using ELinq.Mapping.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Orm.Model;

namespace Orm.MapContext
{
    public class BsCheckTestListMapping : ClassMap<BsCheckTestList>
    {
        /// <summary>
        /// 
        /// </summary>
        public BsCheckTestListMapping()
        {
            this.TableName("BsCheckTestList").Schema("orm");

            this.Column(p => p.IllName).ColumnName("ILLNAME");
            this.Column(p => p.GroupType).ColumnName("GROUPTYPE");
            this.Column(p => p.CheckTestType).ColumnName("CHECKTESTTYPE");
            this.Column(p => p.ItemName).ColumnName("ITEMNAME");
            this.Column(p => p.ItemDesc).ColumnName("ITEMDESC");
            this.Column(p => p.ItemResult).ColumnName("ITEMRESULT");
            this.Column(p => p.HospitalID).ColumnName("HOSPITALID");
            this.Column(p => p.IllId).ColumnName("ILLID");
            this.Column(p => p.ItemId).ColumnName("ITEMID");  
         this.Id(t => t.GUID); this.Ignore(p => p.IsModify);
        }
    }
}
