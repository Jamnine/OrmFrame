using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public class ElPatForm : BaseModel
    {
        string _patId;
        /// <summary>
        /// 
        /// </summary>
        public string PatId
        {
            get { return _patId; }
            set { _patId = value; }
        }


        string _patMenuId;
        /// <summary>
        /// 对应的档案ID
        /// </summary>
        public string PatMenuId
        {
            get { return _patMenuId; }
            set { _patMenuId = value; }
        }

        string _recId;
        /// <summary>
        /// 对应的档案ID
        /// </summary>
        public string RecId
        {
            get { return _recId; }
            set { _recId = value; }
        }

        string _memo;
        /// <summary>
        /// 其他备注
        /// </summary>
        public string Memo
        {
            get { return _memo; }
            set { _memo = value; }
        }

        DateTime _operTime;
        /// <summary>
        /// 录入时间
        /// </summary>
        public DateTime OperTime
        {
            get { return _operTime; }
            set { _operTime = value; }
        }

        int _operID;
        /// <summary>
        /// 录入人
        /// </summary>
        public int OperID
        {
            get { return _operID; }
            set { _operID = value; }
        }

        int _isAuth;
        /// <summary>
        /// 是否审核
        /// </summary>
        public int IsAuth
        {
            get { return _isAuth; }
            set { _isAuth = value; }
        }

        DateTime _authTime;
        /// <summary>
        /// 审核时间
        /// </summary>
        public DateTime AuthTime
        {
            get { return _authTime; }
            set { _authTime = value; }
        }

        string _rejectReason;
        /// <summary>
        /// 驳回的原因
        /// </summary>
        public string RejectReason
        {
            get { return _rejectReason; }
            set { _rejectReason = value; }
        }

        int _isActive;
        /// <summary>
        /// 是否活动
        /// </summary>
        public int IsActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }

        string _inActiveReason;
        /// <summary>
        /// 非活动的原因
        /// </summary>
        public string InActiveReason
        {
            get { return _inActiveReason; }
            set { _inActiveReason = value; }
        }

        DateTime _inActiveTime;
        /// <summary>
        /// 非活动(迁出或死亡)时间
        /// </summary>
        public DateTime InActiveTime
        {
            get { return _inActiveTime; }
            set { _inActiveTime = value; }
        }

        int _inActiveOperID;
        /// <summary>
        /// 录入非活动的操作者
        /// </summary>
        public int InActiveOperID
        {
            get { return _inActiveOperID; }
            set { _inActiveOperID = value; }
        }

        int _hisType;
        /// <summary>
        /// his类别
        /// </summary>
        public int HisType
        {
            get { return _hisType; }
            set { _hisType = value; }
        }

        DateTime _insertTime;
        /// <summary>
        /// 插入时间
        /// </summary>
        public DateTime InsertTime
        {
            get { return _insertTime; }
            set { _insertTime = value; }
        }
    }
}
