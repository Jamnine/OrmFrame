

using System;
namespace Orm.Model
{
	/// <summary>
	/// 住院发票医保信息表 - 实体类
	/// </summary>
	[Serializable]
	public partial class InInvoYB:BaseModel
	{   
		
		private string _invoId;  //发票ID
		
		private double _factYP;  //部分自付的药费
		
		private double _factJZ;  //部分自付的检治费
		
		private double _allFactYP;  //全部自付的药费
		
		private double _allFactJZ;  //全部自付的检治费
		
		private double _otherFact;  //其它自费
		
		private double _yBDisc;  //报销比例
		
		private double _insurance;  //统筹支付额
		
		private double _underLine;  //起付标准(起付线)
		
		private double _insuranceB1;  //a、统筹报销起付线-5000元
		
		private double _insuranceB2;  //b、统筹报销5000-15000元
		
		private double _insuranceB3;  //c、统筹报销15000元-封顶
		
		private double _paySelf;  //个人支付额
		
		private double _selfPayDisc;  //按比例自付额
		
		private double _selfPayB1;  //起付线-5000个人自付额
		
		private double _selfPayB2;  //5000-15000个人自付额
		
		private double _selfPayB3;  //15000-封顶线个人自付额
		
		private double _outTopSelfFee;  //超封顶线自付
		
		private double _selfFee;  //自费
		
		private double _bchzylbxAmount;  //
		
		private string _accountAttribute;  //
		
		private double _bcProportion;  //
		
		private double _fdAmount;  //总金额
		
		private string _medicalNo;  //医保号
		
		private double _ndybcAmount;  //
		
		private double _tgProportion;  //
		
		private double _wbhProportion;  //
		
		private double _zyyProportion;  //
		
		private double _zzProportion;  //
		
		private double _kbcAmount;  //
		
		private double _kbcA1;  //
		
		private double _kbcA2;  //
		
		private double _kbcA3;  //
		
		private double _kbcA4;  //
		
		private double _kbcA5;  //
		
		private double _kbcA6;  //
		
		private double _kbcA12;  //
		
		private double _kbcA13;  //
		
		private double _kbcA16;  //
		
		private double _kbcA17;  //
		
		private double _kbcA18;  //
		
		private double _kbcA19;  //
		
		private double _kbcA20;  //
		
		private double _sjbcA1;  //
		
		private double _sjbcA2;  //
		
		private double _sjbcA3;  //
		
		private double _sjbcA4;  //
		
		private double _sjbcA5;  //
		
		private double _sjbcA6;  //
		
		private double _sjbcA12;  //
		
		private double _sjbcA13;  //
		
		private double _sjbcA16;  //
		
		private double _sjbcA17;  //
		
		private double _sjbcA18;  //
		
		private double _sjbcA19;  //
		
		private double _sjbcA20;  //
		
		private double _originalAmount;  //
		
		private double _originalA1;  //
		
		private double _originalA2;  //
		
		private double _originalA3;  //
		
		private double _originalA4;  //
		
		private double _originalA5;  //
		
		private double _originalA6;  //
		
		private double _originalA12;  //
		
		private double _originalA13;  //
		
		private double _originalA16;  //
		
		private double _originalA17;  //
		
		private double _originalA18;  //
		
		private double _originalA19;  //
		
		private double _originalA20;  //
		
		private string _hospId;  //住院病人对应InHosinfo.Id
		
		private DateTime _invoYBTime;  //医保结算时间
		
		private string _ybPatType;  //参保人医别：职工，居民
		
		private string _nTime;  //住院次数
		
		private string _balaNo;  //医保结算号
		
		private string _insuranceType;  //报销类型
		
		private string _remark;  //备注
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //
		 
         
		/// <summary>
		/// 发票ID
		/// </summary>
		public string InvoId
		{
			get { return _invoId;}
			set { _invoId = value;}
		}                                    
		
		/// <summary>
		/// 部分自付的药费
		/// </summary>
		public double FactYP
		{
			get { return _factYP;}
			set { _factYP = value;}
		}                                    
		
		/// <summary>
		/// 部分自付的检治费
		/// </summary>
		public double FactJZ
		{
			get { return _factJZ;}
			set { _factJZ = value;}
		}                                    
		
		/// <summary>
		/// 全部自付的药费
		/// </summary>
		public double AllFactYP
		{
			get { return _allFactYP;}
			set { _allFactYP = value;}
		}                                    
		
		/// <summary>
		/// 全部自付的检治费
		/// </summary>
		public double AllFactJZ
		{
			get { return _allFactJZ;}
			set { _allFactJZ = value;}
		}                                    
		
		/// <summary>
		/// 其它自费
		/// </summary>
		public double OtherFact
		{
			get { return _otherFact;}
			set { _otherFact = value;}
		}                                    
		
		/// <summary>
		/// 报销比例
		/// </summary>
		public double YBDisc
		{
			get { return _yBDisc;}
			set { _yBDisc = value;}
		}                                    
		
		/// <summary>
		/// 统筹支付额
		/// </summary>
		public double Insurance
		{
			get { return _insurance;}
			set { _insurance = value;}
		}                                    
		
		/// <summary>
		/// 起付标准(起付线)
		/// </summary>
		public double UnderLine
		{
			get { return _underLine;}
			set { _underLine = value;}
		}                                    
		
		/// <summary>
		/// a、统筹报销起付线-5000元
		/// </summary>
		public double InsuranceB1
		{
			get { return _insuranceB1;}
			set { _insuranceB1 = value;}
		}                                    
		
		/// <summary>
		/// b、统筹报销5000-15000元
		/// </summary>
		public double InsuranceB2
		{
			get { return _insuranceB2;}
			set { _insuranceB2 = value;}
		}                                    
		
		/// <summary>
		/// c、统筹报销15000元-封顶
		/// </summary>
		public double InsuranceB3
		{
			get { return _insuranceB3;}
			set { _insuranceB3 = value;}
		}                                    
		
		/// <summary>
		/// 个人支付额
		/// </summary>
		public double PaySelf
		{
			get { return _paySelf;}
			set { _paySelf = value;}
		}                                    
		
		/// <summary>
		/// 按比例自付额
		/// </summary>
		public double SelfPayDisc
		{
			get { return _selfPayDisc;}
			set { _selfPayDisc = value;}
		}                                    
		
		/// <summary>
		/// 起付线-5000个人自付额
		/// </summary>
		public double SelfPayB1
		{
			get { return _selfPayB1;}
			set { _selfPayB1 = value;}
		}                                    
		
		/// <summary>
		/// 5000-15000个人自付额
		/// </summary>
		public double SelfPayB2
		{
			get { return _selfPayB2;}
			set { _selfPayB2 = value;}
		}                                    
		
		/// <summary>
		/// 15000-封顶线个人自付额
		/// </summary>
		public double SelfPayB3
		{
			get { return _selfPayB3;}
			set { _selfPayB3 = value;}
		}                                    
		
		/// <summary>
		/// 超封顶线自付
		/// </summary>
		public double OutTopSelfFee
		{
			get { return _outTopSelfFee;}
			set { _outTopSelfFee = value;}
		}                                    
		
		/// <summary>
		/// 自费
		/// </summary>
		public double SelfFee
		{
			get { return _selfFee;}
			set { _selfFee = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double BchzylbxAmount
		{
			get { return _bchzylbxAmount;}
			set { _bchzylbxAmount = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string AccountAttribute
		{
			get { return _accountAttribute;}
			set { _accountAttribute = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double BcProportion
		{
			get { return _bcProportion;}
			set { _bcProportion = value;}
		}                                    
		
		/// <summary>
		/// 总金额
		/// </summary>
		public double FdAmount
		{
			get { return _fdAmount;}
			set { _fdAmount = value;}
		}                                    
		
		/// <summary>
		/// 医保号
		/// </summary>
		public string MedicalNo
		{
			get { return _medicalNo;}
			set { _medicalNo = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double NdybcAmount
		{
			get { return _ndybcAmount;}
			set { _ndybcAmount = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double TgProportion
		{
			get { return _tgProportion;}
			set { _tgProportion = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double WbhProportion
		{
			get { return _wbhProportion;}
			set { _wbhProportion = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double ZyyProportion
		{
			get { return _zyyProportion;}
			set { _zyyProportion = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double ZzProportion
		{
			get { return _zzProportion;}
			set { _zzProportion = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double KbcAmount
		{
			get { return _kbcAmount;}
			set { _kbcAmount = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double KbcA1
		{
			get { return _kbcA1;}
			set { _kbcA1 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double KbcA2
		{
			get { return _kbcA2;}
			set { _kbcA2 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double KbcA3
		{
			get { return _kbcA3;}
			set { _kbcA3 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double KbcA4
		{
			get { return _kbcA4;}
			set { _kbcA4 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double KbcA5
		{
			get { return _kbcA5;}
			set { _kbcA5 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double KbcA6
		{
			get { return _kbcA6;}
			set { _kbcA6 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double KbcA12
		{
			get { return _kbcA12;}
			set { _kbcA12 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double KbcA13
		{
			get { return _kbcA13;}
			set { _kbcA13 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double KbcA16
		{
			get { return _kbcA16;}
			set { _kbcA16 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double KbcA17
		{
			get { return _kbcA17;}
			set { _kbcA17 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double KbcA18
		{
			get { return _kbcA18;}
			set { _kbcA18 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double KbcA19
		{
			get { return _kbcA19;}
			set { _kbcA19 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double KbcA20
		{
			get { return _kbcA20;}
			set { _kbcA20 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double SjbcA1
		{
			get { return _sjbcA1;}
			set { _sjbcA1 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double SjbcA2
		{
			get { return _sjbcA2;}
			set { _sjbcA2 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double SjbcA3
		{
			get { return _sjbcA3;}
			set { _sjbcA3 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double SjbcA4
		{
			get { return _sjbcA4;}
			set { _sjbcA4 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double SjbcA5
		{
			get { return _sjbcA5;}
			set { _sjbcA5 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double SjbcA6
		{
			get { return _sjbcA6;}
			set { _sjbcA6 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double SjbcA12
		{
			get { return _sjbcA12;}
			set { _sjbcA12 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double SjbcA13
		{
			get { return _sjbcA13;}
			set { _sjbcA13 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double SjbcA16
		{
			get { return _sjbcA16;}
			set { _sjbcA16 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double SjbcA17
		{
			get { return _sjbcA17;}
			set { _sjbcA17 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double SjbcA18
		{
			get { return _sjbcA18;}
			set { _sjbcA18 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double SjbcA19
		{
			get { return _sjbcA19;}
			set { _sjbcA19 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double SjbcA20
		{
			get { return _sjbcA20;}
			set { _sjbcA20 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double OriginalAmount
		{
			get { return _originalAmount;}
			set { _originalAmount = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double OriginalA1
		{
			get { return _originalA1;}
			set { _originalA1 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double OriginalA2
		{
			get { return _originalA2;}
			set { _originalA2 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double OriginalA3
		{
			get { return _originalA3;}
			set { _originalA3 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double OriginalA4
		{
			get { return _originalA4;}
			set { _originalA4 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double OriginalA5
		{
			get { return _originalA5;}
			set { _originalA5 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double OriginalA6
		{
			get { return _originalA6;}
			set { _originalA6 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double OriginalA12
		{
			get { return _originalA12;}
			set { _originalA12 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double OriginalA13
		{
			get { return _originalA13;}
			set { _originalA13 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double OriginalA16
		{
			get { return _originalA16;}
			set { _originalA16 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double OriginalA17
		{
			get { return _originalA17;}
			set { _originalA17 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double OriginalA18
		{
			get { return _originalA18;}
			set { _originalA18 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double OriginalA19
		{
			get { return _originalA19;}
			set { _originalA19 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double OriginalA20
		{
			get { return _originalA20;}
			set { _originalA20 = value;}
		}                                    
		
		/// <summary>
		/// 住院病人对应InHosinfo.Id
		/// </summary>
		public string HospId
		{
			get { return _hospId;}
			set { _hospId = value;}
		}                                    
		
		/// <summary>
		/// 医保结算时间
		/// </summary>
		public DateTime InvoYBTime
		{
			get { return _invoYBTime;}
			set { _invoYBTime = value;}
		}                                    
		
		/// <summary>
		/// 参保人医别：职工，居民
		/// </summary>
		public string YbPatType
		{
			get { return _ybPatType;}
			set { _ybPatType = value;}
		}                                    
		
		/// <summary>
		/// 住院次数
		/// </summary>
		public string NTime
		{
			get { return _nTime;}
			set { _nTime = value;}
		}                                    
		
		/// <summary>
		/// 医保结算号
		/// </summary>
		public string BalaNo
		{
			get { return _balaNo;}
			set { _balaNo = value;}
		}                                    
		
		/// <summary>
		/// 报销类型
		/// </summary>
		public string InsuranceType
		{
			get { return _insuranceType;}
			set { _insuranceType = value;}
		}                                    
		
		/// <summary>
		/// 备注
		/// </summary>
		public string Remark
		{
			get { return _remark;}
			set { _remark = value;}
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
		/// 
		/// </summary>
		public int HospitalID
		{
			get { return _HospitalID;}
			set { _HospitalID = value;}
		}                                    
		        
	}  
}           


