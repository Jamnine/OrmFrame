using System;
using System.Collections.Generic;

namespace Orm.Model
{
    [Serializable]
    public class Iteminfo:BaseModel
    {
        private int _detail_sn { get; set; }
        private string _apply_status { get; set; }
        private string _post_zychargeID { get; set; }
        public string Post_zychargeID 
        {
            get { return _post_zychargeID; }
            set { _post_zychargeID = value; }
        }
        public int Detail_sn
        {
            get { return _detail_sn; }
            set { _detail_sn = value; }
        }

        public string Apply_status
        {
            get { return _apply_status; }
            set { _apply_status = value; }
        }
    }

    [Serializable]
    public class Mzcharge : BaseModel
    {
        private string _patient_id { get; set; }
        private int _times { get; set; }
        private string _order_type { get; set; }
        private int _order_no { get; set; }
        private int _ledger_sn { get; set; }
        private DateTime _confirm_time { get; set; }
        private string _confirm_opera { get; set; }
        private int _confirm_win { get; set; }
        private DateTime _dosage_time { get; set; }
        private string _dosage_opera { get; set; }
        public string Patient_id
        {
            get { return _patient_id; }
            set { _patient_id = value; }
        }

        public int Times
        {
            get { return _times; }
            set { _times = value; }
        }

        public string Order_type
        {
            get { return _order_type; }
            set { _order_type = value; }
        }

        public int Order_no
        {
            get { return _order_no; }
            set { _order_no = value; }
        }
        public int Ledger_sn
        {
            get { return _ledger_sn; }
            set { _ledger_sn = value; }
        }
        public DateTime Confirm_time
        {
            get { return _confirm_time; }
            set { _confirm_time = value; }
        }
        public string Confirm_opera
        {
            get { return _confirm_opera; }
            set { _confirm_opera = value; }
        }
        public int Confirm_win
        {
            get { return _confirm_win; }
            set { _confirm_win = value; }
        }
        public DateTime Dosage_time
        {
            get { return _dosage_time; }
            set { _dosage_time = value; }
        }
        public string Dosage_opera
        {
            get { return _dosage_opera; }
            set { _dosage_opera = value; }
        }

    }

    [Serializable]
    public class MzchargeBack : BaseModel
    {
        private string _patient_id { get; set; }
        private int _times { get; set; }
        private string _order_type { get; set; }
        private int _order_no { get; set; }
        private int _ledger_sn { get; set; }
        private DateTime _confirm_time { get; set; }
        private string _confirm_opera { get; set; }
        private List<Iteminfo> _iteminfo { get; set; }
        public string Patient_id
        {
            get { return _patient_id; }
            set { _patient_id = value; }
        }

        public int Times
        {
            get { return _times; }
            set { _times = value; }
        }

        public string Order_type
        {
            get { return _order_type; }
            set { _order_type = value; }
        }

        public int Order_no
        {
            get { return _order_no; }
            set { _order_no = value; }
        }
        public int Ledger_sn
        {
            get { return _ledger_sn; }
            set { _ledger_sn = value; }
        }
        public DateTime Confirm_time
        {
            get { return _confirm_time; }
            set { _confirm_time = value; }
        }
        public string Confirm_opera
        {
            get { return _confirm_opera; }
            set { _confirm_opera = value; }
        }
        public List<Iteminfo> Iteminfo
        {
            get { return _iteminfo; }
            set { _iteminfo = value; }
        }
    }

    [Serializable]
    public class TospdDatabase : BaseModel
    {
        private string _code { get; set; }
        private string _name { get; set; }
        private string _py_code { get; set; }
        private string _d_code { get; set; }
        private string _print_name { get; set; }
        private string _mz_zy_flag { get; set; }
        private bool _deleted_flag { get; set; }
        private string _comment { get; set; }
        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Py_code
        {
            get { return _py_code; }
            set { _py_code = value; }
        }

        public string D_code
        {
            get { return _d_code; }
            set { _d_code = value; }
        }
        public string Print_name
        {
            get { return _print_name; }
            set { _print_name = value; }
        }
        public string Mz_zy_flag
        {
            get { return _mz_zy_flag; }
            set { _mz_zy_flag = value; }
        }
        public bool Deleted_flag
        {
            get { return _deleted_flag; }
            set { _deleted_flag = value; }
        }
        public string Comment
        {
            get { return _comment; }
            set { _comment = value; }
        }

    }
    [Serializable]
    public class YpBasedata : BaseModel
    {
        private string _charge_code { get; set; }
        public string Charge_code
        {
            get { return _charge_code; }
            set { _charge_code = value; }
        }
        private string _serial { get; set; }
        public string Serial
        {
            get { return _serial; }
            set { _serial = value; }
        }
        private string _drug_id { get; set; }
        public string Drug_id
        {
            get { return _drug_id; }
            set { _drug_id = value; }
        }
        private string _drug_standard_id { get; set; }
        public string Drug_standard_id
        {
            get { return _drug_standard_id; }
            set { _drug_standard_id = value; }
        }
        private string _drugname { get; set; }
        public string Drugname
        {
            get { return _drugname; }
            set { _drugname = value; }
        }
        private string _dosage { get; set; }
        public string Dosage
        {
            get { return _dosage; }
            set { _dosage = value; }
        }
        private string _concentration { get; set; }
        public string Concentration
        {
            get { return _concentration; }
            set { _concentration = value; }
        }
        private Double _weight { get; set; }
        /// <summary>
        /// 重量
        /// </summary>
        public Double Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }
        private string _weight_unit { get; set; }
        /// <summary>
        /// 重量单位
        /// </summary>
        public string Weight_unit
        {
            get { return _weight_unit; }
            set { _weight_unit = value; }
        }
        private Double _volum { get; set; }
        /// <summary>
        /// 体积
        /// </summary>
        public Double Volum
        {
            get { return _volum; }
            set { _volum = value; }
        }
        private string _vol_unit { get; set; }
        /// <summary>
        /// 体积单位
        /// </summary>
        public string Vol_unit
        {
            get { return _vol_unit; }
            set { _vol_unit = value; }
        }
        private string _mini_unit { get; set; }
        public string Mini_unit
        {
            get { return _mini_unit; }
            set { _mini_unit = value; }
        }
        private Double _pack_size { get; set; }
        public Double Pack_size
        {
            get { return _pack_size; }
            set { _pack_size = value; }
        }
        private string _pack_unit { get; set; }
        public string Pack_unit
        {
            get { return _pack_unit; }
            set { _pack_unit = value; }
        }
        private string _specification { get; set; }
        public string Specification
        {
            get { return _specification; }
            set { _specification = value; }
        }
        private string _spe_comment { get; set; }
        public string Spe_comment
        {
            get { return _spe_comment; }
            set { _spe_comment = value; }
        }
        private Double _fix_price { get; set; }
        public Double Fix_price
        {
            get { return _fix_price; }
            set { _fix_price = value; }
        }
        private Double _retprice { get; set; }
        public Double Retprice
        {
            get { return _retprice; }
            set { _retprice = value; }
        }
        private string _manufactory { get; set; }
        public string Manufactory
        {
            get { return _manufactory; }
            set { _manufactory = value; }
        }
        private string _self_flag { get; set; }
        public string Self_flag
        {
            get { return _self_flag; }
            set { _self_flag = value; }
        }
        private string _separate_flag { get; set; }
        public string Separate_flag
        {
            get { return _separate_flag; }
            set { _separate_flag = value; }
        }
        private string _suprice_flag { get; set; }
        public string Suprice_flag
        {
            get { return _suprice_flag; }
            set { _suprice_flag = value; }
        }
        private string _drug_flag { get; set; }
        public string Drug_flag
        {
            get { return _drug_flag; }
            set { _drug_flag = value; }
        }
        private string _py_code { get; set; }
        public string Py_code
        {
            get { return _py_code; }
            set { _py_code = value; }
        }
        private string _d_code { get; set; }
        public string D_code
        {
            get { return _d_code; }
            set { _d_code = value; }
        }
        private string _infusion_flag { get; set; }
        public string Infusion_flag
        {
            get { return _infusion_flag; }
            set { _infusion_flag = value; }
        }
        private string _country_flag { get; set; }
        public string Country_flag
        {
            get { return _country_flag; }
            set { _country_flag = value; }
        }
        private string _divide_flag { get; set; }
        public string Divide_flag
        {
            get { return _divide_flag; }
            set { _divide_flag = value; }
        }
        private bool _deleted_flag { get; set; }
        public bool Deleted_flag
        {
            get { return _deleted_flag; }
            set { _deleted_flag = value; }
        }
        private string _drug_kind { get; set; }
        public string Drug_kind
        {
            get { return _drug_kind; }
            set { _drug_kind = value; }
        }
        private string _zy_bill_item { get; set; }
        public string Zy_bill_item
        {
            get { return _zy_bill_item; }
            set { _zy_bill_item = value; }
        }
        private string _mz_bill_item { get; set; }
        public string Mz_bill_item
        {
            get { return _mz_bill_item; }
            set { _mz_bill_item = value; }
        }
        private string _zy_charge_group { get; set; }
        public string Zy_charge_group
        {
            get { return _zy_charge_group; }
            set { _zy_charge_group = value; }
        }
        private string _mz_charge_group { get; set; }
        public string Mz_charge_group
        {
            get { return _mz_charge_group; }
            set { _mz_charge_group = value; }
        }
        private string _class_code { get; set; }
        public string Class_code
        {
            get { return _class_code; }
            set { _class_code = value; }
        }
        private string _extend_code { get; set; }
        public string Extend_code
        {
            get { return _extend_code; }
            set { _extend_code = value; }
        }
        private string _supply_code { get; set; }
        public string Supply_code
        {
            get { return _supply_code; }
            set { _supply_code = value; }
        }
        private string _frequ_code { get; set; }
        public string Frequ_code
        {
            get { return _frequ_code; }
            set { _frequ_code = value; }
        }
        private Double _order_dosage { get; set; }
        public Double Order_dosage
        {
            get { return _order_dosage; }
            set { _order_dosage = value; }
        }
        private string _dosage_unit { get; set; }
        public string Dosage_unit
        {
            get { return _dosage_unit; }
            set { _dosage_unit = value; }
        }
        private Double _buy_price { get; set; }
        public Double Buy_price
        {
            get { return _buy_price; }
            set { _buy_price = value; }
        }
        private string _lowdosage_flag { get; set; }
        public string Lowdosage_flag
        {
            get { return _lowdosage_flag; }
            set { _lowdosage_flag = value; }
        }
        private string _audit_code { get; set; }
        public string Audit_code
        {
            get { return _audit_code; }
            set { _audit_code = value; }
        }
        private string _skin_test_flag { get; set; }
        public string Skin_test_flag
        {
            get { return _skin_test_flag; }
            set { _skin_test_flag = value; }
        }
        private string _print_name { get; set; }
        public string Print_name
        {
            get { return _print_name; }
            set { _print_name = value; }
        }
        private string _license_no { get; set; }
        public string License_no
        {
            get { return _license_no; }
            set { _license_no = value; }
        }
        private int _eff_month { get; set; }
        public int Eff_month
        {
            get { return _eff_month; }
            set { _eff_month = value; }
        }
        private string _trad_mark { get; set; }
        /// <summary>
        /// 商标
        /// </summary>
        public string Trad_mark
        {
            get { return _trad_mark; }
            set { _trad_mark = value; }
        }
        private string _fu_flag { get; set; }
        public string Fu_flag
        {
            get { return _fu_flag; }
            set { _fu_flag = value; }
        }
        private Double _retprice2 { get; set; }
        public Double Retprice2
        {
            get { return _retprice2; }
            set { _retprice2 = value; }
        }
        private string _zy_supply_code { get; set; }
        public string Zy_supply_code
        {
            get { return _zy_supply_code; }
            set { _zy_supply_code = value; }
        }
        private string _extend_code2 { get; set; }
        public string Extend_code2
        {
            get { return _extend_code2; }
            set { _extend_code2 = value; }
        }
        private string _zy_frequ_code { get; set; }
        public string Zy_frequ_code
        {
            get { return _zy_frequ_code; }
            set { _zy_frequ_code = value; }
        }
        private string _hzyl_ml_flag { get; set; }
        public string Hzyl_ml_flag
        {
            get { return _hzyl_ml_flag; }
            set { _hzyl_ml_flag = value; }
        }
        private string _jb_flag { get; set; }
        public string Jb_flag
        {
            get { return _jb_flag; }
            set { _jb_flag = value; }
        }
        private string _part_flag { get; set; }
        public string Part_flag
        {
            get { return _part_flag; }
            set { _part_flag = value; }
        }
        private string _pjmz_flag { get; set; }
        public string Pjmz_flag
        {
            get { return _pjmz_flag; }
            set { _pjmz_flag = value; }
        }
        private string _py_visit_flag { get; set; }
        public string Py_visit_flag
        {
            get { return _py_visit_flag; }
            set { _py_visit_flag = value; }
        }
        private string _sctjgl_flag { get; set; }
        public string Sctjgl_flag
        {
            get { return _sctjgl_flag; }
            set { _sctjgl_flag = value; }
        }
        private string _skgl_flag { get; set; }
        public string Skgl_flag
        {
            get { return _skgl_flag; }
            set { _skgl_flag = value; }
        }
        private string _tdmz_flag { get; set; }
        public string Tdmz_flag
        {
            get { return _tdmz_flag; }
            set { _tdmz_flag = value; }
        }
        private string _xfj_flag { get; set; }
        public string Xfj_flag
        {
            get { return _xfj_flag; }
            set { _xfj_flag = value; }
        }
        private string _ym_flag { get; set; }
        public string Ym_flag
        {
            get { return _ym_flag; }
            set { _ym_flag = value; }
        }
        private string _ba_bill_item { get; set; }
        public string Ba_bill_item
        {
            get { return _ba_bill_item; }
            set { _ba_bill_item = value; }
        }
        private string _hos_ori_code { get; set; }
        public string Hos_ori_code
        {
            get { return _hos_ori_code; }
            set { _hos_ori_code = value; }
        }
    }

    [Serializable]
    public class YpRetprice : BaseModel
    {
        private string _charge_code { get; set; }
        private string _serial { get; set; }
        private Double _buy_price { get; set; }
        private Double _retprice { get; set; }
        public string Charge_code
        {
            get { return _charge_code; }
            set { _charge_code = value; }
        }

        public string Serial
        {
            get { return _serial; }
            set { _serial = value; }
        }

        public Double Buy_price
        {
            get { return _buy_price; }
            set { _buy_price = value; }
        }
        /// <summary>
        /// 重新定价
        /// </summary>
        public Double Retprice
        {
            get { return _retprice; }
            set { _retprice = value; }
        }
    }

    [Serializable]
    public class YpStock : BaseModel
    {
        private string _charge_code { get; set; }
        private string _serial { get; set; }
        private string _group_no { get; set; }
        private Double _stock_amount { get; set; }
        public string Charge_code
        {
            get { return _charge_code; }
            set { _charge_code = value; }
        }

        public string Serial
        {
            get { return _serial; }
            set { _serial = value; }
        }

        public string Group_no
        {
            get { return _group_no; }
            set { _group_no = value; }
        }

        public Double Stock_amount
        {
            get { return _stock_amount; }
            set { _stock_amount = value; }
        }
    }
    
    [Serializable]
    public class YpTablenewcode : BaseModel
    {
        private string _tableName { get; set; }
        /// <summary>
        /// 表名称
        /// </summary>
        public string TableName
        {
            get { return _tableName; }
            set { _tableName = value; }
        }
    }

    [Serializable]
    public class Zycharge : BaseModel
    {
        private int _businessflag { get; set; }
        private string _page_no { get; set; }
        private string _ward_sn { get; set; }
        private string _dept_sn { get; set; }
        private DateTime _submit_time { get; set; }
        private int _page_type { get; set; }
        private string _group_no { get; set; }
        private DateTime _confirm_time { get; set; }
        private string _confirm_opera { get; set; }
        private DateTime _print_time { get; set; }
        private DateTime _print_bag_time { get; set; }
        private List<Iteminfo> _iteminfo { get; set; }
        public int Businessflag
        {
            get { return _businessflag; }
            set { _businessflag = value; }
        }
        public string Page_no
        {
            get { return _page_no; }
            set { _page_no = value; }

        }
        public string Ward_sn
        {
            get { return _ward_sn; }
            set { _ward_sn = value; }
        }
        public string Dept_sn
        {
            get { return _dept_sn; }
            set { _dept_sn = value; }
        }
        public DateTime Submit_time
        {
            get { return _submit_time; }
            set { _submit_time = value; }
        }
        public int Page_type
        {
            get { return _page_type; }
            set { _page_type = value; }
        }
        public string Group_no
        {
            get { return _group_no; }
            set { _group_no = value; }
        }
        /// <summary>
        /// 确认时间
        /// </summary>
        public DateTime Confirm_time
        {
            get { return _confirm_time; }
            set { _confirm_time = value; }
        }
        /// <summary>
        /// 确认人
        /// </summary>
        public string Confirm_opera
        {
            get { return _confirm_opera; }
            set { _confirm_opera = value; }
        }
        public DateTime Print_time
        {
            get { return _print_time; }
            set { _print_time = value; }
        }
        public DateTime Print_bag_time
        {
            get { return _print_bag_time; }
            set { _print_bag_time = value; }
        }
        public List<Iteminfo> Iteminfo
        {
            get { return _iteminfo; }
            set { _iteminfo = value; }
        }

    }

    [Serializable]
    public class ZychargeZcy : BaseModel
    {
        private string _patient_id { get; set; }
        /// <summary>
        /// 病人Id
        /// </summary>
        public string Patient_id
        {
            get { return _patient_id; }
            set { _patient_id = value; }
        }
        private int _admiss_times { get; set; }
        public int Admiss_times
        {
            get { return _admiss_times; }
            set { _admiss_times = value; }
        }
        private int _page_no { get; set; }
        public int Page_no
        {
            get { return _page_no; }
            set { _page_no = value; }
        }
        private int _act_order_no { get; set; }
        public int Act_order_no
        {
            get { return _act_order_no; }
            set { _act_order_no = value; }
        }
        private string _ward_sn { get; set; }
        public string Ward_sn
        {
            get { return _ward_sn; }
            set { _ward_sn = value; }
        }
        private string _dept_sn { get; set; }
        public string Dept_sn
        {
            get { return _dept_sn; }
            set { _dept_sn = value; }
        }
        private string _group_no { get; set; }
        public string Group_no
        {
            get { return _group_no; }
            set { _group_no = value; }
        }
        private DateTime _confirm_time { get; set; }
        /// <summary>
        /// 确认时间
        /// </summary>
        public DateTime Confirm_time
        {
            get { return _confirm_time; }
            set { _confirm_time = value; }
        }
        private string _confirm_opera { get; set; }
        /// <summary>
        /// 确认人
        /// </summary>
        public string Confirm_opera
        {
            get { return _confirm_opera; }
            set { _confirm_opera = value; }
        }
    }
}
