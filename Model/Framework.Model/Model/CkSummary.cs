

using System;
namespace Orm.Model
{
	/// <summary>
	/// 体检小结 - 实体类
	/// </summary>
	[Serializable]
	public partial class CkSummary:BaseModel
	{   
		 
		private string _mzRegId;  //就诊ID
		
		private string _doctorId;  //体检医生ID
		
		private string _tjLocationID;  //体检科室ID
		
		private string _summary;  //科室小结
		
		private string _suggestion;  //建议
		
		private bool _isOver;  //是否小结
		
		private string _operId;  //操作人ID
		
		private DateTime _operTime;  //操作时间
		
		private string _patID;  //病人ID
		
		private string _cAnalysis;  //综合分析
		
		private string _conclusion;  //健康结论
		
		private string _programme;  //干预方案
		
		private string _testIllustration;  //检测说明
		
		private string _resultDetermine;  //结果判定
		
		private string _rAnalysis;  //结果分析
		
		private string _commonProblem;  //常见问题
		
		private DateTime _saveTime;  //保存时间
		 
		/// <summary>
		/// 就诊ID
		/// </summary>
		public string MzRegId
		{
			get { return _mzRegId;}
			set { _mzRegId = value;}
		}                                    
		
		/// <summary>
		/// 体检医生ID
		/// </summary>
		public string DoctorId
		{
			get { return _doctorId;}
			set { _doctorId = value;}
		}                                    
		
		/// <summary>
		/// 体检科室ID
		/// </summary>
		public string TjLocationID
		{
			get { return _tjLocationID;}
			set { _tjLocationID = value;}
		}                                    
		
		/// <summary>
		/// 科室小结
		/// </summary>
		public string Summary
		{
			get { return _summary;}
			set { _summary = value;}
		}                                    
		
		/// <summary>
		/// 建议
		/// </summary>
		public string Suggestion
		{
			get { return _suggestion;}
			set { _suggestion = value;}
		}                                    
		
		/// <summary>
		/// 是否小结
		/// </summary>
		public bool IsOver
		{
			get { return _isOver;}
			set { _isOver = value;}
		}                                    
		
		/// <summary>
		/// 操作人ID
		/// </summary>
		public string OperId
		{
			get { return _operId;}
			set { _operId = value;}
		}                                    
		
		/// <summary>
		/// 操作时间
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 病人ID
		/// </summary>
		public string PatID
		{
			get { return _patID;}
			set { _patID = value;}
		}                                    
		
		/// <summary>
		/// 综合分析
		/// </summary>
		public string CAnalysis
		{
			get { return _cAnalysis;}
			set { _cAnalysis = value;}
		}                                    
		
		/// <summary>
		/// 健康结论
		/// </summary>
		public string Conclusion
		{
			get { return _conclusion;}
			set { _conclusion = value;}
		}                                    
		
		/// <summary>
		/// 干预方案
		/// </summary>
		public string Programme
		{
			get { return _programme;}
			set { _programme = value;}
		}                                    
		
		/// <summary>
		/// 检测说明
		/// </summary>
		public string TestIllustration
		{
			get { return _testIllustration;}
			set { _testIllustration = value;}
		}                                    
		
		/// <summary>
		/// 结果判定
		/// </summary>
		public string ResultDetermine
		{
			get { return _resultDetermine;}
			set { _resultDetermine = value;}
		}                                    
		
		/// <summary>
		/// 结果分析
		/// </summary>
		public string RAnalysis
		{
			get { return _rAnalysis;}
			set { _rAnalysis = value;}
		}                                    
		
		/// <summary>
		/// 常见问题
		/// </summary>
		public string CommonProblem
		{
			get { return _commonProblem;}
			set { _commonProblem = value;}
		}                                    
		
		/// <summary>
		/// 保存时间
		/// </summary>
		public DateTime SaveTime
		{
			get { return _saveTime;}
			set { _saveTime = value;}
		}                                    
		 
    }  
}           


