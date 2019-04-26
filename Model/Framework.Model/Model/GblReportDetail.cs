

using System;
namespace Orm.Model
{
	/// <summary>
	/// 报表内容设置 - 实体类
	/// </summary>
	[Serializable]
	public partial class GblReportDetail : BaseModel
    {   
		 
		private string _groupId;  //GblReportGroup.id
		
		private string _feeId;  //基础分类FeeId
		
		private int _HospitalID;  //
		 
                                    
		
		/// <summary>
		/// GblReportGroup.id
		/// </summary>
		public string GroupId
		{
			get { return _groupId;}
			set { _groupId = value;}
		}                                    
		
		/// <summary>
		/// 基础分类FeeId
		/// </summary>
		public string FeeId
		{
			get { return _feeId;}
			set { _feeId = value;}
		}                                    
		                                  
		        
	}  
}           


