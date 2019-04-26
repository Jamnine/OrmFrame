

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 行心云:病人档案?? - 实体类
	/// </summary>
	public partial class OuHealthCheckHitMapping: ClassMap<OuHealthCheckHit>
	{   
		/// <summary>
		/// 行心云:病人档案?? - 实体类
		/// </summary>
		public OuHealthCheckHitMapping()
		{
			this.TableName("OUHEALTHCHECKHIT").Schema("orm");
            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p =>p.PatId).ColumnName("PATID");
			  
			this.Column(p =>p.LocationId).ColumnName("LOCATIONID");
			  
			this.Column(p =>p.MzRegId).ColumnName("MZREGID");
			  
			this.Column(p =>p.Operid).ColumnName("OPERID");
			  
			this.Column(p =>p.OperLastDate).ColumnName("OPERLASTDATE");
			  
			this.Column(p =>p.IsPeaceQuality).ColumnName("ISPEACEQUALITY");
			  
			this.Column(p =>p.IsQiDeficiency).ColumnName("ISQIDEFICIENCY");
			  
			this.Column(p =>p.IsYinDeficiency).ColumnName("ISYINDEFICIENCY");
			  
			this.Column(p =>p.IsYangDeficiency).ColumnName("ISYANGDEFICIENCY");
			  
			this.Column(p =>p.IsPhlegmDampness).ColumnName("ISPHLEGMDAMPNESS");
			  
			this.Column(p =>p.IsDampHeat).ColumnName("ISDAMPHEAT");
			  
			this.Column(p =>p.IsCongestion).ColumnName("ISCONGESTION");
			  
			this.Column(p =>p.IsQiStagnation).ColumnName("ISQISTAGNATION");
			  
			this.Column(p =>p.IsIntrinsicQuality).ColumnName("ISINTRINSICQUALITY");
			  
			this.Column(p =>p.NaoXueGuan).ColumnName("NAOXUEGUAN");
			  
			this.Column(p =>p.ShenZang).ColumnName("SHENZANG");
			  
			this.Column(p =>p.XinZang).ColumnName("XINZANG");
			  
			this.Column(p =>p.XueGuan).ColumnName("XUEGUAN");
			  
			this.Column(p =>p.YanBu).ColumnName("YANBU");
			  
			this.Column(p =>p.ShenJingSystem).ColumnName("SHENJINGSYSTEM");
			  
			this.Column(p =>p.Other).ColumnName("OTHER");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

