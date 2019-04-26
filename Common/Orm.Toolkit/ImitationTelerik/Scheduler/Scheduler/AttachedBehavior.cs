namespace Orm.Toolkit.Telerik.Windows.Controls.Scheduler
{
    /// <summary>
    /// Base class for attached behaviors.
    /// </summary>
    public abstract class AttachedBehavior
    {
        /// <summary>
        /// Gets a value indicating whether this behavior is currently attached.
        /// </summary>
        /// <value>
        /// 	<c>True</c> if this instance is attached; otherwise, <c>false</c>.
        /// </value>
        public bool IsAttached { get; private set; }

        /// <summary>
        /// Attach the behavior.
        /// </summary>
        public virtual void Attach()
        {
            this.IsAttached = true;
        }

        /// <summary>
        /// Detach the behavior.
        /// </summary>
        public virtual void Detach()
        {
            this.IsAttached = false;
        }
    }
}