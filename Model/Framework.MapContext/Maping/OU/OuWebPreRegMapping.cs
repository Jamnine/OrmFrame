using ELinq.Mapping.Fluent;
using Orm.Model;

namespace Orm.MapContext
{
    /// <summary>  
    ///  预约申请表
    /// </summary> 
    public partial class OuWebPreRegMapping: ClassMap<OuWebPreReg>  
    {  
        /// <summary>  
        /// Stru  
        /// </summary>  
        public OuWebPreRegMapping()  
        {  
            this.TableName("OUWEBPREREG").Schema("orm");
            this.Column(p => p.PatID).ColumnName("PatID");  
            this.Column(p => p.WebUserCode).ColumnName("WebUserCode");  
            this.Column(p => p.Name).ColumnName("Name");  
            this.Column(p => p.Sex).ColumnName("Sex");  
            this.Column(p => p.BirthDate).ColumnName("BirthDate");  
            this.Column(p => p.Phone).ColumnName("Phone");  
            this.Column(p => p.BookingPurpose).ColumnName("BookingPurpose");  
            this.Column(p => p.BookingComments).ColumnName("BookingComments");  
            this.Column(p => p.Comments).ColumnName("Comments");
            this.Column(p => p.PreRegTime).ColumnName("PreRegTime");  
            this.Column(p => p.TimeSpanSubID).ColumnName("TimeSpanSubID");  
            this.Column(p => p.DoctorId).ColumnName("DoctorId");
            this.Column(p => p.ApplyTime).ColumnName("ApplyTime");   
            this.Column(p => p.OperId).ColumnName("OperId");  
            this.Column(p => p.OperTime).ColumnName("OperTime");  
            this.Column(p => p.IsDealed).ColumnName("IsDealed");
            this.Column(p => p.BookingSource).ColumnName("BookingSource");   
            this.Column(p => p.IsActive).ColumnName("IsActive");
            this.Column(p => p.MzRegID).ColumnName("MzRegID");
            this.Column(p => p.LocationID).ColumnName("LocationID");
            this.Column(p => p.Status).ColumnName("Status"); 
               
              
            
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify);   
        }  
  
    }  
}  
  
  

