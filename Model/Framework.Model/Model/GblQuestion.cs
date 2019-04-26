

using System;
namespace Orm.Model
{
	/// <summary>
	/// 问题答案库 - 实体类
	/// </summary>
	[Serializable]
	public partial class GblQuestion : BaseModel
    {   
		 
		private string _question;  //问题
		
		private string _answer;  //答案
		
		private string _systemId;  //系统菜单GblSystem.Id
		
		private DateTime _operTime;  //登记日期
		
		private string _operID;  //登记人
		
		private int _HospitalID;  //
		 
         
		/// <summary>
		/// 问题
		/// </summary>
		public string Question
		{
			get { return _question;}
			set { _question = value;}
		}                                    
		
		/// <summary>
		/// 答案
		/// </summary>
		public string Answer
		{
			get { return _answer;}
			set { _answer = value;}
		}                                    
		
		/// <summary>
		/// 系统菜单GblSystem.Id
		/// </summary>
		public string SystemId
		{
			get { return _systemId;}
			set { _systemId = value;}
		}                                    
		
		/// <summary>
		/// 登记日期
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 登记人
		/// </summary>
		public string OperID
		{
			get { return _operID;}
			set { _operID = value;}
		}                                    
		                                
		        
	}  
}           


