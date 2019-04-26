using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model
{
    public partial class bsUserPic:BaseModel
    {
        private byte[] _pictureSource;
        // <summary>  
        /// 头像图片二进制  
        /// </summary>  
        public byte[] PictureSource
        {
            get { return this._pictureSource; }
            set { this._pictureSource = value; }
        } 
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName
        {
            get;
            set;
        }
        /// <summary>
        ///门诊名称
        /// </summary>
        public string LocationName
        {
            get;
            set;
        }
        /// <summary>
        /// 职称
        /// </summary>
        public string DocLevname
        {
            get;
            set;
        }
        /// <summary>
        /// 科室
        /// </summary>
        public string DepartmentName
        {
            get;
            set;
        }
        /// <summary>
        /// 相片
        /// </summary>
        public System.Windows.Media.Imaging.BitmapImage Photo
        {
            get;
            set;
        }
    }
}

