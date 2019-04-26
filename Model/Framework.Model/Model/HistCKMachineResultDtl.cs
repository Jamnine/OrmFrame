

using System;
namespace Orm.Model
{
	/// <summary>
	/// 历史检验仪器结果明细 - 实体类
	/// </summary>
	[Serializable]
	public partial class HistCKMachineResultDtl : BaseModel
    {   
		
		private DateTime _inSertTime;  //插入时间
		 
		private string _resultID;  //结果ID
		
		private string _testID;  //检验项目ID,对应CkItem.Id
		
		private string _result;  //结果
		
		private string _bench;  //
		
		private int _HospitalID;  //
		 

		
		/// <summary>
		/// 插入时间
		/// </summary>
		public DateTime InSertTime
		{
			get { return _inSertTime;}
			set { _inSertTime = value;}
		}                                    
		 
		/// <summary>
		/// 结果ID
		/// </summary>
		public string ResultID
		{
			get { return _resultID;}
			set { _resultID = value;}
		}                                    
		
		/// <summary>
		/// 检验项目ID,对应CkItem.Id
		/// </summary>
		public string TestID
		{
			get { return _testID;}
			set { _testID = value;}
		}                                    
		
		/// <summary>
		/// 结果
		/// </summary>
		public string Result
		{
			get { return _result;}
			set { _result = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string bench
		{
			get { return _bench;}
			set { _bench = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int HospitalID
		{
			get { return _HospitalID;}
			set { _HospitalID = value;}
		}                                    
		        
	}  
}           


