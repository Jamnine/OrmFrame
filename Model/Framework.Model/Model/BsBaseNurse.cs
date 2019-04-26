

using System;
namespace Orm.Model
{
	/// <summary>
	/// 临床路径护理 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsBaseNurse:BaseModel
	{   
		 
		private string _code;  //
		
		private string _name;  //
		
		private string _pyCode;  //
		
		private string _wbCode;  //
		
		private int _orderBy;  //
		
		private bool _isActive;  //
		
		private int _iconIndex;  //
		
		private string _memo;  //备注
		
		private string _groupMainId;  //主组
		
		private string _groupSubId;  //子组
		
		private string _groupSubId2;  //三级分组
		
		private string _engDesc;  //英文名
		
		private int _lsYbType;  //类别：1-甲类；2-乙类；3-自费
		
		private string _ybMemo;  //

        private int _hospitalId;//医院ID

         
		/// <summary>
		/// 
		/// </summary>
		public string Code
		{
			get { return _code;}
			set { _code = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string Name
		{
			get { return _name;}
			set { _name = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string PyCode
		{
			get { return _pyCode;}
			set { _pyCode = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string WbCode
		{
			get { return _wbCode;}
			set { _wbCode = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int OrderBy
		{
			get { return _orderBy;}
			set { _orderBy = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public bool IsActive
		{
			get { return _isActive;}
			set { _isActive = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int IconIndex
		{
			get { return _iconIndex;}
			set { _iconIndex = value;}
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
		/// 主组
		/// </summary>
		public string GroupMainId
		{
			get { return _groupMainId;}
			set { _groupMainId = value;}
		}                                    
		
		/// <summary>
		/// 子组
		/// </summary>
		public string GroupSubId
		{
			get { return _groupSubId;}
			set { _groupSubId = value;}
		}                                    
		
		/// <summary>
		/// 三级分组
		/// </summary>
		public string GroupSubId2
		{
			get { return _groupSubId2;}
			set { _groupSubId2 = value;}
		}                                    
		
		/// <summary>
		/// 英文名
		/// </summary>
		public string EngDesc
		{
			get { return _engDesc;}
			set { _engDesc = value;}
		}                                    
		
		/// <summary>
		/// 类别：1-甲类；2-乙类；3-自费
		/// </summary>
		public int LsYbType
		{
			get { return _lsYbType;}
			set { _lsYbType = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string YbMemo
		{
			get { return _ybMemo;}
			set { _ybMemo = value;}
		}


    }  
}           


