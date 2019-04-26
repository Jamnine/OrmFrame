

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	public partial class VipCardLog:BaseModel
	{
        private string _operName;  
        public string OperName
        {
            get { return _operName; }
            set { _operName = value; }
        }
        
    }  
}           


