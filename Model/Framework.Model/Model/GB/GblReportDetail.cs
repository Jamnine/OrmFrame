

using System;
namespace XYHis.Model
{
	/// <summary>
	/// 报表内容设置 - 实体类***********
	/// </summary>
	[Serializable]
	public partial class GblReportDetail : BaseModel
    {   
		
		
		
		private int _groupId;  //GblReportGroup.id
		
		private int _feeId;  //基础分类FeeId
		
		private int _hospitalId;  //
		 

		
		/// <summary>
		/// 唯一标识
		/// </summary>
		public int Id
		{
			get { return _id;}
			set { _id = value;}
		}                                    
		
		/// <summary>
		/// GblReportGroup.id
		/// </summary>
		public int GroupId
		{
			get { return _groupId;}
			set { _groupId = value;}
		}                                    
		
		/// <summary>
		/// 基础分类FeeId
		/// </summary>
		public int FeeId
		{
			get { return _feeId;}
			set { _feeId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int HospitalId
		{
			get { return _hospitalId;}
			set { _hospitalId = value;}
		}                                    
		        
	}  
}           


