

using System;
namespace Orm.Model
{
	/// <summary>
	/// 挂号费用 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsRegPatAmount:BaseModel
	{   
		 
		private string _regTypeID;  //不要删除此表（根据挂号类型与病人类型得到诊金）
		
		private string _patTypeID;  //病人类别
		
		private double _regFee;  //挂号费
		
		private double _diagnoFee;  //诊金
		
		private double _otherFee1;  //其他费用1
		
		private double _otherFee2;  //其他费用2
		
		private double _paySel;  //诊金的自付比例
		
		private double _tallyFee;  //记账诊金
		
		private int _iconIndex;  //图标类型
		
		private string _diagFeeItemId;  //诊查费对应的itemid
		
		private double _zyFee;  //工本费
		
		private string _upcode;  //行心云:上报码
		
		private string _ybCode;  //行心云:医保码
		
		private string _modiOperID;  //行心云:最后修改人
		
		private DateTime _modiTime;  //行心云:最后修改时间
		
		private int _HospitalID;  //
		  
		/// <summary>
		/// 不要删除此表（根据挂号类型与病人类型得到诊金）
		/// </summary>
		public string RegTypeID
		{
			get { return _regTypeID;}
			set { _regTypeID = value;}
		}                                    
		
		/// <summary>
		/// 病人类别
		/// </summary>
		public string PatTypeID
		{
			get { return _patTypeID;}
			set { _patTypeID = value;}
		}                                    
		
		/// <summary>
		/// 挂号费
		/// </summary>
		public double RegFee
		{
			get { return _regFee;}
			set { _regFee = value;}
		}                                    
		
		/// <summary>
		/// 诊金
		/// </summary>
		public double DiagnoFee
		{
			get { return _diagnoFee;}
			set { _diagnoFee = value;}
		}                                    
		
		/// <summary>
		/// 其他费用1
		/// </summary>
		public double OtherFee1
		{
			get { return _otherFee1;}
			set { _otherFee1 = value;}
		}                                    
		
		/// <summary>
		/// 其他费用2
		/// </summary>
		public double OtherFee2
		{
			get { return _otherFee2;}
			set { _otherFee2 = value;}
		}                                    
		
		/// <summary>
		/// 诊金的自付比例
		/// </summary>
		public double PaySel
		{
			get { return _paySel;}
			set { _paySel = value;}
		}                                    
		
		/// <summary>
		/// 记账诊金
		/// </summary>
		public double TallyFee
		{
			get { return _tallyFee;}
			set { _tallyFee = value;}
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
		/// 诊查费对应的itemid
		/// </summary>
		public string DiagFeeItemId
		{
			get { return _diagFeeItemId;}
			set { _diagFeeItemId = value;}
		}                                    
		
		/// <summary>
		/// 工本费
		/// </summary>
		public double ZyFee
		{
			get { return _zyFee;}
			set { _zyFee = value;}
		}                                    
		
		/// <summary>
		/// 行心云:上报码
		/// </summary>
		public string Upcode
		{
			get { return _upcode;}
			set { _upcode = value;}
		}                                    
		
		/// <summary>
		/// 行心云:医保码
		/// </summary>
		public string YbCode
		{
			get { return _ybCode;}
			set { _ybCode = value;}
		}                                    
		
		/// <summary>
		/// 行心云:最后修改人
		/// </summary>
		public string ModiOperID
		{
			get { return _modiOperID;}
			set { _modiOperID = value;}
		}                                    
		
		/// <summary>
		/// 行心云:最后修改时间
		/// </summary>
		public DateTime ModiTime
		{
			get { return _modiTime;}
			set { _modiTime = value;}
		}                                    
		
	                                  
		        
	}  
}           


