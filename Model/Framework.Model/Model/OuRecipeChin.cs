


using System;
namespace Orm.Model
{
    /// <summary>
    /// 门诊中药处方用法说明 - 实体类
    /// </summary>
    [Serializable]
    public partial class OuRecipeChin : BaseModel
    {


        private string _recipeId;  //处方ID

        private string _frequencyId;  //每天服用次数

        private string _usageId;  //用法

        private int _decoctNum;  //煎药付数

        private int _lsCookSelf;  //煎药方法：1-代煎；2-自煎

        private int _cookMinute;  //煎药分钟

        private int _lsFire;  //火候：1-文火;2-中火;3-武火

        private bool _isAuthed;  //已经封存，不可改删

        private double _beforeWater;  //行心云:煮后水量

        private double _afterWater;  //行心云:煮前水量

        private int _HospitalID;  //

        /// <summary>
        /// 处方ID
        /// </summary>
        public string RecipeId
        {
            get { return _recipeId; }
            set { _recipeId = value; }
        }

        /// <summary>
        /// 每天服用次数
        /// </summary>
        public string FrequencyId
        {
            get { return _frequencyId; }
            set { _frequencyId = value; }
        }

        /// <summary>
        /// 用法
        /// </summary>
        public string UsageId
        {
            get { return _usageId; }
            set { _usageId = value; }
        }

        /// <summary>
        /// 煎药付数
        /// </summary>
        public int DecoctNum
        {
            get { return _decoctNum; }
            set { _decoctNum = value; }
        }

        /// <summary>
        /// 煎药方法：1-代煎；2-自煎
        /// </summary>
        public int LsCookSelf
        {
            get { return _lsCookSelf; }
            set { _lsCookSelf = value; }
        }

        /// <summary>
        /// 煎药分钟
        /// </summary>
        public int CookMinute
        {
            get { return _cookMinute; }
            set { _cookMinute = value; }
        }

        /// <summary>
        /// 火候：1-文火;2-中火;3-武火
        /// </summary>
        public int LsFire
        {
            get { return _lsFire; }
            set { _lsFire = value; }
        }

        /// <summary>
        /// 已经封存，不可改删
        /// </summary>
        public bool IsAuthed
        {
            get { return _isAuthed; }
            set { _isAuthed = value; }
        }

        /// <summary>
        /// 行心云:煮后水量
        /// </summary>
        public double BeforeWater
        {
            get { return _beforeWater; }
            set { _beforeWater = value; }
        }

        /// <summary>
        /// 行心云:煮前水量
        /// </summary>
        public double AfterWater
        {
            get { return _afterWater; }
            set { _afterWater = value; }
        }

    }
}



