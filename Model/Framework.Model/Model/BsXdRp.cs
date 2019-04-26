

using System;
namespace Orm.Model
{
	/// <summary>
	/// 减号套餐主表 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsXdRp : BaseModel
    {   
		 
		private string _code=string.Empty;  //协定处方ID
		
		private string _name = string.Empty;  //协定处方名称
		
		private string _groupMain = string.Empty;  //一级分组
		
		private string _groupSub = string.Empty;  //二级分组
		
		private int _orderBy;  //显示次序
		
		private bool _isActive;  //是否可用
		
		private string _wbCode = string.Empty;  //五笔码
		
		private string _pyCode = string.Empty;  //拼音码
		
		private int _lsOpenType;  //使用权：1-个人；2-科室；3-公共
		
		private string _operId = string.Empty;  //创建人
		
		private DateTime _operTime;  //创建时间
		
		private string _locationId = string.Empty;  //创建部门
		
		private int _iconIndex;  //图标类型
		
		private string _testId = string.Empty;  //检验项目ID,CkItem.Id
		
		private int _lsInOut;  //1-门诊科室;2-住院科室;3-所有业务科室;
		
		private string _execLocId = string.Empty;  //执行科室
		
		private int _ntime;  //套餐次数显示
		
		private double _discountAoumt;  //折扣金额
		
		private double _amount;  //行心云:金额
		
		private string _feemzId = string.Empty;  //行心云:项目类别

        private int _feemzIdCode;  //行心云:项目类别 对应 EnumFeeMzId 中的项

        private string _modioperId = string.Empty;  //行心云:最后修改人
		
		private DateTime _modiTime;  //行心云:最后修改时间
		
		private int _HospitalID;  //

        public BsXdRp() { }
         
		/// <summary>
		/// 协定处方ID
		/// </summary>
		public string Code
		{
			get { return _code;}
			set { _code = value;}
		}                                    
		
		/// <summary>
		/// 协定处方名称
		/// </summary>
		public string Name
		{
			get { return _name;}
			set { _name = value;}
		}                                    
		
		/// <summary>
		/// 一级分组
		/// </summary>
		public string GroupMain
		{
			get { return _groupMain;}
			set { _groupMain = value;}
		}                                    
		
		/// <summary>
		/// 二级分组
		/// </summary>
		public string GroupSub
		{
			get { return _groupSub;}
			set { _groupSub = value;}
		}                                    
		
		/// <summary>
		/// 显示次序
		/// </summary>
		public int OrderBy
		{
			get { return _orderBy;}
			set { _orderBy = value;}
		}                                    
		
		/// <summary>
		/// 是否可用
		/// </summary>
		public bool IsActive
		{
			get { return _isActive;}
			set { _isActive = value;}
		}                                    
		
		/// <summary>
		/// 五笔码
		/// </summary>
		public string WbCode
		{
			get { return _wbCode;}
			set { _wbCode = value;}
		}                                    
		
		/// <summary>
		/// 拼音码
		/// </summary>
		public string PyCode
		{
			get { return _pyCode;}
			set { _pyCode = value;}
		}                                    
		
		/// <summary>
		/// 使用权：1-个人；2-科室；3-公共
		/// </summary>
		public int LsOpenType
		{
			get { return _lsOpenType;}
			set { _lsOpenType = value;}
		}                                    
		
		/// <summary>
		/// 创建人
		/// </summary>
		public string OperId
		{
			get { return _operId;}
			set { _operId = value;}
		}                                    
		
		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 创建部门
		/// </summary>
		public string LocationId
		{
			get { return _locationId;}
			set { _locationId = value;}
		}                                    
		
		/// <summary>
		/// 图标类型
		/// </summary>
		public int IconIndex
		{
			get { return _iconIndex;}
			set { _iconIndex = value;}
		}                                    
		
		/// <summary>
		/// 检验项目ID,CkItem.Id
		/// </summary>
		public string TestId
		{
			get { return _testId;}
			set { _testId = value;}
		}                                    
		
		/// <summary>
		/// 1-门诊科室;2-住院科室;3-所有业务科室;
		/// </summary>
		public int LsInOut
		{
			get { return _lsInOut;}
			set { _lsInOut = value;}
		}                                    
		
		/// <summary>
		/// 执行科室
		/// </summary>
		public string ExecLocId
		{
			get { return _execLocId;}
			set { _execLocId = value;}
		}                                    
		
		/// <summary>
		/// 套餐次数显示
		/// </summary>
		public int Ntime
		{
			get { return _ntime;}
			set { _ntime = value;}
		}                                    
		
		/// <summary>
		/// 折扣金额
		/// </summary>
		public double DiscountAoumt
		{
			get { return _discountAoumt;}
			set { _discountAoumt = value;}
		}                                    
		
		/// <summary>
		/// 行心云:金额
		/// </summary>
		public double Amount
		{
			get { return _amount;}
			set { _amount = value;}
		}

        /// <summary>
        /// 行心云:项目类别 FeeMzId FeemzId
        /// </summary>
        public string FeemzId
        {
			get { return _feemzId;}
			set { _feemzId = value;}
		}                                    
		
		/// <summary>
		/// 行心云:最后修改人
		/// </summary>
		public string ModioperId
		{
			get { return _modioperId;}
			set { _modioperId = value;}
		}                                    
		
		/// <summary>
		/// 行心云:最后修改时间
		/// </summary>
		public DateTime ModiTime
		{
			get { return _modiTime;}
			set { _modiTime = value;}
		}                                    
		


        /// <summary>
        /// 行心云:项目类别 对应 EnumFeeMzId 中的项
        /// </summary>
        public int FeemzIdCode
        {
            get { return _feemzIdCode; }
            set { _feemzIdCode = value; }
        }
    }  
}           


