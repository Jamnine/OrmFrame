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
    public class ElPatFormValue : BaseModel
    {
        int _id;
        /// <summary>
        /// ID
        /// </summary>
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        string _patFormId;
        /// <summary>
        /// PATFORMID
        /// </summary>
        public string PatFormId
        {
            get { return _patFormId; }
            set { _patFormId = value; }
        }

        string _elId;
        /// <summary>
        /// ELID
        /// </summary>
        public string ElId
        {
            get { return _elId; }
            set { _elId = value; }
        }

        string _elValue;
        /// <summary>
        /// 元素值
        /// </summary>
        public string ElValue
        {
            get { return _elValue; }
            set { _elValue = value; }
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

        
        int _classId;
        /// <summary>
        /// 控件类
        /// </summary>
        public int ClassId
        {
            get { return _classId; }
            set { _classId = value; }
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
