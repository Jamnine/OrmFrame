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
    /// <summary>
    /// 金额控件
    /// 有以下功能：
    /// 一个是屏蔽非法按键
    /// 一个是防止非法粘贴
    /// 一个是当按下"."光标自动跳到"."之后
    /// </summary>
    public class AmountTextBox : System.Windows.Controls.TextBox
    {
        /// <summary>
        /// 控件的最小值属性
        /// </summary>
        public double MinNum
        {
            get { return (double)GetValue(MinNumProperty); }
            set { SetValue(MinNumProperty, value); }
        }


        public static readonly DependencyProperty MinNumProperty =
            DependencyProperty.Register("MinNum", typeof(double), typeof(AmountTextBox), new PropertyMetadata(0.0000));


        /// <summary>
        /// 控件的最大值属性
        /// </summary>
        public double MaxNum
        {
            get { return (double)GetValue(MaxNumProperty); }
            set { SetValue(MaxNumProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MaxNum.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MaxNumProperty =
            DependencyProperty.Register("MaxNum", typeof(double), typeof(AmountTextBox), new PropertyMetadata(0.0000));

        static AmountTextBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(AmountTextBox), new FrameworkPropertyMetadata(typeof(AmountTextBox)));
        }
        protected override void OnPreviewKeyDown(KeyEventArgs e)
        {
            TextBox txt = this;
            if (e.Key == Key.Back)
            {
                if (txt.Text.Contains(".") && txt.CaretIndex == (txt.Text.IndexOf(".") + 1))
                {
                    //光标跳到"."之后
                    txt.CaretIndex = txt.CaretIndex - 1;
                    e.Handled = true;
                    return;
                }
                e.Handled = false;
            }
            if (txt.SelectionStart == txt.Text.Length && txt.Text.Length!=0)
            {
                e.Handled = true;
                return;
            }
            //当文本全选时，让其真正获得
            if (txt.SelectedText == txt.Text)
            {
                txt.SelectAll();
                //txt.Text = "";
            }
            base.OnPreviewKeyDown(e);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            TextBox txt = this;
            //屏蔽非法按键
            if ((e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9) || e.Key == Key.Decimal || e.Key.ToString() == "Tab")
            {
                if (txt.Text.Contains(".") && e.Key == Key.Decimal)
                {
                    //光标跳到"."之后
                    var tempIndex = txt.Text.IndexOf(".");
                    txt.CaretIndex = tempIndex + 1;
                    e.Handled = true;
                    return;
                }
                e.Handled = false;
            }
            else if (((e.Key >= Key.D0 && e.Key <= Key.D9) || e.Key == Key.OemPeriod) && e.KeyboardDevice.Modifiers != ModifierKeys.Shift)
            {
                if (txt.Text.Contains(".") && e.Key == Key.OemPeriod)
                {
                    //光标跳到"."之后
                    var tempIndex = txt.Text.IndexOf(".");
                    txt.CaretIndex = tempIndex + 1;
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
            //不是个很好的方法

            //屏蔽中文输入和非法字符粘贴输入
            //TextBox textBox = this;
            //TextChange[] change = new TextChange[e.Changes.Count];
            //e.Changes.CopyTo(change, 0);

            //int offset = change[0].Offset;
            //if (change[0].AddedLength > 0)
            //{
            //    double num = 0;
            //    if (!Double.TryParse(textBox.Text, out num))
            //    {
            //        textBox.Text = textBox.Text.Remove(offset, change[0].AddedLength);
            //        textBox.Select(offset, 0);
            //    }

            //    //if (textBox.Text.Contains(".") && (textBox.Text.Length - textBox.Text.IndexOf('.') - 1) > 2)
            //    //{
            //    //    textBox.Text = textBox.Text.Remove(offset, change[0].AddedLength);
            //    //    textBox.Select(offset, 0);
            //    //    e.Handled = true;
            //    //}
            //}
            TextBox textBox = this;
            TextChange[] change = new TextChange[e.Changes.Count];
            e.Changes.CopyTo(change, 0);

            int offset = change[0].Offset;
            if (change[0].AddedLength > 0)
            {
                double num = 0;
                if (!Double.TryParse(textBox.Text, out num))
                {
                    //
                    textBox.Text = textBox.Text.Remove(offset, change[0].AddedLength);
                    textBox.Select(offset, 0);
                }
                else
                {
                    //判断值的左数位是否有多余的零，有则去掉多余的零；
                    //if (textBox.Text.Trim() == "00")
                    //{
                    //    textBox.Text = "0";
                    //    textBox.SelectAll();
                    //}
                    //else if (textBox.Text.Trim() != "0")
                    //{
                    //    textBox.Text = textBox.Text.TrimStart('0');
                    //    //textBox.SelectAll();
                    //}
                    if (this.MaxNum != 0)
                    {
                        double num1 = 0;
                        if (double.TryParse(textBox.Text, out num1))
                        {
                            //判断值是否小于最小值，是则将最小值设为值；
                            if (num1 < this.MinNum)
                            {
                                textBox.Text = this.MinNum.ToString();
                                textBox.SelectAll();
                            }
                            //判断值是否大于最大值，是则将最大值设为值；
                            if (num1 > this.MaxNum)
                            {
                                textBox.Text = this.MaxNum.ToString();
                                textBox.SelectAll();
                            }

                        }
                    }
                }
            }
            else
            {
                //判断是否为非小数，并判断是否为空值，是则赋值为0；
                //if (IsInt)
                //{
                //    if (textBox.Text.Trim() == "")
                //    {
                //        textBox.Text = "0";
                //        textBox.SelectAll();
                //    }
                //}
            }
            base.OnTextChanged(e);
        }

        protected override void OnLostFocus(RoutedEventArgs e)
        {
            TextBox txt = this;
            double tmpInput = 0.0000;
            if (string.IsNullOrWhiteSpace(txt.Text) || !double.TryParse(txt.Text, out tmpInput))
            {
                txt.Text = "0.0000";
            }
            base.OnLostFocus(e);
        }

    }
}
