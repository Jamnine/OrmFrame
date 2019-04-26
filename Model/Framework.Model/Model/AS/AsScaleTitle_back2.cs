using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model
{
    [Serializable]
    public class AsScaleTitle_back2 : Basics
    {
        public int AsScaleId { get; set; }

        public int TitleGroupId { get; set; }

        public int Title { get; set; }

        public short TitleType { get; set; }

        public double Score { get; set; }

        public bool Required { get; set; }

        public string OrderBy { get; set; }

        public bool IsGroupGrade { get; set; }

        public bool IsRestsGroupValid { get; set; }
    }
}
