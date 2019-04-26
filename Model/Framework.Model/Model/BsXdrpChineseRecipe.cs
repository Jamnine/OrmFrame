using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model
{
    /// <summary>
    /// 中药处方用法维护表
    /// </summary>
    [Serializable]
    public partial class BsXdrpChineseRecipe: BaseModel
    {
        public BsXdrpChineseRecipe() { }

        private int _lsFire;
        /// <summary>
        /// 火候：1-文火;2-中火;3-武火.
        /// </summary>
        public int LsFire
        {
            get
            {
                return this._lsFire;
            }
            set
            {
                this._lsFire = value;
            }
        }

        private int _decoctNum;
        /// <summary>
        /// 煎药数
        /// </summary>
        public int DecoctNum
        {
            get
            {
                return this._decoctNum;
            }
            set
            {
                this._decoctNum = value;
            }
        }

        private string _tmpRecipeEmrID;
        /// <summary>
        /// 处方模板维护主表ID
        /// </summary>
        public string TmpRecipeEmrID
        {
            get { return _tmpRecipeEmrID; }
            set { _tmpRecipeEmrID = value; }
        }


        private int _cookMinute;

        /// <summary>
        /// 煎药分钟.
        /// </summary>
        public int CookMinute
        {
            get
            {
                return this._cookMinute;
            }
            set
            {
                this._cookMinute = value;
            }
        }

        private double _beforeWater;

        /// <summary>
        /// 煮前水量
        /// </summary>
        public double BeforeWater
        {
            get { return this._beforeWater; }
            set { this._beforeWater = value; }
        }

        private double _afterWater;
        /// <summary>
        /// 煮后水量
        /// </summary>
        public double AfterWater
        {
            get { return this._afterWater; }
            set { this._afterWater = value; }
        }
        private string _frequencyId;
        /// <summary>
        /// 每天服用次数.
        /// </summary>
        public string FrequencyId
        {
            get
            {
                return this._frequencyId;
            }
            set
            {
                this._frequencyId = value;
            }
        }

        private string _usageId;
        /// <summary>
        /// 用法。外键，引用BsUsage.GUID.
        /// </summary>
        public string UsageId
        {
            get { return _usageId; }
            set { _usageId = value; }
        }

        private int _lsCookSelf;
        /// <summary>
        /// 煎药方式：1-代煎；2-自煎.
        /// </summary>
        public int LsCookSelf
        {
            get
            {
                return this._lsCookSelf;
            }
            set
            {
                this._lsCookSelf = value;
            }
        }

    

        

        private int hisType;

        /// <summary>
        /// 系统类型
        /// </summary>
        public int HisType
        {
            get
            {
                return this.hisType;
            }

            set
            {
                this.hisType = value;
            }
        }

        /// <summary>
        /// 处方时间
        /// </summary>
        public DateTime InsertTime
        {
            get
            {
                return insertTime;
            }

            set
            {
                insertTime = value;
            }
        }

        private DateTime insertTime;

    }
}
