

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 自动更新文件表 - 实体类
	/// </summary>
	public partial class GblAutoUpdateMapping: ClassMap<GblAutoUpdate>
	{   
		/// <summary>
		/// 自动更新文件表 - 实体类
		/// </summary>
		public GblAutoUpdateMapping()
		{
			this.TableName("GBLAUTOUPDATE").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.PathName).ColumnName("PATHNAME");
			  
			this.Column(p =>p.FileContent).ColumnName("FILECONTENT");
			  
			this.Column(p =>p.OldVersion).ColumnName("OLDVERSION");
			  
			this.Column(p =>p.NewVersion).ColumnName("NEWVERSION");
			  
			this.Column(p =>p.UpLoadHostName).ColumnName("UPLOADHOSTNAME");
			  
			this.Column(p =>p.UpLoadIp).ColumnName("UPLOADIP");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.DownLoadHostNames).ColumnName("DOWNLOADHOSTNAMES");
			  
			this.Column(p =>p.HospitalIDs).ColumnName("HospitalIDS");
			  
			this.Column(p =>p.FileSize).ColumnName("FILESIZE");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

