using System;

namespace Orm.Model
{
    /// <summary>
    /// 辅助检查  数据库不存在此表
    /// </summary>
    [Serializable]
    public class OuAuxiliaryCheck : BaseModel
    {
        private string patId;
        private string locationId;
        private string mzRegId;
        private string operid;
        private DateTime operLastDate;
        private int lips;
        private int dentition;
        private int pharynx;
        private bool hearing;
        private bool isMotionGood;
        private string visionLeft;
        private string visionReght;
        private string bridgeVisionLeft;
        private string bridgeVisionReght;
        private bool eyeCrazy;
        private int skin;
        private int gongMo;
        private int linBaJie;
        private bool isTongZhuangXiong;
        private bool isHuXiYin;
        private int luoYin;
        private int heartRrate;
        private int rhythm;
        private bool isZaYin;
        private bool isDuTong;
        private bool isBaoChang;
        private bool isGanDa;
        private bool isPiDa;
        private bool isZhuoYin;
        private int lowerShuiZhong;
        private int dongMai;
        private int gangMeng;
        private int ruXian;
        private bool isWaiYinError;
        private bool isYinDaoError;
        private bool isGonJinError;
        private bool isGonTiError;
        private bool isFuTiError;
        private string chaTiQiTa;
        private int xueHongDanBai;
        private int baiXiBao;
        private int xueXiaoBan;
        private string xCGQiTa;
        private int nWLBaiDanBai;
        private int kongFuXueTan1;
        private int kongFuXueTan2;
        private int daBianQianXue;
        private int tHXueHongDanBai;
        private int xinDianTu;
        private string niaoDanBai;
        private string niaoTang;
        private string niaoTongTi;
        private string niaoQianXue;
        private string nCGQiTa;
        private int aLT;
        private int aST;
        private int aLB;
        private int tBIL;
        private int dBIL;
        private int hBV;
        private int cR;
        private int xueQingJia;
        private int xueQingNa;
        private int bUN;
        private int tCHO;
        private int tRIG;
        private int lDL;
        private int hDLC;
        private bool isChestXRayFilm;
        private bool isBChao;
        private bool isPapSmear;
        private string checkQiTa;


        /// <summary>
        /// 病人ID
        /// </summary>
        public string PatId
        {
            get
            {
                return patId;
            }

            set
            {
                patId = value;
            }
        }

        /// <summary>
        /// 门诊ID
        /// </summary>
        public string MzRegId
        {
            get
            {
                return mzRegId;
            }

            set
            {
                mzRegId = value;
            }
        }

        /// <summary>
        /// 操作人ID
        /// </summary>
        public string Operid
        {
            get
            {
                return operid;
            }

            set
            {
                operid = value;
            }
        }

        /// <summary>
        /// 最后操作时间
        /// </summary>
        public DateTime OperLastDate
        {
            get
            {
                return operLastDate;
            }

            set
            {
                operLastDate = value;
            }
        }

        /// <summary>
        /// 口唇
        /// </summary>
        public int Lips
        {
            get
            {
                return lips;
            }

            set
            {
                lips = value;
            }
        }

        /// <summary>
        /// 齿列
        /// </summary>
        public int Dentition
        {
            get
            {
                return dentition;
            }

            set
            {
                dentition = value;
            }
        }

        /// <summary>
        /// 咽部
        /// </summary>
        public int Pharynx
        {
            get
            {
                return pharynx;
            }

            set
            {
                pharynx = value;
            }
        }

        /// <summary>
        /// 听力
        /// </summary>
        public bool Hearing
        {
            get
            {
                return hearing;
            }

            set
            {
                hearing = value;
            }
        }

        /// <summary>
        /// 左视力
        /// </summary>
        public string VisionLeft
        {
            get
            {
                return visionLeft;
            }

            set
            {
                visionLeft = value;
            }
        }

        /// <summary>
        /// 右视力
        /// </summary>
        public string VisionReght
        {
            get
            {
                return visionReght;
            }

            set
            {
                visionReght = value;
            }
        }

        /// <summary>
        /// 桥正左视力
        /// </summary>
        public string BridgeVisionLeft
        {
            get
            {
                return bridgeVisionLeft;
            }

            set
            {
                bridgeVisionLeft = value;
            }
        }

        /// <summary>
        /// 桥正右视力
        /// </summary>
        public string BridgeVisionReght
        {
            get
            {
                return bridgeVisionReght;
            }

            set
            {
                bridgeVisionReght = value;
            }
        }

        /// <summary>
        /// 眼底
        /// </summary>
        public bool EyeCrazy
        {
            get
            {
                return eyeCrazy;
            }

            set
            {
                eyeCrazy = value;
            }
        }

        /// <summary>
        /// 皮肤
        /// </summary>
        public int Skin
        {
            get
            {
                return skin;
            }

            set
            {
                skin = value;
            }
        }

        /// <summary>
        /// 巩膜
        /// </summary>
        public int GongMo
        {
            get
            {
                return gongMo;
            }

            set
            {
                gongMo = value;
            }
        }

        /// <summary>
        /// 淋巴结
        /// </summary>
        public int LinBaJie
        {
            get
            {
                return linBaJie;
            }

            set
            {
                linBaJie = value;
            }
        }

        /// <summary>
        /// 桶状胸
        /// </summary>
        public bool IsTongZhuangXiong
        {
            get
            {
                return isTongZhuangXiong;
            }
            set
            {
                isTongZhuangXiong = value;
            }
        }

        /// <summary>
        /// 呼吸音
        /// </summary>
        public bool IsHuXiYin
        {
            get
            {
                return isHuXiYin;
            }
            set
            {
                isHuXiYin = value;
            }
        }

        /// <summary>
        /// 啰音
        /// </summary>
        public int LuoYin
        {
            get
            {
                return luoYin;
            }

            set
            {
                luoYin = value;
            }
        }

        /// <summary>
        /// 心率
        /// </summary>
        public int HeartRrate
        {
            get
            {
                return heartRrate;
            }

            set
            {
                heartRrate = value;
            }
        }

        /// <summary>
        /// 心律
        /// </summary>
        public int Rhythm
        {
            get
            {
                return rhythm;
            }

            set
            {
                rhythm = value;
            }
        }

        /// <summary>
        /// 水肿
        /// </summary>
        public int LowerShuiZhong
        {
            get
            {
                return lowerShuiZhong;
            }

            set
            {
                lowerShuiZhong = value;
            }
        }

        /// <summary>
        /// 足背动脉搏动
        /// </summary>
        public int DongMai
        {
            get
            {
                return dongMai;
            }

            set
            {
                dongMai = value;
            }
        }

        /// <summary>
        /// 肛门
        /// </summary>
        public int GangMeng
        {
            get
            {
                return gangMeng;
            }

            set
            {
                gangMeng = value;
            }
        }

        /// <summary>
        /// 乳腺
        /// </summary>
        public int RuXian
        {
            get
            {
                return ruXian;
            }

            set
            {
                ruXian = value;
            }
        }

        /// <summary>
        /// 查体其他
        /// </summary>
        public string ChaTiQiTa
        {
            get
            {
                return chaTiQiTa;
            }

            set
            {
                chaTiQiTa = value;
            }
        }

        /// <summary>
        /// 血红蛋白
        /// </summary>
        public int XueHongDanBai
        {
            get
            {
                return xueHongDanBai;
            }

            set
            {
                xueHongDanBai = value;
            }
        }

        /// <summary>
        /// /白细胞
        /// </summary>
        public int BaiXiBao
        {
            get
            {
                return baiXiBao;
            }
            set
            {
                baiXiBao = value;
            }
        }

        /// <summary>
        /// 血小板
        /// </summary>
        public int XueXiaoBan
        {
            get
            {
                return xueXiaoBan;
            }

            set
            {
                xueXiaoBan = value;
            }
        }

        /// <summary>
        /// 血常规其他
        /// </summary>
        public string XCGQiTa
        {
            get
            {
                return xCGQiTa;
            }

            set
            {
                xCGQiTa = value;
            }
        }

        /// <summary>
        /// 尿微量白蛋白
        /// </summary>
        public int NWLBaiDanBai
        {
            get
            {
                return nWLBaiDanBai;
            }

            set
            {
                nWLBaiDanBai = value;
            }
        }

        /// <summary>
        /// 空腹血糖
        /// </summary>
        public int KongFuXueTan1
        {
            get
            {
                return kongFuXueTan1;
            }

            set
            {
                kongFuXueTan1 = value;
            }
        }

        /// <summary>
        /// 空腹血糖
        /// </summary>
        public int KongFuXueTan2
        {
            get
            {
                return kongFuXueTan2;
            }

            set
            {
                kongFuXueTan2 = value;
            }
        }

        /// <summary>
        /// 大便潜血
        /// </summary>
        public int DaBianQianXue
        {
            get
            {
                return daBianQianXue;
            }

            set
            {
                daBianQianXue = value;
            }
        }

        /// <summary>
        /// 糖化血红蛋白
        /// </summary>
        public int THXueHongDanBai
        {
            get
            {
                return tHXueHongDanBai;
            }

            set
            {
                tHXueHongDanBai = value;
            }
        }

        /// <summary>
        /// 心电图
        /// </summary>
        public int XinDianTu
        {
            get
            {
                return xinDianTu;
            }

            set
            {
                xinDianTu = value;
            }
        }

        /// <summary>
        /// 尿蛋白
        /// </summary>
        public string NiaoDanBai
        {
            get
            {
                return niaoDanBai;
            }

            set
            {
                niaoDanBai = value;
            }
        }

        /// <summary>
        /// 尿糖
        /// </summary>
        public string NiaoTang
        {
            get
            {
                return niaoTang;
            }

            set
            {
                niaoTang = value;
            }
        }

        /// <summary>
        /// 尿潜血
        /// </summary>
        public string NiaoQianXue
        {
            get
            {
                return niaoQianXue;
            }

            set
            {
                niaoQianXue = value;
            }
        }

        /// <summary>
        /// 尿常规其他
        /// </summary>
        public string NCGQiTa
        {
            get
            {
                return nCGQiTa;
            }

            set
            {
                nCGQiTa = value;
            }
        }

        /// <summary>
        /// 丙氨酸氨基转移酶
        /// </summary>
        public int ALT
        {
            get
            {
                return aLT;
            }

            set
            {
                aLT = value;
            }
        }

        /// <summary>
        /// 血清门冬氨酸氨基转移酶
        /// </summary>
        public int AST
        {
            get
            {
                return aST;
            }

            set
            {
                aST = value;
            }
        }

        /// <summary>
        /// 白蛋白
        /// </summary>
        public int ALB
        {
            get
            {
                return aLB;
            }

            set
            {
                aLB = value;
            }
        }

        /// <summary>
        /// 总胆红素
        /// </summary>
        public int TBIL
        {
            get
            {
                return tBIL;
            }

            set
            {
                tBIL = value;
            }
        }

        /// <summary>
        /// 结合胆红素
        /// </summary>
        public int DBIL
        {
            get
            {
                return dBIL;
            }

            set
            {
                dBIL = value;
            }
        }

        /// <summary>
        /// 乙型肝炎
        /// </summary>
        public int HBV
        {
            get
            {
                return hBV;
            }

            set
            {
                hBV = value;
            }
        }

        /// <summary>
        /// /血清肌酐
        /// </summary>
        public int CR
        {
            get
            {
                return cR;
            }
            set
            {
                cR = value;
            }
        }

        /// <summary>
        /// 血钾浓度
        /// </summary>
        public int XueQingJia
        {
            get
            {
                return xueQingJia;
            }

            set
            {
                xueQingJia = value;
            }
        }

        /// <summary>
        /// 血钠浓度
        /// </summary>
        public int XueQingNa
        {
            get
            {
                return xueQingNa;
            }

            set
            {
                xueQingNa = value;
            }
        }

        /// <summary>
        /// 血尿素氮
        /// </summary>
        public int BUN
        {
            get
            {
                return bUN;
            }

            set
            {
                bUN = value;
            }
        }

        /// <summary>
        /// 总胆固醇
        /// </summary>
        public int TCHO
        {
            get
            {
                return tCHO;
            }

            set
            {
                tCHO = value;
            }
        }

        /// <summary>
        /// 甘油三酯
        /// </summary>
        public int TRIG
        {
            get
            {
                return tRIG;
            }

            set
            {
                tRIG = value;
            }
        }

        /// <summary>
        /// 血清低密度脂蛋白胆固醇
        /// </summary>
        public int LDL
        {
            get
            {
                return lDL;
            }

            set
            {
                lDL = value;
            }
        }

        /// <summary>
        /// 血清高密度脂蛋白胆固醇
        /// </summary>
        public int HDLC
        {
            get
            {
                return hDLC;
            }

            set
            {
                hDLC = value;
            }
        }

        /// <summary>
        /// 其他
        /// </summary>
        public string CheckQiTa
        {
            get
            {
                return checkQiTa;
            }

            set
            {
                checkQiTa = value;
            }
        }

        /// <summary>
        /// 外阴异常
        /// </summary>
        public bool IsWaiYinError
        {
            get
            {
                return isWaiYinError;
            }

            set
            {
                isWaiYinError = value;
            }
        }

        /// <summary>
        /// 阴道异常
        /// </summary>
        public bool IsYinDaoError
        {
            get
            {
                return isYinDaoError;
            }

            set
            {
                isYinDaoError = value;
            }
        }

        /// <summary>
        /// 宫颈异常
        /// </summary>
        public bool IsGonJinError
        {
            get
            {
                return isGonJinError;
            }

            set
            {
                isGonJinError = value;
            }
        }

        /// <summary>
        /// 宫体异常
        /// </summary>
        public bool IsGonTiError
        {
            get
            {
                return isGonTiError;
            }

            set
            {
                isGonTiError = value;
            }
        }

        /// <summary>
        /// 附体异常
        /// </summary>
        public bool IsFuTiError
        {
            get
            {
                return isFuTiError;
            }

            set
            {
                isFuTiError = value;
            }
        }

        /// <summary>
        /// 胸部X线片
        /// </summary>
        public bool IsChestXRayFilm
        {
            get
            {
                return isChestXRayFilm;
            }

            set
            {
                isChestXRayFilm = value;
            }
        }

        /// <summary>
        /// B超
        /// </summary>
        public bool IsBChao
        {
            get
            {
                return isBChao;
            }

            set
            {
                isBChao = value;
            }
        }

        /// <summary>
        /// 宫颈涂片
        /// </summary>
        public bool IsPapSmear
        {
            get
            {
                return isPapSmear;
            }

            set
            {
                isPapSmear = value;
            }
        }

        /// <summary>
        /// 杂音
        /// </summary>
        public bool IsZaYin
        {
            get
            {
                return isZaYin;
            }

            set
            {
                isZaYin = value;
            }
        }

        /// <summary>
        /// 压痛
        /// </summary>
        public bool IsDuTong
        {
            get
            {
                return isDuTong;
            }

            set
            {
                isDuTong = value;
            }
        }

        /// <summary>
        /// 包场
        /// </summary>
        public bool IsBaoChang
        {
            get
            {
                return isBaoChang;
            }

            set
            {
                isBaoChang = value;
            }
        }

        /// <summary>
        /// 肝大
        /// </summary>
        public bool IsGanDa
        {
            get
            {
                return isGanDa;
            }

            set
            {
                isGanDa = value;
            }
        }

        /// <summary>
        /// 脾大
        /// </summary>
        public bool IsPiDa
        {
            get
            {
                return isPiDa;
            }

            set
            {
                isPiDa = value;
            }
        }

        /// <summary>
        /// 浊音
        /// </summary>
        public bool IsZhuoYin
        {
            get
            {
                return isZhuoYin;
            }

            set
            {
                isZhuoYin = value;
            }
        }

        /// <summary>
        /// 运动功能能够独自完成
        /// </summary>
        public bool IsMotionGood
        {
            get
            {
                return isMotionGood;
            }

            set
            {
                isMotionGood = value;
            }
        }

        /// <summary>
        /// 尿酮体
        /// </summary>
        public string NiaoTongTi
        {
            get
            {
                return niaoTongTi;
            }

            set
            {
                niaoTongTi = value;
            }
        }
    }
}
