using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.InterFace
{
    public class ApiResultInfo
    {
        public string error_msg { get; set; }
        public string status { get; set; }
        public string is_empty { get; set; }
        public string error_code { get; set; }
        public List<ApiResultInfoDetail> result { get; set; }
    }
    public class ApiResultInfoDetail
    {
        #region 病人基础信息
        public string sex { get; set; }
        public string age { get; set; }
        public string social_no { get; set; }
        public string mobile { get; set; }
        public string hic_no { get; set; }
        public string times { get; set; }
        public string birth_date { get; set; }
        public string relation_tel { get; set; }
        public string home_street { get; set; }
        #endregion

        #region 检验信息部分
        public string patient_id { get; set; }
        public string URL { get; set; }
        public string exec_unit { get; set; }
        public string sample_name { get; set; }
        public string test_name { get; set; }
        public string doctor { get; set; }
        public string apply_unit { get; set; }
        public string apply_date { get; set; }
        public string test_no { get; set; }
        public string status_flag { get; set; }
        #endregion

        #region 住院医嘱病历信息部分
        public string skin_test_result { get; set; }
        public string order_type { get; set; }
        public string order_time { get; set; }
        public string order_name { get; set; }
        public string therapeutic_flag { get; set; }
        public string order_code { get; set; }
        public string doseage_unit { get; set; }
        public string pay_self { get; set; }
        public string occ_time_confirm { get; set; }
        public string drug_specification { get; set; }
        public string alter_print_order { get; set; }
        public string input_group_sn { get; set; }
        public string charge_amount { get; set; }
        public string fit_flag { get; set; }
        public string preventive_flag { get; set; }
        public string supply { get; set; }
        public string firstdayocctimes { get; set; }
        public string end_time_2 { get; set; }
        public string drug_occ { get; set; }
        public string pathway_schedule_sn { get; set; }
        public string cancel_confirm { get; set; }
        public string start_time { get; set; }
        public string exclusive_type { get; set; }
        public string stop_doctor_study { get; set; }
        public string exclu_back_time { get; set; }
        public string confirm_opera_study { get; set; }
        public string skin_test_flag { get; set; }
        public string apply_item_code { get; set; }
        public string infant_flag { get; set; }
        public string emergency_flag { get; set; }
        public string parentchild_tag { get; set; }
        public string Serial { get; set; }
        public string confirm_time { get; set; }
        public string self_buy { get; set; }
        public string doseage { get; set; }
        public string back_flag { get; set; }
        public string patient { get; set; }
        public string confirm_opera_doctor { get; set; }
        public string print_order { get; set; }
        public string ope_flag { get; set; }
        public string modifier { get; set; }
        public string print_order_change { get; set; }
        public string parent_no { get; set; }
        public string sr_flag { get; set; }
        public string enter_time { get; set; }
        public string stop_confirm_opera { get; set; }
        public string enter_oper { get; set; }
        public string occ_opera { get; set; }
        public string mini_unit { get; set; }
        public string stop_doctor { get; set; }
        public string act_order_no { get; set; }
        public string occ_time_confirm_opera { get; set; }
        public string group_no { get; set; }
        public string confirm_opera { get; set; }
        public string stop_confirm_time { get; set; }
        public string yz_comment { get; set; }
        public string sb_equip_id { get; set; }
        public string deleted_flag { get; set; }
        public string sb_loan_docu_no { get; set; }
        public string end_time { get; set; }
        public string long_once_flag { get; set; }
        public string frequ_anem { get; set; }
        public string discription { get; set; }
        public string confirm_time_doctor { get; set; }
        public string cancel_confirm_time { get; set; }
        public string ward { get; set; }
        public string name { get; set; }
        public string modify_time { get; set; }
        public string dept { get; set; }
        public string instruction { get; set; }
        public string modifier_study { get; set; }
        public string stop_confirm { get; set; }
        public string stop_opera { get; set; }
        public string sr_zh_sn { get; set; }
        public string pathway_t_sn { get; set; }
        public string order_doctor { get; set; }
        public string performance_time { get; set; }
        public string apply_sn { get; set; }
        public string exclu_act_order_no { get; set; }
        #endregion

        #region 门诊病历信息部分
        public string FamilyHistoryOther { get; set; }
        public string ExamBp2 { get; set; }
        public string UsDrugCase { get; set; }
        public string OtherHistory { get; set; }
        public string Treatment { get; set; }
        public string MainInform { get; set; }
        public string ExamBp { get; set; }
        public string PhysicalCheck { get; set; }
        public string SickHist { get; set; }
        public string Abortion { get; set; }
        public string ExamT { get; set; }
        public string ExamR { get; set; }
        public string ExamP { get; set; }
        public string Menarche { get; set; }
        public string AllErgy { get; set; }
        #endregion
    }
}
