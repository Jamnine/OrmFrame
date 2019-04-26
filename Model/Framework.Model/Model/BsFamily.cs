

using System;
namespace Orm.Model
{
	/// <summary>
	/// 家庭档案 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsFamily : BaseModel
    {   
		
		private string _code;  //编码
		
		private string _committeeId;  //所在居委会
		
		private string _name;  //户主姓名
		
		private string _addressHome;  //家庭地址
		
		private string _phoneHome;  //家庭的电话
		
		private string _postCodeHome;  //家庭的邮政编码
		
		private string _areaCodeHome;  //家庭地区号
		
		private int _totalPersons;  //家庭人口数
		
		private int _housePersons;  //现住人口数
		
		private int _workingPersons;  //就业人数
		
		private int _lsFamilyType;  //家庭类型：1.核心家庭；2-主干家庭；3-联合家庭；4-单身家庭；5-单亲家庭；6-群居家庭；7-同居家庭；8-同性恋家庭；9-其他家庭类型
		
		private int _lsPeriod;  //家庭生活周期：1.新婚期；2-首孩出生期；3-学龄前儿童期；4-学龄儿童期；5-青少年期；6-孩子离家创业期；7-空巢期；8-退休期
		
		private int _lsHouseType;  //家庭住房：1-电梯楼；2-非电梯楼；3-平房；4-其它
		
		private int _acreage;  //面积M2
		
		private int _lsFuel;  //使用燃料:1-罐装液化气；2-天然气；3-沼气；4-煤炉；5-管道煤制气
		
		private int _lsWarm;  //取暖方式：1-电炉；2-空调
		
		private int _lsCold;  //降温方式：1-风扇；2-空调
		
		private int _lsWater;  //饮用水：1-自来水；2-河水；3-深井水；4-浅井水；5-纯净水；6-矿泉水
		
		private int _lsSaniFamily;  //家庭卫生：1-整洁；2-一般；3-较差；4-有鼠害；5-蟑螂；6-苍蝇
		
		private int _lsSaniPerson;  //饮食卫生：1-优；2-良；3-一般；4-差
		
		private int _lsSaniHabit;  //饮食习惯：1-优；2-良；3-一般；4-差
		
		private int _lsNeighbourhood;  //邻居关系：1-优；2-一般；3-差；无往来
		
		private int _lsWC;  //厕所类型：1-家庭坐厕；2-家庭登厕；3-公共厕所；4-其他
		
		private bool _isHealthBin;  //是否家庭保健箱
		
		private int _lsIncome;  //月人均收入：1-小于500元；2-500元以上；3-1500元以上；4-3000元以上；5-5000元以上；6-不详；7-拒绝回答
		
		private string _memo;  //备注
		
		private string _pyCode;  //拼音码
		
		private string _wbCode;  //五笔码
		
		private int _orderBy;  //显示顺序
		
		private DateTime _operTime;  //录入时间
		
		private string _operID;  //录入人
		
		private bool _isActive;  //有效标志
		
		private string _inActiveReason;  //非活动的原因
		
		private DateTime _inActiveTime;  //非活动(迁出或死亡)时间
		
		private string _inActiveOperID;  //录入非活动的操作者
		
		private int _iconIndex;  //图标类型
		
		private string _roadId;  //所在组/路/巷
		
		private bool _isSign;  //是否签约
		
		private int _isCareMan;  //是否有家庭保健员
		
		private string _signDoctorId;  //签约医生
		
		private string _signGroupId;  //签约团队

        private int _HospitalID;  //

		/// <summary>
		/// 编码
		/// </summary>
		public string Code
		{
			get { return _code;}
			set { _code = value;}
		}                                    
		
		/// <summary>
		/// 所在居委会
		/// </summary>
		public string CommitteeId
		{
			get { return _committeeId;}
			set { _committeeId = value;}
		}                                    
		
		/// <summary>
		/// 户主姓名
		/// </summary>
		public string Name
		{
			get { return _name;}
			set { _name = value;}
		}                                    
		
		/// <summary>
		/// 家庭地址
		/// </summary>
		public string AddressHome
		{
			get { return _addressHome;}
			set { _addressHome = value;}
		}                                    
		
		/// <summary>
		/// 家庭的电话
		/// </summary>
		public string PhoneHome
		{
			get { return _phoneHome;}
			set { _phoneHome = value;}
		}                                    
		
		/// <summary>
		/// 家庭的邮政编码
		/// </summary>
		public string PostCodeHome
		{
			get { return _postCodeHome;}
			set { _postCodeHome = value;}
		}                                    
		
		/// <summary>
		/// 家庭地区号
		/// </summary>
		public string AreaCodeHome
		{
			get { return _areaCodeHome;}
			set { _areaCodeHome = value;}
		}                                    
		
		/// <summary>
		/// 家庭人口数
		/// </summary>
		public int TotalPersons
		{
			get { return _totalPersons;}
			set { _totalPersons = value;}
		}                                    
		
		/// <summary>
		/// 现住人口数
		/// </summary>
		public int HousePersons
		{
			get { return _housePersons;}
			set { _housePersons = value;}
		}                                    
		
		/// <summary>
		/// 就业人数
		/// </summary>
		public int WorkingPersons
		{
			get { return _workingPersons;}
			set { _workingPersons = value;}
		}                                    
		
		/// <summary>
		/// 家庭类型：1.核心家庭；2-主干家庭；3-联合家庭；4-单身家庭；5-单亲家庭；6-群居家庭；7-同居家庭；8-同性恋家庭；9-其他家庭类型
		/// </summary>
		public int LsFamilyType
		{
			get { return _lsFamilyType;}
			set { _lsFamilyType = value;}
		}                                    
		
		/// <summary>
		/// 家庭生活周期：1.新婚期；2-首孩出生期；3-学龄前儿童期；4-学龄儿童期；5-青少年期；6-孩子离家创业期；7-空巢期；8-退休期
		/// </summary>
		public int LsPeriod
		{
			get { return _lsPeriod;}
			set { _lsPeriod = value;}
		}                                    
		
		/// <summary>
		/// 家庭住房：1-电梯楼；2-非电梯楼；3-平房；4-其它
		/// </summary>
		public int LsHouseType
		{
			get { return _lsHouseType;}
			set { _lsHouseType = value;}
		}                                    
		
		/// <summary>
		/// 面积M2
		/// </summary>
		public int Acreage
		{
			get { return _acreage;}
			set { _acreage = value;}
		}                                    
		
		/// <summary>
		/// 使用燃料:1-罐装液化气；2-天然气；3-沼气；4-煤炉；5-管道煤制气
		/// </summary>
		public int LsFuel
		{
			get { return _lsFuel;}
			set { _lsFuel = value;}
		}                                    
		
		/// <summary>
		/// 取暖方式：1-电炉；2-空调
		/// </summary>
		public int LsWarm
		{
			get { return _lsWarm;}
			set { _lsWarm = value;}
		}                                    
		
		/// <summary>
		/// 降温方式：1-风扇；2-空调
		/// </summary>
		public int LsCold
		{
			get { return _lsCold;}
			set { _lsCold = value;}
		}                                    
		
		/// <summary>
		/// 饮用水：1-自来水；2-河水；3-深井水；4-浅井水；5-纯净水；6-矿泉水
		/// </summary>
		public int LsWater
		{
			get { return _lsWater;}
			set { _lsWater = value;}
		}                                    
		
		/// <summary>
		/// 家庭卫生：1-整洁；2-一般；3-较差；4-有鼠害；5-蟑螂；6-苍蝇
		/// </summary>
		public int LsSaniFamily
		{
			get { return _lsSaniFamily;}
			set { _lsSaniFamily = value;}
		}                                    
		
		/// <summary>
		/// 饮食卫生：1-优；2-良；3-一般；4-差
		/// </summary>
		public int LsSaniPerson
		{
			get { return _lsSaniPerson;}
			set { _lsSaniPerson = value;}
		}                                    
		
		/// <summary>
		/// 饮食习惯：1-优；2-良；3-一般；4-差
		/// </summary>
		public int LsSaniHabit
		{
			get { return _lsSaniHabit;}
			set { _lsSaniHabit = value;}
		}                                    
		
		/// <summary>
		/// 邻居关系：1-优；2-一般；3-差；无往来
		/// </summary>
		public int LsNeighbourhood
		{
			get { return _lsNeighbourhood;}
			set { _lsNeighbourhood = value;}
		}                                    
		
		/// <summary>
		/// 厕所类型：1-家庭坐厕；2-家庭登厕；3-公共厕所；4-其他
		/// </summary>
		public int LsWC
		{
			get { return _lsWC;}
			set { _lsWC = value;}
		}                                    
		
		/// <summary>
		/// 是否家庭保健箱
		/// </summary>
		public bool IsHealthBin
		{
			get { return _isHealthBin;}
			set { _isHealthBin = value;}
		}                                    
		
		/// <summary>
		/// 月人均收入：1-小于500元；2-500元以上；3-1500元以上；4-3000元以上；5-5000元以上；6-不详；7-拒绝回答
		/// </summary>
		public int LsIncome
		{
			get { return _lsIncome;}
			set { _lsIncome = value;}
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
		/// 拼音码
		/// </summary>
		public string PyCode
		{
			get { return _pyCode;}
			set { _pyCode = value;}
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
		/// 显示顺序
		/// </summary>
		public int OrderBy
		{
			get { return _orderBy;}
			set { _orderBy = value;}
		}                                    
		
		/// <summary>
		/// 录入时间
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 录入人
		/// </summary>
		public string OperID
		{
			get { return _operID;}
			set { _operID = value;}
		}                                    
		
		/// <summary>
		/// 有效标志
		/// </summary>
		public bool IsActive
		{
			get { return _isActive;}
			set { _isActive = value;}
		}                                    
		
		/// <summary>
		/// 非活动的原因
		/// </summary>
		public string InActiveReason
		{
			get { return _inActiveReason;}
			set { _inActiveReason = value;}
		}                                    
		
		/// <summary>
		/// 非活动(迁出或死亡)时间
		/// </summary>
		public DateTime InActiveTime
		{
			get { return _inActiveTime;}
			set { _inActiveTime = value;}
		}                                    
		
		/// <summary>
		/// 录入非活动的操作者
		/// </summary>
		public string InActiveOperID
		{
			get { return _inActiveOperID;}
			set { _inActiveOperID = value;}
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
		/// 所在组/路/巷
		/// </summary>
		public string RoadId
		{
			get { return _roadId;}
			set { _roadId = value;}
		}                                    
		
		/// <summary>
		/// 是否签约
		/// </summary>
		public bool IsSign
		{
			get { return _isSign;}
			set { _isSign = value;}
		}                                    
		
		/// <summary>
		/// 是否有家庭保健员
		/// </summary>
		public int IsCareMan
		{
			get { return _isCareMan;}
			set { _isCareMan = value;}
		}                                    
		
		/// <summary>
		/// 签约医生
		/// </summary>
		public string SignDoctorId
		{
			get { return _signDoctorId;}
			set { _signDoctorId = value;}
		}                                    
		
		/// <summary>
		/// 签约团队
		/// </summary>
		public string SignGroupId
		{
			get { return _signGroupId;}
			set { _signGroupId = value;}
		}

        /// <summary>
        /// 
        /// </summary>
        public int HospitalID
        {
            get { return _HospitalID; }
            set { _HospitalID = value; }
        }

    }  
}           


