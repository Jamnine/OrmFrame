using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using Orm.Model.Custom;
using Orm.MvvmFrame.Auxiliary;

namespace Orm.Client.Common
{
    public class SystemCommon : ViewModelBase
    {
        public SystemCommon()
        {

        }

        #region 公共属性

        /// <summary>
        /// 用于本地配置的xml数据文件路径
        /// </summary>
        public static  string localParSettingFilePath = "LocalParameterSettings.xml";

        #endregion
        //public static DateTime GetServerTime()
        //{
        //    return Orm.Config.Service.DBClientService.GetServerTime();
        //}

        //public static bool IsCanAccessTheModule(string menuName, string pageName, string functionName)
        //{
        //    bool retnBool = IsCanAccessThisModule(menuName, pageName, functionName);
        //    if (!retnBool)
        //    {
        //        Orm.Toolkit.MessageBox.Show("你无权限操作此模块,请联系管理员！", "系统提示");
        //        return false;
        //    }
        //    return true;
        //}

        /// <summary>
        /// 全角转半角的函数(DBC case)
        /// </summary>
        /// <param name="input">任意字符串</param>
        /// <returns>半角字符串</returns>
        ///<remarks>
        ///全角空格为12288，半角空格为32
        ///其他字符半角(33-126)与全角(65281-65374)的对应关系是：均相差65248
        ///</remarks>
        public static string StringToDBC(string input)
        {
            char[] charArr = input.ToCharArray();
            for (int i = 0; i < charArr.Length; i++)
            {
                if (charArr[i] == 12288)
                {
                    charArr[i] = (char)32;
                    continue;
                }
                if (charArr[i] > 65280 && charArr[i] < 65375)
                {
                    charArr[i] = (char)(charArr[i] - 65248);
                }
            }
            string str = charArr.ToString().Replace("。", ".");
            return new string(charArr);
        }

        /// <summary>
        /// 打开插入图片框
        /// </summary>
        private static int i = 0;
        public static string UpLoadPhoto(object parameter)
        {
            i++;
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 0, 0, 300);
            timer.Tick += (s, e1) => { timer.IsEnabled = false; i = 0; };
            timer.IsEnabled = true;
            string fileName = string.Empty;
            if (i % 2 == 0)
            {
                return fileName;
            }
            else
            {
                object arr = parameter as object;
                //创建＂打开文件＂对话框
                Microsoft.Win32.OpenFileDialog dlg = new OpenFileDialog();
                //设置文件类型过滤
                dlg.Filter = "图片|*.jpg;*.png;*.jpeg";
                Nullable<bool> result = dlg.ShowDialog();
                if (result == true)
                {
                    fileName = dlg.FileName;
                    FileInfo file = new FileInfo(fileName);
                    if ((file.Length / 1024) > 512)
                    {
                        //Orm.Client.Base.FrmMessageRemind.Show("图片不能大于512KB");
                        return string.Empty;
                    }
                    BitmapImage xPhoto = new BitmapImage(new Uri(fileName));
                    if (arr is Image)
                    {
                        ((Image)arr).Source = xPhoto;
                        ((Image)arr).Stretch = System.Windows.Media.Stretch.Fill;
                    }
                }
                return fileName;
            }
        }
 
        /// <summary>
        /// 键盘按下
        /// </summary>
        /// <param name="eventInfo"></param>
        /// <returns></returns>
        public static ReturnValues DbcKeyDownEvent(EventInformation<RoutedEventArgs> eventInfo)
        {
            ReturnValues returnValues = new ReturnValues();
            if (eventInfo == null || eventInfo.Sender == null)
            {
                return returnValues;
            }
            System.Windows.Controls.TextBox sender = eventInfo.Sender as System.Windows.Controls.TextBox;
            System.Windows.Input.KeyEventArgs keyEventArgs = eventInfo.EventArgs as System.Windows.Input.KeyEventArgs;
            int count = sender.CaretIndex;
            string senderText = sender.Text.ToString();
            if ((Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control && keyEventArgs.Key == Key.A)
            {
                return returnValues;
            }
            if (sender.SelectedText.ToString().Length > 0)
            {
                return returnValues;
            }
            returnValues.ReturnBool = true;
            returnValues.ReturnCount = count;
            returnValues.ReturnString=  SystemCommon.StringToDBC(senderText);
            return returnValues;
        }

        public static List<BsCmmonData> EnumToBsCmmonDataList(string enumDefine)
        {
            try
            {
                List<BsCmmonData> bsCmmonDataList = new List<BsCmmonData>();
                List<KeyValuePair<string, string>> workSheetStatusList = Orm.Model.EnumDefine.EumConvertor.ConvertToKeyValueList(enumDefine);
                foreach (KeyValuePair<string, string> workSheetStatus in workSheetStatusList)
                {
                    BsCmmonData cmmonData = new BsCmmonData
                    {
                        ID = workSheetStatus.Key.ToString(),
                        Name = workSheetStatus.Value
                    };
                    bsCmmonDataList.Add(cmmonData);
                }
                return bsCmmonDataList;
            }
            catch (Exception ex)
            {
                //Orm.Client.Base.FrmMessageRemind.Show(ex.Message);
                return new List<BsCmmonData>();
            }
        }

    }

    public class ReturnValues
    {
        public bool ReturnBool { get; set; }
        public int ReturnCount { get; set; }
        public string ReturnString { get; set; }
    }
}
