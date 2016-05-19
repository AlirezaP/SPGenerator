using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPGenarator
{
    public class RecordInfo
    {
        public string Path { get; set; }
        public string ColName { get; set; }
        public string ColType { get; set; }
        public int? MaxLeng { get; set; }
        public int? OctLeng { get; set; }
        public int? NumericPrecision { get; set; }
        public int? NumericScale { get; set; }
        public int? DateTimePrecision { get; set; }
        public bool IsPrimaryKey { get; set; }
        public bool ISIdentity { get; set; }

    }
    class Generator : Parser
    {
        private RecordInfo _PrimaryKey;
        private RecordInfo[] _Model;
        private string _TableName;

        public string ListPreFix { get; set; } = "Sel";

        public string InsertPreFix { get; set; } = "Inc";

        public string UpdatePreFix { get; set; } = "Upd";

        public string DeletePreFix { get; set; } = "Del";

        public Generator(string tableName, RecordInfo[] reordInfo)
        {
            if (string.IsNullOrEmpty(tableName))
            {
                throw new Exception("TableName Couldnt Be Null!");
            }

            if (reordInfo==null || reordInfo.Length<=0)
            {
                throw new Exception("ReordInfo Couldnt Be Null!");
            }

            _PrimaryKey = reordInfo.Where(p => p.IsPrimaryKey).FirstOrDefault();
            _Model = reordInfo;
            _TableName = tableName;
        }

        public string CreateIns()
        {
            string ins = Query.InsBody
                .Replace("##tbName##", _Model[0].Path)
                .Replace("##col##", GetColumns(_Model, false))
                .Replace("##val##", GetColumnsWithAt(_Model, false));


            string insSP = Query.SpBody
                .Replace("##PreFix##", InsertPreFix)
                .Replace("##tbName##", _TableName)
                .Replace("##param##", GetParametrs(_Model, false))
                .Replace("##body##", ins);

            return insSP;

        }

        public string CreateUpd()
        {
            string upd = Query.UpdBody
                .Replace("##tbName##", _Model[0].Path)
                .Replace("##UPMethod##", AssignVal(_Model, false))
                .Replace("##Condition##", CreateConditionForPrimaryKey(_PrimaryKey));


            string updSP = Query.UpdSpBody
                .Replace("##PreFix##", UpdatePreFix)
                .Replace("##tbName##", _TableName)
                .Replace("##param##", GetParametrs(_Model, true))
                .Replace("##body##", upd);

            return updSP;

        }

        public string CreateList()
        {
            string list = Query.ListBody
                .Replace("##tbName##", _Model[0].Path)
                .Replace("##colName##", GetColumns(_Model, true));


            string selSP = Query.SelSpBody
                .Replace("##PreFix##", ListPreFix)
                .Replace("##tbName##", _TableName)
                .Replace("##param##", "")
                .Replace("##body##", list);

            return selSP;

        }

        public string CreateDel()
        {
            string list = Query.DelBody
                .Replace("##tbName##", _Model[0].Path)
                .Replace("##Condition##", CreateConditionForPrimaryKey(_PrimaryKey));


            string delSP = Query.DelSpBody
                .Replace("##PreFix##", DeletePreFix)
                .Replace("##tbName##", _TableName)
                .Replace("##param##", $"@{RemoveSquareBrackets(_PrimaryKey.ColName)} {_PrimaryKey.ColType}")
                .Replace("##body##", list);

            return delSP;

        }

    }
}
