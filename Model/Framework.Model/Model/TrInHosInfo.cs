

using System;
namespace Orm.Model
{
	/// <summary>
	/// 病人屏蔽表 - 实体类
	/// </summary>
	[Serializable]
	public partial class TrInHosInfo:BaseModel
	{   
		 
		private string _hospId;  //住院号（相当于门诊的流水号）,用户不可见
		
		private string _inPatNo;  //病人号(对一个病人唯一),不可见
		
		private string _cardNo;  //卡号
		
		private string _name;  //病人姓名
		
		private string _sex;  //病人性别：F-男；M-女；O-其他
		
		private DateTime _inTime;  //入院日期
		
		private DateTime _outTime;  //出院日期
		
		private string _locationId;  //当前科室
		
		private string _bedId;  //当前床位
		
		private int _lsInStatus;  //住院状态：1-等待住院；2-在院；3-出院；4-请假；5-待出院
		
		private int _locIn;  //入院科室
		
		private string _residence;  //户口地址
		
		private string _patTypeId;  //病人类别
		
		private string _doctorId;  //住院医生
		
		private string _idCardNo;  //身份证号
		
		private int _lsMarriage;  //婚姻状况：1-儿童；2-未婚；3-初婚；4-再婚；5-离异；6-丧偶；7-其他
		
		private int _HospitalID;  //
		 

		
		 
		/// <summary>
		/// 住院号（相当于门诊的流水号）,用户不可见
		/// </summary>
		public string HospId
		{
			get { return _hospId;}
			set { _hospId = value;}
		}                                    
		
		/// <summary>
		/// 病人号(对一个病人唯一),不可见
		/// </summary>
		public string InPatNo
		{
			get { return _inPatNo;}
			set { _inPatNo = value;}
		}                                    
		
		/// <summary>
		/// 卡号
		/// </summary>
		public string CardNo
		{
			get { return _cardNo;}
			set { _cardNo = value;}
		}                                    
		
		/// <summary>
		/// 病人姓名
		/// </summary>
		public string Name
		{
			get { return _name;}
			set { _name = value;}
		}                                    
		
		/// <summary>
		/// 病人性别：F-男；M-女；O-其他
		/// </summary>
		public string Sex
		{
			get { return _sex;}
			set { _sex = value;}
		}                                    
		
		/// <summary>
		/// 入院日期
		/// </summary>
		public DateTime InTime
		{
			get { return _inTime;}
			set { _inTime = value;}
		}                                    
		
		/// <summary>
		/// 出院日期
		/// </summary>
		public DateTime OutTime
		{
			get { return _outTime;}
			set { _outTime = value;}
		}                                    
		
		/// <summary>
		/// 当前科室
		/// </summary>
		public string LocationId
		{
			get { return _locationId;}
			set { _locationId = value;}
		}                                    
		
		/// <summary>
		/// 当前床位
		/// </summary>
		public string BedId
		{
			get { return _bedId;}
			set { _bedId = value;}
		}                                    
		
		/// <summary>
		/// 住院状态：1-等待住院；2-在院；3-出院；4-请假；5-待出院
		/// </summary>
		public int LsInStatus
		{
			get { return _lsInStatus;}
			set { _lsInStatus = value;}
		}                                    
		
		/// <summary>
		/// 入院科室
		/// </summary>
		public int LocIn
		{
			get { return _locIn;}
			set { _locIn = value;}
		}                                    
		
		/// <summary>
		/// 户口地址
		/// </summary>
		public string Residence
		{
			get { return _residence;}
			set { _residence = value;}
		}                                    
		
		/// <summary>
		/// 病人类别
		/// </summary>
		public string PatTypeId
		{
			get { return _patTypeId;}
			set { _patTypeId = value;}
		}                                    
		
		/// <summary>
		/// 住院医生
		/// </summary>
		public string DoctorId
		{
			get { return _doctorId;}
			set { _doctorId = value;}
		}                                    
		
		/// <summary>
		/// 身份证号
		/// </summary>
		public string IdCardNo
		{
			get { return _idCardNo;}
			set { _idCardNo = value;}
		}                                    
		
		/// <summary>
		/// 婚姻状况：1-儿童；2-未婚；3-初婚；4-再婚；5-离异；6-丧偶；7-其他
		/// </summary>
		public int LsMarriage
		{
			get { return _lsMarriage;}
			set { _lsMarriage = value;}
		}                                    
		 
	}  
}           


