using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model
{
    [Serializable]
    public partial class SeverStock
    {
        //private string _receiving;  //收货单位
        //private string _billNo;  //单据号
        //private string _distributionType; //配送方式
        //private string _x_date; //配送时间
        //private decimal _tal_cpcg;//该单据的合计金额
        //private string _cpca;//药品编码
        //private string _cpcb;//药品名称
        //private string _cpcc;//药品规格
        //private string _lot_no;//生产批号
        //private decimal _cpcg_m;//药品合计金额
        //private string _lot_date;//有效期
        //private string _in_per;//生产日期
        //private decimal _cpce;//数量（该数量是以kg为单位，在云门诊需要转为以g单位）
        //private decimal _cpcf_m;//单价（该单价是以kg为单位，在云门诊需要转为以g单位）
        //private decimal _cpcf;//成本价
        //private decimal _cpci_no;//门店编码（可根据该编码判断是不是该诊所）
        //private string _jixing;//剂型
        //private string _pizhwh;//注册证号或生成企业许可证号
        //private string _shengccj;//生产厂商
        //private decimal _qhdh;//件数
        public string id;
        public string rowOrder;
        public string cpci;
        public string x_no;
        public string psfx;
        public string x_date;
        public string tal_cpcg;
        public string cpca;
        public string cpcb;
        public string cpcc;
        public string lot_no;
        public string cpcg_m;
        public string lot_date;
        public string in_per;
        public string cpce;
        public string cpcf_m;
        public string cpcf;
        public string cpci_no;
        public string jixing;
        public string pizhwh;
        public string shengccj;
        public string qhdh;
    }
}
