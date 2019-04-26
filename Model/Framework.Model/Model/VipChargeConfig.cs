

using System;
namespace Orm.Model
{
    /// <summary>
    ///  - 实体类
    /// </summary>
    [Serializable]
    public partial class VipChargeConfig : BaseModel
    { 
        private string _viplevelid;  //会员等级ID

        private double _balance;  //充值金额

        private double _givingintegral1;  //赠送积分

        private double _givingintegral2;  //推荐人赠送积分

        private bool _isAuthed;  //已经封存，不可改删

        private int _HospitalID;  //

        public VipChargeConfig() { }
                    
		
		/// <summary>
		/// 会员等级ID
		/// </summary>
		public string Viplevelid
		{
			get { return _viplevelid;}
			set { _viplevelid = value;}
		}                                    
		
		/// <summary>
		/// 充值金额
		/// </summary>
		public double Balance
		{
			get { return _balance;}
			set { _balance = value;}
		}                                    
		
		/// <summary>
		/// 赠送积分
		/// </summary>
		public double Givingintegral1
		{
			get { return _givingintegral1;}
			set { _givingintegral1 = value;}
		}                                    
		
		/// <summary>
		/// 推荐人赠送积分
		/// </summary>
		public double Givingintegral2
		{
			get { return _givingintegral2;}
			set { _givingintegral2 = value;}
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


