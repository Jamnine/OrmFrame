

using System;
using System.Collections.Generic;
using System.Windows.Data;

namespace Orm.Model
{
    /// <summary>
    /// BP的治疗方案及小字说明表(三级) - 实体类
    /// </summary>
    public partial class BsBPCure
    {
        /// <summary>
        /// 默认构造方法.
        /// </summary>
        public BsBPCure()
        {
            MethodGroup = new List<string>();
        }
        /// <summary>
        /// 第几选择
        /// </summary>
        public List<string> MethodGroup { get; set; }
        /// <summary>
        /// 方法组(所有项目)
        /// </summary>
        public List<BsItemList> LstItemList { get; set; }

        /// <summary>
        /// 方法组(所有项目)
        /// </summary>
        public List<BsBPCureDtl> BsBPCureDtlList { get; set; }
        
    }
    #region 类
    /// <summary>
    /// 方法组
    /// </summary>
    public class MethodGroup
    {
        public MethodGroup()
        {
            itemgroup = new List<ItemGroup>();
        }

        /// <summary>
        /// 第几选择
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 列表
        /// </summary>
        public List<ItemGroup> itemgroup { get; set; }
    }

    /// <summary>
    /// 项目组
    /// </summary>
    public class ItemGroup
    {
        public ItemGroup()
        {
            LstItem = new List<BsItemList>();
            CollectionView = new ListCollectionView(LstItem);
            CollectionView.GroupDescriptions.Add(new PropertyGroupDescription("TypeCode"));
        }
        /// <summary>
        /// 组名
        /// </summary>
        public string GroupName { get; set; }

        /// <summary>
        /// 项目列表
        /// </summary>
        public List<BsItemList> LstItem { get; set; }

        ListCollectionView _collectionView;
        /// <summary>
        /// datagrid分组使用
        /// </summary>
        public ListCollectionView CollectionView
        {
            get { return _collectionView; }
            set
            {
                _collectionView = value;
            }
        }
    }
    #endregion
}


