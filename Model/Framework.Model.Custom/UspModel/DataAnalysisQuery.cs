using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 
    /// </summary>
    /// 
    [Serializable]
    public class DataAnalysisQuery
    {
        /// <summary>
        /// 开始时间（报表）
        /// </summary>
        public DateTime BeginTime { get; set; }
        /// <summary>
        /// 结束时间（报表）
        /// </summary>
        public DateTime EndTime { get; set; }
        /// <summary>
        ///员工ID
        /// </summary>
        public string doctorId { get; set; }
        /// <summary>
        ///登陆员工ID
        /// </summary>
        public string UserID { get; set; }
        /// <summary>
        ///药房ID
        /// </summary>
        public string RoomId { get; set; }
        /// <summary>
        ///科室ID  
        /// </summary>
        public int HospitalId { get; set; }
        /// <summary>
        ///医院ID  
        /// </summary>
        public int hospitalId { get; set; }
        /// <summary>
        /// 项目类别ID
        /// </summary> 
        public int ItemTypeID { get; set; }
        /// <summary>
        /// 回访人员ID  
        /// </summary>
        public string OperId { get; set; }
        /// <summary>
        /// 回访状态ID  
        /// </summary>
        public string staId { get; set; }
        
        /// <summary>
        /// 治疗医生ID  
        /// </summary>
        public string doctorID { get; set; }
        /// <summary>
        /// 收费分类ID  
        /// </summary>
        public string PatTypeId { get; set; }
        /// <summary>
        /// 转诊后医生id
        /// </summary>
        public string TransferDoctorId { get; set; }

        /// <summary>
        /// 转诊前医生id
        /// </summary>
        public string OldTransferDoctorId { get; set; }
        /// <summary>
        /// 员工（存储）
        /// </summary>
        public string v_DoctorId { get { return this.doctorId; } }

        /// <summary>
        /// 登陆员工ID（存储）
        /// </summary>
        public string v_userid { get { return this.UserID; } }

        
        /// <summary>
        ///药房（存储）
        /// </summary>
        public string v_pharmacy { get { return this.RoomId; } }
        /// <summary>
        /// 门诊机构名称
        /// </summary>
        public string LocationName { get; set; }

        /// <summary>
        /// 转诊总数
        /// </summary>
        public int TotalNumber { get; set; }

        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime ExecutionTime { get; set; }

        /// <summary>
        /// 病人来源
        /// </summary>
        public string PatientSource { get; set; }

        /// <summary>
        /// 客人ID
        /// </summary>
        public string PatId { get; set; }

        /// <summary>
        /// 内部介绍人id（市场）
        /// </summary>
        public string IntroducerID { get; set; }

        /// <summary>
        /// 现在时间
        /// </summary>
        public DateTime NowTime { get; set; }

        /// <summary>
        /// 外部运营业绩指标汇总
        /// </summary>
        public int TotalAmount { get; set; }

        /// <summary>
        /// 就诊状态ID 
        /// </summary>
        public string Visit { get; set; }

        /// <summary>
        /// 医院名称 
        /// </summary>
        public string HospitalName {  get;set; }

        /// <summary>
        /// 制表人 
        /// </summary>
        public string Lister {  get; set; }
        
        ///// <summary>
        ///// 预约到诊总数
        ///// </summary>
        //public int TotalNumberA { get; set; }

        ///// <summary>
        ///// 收费项目用量汇总总数
        ///// </summary>
        //public int TotalNumberB { get; set; }


        /// <summary>
        /// 门诊机构名称(专家助理患者)
        /// </summary>
        public string ClinicName { get { return this.LocationName; } }

        /// <summary>
        /// 收银员ID
        /// </summary>
        public string CashierId { get; set; }

        /// <summary>
        /// 患者ID
        /// </summary>
        public string PatientID { get; set; }

        /// <summary>
        /// 科室ID
        /// </summary>
        public string DepartmentID { get; set; }

        /// <summary>
        /// 专家助理ID
        /// </summary>
        public string ConsultID { get; set; }

        /// <summary>
        /// 收费项目大类ID
        /// </summary>
        public string FeeMzID { get; set; }

        /// <summary>
        /// 收费项目小类ID
        /// </summary>
        public string ChildFeeMzID { get; set; }

        /// <summary>
        /// 会员卡等级
        /// </summary>
        public string VipLevel{ get ;set;}

        /// <summary>
        /// 会员卡ID
        /// </summary>
        public string VipCardID { get; set; }


        /// <summary>
        /// 操作类型
        /// </summary>
        public int OperType { get; set; }

        /// <summary>
        /// 内部推荐人
        /// </summary>
        public string DoctorId { get; set; }


        public string index { get; set; }

        /// <summary>
        /// 是否特殊病人
        /// </summary>
        public string CanSeeIllness { get; set; }

        /// <summary>
        /// 是否特殊病人
        /// </summary>
        public string Assistantid { get; set; }


     
        /// <summary>
        /// 是否特殊病人
        /// </summary>
        public string Chargemodeid { get; set; }

        /// <summary>
        /// 消费类型
        /// </summary>
        public string Indexlevel { get; set; }
      
        /// <summary>
        /// 医生职称
        /// </summary>
        public string Doclevid { get; set; }



        /// <summary>
        /// 支付方式
        /// </summary>
        public string PayWayId{ get; set; }

        private string _invoNo = string.Empty;
        /// <summary>
        /// 发票号
        /// </summary>
        public string InvoNo
        {
            get { return this._invoNo; }
            set { this._invoNo = value; }
        }

        private string _patSearchCondition = string.Empty;
        /// <summary>
        /// 病人
        /// </summary>
        public string PatSearchCondition
        {
            get { return this._patSearchCondition; }
            set { this._patSearchCondition = value; }
        }
        
        /// <summary>
        ///  开始时间（存储）
        /// </summary>
        public string v_begintime { get { return this.BeginTime.ToString("yyyy-MM-dd"); } }

        /// <summary>
        /// 结束时间（存储）
        /// </summary>
        //private string v_endtime;
        public string v_endtime { get { return this.EndTime.ToString("yyyy-MM-dd"); } }

        /// <summary>
        /// 医生职称
        /// </summary>        
        public string v_doclevid { get { return this.Doclevid; } }
        /// <summary>
        /// 医院
        /// </summary>        
        public int v_hospitalId { get { return this.HospitalId; } }
        /// <summary>
        /// 转诊前医生（存储） 
        /// </summary>
        public string v_olddoctorid { get { return this.OldTransferDoctorId; } }

        /// <summary>
        /// 就诊状态（存储）
        /// </summary>
        public string v_visit { get { return this.Visit; } }
        /// <summary>
        /// 回访人员（存储）
        /// </summary>
        public string v_operId { get { return this.OperId; } }

        /// <summary>
        /// 回访状态（存储）
        /// </summary>
        public string v_staId { get { return this.staId; } }

        /// <summary>
        /// 治疗医生（存储）
        /// </summary>
        public string v_doctorId { get { return this.doctorID ; } }
        /// <summary>
        /// 收费分类（存储）
        /// </summary>
        public string v_code { get { return this.PatTypeId; } }
        /// <summary>
        /// 转诊后医生（存储）
        /// </summary>
        public string v_doctorid { get { return this.TransferDoctorId; } }   
        /// <summary>
        /// 科室ID（存储）
        /// </summary>
        public int v_loc { get { return this.HospitalId; } }

        /// <summary>
        /// 诊所ID（存储）
        /// </summary>
        public string cv_1 { get { return "121"; } }


        /// <summary>
        /// 客人ID（存储）
        /// </summary>
        public string v_PatId { get { return this.PatId; } }

        /// <summary>
        /// 内部介绍人ID（存储）
        /// </summary>
        public string v_IntroducerId { get { return this.IntroducerID; } }

        /// <summary>
        /// 病人来源（存储）
        /// </summary>
        public string v_PatientSource { get { return this.PatientSource; } }

        /// <summary>
        /// 专家助理ID（存储）
        /// </summary>
        public string v_consultid { get { return this.ConsultID; } }

        /// <summary>
        /// 科室ID（存储）
        /// </summary>
        public string v_departmentid { get { return this.DepartmentID; } }
       
        /// <summary>
        /// 收费项目大类ID（存储）
        /// </summary>
        public string v_feemzid { get { return this.FeeMzID; } }

        /// <summary>
        /// 收费项目小类ID（存储）
        /// </summary>
        public string v_childfeemzid { get { return this.ChildFeeMzID; } }

        /// <summary>
        /// 会员卡等级
        /// </summary>
        public string v_levelid { get { return this.VipLevel; } }

        /// <summary>
        /// 会员卡ID
        /// </summary>
        public string v_vipcardid { get { return this.VipCardID; } }

        /// <summary>
        /// 操作类型
        /// </summary>
        public int v_opertype { get { return this.OperType; } }

        /// <summary>
        /// 内部推荐人
        /// </summary>
        public string v_doctorid_a { get { return this.DoctorId; } }
        /// <summary>
        /// 项目类别ID（存储）
        /// </summary>
        public int v_itemType { get { return this.ItemTypeID; } }
        /// <summary>
        /// ID
        /// </summary>
        //public string v_id { get { return "0"; } }

        /// <summary>
        /// 报表类型（存储）
        /// </summary>
        public string v_index { get { return this.index; } }


        
        /// <summary>
        /// 收银员ID（存储）
        /// </summary>
        public string v_cashierId { get { return this.CashierId; } }

        /// <summary>
        /// 是否特殊病人（存储）0-否 1-是
        /// </summary>
        public string v_canSeeIllness { get { return this.CanSeeIllness; } }

        /// <summary>
        /// 医生助理（存储）
        /// </summary>
        public string v_assistantid { get { return this.Assistantid; } }

        /// <summary>
        /// （存储）
        /// </summary>
        public string v_chargemodeid { get { return this.Chargemodeid; } }

        /// <summary>
        /// 消费类型（存储）
        /// </summary>
        public string v_indexlevel { get { return this.Indexlevel; } }

        /// <summary>
        /// 支付方式（存储）
        /// </summary>
        public string v_payWayId { get { return this.PayWayId; } }

        /// <summary>
        /// 发票号（存储）
        /// </summary>
        public string v_invoNo { get { return this.InvoNo; } }

        /// <summary>
        /// 病人（存储）
        /// </summary>
        public string v_patSearchCondition { get { return this.PatSearchCondition; } }



    }
}
