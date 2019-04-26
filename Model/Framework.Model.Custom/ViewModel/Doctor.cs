using System;
using Orm.Toolkit.Telerik.Windows.Controls;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 医生资源类，用于RadScheduler控件的日模式的医生分组
    /// </summary>
    [Serializable]
    public class Doctor : Resource
    {
        public Doctor()
		{
		}

        public Doctor(int id, string name, string diagRoomName, bool isSeleted = false)
        {
            ResourceName = id.ToString(); 
            DoctorName = name;
            DiagRoomName = diagRoomName;
            IsSelected = isSeleted;
        }
        /// <summary>
        /// 是否选择
        /// </summary>
        public bool IsSelected { get; set; }
    }
}
