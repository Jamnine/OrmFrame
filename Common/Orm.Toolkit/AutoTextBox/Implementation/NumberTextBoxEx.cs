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
    public class NumberTextBoxEx : System.Windows.Controls.TextBox
    {

        /// <summary>
        /// 控件的最小值属性
        /// </summary>
        public int MinNum
        {
            get { return (int)GetValue(MinNumProperty); }
            set { SetValue(MinNumProperty, value); }
        }


        public static readonly DependencyProperty MinNumProperty =
            DependencyProperty.Register("MinNum", typeof(int), typeof(NumberTextBoxEx), new PropertyMetadata(0));


        /// <summary>
        /// 控件的最大值属性
        /// </summary>
        public int MaxNum
        {
            get { return (int)GetValue(MaxNumProperty); }
            set { SetValue(MaxNumProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MaxNum.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MaxNumProperty =
            DependencyProperty.Register("MaxNum", typeof(int), typeof(NumberTextBoxEx), new PropertyMetadata(0));


        /// <summary>
        /// 控件的值是否为非小数，默认值为false
        /// </summary>
        public bool IsInt
        {
            get { return (bool)GetValue(IsIntProperty); }
            set { SetValue(IsIntProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsDecimal.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsIntProperty =
            DependencyProperty.Register("IsInt", typeof(bool), typeof(NumberTextBoxEx), new PropertyMetadata(false));




        static NumberTextBoxEx()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(NumberTextBoxEx), new FrameworkPropertyMetadata(typeof(NumberTextBoxEx)));
        }



        protected override void OnKeyDown(KeyEventArgs e)
        {
            TextBox txt = this;
            //屏蔽非法按键
            if ((e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9) || (e.Key == Key.Decimal && !IsInt) || e.Key.ToString() == "Tab")
            {
                if (txt.Text.Contains(".") && e.Key == Key.Decimal)
                {
                    e.Handled = true;
                    return;
                }
                e.Handled = false;
            }
            else if (((e.Key >= Key.D0 && e.Key <= Key.D9) || (e.Key == Key.OemPeriod && !IsInt)) && e.KeyboardDevice.Modifiers != ModifierKeys.Shift)
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
                    //
                    textBox.Text = textBox.Text.Remove(offset, change[0].AddedLength);
                    textBox.Select(offset, 0);
                }
                else
                {
                    //判断值是否为非小数；
                    if (IsInt)
                    {
                        //判断值的左数位是否有多余的零，有则去掉多余的零；
                        if (textBox.Text.Trim() == "00")
                        {
                            textBox.Text = "0";
                            textBox.SelectAll();
                        }
                        else if (textBox.Text.Trim() != "0")
                        {
                            textBox.Text = textBox.Text.TrimStart('0');
                            //textBox.SelectAll();
                        }
                        if (this.MaxNum != 0)
                        {
                            int num1 = 0;
                            if (int.TryParse(textBox.Text, out num1))
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
            }
            else
            {
                //判断是否为非小数，并判断是否为空值，是则赋值为0；
                if (IsInt)
                {
                    if (textBox.Text.Trim() == "")
                    {
                        textBox.Text = "0";
                        textBox.SelectAll();
                    }
                }
            }
            base.OnTextChanged(e);
        }


    }
}
