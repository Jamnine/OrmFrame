

using System;
namespace Orm.Model
{
	/// <summary>
	/// 药房药品设置 - 实体类
	/// </summary>
	[Serializable]
	public partial class RmUnderLine : BaseModel
    {    
		
		private string _roomId;  //药房ID,BsRoom.Id
		
		private string _itemId;  //项目ID对应Bsitem.id
		
		private double _underLine;  //库存下限
		
		private double _uperLine;  //库存上限
		
		private double _normal;  //正常库存维持数
		
		private bool _isActive;  //有药可发标志
		
		private int _orderBy;  //显示顺序
		
		private bool _isStop;  //是否停用
		
		private bool _isAuthed;  //已经封存，不可改删

        private int _HospitalID;  //

        private int _hisType;

        private DateTime _insertTime;

        public RmUnderLine() { }

                          
		
		/// <summary>
		/// 药房ID,BsRoom.Id
		/// </summary>
		public string RoomId
		{
			get { return _roomId;}
			set { _roomId = value;}
		}                                    
		
		/// <summary>
		/// 项目ID对应Bsitem.id
		/// </summary>
		public string ItemId
		{
			get { return _itemId;}
			set { _itemId = value;}
		}                                    
		
		/// <summary>
		/// 库存下限
		/// </summary>
		public double UnderLine
		{
			get { return _underLine;}
			set { _underLine = value;}
		}                                    
		
		/// <summary>
		/// 库存上限
		/// </summary>
		public double UperLine
		{
			get { return _uperLine;}
			set { _uperLine = value;}
		}                                    
		
		/// <summary>
		/// 正常库存维持数
		/// </summary>
		public double Normal
		{
			get { return _normal;}
			set { _normal = value;}
		}                                    
		
		/// <summary>
		/// 有药可发标志
		/// </summary>
		public bool IsActive
		{
			get { return _isActive;}
			set { _isActive = value;}
		}                                    
		
		/// <summary>
		/// 显示顺序
		/// </summary>
		public int OrderBy
		{
			get { return _orderBy;}
			set { _orderBy = value;}
		}                                    
		
		/// <summary>
		/// 是否停用
		/// </summary>
		public bool IsStop
		{
			get { return _isStop;}
			set { _isStop = value;}
		}                                    
		
		/// <summary>
		/// 已经封存，不可改删
		/// </summary>
		public bool IsAuthed
		{
			get { return _isAuthed;}
			set { _isAuthed = value;}
		}

      

        public int HisType
        {
            get { return _hisType; }
            set { _hisType = value; }
        }

        public DateTime InsertTime
        {
            get { return _insertTime; }
            set { _insertTime = value; }
        }
    }  
}           


