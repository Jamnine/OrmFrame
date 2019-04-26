

using System;
namespace Orm.Model
{
	/// <summary>
	/// 收费未发药数量（由计划任务生成） - 实体类
	/// </summary>
	[Serializable]
	public partial class RmstoreStockNum : BaseModel
    {   
		
		private DateTime _opertime;  //操作时间
		
		private string _HospitalID;  //院区Id,BsHospital.Id
		
		private int _lsRoomType;  //用途：1-西药药房；2-中药药房；3-配制中心
		
		private int _lsInOut;  //药房分类：1-门诊；2-住院；3-其他
		
		private string _itemId;  //项目ID对应Bsitem.id
		
		private double _stockNum;  //库存数量

        public RmstoreStockNum() { }

        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime opertime
		{
			get { return _opertime;}
			set { _opertime = value;}
		}                                    
		
		/// <summary>
		/// 院区Id,BsHospital.Id
		/// </summary>
		public string HospitalID
		{
			get { return _HospitalID;}
			set { _HospitalID = value;}
		}                                    
		
		/// <summary>
		/// 用途：1-西药药房；2-中药药房；3-配制中心
		/// </summary>
		public int LsRoomType
		{
			get { return _lsRoomType;}
			set { _lsRoomType = value;}
		}                                    
		
		/// <summary>
		/// 药房分类：1-门诊；2-住院；3-其他
		/// </summary>
		public int LsInOut
		{
			get { return _lsInOut;}
			set { _lsInOut = value;}
		}                                    
		
		/// <summary>
		/// 项目ID对应Bsitem.id
		/// </summary>
		public string ItemId
		{
			get { return _itemId;}
			set { _itemId = value;}
		}                                    
		
		/// <summary>
		/// 库存数量
		/// </summary>
		public double StockNum
		{
			get { return _stockNum;}
			set { _stockNum = value;}
		}                                    
		        
	}  
}           


