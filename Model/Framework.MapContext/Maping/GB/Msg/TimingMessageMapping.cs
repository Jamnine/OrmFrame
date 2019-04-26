using ELinq.Mapping.Fluent;
using Orm.Model;

namespace Orm.MapContext
{
    /// <summary>  
    /// 定时发送信息表
    /// </summary> 
    public partial class TimingMessageMapping: ClassMap<TimingMessage>  
    {  
        /// <summary>  
        /// Stru  
        /// </summary>  
        public TimingMessageMapping()  
        {  
            this.TableName("TIMINGMESSAGE").Schema("orm");  
            this.Column(p => p.TaskID).ColumnName("TaskID");  
            this.Column(p => p.PatID).ColumnName("PatID");  
            this.Column(p => p.PatientName).ColumnName("PatientName");  
            this.Column(p => p.Sex).ColumnName("Sex");  
            this.Column(p => p.Mobile).ColumnName("Mobile");  
            this.Column(p => p.MessageContent).ColumnName("MessageContent");  
            this.Column(p => p.SendType).ColumnName("SendType");  
            this.Column(p => p.SendNum).ColumnName("SendNum");  
            this.Column(p => p.SendState).ColumnName("SendState");  
            this.Column(p => p.MsgError).ColumnName("MsgError");  
            this.Column(p => p.CreateDate).ColumnName("CreateDate");  
            this.Column(p => p.SendTime).ColumnName("SendTime");  
               
              
            
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify);   
        }  
  
    }  
}  
  
  

