using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model
{
    /// <summary>
    /// 首页数据
    /// </summary>
    [Serializable]
    public  class BsHomePage: BaseModel
    {

       //  Content   Link ParentId   Abbreviation
        private int _orderNumber;
        private string _content;
        private string _link;
        private string _parentId;
        private string _abbreviation;
         
        /// <summary>
        /// 序号.
        /// </summary>
        [Collumn(HeaderName = "序号", RelatedTableType = null)]
        public int  OrderNumber
        {
            get
            {
                return this._orderNumber;
            }
            set
            {
                this._orderNumber = value;
            }
        }

        /// <summary>
        /// 内容.
        /// </summary>
        [Collumn(HeaderName = "内容", RelatedTableType = null, Length = 50)]
        public string Content
        {
            get
            {
                return this._content;
            }
            set
            {
                this._content = value;
            }
        }

        /// <summary>
        /// 链接.
        /// </summary>
        [Collumn(HeaderName = "链接", RelatedTableType = null, Length = 100)]
        public string Link
        {
            get
            {
                return this._link;
            }
            set
            {
                this._link = value;
            }
        }


        /// <summary>
        /// 上级ID
        /// </summary>
        [Collumn(HeaderName = "上级ID", RelatedTableType = null, Length = 50)]
        public string ParentId
        {
            get
            {
                return this._parentId;
            }
            set
            {
                this._parentId = value;
            }
        }


        /// <summary>
        /// 序号.
        /// </summary>
        [Collumn(HeaderName = "序号", RelatedTableType = null, Length = 50)]
        public string Abbreviation
        {
            get
            {
                return this._abbreviation;
            }
            set
            {
                this._abbreviation = value;
            }
        }

    }
}
