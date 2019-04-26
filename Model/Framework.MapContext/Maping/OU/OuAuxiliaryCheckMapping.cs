using ELinq.Mapping.Fluent;
using Orm.Model;

namespace Orm.MapContext
{
    /// <summary>
    /// 辅助检查
    /// </summary>
    public class OuAuxiliaryCheckMapping :ClassMap<OuAuxiliaryCheck>
    {
        public OuAuxiliaryCheckMapping()
        {
            this.TableName("OuAuxiliaryCheck").Schema("orm");

            this.Column(p => p.PatId).ColumnName("PatId");
            this.Column(p => p.HospitalId).ColumnName("HospitalId");
            this.Column(p => p.MzRegId).ColumnName("MzRegId");
            this.Column(p => p.Operid).ColumnName("Operid");
            this.Column(p => p.OperLastDate).ColumnName("OperLastDate");
            this.Column(p => p.Lips).ColumnName("Lips");//口唇
            this.Column(p => p.Dentition).ColumnName("Dentition");//齿列
            this.Column(p => p.Pharynx).ColumnName("Pharynx");//咽部
            this.Column(p => p.Hearing).ColumnName("Hearing");//听力
            this.Column(p => p.IsMotionGood).ColumnName("IsMotionGood");//运动功能能够独自完成
            this.Column(p => p.VisionLeft).ColumnName("VisionLeft");//左视力
            this.Column(p => p.VisionReght).ColumnName("VisionReght");//右视力
            this.Column(p => p.BridgeVisionLeft).ColumnName("BridgeVisionLeft");//桥正左视力
            this.Column(p => p.BridgeVisionReght).ColumnName("BridgeVisionReght");//桥正右视力
            this.Column(p => p.EyeCrazy).ColumnName("EyeCrazy");//眼底
            this.Column(p => p.Skin).ColumnName("Skin");//皮肤
            this.Column(p => p.GongMo).ColumnName("GongMo");//巩膜
            this.Column(p => p.LinBaJie).ColumnName("LinBaJie");//淋巴结
            this.Column(p => p.IsTongZhuangXiong).ColumnName("IsTongZhuangXiong");//桶状胸
            this.Column(p => p.IsHuXiYin).ColumnName("IsHuXiYin");//呼吸音
            this.Column(p => p.LuoYin).ColumnName("LuoYin");//啰音
            this.Column(p => p.HeartRrate).ColumnName("HeartRrate");//心率
            this.Column(p => p.Rhythm).ColumnName("Rhythm");//心律
            this.Column(p => p.IsZaYin).ColumnName("IsZaYin");//杂音
            this.Column(p => p.IsDuTong).ColumnName("IsDuTong");//压痛
            this.Column(p => p.IsBaoChang).ColumnName("IsBaoChang");//包场
            this.Column(p => p.IsGanDa).ColumnName("IsGanDa");//肝大
            this.Column(p => p.IsPiDa).ColumnName("IsPiDa");//脾大
            this.Column(p => p.IsZhuoYin).ColumnName("IsZhuoYin");//浊音
            this.Column(p => p.LowerShuiZhong).ColumnName("LowerShuiZhong");//水肿
            this.Column(p => p.DongMai).ColumnName("DongMai");//足背动脉搏动
            this.Column(p => p.GangMeng).ColumnName("GangMeng");//肛门
            this.Column(p => p.RuXian).ColumnName("RuXian");//乳腺
            this.Column(p => p.IsWaiYinError).ColumnName("IsWaiYinError");//外阴异常
            this.Column(p => p.IsYinDaoError).ColumnName("IsYinDaoError");//阴道异常
            this.Column(p => p.IsGonJinError).ColumnName("IsGonJinError");//宫颈异常
            this.Column(p => p.IsGonTiError).ColumnName("IsGonTiError");//宫体异常
            this.Column(p => p.IsFuTiError).ColumnName("IsFuTiError");//附体异常
            this.Column(p => p.ChaTiQiTa).ColumnName("ChaTiQiTa");//查体其他
            this.Column(p => p.XueHongDanBai).ColumnName("XueHongDanBai");//血红蛋白
            this.Column(p => p.BaiXiBao).ColumnName("BaiXiBao");//白细胞
            this.Column(p => p.XueXiaoBan).ColumnName("XueXiaoBan");//血小板
            this.Column(p => p.XCGQiTa).ColumnName("XCGQiTa");//血常规其他
            this.Column(p => p.NWLBaiDanBai).ColumnName("NWLBaiDanBai");//尿微量白蛋白
            this.Column(p => p.KongFuXueTan1).ColumnName("KongFuXueTan1");//空腹血糖
            this.Column(p => p.KongFuXueTan2).ColumnName("KongFuXueTan2");//空腹血糖
            this.Column(p => p.DaBianQianXue).ColumnName("DaBianQianXue");//大便潜血
            this.Column(p => p.THXueHongDanBai).ColumnName("THXueHongDanBai");//糖化血红蛋白
            this.Column(p => p.XinDianTu).ColumnName("XinDianTu");//心电图
            this.Column(p => p.NiaoDanBai).ColumnName("NiaoDanBai");//尿蛋白
            this.Column(p => p.NiaoTang).ColumnName("NiaoTang");//尿糖
            this.Column(p => p.NiaoTongTi).ColumnName("NiaoTongTi");//尿酮体
            this.Column(p => p.NiaoQianXue).ColumnName("NiaoQianXue");//尿潜血
            this.Column(p => p.NCGQiTa).ColumnName("NCGQiTa");//尿常规其他
            this.Column(p => p.ALT).ColumnName("ALT");//丙氨酸氨基转移酶
            this.Column(p => p.AST).ColumnName("AST");//血清门冬氨酸氨基转移酶
            this.Column(p => p.ALB).ColumnName("ALB");//白蛋白
            this.Column(p => p.TBIL).ColumnName("TBIL");//总胆红素
            this.Column(p => p.DBIL).ColumnName("DBIL");//结合胆红素
            this.Column(p => p.HBV).ColumnName("HBV");//乙型肝炎
            this.Column(p => p.CR).ColumnName("CR");//血清肌酐
            this.Column(p => p.XueQingJia).ColumnName("XueQingJia");//血钾浓度
            this.Column(p => p.XueQingNa).ColumnName("XueQingNa");//血钠浓度
            this.Column(p => p.BUN).ColumnName("BUN");//血尿素氮
            this.Column(p => p.TCHO).ColumnName("TCHO");//总胆固醇
            this.Column(p => p.TRIG).ColumnName("TRIG");//甘油三酯
            this.Column(p => p.LDL).ColumnName("LDL");//血清低密度脂蛋白胆固醇
            this.Column(p => p.HDLC).ColumnName("HDLC");//血清高密度脂蛋白胆固醇
            this.Column(p => p.IsChestXRayFilm).ColumnName("IsChestXRayFilm");//胸部X线片
            this.Column(p => p.IsBChao).ColumnName("IsBChao");//B超
            this.Column(p => p.IsPapSmear).ColumnName("IsPapSmear");//宫颈涂片
            this.Column(p => p.CheckQiTa).ColumnName("CheckQiTa");//其他

             
            
            
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
        }
    }
}
