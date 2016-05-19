using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace SPGenarator
{
    class SqlHelper : IDisposable
    {
        SqlConnection connection;
        private string _dbName = "";
        private List<string> _tbName;
        private string _connectionString = "";
        public SqlHelper(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString))
            {
                throw new Exception("Connection String Couldnt Be Null!");
            }

            _connectionString = connectionString;
            connection = new SqlConnection(connectionString);
            connection.Open();
            FindDatabaseName();
        }
        public void FindDatabaseName()
        {

            _dbName =
                _connectionString.Substring
                (_connectionString.IndexOf("Catalog="), _connectionString.Length - _connectionString.IndexOf("Catalog="))
                .Split(';')[0]
                .Split('=')[1];

        }

        public List<string> GetTableName()
        {
            SqlCommand commnad = new SqlCommand("USE " + _dbName + Environment.NewLine + @" SELECT * FROM sys.Tables", connection);

            //connection.Open();
            SqlDataReader reader = commnad.ExecuteReader();

            _tbName = new List<string>();
            while (reader.Read())
            {
                _tbName.Add(reader[0].ToString());
            }
            reader.Close();

            //connection.Close();

            return _tbName;
        }

        public List<RecordInfo> GetRecordInfo(string table)
        {
            bool isIdentity = false;
            bool isPrimaryKey = false;
            string columnName = "";
            string path = "";
            string[] idCol = IdentityColName(table);
            string primaryKey = GetPrimaryColName(table);
            List<RecordInfo> obj = new List<RecordInfo>();

            SqlCommand commnad = new SqlCommand("SELECT * FROM " + _dbName + ".INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = N'" + table + "'", connection);
            //connection.Open();

            SqlDataReader reader = commnad.ExecuteReader();
            while (reader.Read())
            {
                isIdentity = false;
                isPrimaryKey = false;

                path = $"[{reader[0]}].[{reader[1]}].[{reader[2]}]";

                if (idCol.Contains((reader[3].ToString())))
                {
                    isIdentity = true;
                }

                columnName = reader[3].ToString();

                if (columnName == primaryKey)
                {
                    isPrimaryKey = true;
                }

                columnName = $"[{reader[3].ToString()}]";

                obj.Add(new RecordInfo
                {
                    ColName = columnName,
                    ColType = reader[7].ToString(),
                    MaxLeng = (reader[8].ToString() == "") ? -2 : int.Parse(reader[8].ToString()),
                    OctLeng = (reader[9].ToString() == "") ? -2 : int.Parse(reader[9].ToString()),
                    NumericPrecision = (reader[10].ToString() == "") ? -2 : int.Parse(reader[10].ToString()),
                    NumericScale = (reader[12].ToString() == "") ? -2 : int.Parse(reader[12].ToString()),
                    DateTimePrecision = (reader[13].ToString() == "") ? -2 : int.Parse(reader[13].ToString()),
                    Path = path,
                    ISIdentity = isIdentity,
                    IsPrimaryKey = isPrimaryKey
                });

            }

            reader.Close();
            //connection.Close();

            return obj;
        }

        public string[] IdentityColName(string table)
        {
            List<string> res = new List<string>();

            string cmd = "select top 1 * from INFORMATION_SCHEMA.COLUMNS where TABLE_SCHEMA = 'dbo' and COLUMNPROPERTY(object_id(TABLE_NAME), COLUMN_NAME, 'IsIdentity') = 1 and TABLE_NAME='" + table + "'";

            SqlCommand commnad = new SqlCommand(cmd, connection);

            //connection.Open();

            SqlDataReader reader = commnad.ExecuteReader();
            while (reader.Read())
            {
                res.Add(reader[3].ToString());
            }
            reader.Close();

            //connection.Close();

            return res.ToArray();
        }

        public string GetPrimaryColName(string table)
        {
            string cmd =
@"SELECT COLUMN_NAME
FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE
WHERE OBJECTPROPERTY(OBJECT_ID(CONSTRAINT_SCHEMA + '.' + CONSTRAINT_NAME), 'IsPrimaryKey') = 1
AND TABLE_NAME = '" + table + "'--AND TABLE_SCHEMA = 'Schema'";

            SqlCommand commnad = new SqlCommand(cmd, connection);

            //connection.Open();
            SqlDataReader reader = commnad.ExecuteReader();
            string temp = "";

            reader.Read();

            temp = (reader[0].ToString());

            reader.Close();

            //connection.Close();

            return temp;
        }

        public void Execute(string command)
        {
            var commnad = new SqlCommand(command, connection);
            //connection.Open();
            commnad.ExecuteNonQuery();
            //connection.Close();
        }

        public void Dispose()
        {
            connection.Close();
        }
    }
}
