using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model
{
    [Serializable]
    public class ToothCaseContentType : BaseModel
    {
        public string Name { get; set; }

        /// <summary>
        /// 疾病类别，
        /// </summary>
        public string TypeName { get; set; }

        public int OrderBy { get; set; }
    }
}
