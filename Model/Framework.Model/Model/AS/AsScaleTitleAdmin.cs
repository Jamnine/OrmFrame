using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model
{
    [Serializable]
    public class AsScaleTitleAdmin : Basics
    {
        public int AssessmentId { get; set; }

        public int TitleId { get; set; }

        public string CheckedItemId { get; set; }

        public string TitleAnsr { get; set; }
    }
}
