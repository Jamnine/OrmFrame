

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 
	/// </summary>
	public partial class ZxybPatMapping : ClassMap<ZxybPat>
	{   
		/// <summary>
		/// 会员积分表 - 实体类
		/// </summary>
		public ZxybPatMapping()
		{
			this.TableName("ZXYBPAT").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.PatId).ColumnName("PATID");
			  
			this.Column(p =>p.Astr1).ColumnName("HOSPID");

            this.Column(p => p.Astr2).ColumnName("HOSPID");

            this.Column(p => p.Astr3).ColumnName("HOSPID");

            this.Column(p => p.Astr4).ColumnName("HOSPID");

            this.Column(p => p.Astr5).ColumnName("HOSPID");

            this.Column(p => p.Astr6).ColumnName("HOSPID");

            this.Column(p => p.Astr7).ColumnName("HOSPID");

            this.Column(p => p.Astr8).ColumnName("HOSPID");

            this.Column(p => p.Astr9).ColumnName("HOSPID");

            this.Column(p => p.Astr10).ColumnName("HOSPID");

            this.Column(p => p.Astr11).ColumnName("HOSPID");

            this.Column(p => p.Astr12).ColumnName("HOSPID");

            this.Column(p => p.Astr13).ColumnName("HOSPID");

            this.Column(p => p.Astr14).ColumnName("HOSPID");

            this.Column(p => p.Astr15).ColumnName("HOSPID");

            this.Column(p => p.Astr16).ColumnName("HOSPID");

            this.Column(p => p.Astr17).ColumnName("HOSPID");

            this.Column(p => p.Astr18).ColumnName("HOSPID");

            this.Column(p => p.Astr19).ColumnName("HOSPID");

            this.Column(p => p.Astr20).ColumnName("HOSPID");

            this.Column(p => p.Astr21).ColumnName("HOSPID");

            this.Column(p => p.Astr22).ColumnName("HOSPID");

            this.Column(p => p.Astr23).ColumnName("HOSPID");

            this.Column(p => p.Astr24).ColumnName("HOSPID");

            this.Column(p => p.Astr25).ColumnName("HOSPID");

            this.Column(p => p.Astr26).ColumnName("HOSPID");

            this.Column(p => p.Astr27).ColumnName("HOSPID");

            this.Column(p => p.Astr28).ColumnName("HOSPID");

            this.Column(p => p.Astr29).ColumnName("HOSPID");

            this.Column(p => p.Astr30).ColumnName("HOSPID");

            this.Column(p => p.Astr31).ColumnName("HOSPID");

            this.Column(p => p.Astr32).ColumnName("HOSPID");

            this.Column(p => p.Astr33).ColumnName("HOSPID");

            this.Column(p => p.Astr34).ColumnName("HOSPID");

            this.Column(p => p.Astr35).ColumnName("HOSPID");

            this.Column(p =>p.Astr36).ColumnName("MEMO");
			  
			this.Column(p =>p.Astr37).ColumnName("OPERTIME");
			  
			this.Column(p =>p.Astr38).ColumnName("OPERID");

            this.Column(p => p.IsAuthed).ColumnName("ISAUTHED");

            this.Column(p => p.HospitalId).ColumnName("HospitalID");

            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

