

using System;
namespace Orm.Model
{
	/// <summary>
	/// 发票设置 - 实体类
	/// </summary>
	[Serializable]
	public partial class GblInvReg : BaseModel
    {    
		private string _invType;  //发票类别：1-门诊挂号；2-门诊收费；3-住院按金；4-住院收费
		
		private string _name;  //窗口号
		
		private string _startInvoNo;  //起始发票号码
		
		private string _endInvoNo;  //结束发票号码
		
		private bool _isEnd;  //是否已用完
		
		private DateTime _endTime;  //标识用完的时间
		
		private DateTime _operTime;  //交款时间
		
		private string _operID;  //操作员
		
		private string _modiOperId;  //行心云:最后修改人
		
		private DateTime _modiTime;  //行心云:最后修改时间
		
		private int _HospitalID;  //

        private int _hisType;
		 
         
		/// <summary>
		/// 发票类别：1-门诊挂号；2-门诊收费；3-住院按金；4-住院收费
		/// </summary>
		public string InvType
		{
			get { return _invType;}
			set { _invType = value;}
		}                                    
		
		/// <summary>
		/// 窗口号
		/// </summary>
		public string Name
		{
			get { return _name;}
			set { _name = value;}
		}                                    
		
		/// <summary>
		/// 起始发票号码
		/// </summary>
		public string StartInvoNo
		{
			get { return _startInvoNo;}
			set { _startInvoNo = value;}
		}                                    
		
		/// <summary>
		/// 结束发票号码
		/// </summary>
		public string EndInvoNo
		{
			get { return _endInvoNo;}
			set { _endInvoNo = value;}
		}                                    
		
		/// <summary>
		/// 是否已用完
		/// </summary>
		public bool IsEnd
		{
			get { return _isEnd;}
			set { _isEnd = value;}
		}                                    
		
		/// <summary>
		/// 标识用完的时间
		/// </summary>
		public DateTime EndTime
		{
			get { return _endTime;}
			set { _endTime = value;}
		}                                    
		
		/// <summary>
		/// 交款时间
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 操作员
		/// </summary>
		public string OperID
		{
			get { return _operID;}
			set { _operID = value;}
		}                                    
		
		/// <summary>
		/// 行心云:最后修改人
		/// </summary>
		public string ModiOperId
		{
			get { return _modiOperId;}
			set { _modiOperId = value;}
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
        /// 产品类型: 0：共享，1：HIS，2：行心云
        /// </summary>
        public int HisType
        {
            get { return _hisType; }
            set { _hisType = value; }
        }                                    
		        
	}  
}           


