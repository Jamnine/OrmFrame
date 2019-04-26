

using System;
namespace Orm.Model
{
	/// <summary>
	/// 历史医生医嘱修改记录 - 实体类
	/// </summary>
	[Serializable]
	public partial class HistTrAdvice : BaseModel
    {   
		
		private DateTime _inSertTime;  // 
		
		private DateTime _operTime;  //操作时间
		
		private string _operId;  //操作员ID,BsUser.Id
		
		private string _adviceId;  //医嘱ID
		
		private int _lsMarkType;  //医嘱类别:1长嘱2临嘱3其它11中药12护嘱13辅助记账
		
		private string _type;  //类别
		
		private string _before;  //操作前
		
		private string _after;  //操作后
		
		private string _hospId;  //住院病人对应InHosinfo.Id
		
		private int _HospitalID;  //
		 

		
		/// <summary>
		/// 插入时间
		/// </summary>
		public DateTime InSertTime
		{
			get { return _inSertTime;}
			set { _inSertTime = value;}
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
		/// 操作员ID,BsUser.Id
		/// </summary>
		public string OperId
		{
			get { return _operId;}
			set { _operId = value;}
		}                                    
		
		/// <summary>
		/// 医嘱ID
		/// </summary>
		public string AdviceId
		{
			get { return _adviceId;}
			set { _adviceId = value;}
		}                                    
		
		/// <summary>
		/// 医嘱类别:1长嘱2临嘱3其它11中药12护嘱13辅助记账
		/// </summary>
		public int LsMarkType
		{
			get { return _lsMarkType;}
			set { _lsMarkType = value;}
		}                                    
		
		/// <summary>
		/// 类别
		/// </summary>
		public string Type
		{
			get { return _type;}
			set { _type = value;}
		}                                    
		
		/// <summary>
		/// 操作前
		/// </summary>
		public string Before
		{
			get { return _before;}
			set { _before = value;}
		}                                    
		
		/// <summary>
		/// 操作后
		/// </summary>
		public string After
		{
			get { return _after;}
			set { _after = value;}
		}                                    
		
		/// <summary>
		/// 住院病人对应InHosinfo.Id
		/// </summary>
		public string HospId
		{
			get { return _hospId;}
			set { _hospId = value;}
		}                                    
		                                 
		        
	}  
}           


