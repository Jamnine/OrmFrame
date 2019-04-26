using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Custom.UspModel
{
    [Serializable]
    public class UspGetDocRegType
    {
        public string GUID { get; set; }

        public Int32 HasDiagNum { get; set; }

        public Int32 WaitDiagNum { get; set; }

        public String Name { get; set; }

        public String Sex { get; set; }

        public String LocationName { get; set; }

        public String RegType { get; set; }

        public string TimeSpanId { get; set; }

        public string TimeSpanName { get; set; }

        public string WeekTime { get; set; }

        public Int32 WeekDay { get; set; }

        public Boolean IsActive { get; set; }

        public Int32 LimitNum { get; set; }

        public DateTime LastLimitDate { get; set; }

        public Int32 LastLimitNum { get; set; }

        public string DoctorId { get; set; }

        public string LocationId { get; set; }

        public string RegTypeId { get; set; }

        public String TimeBegin { get; set; }

        public String TimeEnd { get; set; }

        public String RoomNo { get; set; }

        public String MDInfo { get; set; }

        public String TDInfo { get; set; }

        public String WDInfo { get; set; }

        public String TUDInfo { get; set; }

        public String FDInfo { get; set; }

        public String STDInfo { get; set; }

        public String SUDInfo { get; set; }
    }
}
