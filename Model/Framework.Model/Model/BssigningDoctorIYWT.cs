using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public class BssigningDoctorIYWT : BaseModel
    {
        private string login_id;
        private string doctorId;
        private int isCancel;


        public string Login_id
        {
            get { return login_id; }
            set { login_id = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string DoctorId
        {
            get { return doctorId; }
            set { doctorId = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int IsCancel
        {
            get { return isCancel; }
            set { isCancel = value; }
        }
    }
}
