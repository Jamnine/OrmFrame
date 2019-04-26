

using System;
namespace Orm.Model
{
	/// <summary>
	/// 医生医嘱修改记录 - 实体类
	/// </summary>
	[Serializable]
	public partial class TrAdvice:BaseModel
	{    
		private DateTime _operTime;  //登记时间
		
		private string _operId;  //登记人
		
		private string _adviceId;  //医嘱id号
		
		private int _lsMarkType;  //执行单类：1-长期；2-临时；3-其他；4-床位；5-出院带药
		
		private string _type;  //类别
		
		private string _before;  //更改前
		
		private string _after;  //更改后
		
		private string _hospId;  //入院病人ID,对应Inhosinfo.id
		
		private int _HospitalID;  //
		 

		                            
		
		/// <summary>
		/// 登记时间
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 登记人
		/// </summary>
		public string OperId
		{
			get { return _operId;}
			set { _operId = value;}
		}                                    
		
		/// <summary>
		/// 医嘱id号
		/// </summary>
		public string AdviceId
		{
			get { return _adviceId;}
			set { _adviceId = value;}
		}                                    
		
		/// <summary>
		/// 执行单类：1-长期；2-临时；3-其他；4-床位；5-出院带药
		/// </summary>
		public int LsMarkType
		{
			get { return _lsMarkType;}
			set { _lsMarkType = value;}
		}                                    
		
		/// <summary>
		/// 类别
		/// </summary>
		public string Type
		{
			get { return _type;}
			set { _type = value;}
		}                                    
		
		/// <summary>
		/// 更改前
		/// </summary>
		public string Before
		{
			get { return _before;}
			set { _before = value;}
		}                                    
		
		/// <summary>
		/// 更改后
		/// </summary>
		public string After
		{
			get { return _after;}
			set { _after = value;}
		}                                    
		
		/// <summary>
		/// 入院病人ID,对应Inhosinfo.id
		/// </summary>
		public string HospId
		{
			get { return _hospId;}
			set { _hospId = value;}
		}                                    
		                                   
		        
	}  
}           


