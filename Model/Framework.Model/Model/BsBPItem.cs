

using System;
namespace Orm.Model
{
	/// <summary>
	/// BP的基础项目表 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsBPItem:BaseModel
	{   
		 
		private string _name;  //BP项目名称
		
		private string _pyCode;  //拼音码
		
		private string _wbCode;  //五笔码
		
		private int _lsRpType;  //处方项目：1-药品；2-非药品项目
		
		private string _ybCode;  //医保编码

        private int _HospitalID;//医院ID

		
		/// <summary>
		/// BP项目名称
		/// </summary>
		public string Name
		{
			get { return _name;}
			set { _name = value;}
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
		/// 处方项目：1-药品；2-非药品项目
		/// </summary>
		public int LsRpType
		{
			get { return _lsRpType;}
			set { _lsRpType = value;}
		}                                    
		
		/// <summary>
		/// 医保编码
		/// </summary>
		public string YbCode
		{
			get { return _ybCode;}
			set { _ybCode = value;}
		}


  
    }  
}           


