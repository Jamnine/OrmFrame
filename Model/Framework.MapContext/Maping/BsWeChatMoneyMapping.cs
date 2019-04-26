

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 行心云:微信红包记录表 - 实体类
	/// </summary>
	public partial class BsWeChatMoneyMapping: ClassMap<BsWeChatMoney>
	{   
		/// <summary>
		/// 行心云:微信红包记录表 - 实体类
		/// </summary>
		public BsWeChatMoneyMapping()
		{
			this.TableName("BSWECHATMONEY").Schema("orm");
            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p =>p.DoctorId).ColumnName("DOCTORID");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.LoctionId).ColumnName("LOCTIONID");
			  
			this.Column(p =>p.Money).ColumnName("MONEY");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

