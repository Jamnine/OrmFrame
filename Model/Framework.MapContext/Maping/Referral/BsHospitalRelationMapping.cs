using ELinq.Mapping.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Orm.Model;

namespace Orm.MapContext
{
    /// <summary>
    ///医院可以转诊医院的关系表
    /// </summary>
    public partial class BsHospitalRelationMapping : ClassMap<BsHospitalRelation>
    {
        /// <summary>
        /// 医院可以转诊医院的关系表
        /// </summary>
        public BsHospitalRelationMapping()
        {
            this.TableName("BsHospitalRelation").Schema("orm");
             
            this.Column(p => p.OutHospitalId).ColumnName("OutHospitalID");
            this.Column(p => p.InHospitalId).ColumnName("InHospitalID");
            this.Column(p => p.IsExChange).ColumnName("IsExChange");
            this.Column(p => p.RelationDesc).ColumnName("RelationDesc");
             
            //this.Id(T => T.ID).DbGenerated();
            this.SequenceId(t => t.GUID).SequenceName("BsHospitalRelation_ID_SEQ");
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
        }
    }
}
