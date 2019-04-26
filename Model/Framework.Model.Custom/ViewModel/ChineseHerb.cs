using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Orm.Model;
using Orm.Model.Custom;

namespace Orm.Model.Custom
{
    [Serializable]
    public class ChineseHerb
    {
        public ChineseHerb()
        {

        }

        private bool _canCancel = true;
        /// <summary>
        /// 能否删除
        /// </summary>
        public bool CanCancel
        {
            get { return this._canCancel; }
            set { this._canCancel = value; }
        }

        private OuRecipe _herbOuRecipe = new OuRecipe();
        /// <summary>
        /// 主表
        /// </summary>
        public OuRecipe HerbOuRecipe
        {
            get { return this._herbOuRecipe; }
            set { this._herbOuRecipe = value; }
        }

        private OuRecipeChin _chineseHerbChin = new OuRecipeChin();
        /// <summary>
        /// 中药项目用法表
        /// </summary>
        public OuRecipeChin ChineseHerbChin
        {
            get { return this._chineseHerbChin; }
            set { this._chineseHerbChin = value; }
        }

        private ObservableCollection<OuRecipeDtl> _chineseHerbDtl = new ObservableCollection<OuRecipeDtl>();
        /// <summary>
        /// 中药项目明细
        /// </summary>
        public ObservableCollection<OuRecipeDtl> ChineseHerbDtl
        {
            get { return this._chineseHerbDtl; }
            set { this._chineseHerbDtl = value; }
        }
    }

    [Serializable]
    public class WestHerb
    {
        public WestHerb()
        {

        }

        private bool _canCancel = true;
        /// <summary>
        /// 能否删除
        /// </summary>
        public bool CanCancel
        {
            get { return this._canCancel; }
            set { this._canCancel = value; }
        }

        private OuRecipe _herbOuRecipe = new OuRecipe();
        /// <summary>
        /// 主表
        /// </summary>
        public OuRecipe HerbOuRecipe
        {
            get { return this._herbOuRecipe; }
            set { this._herbOuRecipe = value; }
        }


        private ObservableCollection<OuRecipeDtl> _westHerbDtl = new ObservableCollection<OuRecipeDtl>();
        /// <summary>
        /// 西药项目明细/营养素明细
        /// </summary>
        public ObservableCollection<OuRecipeDtl> WestHerbDtl
        {
            get { return this._westHerbDtl; }
            set { this._westHerbDtl = value; }
        }
    }
}
