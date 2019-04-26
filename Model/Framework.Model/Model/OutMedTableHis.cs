

using System;
namespace Orm.Model
{
	/// <summary>
	/// 自动发药机明细 - 实体类
	/// </summary>
	[Serializable]
	public partial class OutMedTableHis : BaseModel
	{   
		
		private string _presNO;  //处方号(唯一处方号码)
		
		private string _medID;  //药品流水号(同一处方中流水号，从1开始)
		
		private string _medOnlyCode;  //药品编码(itemID)
		
		private int _medAMT;  //出药数量
		
		private string _medPack;  //药品单位(药房单位)
		
		private string _medUnitPack;  //药品包装单位(包装单位)
		
		private string _medUnit;  //药品规格
		
		private string _medOutTime;  //出药时间(收费时间)
		
		private string _presType;  //处方类型(儿科处方/普通处方/社保等)
		
		private int _windowNO;  //窗口号
		
		private string _patientID;  //病人ID(病人唯一标识(如：病历号))
		
		private string _patientName;  //病人姓名
		
		private string _patientSex;  //病人性别(男/女)
		
		private string _patientAge;  //病人年龄
		
		private string _patientBirth;  //病人生日(如：1984-09-12)
		
		private string _diagnosis;  //诊断
		
		private string _wardNO;  //科别代码
		
		private string _wardName;  //科别名称
		
		private string _medPerdos;  //每次用量
		
		private string _medUsage;  //用法1(给药方式（口服、外服）)
		
		private string _medPerday;  //用法2(执行频率（三次/日）)
		
		private string _doctorName;  //医生姓名
		
		private string _sEndflag;  //处方状态(传递0值(若为Webservice，忽略此字段)，有修改权限)
		
		private double _medUnitPrice;  //药品单价(药品单价*药品数量)
		
		private double _medTotalPrice;  //处方总价格(整个处方总价格)
		
		private string _medType;  //药品类型(1为西药2为成药0为其他)
		
		private int _medConvercof;  //转换系数(药品包装单位间转换系数)
		
		private string _remark;  //备注(药品门诊药品货位号码)
		
		private string _yFCode;  //药房标记(0代表门诊，1急诊，2出院带药,3为住院)
		
		private string _endflag;  //配药结束标记(默认为0，如果配药结束IRON修改为1)
		
		
		private string _yfFinish;  //药房成完
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //
		 

		
		/// <summary>
		/// 处方号(唯一处方号码)
		/// </summary>
		public string PresNO
		{
			get { return _presNO;}
			set { _presNO = value;}
		}                                    
		
		/// <summary>
		/// 药品流水号(同一处方中流水号，从1开始)
		/// </summary>
		public string MedID
		{
			get { return _medID;}
			set { _medID = value;}
		}                                    
		
		/// <summary>
		/// 药品编码(itemID)
		/// </summary>
		public string MedOnlyCode
		{
			get { return _medOnlyCode;}
			set { _medOnlyCode = value;}
		}                                    
		
		/// <summary>
		/// 出药数量
		/// </summary>
		public int MedAMT
		{
			get { return _medAMT;}
			set { _medAMT = value;}
		}                                    
		
		/// <summary>
		/// 药品单位(药房单位)
		/// </summary>
		public string MedPack
		{
			get { return _medPack;}
			set { _medPack = value;}
		}                                    
		
		/// <summary>
		/// 药品包装单位(包装单位)
		/// </summary>
		public string MedUnitPack
		{
			get { return _medUnitPack;}
			set { _medUnitPack = value;}
		}                                    
		
		/// <summary>
		/// 药品规格
		/// </summary>
		public string MedUnit
		{
			get { return _medUnit;}
			set { _medUnit = value;}
		}                                    
		
		/// <summary>
		/// 出药时间(收费时间)
		/// </summary>
		public string MedOutTime
		{
			get { return _medOutTime;}
			set { _medOutTime = value;}
		}                                    
		
		/// <summary>
		/// 处方类型(儿科处方/普通处方/社保等)
		/// </summary>
		public string PresType
		{
			get { return _presType;}
			set { _presType = value;}
		}                                    
		
		/// <summary>
		/// 窗口号
		/// </summary>
		public int WindowNO
		{
			get { return _windowNO;}
			set { _windowNO = value;}
		}                                    
		
		/// <summary>
		/// 病人ID(病人唯一标识(如：病历号))
		/// </summary>
		public string PatientID
		{
			get { return _patientID;}
			set { _patientID = value;}
		}                                    
		
		/// <summary>
		/// 病人姓名
		/// </summary>
		public string PatientName
		{
			get { return _patientName;}
			set { _patientName = value;}
		}                                    
		
		/// <summary>
		/// 病人性别(男/女)
		/// </summary>
		public string PatientSex
		{
			get { return _patientSex;}
			set { _patientSex = value;}
		}                                    
		
		/// <summary>
		/// 病人年龄
		/// </summary>
		public string PatientAge
		{
			get { return _patientAge;}
			set { _patientAge = value;}
		}                                    
		
		/// <summary>
		/// 病人生日(如：1984-09-12)
		/// </summary>
		public string PatientBirth
		{
			get { return _patientBirth;}
			set { _patientBirth = value;}
		}                                    
		
		/// <summary>
		/// 诊断
		/// </summary>
		public string Diagnosis
		{
			get { return _diagnosis;}
			set { _diagnosis = value;}
		}                                    
		
		/// <summary>
		/// 科别代码
		/// </summary>
		public string WardNO
		{
			get { return _wardNO;}
			set { _wardNO = value;}
		}                                    
		
		/// <summary>
		/// 科别名称
		/// </summary>
		public string WardName
		{
			get { return _wardName;}
			set { _wardName = value;}
		}                                    
		
		/// <summary>
		/// 每次用量
		/// </summary>
		public string MedPerdos
		{
			get { return _medPerdos;}
			set { _medPerdos = value;}
		}                                    
		
		/// <summary>
		/// 用法1(给药方式（口服、外服）)
		/// </summary>
		public string MedUsage
		{
			get { return _medUsage;}
			set { _medUsage = value;}
		}                                    
		
		/// <summary>
		/// 用法2(执行频率（三次/日）)
		/// </summary>
		public string MedPerday
		{
			get { return _medPerday;}
			set { _medPerday = value;}
		}                                    
		
		/// <summary>
		/// 医生姓名
		/// </summary>
		public string DoctorName
		{
			get { return _doctorName;}
			set { _doctorName = value;}
		}                                    
		
		/// <summary>
		/// 处方状态(传递0值(若为Webservice，忽略此字段)，有修改权限)
		/// </summary>
		public string SEndflag
		{
			get { return _sEndflag;}
			set { _sEndflag = value;}
		}                                    
		
		/// <summary>
		/// 药品单价(药品单价*药品数量)
		/// </summary>
		public double MedUnitPrice
		{
			get { return _medUnitPrice;}
			set { _medUnitPrice = value;}
		}                                    
		
		/// <summary>
		/// 处方总价格(整个处方总价格)
		/// </summary>
		public double MedTotalPrice
		{
			get { return _medTotalPrice;}
			set { _medTotalPrice = value;}
		}                                    
		
		/// <summary>
		/// 药品类型(1为西药2为成药0为其他)
		/// </summary>
		public string MedType
		{
			get { return _medType;}
			set { _medType = value;}
		}                                    
		
		/// <summary>
		/// 转换系数(药品包装单位间转换系数)
		/// </summary>
		public int MedConvercof
		{
			get { return _medConvercof;}
			set { _medConvercof = value;}
		}                                    
		
		/// <summary>
		/// 备注(药品门诊药品货位号码)
		/// </summary>
		public string Remark
		{
			get { return _remark;}
			set { _remark = value;}
		}                                    
		
		/// <summary>
		/// 药房标记(0代表门诊，1急诊，2出院带药,3为住院)
		/// </summary>
		public string YFCode
		{
			get { return _yFCode;}
			set { _yFCode = value;}
		}                                    
		
		/// <summary>
		/// 配药结束标记(默认为0，如果配药结束IRON修改为1)
		/// </summary>
		public string Endflag
		{
			get { return _endflag;}
			set { _endflag = value;}
		}                                    
		

		/// <summary>
		/// 药房成完
		/// </summary>
		public string YfFinish
		{
			get { return _yfFinish;}
			set { _yfFinish = value;}
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


