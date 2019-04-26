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

namespace Orm.Toolkit.Telerik.Windows.Controls
{
    /// <summary>
    /// Extension methods for <see cref="IResource"/> class.
    /// </summary>
    public static class IResourceExtensions
    {
        internal static bool IsEqualTo(this IResource resource, IResource target)
        {
            if (target == null)
            {
                return false;
            }
            return resource.ResourceName == target.ResourceName && resource.ResourceType == target.ResourceType;
        }
    }
}
