

using System;
namespace Orm.Model
{
	/// <summary>
	/// 行心云:处方限制规则表 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsRecipeLimit:BaseModel
	{   
		 
		private string _itemId;  //项目ID
		
		private string _limitName;  //限制名称：过敏史或既往史
		
		private string _limitContent;  //限制内容（比如：包含青霉素，葡萄糖）
		
		private int _limitType;  //限制类型：1 询问 2限制
		
		private int _HospitalID;  //
		 
         
		/// <summary>
		/// 项目ID
		/// </summary>
		public string ItemId
		{
			get { return _itemId;}
			set { _itemId = value;}
		}                                    
		
		/// <summary>
		/// 限制名称：过敏史或既往史
		/// </summary>
		public string LimitName
		{
			get { return _limitName;}
			set { _limitName = value;}
		}                                    
		
		/// <summary>
		/// 限制内容（比如：包含青霉素，葡萄糖）
		/// </summary>
		public string LimitContent
		{
			get { return _limitContent;}
			set { _limitContent = value;}
		}                                    
		
		/// <summary>
		/// 限制类型：1 询问 2限制
		/// </summary>
		public int  LimitType
		{
			get { return _limitType;}
			set { _limitType = value;}
		}                                    
		
	                               
		        
	}  
}           


