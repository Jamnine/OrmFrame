

using System;
namespace Orm.Model
{
	/// <summary>
	/// 门诊处方 - 实体类
	/// </summary>
	[Serializable]
	public partial class OuRecipe : BaseModel
	{   
		
		private string _mzRegId;  //门诊流水号
		
		private int _lsRepType;  //处方种类：1-西药；2-中药；3-检查/检验/治疗
		
		private string _recipeNum;  //处方号
		
		private DateTime _recipeTime;  //处方日期
		
		private string _locationId;  //关联到LOCATION表
		
		private string _doctorId;  //关联到DOCTOR表
		
		private int _howMany;  //中药剂数
		
		private bool _isPriority;  //优先
		
		private string _memo;  //备注
		
		private bool _isPend;  //是否挂起发药处方
		
		private bool _isExecuted;  //是否发药挂起
		
		private string _patId;  //病人ID，对应于Patient的Pat_Id
		
		private bool _isDosage;  //是否已配药
		
		private string _dosageOperId;  //配药人
		
		private DateTime _dosageTime;  //配药时间 
		
		private int _lsCookSelf;  //煎药方法：1-代煎；2-自煎
		
		private bool _isPrinted;  //是否已经打印
		
		private bool _isPutDrug;  //摆药
		
		private string _tempStr;  //代码临时使用
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private DateTime _ouChargeDate;  //行心云:收费时间
		
		private double _amount;  //行心云:金额

        private string _deptNo;

        private string _deptAddress;

        private string _deptName;

        public string DeptAddress
        {
            get
            {
                return this._deptAddress;
            }
            set
            {
                this._deptAddress = value;
            }
        }
        public string DeptNo
        {
            get
            {
                return this._deptNo;
            }
            set
            {
                this._deptNo = value;
            }
        }
        public string DeptName
        {
            get
            {
                return this._deptName;
            }
            set
            {
                this._deptName = value;
            }
        }


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
		/// 处方号
		/// </summary>
		public string RecipeNum
		{
			get { return _recipeNum;}
			set { _recipeNum = value;}
		}                                    
		
		/// <summary>
		/// 处方日期
		/// </summary>
		public DateTime RecipeTime
		{
			get { return _recipeTime;}
			set { _recipeTime = value;}
		}                                    
		
		/// <summary>
		/// 关联到LOCATION表
		/// </summary>
		public string LocationId
		{
			get { return _locationId;}
			set { _locationId = value;}
		}                                    
		
		/// <summary>
		/// 关联到DOCTOR表
		/// </summary>
		public string DoctorId
		{
			get { return _doctorId;}
			set { _doctorId = value;}
		}                                    
		
		/// <summary>
		/// 中药剂数
		/// </summary>
		public int HowMany
		{
			get { return _howMany;}
			set { _howMany = value;}
		}                                    
		
		/// <summary>
		/// 优先
		/// </summary>
		public bool IsPriority
		{
			get { return _isPriority;}
			set { _isPriority = value;}
		}                                    
		
		/// <summary>
		/// 备注
		/// </summary>
		public string Memo
		{
			get { return _memo;}
			set { _memo = value;}
		}                                    
		
		/// <summary>
		/// 是否挂起发药处方
		/// </summary>
		public bool IsPend
		{
			get { return _isPend;}
			set { _isPend = value;}
		}                                    
		
		/// <summary>
		/// 是否发药挂起
		/// </summary>
		public bool IsExecuted
		{
			get { return _isExecuted;}
			set { _isExecuted = value;}
		}                                    
		
		/// <summary>
		/// 病人ID，对应于Patient的Pat_Id
		/// </summary>
		public string PatId
		{
			get { return _patId;}
			set { _patId = value;}
		}                                    
		
		/// <summary>
		/// 是否已配药
		/// </summary>
		public bool IsDosage
		{
			get { return _isDosage;}
			set { _isDosage = value;}
		}                                    
		
		/// <summary>
		/// 配药人
		/// </summary>
		public string DosageOperId
		{
			get { return _dosageOperId;}
			set { _dosageOperId = value;}
		}                                    
		
		/// <summary>
		/// 配药时间
		/// </summary>
		public DateTime DosageTime
		{
			get { return _dosageTime;}
			set { _dosageTime = value;}
		}                                    
		
	                                
		
		/// <summary>
		/// 煎药方法：1-代煎；2-自煎
		/// </summary>
		public int LsCookSelf
		{
			get { return _lsCookSelf;}
			set { _lsCookSelf = value;}
		}                                    
		
		/// <summary>
		/// 是否已经打印
		/// </summary>
		public bool IsPrinted
		{
			get { return _isPrinted;}
			set { _isPrinted = value;}
		}                                    
		
		/// <summary>
		/// 摆药
		/// </summary>
		public bool IsPutDrug
		{
			get { return _isPutDrug;}
			set { _isPutDrug = value;}
		}                                    
		
		/// <summary>
		/// 代码临时使用
		/// </summary>
		public string TempStr
		{
			get { return _tempStr;}
			set { _tempStr = value;}
		}                                    
		
		/// <summary>
		/// 已经封存，不可改删
		/// </summary>
		public bool IsAuthed
		{
			get { return _isAuthed;}
			set { _isAuthed = value;}
		}                                    
		
		/// <summary>
		/// 行心云:收费时间

		/// </summary>
		public DateTime OuChargeDate
		{
			get { return _ouChargeDate;}
			set { _ouChargeDate = value;}
		}                                    
		
		/// <summary>
		/// 行心云:金额
		/// </summary>
		public double Amount
		{
			get { return _amount;}
			set { _amount = value;}
		}
 

    }  
}           


