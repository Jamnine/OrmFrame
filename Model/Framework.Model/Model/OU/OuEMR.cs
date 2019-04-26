using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Model
{
    [Serializable]
    public class OuEMR : BaseModel
    {
        #region 构造函数
        /// <summary>
        /// 门诊病历 构造函数
        /// </summary>
        public OuEMR()
        {
        }
        #endregion

        #region 字段  AddressHome-户籍地址, AddressPresent-现在地址, AddressWork-工作地址, BirthDate-出生日期, BirthPlace-籍贯, Blood-血压, Breath-呼吸, CheckUpDes-体格检查描述, CheckUpOther-其他, Correct-修正诊断, CorrectDate-修正诊断日期, CorrectSign-修正诊断签名, CultureId-文化, DiagnoseRemark, DM-DM, Dose-剂量, Favoring-主要表现, GuarderAddress-监护人地址, GuarderName-监护人, GuarderPhone-监护人电话, HeartRate-心率, HomeRemarks-家庭史备注, HowRemark-备注, IdCardNo-身份证, IfGoodRemark-备注, IsAuthed-已经封存，不可改删, IsCAddress-地点, IsCTime-时间, IsDefy-违拗, IsDFSW-答非所问, IsFight-打架, IsForceAction-强迫性动作, IsHappy-快乐, IsImitate-模仿, IsIncrease-增多, IsKB-刻板, IsKBAction-刻板动作, IsMj-木僵, IsMySelf-自身, IsPerson-人物, IsReduce-减少, IsRepeat-重复, IsSilence-缄默, IsStrange-古怪, IsZs-赘述, IsZY-自语, LastRemark-备注, LsApperance-仪表, LsAttention-注意力, LsBeforeFactor-病前因素:1-有;2-无, LsBehaviour-行为, LsBreathSound-呼吸音:1-清晰;2-粗糙, LsEating-饮食:1-好;2-一般;3-差, LsEmotion-情感活动, LsFeeling-感知觉, LsForce-定向力, LsHeartRhythm-心律:1-整;3-不整, LsHomeHistory-家庭史：1-阳性；2-阴性, LsHowPregnant-分娩情况：1-顺产；2-难产；3-钳产；4-吸引产；5-剖腹产；6-先兆流产, LsHurt-伤人:1-有；2-无, LsHurtmyself-自伤:1-有；2-无, LsIdCardStatus-身份证状态: 1-未领; 2-遗失; 3-未带, LsIfBodyGood-孕期情况：1-健康；2-曾患疾病, LsIfGrade-留级, LsIfMonth-胎儿情况：1-足月；2-不足月, LsInsight-自知力, LsIntelligence-智力, LsLanuage-语言, LsLastHistory-既往史：1-阳性；2-阴性, LsLifeAbility-生活能力:1-好;2-一般;3-差, LsMarriage-婚姻状况：1-儿童；2-未婚；3-初婚；4-再婚；5-离异；6-丧偶；7-其他, LsMemory-记忆力, LsNervousSystem-神经系统:1-正常;2-异常, LsNoise-杂音:1-未问;2-可问, LsOnsetForm-起病形式:1-慢性;2-亚急性;3-慢性, LsPHobby-爱好, LsPRelation-人际关系, LsRale-罗音:1-干性;2-湿性3-其他, LsRealize-意识:1-清晰;2-障碍, LsRelationship-人际关系:1-如常;2-受损, LsSelfdestruction-自杀:1-有；2-无, LsSensitive-药物过敏:1-有;2-无, LsSerious-重大精神创伤, LsSHW-生毁物:1-有；2-无, LsSleeping-睡眠:1-好;2-一般;3-差, LsSpecailHobby-特殊爱好：1-有；2-无, LsSpecialHistory-特殊病史:1-有;2-无, LsStudyCondition-学习情况:1-如常;2-受损, LsStudyGrade-学习成绩, LsThinking-思维, LsTouching-触摸, LsWorkCondition-工作情况:1-如常;2-受损, MaxMedicine-最大剂量, Menstrual-月经史：男性不显示, MzRegId-门诊号, Name-姓名, Native-民族, NowMedicine-现在用药, OnceMedicine-曾用药物, OnsetDate-起病时间, OuDate-初诊日期, OuNo-门诊卡号, Phone-联系电话, PostCodeHome-户籍邮政编码, PostCodePresent-现住邮政编码, ProviderCultureId-提供者文化, ProviderName-病史提供者, ProviderRelationId-与病者关系, ProviderWorktypeId-提供者职业, Pulse-脉搏, Qty-第几胎, RelationId-关系, ReviewDate-审阅日期, ReviewSign-审阅签名, Saying-几岁会说话, Schooling-几岁上学, SenRemark, Sex-性别, SM-SM, SpecailRemark-备注, SpeRemark, SpiritCheckOther-其他, SpiritCheckUp-精神检查描述, Temperature-体温, Tentative-初步诊断, TentativeDocSign-初诊签名, TreatDate-治疗时间, TreatResult-治疗结果, Walking-几岁会走路, WhatWork-曾做工作, Working-几岁工作, WorktypeId-职业


        public virtual string GUID { get; set; }

        /// <summary>
        /// 户籍地址
        /// </summary>	

        public virtual string AddressHome { get; set; }

        /// <summary>
        /// 现在地址
        /// </summary>	

        public virtual string AddressPresent { get; set; }

        /// <summary>
        /// 工作地址
        /// </summary>	

        public virtual string AddressWork { get; set; }

        /// <summary>
        /// 出生日期 (已初始化值)
        /// </summary>	

        public virtual DateTime BirthDate { get; set; }

        /// <summary>
        /// 籍贯
        /// </summary>	

        public virtual string BirthPlace { get; set; }

        /// <summary>
        /// 血压
        /// </summary>	

        public virtual string Blood { get; set; }

        /// <summary>
        /// 呼吸
        /// </summary>	

        public virtual string Breath { get; set; }

        /// <summary>
        /// 体格检查描述
        /// </summary>	

        public virtual string CheckUpDes { get; set; }

        /// <summary>
        /// 其他
        /// </summary>	

        public virtual string CheckUpOther { get; set; }

        /// <summary>
        /// 修正诊断
        /// </summary>	

        public virtual string Correct { get; set; }

        /// <summary>
        /// 修正诊断日期
        /// </summary>	

        public virtual DateTime? CorrectDate { get; set; }

        /// <summary>
        /// 修正诊断签名
        /// </summary>	

        public virtual string CorrectSign { get; set; }

        /// <summary>
        /// 文化
        /// </summary>	

        public virtual string CultureId { get; set; }

        /// <summary>
        /// 
        /// </summary>	

        public virtual string DiagnoseRemark { get; set; }

        /// <summary>
        /// DM
        /// </summary>	

        public virtual string DM { get; set; }

        /// <summary>
        /// 剂量
        /// </summary>	

        public virtual string Dose { get; set; }

        /// <summary>
        /// 主要表现
        /// </summary>	

        public virtual string Favoring { get; set; }

        /// <summary>
        /// 监护人地址
        /// </summary>	

        public virtual string GuarderAddress { get; set; }

        /// <summary>
        /// 监护人
        /// </summary>	

        public virtual string GuarderName { get; set; }

        /// <summary>
        /// 监护人电话
        /// </summary>	

        public virtual string GuarderPhone { get; set; }

        /// <summary>
        /// 心率
        /// </summary>	

        public virtual string HeartRate { get; set; }

        /// <summary>
        /// 家庭史备注
        /// </summary>	

        public virtual string HomeRemarks { get; set; }

        /// <summary>
        /// 备注
        /// </summary>	

        public virtual string HowRemark { get; set; }

        /// <summary>
        /// 身份证
        /// </summary>	

        public virtual string IdCardNo { get; set; }

        /// <summary>
        /// 备注
        /// </summary>	

        public virtual string IfGoodRemark { get; set; }

        /// <summary>
        /// 已经封存，不可改删
        /// </summary>	

        public virtual Boolean IsAuthed { get; set; }

        /// <summary>
        /// 地点
        /// </summary>	

        public virtual Boolean? IsCAddress { get; set; }

        /// <summary>
        /// 时间
        /// </summary>	

        public virtual Boolean? IsCTime { get; set; }

        /// <summary>
        /// 违拗
        /// </summary>	

        public virtual Boolean? IsDefy { get; set; }

        /// <summary>
        /// 答非所问
        /// </summary>	

        public virtual Boolean? IsDFSW { get; set; }

        /// <summary>
        /// 打架
        /// </summary>	

        public virtual Boolean? IsFight { get; set; }

        /// <summary>
        /// 强迫性动作
        /// </summary>	

        public virtual Boolean? IsForceAction { get; set; }

        /// <summary>
        /// 快乐
        /// </summary>	

        public virtual Boolean? IsHappy { get; set; }

        /// <summary>
        /// 模仿
        /// </summary>	

        public virtual Boolean? IsImitate { get; set; }

        /// <summary>
        /// 增多
        /// </summary>	

        public virtual Boolean? IsIncrease { get; set; }

        /// <summary>
        /// 刻板
        /// </summary>	

        public virtual Boolean? IsKB { get; set; }

        /// <summary>
        /// 刻板动作
        /// </summary>	

        public virtual Boolean? IsKBAction { get; set; }

        /// <summary>
        /// 木僵
        /// </summary>	

        public virtual Boolean? IsMj { get; set; }

        /// <summary>
        /// 自身
        /// </summary>	

        public virtual Boolean? IsMySelf { get; set; }

        /// <summary>
        /// 人物
        /// </summary>	

        public virtual Boolean? IsPerson { get; set; }

        /// <summary>
        /// 减少
        /// </summary>	

        public virtual Boolean? IsReduce { get; set; }

        /// <summary>
        /// 重复
        /// </summary>	

        public virtual Boolean? IsRepeat { get; set; }

        /// <summary>
        /// 缄默
        /// </summary>	

        public virtual Boolean? IsSilence { get; set; }

        /// <summary>
        /// 古怪
        /// </summary>	

        public virtual Boolean? IsStrange { get; set; }

        /// <summary>
        /// 赘述
        /// </summary>	

        public virtual Boolean? IsZs { get; set; }

        /// <summary>
        /// 自语
        /// </summary>	

        public virtual Boolean? IsZY { get; set; }

        /// <summary>
        /// 备注
        /// </summary>	

        public virtual string LastRemark { get; set; }

        /// <summary>
        /// 仪表
        /// </summary>	

        public virtual Int16? LsApperance { get; set; }

        /// <summary>
        /// 注意力
        /// </summary>	

        public virtual Int16? LsAttention { get; set; }

        /// <summary>
        /// 病前因素:1-有;2-无
        /// </summary>	

        public virtual Int16? LsBeforeFactor { get; set; }

        /// <summary>
        /// 行为
        /// </summary>	

        public virtual Int16? LsBehaviour { get; set; }

        /// <summary>
        /// 呼吸音:1-清晰;2-粗糙
        /// </summary>	

        public virtual Int16? LsBreathSound { get; set; }

        /// <summary>
        /// 饮食:1-好;2-一般;3-差
        /// </summary>	

        public virtual Int16? LsEating { get; set; }

        /// <summary>
        /// 情感活动
        /// </summary>	

        public virtual Int16? LsEmotion { get; set; }

        /// <summary>
        /// 感知觉
        /// </summary>	

        public virtual Int16? LsFeeling { get; set; }

        /// <summary>
        /// 定向力
        /// </summary>	

        public virtual Int16? LsForce { get; set; }

        /// <summary>
        /// 心律:1-整;3-不整
        /// </summary>	

        public virtual Int16? LsHeartRhythm { get; set; }

        /// <summary>
        /// 家庭史：1-阳性；2-阴性
        /// </summary>	

        public virtual Int16? LsHomeHistory { get; set; }

        /// <summary>
        /// 分娩情况：1-顺产；2-难产；3-钳产；4-吸引产；5-剖腹产；6-先兆流产
        /// </summary>	

        public virtual Int16? LsHowPregnant { get; set; }

        /// <summary>
        /// 伤人:1-有；2-无
        /// </summary>	

        public virtual Int16? LsHurt { get; set; }

        /// <summary>
        /// 自伤:1-有；2-无
        /// </summary>	

        public virtual Int16? LsHurtmyself { get; set; }

        /// <summary>
        /// 身份证状态: 1-未领; 2-遗失; 3-未带
        /// </summary>	

        public virtual Int16? LsIdCardStatus { get; set; }

        /// <summary>
        /// 孕期情况：1-健康；2-曾患疾病
        /// </summary>	

        public virtual Int16? LsIfBodyGood { get; set; }

        /// <summary>
        /// 留级
        /// </summary>	

        public virtual Int16? LsIfGrade { get; set; }

        /// <summary>
        /// 胎儿情况：1-足月；2-不足月
        /// </summary>	

        public virtual Int16? LsIfMonth { get; set; }

        /// <summary>
        /// 自知力
        /// </summary>	

        public virtual Int16? LsInsight { get; set; }

        /// <summary>
        /// 智力
        /// </summary>	

        public virtual Int16? LsIntelligence { get; set; }

        /// <summary>
        /// 语言
        /// </summary>	

        public virtual Int16? LsLanuage { get; set; }

        /// <summary>
        /// 既往史：1-阳性；2-阴性
        /// </summary>	

        public virtual Int16? LsLastHistory { get; set; }

        /// <summary>
        /// 生活能力:1-好;2-一般;3-差
        /// </summary>	

        public virtual Int16? LsLifeAbility { get; set; }

        /// <summary>
        /// 婚姻状况：1-儿童；2-未婚；3-初婚；4-再婚；5-离异；6-丧偶；7-其他
        /// </summary>	

        public virtual Int16? LsMarriage { get; set; }

        /// <summary>
        /// 记忆力
        /// </summary>	

        public virtual Int16? LsMemory { get; set; }

        /// <summary>
        /// 神经系统:1-正常;2-异常
        /// </summary>	

        public virtual Int16? LsNervousSystem { get; set; }

        /// <summary>
        /// 杂音:1-未问;2-可问
        /// </summary>	

        public virtual Int16? LsNoise { get; set; }

        /// <summary>
        /// 起病形式:1-慢性;2-亚急性;3-慢性
        /// </summary>	

        public virtual Int16? LsOnsetForm { get; set; }

        /// <summary>
        /// 爱好
        /// </summary>	

        public virtual Int16? LsPHobby { get; set; }

        /// <summary>
        /// 人际关系
        /// </summary>	

        public virtual Int16? LsPRelation { get; set; }

        /// <summary>
        /// 罗音:1-干性;2-湿性3-其他
        /// </summary>	

        public virtual Int16? LsRale { get; set; }

        /// <summary>
        /// 意识:1-清晰;2-障碍
        /// </summary>	

        public virtual Int16? LsRealize { get; set; }

        /// <summary>
        /// 人际关系:1-如常;2-受损
        /// </summary>	

        public virtual Int16? LsRelationship { get; set; }

        /// <summary>
        /// 自杀:1-有；2-无
        /// </summary>	

        public virtual Int16? LsSelfdestruction { get; set; }

        /// <summary>
        /// 药物过敏:1-有;2-无
        /// </summary>	

        public virtual Int16? LsSensitive { get; set; }

        /// <summary>
        /// 重大精神创伤
        /// </summary>	

        public virtual Int16? LsSerious { get; set; }

        /// <summary>
        /// 生毁物:1-有；2-无
        /// </summary>	

        public virtual Int16? LsSHW { get; set; }

        /// <summary>
        /// 睡眠:1-好;2-一般;3-差
        /// </summary>	

        public virtual Int16? LsSleeping { get; set; }

        /// <summary>
        /// 特殊爱好：1-有；2-无
        /// </summary>	

        public virtual Int16? LsSpecailHobby { get; set; }

        /// <summary>
        /// 特殊病史:1-有;2-无
        /// </summary>	

        public virtual Int16? LsSpecialHistory { get; set; }

        /// <summary>
        /// 学习情况:1-如常;2-受损
        /// </summary>	

        public virtual Int16? LsStudyCondition { get; set; }

        /// <summary>
        /// 学习成绩
        /// </summary>	

        public virtual Int16? LsStudyGrade { get; set; }

        /// <summary>
        /// 思维
        /// </summary>	

        public virtual Int16? LsThinking { get; set; }

        /// <summary>
        /// 触摸
        /// </summary>	

        public virtual Int16? LsTouching { get; set; }

        /// <summary>
        /// 工作情况:1-如常;2-受损
        /// </summary>	

        public virtual Int16? LsWorkCondition { get; set; }

        /// <summary>
        /// 最大剂量
        /// </summary>	

        public virtual string MaxMedicine { get; set; }

        /// <summary>
        /// 月经史：男性不显示
        /// </summary>	

        public virtual string Menstrual { get; set; }

        /// <summary>
        /// 门诊号
        /// </summary>	

        public virtual string MzRegId { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>	

        public virtual string Name { get; set; }

        /// <summary>
        /// 民族
        /// </summary>	

        public virtual string Native { get; set; }

        /// <summary>
        /// 现在用药
        /// </summary>	

        public virtual string NowMedicine { get; set; }

        /// <summary>
        /// 曾用药物
        /// </summary>	

        public virtual string OnceMedicine { get; set; }

        /// <summary>
        /// 起病时间
        /// </summary>	

        public virtual DateTime? OnsetDate { get; set; }

        /// <summary>
        /// 初诊日期 (已初始化值)
        /// </summary>	

        public virtual DateTime OuDate { get; set; }

        /// <summary>
        /// 门诊卡号
        /// </summary>	

        public virtual string OuNo { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>	

        public virtual string Phone { get; set; }

        /// <summary>
        /// 户籍邮政编码
        /// </summary>	

        public virtual string PostCodeHome { get; set; }

        /// <summary>
        /// 现住邮政编码
        /// </summary>	

        public virtual string PostCodePresent { get; set; }

        /// <summary>
        /// 提供者文化
        /// </summary>	

        public virtual string ProviderCultureId { get; set; }

        /// <summary>
        /// 病史提供者
        /// </summary>	

        public virtual string ProviderName { get; set; }

        /// <summary>
        /// 与病者关系
        /// </summary>	

        public virtual string ProviderRelationId { get; set; }

        /// <summary>
        /// 提供者职业
        /// </summary>	

        public virtual string ProviderWorktypeId { get; set; }

        /// <summary>
        /// 脉搏
        /// </summary>	

        public virtual string Pulse { get; set; }

        /// <summary>
        /// 第几胎
        /// </summary>	

        public virtual string Qty { get; set; }

        /// <summary>
        /// 关系
        /// </summary>	

        public virtual string RelationId { get; set; }

        /// <summary>
        /// 审阅日期
        /// </summary>	

        public virtual DateTime? ReviewDate { get; set; }

        /// <summary>
        /// 审阅签名
        /// </summary>	

        public virtual string ReviewSign { get; set; }

        /// <summary>
        /// 几岁会说话
        /// </summary>	

        public virtual string Saying { get; set; }

        /// <summary>
        /// 几岁上学
        /// </summary>	

        public virtual string Schooling { get; set; }

        /// <summary>
        /// 
        /// </summary>	

        public virtual string SenRemark { get; set; }

        /// <summary>
        /// 性别
        /// </summary>	

        public virtual string Sex { get; set; }

        /// <summary>
        /// SM
        /// </summary>	

        public virtual string SM { get; set; }

        /// <summary>
        /// 备注
        /// </summary>	

        public virtual string SpecailRemark { get; set; }

        /// <summary>
        /// 
        /// </summary>	

        public virtual string SpeRemark { get; set; }

        /// <summary>
        /// 其他
        /// </summary>	

        public virtual string SpiritCheckOther { get; set; }

        /// <summary>
        /// 精神检查描述
        /// </summary>	

        public virtual string SpiritCheckUp { get; set; }

        /// <summary>
        /// 体温
        /// </summary>	

        public virtual string Temperature { get; set; }

        /// <summary>
        /// 初步诊断
        /// </summary>	

        public virtual string Tentative { get; set; }

        /// <summary>
        /// 初诊签名
        /// </summary>	

        public virtual string TentativeDocSign { get; set; }

        /// <summary>
        /// 治疗时间
        /// </summary>	

        public virtual DateTime? TreatDate { get; set; }

        /// <summary>
        /// 治疗结果
        /// </summary>	

        public virtual string TreatResult { get; set; }

        /// <summary>
        /// 几岁会走路
        /// </summary>	

        public virtual string Walking { get; set; }

        /// <summary>
        /// 曾做工作
        /// </summary>	

        public virtual string WhatWork { get; set; }

        /// <summary>
        /// 几岁工作
        /// </summary>	

        public virtual string Working { get; set; }

        /// <summary>
        /// 职业
        /// </summary>	

        public virtual string WorktypeId { get; set; }

        #endregion
    }
}
