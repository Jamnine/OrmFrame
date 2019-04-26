using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYHis.Model
{
    /// <summary>
    /// 修复体
    /// </summary>
    [Serializable]
    public class BsRestoration : BaseModel
    {
        #region Fields
        //protected string _code = String.Empty;
        protected string _name = String.Empty;
        protected int _orderBy;
        protected bool _isActive = true;
        protected string _pYCode = String.Empty;
        protected string _wBCode = String.Empty;
        protected DateTime _modiTime;
        protected int _modiOperId;

        private double _price = 0.0;
        #endregion

        #region Contructors
        public BsRestoration()
        {
        }


        #endregion

        #region Public Properties


        /// <summary>  
        /// 编号  
        /// </summary>  
        //[Collumn(HeaderName = "编码", RelatedTableType = null, Length = 6)]
        //public string Code
        //{
        //    get { return _code; }
        //    set { _code = value; }
        //}

        /// <summary>  
        /// 名称  
        /// </summary>  
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        /// <summary>  
        /// 价格  
        /// </summary>  
        [Collumn(HeaderName = "价格", RelatedTableType = null, Length = 50)]
        public double Price { get { return _price; } set { _price = value; } }

        [Collumn(HeaderName = "排序", IsShow = true)]
        /// <summary>  
        /// 显示顺序  
        /// </summary>  
        public int OrderBy
        {
            get { return _orderBy; }
            set { _orderBy = value; }
        }

        /// <summary>  
        /// 有效标志  
        /// </summary>  
        public bool IsActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }

        /// <summary>  
        /// 拼音码  
        /// </summary>  
        public string PYCode
        {
            get { return _pYCode; }
            set { _pYCode = value; }
        }

        /// <summary>  
        /// 五笔码  
        /// </summary>  
        public string WBCode
        {
            get { return _wBCode; }
            set { _wBCode = value; }
        }

        /// <summary>  
        /// 最后修改时间  
        /// </summary>  
        public DateTime ModiTime
        {
            get { return _modiTime; }
            set { _modiTime = value; }
        }

        /// <summary>  
        /// 最后修改人  
        /// </summary>  
        public int ModiOperId
        {
            get { return _modiOperId; }
            set { _modiOperId = value; }
        }

        /// <summary>
        /// 加工厂
        /// </summary>
        public int ProcessingFactory { get; set; }

        #endregion
    }
}
