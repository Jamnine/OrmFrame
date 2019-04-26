using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Parameter
{
    /// <summary>
    /// 用于一键诊疗web端的新增病人接口
    /// ............................
    /// </summary>
    [Serializable]
    public class PMAddPatient : BaseModel
    {
        private string _name = "";
        private string _sex = "";
        private int _age = 0;
        private DateTime _birthDate;
        private string _mobile = "";
        private string _idCardNo = "";
        private string _locationid;
        private string _userid;
        private string _hostName;
        private string _ip;
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        } 
        /// <summary>
       /// 性别
       /// </summary>
        public string Sex
        {
            get { return _sex; }
            set { _sex = value; }
        }   
        /// <summary>
       /// 年龄（int型）
       /// </summary>
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }  
        /// <summary>
        /// 生日
        /// </summary>
        public DateTime BirthDate
        {
            get { return _birthDate; }
            set { _birthDate = value; }
        }
        /// <summary>
        /// 手机号
        /// </summary>
        public string Mobile
        {
            get { return _mobile; }
            set { _mobile = value; }
        }   
        /// <summary>
        /// 身份证号码
        /// </summary>
        public string IdCardNo
        {
            get { return _idCardNo; }
            set { _idCardNo = value; }
        }
        /// <summary>
        /// 科室ID
        /// </summary>
        public string Locationid
        {
            get { return _locationid; }
            set { _locationid = value; }
        }
        /// <summary>
        /// 用户ID
        /// </summary>
        public string UserID
        {
            get { return _userid; }
            set { _userid = value; }
        }
        /// <summary>
        /// 主机名
        /// </summary>
        public string HostName
        {
            get { return _hostName; }
            set { _hostName = value; }
        }
        /// <summary>
        /// IP地址
        /// </summary>
        public string Ip
        {
            get { return _ip; }
            set { _ip = value; }
        }
    }
}
