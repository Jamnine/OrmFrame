using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Orm.Toolkit.Primitives
{
    [TemplatePart(Name=ItemsPanelName,Type=typeof(Panel))]
    [TemplatePart(Name=CenteringTransformName,Type=typeof(TranslateTransform))]
   public class LoopingSelector : Control
   {
       //模板命名部分
       private const string ItemsPanelName = "ItemsPanel";
       private const string CenteringTransformName = "CenteringTransform";
       private const string PanningTransformName = "PanningTransform";



   }
}
