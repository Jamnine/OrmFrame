

using System;
using System.Collections.Generic;

namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class BsCheckTestList:BaseModel
	{   
		private string _illId;  //疾病编号
		
		private string _illName;  //疾病名称
		
		private string _groupType;  //检查检验项目分组
		
		private string _checkTestType;  //项目类别
		
		private string _itemId;  //项目编号
		
		private string _itemName;  //项目名称
		
		private string _itemDesc;  //项目描述
		
		private string _itemResult;  //项目结果

        private int _HospitalID;//医院ID
         
		/// <summary>
		/// 疾病编号
		/// </summary>
		public string IllId
		{
			get { return _illId;}
			set { _illId = value;}
		}                                    
		
		/// <summary>
		/// 疾病名称
		/// </summary>
		public string IllName
		{
			get { return _illName;}
			set { _illName = value;}
		}                                    
		
		/// <summary>
		/// 检查检验项目分组
		/// </summary>
		public string GroupType
		{
			get { return _groupType;}
			set { _groupType = value;}
		}                                    
		
		/// <summary>
		/// 项目类别
		/// </summary>
		public string CheckTestType
		{
			get { return _checkTestType;}
			set { _checkTestType = value;}
		}                                    
		
		/// <summary>
		/// 项目编号
		/// </summary>
		public string ItemId
		{
			get { return _itemId;}
			set { _itemId = value;}
		}                                    
		
		/// <summary>
		/// 项目名称
		/// </summary>
		public string ItemName
		{
			get { return _itemName;}
			set { _itemName = value;}
		}                                    
		
		/// <summary>
		/// 项目描述
		/// </summary>
		public string ItemDesc
		{
			get { return _itemDesc;}
			set { _itemDesc = value;}
		}                                    
		
		/// <summary>
		/// 项目结果
		/// </summary>
		public string ItemResult
		{
			get { return _itemResult;}
			set { _itemResult = value;}
		}

        /// <summary>
        /// 医院ID
        /// </summary>
        public int HospitalID
        {
            get { return _HospitalID; }
            set { _HospitalID = value; }
        }

        public List<BsItem> LstItem { get; set; }
    }  
}           


