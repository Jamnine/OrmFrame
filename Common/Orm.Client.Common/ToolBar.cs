using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orm.Model.EnumDefine;

namespace Orm.Client.Common
{
    public class Toolbar
    {

        protected int _itemWidth;
        /// <summary>
        /// ItemWidth
        /// </summary>
        public int ItemWidth
        {
            set { _itemWidth = value; }
            get { return _itemWidth; }
        }


        protected int _itemHeight;
        /// <summary>
        /// ItemHeight
        /// </summary>
        public int ItemHeight
        {
            set { _itemHeight = value; }
            get { return _itemHeight; }
        }

        protected List<ToolbarItem> _toolbarItems;
        /// <summary>
        /// ToolbarItem
        /// </summary>
        public List<ToolbarItem> ToolbarItems
        {
            set { _toolbarItems = value; }
            get { return _toolbarItems; }
        }
    }

    public class ToolbarItem :IComparable
    {

        protected int _id;
        /// <summary>
        /// ID
        /// </summary>
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }

        protected string _key;
        /// <summary>
        /// Key
        /// </summary>
        public string Key
        {
            set { _key = value; }
            get { return _key; }
        }

        protected int _style = 0;
        /// <summary>
        /// ItemWidth
        /// </summary>
        public int Style
        {
            set { _style = value; }
            get { return _style; }
        }
        protected int _status;
        /// <summary>
        /// Status
        /// </summary>
        public int Status
        {
            set { _status = value; }
            get { return _status; }
        }


        protected int _itemStatus;
        /// <summary>
        /// ItemStatus
        /// </summary>
        public int ItemStatus
        {
            set { _itemStatus = value; }
            get { return _itemStatus; }
        }


        protected HotKeys _hotKey;
        /// <summary>
        /// HotKey
        /// </summary>
        public HotKeys HotKey
        {
            set { _hotKey = value; }
            get { return _hotKey; }
        }

        protected bool _begenGroup;
        /// <summary>
        /// HotKey
        /// </summary>
        public bool BeginGroup
        {
            set { _begenGroup = value; }
            get { return _begenGroup; }
        }



        protected string _icon;
        /// <summary>
        /// Icon
        /// </summary>
        public string Icon
        {
            set { _icon = value; }
            get { return _icon; }
        }


        protected string _text;
        /// <summary>
        /// Text
        /// </summary>
        public string Text
        {
            set { _text = value; }
            get { return _text; }
        }


        protected string _tips;
        /// <summary>
        /// Tips
        /// </summary>
        public string Tips
        {
            set { _tips = value; }
            get { return _tips; }
        }
        protected ToolbarItemType _type;
        /// <summary>
        /// Type
        /// </summary>
        public ToolbarItemType Type
        {
            set { _type = value; }
            get { return _type; }
        }



        protected List<ToolbarMenuItem> _menuItems;
        /// <summary>
        /// MenuItems
        /// </summary>
        public List<ToolbarMenuItem> MenuItems
        {
            set { _menuItems = value; }
            get { return _menuItems; }
        }
        //fwh
        //public override void Fill(System.Data.IDataReader dr)
        //{
        //    throw new Exception("The method or operation is not implemented.");
        //}

        private int columnInfoSortOrder = 0;
        public int SortOrder
        {
            get
            {
                return columnInfoSortOrder;
            }
            set
            {
                columnInfoSortOrder = value;
            }
        }

        int IComparable.CompareTo(object obj)
        {
            return this.SortOrder.CompareTo(((ToolbarItem)obj).SortOrder);
        }
    }

    public class ToolbarMenuItem
    {

        protected int _id;
        /// <summary>
        /// ID
        /// </summary>
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }

        protected string _key;
        /// <summary>
        /// Key
        /// </summary>
        public string Key
        {
            set { _key = value; }
            get { return _key; }
        }
        protected string _icon;
        /// <summary>
        /// Icon
        /// </summary>
        public string Icon
        {
            set { _icon = value; }
            get { return _icon; }
        }
        protected string _text;
        /// <summary>
        /// Text
        /// </summary>
        public string Text
        {
            set { _text = value; }
            get { return _text; }
        }
        public void Fill(System.Data.IDataReader dr)
        {
            throw new Exception("The method or operation is not implemented.");
        }
    }
}

