

using System;
namespace Orm.Model
{
	/// <summary>
	/// 行心云:病人既往史记录表 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsPatDisease:BaseModel
    {   
		 
		private string _dhID;  //疾病ID
		
		private string _dhName;  //疾病名称
		
		private DateTime _dhdate;  //疾病确认时间
		
		private int _dhType;  //疾病分类
		
		private int _HospitalID;  //
		  
		/// <summary>
		/// 疾病ID
		/// </summary>
		public string DhID
		{
			get { return _dhID;}
			set { _dhID = value;}
		}                                    
		
		/// <summary>
		/// 疾病名称
		/// </summary>
		public string DhName
		{
			get { return _dhName;}
			set { _dhName = value;}
		}                                    
		
		/// <summary>
		/// 疾病确认时间
		/// </summary>
		public DateTime Dhdate
		{
			get { return _dhdate;}
			set { _dhdate = value;}
		}                                    
		
		/// <summary>
		/// 疾病分类
		/// </summary>
		public int DhType
		{
			get { return _dhType;}
			set { _dhType = value;}
		}                                    
		
	

        private string  _patid;
        /// <summary>
        /// 病人ID
        /// </summary> 
        public string  Patid
        {
            get { return this._patid; }
            set { this._patid = value; }
        }

    }  
}           


