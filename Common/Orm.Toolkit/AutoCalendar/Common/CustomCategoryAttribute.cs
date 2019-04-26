using System;
using System.ComponentModel;
using System.Runtime;

namespace Orm.Toolkit
{
    internal sealed class CustomCategoryAttribute : CategoryAttribute
    {
        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        internal CustomCategoryAttribute(string name)
            : base(name)
        {
        }

        protected override string GetLocalizedString(string value)
        {
            //if (string.Compare(value, "Content", StringComparison.Ordinal) == 0)
            //{
            //    return System.Windows.SR.Get("DesignerMetadata_CustomCategory_Content");
            //}
            //if (string.Compare(value, "Accessibility", StringComparison.Ordinal) == 0)
            //{
            //    return System.Windows.SR.Get("DesignerMetadata_CustomCategory_Accessibility");
            //}
            //return System.Windows.SR.Get("DesignerMetadata_CustomCategory_Navigation");
            return String.Empty;
        }
    }
}
