

using System;
namespace Orm.Model
{
	/// <summary>
	/// 仓库药库药品库存表 - 实体类
	/// </summary>
 
	public partial class HuStores:BaseModel
	{

        /// <summary>
        /// 扣减前原库存 // 融余
        /// </summary>
        public double OldStockNum { get; set; }


    }  
}           


