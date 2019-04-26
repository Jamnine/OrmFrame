using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Orm.Toolkit
{

    [TemplatePart(Name = "CNT", Type = typeof(Control))]
    [TemplatePart(Name = "MASK", Type = typeof(Border))]
    public class ImitateIndicator : ContentControl
    {

        public static DependencyProperty TextProperty = DependencyProperty.Register("Text", typeof(string), typeof(ImitateIndicator), new PropertyMetadata("Waiting..."));
        public static DependencyProperty MaskTypeProperty = DependencyProperty.Register("MaskType", typeof(MaskTypes), typeof(ImitateIndicator), new PropertyMetadata(MaskTypes.Adorned));
        public static DependencyProperty ContentControlTemplateProperty = DependencyProperty.Register("ContentControlTemplate", typeof(ControlTemplate), typeof(ImitateIndicator));

        public string Text
        {
            get
            {
                return (string)this.GetValue(TextProperty);
            }
            set
            {
                this.SetValue(TextProperty, value);
            }
        }

        public MaskTypes MaskType
        {
            get
            {
                return (MaskTypes)this.GetValue(MaskTypeProperty);
            }
            set
            {
                this.SetValue(MaskTypeProperty, value);
            }
        }

        public ControlTemplate ContentControlTemplate
        {
            get
            {
                return (ControlTemplate)this.GetValue(ContentControlTemplateProperty);
            }
            set
            {
                this.SetValue(ContentControlTemplateProperty, value);
            }
        }

        static ImitateIndicator()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ImitateIndicator), new FrameworkPropertyMetadata(typeof(ImitateIndicator)));
        }

        public ImitateIndicator()
        {
            this.DataContext = this;
        }
        public override void OnApplyTemplate()
        {
            var mask = this.Template.FindName("MASK", this) as Border;
            mask.Visibility = this.MaskType != MaskTypes.None ? Visibility.Visible : Visibility.Collapsed;
            if (this.ContentControlTemplate != null)
            {
                var tp = this.Template.FindName("CNT", this) as Control;
                tp.Template = this.ContentControlTemplate;
            }
        }
    }
}
