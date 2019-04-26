

using System;
namespace Orm.Model
{
	/// <summary>
	/// 汉字编码库 - 实体类
	/// </summary>
	[Serializable]
	public partial class GblChinChar:BaseModel
	{    
		private string _name;  //名称
		
		private string _pyCode;  //拼音码
		
		private string _pyChar;  //拼音首字母
		
		private string _wbCode;  //五笔码
		
		private string _wbChar;  //
		
		private string _modiOperId;  //行心云:最后修改人
		
		private DateTime _modiTime;  //行心云:最后修改时间
		
		private int _HospitalID;  //

        public GblChinChar() { }
         
		/// <summary>
		/// 名称
		/// </summary>
        [Collumn(HeaderName ="名称",RelatedTableType =null,Length =1)]
		public string Name
		{
			get { return _name;}
			set { _name = value;}
		}                                    
		
		/// <summary>
		/// 拼音码
		/// </summary>
        [Collumn(HeaderName ="拼音码",RelatedTableType =null)]
		public string PyCode
		{
			get { return _pyCode;}
			set { _pyCode = value;}
		}                                    
		
		/// <summary>
		/// 拼音首字母
		/// </summary>
        [Collumn(HeaderName ="拼音字符",RelatedTableType =null)]
		public string PyChar
		{
			get { return _pyChar;}
			set { _pyChar = value;}
		}                                    
		
		/// <summary>
		/// 五笔码
		/// </summary>
        [Collumn(HeaderName ="五笔码",RelatedTableType =null)]
		public string WbCode
		{
			get { return _wbCode;}
			set { _wbCode = value;}
		}

        /// <summary>
        /// 
        /// </summary>
        [Collumn(HeaderName = "五笔字符", RelatedTableType = null)]
        public string WbChar
		{
			get { return _wbChar;}
			set { _wbChar = value;}
		}

        /// <summary>
        /// 行心云:最后修改人
        /// </summary>
        [Collumn(HeaderName = "ModiOperId", RelatedTableType = null, IsShow = false)]
        public string ModiOperId
		{
			get { return _modiOperId;}
			set { _modiOperId = value;}
		}

        /// <summary>
        /// 行心云:最后修改时间
        /// </summary>
        [Collumn(HeaderName = "ModiTime", RelatedTableType = null, IsShow = false)]
        public DateTime ModiTime
		{
			get { return _modiTime;}
			set { _modiTime = value;}
		}

    

                                      
		        
	}  
}           


