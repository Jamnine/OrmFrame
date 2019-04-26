using System;
using Orm.Toolkit.Telerik.Windows.Controls.Scheduler;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
    /// <summary>
    /// View definition used for all day appointment presentation.
    /// </summary>
    internal class SingleMonthWeekViewDefinition : MonthViewDefinition
    {
        private ViewDefinitionBase activeViewDefinition;

        public SingleMonthWeekViewDefinition(ViewDefinitionBase activeViewDefinition)
        {
            this.ActiveViewDefinition = activeViewDefinition;
        }

        public override DateTimeInterval LargeChangeInterval
        {
            get
            {
                return this.ActiveViewDefinition.LargeChangeInterval;
            }
            set
            {
            }
        }

        public override DateTimeInterval SmallChangeInterval
        {
            get
            {
                return this.ActiveViewDefinition.SmallChangeInterval;
            }
            set
            {
            }
        }

        public override int VisibleDays
        {
            get
            {
                return this.ActiveViewDefinition.VisibleDays;
            }
            set
            {
            }
        }

        /// <summary>
        /// Gets or sets the active view.
        /// </summary>
        /// <value>The active view.</value>
        /// <exception cref="ArgumentNullException">value</exception>
        public ViewDefinitionBase ActiveViewDefinition
        {
            get
            {
                return this.activeViewDefinition;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }

                if (value != this.activeViewDefinition)
                {
                    this.activeViewDefinition = value;
                }
            }
        }
    }
}