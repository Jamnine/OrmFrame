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
    public class Admin : Basics
    {
        public string Name { get; set; }

        public short Sex { get; set; }

        public string Phone { get; set; }

        public string PIC { get; set; }

        public string Password { get; set; }

        public short Type { get; set; }

        public int OrganizationId { get; set; }

        public int RoleId { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime CloseTime { get; set; }

        public DateTime LastTime { get; set; }

        public int OperId { get; set; }

        public string Address { get; set; }

        public string Qualifications { get; set; }
    }
}
