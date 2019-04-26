using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Orm.Toolkit.Telerik.Windows.Controls.Scheduler
{
    /// <summary>
    /// Control containing headers arranged over resource groups.
    /// </summary>
    public class ResourceHeaderControl : ContentControl
    {
        /// <summary>
        /// When overridden in a derived class, is invoked whenever application code or internal processes (such as a rebuilding layout pass) call <see cref="M:System.Windows.Controls.Control.ApplyTemplate"/>.
        /// </summary>
        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
			var scheduler = this.GetVisualParent<RadScheduler>();
            var group = this.DataContext as ResourceGroup;
			if (group != null && scheduler != null && group.ResourceStyleMapping != null)
            {
				if (scheduler.ViewMode == SchedulerViewMode.Timeline)
                {
                    if (group.ResourceStyleMapping.VerticalHeaderTemplate != null)
                    {
                        this.ContentTemplate = group.ResourceStyleMapping.VerticalHeaderTemplate;
                    }
                }
                else
                {
                    if (group.ResourceStyleMapping.HeaderTemplate != null)
                    {
                        this.ContentTemplate = group.ResourceStyleMapping.HeaderTemplate;
                    }
                }
            }
        }
    }
}
