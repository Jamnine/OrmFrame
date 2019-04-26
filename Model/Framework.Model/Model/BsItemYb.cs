

using System;
namespace Orm.Model
{
	/// <summary>
	/// 项目对应医保码 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsItemYb : BaseModel
	{   
		 
		private string _itemId;  //项目ID
		
		private string _tallyGroupId;  //医保种类
		
		private string _ybCode;  //医保码
		
		private string _ybDesc;  //标准中文名
		
		private int _lsYbType;  //类别：1-甲类；2-乙类；3-自费；4-丙类
		
		private int _iconIndex;  //图标类型
		
		private int _lsAuthstatus;  //审核状态：1-未审核；2-已审核
		
		private string _drugCode;  //药监码
		
		private string _yblimitCue;  //医保限制提示
		
		private bool _isYblimit;  //是否提示限制用药提示
		
		private string _upCode;  //行心云:上报码
		
		private string _modioperId;  //行心云:最后修改人
		
		private DateTime _modiTime;  //行心云:最后修改时间

        public BsItemYb() { }
         
		/// <summary>
		/// 项目ID
		/// </summary>
		public string ItemId
		{
			get { return _itemId;}
			set { _itemId = value;}
		}                                    
		
		/// <summary>
		/// 医保种类
		/// </summary>
		public string TallyGroupId
		{
			get { return _tallyGroupId;}
			set { _tallyGroupId = value;}
		}                                    
		
		/// <summary>
		/// 医保码
		/// </summary>
		public string YbCode
		{
			get { return _ybCode;}
			set { _ybCode = value;}
		}                                    
		
		/// <summary>
		/// 标准中文名
		/// </summary>
		public string YbDesc
		{
			get { return _ybDesc;}
			set { _ybDesc = value;}
		}                                    
		
		/// <summary>
		/// 类别：1-甲类；2-乙类；3-自费；4-丙类
		/// </summary>
		public int LsYbType
		{
			get { return _lsYbType;}
			set { _lsYbType = value;}
		}                                    
		
		/// <summary>
		/// 图标类型
		/// </summary>
		public int IconIndex
		{
			get { return _iconIndex;}
			set { _iconIndex = value;}
		}                                    
		
		/// <summary>
		/// 审核状态：1-未审核；2-已审核
		/// </summary>
		public int LsAuthstatus
		{
			get { return _lsAuthstatus;}
			set { _lsAuthstatus = value;}
		}                                    
		
		/// <summary>
		/// 药监码
		/// </summary>
		public string DrugCode
		{
			get { return _drugCode;}
			set { _drugCode = value;}
		}                                    
		
		/// <summary>
		/// 医保限制提示
		/// </summary>
		public string YblimitCue
		{
			get { return _yblimitCue;}
			set { _yblimitCue = value;}
		}                                    
		
		/// <summary>
		/// 是否提示限制用药提示
		/// </summary>
		public bool IsYblimit
		{
			get { return _isYblimit;}
			set { _isYblimit = value;}
		}                                    
		
		/// <summary>
		/// 行心云:上报码
		/// </summary>
		public string UpCode
		{
			get { return _upCode;}
			set { _upCode = value;}
		}                                    
		
		/// <summary>
		/// 行心云:最后修改人
		/// </summary>
		public string ModioperId
		{
			get { return _modioperId;}
			set { _modioperId = value;}
		}                                    
		
		/// <summary>
		/// 行心云:最后修改时间
		/// </summary>
		public DateTime ModiTime
		{
			get { return _modiTime;}
			set { _modiTime = value;}
		}                                    
		        
	}  
}           


