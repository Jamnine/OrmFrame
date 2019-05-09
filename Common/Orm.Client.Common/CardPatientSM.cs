using System;
using System.Collections.Generic;
using System.Text;

namespace Orm.Client.Common
{
    public class CardPatientSM
    {
        private string _name;
        private string _sex;
        private DateTime _birthDate;
        private string _idCardNo;
        private string _nation;
        private string _birthAddress;
        //private string _committee;

        //private string _addressHome;
        //private string _addressHomeb;
       
        public CardPatientSM()
        {
        }

        /// <summary>
        ///姓名
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        /// <summary>
        /// 身份证号码
        /// </summary>
        public string IdCardNo
        {
            get
            {
                return _idCardNo;
            }
            set
            {
                _idCardNo = value;
            }
        }

        /// <summary>
        /// 性别
        /// </summary>
        public string Sex
        {
            get
            {
                return _sex;
            }
            set
            {
                _sex = value;
            }
        }

        /// <summary>
        /// 出生日期
        /// </summary>
        public DateTime BirthDate
        {
            get
            {
                return _birthDate;
            }
            set
            {
                _birthDate = value;
            }
        }

        /// <summary>
        /// 民族
        /// </summary>
        public string Nation
        {
            get
            {
                return _nation;
            }
            set
            {
                _nation = value;
            }
        }

        /// <summary>
        /// 出生地
        /// </summary>
        public string BirthAddress
        {
            get
            {
                return _birthAddress;
            }
            set
            {
                _birthAddress = value;
            }
        }
    }
}
