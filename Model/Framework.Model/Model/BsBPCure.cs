

using System;
namespace Orm.Model
{
	/// <summary>
	/// BP的治疗方案及小字说明表(三级) - 实体类
	/// </summary>
	[Serializable]
	public partial class BsBPCure:BaseModel
	{    
		private string _cureRuleName;  //
		
		private string _cureRuleDesc;  //
		
		private string _bPIllId;  //
		
		private string _bPGroupId;  //
		
		private int _orderBy;  //排序

        private int _hospitalId;//医院ID

         
		/// <summary>
		/// 
		/// </summary>
		public string CureRuleName
		{
			get { return _cureRuleName;}
			set { _cureRuleName = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string CureRuleDesc
		{
			get { return _cureRuleDesc;}
			set { _cureRuleDesc = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string BPIllId
		{
			get { return _bPIllId;}
			set { _bPIllId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string BPGroupId
		{
			get { return _bPGroupId;}
			set { _bPGroupId = value;}
		}                                    
		
		/// <summary>
		/// 排序
		/// </summary>
		public int OrderBy
		{
			get { return _orderBy;}
			set { _orderBy = value;}
		}

    }  
}           


