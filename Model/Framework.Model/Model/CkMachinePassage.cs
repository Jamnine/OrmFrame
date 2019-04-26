

using System;
namespace Orm.Model
{
	/// <summary>
	/// 检验仪器项目通道号 - 实体类
	/// </summary>
	[Serializable]
    public partial class CkMachinePassage : BaseModel
	{   
		 
		private string _machineID;  //检验仪器CKMachine.GUID
		
		private string _testID;  //检验项目ID,对应CkItem.Id
		
		private string _passAgeNum;  //
		
		private double _modulus;  //
		
		private bool _isQc;  //是否QC可用的通道
		
		private string _engshortName;  //
		
		private string _factor;  //
		
		private string _testType;  //
		
		private bool _isdiluction;  //
		
		private int _precision;  //
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //

        private string _tjItemCode;

        /// <summary>
        /// 检验仪器CKMachine.GUID
        /// </summary>
        public string MachineID
		{
			get { return _machineID;}
			set { _machineID = value;}
		}                                    
		
		/// <summary>
		/// 检验项目ID,对应CkItem.Id
		/// </summary>
		public string TestID
		{
			get { return _testID;}
			set { _testID = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string PassAgeNum
		{
			get { return _passAgeNum;}
			set { _passAgeNum = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double Modulus
		{
			get { return _modulus;}
			set { _modulus = value;}
		}                                    
		
		/// <summary>
		/// 是否QC可用的通道
		/// </summary>
		public bool IsQc
		{
			get { return _isQc;}
			set { _isQc = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string EngshortName
		{
			get { return _engshortName;}
			set { _engshortName = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string Factor
		{
			get { return _factor;}
			set { _factor = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string TestType
		{
			get { return _testType;}
			set { _testType = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public bool Isdiluction
		{
			get { return _isdiluction;}
			set { _isdiluction = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int Precision
		{
			get { return _precision;}
			set { _precision = value;}
		}                                    
		
		/// <summary>
		/// 已经封存，不可改删
		/// </summary>
		public bool IsAuthed
		{
			get { return _isAuthed;}
			set { _isAuthed = value;}
		}                                    
		


        /// <summary>
        /// 
        /// </summary>
        public string TjItemCode
        {
            get { return _tjItemCode; }
            set { _tjItemCode = value; }
        }
        
    }  
}           


