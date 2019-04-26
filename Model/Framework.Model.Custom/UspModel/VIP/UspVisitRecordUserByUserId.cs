using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom.UspModel
{
    [Serializable]
    public class UspVisitRecordUserByUserId:BaseModel
    { 
        public bool IsSelected { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }
         
        public string Mobile { get; set; }

        public string UserId { get; set; }

        public string DoctorId { get; set; }

        public int LsUserRole { get; set; }
    }
}

