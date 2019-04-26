using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model
{
    /// <summary>
    /// 中药处方模板维护明细 数据库不存在此表
    /// </summary>
    [Serializable]
    public class ChineseRecipeDtl : BaseModel
    {
        public ChineseRecipeDtl() { }
        private string _itemID;
        /// <summary>
        /// 项目ID
        /// </summary>
        public string ItemID
        {
            get { return _itemID; }
            set { _itemID = value; }
        }


        private double _priceDiag;
        /// <summary>
        /// 单价
        /// </summary>
        public double PriceDiag
        {
            get { return _priceDiag; }
            set { _priceDiag = value; }
        }

        
        private string _name;
        /// <summary>
        /// 项目名称
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private double _dosage;
        /// <summary>
        /// 数量
        /// </summary>
        public double Dosage
        {
            get { return _dosage; }
            set { _dosage = value; }
        }
        private string _unitTakeId;
        /// <summary>
        /// 用量单位
        /// </summary>
        public string UnitTakeId
        {
            get { return _unitTakeId; }
            set { _unitTakeId = value; }
        }
     
        
        private string _cookTypeName;
        /// <summary>
        /// 煎药方式
        /// </summary>
        public string CookTypeName
        {
            get { return _cookTypeName; }
            set { _cookTypeName = value; }
        }
        private string _memo;

        /// <summary>
        /// 备注
        /// </summary>
        public string Memo
        {
            get { return _memo; }
            set { _memo = value; }
        }
        private string _recipeId;

        /// <summary>
        /// 处方ID.
        /// </summary>
        public string RecipeId
        {
            get
            {
                return this._recipeId;
            }
            set
            {
                this._recipeId = value;
            }
        }

        private int _cookType;
        /// <summary>
        /// 煎药方式
        /// </summary>
        public int CookType
        {
            get
            {
                return this._cookType;
            }
            set
            {
                this._cookType = value;
            }
        }
       
        /// <summary>
        /// 中药处方号
        /// </summary>
        public string RecipeNum { get; set; }
        private string tmpRecipeEmrId;
        /// <summary>
        ///处方模板表ID
        /// </summary>
        public string TmpRecipeEmrId
        {
            get { return tmpRecipeEmrId; }
            set { tmpRecipeEmrId = value; }
        }

        private string _unitDiagID;
        /// <summary>
        /// 单位ID
        /// </summary>
        public string UnitDiagID
        {
            get { return _unitDiagID; }
            set { _unitDiagID = value; }
        }

    }
}
