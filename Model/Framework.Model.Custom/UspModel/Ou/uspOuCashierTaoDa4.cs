using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 收据套打类型四
    /// </summary>
    [Serializable]
    public class uspOuCashierTaoDa4
    {
        private double _guaHao;
        private double _yiCiQiXie;
        private double _maYao;
        private double _jieYa;
        private double _zhiLiao;
        private double _baYa;
        private double _shouShu;
        private double _guDingXiuFu;
        private double _huoDongXiuFu;
        private double _zhengJi;
        private double _zhongzhiya;
        private double _fangShe;
        private double _buYa;
        private double _yaZhouZhiLiao;
        private double _baYaDingJin;
        private double _yuFuJinE;

        private DateTime _invoTime;
        private string _clinicName = String.Empty;
        private string _phone = String.Empty;
        private string _biillNo = String.Empty;
        private string _patName = String.Empty;
        private string _sex = string.Empty;
        private int _age;
        private string _payWay = String.Empty;
        private string _doctor = String.Empty;
        private string _nurse = String.Empty;
        private string _oper = String.Empty;
        private string _wan = String.Empty;
        private string _qian = String.Empty;
        private string _bai = String.Empty;
        private string _shi = String.Empty;
        private string _yuan = String.Empty;
        private string _jiao = String.Empty;
        private string _fen = String.Empty;
        private double _amount;
        public uspOuCashierTaoDa4() { }


        /// <summary>
        /// 挂号
        /// </summary>
        public double GuaHao
        {
            get { return _guaHao; }
            set { _guaHao = value; }
        }

        /// <summary>
        /// 一次性器械费
        /// </summary>
        public double YiCiQiXie
        {
            get { return _yiCiQiXie; }
            set { _yiCiQiXie = value; }
        }
        /// <summary>
        /// 麻药费
        /// </summary>
        public double MaYao
        {
            get { return _maYao; }
            set { _maYao = value; }
        }

        /// <summary>
        /// 洁牙费
        /// </summary>
        public double JieYa
        {
            get { return _jieYa; }
            set { _jieYa = value; }
        }

        /// <summary>
        /// 治疗费
        /// </summary>
        public double ZhiLiao
        {
            get { return _zhiLiao; }
            set { _zhiLiao = value; }
        }

        /// <summary>
        /// 拔牙费
        /// </summary>
        public double BaYa
        {
            get { return _baYa; }
            set { _baYa = value; }
        }

        /// <summary>
        /// 手术费
        /// </summary>
        public double ShouShu
        {
            get { return _shouShu; }
            set { _shouShu = value; }
        }

        /// <summary>
        /// 固定修复
        /// </summary>
        public double GuDingXiuFu
        {
            get { return _guDingXiuFu; }
            set { _guDingXiuFu = value; }
        }

        /// <summary>
        /// 活动修复
        /// </summary>
        public double HuoDongXiuFu
        {
            get { return _huoDongXiuFu; }
            set { _huoDongXiuFu = value; }
        }

        /// <summary>
        /// 正畸费
        /// </summary>
        public double ZhengJi
        {
            get { return _zhengJi; }
            set { _zhengJi = value; }
        }

        /// <summary>
        /// 种植牙
        /// </summary>
        public double Zhongzhiya
        {
            get { return _zhongzhiya; }
            set { _zhongzhiya = value; }
        }

        /// <summary>
        /// 放射费
        /// </summary>
        public double FangShe
        {
            get { return _fangShe; }
            set { _fangShe = value; }
        }

        /// <summary>
        /// 补牙费
        /// </summary>
        public double BuYa
        {
            get { return _buYa; }
            set { _buYa = value; }
        }

        /// <summary>
        /// 牙周治疗费
        /// </summary>
        public double YaZhouZhiLiao
        {
            get { return _yaZhouZhiLiao; }
            set { _yaZhouZhiLiao = value; }
        }

        /// <summary>
        /// 拔牙定金
        /// </summary>
        public double BaYaDingJin
        {
            get { return _baYaDingJin; }
            set { _baYaDingJin = value; }
        }

        /// <summary>
        /// 预付金额
        /// </summary>
        public double YuFuJinE
        {
            get { return _yuFuJinE; }
            set { _yuFuJinE = value; }
        }

        /// <summary>
        /// 诊所名称
        /// </summary>
        public string ClinicName
        {
            get { return _clinicName; }
            set { _clinicName = value; }
        }

        /// <summary>
        /// 电话
        /// </summary>
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        /// <summary>
        /// 发票号
        /// </summary>
        public string BiillNo
        {
            get { return _biillNo; }
            set { _biillNo = value; }
        }

        /// <summary>
        /// 收费时间
        /// </summary>
        public DateTime InvoTime
        {
            get { return _invoTime; }
            set { _invoTime = value; }
        }

        /// <summary>
        /// 病人姓名
        /// </summary>
        public string PatName
        {
            get { return _patName; }
            set { _patName = value; }
        }

        /// <summary>
        /// 性别
        /// </summary>
        public string Sex
        {
            get { return _sex; }
            set { _sex = value; }
        }

        /// <summary>
        /// 年龄
        /// </summary>
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        /// <summary>
        /// 支付方式
        /// </summary>
        public string PayWay
        {
            get { return _payWay; }
            set { _payWay = value; }
        }

        /// <summary>
        /// 医生
        /// </summary>
        public string Doctor
        {
            get { return _doctor; }
            set { _doctor = value; }
        }

        /// <summary>
        /// 护士
        /// </summary>
        public string Nurse
        {
            get { return _nurse; }
            set { _nurse = value; }
        }

        /// <summary>
        /// 操作员
        /// </summary>
        public string Oper
        {
            get { return _oper; }
            set { _oper = value; }
        }

        /// <summary>
        /// 万
        /// </summary>
        public string Wan
        {
            get { return _wan; }
            set { _wan = value; }
        }

        /// <summary>
        /// 千
        /// </summary>
        public string Qian
        {
            get { return _qian; }
            set { _qian = value; }
        }

        /// <summary>
        /// 百
        /// </summary>
        public string Bai
        {
            get { return _bai; }
            set { _bai = value; }
        }


        /// <summary>
        /// 十
        /// </summary>
        public string Shi
        {
            get { return _shi; }
            set { _shi = value; }
        }

        /// <summary>
        /// 元
        /// </summary>
        public string Yuan
        {
            get { return _yuan; }
            set { _yuan = value; }
        }

        /// <summary>
        /// 角
        /// </summary>
        public string Jiao
        {
            get { return _jiao; }
            set { _jiao = value; }
        }

        /// <summary>
        /// 分
        /// </summary>
        public string Fen
        {
            get { return _fen; }
            set { _fen = value; }
        }

        /// <summary>
        /// 支付金额
        /// </summary>
        public double Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }
    }
}
