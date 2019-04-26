

using System;
namespace Orm.Model
{
	/// <summary>
	/// 迁移病人 - 实体类
	/// </summary>
	[Serializable]
	public partial class HistMoveHosInfo : BaseModel
    {   
		 
		private string _recordId;  //病人ID,Ouhosinfo.idorinhosinfo.id
		
		private int _lsInout;  //1:门诊2:住院
		
		private DateTime _operTime;  //操作时间
		
		private int _HospitalID;  //
		  
		/// <summary>
		/// 病人ID,Ouhosinfo.idorinhosinfo.id
		/// </summary>
		public string RecordId
		{
			get { return _recordId;}
			set { _recordId = value;}
		}                                    
		
		/// <summary>
		/// 1:门诊2:住院
		/// </summary>
		public int LsInout
		{
			get { return _lsInout;}
			set { _lsInout = value;}
		}                                    
		
		/// <summary>
		/// 操作时间
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		                                  
		        
	}  
}           


