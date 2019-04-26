

using System;
namespace Orm.Model
{
	/// <summary>
	/// BP的诊断表(一级) - 实体类
	/// </summary>
	[Serializable]
	public partial class BsBPIllList:BaseModel
	{   
		 
		private string _bPIllId;  //对应BP知识库的ID,BP网页上可见
		
		private string _bPIllName;  //疾病名称
		
		private string _wbCode;  //五笔码
		
		private string _pyCode;  //拼音码

        private int _HospitalID;//医院ID
                                  
		
		/// <summary>
		/// 对应BP知识库的ID,BP网页上可见
		/// </summary>
		public string BPIllId
		{
			get { return _bPIllId;}
			set { _bPIllId = value;}
		}                                    
		
		/// <summary>
		/// 疾病名称
		/// </summary>
		public string BPIllName
		{
			get { return _bPIllName;}
			set { _bPIllName = value;}
		}                                    
		
		/// <summary>
		/// 五笔码
		/// </summary>
		public string WbCode
		{
			get { return _wbCode;}
			set { _wbCode = value;}
		}                                    
		
		/// <summary>
		/// 拼音码
		/// </summary>
		public string PyCode
		{
			get { return _pyCode;}
			set { _pyCode = value;}
		}

    
        private string _icd;
        /// <summary>
        /// ICD编码
        /// </summary>
        public string ICD
        {
            get { return _icd; }
            set { _icd = value; }
        }
        private string _icdName;
        /// <summary>
        /// ICD名称
        /// </summary>
        public string ICDName
        {
            get { return _icdName; }
            set { _icdName = value; }
        }
        
        private bool _existBP;
        /// <summary>
        /// 是否存在bp数据
        /// </summary>
        public bool ExistBP
        {
            get { return _existBP; }
            set { _existBP = value; }
        }

        private bool _existChinaMed;
        /// <summary>
        /// 是否存在中药数据
        /// </summary>
        public bool ExistChinaMed
        {
            get { return _existChinaMed; }
            set { _existChinaMed = value; }
        }

        private bool _existPatentMed;
        /// <summary>
        /// 是否存在中成药数据
        /// </summary>
        public bool ExistPatentMed
        {
            get { return _existPatentMed; }
            set { _existPatentMed = value; }
        }
    }  
}           


