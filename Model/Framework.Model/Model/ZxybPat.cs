

using System;
namespace Orm.Model
{
	/// <summary>
	/// 医保系统病人信息表 - 实体类
	/// </summary>
	[Serializable]
	public partial class ZxybPat : BaseModel
	{    
		private string _patId;  //病人ID,对应BsPatient.Id
		
		private string _astr1;  //个人编号
		
		private string _astr2;  //个人编号
		
		private string _astr3;  //单位名称/户主名称
		
		private string _astr4;  //身份证号
		
		private string _astr5;  //姓名
		
		private string _astr6;  //性别
		
		private string _astr7;  //民族
		
		private string _astr8;  //出生日期
		
		private string _astr9;  //医疗人员类别
		
		private string _astr10;  //医疗证号
		
		private string _astr11;  //人员资料登记状态
		
		private string _astr12;  //参保状态
		
		private string _astr13;  //异地人员标志
		
		private string _astr14;  //统筹区号
		
		private string _astr15;  //基金类型
		
		private string _astr16;  //年度
		
		private string _astr17;  //在院状态
		
		private string _astr18;  //本年医疗费总金额累计
		
		private string _astr19;  //本年医保支付金额累计
		
		private string _astr20;  //本年进入统筹费用累计
		
		private string _astr21;  //本年进入补充医疗保险费用累计
		
		private string _astr22;  //本年起付标准累计
		
		private string _astr23;  //本年住院次数
		
		private string _astr24;  //本年超封顶线个人自付累计
		
		private string _astr25;  //本年进入结算费用累计
		
		private string _astr26;  //本年补充医保二次支付金额累计
		
		private string _astr27;  //参保类别
		
		private string _astr28;  //经办机构编码
		
		private string _astr29;  //经办机构名称
		
		private string _astr30;  //医疗待遇类别
		
		private string _astr31;  //报销类型
		
		private string _astr32;  //单位地址/家庭地址
		
		private string _astr33;  //是否五保供养
		
		private string _astr34;  //备用
		
		private string _astr35;  //病种编码
		
		private string _astr36;  //病种名称
		
		private string _astr37;  //月累计已支付
		
		private string _astr38;  //
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //

        public ZxybPat() { }

                                 
		
		/// <summary>
		/// 病人ID,对应BsPatient.Id
		/// </summary>
		public string PatId
		{
			get { return _patId;}
			set { _patId = value;}
		}                                    
		
		/// <summary>
		/// 个人编号
		/// </summary>
		public string Astr1
		{
			get { return _astr1;}
			set { _astr1 = value;}
		}                                    
		
		/// <summary>
		/// 个人编号
		/// </summary>
		public string Astr2
		{
			get { return _astr2;}
			set { _astr2 = value;}
		}                                    
		
		/// <summary>
		/// 单位名称/户主名称
		/// </summary>
		public string Astr3
		{
			get { return _astr3;}
			set { _astr3 = value;}
		}                                    
		
		/// <summary>
		/// 身份证号
		/// </summary>
		public string Astr4
		{
			get { return _astr4;}
			set { _astr4 = value;}
		}                                    
		
		/// <summary>
		/// 姓名
		/// </summary>
		public string Astr5
		{
			get { return _astr5;}
			set { _astr5 = value;}
		}                                    
		
		/// <summary>
		/// 性别
		/// </summary>
		public string Astr6
		{
			get { return _astr6;}
			set { _astr6 = value;}
		}                                    
		
		/// <summary>
		/// 民族
		/// </summary>
		public string Astr7
		{
			get { return _astr7;}
			set { _astr7 = value;}
		}                                    
		
		/// <summary>
		/// 出生日期
		/// </summary>
		public string Astr8
		{
			get { return _astr8;}
			set { _astr8 = value;}
		}                                    
		
		/// <summary>
		/// 医疗人员类别
		/// </summary>
		public string Astr9
		{
			get { return _astr9;}
			set { _astr9 = value;}
		}                                    
		
		/// <summary>
		/// 医疗证号
		/// </summary>
		public string Astr10
		{
			get { return _astr10;}
			set { _astr10 = value;}
		}                                    
		
		/// <summary>
		/// 人员资料登记状态
		/// </summary>
		public string Astr11
		{
			get { return _astr11;}
			set { _astr11 = value;}
		}                                    
		
		/// <summary>
		/// 参保状态
		/// </summary>
		public string Astr12
		{
			get { return _astr12;}
			set { _astr12 = value;}
		}                                    
		
		/// <summary>
		/// 异地人员标志
		/// </summary>
		public string Astr13
		{
			get { return _astr13;}
			set { _astr13 = value;}
		}                                    
		
		/// <summary>
		/// 统筹区号
		/// </summary>
		public string Astr14
		{
			get { return _astr14;}
			set { _astr14 = value;}
		}                                    
		
		/// <summary>
		/// 基金类型
		/// </summary>
		public string Astr15
		{
			get { return _astr15;}
			set { _astr15 = value;}
		}                                    
		
		/// <summary>
		/// 年度
		/// </summary>
		public string Astr16
		{
			get { return _astr16;}
			set { _astr16 = value;}
		}                                    
		
		/// <summary>
		/// 在院状态
		/// </summary>
		public string Astr17
		{
			get { return _astr17;}
			set { _astr17 = value;}
		}                                    
		
		/// <summary>
		/// 本年医疗费总金额累计
		/// </summary>
		public string Astr18
		{
			get { return _astr18;}
			set { _astr18 = value;}
		}                                    
		
		/// <summary>
		/// 本年医保支付金额累计
		/// </summary>
		public string Astr19
		{
			get { return _astr19;}
			set { _astr19 = value;}
		}                                    
		
		/// <summary>
		/// 本年进入统筹费用累计
		/// </summary>
		public string Astr20
		{
			get { return _astr20;}
			set { _astr20 = value;}
		}                                    
		
		/// <summary>
		/// 本年进入补充医疗保险费用累计
		/// </summary>
		public string Astr21
		{
			get { return _astr21;}
			set { _astr21 = value;}
		}                                    
		
		/// <summary>
		/// 本年起付标准累计
		/// </summary>
		public string Astr22
		{
			get { return _astr22;}
			set { _astr22 = value;}
		}                                    
		
		/// <summary>
		/// 本年住院次数
		/// </summary>
		public string Astr23
		{
			get { return _astr23;}
			set { _astr23 = value;}
		}                                    
		
		/// <summary>
		/// 本年超封顶线个人自付累计
		/// </summary>
		public string Astr24
		{
			get { return _astr24;}
			set { _astr24 = value;}
		}                                    
		
		/// <summary>
		/// 本年进入结算费用累计
		/// </summary>
		public string Astr25
		{
			get { return _astr25;}
			set { _astr25 = value;}
		}                                    
		
		/// <summary>
		/// 本年补充医保二次支付金额累计
		/// </summary>
		public string Astr26
		{
			get { return _astr26;}
			set { _astr26 = value;}
		}                                    
		
		/// <summary>
		/// 参保类别
		/// </summary>
		public string Astr27
		{
			get { return _astr27;}
			set { _astr27 = value;}
		}                                    
		
		/// <summary>
		/// 经办机构编码
		/// </summary>
		public string Astr28
		{
			get { return _astr28;}
			set { _astr28 = value;}
		}                                    
		
		/// <summary>
		/// 经办机构名称
		/// </summary>
		public string Astr29
		{
			get { return _astr29;}
			set { _astr29 = value;}
		}                                    
		
		/// <summary>
		/// 医疗待遇类别
		/// </summary>
		public string Astr30
		{
			get { return _astr30;}
			set { _astr30 = value;}
		}                                    
		
		/// <summary>
		/// 报销类型
		/// </summary>
		public string Astr31
		{
			get { return _astr31;}
			set { _astr31 = value;}
		}                                    
		
		/// <summary>
		/// 单位地址/家庭地址
		/// </summary>
		public string Astr32
		{
			get { return _astr32;}
			set { _astr32 = value;}
		}                                    
		
		/// <summary>
		/// 是否五保供养
		/// </summary>
		public string Astr33
		{
			get { return _astr33;}
			set { _astr33 = value;}
		}                                    
		
		/// <summary>
		/// 备用
		/// </summary>
		public string Astr34
		{
			get { return _astr34;}
			set { _astr34 = value;}
		}                                    
		
		/// <summary>
		/// 病种编码
		/// </summary>
		public string Astr35
		{
			get { return _astr35;}
			set { _astr35 = value;}
		}                                    
		
		/// <summary>
		/// 病种名称
		/// </summary>
		public string Astr36
		{
			get { return _astr36;}
			set { _astr36 = value;}
		}                                    
		
		/// <summary>
		/// 月累计已支付
		/// </summary>
		public string Astr37
		{
			get { return _astr37;}
			set { _astr37 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string Astr38
		{
			get { return _astr38;}
			set { _astr38 = value;}
		}                                    
		
		/// <summary>
		/// 已经封存，不可改删
		/// </summary>
		public bool IsAuthed
		{
			get { return _isAuthed;}
			set { _isAuthed = value;}
		}                                    
                                 
		        
	}  
}           


