

using System;
using System.ComponentModel;

namespace Orm.Model
{
    /// <summary>
    /// 行心云:医联体管理 - 实体类
    /// </summary> 
    public partial class BsHospitalUnion: INotifyPropertyChanged
    {
        private string _mobile;
        private string _adminName;
        private string _provinceName;
        private string _regionName;
        private string _areaName;

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        /// <summary>
        /// 管理员名称
        /// </summary> 

        public string AdminName
        {
            get { return _adminName; }
            set { _adminName = value; }
        }


        /// <summary>
        /// 省名称
        /// </summary> 
        public string ProvinceName
        {
            get { return _provinceName; }
            set { _provinceName = value; }
        }


        /// <summary>
        /// 市名称
        /// </summary> 
        public string RegionName
        {
            get { return _regionName; }
            set { _regionName = value; }
        }
        /// <summary>
        /// 区名称
        /// </summary> 
        public string AreaName
        {
            get { return _areaName; }
            set { _areaName = value; }
        }



        /// <summary>
        /// 手机号
        /// </summary>
        public string Mobile
        {
            get { return _mobile; }
            set
            {
                _mobile = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Mobile"));
            }
        }
    }
}


