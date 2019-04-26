using System;

namespace Orm.Model
{
    /// <summary>  
    ///  医生团队
    /// </summary>  
    [Serializable]
    public partial class DoctorTeam : BaseModel
    {
        private string _doctorTeamname = String.Empty;
        private string _doctorTeamIIS = String.Empty;
        private bool _isactive = false;

        public DoctorTeam()
        {
        }
        
        /// <summary>  
        ///   医联体名称
        /// </summary>  
        public string DoctorTeamname
        {
            get { return this._doctorTeamname; }
            set { this._doctorTeamname = value; }
        }

        /// <summary>  
        ///    医联体指定iis
        /// </summary>  
        public string DoctorTeamIIS
        {
            get { return this._doctorTeamIIS; }
            set { this._doctorTeamIIS = value; }
        }

        /// <summary>
        /// 是否可用
        /// </summary>
        public bool IsActive
        {
            get { return this._isactive; }
            set { this._isactive = value; }
        }
    }
}
