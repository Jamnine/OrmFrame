using ELinq.Mapping.Fluent;
using Orm.Model;

namespace Orm.MapContext
{
    /// <summary>
    ///  小孩口腔表
    /// </summary>
    public partial class ChildrenOralMapping: ClassMap<ChildrenOral>  
    {  
        /// <summary>  
        /// Stru  
        /// </summary>  
        public ChildrenOralMapping()  
        {  
            this.TableName("CHILDRENORAL").Schema("orm");  
            this.Column(p => p.SchoolName).ColumnName("SCHOOLNAME");  
            this.Column(p => p.ClassLevel).ColumnName("CLASSLEVEL");  
            this.Column(p => p.StudentID).ColumnName("STUDENTID");  
            this.Column(p => p.Name).ColumnName("NAME");  
            this.Column(p => p.Sex).ColumnName("SEX");  
            this.Column(p => p.Birthday).ColumnName("BIRTHDAY");  
            this.Column(p => p.DentalConditions).ColumnName("DENTALCONDITIONS");  
            this.Column(p => p.CheckDate).ColumnName("CHECKDATE");  
            this.Column(p => p.IsParentalConsent).ColumnName("ISPARENTALCONSENT");  
            this.Column(p => p.PitAndFissure).ColumnName("PITANDFISSURE");  
            this.Column(p => p.OperatorDate).ColumnName("OPERATORDATE");  
            this.Column(p => p.Signature).ColumnName("SIGNATURE");  
            this.Column(p => p.Review).ColumnName("REVIEW");  
            this.Column(p => p.ReviewDate).ColumnName("REVIEWDATE");  
            this.Column(p => p.Telephone).ColumnName("TELEPHONE");  
            this.Column(p => p.Memo).ColumnName("MEMO");  
            this.Column(p => p.OperId).ColumnName("OPERID");  
            this.Column(p => p.OperTime).ColumnName("OPERTIME");
            this.Column(p => p.ReClose).ColumnName("RECLOSE");
            this.Column(p => p.OperName).ColumnName("OPERNAME");
            this.Column(p => p.ParentsAgree).ColumnName("PARENTSAGREE");
            this.Column(p => p.HospitalId).ColumnName("HOSPITALID");


            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify);   
        }  
  
    }  
}  
  
  

