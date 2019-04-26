// ===================================================================   
// Model  
// ===================================================================   
// File: LogFieldChanged.cs  
//   
// Copyright   
// History:  
// 2015/4/22 17:11:37: Chen Envision   Original Version  
//   
// ===================================================================  

using System;

namespace Orm.Model
{
    [Serializable]
    /// <summary>  
    ///  
    /// </summary>  
    public partial class LogFieldChanged2 : BaseModel
    {
        private DateTime _operDate;
        private string _operId;
        private string _operName = String.Empty;
        private int _operType;
        private int _tableNum;
        private string _tableDesc = String.Empty;
        private string _operContent = String.Empty;
        private string _operTableName = String.Empty;
        private string _operTableID;
        private string _oldValue = "";
        private string _newValue = "";
        private string _columnName = "";
        private string _operIP = "";
        private string _machineName = "";

        public LogFieldChanged2()
        {
        }


        /// <summary>  
        /// 操作时间  
        /// </summary>  
        public DateTime OperDate { get { return this._operDate; } set { this._operDate = value; } }

        /// <summary>  
        /// 操作员ID  
        /// </summary>  
        public string OperId { get { return this._operId; } set { this._operId = value; } }

        /// <summary>  
        /// 操作员名称  
        /// </summary>  
        public string OperName { get { return this._operName; } set { this._operName = value; } }

        /// <summary>  
        /// 操作类型：1-新增 2-删除 3-修改  
        /// </summary>  
        public int OperType { get { return this._operType; } set { this._operType = value; } }

        /// <summary>  
        /// 操作的表的序号 1-Bsitem  
        /// </summary>  
        public int TableNum { get { return this._tableNum; } set { this._tableNum = value; } }

        /// <summary>  
        /// 操作的表的描述  
        /// </summary>  
        public string TableDesc { get { return this._tableDesc; } set { this._tableDesc = value; } }

        /// <summary>  
        /// 操作内容  
        /// </summary>  
        public string OperContent { get { return this._operContent; } set { this._operContent = value; } }

        /// <summary>  
        /// 操作的表的名称  
        /// </summary>  
        public string OperTableName { get { return this._operTableName; } set { this._operTableName = value; } }

        /// <summary>
        /// 操作表的ID
        /// </summary>
        public string OperTableID { get { return this._operTableID; } set { this._operTableID = value; } }

        /// <summary>  
        /// 修改前值  
        /// </summary>  
        public string OldValue { get { return this._oldValue; } set { this._oldValue = value; } }

        /// <summary>  
        /// 修改后值  
        /// </summary>  
        public string NewValue { get { return this._newValue; } set { this._newValue = value; } }

        /// <summary>  
        /// 列名  
        /// </summary>  
        public string ColumnName { get { return this._columnName; } set { this._columnName = value; } }

        /// <summary>  
        /// 操作IP  
        /// </summary>  
        public string OperIP { get { return this._operIP; } set { this._operIP = value; } }

        /// <summary>  
        /// 机器名 
        /// </summary>  
        public string MachineName { get { return this._machineName; } set { this._machineName = value; } }
    }
}
