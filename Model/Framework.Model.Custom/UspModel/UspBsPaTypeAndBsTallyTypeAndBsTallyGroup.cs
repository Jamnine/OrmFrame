using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYHis.Model.Custom
{
    [Serializable]
    public class UspBsPaTypeAndBsTallyTypeAndBsTallyGroup
    {
        public string GUID { get; set; }
        public string Name { get; set; }
        public double DiscDiag { get; set; }
        public double DiscIn { get; set; }
        public int LsGFPatType { get; set; }
        public object LsGFPatTypeName { get; set; }
        public string TallyTypeId { get; set; }
        public string TallyTypeName { get; set; }
        public string TallyGroupId { get; set; }
        public string TallyGroupName { get; set; }
        public bool IsGf { get; set; }
        public double ArrearAmount { get; set; }
        public bool IsYb { get; set; }
    }
}
