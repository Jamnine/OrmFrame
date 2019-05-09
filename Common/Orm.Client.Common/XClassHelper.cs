using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using Orm.Model.Custom;

namespace Orm.Client.Common
{
    public class XClassHelper
    {
        public static bool UserControlLoadCurrentPatientIsNull(uspHisOuPatientQry currentPatient, object parameter)
        {
            if (currentPatient == null)
            {
                if (parameter != null)
                {
                    if (parameter is UserControl)
                    {
                        UserControl uControl = parameter as UserControl;
                        (uControl.Parent as Panel).Children.Remove(uControl);
                    }
                    else if (parameter is System.Windows.FrameworkElement)
                    {
                        System.Windows.FrameworkElement frameworkElement = (parameter as System.Windows.FrameworkElement);
                        if (frameworkElement.Parent is Panel)
                        {
                            (frameworkElement.Parent as Panel).Children.Remove(frameworkElement);
                        }
                    }
                }

                //Orm.Client.Base.FrmMessageRemind.Show("请先选择病人！", "系统提示");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
