using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Orm.Toolkit.Telerik.Windows.Controls;

namespace Orm.Model.Custom
{
    [Serializable]
    /// <summary>
    /// 诊室资源类，用于RadScheduler控件的日模式的医生分组
    /// </summary>
    public class DiogRoom : Resource
    {
        public DiogRoom()
        {

        }
        public DiogRoom(int diagId, string diagRoomName)
        {
            ResourceName = diagId.ToString();
            DoctorName = diagRoomName;
            DiagRoomName = diagRoomName;
        }
    }
}
