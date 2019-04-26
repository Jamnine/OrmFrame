
namespace Orm.Toolkit.Telerik.Windows.Controls.Scheduler
{
    /// <summary>
    /// Specifies the actions which can be performed over editing of appointments.
    /// </summary>
    public enum AppointmentEditAction
    {
        /// <summary>
        /// Indicates that appointment is being edited by clicking.
        /// </summary>
        Edit,

        /// <summary>
        /// Indicates that appointment is being edited inline.
        /// </summary>
        EditInline,

        /// <summary>
        /// Indicates that appointment is being edited by dragging.
        /// </summary>
        Drag,

        /// <summary>
        /// Indicates that appointment is being edited by resizing.
        /// </summary>
        Resize
    }
}