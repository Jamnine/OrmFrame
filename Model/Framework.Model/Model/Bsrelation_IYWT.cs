

using System;
using System.Collections.Generic;

namespace Orm.Model
{
    /// <summary>
    /// APP病人关系表 - 实体类
    /// </summary>
    [Serializable]
    public partial class Bsrelation_IYWT : BaseModel
    {
        private string loginId;
        private string name;
        private string sex;
        private string birthday;
        private string country;
        private string nation;
        private string telephone;
        private string social;
        private string address;
        private string relation;
        private int hospitalid;

        /// <summary>
        /// 
        /// </summary>
        public string LoginId
        {
            get { return loginId; }
            set { loginId = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Nation
        {
            get { return nation; }
            set { nation = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Telephone
        {
            get { return telephone; }
            set { telephone = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Social
        {
            get { return social; }
            set { social = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Relation
        {
            get { return relation; }
            set { relation = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int Hospitalid
        {
            get { return hospitalid; }
            set { hospitalid = value; }
        }
    }
}


