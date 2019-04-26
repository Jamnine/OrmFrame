

using System;
namespace Orm.Model
{
	/// <summary>
	/// 用户 - 实体扩展类
	/// </summary>
 
	public partial class BsUser
	{   
        /// <summary>
        /// 角色id
        /// </summary>
	    public string RoleId { get; set; }


        /// <summary>
        /// 门诊类别  
        /// </summary>
        public string RegTypeId { get; set; }

        /// <summary>  
        /// 所属门诊机构  
        /// </summary>  
        public string LocationId{ get; set; }

        /// <summary>
        /// 可登陆诊所，如1001|1002
        /// </summary>
        public string HospitalIDs { get; set; }

        /// <summary>
        /// 可登陆诊所，如诊所1|诊所2
        /// </summary>
        public string HospitalIDNames { get; set; }

        /// 体检总检权限
        /// </summary>
        public bool IsTjSummary { get; set; }
        /// <summary>
        /// 体检科室
        /// </summary>
        public string TjLocationID { get; set; }

        /// <summary>
        /// 自愿者(代码中无使用)
        /// </summary>
        public bool IsInternalService { get; set; }

        /// <summary>
        /// 是否上门服务 (代码中无使用)
        /// </summary>
        public bool IsDoorService { get; set; }

        /// <summary>
        /// 医生等级
        /// </summary>
        public int DoctorLevel { get; set; }

        /// <summary>
        /// 是否选中 用于单次操作
        /// </summary>
        public bool IsSelect { get; set; }
        /// <summary>
        /// 擅长
        /// </summary>
        public string Specialty { get; set; }        private byte[] _pictureSource;
        /// <summary>  
        /// 头像图片二进制  
        /// </summary>  
        public byte[] PictureSource
        {
            get { return this._pictureSource; }
            set { this._pictureSource = value; }
        }


        /// <summary>
        /// 可登陆诊所，如1001|1002
        /// </summary>
        public string LocationIDs { get; set; }

        /// <summary>
        /// 可登陆诊所，如诊所1|诊所2
        /// </summary>
        public string LocationNames { get; set; }

    }
}           


