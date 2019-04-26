using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Orm.Toolkit
{
    public class NumberTextBox : System.Windows.Controls.TextBox
    {

        static NumberTextBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(NumberTextBox), new FrameworkPropertyMetadata(typeof(NumberTextBox)));
         }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            TextBox txt = this;
            //屏蔽非法按键
            if ((e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9) || e.Key == Key.Decimal || e.Key.ToString() == "Tab")
            {
                if (txt.Text.Contains(".") && e.Key == Key.Decimal)
                {
                    e.Handled = true;
                    return;
                }
                e.Handled = false;
            }
            else if (((e.Key >= Key.D0 && e.Key <= Key.D9) || e.Key == Key.OemPeriod) && e.KeyboardDevice.Modifiers != ModifierKeys.Shift)
            {
                if (txt.Text.Contains(".") && e.Key == Key.OemPeriod)
                {
                    e.Handled = true;
                    return;
                }
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                if (e.Key.ToString() != "RightCtrl")
                {
                    //MessageBox.Show(this.Resources["Txt_InnerPage_ConnPointManage_TabMyConnPoint_AddMyCloudSeeNum_Prompt"].ToString(), this.Resources["Txt_InnerPage_ConnPointManage_TabMyConnPoint_AddMyCloudSeeNum_PromptTitle"].ToString(), MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            base.OnKeyDown(e);
        }

    

        protected override void OnTextChanged(TextChangedEventArgs e)
        {
            //屏蔽中文输入和非法字符粘贴输入
            TextBox textBox = this;
            TextChange[] change = new TextChange[e.Changes.Count];
            e.Changes.CopyTo(change, 0);

            int offset = change[0].Offset;
            if (change[0].AddedLength > 0)
            {
                double num = 0;
                if (!Double.TryParse(textBox.Text, out num))
                {
                    textBox.Text = textBox.Text.Remove(offset, change[0].AddedLength);
                    textBox.Select(offset, 0);
                }
            }
            base.OnTextChanged(e);
        }


    }
}
