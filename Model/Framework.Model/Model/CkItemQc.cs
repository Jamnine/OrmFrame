

using System;
namespace Orm.Model
{
	/// <summary>
	/// 检验质控 - 实体类
	/// </summary>
	[Serializable]
    public partial class CkItemQc : BaseModel
	{   
		 
		private string _testId;  //检验项目ID,对应CkItem.Id
		
		private string _qcName;  //QC标准
		
		private double _dev3;  //标准差+3
		
		private double _dev2;  //标准差+2
		
		private double _dev1;  //标准差+1
		
		private double _devM1;  //标准差-1
		
		private double _devM2;  //标准差-2
		
		private double _devM3;  //标准差-3
		
		private double _avgValue;  //平均值
		
		private string _ctrlId;  //
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //
		  
		/// <summary>
		/// 检验项目ID,对应CkItem.Id
		/// </summary>
		public string TestId
		{
			get { return _testId;}
			set { _testId = value;}
		}                                    
		
		/// <summary>
		/// QC标准
		/// </summary>
		public string QcName
		{
			get { return _qcName;}
			set { _qcName = value;}
		}                                    
		
		/// <summary>
		/// 标准差+3
		/// </summary>
		public double Dev3
		{
			get { return _dev3;}
			set { _dev3 = value;}
		}                                    
		
		/// <summary>
		/// 标准差+2
		/// </summary>
		public double Dev2
		{
			get { return _dev2;}
			set { _dev2 = value;}
		}                                    
		
		/// <summary>
		/// 标准差+1
		/// </summary>
		public double Dev1
		{
			get { return _dev1;}
			set { _dev1 = value;}
		}                                    
		
		/// <summary>
		/// 标准差-1
		/// </summary>
		public double DevM1
		{
			get { return _devM1;}
			set { _devM1 = value;}
		}                                    
		
		/// <summary>
		/// 标准差-2
		/// </summary>
		public double DevM2
		{
			get { return _devM2;}
			set { _devM2 = value;}
		}                                    
		
		/// <summary>
		/// 标准差-3
		/// </summary>
		public double DevM3
		{
			get { return _devM3;}
			set { _devM3 = value;}
		}                                    
		
		/// <summary>
		/// 平均值
		/// </summary>
		public double AvgValue
		{
			get { return _avgValue;}
			set { _avgValue = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string CtrlId
		{
			get { return _ctrlId;}
			set { _ctrlId = value;}
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


