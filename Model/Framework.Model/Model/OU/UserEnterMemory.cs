// ===================================================================   
// Model  
// ===================================================================   
// File: CollectPat.cs  
//   
// Copyright   
// History:  
// 2014/12/15 15:32:41: Chen Envision   Original Version  
//   
// ===================================================================  
  
using System;  
  
namespace Orm.Model  
{
    /// <summary>
    /// 用户输入记忆  数据库不存在此表
    /// </summary>
    [Serializable]
    public partial class UserEnterMemory : BaseModel  
    {
        private string _ownerID;
        private string _content = string.Empty;
        private DateTime _modifyTime;
        private int _orderBy = 0;
        private string _source = string.Empty;

        private string _allPYCode = string.Empty;
        private string _firstPYCode = string.Empty;
        private string _wBCode = string.Empty;

        public UserEnterMemory()  
        {  
        }  
  
  
        /// <summary>  
        ///   所属用户ID
        /// </summary>  
        public string OwnerID  
        {
            get { return this._ownerID; }
            set { this._ownerID = value; }  
        }  
  
        /// <summary>  
        ///   内容
        /// </summary>  
        public string Content  
        {
            get { return this._content; }
            set { this._content = value; }  
        }  
  
        /// <summary>  
        ///  最后修改时间
        /// </summary>  
        public DateTime ModifyTime  
        {
            get { return this._modifyTime; }
            set { this._modifyTime = value; }  
        }  
  
        /// <summary>  
        ///  权重排序
        /// </summary>  
        public int OrderBy
        {
            get { return this._orderBy; }
            set { this._orderBy = value; }  
        }

        /// <summary>  
        ///   数据来源
        /// </summary>  
        public string Source
        {
            get { return this._source; }
            set { this._source = value; }
        }  

        /// <summary>
        /// 全拼拼音码
        /// </summary>
        public string AllPYCode
        {
            get { return this._allPYCode; }
            set { this._allPYCode = value; }
        }

        /// <summary>
        /// 拼音首字母
        /// </summary>
        public string FirstPYCode
        {
            get { return this._firstPYCode; }
            set { this._firstPYCode = value; }
        }

        /// <summary>
        /// 五笔码
        /// </summary>
        public string WBCode
        {
            get { return this._wBCode; }
            set { this._wBCode = value; }
        }
  
  
    }  
}  

