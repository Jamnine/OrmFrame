using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 收据套打类型一
    /// </summary>
    [Serializable]
    public class uspOuCashierTaoDa1 : BaseModel
    {
        private string _payment = String.Empty;
        private string _invoceNo = String.Empty;
        private string _mzRegNo = String.Empty;
        private string _patientName = String.Empty;
        private DateTime _regTime;
        private double _xiYao;
        private double _zChengYao;
        private double _zCaoYao;
        private double _zhenCha;
        private double _zhiLiao;
        private double _jianCha;
        private double _CT;
        private double _MRI;
        private double _shouShu;
        private double _huaYan;
        private double _qiTa;
        private double _teXu;
        private double _ziFei;
        private double _zongJi;
        private string _qian = String.Empty;
        private string _bai = String.Empty;
        private string _shi = String.Empty;
        private string _yuan = String.Empty;
        private string _jiao = String.Empty;
        private string _fen = String.Empty;

        private string _doctor = String.Empty;
        private string _yiBao = String.Empty;
        private string _operMan = String.Empty;

        public uspOuCashierTaoDa1() { }

        /// <summary>
        ///支付方式 
        /// </summary>
        public string Payment
        {
            get { return _payment; }
            set { _payment = value; }
        }

        /// <summary>
        /// 收据号
        /// </summary>
        public string InvoceNo
        {
            get { return _invoceNo; }
            set { _invoceNo = value; }
        }
        /// <summary>
        /// 病人卡号
        /// </summary>
        public string MzRegNo
        {
            get { return _mzRegNo; }
            set { _mzRegNo = value; }
        }
        /// <summary>
        /// 病人姓名
        /// </summary>
        public string PatientName
        {
            get { return _patientName; }
            set { _patientName = value; }
        }
        /// <summary>
        /// 预约时间
        /// </summary>
        public DateTime RegTime
        {
            get { return _regTime; }
            set { _regTime = value; }
        }
        /// <summary>
        /// 西药费
        /// </summary>
        public double XiYao
        {
            get { return _xiYao; }
            set { _xiYao = value; }
        }


        /// <summary>
        /// 中成药费
        /// </summary>
        public double ZChengYao
        {
            get { return _zChengYao; }
            set { _zChengYao = value; }
        }

        /// <summary>
        /// 中草药费
        /// </summary>
        public double ZCaoYao
        {
            get { return _zCaoYao; }
            set { _zCaoYao = value; }
        }
        /// <summary>
        /// 诊察费
        /// </summary>
        public double ZhenCha
        {
            get { return _zhenCha; }
            set { _zhenCha = value; }
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
        /// 检查费
        /// </summary>
        public double JianCha
        {
            get { return _jianCha; }
            set { _jianCha = value; }
        }
        /// <summary>
        /// CT
        /// </summary>
        public double CT
        {
            get { return _CT; }
            set { _CT = value; }
        }
        /// <summary>
        /// MRI
        /// </summary>
        public double MRI
        {
            get { return _MRI; }
            set { _MRI = value; }
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
        /// 化验费
        /// </summary>
        public double HuaYan
        {
            get { return _huaYan; }
            set { _huaYan = value; }
        }
        /// <summary>
        /// 其他
        /// </summary>
        public double QiTa
        {
            get { return _qiTa; }
            set { _qiTa = value; }
        }
        /// <summary>
        /// 特需服务
        /// </summary>
        public double TeXu
        {
            get { return _teXu; }
            set { _teXu = value; }
        }
        /// <summary>
        /// 自费药品
        /// </summary>
        public double ZiFei
        {
            get { return _ziFei; }
            set { _ziFei = value; }
        }
        /// <summary>
        /// 总计
        /// </summary>
        public double ZongJi
        {
            get { return _zongJi; }
            set { _zongJi = value; }
        }

        /// <summary>
        /// 千（大写）
        /// </summary>
        public string Qian
        {
            get { return _qian; }
            set { _qian = value; }
        }
        /// <summary>
        /// 百（大写）
        /// </summary>
        public string Bai
        {
            get { return _bai; }
            set { _bai = value; }
        }
        /// <summary>
        /// 十（大写）
        /// </summary>
        public string Shi
        {
            get { return _shi; }
            set { _shi = value; }
        }
        /// <summary>
        /// 元（大写）
        /// </summary>
        public string Yuan
        {
            get { return _yuan; }
            set { _yuan = value; }
        }
        /// <summary>
        /// 角（大写）
        /// </summary>
        public string Jiao
        {
            get { return _jiao; }
            set { _jiao = value; }
        }
        /// <summary>
        /// 分（大写）
        /// </summary>
        public string Fen
        {
            get { return _fen; }
            set { _fen = value; }
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
        /// 医保
        /// </summary>
        public string YiBao
        {
            get { return _yiBao; }
            set { _yiBao = value; }
        }
        /// <summary>
        /// 操作员
        /// </summary>
        public string OperMan
        {
            get { return _operMan; }
            set { _operMan = value; }
        }
    }
}
