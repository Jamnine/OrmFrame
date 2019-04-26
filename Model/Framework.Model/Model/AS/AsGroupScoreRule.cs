using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model
{
    [Serializable]
    public class AsGroupScoreRule : Basics
    {
        public int ScaleTitleId { get; set; }

        public string Regulation { get; set; }

        public double Score { get; set; }
    }
}
