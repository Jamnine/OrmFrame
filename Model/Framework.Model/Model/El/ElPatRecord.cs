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
    public class ElPatRecord : BaseModel
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

        int _hospitalID;
        /// <summary>
        /// 医院ID
        /// </summary>
        public int HospitalID
        {
            get { return _hospitalID; }
            set { _hospitalID = value; }
        }
        
        string _groupId;
        /// <summary>
        /// 对应的档案ID
        /// </summary>
        public string GroupId
        {
            get { return _groupId; }
            set { _groupId = value; }
        }
       
        string _recNo;
        /// <summary>
        /// 档案号
        /// </summary>
        public string RecNo
        {
            get { return _recNo; }
            set { _recNo = value; }
        }

        string _memo;
        /// <summary>
        /// 备注
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

        int _lsType;
        /// <summary>
        /// 活动类别：1-专案登记；2-问询记录；3-体格检查；4-检验；5-物理检查；6-影像检查；7-医学指导；8-医学指导；9-评估报告；10-随访记录；11-诊断记录；12-手术记录；13-麻醉记录；14-其他治疗记录；15-分娩记录
        /// </summary>
        public int LsType
        {
            get { return _lsType; }
            set { _lsType = value; }
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
