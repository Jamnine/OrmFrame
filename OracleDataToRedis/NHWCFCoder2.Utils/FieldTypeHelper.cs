using System;
using System.Collections.Generic;
using System.Text;

namespace OracleDataToRedis.Utils
{
    public class FieldTypeHelper
    {
        public static string ChangeToFieldType(string dataType)
        {
            switch (DataBaseHelper.CurrentDbType)
            {
                case DataBaseType.Oracle9:
                    return FieldTypeHelper.ChangeToOracleCSharpType(dataType);
                case DataBaseType.SqlServer2005:
                case DataBaseType.SqlServer2008:
                    return FieldTypeHelper.ChangeToSqlServerCSharpType(dataType);
                default:
                    return FieldTypeHelper.ChangeToSqlServerCSharpType(dataType);
            }
        }

        /// <summary>
        /// 需要排除的字段
        /// </summary>
        /// <param name="dc">列对象</param>
        /// <param name="dt">表对象</param>
        /// <returns>是，否</returns>
        public static bool IsNoCreateColumn(string fieldParamCaseName)
        {
            if (fieldParamCaseName.ToLower() == "dataversion"
                || fieldParamCaseName.ToLower() == "datacreatetime")
            {
                return true;
            }
            return false;
        }

        public static string ChangeToSqlServerCSharpType(string type)
        {
            string reval = string.Empty;
            switch (type.ToLower())
            {
                case "int": reval = "Int32?"; break;
                case "text": reval = "String"; break;
                case "bigint": reval = "Int64?"; break;
                case "binary": reval = "Byte[]"; break;
                case "bit": reval = "Boolean"; break;
                case "char": reval = "String"; break;
                case "datetime": reval = "DateTime?"; break;
                case "decimal": reval = "Decimal?"; break;
                case "float": reval = "Double?"; break;
                case "image": reval = "Byte[]"; break;
                case "money": reval = "Decimal?"; break;
                case "nchar": reval = "String"; break;
                case "ntext": reval = "String"; break;
                case "numeric": reval = "Decimal?"; break;
                case "nvarchar": reval = "String"; break;
                case "real": reval = "Single"; break;
                case "smalldatetime": reval = "DateTime?"; break;
                case "smallint": reval = "Int16?"; break;
                case "smallmoney": reval = "Decimal?"; break;
                case "timestamp": reval = "DateTime?"; break;
                case "tinyint": reval = "Byte"; break;
                case "uniqueidentifier": reval = "Guid"; break;
                case "varbinary": reval = "Byte[]"; break;
                case "varchar": reval = "String"; break;
                case "Variant": reval = "Object"; break;
                default: reval = "String"; break;
            }
            return reval;
        }

        public static string ChangeToOracleCSharpType(string type)
        {
            string reval = string.Empty;
            switch (type.ToUpper())
            {
                case "VARCHAR2": reval = "String"; break;
                case "INT": reval = "Int32?"; break;
                case "BFILE": reval = "Byte[]"; break;
                case "BLOB": reval = "Byte[]"; break;
                case "CHAR": reval = "String"; break;
                case "CLOB": reval = "String"; break;
                case "DATE": reval = "DateTime?"; break;
                case "FLOAT": reval = "Decimal?"; break;
                case "INTEGER": reval = "Decimal?"; break;
                case "LONG": reval = "String"; break;
                case "LONG RAW": reval = "Byte[]"; break;
                case "NCHAR": reval = "String"; break;
                case "NCLOB": reval = "String"; break;
                case "NUMBER": reval = "Decimal?"; break;
                case "NVARCHAR2": reval = "String"; break;
                case "RAW": reval = "Byte[]"; break;
                case "ROWID": reval = "String"; break;
                case "TIMESTAMP": reval = "DateTime?"; break;
                case "UNSIGNED INTEGER": reval = "Decimal?"; break;
                case "INTERVAL YEAR TO MONTH": reval = "Int32?"; break;
                case "INTERVAL DAY TO SECOND": reval = "TimeSpan?"; break;
                case "TIMESTAMP WITH TIME ZONE": reval = "DateTime?"; break;
                case "TIMESTAMP WITH LOCAL TIME ZONE": reval = "DateTime?"; break;
                
                case "DECIMAL": reval = "Decimal?"; break;
                case "REAL": reval = "Decimal?"; break;

                default: reval = "String"; break;
            }
            return reval;
        }
    }
}
