using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using Orm.Model;

namespace Orm.Client.Common
{
    public class PhotoDealClass
    {
        /// <summary>
        /// 上传图片
        /// </summary>
        /// <param name="parameter">控件数组（照相机控件和图片控件）</param>
        public string UpLoadPhoto(object parameter)
        {
            BitmapImage photo = new BitmapImage();  
            object[] controlArray = parameter as object[];
            ((Image)controlArray[0]).Visibility = System.Windows.Visibility.Visible;
            //上传
            //创建＂打开文件＂对话框
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
            //设置文件类型过滤
            openFileDialog.Filter = "图片|*.jpg;*.png;*.jpeg";
            // 调用ShowDialog方法显示＂打开文件＂对话框
            Nullable<bool> isSelectResult = openFileDialog.ShowDialog();
            if (isSelectResult == true)
            {
                //获取所选文件名并在FileNameTextBox中显示完整路径
                string fileName = openFileDialog.FileName;
                //预览所选图片
                photo = new BitmapImage(new Uri(fileName));
                //Image imag = param as Image;
                if (controlArray[0] is Image)
                {
                    ((Image)controlArray[0]).Source = photo;
                    ((Image)controlArray[0]).Stretch = System.Windows.Media.Stretch.Fill;
                    ((Image)controlArray[0]).Visibility = System.Windows.Visibility.Visible;
                }
                return fileName;
            }
            return string.Empty ;
        }
        

    }
}
