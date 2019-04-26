

using System;
namespace Orm.Model
{
	/// <summary>
	/// 体检组项目 - 实体类
	/// </summary>
	[Serializable]
	public partial class CkGroupItem : BaseModel
	{   
		
		private string _companyGroupId;  //单位
		
		private string _testId;  //体检项目
		
		private string _parentID;  //父键ID
		
		private string _itemId;  //收费项目
		
		private string _appId;  //申请单
		
		private bool _isAuthed;  //已经封存，不可改删

        private int _HospitalID;  //
        private int _histype = 2;//产品类型：0.共享 1.His 2.行心云

        private DateTime _insertTime;
        

        /// <summary>
        /// 单位
        /// </summary>
        public string CompanyGroupId
		{
			get { return _companyGroupId;}
			set { _companyGroupId = value;}
		}                                    
		
		/// <summary>
		/// 体检项目
		/// </summary>
		public string TestId
		{
			get { return _testId;}
			set { _testId = value;}
		}                                    
		
		/// <summary>
		/// 父键ID
		/// </summary>
		public string ParentID
		{
			get { return _parentID;}
			set { _parentID = value;}
		}                                    
		
		/// <summary>
		/// 项目guid
		/// </summary>
		public string ItemId
		{
			get { return _itemId;}
			set { _itemId = value;}
		}                                    
		
		/// <summary>
		/// 申请单
		/// </summary>
		public string AppId
		{
			get { return _appId;}
			set { _appId = value;}
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
        /// 产品类型：0.共享  1.His 2.行心云
        /// </summary>
        public int HisType
        {
            get { return _histype; }
            set { _histype = value; }
        }

        /// <summary>
        /// 插入时间
        /// </summary>
        public DateTime InsertTime
        {
            get
            {
                return _insertTime;
            }

            set
            {
                _insertTime = value;
            }
        }

    }  
}           


