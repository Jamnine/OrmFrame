

using System;
namespace Orm.Model
{
	/// <summary>
	/// 单位体检项目 - 实体类
	/// </summary>
	[Serializable]
	public partial class CkCompGroupPsApply : BaseModel
    {   
		
		private DateTime _operTime;  //申请时间
		
		private string _operId;  //申请人
		
		private int _xType;  //申请类别：1-CT；2-DR；3-MR；4-CR；5-RF；6-US；7-脑电图；8-心电图；9-镜检查；10-MG；11-DSA；12-普放；13-病理；14-其它
		
		private bool _isPre;  //是否预约
		
		private string _itemId;  //检查项目
		
		private string _applyMemo;  //申请备注
		
		private string _summary;  //总结
		
		private string _diagnose;  //诊断
		
		private string _compGroupId;  //对应表CkCompanyGroup.Id
		
		private string _checkBody;  //检查部位
		
		private bool _isAuthed;  //已经封存，不可改删

        private int _HospitalID;  //

                                   
		
		/// <summary>
		/// 申请时间
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 申请人
		/// </summary>
		public string OperId
		{
			get { return _operId;}
			set { _operId = value;}
		}                                    
		
		/// <summary>
		/// 申请类别：1-CT；2-DR；3-MR；4-CR；5-RF；6-US；7-脑电图；8-心电图；9-镜检查；10-MG；11-DSA；12-普放；13-病理；14-其它
		/// </summary>
		public int XType
		{
			get { return _xType;}
			set { _xType = value;}
		}                                    
		
		/// <summary>
		/// 是否预约
		/// </summary>
		public bool IsPre
		{
			get { return _isPre;}
			set { _isPre = value;}
		}                                    
		
		/// <summary>
		/// 检查项目
		/// </summary>
		public string ItemId
		{
			get { return _itemId;}
			set { _itemId = value;}
		}                                    
		
		/// <summary>
		/// 申请备注
		/// </summary>
		public string ApplyMemo
		{
			get { return _applyMemo;}
			set { _applyMemo = value;}
		}                                    
		
		/// <summary>
		/// 总结
		/// </summary>
		public string Summary
		{
			get { return _summary;}
			set { _summary = value;}
		}                                    
		
		/// <summary>
		/// 诊断
		/// </summary>
		public string Diagnose
		{
			get { return _diagnose;}
			set { _diagnose = value;}
		}                                    
		
		/// <summary>
		/// 对应表CkCompanyGroup.Id
		/// </summary>
		public string CompGroupId
		{
			get { return _compGroupId;}
			set { _compGroupId = value;}
		}                                    
		
		/// <summary>
		/// 检查部位
		/// </summary>
		public string CheckBody
		{
			get { return _checkBody;}
			set { _checkBody = value;}
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


