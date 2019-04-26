using ELinq.Mapping.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Orm.Model;

namespace Orm.MapContext
{
    public partial class YlReferralRecordMapping : ClassMap<YlReferralRecord>
    {
        /// <summary>
        /// 转诊记录表
        /// </summary>
        public YlReferralRecordMapping()
        {
            this.TableName("YLREFERRALRECORD").Schema("orm");

            this.Column(p => p.PatId).ColumnName("PATIENTID");
            this.Column(p => p.OriginalHospitalId).ColumnName("ORIGINALHospitalID");
            this.Column(p => p.OriginaDepartmentId).ColumnName("ORIGINALDEPARTMENTID");
            this.Column(p => p.OriginaDoctorId).ColumnName("ORIGINALDOCTORID");
            this.Column(p => p.ReferralHospitalId).ColumnName("REFERRALHospitalID");
            this.Column(p => p.ReferralDepartmentId).ColumnName("REFERRALDEPARTMENTID");
            this.Column(p => p.ReferralDoctorId).ColumnName("REFERRALDOCTORID");
            this.Column(p => p.ReferralTimeBegin).ColumnName("REFERRALTIMEBEGIN");
            this.Column(p => p.ReferralTimeEnd).ColumnName("REFERRALTIMEEND");
            this.Column(p => p.Remarks).ColumnName("REMARKS");
            this.Column(p => p.ReferralObjective).ColumnName("REFERRALOBJECTIVE");
            this.Column(p => p.OperatorId).ColumnName("OPERATORID");
            this.Column(p => p.OperatorTime).ColumnName("OPERATORTIME");
            this.Column(p => p.PreliminaryDiagnosis).ColumnName("PRELIMINARYDIAGNOSIS");
            this.Column(p => p.EmergencyDegree).ColumnName("EMRRGENCYDEGREE");

             
            
            
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
        }
    }
}
