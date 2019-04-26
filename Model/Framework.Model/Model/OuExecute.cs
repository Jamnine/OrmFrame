

using System;
namespace Orm.Model
{
	/// <summary>
	/// 门诊执行单(注射) - 实体类
	/// </summary>
	[Serializable]
	public partial class OuExecute : BaseModel  
	{   
		
		private string _mzRegId;  //门诊流水号
		
		private int _lsRepType;  //处方种类：1-西药；2-中药；3-检查/检验/治疗
		
		private string _name;  //执行单概要
		
		private string _recipeId;  //处方ID
		
		private int _groupNum;  //组号
		
		private int _nDay;  //第几天
		
		private int _nTime;  //次
		
		private string _usageId;  //用法
		
		private bool _isExecuted;  //是否已执行
		
		private DateTime _executeDate;  //执行日期
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //

        private string _executeUserId;

        private string _recipeDtlId;


        /// <summary>
        /// 门诊流水号
        /// </summary>
        public string MzRegId
		{
			get { return _mzRegId;}
			set { _mzRegId = value;}
		}                                    
		
		/// <summary>
		/// 处方种类：1-西药；2-中药；3-检查/检验/治疗
		/// </summary>
		public int LsRepType
		{
			get { return _lsRepType;}
			set { _lsRepType = value;}
		}                                    
		
		/// <summary>
		/// 执行单概要
		/// </summary>
		public string Name
		{
			get { return _name;}
			set { _name = value;}
		}                                    
		
		/// <summary>
		/// 处方ID
		/// </summary>
		public string RecipeId
		{
			get { return _recipeId;}
			set { _recipeId = value;}
		}                                    
		
		/// <summary>
		/// 组号
		/// </summary>
		public int GroupNum
		{
			get { return _groupNum;}
			set { _groupNum = value;}
		}                                    
		
		/// <summary>
		/// 第几天
		/// </summary>
		public int NDay
		{
			get { return _nDay;}
			set { _nDay = value;}
		}                                    
		
		/// <summary>
		/// 次
		/// </summary>
		public int NTime
		{
			get { return _nTime;}
			set { _nTime = value;}
		}                                    
		
		/// <summary>
		/// 用法
		/// </summary>
		public string UsageId
		{
			get { return _usageId;}
			set { _usageId = value;}
		}                                    
		
		/// <summary>
		/// 是否已执行
		/// </summary>
		public bool IsExecuted
		{
			get { return _isExecuted;}
			set { _isExecuted = value;}
		}                                    
		
		/// <summary>
		/// 执行日期
		/// </summary>
		public DateTime ExecuteDate
		{
			get { return _executeDate;}
			set { _executeDate = value;}
		}                                    
		
		/// <summary>
		/// 已经封存，不可改删
		/// </summary>
		public bool IsAuthed
		{
			get { return _isAuthed;}
			set { _isAuthed = value;}
		}                                    
		

        public string _itemId;

        /// <summary>
        /// BsItem.ID(项目ID)
        /// </summary>
        public string ItemId
        {
            get { return this._itemId; }
            set { this._itemId = value; }
        }
        public string RecipeNum { get; set; }
        public bool _isSkinTest;


        /// <summary>
        /// 是否皮试
        /// </summary>
        public bool IsSkinTest
        {
            get { return this._isSkinTest; }
            set { this._isSkinTest = value; }
        }


        /// <summary>
        /// OuRecipeDtl.ID（处方明细ID）
        /// </summary>
        public string RecipeDtlId
        {
            get { return this._recipeDtlId; }
            set { this._recipeDtlId = value; }
        }
        public string ExecuteUserId
        {
            get { return _executeUserId;} set { _executeUserId = value; }
        }
    }  
}           


