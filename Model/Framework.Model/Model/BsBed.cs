

using System;
namespace Orm.Model
{
	/// <summary>
	/// 床位 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsBed:BaseModel
	{    
		private string _name;  //床号
		
		private string _roomNo;  //房间号
		
		private string _locationId;  //所属科室
		
		private int _lsBALL;  //床位状态：1-床位清理；2-占用；3-开放使用；4-污染；5-被隔离；6-禁用
		
		private string _itemId;  //对应收费代码
		
		private bool _isAdd;  //是否加床
		
		private string _memo;  //备注
		
		private string _operID;  //操作员ID,BsUser.Id
		
		private DateTime _operTime;  //操作时间
		
		private int _orderBy;  //显示次序
		
		private bool _isActive;  //是否可用
		
		private int _iconIndex;  //图标类型
		
		private int _lsClass;  //护理等级：1-一级护理；2-二级护理；3-三级护理
		
		private bool _isAddBed;  //是否加床
		
		private string _bedGroup;  //床位分组。对应BsItem.Id
		
		private string _itemIdCode1;  //升温费。对应BsItem.Id
		
		private string _itemIdCode2;  //降温费。对应BsItem.Id
		
		private string _addItemCode;  //附加费。对应BsItem.Id
		
		private string _leaveHospId;  //请假时占用床位的病人ID
		
		private string _matBedId;  //儿童床对应母亲床id

        private int _hospitalId;//医院ID

        private int _floorNum;

        /// <summary>
        /// 床号
        /// </summary>
        public string Name
		{
			get { return _name;}
			set { _name = value;}
		}                                    
		
		/// <summary>
		/// 房间号
		/// </summary>
		public string RoomNo
		{
			get { return _roomNo;}
			set { _roomNo = value;}
		}                                    
		
		/// <summary>
		/// 所属科室
		/// </summary>
		public string LocationId
		{
			get { return _locationId;}
			set { _locationId = value;}
		}                                    
		
		/// <summary>
		/// 床位状态：1-床位清理；2-占用；3-开放使用；4-污染；5-被隔离；6-禁用
		/// </summary>
		public int LsBALL
		{
			get { return _lsBALL;}
			set { _lsBALL = value;}
		}                                    
		
		/// <summary>
		/// 对应收费代码
		/// </summary>
		public string ItemId
		{
			get { return _itemId;}
			set { _itemId = value;}
		}                                    
		
		/// <summary>
		/// 是否加床
		/// </summary>
		public bool IsAdd
		{
			get { return _isAdd;}
			set { _isAdd = value;}
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
		/// 操作员ID,BsUser.Id
		/// </summary>
		public string OperID
		{
			get { return _operID;}
			set { _operID = value;}
		}                                    
		
		/// <summary>
		/// 操作时间
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 显示次序
		/// </summary>
		public int OrderBy
		{
			get { return _orderBy;}
			set { _orderBy = value;}
		}                                    
		
		/// <summary>
		/// 是否可用
		/// </summary>
		public bool IsActive
		{
			get { return _isActive;}
			set { _isActive = value;}
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
		/// 护理等级：1-一级护理；2-二级护理；3-三级护理
		/// </summary>
		public int LsClass
		{
			get { return _lsClass;}
			set { _lsClass = value;}
		}                                    
		
		/// <summary>
		/// 是否加床
		/// </summary>
		public bool IsAddBed
		{
			get { return _isAddBed;}
			set { _isAddBed = value;}
		}                                    
		
		/// <summary>
		/// 床位分组。对应BsItem.Id
		/// </summary>
		public string BedGroup
		{
			get { return _bedGroup;}
			set { _bedGroup = value;}
		}                                    
		
		/// <summary>
		/// 升温费。对应BsItem.Id
		/// </summary>
		public string ItemIdCode1
		{
			get { return _itemIdCode1;}
			set { _itemIdCode1 = value;}
		}                                    
		
		/// <summary>
		/// 降温费。对应BsItem.Id
		/// </summary>
		public string ItemIdCode2
		{
			get { return _itemIdCode2;}
			set { _itemIdCode2 = value;}
		}                                    
		
		/// <summary>
		/// 附加费。对应BsItem.Id
		/// </summary>
		public string AddItemCode
		{
			get { return _addItemCode;}
			set { _addItemCode = value;}
		}                                    
		
		/// <summary>
		/// 请假时占用床位的病人ID
		/// </summary>
		public string LeaveHospId
		{
			get { return _leaveHospId;}
			set { _leaveHospId = value;}
		}                                    
		
		/// <summary>
		/// 儿童床对应母亲床id
		/// </summary>
		public string MatBedId
		{
			get { return _matBedId;}
			set { _matBedId = value;}
		}

        public int FloorNum
        {
            get { return _floorNum; }
            set { _floorNum = value; }
        }
    }  
}           


