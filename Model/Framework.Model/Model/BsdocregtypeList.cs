

using System;
namespace Orm.Model
{
    /// <summary>
    /// 挂号接口 - 实体类
    /// </summary>
    [Serializable]
    public partial class BsdocregtypeList : BaseModel
    {

        private string _locationid;  //排班科室

        private string _regtypeid;  //排班类别

        private string _timespanid;  //排班班次

        private string _mdinfo;  //

        private string _tdinfo;  //

        private string _wdInfo;  //

        private string _tudInfo;  //

        private string _fdinfo;  //

        private string _stdinfo;

        private string _sudinfo;  //

        private string _doctorid;  //

        private int _hospitalId;  //


        /// <summary>
        /// 排班科室
        /// </summary>
        public string Locationid
        {
            get { return _locationid; }
            set { _locationid = value; }
        }

        /// <summary>
        /// 排班类别
        /// </summary>
        public string Regtypeid
        {
            get { return _regtypeid; }
            set { _regtypeid = value; }
        }

        /// <summary>
        /// 排班班次
        /// </summary>
        public string timespanid
        {
            get { return _timespanid; }
            set { _timespanid = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string mdinfo
        {
            get { return _mdinfo; }
            set { _mdinfo = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string tdinfo
        {
            get { return _tdinfo; }
            set { _tdinfo = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string WdInfo
        {
            get { return _wdInfo; }
            set { _wdInfo = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string TudInfo
        {
            get { return _tudInfo; }
            set { _tudInfo = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string fdinfo
        {
            get { return _fdinfo; }
            set { _fdinfo = value; }
        }

        public string Stdinfo
        {
            get { return _stdinfo; }
            set { _stdinfo = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Sudinfo
        {
            get { return _sudinfo; }
            set { _sudinfo = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Doctorid
        {
            get { return _doctorid; }
            set { _doctorid = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int HospitalId
        {
            get { return _hospitalId; }
            set { _hospitalId = value; }
        }

    }
}


