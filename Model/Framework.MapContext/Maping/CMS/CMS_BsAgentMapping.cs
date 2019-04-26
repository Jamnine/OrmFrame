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
    public class CMS_BsAgentMapping: ClassMap<CMS_BsAgent>
    {
        /// <summary>
        /// 
        /// </summary>
        public CMS_BsAgentMapping()
        {
            this.TableName("CMS_BSAGENT").Schema("orm");
            this.Column(p => p.ID).ColumnName("ID");
            this.Column(p => p.AgentCode).ColumnName("AGENTCODE");
            this.Column(p => p.AgentName).ColumnName("AGENTNAME");
            this.Column(p => p.AgentType).ColumnName("AGENTTYPE");
            this.Column(p => p.CardType).ColumnName("CARDTYPE");
            this.Column(p => p.CardNum).ColumnName("CARDNUM");
            this.Column(p => p.MobileNum).ColumnName("MOBILENUM");
            this.Column(p => p.IsSelf).ColumnName("ISSELF");
            this.Column(p => p.UserBingId).ColumnName("USERBINGID");
            this.Column(p => p.UserCode).ColumnName("USERCODE");

            this.Id(t => t.ID); this.Ignore(p => p.IsModify);
        }
    }
}
