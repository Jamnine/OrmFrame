using System;

namespace Orm.Model
{
    /// <summary>
    /// 体检结果图片 数据库不存在此表
    /// </summary>
    [Serializable]
    public partial class TjResultImage : BaseModel
    {
        private string _mzRegId;
        private string _tjLocationID;
        private string _imageTypePath;
        private string _ouRecipeDtlID;

        /// <summary>
        /// 默认构造函数
        /// </summary>
        public TjResultImage()
        {
        }

        /// <summary>  
        ///  门诊ID
        /// </summary>  
        public string MzRegId
        {
            get { return this._mzRegId; }
            set { this._mzRegId = value; }
        }

        /// <summary>  
        ///   体检科室
        /// </summary>  
        public string TjLocationID
        {
            get { return this._tjLocationID; }
            set { this._tjLocationID = value; }
        }

        /// <summary>
        /// 图片路径
        /// </summary>
        public int PatID { get; set; }

        /// <summary>
        /// 图片路径
        /// </summary>
        public string ImageTypePath
        {
            get { return this._imageTypePath; }
            set { this._imageTypePath = value; }
        }

        /// <summary>
        /// 处方明细ID
        /// </summary>
        public string RecipeDtlId
        {
            get { return this._ouRecipeDtlID; }
            set { this._ouRecipeDtlID = value; }
        }

        /// <summary>
        /// 图片内容
        /// </summary>
        public byte[] BitmapImageSource { get; set; }

        /// <summary>
        /// 图片名称
        /// </summary>
        public string ImgName { get; set; }

        private byte[] _image;
        /// <summary>
        /// 图片二进制流
        /// </summary>
        public byte[] Image
        {
            get { return _image; }
            set { _image = value; }
        }
    }
}
