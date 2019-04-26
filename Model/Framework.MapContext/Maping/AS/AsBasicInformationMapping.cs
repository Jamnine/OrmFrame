using ELinq.Mapping.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Orm.Model;

namespace Orm.MapContext.Maping.AS
{
    public class AsBasicInformationMapping : ClassMap<AsBasicInformation>
    {
        public AsBasicInformationMapping()
        {
            this.TableName("AsBasicInformation").Schema("orm");
            this.Column(p => p.AssessedGrade).ColumnName("ASSESSEDGRADE");
            this.Column(p => p.AssessedTime).ColumnName("ASSESSEDTIME");
            this.Column(p => p.AssessmentId).ColumnName("ASSESSMENTID");
            this.Column(p => p.CareDemand).ColumnName("CAREDEMAND");
            this.Column(p => p.CareDemandIds).ColumnName("CAREDEMANDIDS");
            this.Column(p => p.CareProvider).ColumnName("CAREPROVIDER");
            this.Column(p => p.CareProviderIds).ColumnName("CAREPROVIDERIDS");
            this.Column(p => p.CurrentCare).ColumnName("CURRENTCARE");
            this.Column(p => p.CurrentCareIds).ColumnName("CURRENTCAREIDS");
            this.Column(p => p.EndowmentInsurance).ColumnName("ENDOWMENTINSURANCE");
            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p => p.HedicalInsurance).ColumnName("HEDICALINSURANCE");
            this.Column(p => p.HedicalInsuranceOther).ColumnName("HEDICALINSURANCEOTHER");
            this.Column(p => p.HisType).ColumnName("HISTYPE");
            this.Column(p => p.HospitalId).ColumnName("HospitalID");
            this.Column(p => p.HousingSituation).ColumnName("HOUSINGSITUATION");
            this.Column(p => p.ID).ColumnName("ID");
            this.Column(p => p.InsertTime).ColumnName("INSERTTIME");
            this.Column(p => p.IsAssessed).ColumnName("ISASSESSED");
            this.Column(p => p.LivingConditions).ColumnName("LIVINGCONDITIONS");
            this.Column(p => p.Location).ColumnName("LOCATION");
            this.Column(p => p.MemberFamilyMember1).ColumnName("MEMBERFAMILYMEMBER1");
            this.Column(p => p.MemberFamilyMember2).ColumnName("MEMBERFAMILYMEMBER2");
            this.Column(p => p.ModioperID).ColumnName("MODIOPERID");
            this.Column(p => p.Phone1).ColumnName("PHONE1");
            this.Column(p => p.Phone2).ColumnName("PHONE2");
            this.Column(p => p.Relation1).ColumnName("RELATION1");
            this.Column(p => p.Relation2).ColumnName("RELATION2");
            this.Column(p => p.SurveyAddress).ColumnName("SURVEYADDRESS");
            this.Column(p => p.SurveyAddressId).ColumnName("SURVEYADDRESSID");

            this.Id(t => t.ID); this.Ignore(p => p.IsModify);
        }
    }
}
