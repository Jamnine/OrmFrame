using ELinq.Mapping.Fluent;
using Orm.Model;

namespace Orm.MapContext
{
    /// <summary>  
    ///  医生团队
    /// </summary>  
    public partial class DoctorTeamMapping : ClassMap<DoctorTeam>
    {
        /// <summary>  
        /// Stru  
        /// </summary>  
        public DoctorTeamMapping()
        {
            this.TableName("DoctorTeam").Schema("orm");
            this.Column(p => p.DoctorTeamname).ColumnName("DoctorTeamname");
            this.Column(p => p.DoctorTeamIIS).ColumnName("DoctorTeamIIS");
            this.Column(P => P.IsActive).ColumnName("IsActive");
             
            
            
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
        }

    }
}
