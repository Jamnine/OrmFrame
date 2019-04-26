

using System;
using Orm.Model.EnumDefine;

namespace Orm.Model
{
	/// <summary>
	/// 行心云:处方模板维护主表 - 实体类
	/// </summary>
	[Serializable]
	public partial class TmpRecipeEmr:BaseModel
	{   
				
		private string _lsRepType;  //处方种类：1-西药；2-中药；3-检查/检验/治疗
		
		private string _locationId;  //关联到LOCATION表。外键，引用BsLocation.GUID
		
		private string _memo;  //备注
		
		private string _groupMain;  //一级目录
		
		private string _groupSub;  //二级目录
		
		private string _recipename;  //修改人
		
		private bool _isActive;  //是否启用  0：不启用 1：启用
		
		private string _memoOperId;  //修改人
		
		private DateTime _modificationtime;  //修改时间
		
		private string _memoopername;  //
		
		private string _tmptype;  //模板类型
		
		private string _itemName;  //项目名称
		
		private int _lsOpenType;  //使用权：1-个人；2-诊所；3-公共
		
		private int _HospitalID;  //                             
		
		/// <summary>
		/// 处方种类：1-西药；2-中药；3-检查/检验/治疗
		/// </summary>
		public string  LsRepType
		{
			get { return _lsRepType;}
			set { _lsRepType = value;}
		}                                    
		
		/// <summary>
		/// 关联到LOCATION表。外键，引用BsLocation.GUID
		/// </summary>
		public string LocationId
		{
			get { return _locationId;}
			set { _locationId = value;}
		}                                    
		
		/// <summary>
		/// 备注
		/// </summary>
		public string Memo
		{
			get { return _memo;}
			set { _memo = value;}
		}                                    
		
		/// <summary>
		/// 一级目录
		/// </summary>
		public string GroupMain
		{
			get { return _groupMain;}
			set { _groupMain = value;}
		}                                    
		
		/// <summary>
		/// 二级目录
		/// </summary>
		public string GroupSub
		{
			get { return _groupSub;}
			set { _groupSub = value;}
		}                                    
		
		/// <summary>
		/// 修改人
		/// </summary>
		public string Recipename
		{
			get { return _recipename;}
			set { _recipename = value;}
		}                                    
		
		/// <summary>
		/// 是否启用  0：不启用 1：启用
		/// </summary>
		public bool IsActive
		{
			get { return _isActive;}
			set { _isActive = value;}
		}                                    
		
		/// <summary>
		/// 修改人
		/// </summary>
		public string MemoOperId
		{
			get { return _memoOperId;}
			set { _memoOperId = value;}
		}                                    
		
		/// <summary>
		/// 修改时间
		/// </summary>
		public DateTime Modificationtime
		{
			get { return _modificationtime;}
			set { _modificationtime = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string Memoopername
		{
			get { return _memoopername;}
			set { _memoopername = value;}
		}                                    
		
		/// <summary>
		/// 模板类型
		/// </summary>
		public string Tmptype
		{
			get { return _tmptype;}
			set { _tmptype = value;}
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
		/// 使用权：1-个人；2-诊所；3-公共
		/// </summary>
		public int LsOpenType
		{
			get { return _lsOpenType;}
			set { _lsOpenType = value;}
		}
        private bool _isChineseMedicine = false;
        public bool u_IsChineseMedicine
        {
            get
            {
                if (LsRepType == ((int)EnumRecipeType.中药).ToString())
                {
                    _isChineseMedicine = true;
                }
                else
                {
                    _isChineseMedicine = false;
                }
                return _isChineseMedicine;
            }
            set { _isChineseMedicine = value; }
        }
    }  
}           


