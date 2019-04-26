

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class OpsCharge : BaseModel
    {    
		private string _applyId;  //申请IdOpsApply.Id
		
		private int _listNum;  //序号
		
		private string _itemId;  //项目ID对应Bsitem.id
		
		private string _remark;  //备注
		
		private DateTime _operTime;  //登记日期时间
		
		private string _operID;  //申请人
		
		private bool _isTally;  //是否已记帐
		
		private double _before;  //术前
		
		private double _progress;  //术中
		
		private double _after;  //术后
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //
		 
         
		/// <summary>
		/// 申请IdOpsApply.Id
		/// </summary>
		public string ApplyId
		{
			get { return _applyId;}
			set { _applyId = value;}
		}                                    
		
		/// <summary>
		/// 序号
		/// </summary>
		public int ListNum
		{
			get { return _listNum;}
			set { _listNum = value;}
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
		/// 备注
		/// </summary>
		public string Remark
		{
			get { return _remark;}
			set { _remark = value;}
		}                                    
		
		/// <summary>
		/// 登记日期时间
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 申请人
		/// </summary>
		public string OperID
		{
			get { return _operID;}
			set { _operID = value;}
		}                                    
		
		/// <summary>
		/// 是否已记帐
		/// </summary>
		public bool IsTally
		{
			get { return _isTally;}
			set { _isTally = value;}
		}                                    
		
		/// <summary>
		/// 术前
		/// </summary>
		public double Before
		{
			get { return _before;}
			set { _before = value;}
		}                                    
		
		/// <summary>
		/// 术中
		/// </summary>
		public double Progress
		{
			get { return _progress;}
			set { _progress = value;}
		}                                    
		
		/// <summary>
		/// 术后
		/// </summary>
		public double After
		{
			get { return _after;}
			set { _after = value;}
		}                                    
		
		/// <summary>
		/// 已经封存，不可改删
		/// </summary>
		public bool IsAuthed
		{
			get { return _isAuthed;}
			set { _isAuthed = value;}
		}                                    
		                                   
		        
	}  
}           


