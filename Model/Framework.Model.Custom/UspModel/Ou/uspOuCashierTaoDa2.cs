using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 收据套打类型二
    /// </summary>
    [Serializable]
    public class uspOuCashierTaoDa2 : BaseModel
    {
        private string _doctor;
        private DateTime _regTime;
        private string _nurse;
        private string _mzRegNo = String.Empty;
        private string _patientName = String.Empty;
        private string _payment = String.Empty;

        private double _xiYao;
        private double _zChengYao;
        private double _zCaoYao;
        private double _caiLiao;
        private double _zhuShe;
        private double _liLiao;
        private double _baYa;
        private double _xiangYa;

        private double _zhenCha;
        private double _jiZhen;
        private double _jianCha;
        private double _CT;
        private double _MRI;
        private double _BChaoXinDian;
        private double _XGuang;
        private double _jianYan;

        private double _zhiLiao;
        private double _maZui;
        private double _shuYang;
        private double _shuXue;
        private double _shouShu;
        private double _qiTa;
        private double _teXu;
        private double _xiYa;

        private double _zongJi;
        private string _wan = String.Empty;
        private string _qian = String.Empty;
        private string _bai = String.Empty;
        private string _shi = String.Empty;
        private string _yuan = String.Empty;
        private string _jiao = String.Empty;
        private string _fen = String.Empty;

        private double _zhongZhi;
        private double _buYa;
        private double _zhengJi;

        public uspOuCashierTaoDa2() { }
        /// <summary>
        /// 支付方式
        /// </summary>
        public string Payment
        {
            get { return _payment; }
            set { _payment = value; }
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
        /// 门诊号
        /// </summary>
        public string MzRegNo
        {
            get { return _mzRegNo; }
            set { _mzRegNo = value; }
        }
        /// <summary>
        /// 病人
        /// </summary>
        public string PatientName
        {
            get { return _patientName; }
            set { _patientName = value; }
        }
        /// <summary>
        /// 就诊时间
        /// </summary>
        public DateTime RegTime
        {
            get { return _regTime; }
            set { _regTime = value; }
        }
        /// <summary>
        /// 西药
        /// </summary>
        public double XiYao
        {
            get { return _xiYao; }
            set { _xiYao = value; }
        }
        /// <summary>
        /// 中成药
        /// </summary>
        public double ZChengYao
        {
            get { return _zChengYao; }
            set { _zChengYao = value; }
        }
        /// <summary>
        /// 中草药
        /// </summary>
        public double ZCaoYao
        {
            get { return _zCaoYao; }
            set { _zCaoYao = value; }
        }
        /// <summary>
        /// 材料费
        /// </summary>
        public double CaiLiao
        {
            get { return _caiLiao; }
            set { _caiLiao = value; }
        }
        /// <summary>
        /// 注射费
        /// </summary>
        public double ZhuShe
        {
            get { return _zhuShe; }
            set { _zhuShe = value; }
        }
        /// <summary>
        /// 理疗费
        /// </summary>
        public double LiLiao
        {
            get { return _liLiao; }
            set { _liLiao = value; }
        }
        /// <summary>
        /// 拔牙
        /// </summary>
        public double BaYa
        {
            get { return _baYa; }
            set { _baYa = value; }
        }
        /// <summary>
        /// 洗牙
        /// </summary>
        public double XiangYa
        {
            get { return _xiangYa; }
            set { _xiangYa = value; }
        }
        /// <summary>
        /// 诊查
        /// </summary>
        public double ZhenCha
        {
            get { return _zhenCha; }
            set { _zhenCha = value; }
        }
        /// <summary>
        /// 急诊留观床位费
        /// </summary>
        public double JiZhen
        {
            get { return _jiZhen; }
            set { _jiZhen = value; }
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
        /// B超、心电图
        /// </summary>
        public double BChaoXinDian
        {
            get { return _BChaoXinDian; }
            set { _BChaoXinDian = value; }
        }
        /// <summary>
        /// X光
        /// </summary>
        public double XGuang
        {
            get { return _XGuang; }
            set { _XGuang = value; }
        }
        /// <summary>
        /// 检验费
        /// </summary>
        public double JianYan
        {
            get { return _jianYan; }
            set { _jianYan = value; }
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
        /// 麻醉费
        /// </summary>
        public double MaZui
        {
            get { return _maZui; }
            set { _maZui = value; }
        }
        /// <summary>
        /// 输氧费
        /// </summary>
        public double ShuYang
        {
            get { return _shuYang; }
            set { _shuYang = value; }
        }
        /// <summary>
        /// 输血费
        /// </summary>
        public double ShuXue
        {
            get { return _shuXue; }
            set { _shuXue = value; }
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
        /// 其他
        /// </summary>
        public double QiTa
        {
            get { return _qiTa; }
            set { _qiTa = value; }
        }
        /// <summary>
        /// 特需服务费
        /// </summary>
        public double TeXu
        {
            get { return _teXu; }
            set { _teXu = value; }
        }
        /// <summary>
        /// 洗牙
        /// </summary>
        public double XiYa
        {
            get { return _xiYa; }
            set { _xiYa = value; }
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
        /// 大写万位的数据
        /// </summary>
        public string Wan
        {
            get { return _wan; }
            set { _wan = value; }
        }
        /// <summary>
        /// 大写仟位的数据
        /// </summary>
        public string Qian
        {
            get { return _qian; }
            set { _qian = value; }
        }
        /// <summary>
        /// 大写佰位的数据
        /// </summary>
        public string Bai
        {
            get { return _bai; }
            set { _bai = value; }
        }
        /// <summary>
        /// 大写拾位的数据
        /// </summary>
        public string Shi
        {
            get { return _shi; }
            set { _shi = value; }
        }
        /// <summary>
        /// 大写元位的数据
        /// </summary>
        public string Yuan
        {
            get { return _yuan; }
            set { _yuan = value; }
        }
        /// <summary>
        /// 大写角位的数据
        /// </summary>
        public string Jiao
        {
            get { return _jiao; }
            set { _jiao = value; }
        }
        /// <summary>
        /// 大写分位的数据
        /// </summary>
        public string Fen
        {
            get { return _fen; }
            set { _fen = value; }
        }
        /// <summary>
        /// 种植
        /// </summary>
        public double ZhongZhi
        {
            get { return _zhongZhi; }
            set { _zhongZhi = value; }
        }
        /// <summary>
        /// 补牙
        /// </summary>
        public double BuYa
        {
            get { return _buYa; }
            set { _buYa = value; }
        }
        /// <summary>
        /// 正畸
        /// </summary>
        public double ZhengJi
        {
            get { return _zhengJi; }
            set { _zhengJi = value; }
        }
    }
}
