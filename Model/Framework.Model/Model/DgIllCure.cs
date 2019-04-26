

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class DgIllCure : BaseModel
    {    
		private string _illId;  //诊断（ICD码）
		
		private string _illGroupId;  //治疗方案组别
		
		private string _cureId;  //对应基本治疗
		
		private string _drugId;  //对应基本药品
		
		private string _checkId;  //对应基本检查
		
		private string _nurseId;  //对应基本护理
		
		private int _lsAdvType;  //医嘱类别：1-长期医嘱；2-临时医嘱
		
		private int _lsCureType;  //治疗类别：1-主要诊疗工作；2-重点医嘱；3-主要护理工作
		
		private bool _isBaby;  //儿童专用
		
		private bool _isWomen;  //妇女专用
		
		private bool _isMen;  //男性专用
		
		private bool _isOlder;  //老人专用
		
		private string _memo;  //特殊情况专用
		
		private int _iconIndex;  //
		
		private double _dosAge;  //用量
		
		private string _unitTakeId;  //服用单位
		
		private string _frequencyId;  //频率，对应PUB_Frequency的Fre_Num
		
		private string _usageId;  //用法
		
		private int _days;  //天数
		
		private double _feeTotality;  //总量
		
		private string _unitId;  //计价单位
		
		private bool _isAuthed;  //已经封存，不可改删
		 
                                 
		
		/// <summary>
		/// 诊断（ICD码）
		/// </summary>
		public string IllId
		{
			get { return _illId;}
			set { _illId = value;}
		}                                    
		
		/// <summary>
		/// 治疗方案组别
		/// </summary>
		public string IllGroupId
		{
			get { return _illGroupId;}
			set { _illGroupId = value;}
		}                                    
		
		/// <summary>
		/// 对应基本治疗
		/// </summary>
		public string CureId
		{
			get { return _cureId;}
			set { _cureId = value;}
		}                                    
		
		/// <summary>
		/// 对应基本药品
		/// </summary>
		public string DrugId
		{
			get { return _drugId;}
			set { _drugId = value;}
		}                                    
		
		/// <summary>
		/// 对应基本检查
		/// </summary>
		public string CheckId
		{
			get { return _checkId;}
			set { _checkId = value;}
		}                                    
		
		/// <summary>
		/// 对应基本护理
		/// </summary>
		public string NurseId
		{
			get { return _nurseId;}
			set { _nurseId = value;}
		}                                    
		
		/// <summary>
		/// 医嘱类别：1-长期医嘱；2-临时医嘱
		/// </summary>
		public int LsAdvType
		{
			get { return _lsAdvType;}
			set { _lsAdvType = value;}
		}                                    
		
		/// <summary>
		/// 治疗类别：1-主要诊疗工作；2-重点医嘱；3-主要护理工作
		/// </summary>
		public int LsCureType
		{
			get { return _lsCureType;}
			set { _lsCureType = value;}
		}                                    
		
		/// <summary>
		/// 儿童专用
		/// </summary>
		public bool IsBaby
		{
			get { return _isBaby;}
			set { _isBaby = value;}
		}                                    
		
		/// <summary>
		/// 妇女专用
		/// </summary>
		public bool IsWomen
		{
			get { return _isWomen;}
			set { _isWomen = value;}
		}                                    
		
		/// <summary>
		/// 男性专用
		/// </summary>
		public bool IsMen
		{
			get { return _isMen;}
			set { _isMen = value;}
		}                                    
		
		/// <summary>
		/// 老人专用
		/// </summary>
		public bool IsOlder
		{
			get { return _isOlder;}
			set { _isOlder = value;}
		}                                    
		
		/// <summary>
		/// 特殊情况专用
		/// </summary>
		public string Memo
		{
			get { return _memo;}
			set { _memo = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int IconIndex
		{
			get { return _iconIndex;}
			set { _iconIndex = value;}
		}                                    
		
		/// <summary>
		/// 用量
		/// </summary>
		public double DosAge
		{
			get { return _dosAge;}
			set { _dosAge = value;}
		}                                    
		
		/// <summary>
		/// 服用单位
		/// </summary>
		public string UnitTakeId
		{
			get { return _unitTakeId;}
			set { _unitTakeId = value;}
		}                                    
		
		/// <summary>
		/// 频率，对应PUB_Frequency的Fre_Num
		/// </summary>
		public string FrequencyId
		{
			get { return _frequencyId;}
			set { _frequencyId = value;}
		}                                    
		
		/// <summary>
		/// 用法
		/// </summary>
		public string UsageId
		{
			get { return _usageId;}
			set { _usageId = value;}
		}                                    
		
		/// <summary>
		/// 天数
		/// </summary>
		public int Days
		{
			get { return _days;}
			set { _days = value;}
		}                                    
		
		/// <summary>
		/// 总量
		/// </summary>
		public double FeeTotality
		{
			get { return _feeTotality;}
			set { _feeTotality = value;}
		}                                    
		
		/// <summary>
		/// 计价单位
		/// </summary>
		public string UnitId
		{
			get { return _unitId;}
			set { _unitId = value;}
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


