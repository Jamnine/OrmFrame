using ELinq.Mapping.Fluent;
using Orm.Model;

namespace Orm.MapContext
{
    /// <summary>  
    ///  定时发送任务
    ///</summary> 
    public partial class TimingSendTaskMapping: ClassMap<TimingSendTask>  
    {  
        /// <summary>  
        /// Stru  
        /// </summary>  
        public TimingSendTaskMapping()  
        {  
            this.TableName("TIMINGSENDTASK").Schema("orm");  
            this.Column(p => p.Name).ColumnName("Name");  
            this.Column(p => p.MessageContent).ColumnName("MessageContent");  
            this.Column(p => p.TaskState).ColumnName("TaskState");  
            this.Column(p => p.TaskType).ColumnName("TaskType");  
            this.Column(p => p.SendTime).ColumnName("SendTime");  
            this.Column(p => p.MsgError).ColumnName("MsgError");  
            this.Column(p => p.CreateDate).ColumnName("CreateDate");  
            this.Column(p => p.CreatOperID).ColumnName("CreatOperID");  
               
              
            
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify);   
        }  
  
    }  
}  
  
  

