using System;
using System.Linq;

namespace SPGenarator
{
    class Parser
    {
        protected string GetColumns(RecordInfo[] model, bool IncludeIdentity)
        {
            string temp = "";
            RecordInfo[] data;

            if (!IncludeIdentity)
            {
                data = model.Where(p => p.ISIdentity == false).ToArray();
            }
            else
            {
                data = model;
            }

            for (int i = 0; i < data.Length; i++)
            {
                temp += (data[i].ColName);

                if (i != data.Length - 1)
                {
                    temp += ",";
                }
            }

            return temp;
        }

        protected string GetColumnsWithAt(RecordInfo[] model, bool IncludeIdentity)
        {
            string temp = "";

            RecordInfo[] data;

            if (!IncludeIdentity)
            {
                data = model.Where(p => p.ISIdentity == false).ToArray();
            }
            else
            {
                data = model;
            }


            for (int i = 0; i < data.Length; i++)
            {
                temp += ("@" + RemoveSquareBrackets(data[i].ColName.Replace(" ", "_")));

                if (i != data.Length - 1)
                {
                    temp += ",";
                }
            }

            return temp;
        }

        protected string GetParametrs(RecordInfo[] model, bool IncludeIdentity)
        {
            string temp = "";

            RecordInfo[] data;

            if (!IncludeIdentity)
            {
                data = model.Where(p => p.ISIdentity == false).ToArray();
            }
            else
            {
                data = model;
            }

            for (int i = 0; i < data.Length; i++)
            {
                string tt = "";

                if(IsSensitiveRange(data[i].ColType))
                {
                    tt = data[i].ColType + GetFieldsRange(data[i]);
                }
                else
                {
                    tt = data[i].ColType;
                }

                temp += (("@" + RemoveSquareBrackets(data[i].ColName.Replace(" ", "_"))) + " " + tt);

                if (i < data.Length - 1)
                {
                    temp += ",";
                }
            }

            return temp;
        }

        protected string AssignVal(RecordInfo[] model, bool IncludeIdentity)
        {
            string temp = "";

            RecordInfo[] data;

            if (!IncludeIdentity)
            {
                data = model.Where(p => p.ISIdentity == false).ToArray();
            }
            else
            {
                data = model;
            }

            for (int i = 0; i < data.Length; i++)
            {
                temp += ($"{data[i].ColName} = @{RemoveSquareBrackets(data[i].ColName.Replace(" ", "_"))}");

                if (i != data.Length - 1)
                {
                    temp += ",";
                }
                temp += Environment.NewLine;
            }

            return temp;
        }
        
        protected bool IsSensitiveRange(string type)
        {
            switch (type)
            {
                case "nchar":return true;
                case "nvarchar": return true;
                case "varchar": return true;
                case "binary": return true;
                case "varbinary": return true;
                case "char": return true;
                case "datetime2": return true;
                case "datetimeoffset": return true;
                case "decimal": return true;
                case "numeric": return true;
                case "time": return true;
                default: return false;
            }
        }

        protected string GetFieldsRange(RecordInfo field)
        {
            if (field.MaxLeng != -2 && field.MaxLeng!=-1)
            {
                return $"({field.MaxLeng.ToString()})";
            }

            if (field.NumericPrecision != -2 && field.NumericScale != 2)
            {
                return $"({field.NumericPrecision.ToString()},{field.NumericScale.ToString()})";
            }

            if (field.NumericPrecision != -2 && field.NumericPrecision != -1)
            {
                return $"({field.NumericPrecision.ToString()})";
            }

            if (field.DateTimePrecision != -2 && field.DateTimePrecision != -1)
            {
                return $"({field.DateTimePrecision.ToString()})";
            }


            return "(max)";
        }

        protected string CreateConditionForPrimaryKey(RecordInfo primaryKey) =>
             $"where {primaryKey.ColName} = @{RemoveSquareBrackets(primaryKey.ColName.Replace(" ", "_"))}";


        protected string RemoveSquareBrackets(string str) =>
          str.Replace("[", "").Replace("]", "");
    }
}
