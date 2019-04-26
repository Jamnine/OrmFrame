using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Parameter
{
    /// <summary>
    /// 初始化项目维护页面中的下拉控件值
    /// </summary>
    [Serializable]    
    public class PMInitBsItemComboBox
    {
        /// <summary>
        /// 单位
        /// </summary>
        public List<BsUnit> BsUnitList { get; set; }
        /// <summary>
        /// 收费类别
        /// </summary>
        public List<BsMzFeety> BsMzFeetyList { get; set; }
      
        /// <summary>
        /// 一级分组
        /// </summary>
        public List<BsGroup> BsGroupList { get; set; }
        /// <summary>
        /// 二级分组
        /// </summary>
        public List<BsGroupSub> BsGroupSubList { get; set; }
        /// <summary>
        /// 制造商列表
        /// </summary>
        public List<BsManufacturer> BsManufacturerList { get; set; }
        public List<BsCompany> BsCompanyList { get; set; }
        public List<BsUnitRatio> BsUnitRatioList { get; set; }
        public List<BsUsage> BsUsageList { get; set; }
        public List<BsFrequency> BsFrequencyList { get; set; }
        public ObservableCollection<BsLabSourceItem> BsLabSourceItemList { get; set; }

        public List<BsLabSource> BsLabSourceList { get; set; }
        public ObservableCollection<BsUsageItem> BsUsageItemList { get; set; }

        public List<BstubeType> BstubeTypeList { get; set; }

    }
}
