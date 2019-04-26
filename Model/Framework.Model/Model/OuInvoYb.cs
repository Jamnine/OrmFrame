

using System;
namespace Orm.Model
{
	/// <summary>
	/// 门诊收费发票医保信息 - 实体类
	/// </summary>
	[Serializable]
	public partial class OuInvoYb :  BaseModel  
	{   
		 
		private string _invoid;  //发票ID
		
		private double _factyp;  //部分自付的药费
		
		private double _factjz;  //部分自付的检治费
		
		private double _allFactyp;  //全部自付的药费
		
		private double _allfactjz;  //全部自付的检治费
		
		private double _otherFact;  //其它自费
		
		private double _ybdisc;  //报销比例
		
		private double _insurance;  //统筹支付额
		
		private double _underline;  //起付标准(起付线)
		
		private double _insuranceb1;  //a、统筹报销起付线-5000元
		
		private double _insuranceb2;  //b、统筹报销5000-15000元
		
		private double _insuranceb3;  //c、统筹报销15000元-封顶
		
		private double _payself;  //个人支付额
		
		private double _selfpaydisc;  //按比例自付额
		
		private double _selfpayb1;  //起付线-5000个人自付额
		
		private double _selfpayb2;  //5000-15000个人自付额
		
		private double _selfpayb3;  //15000-封顶线个人自付额
		
		private double _outtopselffee;  //超封顶线自付
		
		private double _selffee;  //自费
		
		private string _accountAttribute;  //
		
		private double _bchzylbxAmount;  //
		
		private double _bcproportion;  //
		
		private double _fdamount;  //总金额
		
		private double _kbca1;  //
		
		private double _kbca12;  //
		
		private double _kbca13;  //
		
		private double _kbca16;  //
		
		private double _kbca17;  //
		
		private double _kbca18;  //
		
		private double _kbca19;  //
		
		private double _kbca2;  //
		
		private double _kbca20;  //
		
		private double _kbca3;  //
		
		private double _kbca4;  //
		
		private double _kbca5;  //
		
		private double _kbca6;  //
		
		private double _kbcamount;  //
		
		private string _medicalNo;  //
		
		private double _ndybcamount;  //
		
		private double _origiNala1;  //
		
		private double _origiNala12;  //
		
		private double _originala13;  //
		
		private double _originala16;  //
		
		private double _originala17;  //
		
		private double _origiNala18;  //
		
		private double _originala19;  //
		
		private double _origiNala2;  //
		
		private double _origiNala20;  //
		
		private double _originala3;  //
		
		private double _origiNala4;  //
		
		private double _originala5;  //
		
		private double _originala6;  //
		
		private double _originalamount;  //
		
		private double _sjbca1;  //
		
		private double _sjbca12;  //
		
		private double _sjbca13;  //
		
		private double _sjbca16;  //
		
		private double _sjbca17;  //
		
		private double _sjbca18;  //
		
		private double _sjbca19;  //
		
		private double _sjbca2;  //
		
		private double _sjbca20;  //
		
		private double _sjbca3;  //
		
		private double _sjbca4;  //
		
		private double _sjbca5;  //
		
		private double _sjbca6;  //
		
		private double _tgproportion;  //
		
		private double _wbhproportion;  //
		
		private double _zyyproportion;  //
		
		private double _zzproPortion;  //
		
		private string _mzRegID;  //门诊病人ID,Ouhosinfo.Id
		
		private string _ybPatType;  //参保人医别：职工，居民
		
		private string _memo;  //备注
		
		private string _nTime;  //住院次数
		
		private string _balaNo;  //医保结算号
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //
		 
 
		/// <summary>
		/// 发票ID
		/// </summary>
		public string invoid
		{
			get { return _invoid;}
			set { _invoid = value;}
		}                                    
		
		/// <summary>
		/// 部分自付的药费
		/// </summary>
		public double Factyp
		{
			get { return _factyp;}
			set { _factyp = value;}
		}                                    
		
		/// <summary>
		/// 部分自付的检治费
		/// </summary>
		public double Factjz
		{
			get { return _factjz;}
			set { _factjz = value;}
		}                                    
		
		/// <summary>
		/// 全部自付的药费
		/// </summary>
		public double AllFactyp
		{
			get { return _allFactyp;}
			set { _allFactyp = value;}
		}                                    
		
		/// <summary>
		/// 全部自付的检治费
		/// </summary>
		public double Allfactjz
		{
			get { return _allfactjz;}
			set { _allfactjz = value;}
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
		public double ybdisc
		{
			get { return _ybdisc;}
			set { _ybdisc = value;}
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
		public double Underline
		{
			get { return _underline;}
			set { _underline = value;}
		}                                    
		
		/// <summary>
		/// a、统筹报销起付线-5000元
		/// </summary>
		public double Insuranceb1
		{
			get { return _insuranceb1;}
			set { _insuranceb1 = value;}
		}                                    
		
		/// <summary>
		/// b、统筹报销5000-15000元
		/// </summary>
		public double Insuranceb2
		{
			get { return _insuranceb2;}
			set { _insuranceb2 = value;}
		}                                    
		
		/// <summary>
		/// c、统筹报销15000元-封顶
		/// </summary>
		public double Insuranceb3
		{
			get { return _insuranceb3;}
			set { _insuranceb3 = value;}
		}                                    
		
		/// <summary>
		/// 个人支付额
		/// </summary>
		public double payself
		{
			get { return _payself;}
			set { _payself = value;}
		}                                    
		
		/// <summary>
		/// 按比例自付额
		/// </summary>
		public double selfpaydisc
		{
			get { return _selfpaydisc;}
			set { _selfpaydisc = value;}
		}                                    
		
		/// <summary>
		/// 起付线-5000个人自付额
		/// </summary>
		public double Selfpayb1
		{
			get { return _selfpayb1;}
			set { _selfpayb1 = value;}
		}                                    
		
		/// <summary>
		/// 5000-15000个人自付额
		/// </summary>
		public double Selfpayb2
		{
			get { return _selfpayb2;}
			set { _selfpayb2 = value;}
		}                                    
		
		/// <summary>
		/// 15000-封顶线个人自付额
		/// </summary>
		public double Selfpayb3
		{
			get { return _selfpayb3;}
			set { _selfpayb3 = value;}
		}                                    
		
		/// <summary>
		/// 超封顶线自付
		/// </summary>
		public double Outtopselffee
		{
			get { return _outtopselffee;}
			set { _outtopselffee = value;}
		}                                    
		
		/// <summary>
		/// 自费
		/// </summary>
		public double Selffee
		{
			get { return _selffee;}
			set { _selffee = value;}
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
		public double BchzylbxAmount
		{
			get { return _bchzylbxAmount;}
			set { _bchzylbxAmount = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double bcproportion
		{
			get { return _bcproportion;}
			set { _bcproportion = value;}
		}                                    
		
		/// <summary>
		/// 总金额
		/// </summary>
		public double Fdamount
		{
			get { return _fdamount;}
			set { _fdamount = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double Kbca1
		{
			get { return _kbca1;}
			set { _kbca1 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double Kbca12
		{
			get { return _kbca12;}
			set { _kbca12 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double Kbca13
		{
			get { return _kbca13;}
			set { _kbca13 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double Kbca16
		{
			get { return _kbca16;}
			set { _kbca16 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double Kbca17
		{
			get { return _kbca17;}
			set { _kbca17 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double Kbca18
		{
			get { return _kbca18;}
			set { _kbca18 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double Kbca19
		{
			get { return _kbca19;}
			set { _kbca19 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double Kbca2
		{
			get { return _kbca2;}
			set { _kbca2 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double Kbca20
		{
			get { return _kbca20;}
			set { _kbca20 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double Kbca3
		{
			get { return _kbca3;}
			set { _kbca3 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double Kbca4
		{
			get { return _kbca4;}
			set { _kbca4 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double Kbca5
		{
			get { return _kbca5;}
			set { _kbca5 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double Kbca6
		{
			get { return _kbca6;}
			set { _kbca6 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double Kbcamount
		{
			get { return _kbcamount;}
			set { _kbcamount = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string MedicalNo
		{
			get { return _medicalNo;}
			set { _medicalNo = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double ndybcamount
		{
			get { return _ndybcamount;}
			set { _ndybcamount = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double OrigiNala1
		{
			get { return _origiNala1;}
			set { _origiNala1 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double OrigiNala12
		{
			get { return _origiNala12;}
			set { _origiNala12 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double Originala13
		{
			get { return _originala13;}
			set { _originala13 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double Originala16
		{
			get { return _originala16;}
			set { _originala16 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double Originala17
		{
			get { return _originala17;}
			set { _originala17 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double OrigiNala18
		{
			get { return _origiNala18;}
			set { _origiNala18 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double Originala19
		{
			get { return _originala19;}
			set { _originala19 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double OrigiNala2
		{
			get { return _origiNala2;}
			set { _origiNala2 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double OrigiNala20
		{
			get { return _origiNala20;}
			set { _origiNala20 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double Originala3
		{
			get { return _originala3;}
			set { _originala3 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double OrigiNala4
		{
			get { return _origiNala4;}
			set { _origiNala4 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double Originala5
		{
			get { return _originala5;}
			set { _originala5 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double Originala6
		{
			get { return _originala6;}
			set { _originala6 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double Originalamount
		{
			get { return _originalamount;}
			set { _originalamount = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double Sjbca1
		{
			get { return _sjbca1;}
			set { _sjbca1 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double Sjbca12
		{
			get { return _sjbca12;}
			set { _sjbca12 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double Sjbca13
		{
			get { return _sjbca13;}
			set { _sjbca13 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double Sjbca16
		{
			get { return _sjbca16;}
			set { _sjbca16 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double Sjbca17
		{
			get { return _sjbca17;}
			set { _sjbca17 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double Sjbca18
		{
			get { return _sjbca18;}
			set { _sjbca18 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double sjbca19
		{
			get { return _sjbca19;}
			set { _sjbca19 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double Sjbca2
		{
			get { return _sjbca2;}
			set { _sjbca2 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double Sjbca20
		{
			get { return _sjbca20;}
			set { _sjbca20 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double Sjbca3
		{
			get { return _sjbca3;}
			set { _sjbca3 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double Sjbca4
		{
			get { return _sjbca4;}
			set { _sjbca4 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double Sjbca5
		{
			get { return _sjbca5;}
			set { _sjbca5 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double Sjbca6
		{
			get { return _sjbca6;}
			set { _sjbca6 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double Tgproportion
		{
			get { return _tgproportion;}
			set { _tgproportion = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double Wbhproportion
		{
			get { return _wbhproportion;}
			set { _wbhproportion = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double Zyyproportion
		{
			get { return _zyyproportion;}
			set { _zyyproportion = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double ZzproPortion
		{
			get { return _zzproPortion;}
			set { _zzproPortion = value;}
		}                                    
		
		/// <summary>
		/// 门诊病人ID,Ouhosinfo.Id
		/// </summary>
		public string MzRegID
		{
			get { return _mzRegID;}
			set { _mzRegID = value;}
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
		/// 备注
		/// </summary>
		public string Memo
		{
			get { return _memo;}
			set { _memo = value;}
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
		/// 已经封存，不可改删
		/// </summary>
		public bool IsAuthed
		{
			get { return _isAuthed;}
			set { _isAuthed = value;}
		}                                    
		                               
		        
	}  
}           


