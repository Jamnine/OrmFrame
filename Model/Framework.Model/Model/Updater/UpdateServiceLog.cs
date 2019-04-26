// ===================================================================   
// Model  
// ===================================================================   
// File: UpdateServiceLog.cs  
//   
// Copyright   
// History:  
// 2015/8/28 11:16:40: Chen Envision   Original Version  
//   
// ===================================================================  

using System;

namespace Orm.Model
{
    /// <summary>  
    ///  更新服务日志
    /// </summary> 
    [Serializable]
   
    public partial class UpdateServiceLog : BaseModel
    {
        private int _customId;
        private int _upVersionId;
        private DateTime _updateTime;
        private int _sqlScriptId;
        private bool _isUpdateSuccess;
        private string _memo = String.Empty;
        private int _updateVersionNum;

        public UpdateServiceLog()
        {
        }


        /// <summary>  
        /// 客户ID  
        /// </summary>  
        public int CustomId
        {
            get { return this._customId; }
            set { this._customId = value; }
        }

        /// <summary>  
        /// 更新的版本id  
        /// </summary>  
        public int UpVersionId
        {
            get { return this._upVersionId; }
            set { this._upVersionId = value; }
        }

        /// <summary>  
        /// 更新时间  
        /// </summary>  
        public DateTime UpdateTime
        {
            get { return this._updateTime; }
            set { this._updateTime = value; }
        }

        /// <summary>  
        /// SQL脚本ID  
        /// </summary>  
        public int SqlScriptId
        {
            get { return this._sqlScriptId; }
            set { this._sqlScriptId = value; }
        }

        /// <summary>  
        /// 是否更新成功  
        /// </summary>  
        public bool IsUpdateSuccess
        {
            get { return this._isUpdateSuccess; }
            set { this._isUpdateSuccess = value; }
        }

        /// <summary>  
        /// 出错的原因  
        /// </summary>  
        public string Memo
        {
            get { return this._memo; }
            set { this._memo = value; }
        }

        /// <summary>  
        /// 更新的版本号  
        /// </summary>  
        public int UpdateVersionNum
        {
            get { return this._updateVersionNum; }
            set { this._updateVersionNum = value; }
        }

    }
}
