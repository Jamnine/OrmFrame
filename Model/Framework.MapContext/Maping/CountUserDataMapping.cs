using ELinq.Mapping.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orm.Model;

namespace Orm.MapContext.Maping
{
    /// <summary>
    /// 服务端访问统计-实体类
    /// </summary>
    public partial class CountUserDataMapping : ClassMap<CountUserData>
    {
        /// <summary>
        /// 服务端访问统计-实体类
        /// </summary>
        public CountUserDataMapping()
        {
            this.TableName("CountUserData").Schema("orm");

            this.Column(p => p.GUID).ColumnName("GUID");

            this.Column(p => p.ApiInterfaceName).ColumnName("ApiInterfaceName");

            this.Column(p => p.ClientComputerIP).ColumnName("ClientComputerIP");

            this.Column(p => p.CounterTime).ColumnName("CounterTime");

            //this.Column(p => p.HisType).ColumnName("HISTYPE");

            //this.Column(p => p.HospitalId).ColumnName("HOSPITALID");

            //this.Column(p => p.ID).ColumnName("ID");

            //this.Column(p => p.IsModify).ColumnName("ISMODIFY");

            this.Column(p => p.LocationName).ColumnName("LocationName");

            this.Column(p => p.MethodName).ColumnName("MethodName");

            this.Column(p => p.OperTime).ColumnName("OperTime");

            this.Column(p => p.ResponseData).ColumnName("ResponseData");

            this.Column(p => p.UserName).ColumnName("USERNAME");

            this.Column(p => p.ParameterContents).ColumnName("PARAMETERCONTENTS");

            this.Id(t => t.GUID); 
        }
    }
}
