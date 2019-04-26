
namespace Orm.Toolkit.Telerik.Windows.Controls.Scheduler
{
    /// <summary>
    /// Specifies the actions which can be performed over exceptions of appointments.
    /// </summary>
    public enum ExceptionAction
    {
        /// <summary>
        /// Indicates that nothing has been performed over exceptions.
        /// </summary>
        None,

        /// <summary>
        /// Indicates that exception has been added.
        /// </summary>
        Add,

        /// <summary>
        /// Indicates that exception has been removed.
        /// </summary>
        Delete,
        
        /// <summary>
        /// Indicates that exception has been edited.
        /// </summary>
        Edit
    }
}