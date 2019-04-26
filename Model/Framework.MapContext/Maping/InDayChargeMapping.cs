using ELinq.Mapping.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Orm.Model;

namespace Orm.MapContext
{
    /// <summary>
	/// 住院每天固定收费项目(针对科室或全院) - 实体类
	/// </summary>
    public partial class InDayChargeMapping:ClassMap<InDayCharge>
    {
        /// <summary>
        /// 住院每天固定收费项目(针对科室或全院)
        /// </summary>
        public InDayChargeMapping ()
        {
            this.TableName("InDayCharge").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			   
			this.Column(p =>p.PatTypeId).ColumnName("PATTYPEID");

            this.Column(p => p.BeginTime).ColumnName("BEGINTIME");
            this.Column(p => p.Totality).ColumnName("TOTALITY");
            this.Column(p => p.IsAuthed).ColumnName("ISAUTHED");
            this.Column(p => p.ItemId).ColumnName("ITEMID"); 
             this.Column(p => p.HospitalId).ColumnName("HospitalID");
            this.Column(p => p.HisType).ColumnName("HISTYPE");
            this.Column(p => p.InsertTime).ColumnName("INSERTTIME");
            this.Column(p =>p.LocationId).ColumnName("LOCATIONID");
            this.Column(p => p.UnitId).ColumnName("UNITID");

            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify);
    }
    }
}
