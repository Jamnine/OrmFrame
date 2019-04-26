using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom.UspModel
{
    /// <summary>
    /// 体检项目查询组合
    /// </summary>
    [Serializable]
    public class uspPhysicalTestQuery : BaseModel
    {
        public uspPhysicalTestQuery()
        {

        }

        private string _patName = string.Empty;
        /// <summary>
        /// 名字
        /// </summary>
        public string PatName
        {
            get { return _patName; }
            set { _patName = value; }
        }

        private string _sex = string.Empty;
        /// <summary>
        /// 性别
        /// </summary>
        public string Sex
        {
            get { return _sex; }
            set { _sex = value; }
        }

        private string _age = string.Empty;
        /// <summary>
        /// 年龄
        /// </summary>
        public string Age
        {
            get { return _age; }
            set { _age = value; }
        }

        private string _vipCardNo= string.Empty;
        /// <summary>
        /// 会员卡号
        /// </summary>
        public string VipCardNo
        {
            get { return _vipCardNo; }
            set { _vipCardNo = value; }
        }

        private string _vipLevel = string.Empty;
        /// <summary>
        /// 会员卡号
        /// </summary>
        public string VipLevel
        {
            get { return _vipLevel; }
            set { _vipLevel = value; }
        }

        private string _itemName = string.Empty;
        /// <summary>
        /// 项目名称
        /// </summary>
        public string ItemName
        {
            get { return _itemName; }
            set { _itemName = value; }
        }

        private string _locationName = string.Empty;
        /// <summary>
        /// 项目科室
        /// </summary>
        public string LocationName
        {
            get { return _locationName; }
            set { _locationName = value; }
        }

        private string _testResult = string.Empty;
        /// <summary>
        /// 体检结果
        /// </summary>
        public string TestResult
        {
            get { return _testResult; }
            set { _testResult = value; }
        }

        private DateTime _testDate = DateTime.MinValue;
        /// <summary>
        /// 体检结果
        /// </summary>
        public DateTime TestDate
        {
            get { return _testDate; }
            set { _testDate = value; }
        }

        private DateTime _inputDate = DateTime.MinValue;
        /// <summary>
        /// 输入结果
        /// </summary>
        public DateTime InputDate
        {
            get { return _inputDate; }
            set { _inputDate = value; }
        }

        private bool _isOver = false;
        /// <summary>
        /// 是否完成
        /// </summary>
        public bool IsOver
        {
            get { return _isOver; }
            set { _isOver = value; }
        }

        private string _testDoctor = string.Empty;
        /// <summary>
        /// 体检医生
        /// </summary>
        public string TestDoctor
        {
            get { return _testDoctor; }
            set { _testDoctor = value; }
        }

        private string _mzRegID ;
        /// <summary>
        /// 门诊挂号ID
        /// </summary>
        public string MzRegID
        {
            get { return _mzRegID; }
            set { _mzRegID = value; }
        }

        private string _phone = string.Empty;
        /// <summary>
        /// 电话
        /// </summary>
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        private bool _isGroup = false;
        /// <summary>
        /// 是否同组
        /// </summary>
        public bool IsGroup
        {
            get { return _isGroup; }
            set { _isGroup = value; }
        }

    }
}
