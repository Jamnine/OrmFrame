

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
    /// <summary>
    /// 检验机器表 - 实体类
    /// </summary>
    public partial class CkMachineMapping : ClassMap<CKMachine>
    {
        /// <summary>
        /// 检验机器表 - 实体类
        /// </summary>
        public CkMachineMapping()
        {
            this.TableName("CKMACHINE").Schema("orm");

            this.Column(p => p.GUID).ColumnName("GUID");

            this.Column(p => p.Code).ColumnName("CODE");

            this.Column(p => p.Name).ColumnName("NAME");

            this.Column(p => p.TestTypeID).ColumnName("TESTTYPEID");

            this.Column(p => p.TypeNum).ColumnName("TYPENUM");

            this.Column(p => p.MachineNum).ColumnName("MACHINENUM");

            this.Column(p => p.FirstSampleNum).ColumnName("FIRSTSAMPLENUM");

            this.Column(p => p.LastSampleNum).ColumnName("LASTSAMPLENUM");

            this.Column(p => p.PyCode).ColumnName("PYCODE");

            this.Column(p => p.OrderBy).ColumnName("ORDERBY");

            this.Column(p => p.IconIndex).ColumnName("ICONINDEX");

            this.Column(p => p.IsActive).ColumnName("ISACTIVE");

            this.Column(p => p.SimpleBeginDate).ColumnName("SIMPLEBEGINDATE");

            this.Column(p => p.FilePath).ColumnName("FILEPATH");

            this.Column(p => p.DataSource).ColumnName("DATASOURCE");

            this.Column(p => p.Result).ColumnName("RESULT");

            this.Column(p => p.EndCode).ColumnName("ENDCODE");

            this.Column(p => p.WbCode).ColumnName("WBCODE");

            this.Column(p => p.ParseTime).ColumnName("PARSETIME");

            this.Column(p => p.Port).ColumnName("PORT");

            this.Column(p => p.BaudRate).ColumnName("BAUDRATE");

            this.Column(p => p.ComPort).ColumnName("COMPORT");

            this.Column(p => p.ClassName).ColumnName("CLASSNAME");

            this.Column(p => p.Barcode).ColumnName("BARCODE");

            this.Column(p => p.Handshake).ColumnName("HANDSHAKE");

            this.Column(p => p.StopBit).ColumnName("STOPBIT");

            this.Column(p => p.Parity).ColumnName("PARITY");

            this.Column(p => p.PortNo).ColumnName("PORTNO");

            this.Column(p => p.HostIP).ColumnName("HOSTIP");

            this.Column(p => p.InstrumentTest).ColumnName("INSTRUMENTTEST");

            this.Column(p => p.CommunicateMode).ColumnName("COMMUNICATEMODE");

            this.Column(p => p.CommunicateType).ColumnName("COMMUNICATETYPE");

            this.Column(p => p.DataFormat).ColumnName("DATAFORMAT");

            this.Column(p => p.DataBit).ColumnName("DATABIT");

            this.Column(p => p.AssemblyName).ColumnName("ASSEMBLYNAME");

            this.Column(p => p.ResponseCode).ColumnName("RESPONSECODE");

            this.Column(p => p.ResponseAt).ColumnName("RESPONSEAT");

            this.Column(p => p.AccessPassword).ColumnName("ACCESSPASSWORD");

            this.Column(p => p.AccessUserID).ColumnName("ACCESSUSERID");

            this.Column(p => p.ResponseAts).ColumnName("RESPONSEATS");

            this.Column(p => p.VirtualInstrumentID).ColumnName("VIRTUALINSTRUMENTID");

            this.Column(p => p.Emergencypreseq).ColumnName("EMERGENCYPRESEQ");

            this.Column(p => p.IpAddress).ColumnName("IPADDRESS");

            this.Column(p => p.InstrumentSplits).ColumnName("INSTRUMENTSPLITS");

            this.Column(p => p.MaintenanceMan).ColumnName("MAINTENANCEMAN");

            this.Column(p => p.DictLabDeptID).ColumnName("DICTLABDEPTID");

            this.Column(p => p.DictSpecimentypeId).ColumnName("DICTSPECIMENTYPEID");

            this.Column(p => p.EngshortName).ColumnName("ENGSHORTNAME");

            this.Column(p => p.TestDate).ColumnName("TESTDATE");

            this.Column(p => p.MachineSampleTime).ColumnName("MACHINESAMPLETIME");

            this.Column(p => p.CkMnume).ColumnName("CKMNUME");

            this.Column(p => p.HospitalId).ColumnName("HospitalID");

             
            
            
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
        }
    }
}


