using ELinq.Mapping.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orm.Model;

namespace Orm.MapContext.Maping.CMS
{
    /// <summary>
    /// 
    /// </summary>
    public class CMS_WeChatPayOrderMapping: ClassMap<CMS_WeChatPayOrder>
    {
        /// <summary>
        /// 
        /// </summary>
        public CMS_WeChatPayOrderMapping()
        {
            this.TableName("CMS_WECHATPAYORDER").Schema("orm");
            this.Column(p=>p.ID).ColumnName("ID");
            this.Column(p => p.TenantId).ColumnName("TENANTID");
            this.Column(p => p.ItemName).ColumnName("ITEMNAME");
            this.Column(p => p.Attach).ColumnName("ATTACH");
            this.Column(p => p.OrderNo).ColumnName("ORDERNO");
            this.Column(p => p.ActuallyMoney).ColumnName("ACTUALLYMONEY");
            this.Column(p => p.CreateTime).ColumnName("CREATETIME");
            this.Column(p => p.PayUse).ColumnName("PAYUSE");
            this.Column(p => p.StateCode).ColumnName("STATECODE");
            this.Column(p => p.NickName).ColumnName("NICKNAME");
            this.Column(p => p.MobileNumber).ColumnName("MOBILENUMBER");
            this.Column(p => p.PayProcess).ColumnName("PAYPROCESS");
            this.Column(p => p.Transaction_id).ColumnName("TRANSACTION_ID");
            this.Column(p => p.Serial_trade_no).ColumnName("SERIAL_TRADE_NO");
            this.Column(p => p.Openid).ColumnName("OPENID");
            this.Column(p => p.CompletionTime).ColumnName("COMPLETIONTIME");
            this.Column(p => p.PayUseInfo).ColumnName("PAYUSEINFO");
            this.Column(p => p.Out_refund_no).ColumnName("OUT_REFUND_NO");
            this.Column(p => p.Refund_id).ColumnName("REFUND_ID");
            this.Column(p => p.Remark).ColumnName("REMARK");
            this.Column(p => p.ExpressTime).ColumnName("EXPRESSTIME");
            this.Column(p => p.UserCode).ColumnName("USERCODE");
            this.Id(t => t.ID); this.Ignore(p => p.IsModify);
        }
    }
}
