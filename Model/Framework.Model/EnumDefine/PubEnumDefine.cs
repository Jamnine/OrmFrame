using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Reflection;
using System.Runtime.Serialization;

namespace Orm.Model.EnumDefine
{
    /// <summary>
    /// 基础控制配置
    /// </summary>
    [Serializable]
    public class BaseControlConfig
    {
      
        #region 属性
        private string _key;
        /// <summary>
        /// 键
        /// </summary>
        public string Key
        {
            get { return _key; }
            set { _key = value; }
        }

        private string _field;
        /// <summary>
        /// 文件id
        /// </summary>
        public string Field
        {
            get { return _field; }
            set { _field = value; }
        }

        private string _storedProcedure;
        /// <summary>
        /// 存储过程
        /// </summary>
        public string StoredProcedure
        {
            get { return _storedProcedure; }
            set { _storedProcedure = value; }
        }

        private string _orderByExpression;
        /// <summary>
        ///表达顺序
        /// </summary>
        public string OrderByExpression
        {
            get { return _orderByExpression; }
            set { _orderByExpression = value; }
        }

        private string _whereCondition;
        /// <summary>
        /// Where条件
        /// </summary>
        public string WhereCondition
        {
            get { return _whereCondition; }
            set { _whereCondition = value; }
        }

        private string _id;
        /// <summary>
        /// GUID
        /// </summary>
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _name;
        /// <summary>
        /// 名称
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        Dictionary<string, object> pramarter;
        /// <summary>
        /// 变量
        /// </summary>
        public Dictionary<string, object> Pramarter
        {
            get
            {
                if (pramarter == null)
                {
                    pramarter = new Dictionary<string, object>();
                    pramarter.Add(":o", this._orderByExpression);
                }
                return pramarter;
            }
        }

        /// <summary>
        /// 是不是枚举
        /// </summary>
        public bool IsEnum
        {
            get
            {
                if (this._storedProcedure.StartsWith("Enum"))
                    return true;
                else
                    return false;
            }
        }

        /// <summary>
        /// 执行sql语句的模板
        /// </summary>
        public string SQLFormat
        {
            get
            {
                if (this._whereCondition.ToLower().Contains("drop")
                    || this._whereCondition.ToLower().Contains("delete"))
                    throw new FormatException(string.Format("配置项{0}配置了非法项", this._key));
                string format = @"select :field from :tbName where :where ";
                string orderby = @" order by :o";
                if (!string.IsNullOrEmpty(this._orderByExpression))
                    format = format + orderby;
                format = format.Replace(":tbName", this._storedProcedure);
                format = format.Replace(":field", this._field);
                format = format.Replace(":where", this._whereCondition);
                return format;
            }
        }
    }
    #endregion

    #region 枚举

    /// <summary>
    /// 医嘱网格的风格定义
    /// </summary>
    public enum EnumAdviceGridCustomStyle
    {
        [Description("未保存的")]
        Default = 0,

        [Description("今天的医嘱")]
        TodayAdvic = 1,

        [Description("取消的医嘱")]
        CancelAdvice = 2,

        [Description("已收费的医嘱；医生工作站：护士已经审核")]
        HasPayedAvice = 4,

        [Description("附加项目；医生工作站：记事医嘱")]
        OtherFeeAdvice = 8,

        [Description("已申请但未发药的；医生工作站：主管医生未审核")]
        AppliedDrug = 16
    }

    /// <summary>
    /// EnumBsItemLsGfType [公费类别：1-公费；2-自费；3-按固定自付比例]
    /// </summary>
    public enum EnumGfType
    {
        [Description("可以报销")]
        SocializedMedicine = 1,

        [Description("自费")]
        OwnExpense = 2,

        [Description("按固定自付比例")]
        FixRatio = 3
    }

    public enum EnumOuDrugRecipeIssueStatus
    {
        [Description("未发")]
        NotIssue = 1,

        [Description("已发")]
        Issue = 2,

        [Description("已退药")]
        Back = 3
    }


    public enum EnumDocumentMenuItem
    {
        添加视频链接,
        说明,
        刷新,
        重新下载
    }

    /// <summary> 
    /// 选中的索引 index 
    /// </summary>
    public enum EnumIndex
    {
        索引一 = 0,

        索引二 = 1,

        索引三 = 2,

        索引四 = 3,

        索引五 = 4,

        索引六 = 5,

        索引七 = 6,

        索引八 = 7,

        索引九 = 8,

        索引十 = 9,
    }

    public enum HotKeys
    {
        None,
        F1,
        F2,
        F3,
        F4,
        F5,
        F6,
        F7,
        F8,
        F9,
        F10,
        F11,
        F12,
        N,
        D,
        S,
        Q,
        P
    }
    public enum ToolbarStatus
    {
        All = 0,
        View = 1,
        Edit = 2,
        Add = 4
    }
    public enum FuctionAccess
    {
        Browse = 1,
        Add = 2,
        Modify = 3,
        Delete = 4,
        Check = 5,
        Public = 6,
        Location = 7,
        Other = 8,
        Doctor = 10,
        User = 11
    }
    public enum ToolbarItemStatus
    {
        Enable = 1,
        Disable = 2,
        Visible = 4,
        Hidden = 8
    }
    public enum ToolbarItemType
    {
        Button = 0,
        Dropdown = 1
    }

    public enum MsgStates
    {
        [Description("成功")]
        Success = 0,
        [Description("警告")]
        Waring,
        [Description("警告列表")]
        WaringList,
        [Description("错误")]
        Error,
        [Description("错误列表")]
        ErrorList
    }

    /// <summary>
    /// 收费类别
    /// </summary>
    public enum EnumInvmzItemId
    {
        体检费 = 1,
        治疗费 = 3,
        其他 = 14,
        中药费 = 41,
        西药费 = 61,
        材料费 = 101
    }
    /// <summary>
    /// 列状态
    /// </summary>
    public enum RowStatusEnum
    {
        已保存 = 0,
        新增 = 1,
        修改 = 2,
        删除 = 3,
        新增后删除 = 4,
        修改后删除 = 5
    }

    /// <summary>
    /// 版本标识
    /// </summary>
    public enum EnumEdition
    {
        口腔 = 1,
        妇科 = 2,
        健康机构 = 3,
        综合门诊 = 4,
        居家养老 = 5,
    }
    /// <summary>
    /// 操作类型：1-新增 2-删除 3-修改  
    /// </summary>
    public enum OperType
    {
        新增 = 1,
        删除 = 2,
        修改 = 3
    }



    /// <summary>
    /// 节点等级
    /// </summary>
    public enum EunmTreeNodeLv
    {
        一级 = 1,
        二级 = 2,
        三级 = 3
    }


    /// <summary>
    /// 一级菜单
    /// </summary>
    public enum EnumCanAccessFirstModul
    {
        前台咨询,
        门诊就诊,
        库存管理,
        数据分析,
        系统维护,
        一键诊疗
    }

    /// <summary>
    /// 二级菜单 界面名称 
    /// </summary>
    public enum EnumCanAccesTwoModul
    {
        科室分检,
        治疗方案,
        问诊就诊,
    }

    /// <summary>
    ///所允许用户做的 操作
    /// </summary>
    public enum EnumAudit
    {
        审核,
        删除,
        编辑
    }
    /// <summary>
    /// 审核执行
    /// </summary>
    public enum EnumAuditStatus
    {
        审核,
        取消
    }

    /// <summary>
    /// 获取欠款类型
    /// </summary>
    public enum EnumGetArrearsType
    {
        获取当前欠费,
        之差记账,
        上次欠费
    }

    /// <summary>
    /// 金钱单位
    /// </summary>
    public enum EnumMoneyUnit
    {
        分,
        角,
        元,
        拾,
        佰,
        仟
    }
    /// <summary>
    ///  是  或 否
    /// </summary>
    public enum EnumYesAndNo
    {
        全部 = 2,
        是 = 1,
        否 = 0
    }

    /// <summary>
    /// List的行的状态
    /// </summary>
    public enum EnumRowStatus
    {
        Add = 1,
        Modify = 2,
        Delete = 3
    }
    /// <summary>
    /// 处方类型 （处方主表是什么类型的处方）
    /// </summary>
    public enum EnumOuRecipeLsRepType
    {
        None = 0,
        治疗 = 1,
        理疗 = 2,
        体检 = 3,
        中药 = 4,
        西药 = 5,
        附加项目 = 6,
        材料 = 7,
        营养素 = 8,
        其他=9,
    }



    /// <summary>
    /// 项目类型
    /// </summary>
    public enum EnumFeeMzId
    {
        Null = -1,
        中药 = 5400,//维修服务
        西药 = 5521,
        体检 = 5540,
        治疗 = 21,//生活用品
        其他 = 5500,
        附加项目 = 5741,
        处置 = 0,
        //生活用品 = 21,
        药品食品 = 5460,
        牙周科 = 5700,
        综合科 = 5701,
        正畸科 = 5702,
        药品 = 5703,
        居家养老 = 5742,
        营养素 = 5741,
        生鲜=5602

    }

    /// <summary>
    /// 基本类型[用于构造基础数据选项]
    /// </summary>
    public enum EnumBaseType
    {
        TypeOne = 1,
        TypeTwo = 2,
        TypeZero = 0,
    }

    /// <summary>
    /// 体检类型 
    /// </summary>
    public enum EnumCheckType
    {
        检查项目 = 1,
        检验项目 = 2,
        无项目 = 0,
    }

    /// <summary>
    /// ReturnValue 编码
    /// </summary>
    public enum EnumReturnValue
    {
        正常 = 0,
        错误 = 1,
    }

    /// <summary>
    /// 门诊挂号表错误编码
    /// </summary>
    public enum EnumErrorCode
    {
        正常 = 0,
        错误 = -1,
    }
    /// <summary>
    /// 消息错误集
    /// </summary>
    public enum EnumErrorMsg
    {
        保存成功,
        保存失败,
        该门诊发票号已经被使用,
        该挂号发票已经被使用,
        还没设置发票类别
    }

    /// <summary>
    /// 注销否
    /// </summary>
    public enum EunmIsCancel
    {
        未注销 = 0,
        注销 = 1,
    }

    /// <summary> 
    /// 选项卡切换的index 
    /// </summary>
    public enum EnumTabIndex
    {
        选项卡一 = 0,

        选项卡二 = 1,

        选项卡三 = 2,

        选项卡四 = 3,

        选项卡五 = 4,

        选项卡六 = 5,

        选项卡七 = 6,

        选项卡八 = 7,

        选项卡九 = 8,

        选项卡十 = 9,

        选项卡十一 = 10,

        选项卡十二 = 11,

        选项卡十三 = 12,

        选项卡十四 = 13,

        选项卡十五 = 15,
    }

    /// <summary>
    /// 角色枚举
    /// </summary>
    public enum EnumRole
    {
        超级管理员 = 1018,

        医联体管理员 = 1238,

        诊所管理员 = 1239,

        诊所医生 = 2,

        护士 = 1164,

        医生助理 = 1238,

        无角色 = 0
    }

    /// <summary>
    /// 用户GUID枚举
    /// </summary>
    public enum EnumUserId
    {
        超管 = 9,
        医联体角色 = 1238
    }

    /// <summary>
    /// 显示或隐藏
    /// </summary>
    public enum EnumCheckShow
    {
        /// <summary>
        /// 显示
        /// </summary>
        Visible = 1,
        /// <summary>
        /// 隐藏
        /// </summary>
        Collapsed = 0
    }


    /// <summary>
    /// 项目类别
    /// </summary>

    public enum EnumItemClass
    {
        质控类 = 130,
        无分类 = 0
    }

    /// <summary>   
    ///套餐类型：0 非套餐 1 套餐
    /// </summary>
    public enum EnumNoItemsType
    {
        /// <summary>
        /// 
        /// </summary>
        非套餐 = 0,
        /// <summary>
        /// 
        /// </summary>
        套餐 = 1
    }

    /// <summary>   
    ///预约病人当前状态 ： 0 默认 1 到达 2 过期 3 预约
    /// </summary>
    public enum EnumBookedPatientStatus
    {
        默认 = 0,
        到达 = 1,
        过期 = 2,
        预约 = 3,
    }
    /// <summary>
    /// 0候诊 1预约 2复诊 3已收费 4已诊 
    /// </summary>
    public enum EnumPatientStatus
    {
        候诊 = 0,
        预约 = 1,
        复诊 = 2,
        已收费 = 3,
        已诊 = 4,
        初诊 = 5,
        非预约 = 6
    }
    /// <summary>
    /// 0.未预约 1.已预约  2.全部
    /// </summary>
    public enum EnumPreRegType
    {
        未预约 = 0,
        已预约 = 1,
        全部 = 2,
    }
    /// <summary>
    /// 病人页面显示状态
    /// </summary>
    public enum EnumPatientUiStatus
    {
        已收费,
        预约已诊,
        预约已到,
        过期未到,
        未收费
    }
    /// <summary>
    /// 检验状态
    /// </summary>
    public enum EnumTjStatusType
    {
        未采集 = 0,
        已采集 = 1,
        已接收 = 2,
        已匹配 = 3,
        已保存 = 4,
        已审核 = 5,
    }

    /// <summary>
    /// 电子病历类别
    /// </summary>
    public enum EnumRecordType
    {
        /// <summary>
        /// 主诉
        /// </summary>
        主诉 = 1,
        /// <summary>
        /// 病史
        /// </summary>
        病史 = 2,
        /// <summary>
        /// 检查
        /// </summary>
        检查 = 3,
        /// <summary>
        /// X线
        /// </summary>
        X光检查 = 4,
        /// <summary>
        /// 诊断
        /// </summary>
        诊断 = 5,
        /// <summary>
        /// 治疗过程
        /// </summary>
        治疗过程 = 6,
        /// <summary>
        /// 治疗方案
        /// </summary>
        治疗 = 7,
        /// <summary>
        /// 医嘱
        /// </summary>
        医嘱 = 8,
        /// <summary>
        /// 既往史
        /// </summary>
        既病史 = 9,
        /// <summary>
        /// 治疗方案
        /// </summary>
        治疗方案 = 10
    }
    /// <summary>
    /// 服务类型
    /// </summary>
    public enum EnumOuServiceType
    {
        上门服务 = 0,
        转诊服务 = 1,
        生活服务 = 2,
    }
    /// <summary>
    /// 回访类型
    /// </summary>
    public enum EnumFollowType
    {
        复诊提醒 = 3,
        健康教育 = 4,
        诊后关怀 = 5,
        病情跟踪 = 6,
        满意度调查 = 7,
        用药提示 = 8
    }

    /// <summary>
    /// 就诊目的
    /// </summary>
    public enum EnumLsIllnessAim
    {
        洁牙 = 1,
        拔牙 = 2,
        镶牙 = 3,
        定期检查 = 4,
        牙周治疗 = 5,
        正畸治疗 = 6,
        修复治疗 = 7,
        种植治疗 = 8,
        根管治疗 = 9
    }

    /// <summary>
    /// 回访状态
    /// </summary>
    public enum EnumFollowStatus
    {
       // 全部 = 0,
        未回访 = 1,
        已回访 = 2,
        待跟进 = 3,
        有异常 = 4,
        关机 = 5,
        停机 = 6,
        拒接 = 7,
        空号 = 8,
        错号 = 9,
    }

    /// <summary>
    /// 加工单状态 未完工、已取件、已完工、试戴、已戴走、返工
    /// </summary>
    public enum EnumWorkSheetStatus
    {
        //未选择 = 9,
        未完工 = 0,
        已完工 = 1,
        已取件 = 2,
        试戴 = 3,
        已戴走 = 4,
        返工 = 5
    }


    /// <summary>
    /// 回访方式（通知方式）
    /// </summary>
    public enum EnumFollowWay
    {
        手机APP = 0,
        短信 = 1,
        电话 = 2,
        其他 = 10
    }

    /// <summary>
    /// 满意度
    /// </summary>
    public enum EnumRaiseType
    {
        非常不满意 = 1,
        不满意 = 2,
        一般 = 3,
        满意 = 4,
        非常满意 = 5
    }

    /// <summary>
    /// 加工单 附件
    /// </summary>
    public enum EnumAttachment
    {
        旧牙 = 1,
        咬合蜡 = 2,
        原摸 = 3,
        照片 = 4,
        数据 = 5,
    }

    /// <summary>
    /// 加工单 紧急程度
    /// </summary>
    public enum EnumEmergencyType
    {
        急件 = 1,
        五天件 = 2,
        七天件 = 3,
    }

    /// <summary>
    /// 课程状态
    /// </summary>
    public enum EnumCourseStatus
    {
        未知状态 = 0,
        我要报名 = 1,
        我已报名,
        我要进入,
        报名结束,
        课程结束,
        开始开课,
        我的课程
    }

    /// <summary>
    ///家庭类型的枚举  
    /// </summary>
    public enum EnumLsFamilyType
    {
        核心家庭 = 1,
        主干家庭,
        联合家庭,
        单身家庭,
        单亲家庭,
        群居家庭,
        同居家庭,
        同性恋家庭,
        其他家庭类型
    }

    /// <summary>
    /// 定义出入库类型的枚举
    /// </summary>
    public enum HuRmBillTypeCodeEnum
    {
        /// <summary>
        /// 自购入库
        /// </summary>
        RK = 1,
        /// <summary>
        /// 其它入库
        /// </summary>
        OT = 2,
        /// <summary>
        /// 领药出库
        /// </summary>
        CK = 3,
        /// <summary>
        /// 其它出库
        /// </summary>
        SL = 4,
        /// <summary>
        /// 退药出库
        /// </summary>
        TH = 5,
        /// <summary>
        /// 报损出库
        /// </summary>
        BS = 6,
        /// <summary>
        /// 盘盈入库
        /// </summary>
        KY = 7,
        /// <summary>
        /// 盘亏出库
        /// </summary>
        KK = 8,
        /// <summary>
        /// 采购申请
        /// </summary>
        QS = 9,
        /// <summary>
        /// 其它入房
        /// </summary>
        OF = 10,
        /// <summary>
        /// 调拨出房
        /// </summary>
        DB = 11,
        /// <summary>
        /// 调拨入房
        /// </summary>
        DR = 28,
        /// <summary>
        /// 退药出房
        /// </summary>
        TK = 12,
        /// <summary>
        /// 报损出房
        /// </summary>
        FS = 13,
        /// <summary>
        /// 其它出房
        /// </summary>
        FO = 14,
        /// <summary>
        /// 盘盈入房
        /// </summary>
        PY = 15,
        /// <summary>
        /// 盘亏出房
        /// </summary>
        PK = 16,
        /// <summary>
        /// 科室领药
        /// </summary>
        KS = 17,
        /// <summary>
        /// 科室退药
        /// </summary>
        KB = 18,
        /// <summary>
        /// 病区发药
        /// </summary>
        BQ = 19,
        /// <summary>
        /// 门诊发药
        /// </summary>
        CF = 20,
        /// <summary>
        /// 病区退药
        /// </summary>
        QB = 21,
        /// <summary>
        /// 门诊退药
        /// </summary>
        FB = 22,
        /// <summary>
        /// 领药申请
        /// </summary>
        FQ = 23,
        /// <summary>
        /// 药库盘点
        /// </summary>
        YK = 24,
        /// <summary>
        /// 药房盘点
        /// </summary>
        YF = 25,
        /// <summary>
        /// 药库调价
        /// </summary>
        HT = 26,
        /// <summary>
        /// 药房调价
        /// </summary>
        RT = 27,
        /// <summary>
        /// 定时调价
        /// </summary>
        TJ = 29
    }

    /// <summary>
    ///  0 一般采购 1 病人采购
    /// </summary>
    public enum QSTypeEnum
    {
        一般采购 = 0,
        病人采购 = 1
    }

    /// <summary>
    /// 单据对象名称类型
    /// </summary>
    public enum BillNameTypeEnum
    {
        /// <summary>
        /// 药房药库GUID字段名称
        /// </summary>
        HouseRoomIDFieldName,
        /// <summary>
        /// 中文名称
        /// </summary>
        ChineseName,
        /// <summary>
        /// BLL主表类名称
        /// </summary>
        BLLMainName,
        /// <summary>
        /// Model主表类名称
        /// </summary>
        ModelMainName,
        /// <summary>
        /// BLL明细表类名称
        /// </summary>
        BLLDetailName,
        /// <summary>
        /// Model明细表类名称
        /// </summary>
        ModelDetailName,
    }


    /// <summary>
    /// 定义文本类型的枚举
    /// </summary>
    public enum TextBoxTypeEnum
    {
        /// <summary>
        /// 字符
        /// </summary>
        String,
        /// <summary>
        /// 折扣: 8.2
        /// </summary>
        NumDiscount,
        /// <summary>
        /// 数量: 10.2
        /// </summary>
        NumTotality,
        /// <summary>
        /// 金额: 18.2
        /// </summary>
        NumAmount,
        /// <summary>
        /// 比例: 10.4
        /// </summary>
        NumRatio,
        /// <summary>
        /// 价格: 12.4
        /// </summary>
        NumPrice,
        /// <summary>
        /// 整数: 6
        /// </summary>
        NumInteger,
        /// <summary>
        /// 整数: 4
        /// </summary>
        NumSmallInteger,
        /// <summary>
        /// 日期
        /// </summary>
        DateTime
    }


    /// <summary>
    /// 家庭生活周期
    /// </summary>
    public enum EnumLsPeriod
    {
        新婚期 = 1,
        首孩出生期,
        学龄前儿童期,
        学龄儿童期,
        青少年期,
        孩子离家创业期,
        空巢期,
        退休期
    }

    public enum ConstantEnum
    {
        /// <summary>
        /// 常量 0
        /// </summary>
        INT_0 = 0,
        /// <summary>
        /// 常量 1
        /// </summary>
        INT_ONE = 1,
        /// <summary>
        /// 常量 2
        /// </summary>
        INT_TWO = 2,
        /// <summary>
        /// 常量 3
        /// </summary>
        INT_THREE = 3,
        /// <summary>
        /// 常量 4
        /// </summary>
        INT_FOUR = 4,
        /// <summary>
        /// 常量 5
        /// </summary>
        INT_FIVE = 5,
        /// <summary>
        /// 常量 6
        /// </summary>
        INT_SIX = 6,
        /// <summary>
        /// 常量 7
        /// </summary>
        INT_SEVEN = 7,
        /// <summary>
        /// 常量 8
        /// </summary>
        INT_EIGHT = 8,
        /// <summary>
        /// 常量 9
        /// </summary>
        INT_NINE = 9,
        /// <summary>
        /// 常量 10
        /// </summary>
        INT_TEN = 10
    }


    /// <summary>
    /// 定义出入库类型的枚举
    /// </summary>
    public enum HuActTypeEnum
    {
        /// <summary>
        /// 自购入库
        /// </summary>
        RK = 1,
        /// <summary>
        /// 退回厂商
        /// </summary>
        TH = 2,
        /// <summary>
        /// 报损出库
        /// </summary>
        BS = 3,
        /// <summary>
        /// 其他入库
        /// </summary>
        OT = 4,
        /// <summary>
        /// 领用出库
        /// </summary>
        CK = 5,
        /// <summary>
        /// 其他出库
        /// </summary>
        SL = 6,
        /// <summary>
        /// 盘盈入库
        /// </summary>
        PY = 7,
        /// <summary>
        /// 盘亏出库
        /// </summary>
        PK = 8,
        /// <summary>
        /// 领用退库
        /// </summary>
        TK = 9,
        /// <summary>
        /// 调拨入库
        /// </summary>
        DB = 10,
        /// <summary>
        /// 采购计划
        /// </summary>
        QS = 11,
        /// <summary>
        /// 作废收费入库
        /// </summary>
        CI = 98,
        /// <summary>
        /// 收费出库
        /// </summary>
        PO = 99,
    }




    /// <summary>
    /// 发票类别  
    /// </summary>
    public enum GblInvTypeEnum
    {
        /// <summary>
        /// 门诊挂号  
        /// </summary>
        OuReg = 1,
        /// <summary>
        /// 门诊收费  
        /// </summary>
        OuChargeInvoice,
        /// <summary>
        /// 住院按金  
        /// </summary>
        InDeposit,
        /// <summary>
        /// 住院收费  
        /// </summary>
        InChargeInvoice
    }

    /// <summary>  
    /// 限制类型：1 询问 2限制  
    /// </summary>  
    public enum EnumLimitType
    {
        询问 = 1,
        限制 = 2
    }

    /// <summary>
    /// 打印标签类型集合
    /// </summary>
    public enum EnumTagType
    {
        尿液标签 = 1,
        唾液标签 = 2
    }

    /// <summary>
    /// 显示bp 或者病历模板 1bp 2 模板
    /// </summary>
    public enum BportreEnum
    {

    }

    /// <summary>
    /// 流水号类别的枚举  
    /// </summary>
    public enum EnumSequenceNumType
    {
        /// <summary>
        /// 挂号  
        /// </summary>
        MzReg = 1,
        /// <summary>
        /// 门诊处方  
        /// </summary>
        MzRecipe = 2,
        /// <summary>
        /// 领药申请单
        /// </summary>
        InDrugReq = 3,
        /// <summary>
        /// 标本登记
        /// </summary>
        SimpleRecord = 4,
        /// <summary>
        /// 住院退药申请单
        /// </summary>
        RmDrugBackReq = 5,
        /// <summary>
        /// 住院退药单
        /// </summary>
        RmInDrugBack = 6,
        /// <summary>
        /// 住院发药
        /// </summary>
        RmInDrugIssue = 7,
        /// <summary>
        /// 门诊发药单
        /// </summary>
        RmOuDrugIssue = 8,
        /// <summary>
        /// 门诊退药单
        /// </summary>
        RmOuDrugBack = 9,
        /// <summary>
        /// 体检单据号
        /// </summary>
        CkMainCheckId = 10,
        /// <summary>
        /// 模板号
        /// </summary>
        TemplateNo = 97,
        /// <summary>
        /// 药品调价
        /// </summary>
        PriceAdjust = 12,
        /// <summary>
        /// 检查申请报告单
        /// </summary>
        PsApplyReport = 78,
        /// <summary>
        /// 标本登记病人次序
        /// </summary>
        CkLabPatientSeq = 77,
        /// 会诊记录
        /// </summary>
        PsDiagSeq = 66,
        /// <summary>
        /// 手术申请
        /// </summary>
        OpsApply = 79,
        /// <summary>
        /// 病人自动卡号
        /// </summary>
        CarNo = 11,
        /// <summary>
        /// 医保流水号
        /// </summary>
        YBRegNo = 98,
        /// <summary>
        /// 卡号不按日期生成
        /// </summary>
        NotDateCarNo = 99,
        /// <summary>
        /// 退回血站流水号
        /// </summary>
        BldBackToSation = 100,
        /// <summary>
        /// 科室退回血库
        /// </summary>
        BldBackToLocation = 101,
        /// <summary>
        /// 血液申请
        /// </summary>
        BldApplyRecNo = 102,
        /// <summary>
        /// 自动生成发票号
        /// </summary>
        AutoCharge = 88,
        /// <summary>
        /// 视频会话组号
        /// </summary>
        ChatGroupID = 13,
        /// <summary>
        /// 自动生成发票号
        /// </summary>
        InvoiceNum = 14,
        /// <summary>
        /// 条形码
        /// </summary>
        BarCode = 23,
        /// <summary>
        /// 发药
        /// </summary>
        FaYaoId = 24
    }
    public enum ItemType
    {
        [Description("完成状态")]
        finishStatus,

        [Description("未完成状态")]
        NofinishStatus,

        [Description("审核状态")]
        AuthorizedStatus
    }
    public enum EnumInHosInfoLsMarriage
    {
        [Description("儿童")]
        Children = 1,

        [Description("未婚")]
        Spinsterhood = 2,

        [Description("初婚")]
        FirstTime = 3,

        [Description("再婚")]
        Remarry = 4,

        [Description("离异")]
        Divorce = 5,

        [Description("丧偶")]
        Spouse = 6,

        [Description("其它")]
        Othor = 7
    }
    public enum EnumUserProfiles
    {
        [Description("LocationID_1464")]
        LocationID_1464 = 1464,
        [Description("LocationID_1465")]
        LocationID_1465 = 1465
    }
    public enum EnumAgeUnit
    {
        [Description("年")]
        Year = 1,

        [Description("月")]
        Month = 2
    }
    /// <summary>
    /// 定义出入房类型的枚举
    /// </summary>
    public enum EnumRmActType
    {
        /// <summary>
        /// 其它入房
        /// </summary>
        OF = 1,
        /// <summary>
        /// 调拨出房
        /// </summary>
        DB = 2,
        /// <summary>
        /// 退药出房
        /// </summary>
        TK = 3,
        /// <summary>
        /// 报损出房
        /// </summary>
        FS = 4,
        /// <summary>
        /// 其它出房
        /// </summary>
        FO = 5,
        /// <summary>
        /// 盘盈入房
        /// </summary>
        PY = 6,
        /// <summary>
        /// 盘亏出房
        /// </summary>
        PK = 7,
        /// <summary>
        /// 科室领药
        /// </summary>
        KS = 8,
        /// <summary>
        /// 科室退药
        /// </summary>
        KB = 9,
        /// <summary>
        /// 病区发药
        /// </summary>
        BQ = 10,
        /// <summary>
        /// 门诊发药
        /// </summary>
        CF = 11,
        /// <summary>
        /// 病区退药
        /// </summary>
        QB = 12,
        /// <summary>
        /// 门诊退药
        /// </summary>
        FB = 13,
        /// <summary>
        /// 药品入房
        /// </summary>
        FR = 14,
        /// <summary>
        /// 调拨入房
        /// </summary>
        DR = 15,
    }

    /// <summary>
    /// 单据操作类型
    /// </summary>
    public enum EnumBillOperatorType
    {
        /// <summary>
        /// Save
        /// </summary>
        Save,
        /// <summary>
        /// Modify
        /// </summary>
        Modify,
        /// <summary>
        /// Remove
        /// </summary>
        Remove,
    }

    /// <summary>
    /// 星期
    /// </summary>
    public enum EnumWeekDay
    {
        /// <summary>
        ///  星期一
        /// </summary>
        MD = 1,
        /// <summary>
        ///  星期二
        /// </summary>
        TD = 2,
        /// <summary>
        ///  星期三
        /// </summary>
        WD = 3,
        /// <summary>
        ///  星期四
        /// </summary>
        TUD = 4,
        /// <summary>
        ///  星期五
        /// </summary>
        FD = 5,
        /// <summary>
        ///  星期六
        /// </summary>
        STD = 6,
        /// <summary>
        ///  星期天
        /// </summary>
        SUD = 0
    }

    /// <summary>
    /// EnumBsLocationLsInOut [1-住院科室;2-门诊科室;3-所有业务科室;4-后勤科室;5-大科室;6-医技科室;7-药剂科室;8-物资仓库]
    /// </summary>
    public enum EnumLocationInOut
    {
        /// <summary>
        /// 1-住院科室
        /// </summary>
        In = 1,
        /// <summary>
        /// 2-门诊科室
        /// </summary>
        Out = 2,
        /// <summary>
        /// 3-所有
        /// </summary>
        All = 3,
        /// <summary>
        /// 4-辅助科室
        /// </summary>
        Assistant = 4,
        /// <summary>
        /// 5-大科室
        /// </summary>
        BigLocation = 5,
        /// <summary>
        /// 6-医技科室
        /// </summary>
        Function = 6,
        /// <summary>
        /// 7-药剂科室
        /// </summary>
        DrugApply = 7,
        /// <summary>
        /// 8-物资仓库
        /// </summary>
        MaterialsApply = 8
    }

    /// <summary>
    /// EnumBsUserLsInputWay [默认中文输入方式：1-拼音；2-五笔]
    /// </summary>
    public enum EnumInputWay
    {
        /// <summary>
        /// 1-拼音
        /// </summary>
        Phoneticize = 1,
        /// <summary>
        /// 2-五笔
        /// </summary>
        WuBi = 2
    }


    /// <summary>
    /// 锁定类别GblKeyLockSetting.LockTypeId
    /// </summary>
    public enum EnumLockType
    {
        /// <summary>
        /// 流水号
        /// </summary>
        MzRegId = 1,
        /// <summary>
        /// 住院中药处方号
        /// </summary>
        InChinRecipe,
        /// <summary>
        /// 住院号
        /// </summary>
        HospId,
        /// <summary>
        /// 领药单号
        /// </summary>
        InDrugReq,
        /// <summary>
        /// 检验标本号
        /// </summary>
        CkLabId,
        /// <summary>
        /// 门诊发药
        /// </summary>
        RecipeId,
        /// <summary>
        /// 采购申请
        /// </summary>
        HuBuyInReq,
        /// <summary>
        /// 自购入库
        /// </summary>
        HuBuyIn,
        /// <summary>
        /// 其他入库
        /// </summary>
        HuOtherIn,
        /// <summary>
        /// 领药出库
        /// </summary>
        HuOut,
        /// <summary>
        /// 退药出库
        /// </summary>
        HuBack,
        /// <summary>
        /// 报损出库
        /// </summary>
        HuLoseOut,
        /// <summary>
        /// 其他出库
        /// </summary>
        HuOtherOut,
        /// <summary>
        /// 药房领药申请
        /// </summary>
        RmAppDrug,
        /// <summary>
        /// 科室退药
        /// </summary>
        RmKsBack,
        /// <summary>
        /// 其他入房
        /// </summary>
        //RmOtherIn,
        /// <summary>
        /// 科室领药
        /// </summary>
        //RmKsOut,
        /// <summary>
        /// 调拔出房
        /// </summary>
        RmMove,
        /// <summary>
        /// 退药出房
        /// </summary>
        RmAppBack,
        /// <summary>
        /// 报损出房
        /// </summary>
        RmLose,
        /// <summary>
        /// 其他出房
        /// </summary>
        RmOutOth,
        /// <summary>
        /// 药房盘点
        /// </summary>
        RmInventories,
        /// <summary>
        /// 药库盘点
        /// </summary>
        HuInventories,
        /// <summary>
        /// 每日收费
        /// </summary>
        DayFee,
        /// <summary>
        /// 医嘱
        /// </summary>
        AlterAdvice,
        /// <summary>
        /// 病历
        /// </summary>
        EMR,
        /// <summary>
        /// 药库定时调价
        /// </summary>
        HuDsTJ,
        /// <summary>
        /// 药房处方打印
        /// </summary>
        RecipeIdRm,
        /// <summary>
        /// 病程记录
        /// </summary>
        EmrDayRecord,
        /// <summary>
        ///  
        /// </summary>
        RoomWindow
    }


    /// <summary>
    /// 单据特定类型
    /// </summary>
    public enum EnumBillSpecialType
    {
        /// <summary>
        /// 下一个单据
        /// </summary>
        Next,
        /// <summary>
        /// 前一个单据
        /// </summary>
        Previous,
        /// <summary>
        /// 最大的单据
        /// </summary>
        Max,
        /// <summary>
        /// 最小的单据
        /// </summary>
        Min,
    }

    /// <summary>
    /// FileTempate Status  文件状态 0 未下载 1 已下载 2 正在下载
    /// </summary>
    public enum EnumFileTempateStatus
    {
        未下载 = 0,
        已下载 = 1,
        正在下载 = 2
    }

    /// <summary>
    /// EnumBsRoomLsInOut [药房分类：1-门诊；2-住院；3-其他]
    /// </summary>
    public enum RoomInOutEnum
    {
        /// <summary>
        /// 1-门诊
        /// </summary>
        ForOutPatient = 1,
        /// <summary>
        /// 2-住院
        /// </summary>
        ForInPatient = 2,
        /// <summary>
        /// 3-其他
        /// </summary>
        Other = 3
    }

    /// <summary>
    /// EnumTmpWordDetailLsOpenType [使用权：1-个人；2-科室；3-公共]
    /// </summary>
    public enum EnumTmpWordDetailLsOpenType
    {
        /// <summary>
        /// 1-个人
        /// </summary>
        个人 = 1,
        /// <summary>
        /// 2-科室
        /// </summary>
        科室 = 2,
        /// <summary>
        /// 3-公共
        /// </summary>
        公共 = 3
    }

    #region EnumTmpPermisson [使用权]
    /// <summary>
    /// EnumTmpPermisson [使用权：1-个人；2-科室；3-公共；4-全部]
    /// </summary>
    public enum EnumTmpPermisson
    {
        [Description("个人")]
        ForPersonal = 1,

        [Description("科室")]
        ForSection = 2,

        [Description("公共")]
        ForPublic = 3,

        [Description("全部")]
        ForAll = 4
    }
    #endregion

    /// <summary>
    /// EnumTmpWordDetailLsOpenType [使用权：1-个人；2-诊所；3-公共]
    /// </summary>
    public enum EnumTmpLsOpenType
    {
        /// <summary>
        /// 1-个人
        /// </summary>
        ForPersonal = 1,
        /// <summary>
        /// 2-诊所
        /// </summary>
        ForSection = 2,
        /// <summary>
        /// 3-公共
        /// </summary>
        Commonality = 3

    }

    /// <summary>
    /// 结算方式
    /// </summary>
    public enum EnumChargeDaysTypeCalculateMode
    {
        UnIncludeLastDay = 1,//不包括最后一天(出院结算时)
        IncludeLastDay = 2,//包括最后一天(出院结算时)
    }

    /// <summary>
    /// EnumYbType [医保类别：1-甲类；2-乙类；3-自费；4-丙类]
    /// </summary>
    public enum EnumYbType
    {
        /// <summary>
        /// 1-甲类
        /// </summary>
        Firstkind = 1,
        /// <summary>
        /// 2-乙类
        /// </summary>
        Secondkind = 2,
        /// <summary>
        /// 3-自费
        /// </summary>
        SelfPay = 3,
        /// <summary>
        /// 4-丙类
        /// </summary>
        Firdkind = 4
    }

    /// <summary>
    /// 重要程度
    /// </summary>
    public enum ImportanceType
    {
        非常紧急 = 1,
        重要 = 2,
        一般 = 3
    }

    /// <summary>
    /// 维修状态
    /// </summary>
    public enum RepairStates
    {
        尚未维修 = 1,
        修理中 = 2,
        修理完成 = 3
    }

    /// <summary>
    /// 维修状态查询
    /// </summary>
    public enum RepairStatesSearch
    {
        全部 = 0,
        尚未维修 = 1,
        修理中 = 2,
        修理完成 = 3
    }

    /// <summary>
    /// 支付方式
    /// </summary>
    public enum LsPayType
    {
        现金 = 1,
        支票 = 2,
        转账 = 3,
        刷卡 = 4
    }

    /// <summary>
    /// 收费方式
    /// </summary>
    public enum EnumPayWayType
    {
        会员退费 = 411,
        平账专用 = 691,
        补录单据 = 711,
        体验券_中国人寿 = 712,
        其他 = 8,
        医保卡 = 592,
        医保卡_现金 = 593,
        医保卡_银联卡 = 594,
        银联卡 = 595,
        医卡通 = 626,
        活动优惠卡 = 627,
        端祥商务卡 = 628,
        普通洁牙券 = 629,
        VIP洁牙券 = 630,
        美团团购 = 631,
        收预付款 = 632,
        扣预付款 = 633,
        退费 = 634,
        免费 = 636,
        支付宝 = 651,
        微信 = 652,
        现金 = 591,
        挂号费 = 671,
        折扣优惠项 = 731,
        普通充值 = 751,
        会员余额 = 771,
    }

    /// <summary>
    /// 会员卡状态
    /// </summary>
    public enum EnumCardStatus
    {
        正常 = 1,
        挂失 = 2,
        停用 = 3
    }

    /// <summary>
    /// 出入库类型
    /// </summary>
    public enum EnumHuActTypeName
    {
        /// <summary>
        /// 全部
        /// </summary>
        全部 = 0,
        /// <summary>
        /// 自购入库
        /// </summary>
        物品入库 = 1,
        /// <summary>
        /// 退回厂商
        /// </summary>
        退回厂商 = 2,
        /// <summary>
        /// 报损出库
        /// </summary>
        物品报损 = 3,
        /// <summary>
        /// 其他入库
        /// </summary>
        其他入库 = 4,
        /// <summary>
        /// 领用出库
        /// </summary>
        物品出库 = 5,
        /// <summary>
        /// 盘盈入库
        /// </summary>
        盘盈入库 = 7,
        /// <summary>
        /// 盘亏出库
        /// </summary>
        盘亏出库 = 8,
        /// <summary>
        /// 领用退库
        /// </summary>
        领用退库 = 9,
        /// <summary>
        /// 调拨入库
        /// </summary>
        调拨入库 = 10,
        /// <summary>
        /// 采购计划
        /// </summary>
        采购计划 = 11,
        /// <summary>
        /// 采购入库
        /// </summary>
        采购入库 = 1,
        /// <summary>
        /// 物品申领
        /// </summary>
        物品申领 = 13,
        /// <summary>
        /// 作废发药入库
        /// </summary>
        作废发药入库 = 98,
        /// <summary>
        /// 发药出库
        /// </summary>
        发药出库 = 99,
      
    }

    /// <summary>
    /// 修改记录日志的操作表序号及其描述
    /// </summary>
    public enum LogChangedType
    {
        项目字典维护 = 1,
        权限设置,
        基本表维护,
        系统参数设置,
        电子病历,
        修改密码
    }
    /// <summary>
    /// 会员消费积分
    /// </summary>
    public enum EnumVipIntegralConsumption
    {
        开卡加积分 = 1,
        充值加积分 = 2,
        消费加积分 = 3,
        兑换减积分 = 4,
        推荐送积分 = 5
    }

    /// <summary>
    /// 消息发送状态
    /// </summary>
    public enum EnumSetMessage
    {
        待发送 = 0,
        发送成功 = 1,
        发送失败 = 2
    }

    /// <summary>
    /// 任务执行状态
    /// </summary>
    public enum EnumTaskState
    {
        待执行 = 0,
        发送执行 = 1,
        执行失败 = 2
    }
    /// <summary>
    /// 工单紧急程度
    /// </summary>
    public enum EnumOrderLive
    {
        一般 = 1,
        紧急 = 2
    }

    /// <summary>
    /// 支付状态
    /// </summary>
    public enum EnumLsPayStart
    {
        未支付 = 1,
        已支付 = 2
    }
    /// <summary>
    /// 紧急程度
    /// </summary>
    public enum EnumEmergencyDegree
    {
        紧急 = 3,
        急 = 2,
        一般 = 1,
    }
    /// <summary>
    /// 支付方式
    /// </summary>
    public enum EnumLsPayType
    {
        //现金 = 1,
        //支票 = 2,
        //转账 = 3,
        //刷卡 = 4
        医保卡 = 1,
        现金 = 2,
        银联卡 = 3,
        合作医疗 = 4,
        支票 = 5,
        计生发票 = 6,
        分娩补助 = 7,
        其他 = 8,
        减免类 = 9,
        单位挂账 = 10,
        会员支付 = 11,
    }
    /// <summary>
    /// 工单状态
    /// </summary>
    public enum EnumOrderStart
    {
        未派单 = 1,
        已派单 = 2
    }

    /// <summary>
    /// 工单状态
    /// </summary>
    public enum EnumOrderType
    {
        回访工单 = 1,
        投诉工单 = 2,
        SOS紧急求助 = 3,
        固定计划排单 = 4,
    }

    /// <summary>
    /// 性别
    /// </summary>
    public enum EnumSex
    {
        /// <summary>
        /// 男
        /// </summary>
        M = 1,
        /// <summary>
        /// 女
        /// </summary>
        F = 2,
        /// <summary>
        /// 通用
        /// </summary>
        O = 0,
        /// <summary>
        /// 通用
        /// </summary>
        C = 3
    }

    /// <summary>
    /// 字符串性别
    /// </summary>
    public enum EnumStringSex
    {
        男 = 1,
        女 = 2,
        未填 = 3
    }
    /// <summary>
    /// 病人称呼类型
    /// </summary>
    public enum EnumPatType
    {
        先生 = 1,
        女士 = 2,
        病人 = 0
    }
    /// <summary>
    /// 顾客进度
    /// </summary>
    public enum EnumIsGblSystemMenu
    {
        平台咨询 = 1,
        医疗服务 = 2, 
    }


    public enum EnumPatSpeed
    {
        报告未出 = 1,
        报告未全 = 2,
        报告齐全 = 3,
        已出营养方案 = 4,
        已出总方案 = 5,
        营养方案已讲解 = 6,
        总方案已讲解 = 7,
        已发送健康检查报告 = 8,
        饮食干预 = 9,
        健康管理启动 = 10
    }

    /// <summary> 
    /// 处方类型 (1治疗 2理疗 3化验 4中药 5西药 7其他/材料 8营养)
    /// </summary>
    public enum EnumRecipeType
    {
        Null = -1,  // 为空
        治疗 = 1,
        理疗 = 2,
        体检 = 3,
        中药 = 4,
        西药 = 5,
        附加项目 = 6,
        材料 = 7,
        营养素 = 8,
        药品食品 = 9,
        牙周科 = 10,
        综合科 = 11,
        正畸科 = 12,
        药品 = 13,
        居家养老 = 14,
        其他 = 15,
        处置 = 16,
        生鲜 = 17
    }




    /// <summary>
    /// 项目类型
    /// </summary>
    //public enum EnumFeeMzId
    //{
    //    Null = -1,
    //    中药 = 5400,//维修服务
    //    西药 = 5521,
    //    体检 = 5540,
    //    治疗 = 21,//生活用品
    //    其他 = 5500,
    //    附加项目 = 5741,
    //    处置 = 0,
    //    //生活用品 = 21,
    //    药品食品 = 5460,
    //    牙周科 = 5700,
    //    综合科 = 5701,
    //    正畸科 = 5702,
    //    药品 = 5703,
    //    居家养老 = 5742,
    //    营养素 = 5741
    //}
    public enum EnumPharmacyType
    {
        药品药房 = 1,
        生鲜药房 = 2,
    }
    /// <summary>
    /// 处方种类：1-治疗项目；2-理疗项目；3-体检项目；4-中草药处方. 5-西药
    /// </summary>
    [Obsolete("请使用EnumRecipeType")]
    public enum EnumRepType
    {
        治疗项目 = 1,
        理疗项目 = 2,
        体检项目 = 3,
        中草药处方 = 4,
        西药 = 5
    }

    /// <summary>
    /// 病人类别
    /// </summary>
    public enum EnumPatientType
    {
        自费 = 116,
    }
    /// <summary>
    /// 文件类型
    /// </summary>
    public enum EnumFileType
    {
        Image = 1,
        Voice = 2,
    }
    /// <summary>
    /// 病人婚姻状态
    /// </summary>
    public enum EnumMarriageType
    {
        未婚 = 1,
        已婚 = 2,
        丧偶 = 3,
        离婚 = 4,
        不详 = 5,
    }

    /// <summary>
    /// 病人的既往史
    /// </summary>
    public enum EnumDhType
    {
        集合 = 0,
        手术史1 = 1,
        手术史2 = 2,
        外伤史1 = 3,
        外伤史2 = 4,
        输血史1 = 5,
        输血史2 = 6,
    }


    /// <summary>
    /// 医生类型
    /// </summary>
    public enum EnumDoctorType
    {
        未知 = 0,
        主治医生 = 1,
        运动师 = 2,
        中医师 = 3,
        心理医生 = 4,
        营养师 = 5,
        其他医师 = 6

    }
    /// <summary>
    ///  诊断类别：1-初诊；2-复诊;3-疑诊；4-急性发作
    /// </summary>
    public enum EnumLsDiagType
    {
        全部 =0,
        初诊 = 1,
        复诊 = 2,
        疑诊 = 3,
        急性发作 = 4,
    }

    /// <summary>
    ///  操作类型：1-新增 2-删除 3-修改
    /// </summary>
    public enum EnumOperType
    {
        新增 = 1,
        删除 = 2,
        修改 = 3
    }

    /// <summary>
    /// /临检，食物不耐受，特检，功能医学
    /// </summary>
    public enum EnumTjLocation
    {
        临检 = 286, // 临检225，145   临检286 临检可能是286
        食物不耐受 = 245,
        特检 = 226,
        功能医学 = 246
    }

    /// <summary>
    /// NewTreatmentTabIndex 所对应的下标
    /// </summary>
    //[Obsolete("每个治疗方案处方项目对应的标签页名称不同但索引相同")]
    public enum EnumTreatmentTabIndex
    {
        西药 = 0,//西药
        中药 = 1,//中药  
        检查 = 2,//检查   
        治疗 = 3,//治疗   
        生鲜 = 4,//其他 ---------------------- 生鲜
        其他 = 5,//营养素   ----------------  其他
    }

    /// <summary>
    /// 治疗方案标签页索引
    /// </summary>
    //[Obsolete("每个治疗方案对应的标签页名称不同但索引相同")]
    public enum EnumConTabIndex
    {
        医嘱信息 = 0,
        病历信息 = 1,
        会诊结果 = 4,
        文件上传 = 3,
        病史 = 4,
        远程会诊 = 3,
        learning = 2
    }

    /// <summary>
    /// 护士执行单或瓶签
    /// </summary>
    public enum EnumNurseExecuteOrLable
    {
        护士执行单 = 0,
        瓶签 = 1,
    }

    /// <summary>
    /// 二级菜单id
    /// </summary>
    public enum EnumGblSystemMenu
    {
        会员管理 = 132,
    }

    /// <summary>
    /// 发药状态
    /// 状态 0 未发药 1 已发药 2 退药 3 已执行
    /// </summary>
    public enum EnumOuExecuteStatus
    {
        未发药 = 0,
        已发药 = 1,
        退药 = 2,
        已执行 = 3,
    }
    /// <summary>
    /// 项目 是否执行
    /// </summary>
    public enum EnumAttachType
    {
        已执行 = 0,
        未执行 = 1,
        全部 = 2
    }

    /// <summary>
    /// 凑整方式
    /// </summary>
    public enum EnumRoundingFee
    {
        ///*不凑整 = 0*/,
        直接取整 = 0,
        四舍五入到整元 = 1,
        四舍五入到整角 = 2,
        四舍五入到整分 = 3,
    }
    /// <summary>
    /// 免责声明分类
    /// </summary>
    public enum EnumDisclaimer
    {
        BP = 1,
        中成药推荐 = 2,
        中医治疗 = 3,
    }
    /// <summary>
    /// 会员卡操作
    /// </summary>
    public enum EnumVipCardIdOperation
    {
        充值 = 0,
        退款 = 1,
        赠送 = 2,
        缴费 = 3,
        作废退费 = 4,
        转账 = 5,
        项目消费抵扣=6,
    }
    /// <summary>
    /// 会员卡状态
    /// </summary>
    public enum EnumVipCardState
    {
        正常 = 1,
        挂失 = 2,
        停用 = 3
    }

    /// <summary>
    /// 推送方式(0 微信 1 短信 2 电话 )：  
    /// </summary>
    public enum EnumNotifyType
    {
        微信 = 0,
        短信 = 1,
        电话 = 2,
    }
    /// <summary>
    ///通讯类型  0 其他 1 回访 2 预约
    /// </summary>
    public enum EnumOuCommunicateLogType
    {
        其他 = 0,
        回访 = 1,
        预约 = 2,
    }

    /// <summary>
    /// 首页选中模块
    /// 0.公告栏 1.更新信息 2.咨询中心 3.库存预警 4.重点关注病人
    /// </summary>
    public enum EnumSelectHomePage
    {
        公告栏 = 0,
        更新信息 = 1,
        咨讯中心 = 2,
        库存预警 = 3,
        重点关注病人 = 4,
    }

    /// <summary>
    /// 首页详情父级GUID
    /// </summary>
    public enum EnumHomePageParentId
    {
        根元素 = 0,
        公告栏 = 1,
        更新信息 = 2,
        资讯中心 = 3,
    }

    /// <summary>
    /// 主诊所GUID
    /// </summary>
    public enum EnumMainLocation
    {
        总店 =    5037,
    }

    /// <summary>
    /// 证书类型
    /// </summary>
    public enum EnumCertificateType
    {
        工作照片 = 1,
        职业证书 = 2,
        职称聘书 = 3,
    }

    /// <summary>
    /// 证书类型
    /// </summary>
    public enum EnumJobStatusType
    {
        在职 = 1,
        离职 = 2
    }

    /// <summary>
    /// 门诊就诊选择项序号和描述
    /// </summary>
    public enum EnumItemType
    {
        西药 = 0,
        中药,
        检查,
        治疗,
        其他,
        营养素
    }

    /// <summary>
    /// 火候
    /// </summary>
    public enum EnumFireType
    {
        文火 = 1,
        中火 = 2,
        武火 = 3,
        武火转文火 = 4,
        武火转中火 = 5
    }

    /// <summary>
    /// 煎药方式：1-代煎；2-自煎.（处方）
    /// </summary>
    public enum EnumCookSelfType
    {
        代煎 = 1,
        自煎 = 2
    }

    /// <summary>
    /// 煎药方式：1-先煎;2-后下;3-包煎;4-另煎;5-烊化;6-冲服.（项目）
    /// </summary>
    public enum EnumCookType
    {
        先煎 = 1,
        后下 = 2,
        包煎 = 3,
        另煎 = 4,
        烊化 = 5,
        冲服 = 6,
        另包 = 7
    }

    /// <summary>
    /// 发票明细是否已收费
    /// </summary>
    public enum EnumInvoiceDtlLsPerform
    {
        收费 = 1,
        退费 = 2,
    }

    /// <summary>
    /// SamlingType 采样方式：1-护士采 ;2-自采.
    /// </summary>
    public enum EnumSamlingType
    {
        护士采 = 1,
        自采 = 2
    }

    /// <summary>
    /// 中药处方类型
    /// </summary>
    public enum EnumPrescriptionType
    {
        辨证疗法 = 0,
        名医名家经验方 = 1,
    }
    /// <summary>
    /// 基本处方或加减法
    /// </summary>
    public enum EnumRepiceType
    {
        基本处方 = 0,
        加减法 = 1,
    }

    /// <summary>
    /// 出库查询的时间段： 
    /// RecentlyWeek-最近一周 ;
    /// RecentlyMonth-最近一个月
    /// </summary>
    public enum EnumHuOutBoundPeriod
    {
        RecentlyWeek = 0,
        RecentlyMonth = 1,
    }

    /// <summary>
    /// 是否预警 :
    /// 0-正常;1-预警
    /// </summary>
    public enum EnumStockAlarm
    {
        Nomal = 0,
        Warning = 1,
    }

    /// <summary>
    /// 
    /// </summary>
    public enum EnumBsDocLevel
    {
        健康管理师 = 4,
        理疗师 = 6,
        营养师 = 7,
        运动师 = 8,
        中医师 = 9,
        心理医生 = 10,
    }

    public enum InvoiceType
    {
        门诊挂号 = 1,
        门诊收费 = 2,
        住院按金 = 3,
        住院收费 = 4
    }

    public enum EnumBackupRestoreType
    {
        备份 = 1,
        还原 = 2
    }

    /// <summary>
    /// 显示的属性枚举
    /// </summary>
    public enum EnumPropertyType
    {
        Key = 1,
        Value = 2
    }

    /// <summary>
    /// 属性枚举
    /// </summary>
    public enum EnumAttribute
    {
        IsEnableSchedule = 1,
        IsAutoAuditStockBill = 2,
        IsDisplayRecycle = 3,
        IsChangeElereCord = 4,
        IsModifyChargeTime = 5,
        IsEnableVisitedRating = 6,
        IsBookingSendMessage = 7,
        PhoneNotMustInput = 8,
        PrintCross = 9,
        IsEnableBirthDateInput = 10,
        PercentagePoints = 11,
        ScoreToMoney = 12,
        IsOpenPreview = 13,
        IsSavelocal = 14,
        IsSaveServerUrl = 15,
        IsEnableNewBooking = 16,
        VipInfoCanModifyDays = 17
    }

    /// <summary>
    /// XmlElement属性Key枚举
    /// </summary>
    public enum EnumXmlElementAttributeKey
    {
        Title = 1,
        IsSelected = 2,
        FamilyName = 3,
        FontSize = 4
    }

    public enum EnumXmlElement
    {
        FontSettingIcons = 1,
        FullScreenSetupInfos = 2,
        FullScreenSetupInfo = 3,
        FontSettingInfos = 4,
        FontSettingInfo = 5,
        LocalParameterSettings = 6
    }

    /// <summary>
    /// XmlElement属性Value枚举
    /// </summary>
    public enum EnumXmlElementAttributeValue
    {
        False = 1,
        Ture = 2,
        不覆盖任务栏 = 3,
        覆盖任务栏 = 4
    }

    public enum WdExportCreateBookmarks
    {
        wdExportCreateNoBookmarks = 0,
        wdExportCreateHeadingBookmarks = 1,
        wdExportCreateWordBookmarks = 2
    }

    public enum WdExportItem
    {
        wdExportDocumentContent = 0,
        wdExportDocumentWithMarkup = 7
    }

    public enum WdExportRange
    {
        wdExportAllDocument = 0,
        wdExportSelection = 1,
        wdExportCurrentPage = 2,
        wdExportFromTo = 3
    }
    public enum WdExportOptimizeFor
    {
        wdExportOptimizeForPrint = 0,
        wdExportOptimizeForOnScreen = 1
    }
    public enum WdExportFormat
    {
        wdExportFormatPDF = 17,
        wdExportFormatXPS = 18
    }
    public enum EnumAppraiseType
    {
        未知类别 = 5
    }
    /// <summary>
    /// 项目分类
    /// </summary>
    public enum EnumLsGroupType
    {
        药品 = 1,
        治疗 = 2,
        物资材料 = 3
    }

    public enum EnumLsFileType
    {
        文件夹 = 1,
        图片 = 2,
        视频 = 3,
        网页链接 = 4,
        文本文档 = 5
    }

    public enum EnumComments
    {
        收银台退费
    }

    public enum EnumMemo
    {
        作废收费恢复库存
    }

    public enum EnumRemark
    {
        结账
    }
    //public enum EnumDocumentMenuItem
    //{
    //    添加视频链接=1,
    //    说明=2,
    //    刷新=3,
    //    重新下载=4
    //}

    ///// <summary>
    ///// 预约挂号方式
    ///// </summary>
    //public enum Registration
    //{
    //    手机微信挂号=0,
    //    电话挂号=1,
    //    现场挂号=2
    //}
    #endregion

    #region EnumRpType [处方项目]
    /// <summary>
    /// EnumRpType [处方项目：1-中成药；2-西药；3-中药；4-检验；5-检查；6-手术；7-治疗；8-床位；9-护理；10-全部]
    /// </summary>
    public enum EnumRpType
    {
        [Description("中成药")]
        ChinesePatentMedicine = 1,

        [Description("西药")]
        WestMedicine = 2,

        [Description("中药")]
        ChineseMedicine = 3,

        [Description("检验")]
        Test = 4,

        [Description("检查")]
        Check = 5,

        [Description("手术")]
        OPS = 6,

        [Description("治疗")]
        Cure = 7,

        [Description("床位")]
        Bed = 8,

        [Description("其他")]
        Other = 9,

        [Description("全部")]
        All = 10
    }
    #endregion

    #region EnumFeeWorkPerform [执行类别]
    /// <summary>
    /// EnumOuFeeWorkLsPerform [执行类别：1-收费；2-退费]
    /// </summary>
    public enum EnumFeeWorkPerform
    {
        [Description("收费")]
        Charge = 1,

        [Description("退费")]
        Refundment = 2
    }
    #endregion

    #region EnumGroupType [项目分类]
    /// <summary>
    /// EnumBsItemLsGroupType [项目分类：1-药品；2-治疗；3-物资材料]
    /// </summary>
    public enum EnumGroupType
    {
        [Description("药品")]
        Medicine = 1,

        [Description("治疗")]
        Cure = 2,

        [Description("物资材料")]
        Meterial = 3
    }
    #endregion

    public enum EnumUsageUseArea
    {
        [Description("门诊")]
        OutPatient = 1,

        [Description("住院")]
        InPatient = 2,

        [Description("共用")]
        All = 3
    }

    public enum EnumLsStatus
    {
        [Description("无库存的血袋")]
        BloodBagWithoutStock = 0,

        [Description("在库")]
        InTheLibrary = 1,

        [Description("退回wancheng")]
        Return = 2,

        [Description("发出")]
        Issue = 3,

        [Description("报废")]
        Scrap = 4,

        [Description("已审核")]
        Reviewed = 5
    }

    /// <summary>
    /// 定义出入库类型的枚举
    /// </summary>
    public enum EnumHuRmBillTypeCode
    {
        [Description("自购入库")]
        RK = 1,

        [Description("其它入库")]
        OT = 2,

        [Description("领药出库")]
        CK = 3,

        [Description("其它出库")]
        SL = 4,

        [Description("退药出库")]
        TH = 5,

        [Description("报损出库")]
        BS = 6,

        [Description("盘盈入库")]
        KY = 7,

        [Description("盘亏出库")]
        KK = 8,

        [Description("采购申请")]
        QS = 9,

        [Description("其它入房")]
        OF = 10,

        [Description("调拨出房")]
        DB = 11,

        [Description("调拨入房")]
        DR = 28,

        [Description("退药出房")]
        TK = 12,

        [Description("报损出房")]
        FS = 13,

        [Description("其它出房")]
        FO = 14,

        [Description("盘盈入房")]
        PY = 15,

        [Description("盘亏出房")]
        PK = 16,

        [Description("科室领药")]
        KS = 17,

        [Description("科室退药")]
        KB = 18,

        [Description("病区发药")]
        BQ = 19,

        [Description("门诊发药")]
        CF = 20,

        [Description("病区退药")]
        QB = 21,

        [Description("门诊退药")]
        FB = 22,

        [Description("领药申请")]
        FQ = 23,

        [Description("药库盘点")]
        YK = 24,

        [Description("药房盘点")]
        YF = 25,

        [Description("药库调价")]
        HT = 26,

        [Description("药房调价")]
        RT = 27,

        [Description("定时调价")]
        TJ = 29
    }

    public enum EnumLsHbsAg
    {
        [Description("阴性")]
        Negative = 1,

        [Description("阳性")]
        Positive,

        [Description("未知")]
        Unknown
    }

    public enum EnumLsForSex
    {
        [Description("男")]
        Male = 1,

        [Description("女")]
        Female = 2,

        [Description("两者")]
        Both = 3
    }

    public enum EnumRoomType
    {
        [Description("西药药房")]
        WesternMedicineDugStore = 1,

        [Description("中药药房")]
        ChineseMedicineDrugStore = 2,

        [Description("配制中心")]
        ConfectCenter = 3
    }


    public enum EnumExecLoc
    {
        [Description("药房")]
        CenterMedicineHouse = 2,

        [Description("本科")]
        Local = 3,

        [Description("自备药")]
        Self = 4,

        [Description("记事")]
        Notepad = 5,

        [Description("其他")]
        Other = 6
    }

    public enum EnumCookSelf
    {
        [Description("代煎")]
        CoctByHospital = 1,

        [Description("自煎")]
        CoctBySelf = 2,

        [Description("免煎")]
        CoctNone = 3
    }

    public enum EnumRecipePrintType
    {
        [Description("西药")]
        WesternMedicine = 1,

        [Description("中药")]
        ChinMedicine = 2,

        [Description("检查/检验/治疗")]
        Checkup = 3,
    }

    public enum EnumBillNameType
    {
        [Description("药房药库ID字段名称")]
        HouseRoomIDFieldName,

        [Description("中文名称")]
        ChineseName,

        [Description("BLL主表类名称")]
        BLLMainName,

        [Description("Model主表类名称")]
        ModelMainName,

        [Description("BLL明细表类名称")]
        BLLDetailName,

        [Description(" Model明细表类名称")]
        ModelDetailName,
    }


    public enum EnumGblInvType
    {
        [Description("门诊挂号")]
        OuReg = 1,

        [Description("门诊收费")]
        OuChargeInvoice,

        [Description("住院按金")]
        InDeposit,

        [Description("住院收费")]
        InChargeInvoice,

        [Description("门诊按金")]
        OuDeposit
    }

    /// <summary>
    /// 完成状态
    /// </summary>
    public enum EnumStatus
    {
        [Description("未完成")]
        OutStanding = 1,

        [Description("完成未审批")]
        Released = 2,

        [Description("审批未发布报告")]
        Authorized = 3,

        [Description("审批已发布报告")]
        Reported = 4,

        [Description("部分完成")]
        FinishPart = 5,

        [Description("已接收")]
        Recieved = 6,

        [Description("已收集")]
        Collected = 7,

        [Description("打印条码")]
        BardCodePrinted = 8,

        [Description("Lis已取消")]
        CancelBardCodePrinted = 9,

        [Description("Lis已接收")]
        LisRecieved = 10,

        [Description("Lis已退费")]
        LisCancel = 11,

        [Description("等待审核")]
        WaitAuth = 12,

        Printed = 13
    }



    #region EnumInStatus [住院状态]
    /// <summary>
    /// EnumInHosInfoLsInStatus [住院状态：1-等待住院；2-在院；3-出院；4-请假；5-待出院；0-全部]
    /// </summary>
    public enum EnumInStatus
    {
        [Description("等待住院")]
        WaitForHospital = 1,

        [Description("在院")]
        InHospital = 2,

        [Description("出院")]
        LeaveHospital = 3,

        [Description("请假")]
        Leave = 4,

        [Description("待出院")]
        WaitForLeaveHospital = 5,

        [Description("全部")]
        All = 0
    }
    #endregion

    /// <summary>  
    /// 医嘱类别：1-长期医嘱；2-临时医嘱  
    /// </summary>  
    public enum EnumLsRmAdvType
    {
        [Description("全部")]
        All = 0,
        [Description("长期医嘱")]
        LongTermMedicalAdvice = 1,
        [Description("临时医嘱")]
        TemporaryOrders = 2,
        [Description("出院带药")]
        DischargeWithMedicine = 3,
        [Description("针剂")]
        Injection = 4,
        [Description("12护士医嘱 -----hhq--- ")]
        NurseAdvice = 12,
        [Description("13-辅助科室 ")]
        AuxiliarySection = 13

    }
    /// <summary>
    /// 定义出入库类型的枚举
    /// </summary>
    public enum EnumHuActType
    {
        [Description("自购入库")]
        RK = 1,

        [Description("退货出库")]
        TH = 2,

        [Description("报损出库")]
        BS = 3,

        [Description("其他入库")]
        OT = 4,

        [Description("领药出库")]
        CK = 5,

        [Description("其他出库")]
        SL = 6,

        [Description("盘盈入库")]
        PY = 7,

        [Description("盘亏出库")]
        PK = 8,

        [Description("药房退药")]
        TK = 9,
    }
    #region EnumBillFiledName   [单据字段名称]
    /// <summary>
    /// 单据字段名称
    /// </summary>
    public enum EnumBillFiledName
    {
        GUID,
        BillNo,
    }
    #endregion
    /// <summary>
    ///标本登记项目来源
    /// </summary>
    public enum EnumSpecimenLsUseType
    {
        [Description("门诊")]
        OutpatientService = 1,

        [Description("住院")]
        Hospitalization = 2,

        [Description("外院")]
        OuterCourt = 3,

        [Description("体检")]
        PhysicalExamination = 4

    }

    public enum ParamDelimiter
    {
        [DataMember]
        [Description("中括号分隔符")]
        Bracket = 0,

        [DataMember]
        [Description("逗号分隔符")]
        Comma = 1,

        [DataMember]
        [Description("竖线分隔符")]
        VerticalLine = 2,
    }

    #region 服务组枚举
    /// <summary>
    /// 病历标题操作
    /// </summary>
    public enum EnumPatientTitleMessage
    {
        [Description("病历删除")]
        病历删除 = 0,
        [Description("病历查看")]
        病历查看,
        [Description("病历内容变化")]
        病历内容变化,
        [Description("病历修改")]
        病历修改,
        [Description("审核操作")]
        审核操作
    }

    public enum udeUserModulePopedom
    {
        [Description("Browse")]
        Browse = 1,

        [Description("Add")]
        Add,

        [Description("Modify")]
        Modify,

        [Description("Delete")]
        Delete,

        [Description("Check")]
        Check,

        [Description("Public")]
        Public,

        [Description("Location")]
        Location,

        [Description("Other")]
        Other,

        [Description("Doctor")]
        Doctor,

        [Description("User")]
        User,

        [Description("Personal")]
        Personal,

        [Description("NuEmr")]
        NuEmr,

        [Description("View")]
        View,
        [Description("Update")]
        Update
    };

    /// <summary>
    /// 手术状态
    /// </summary>
    public enum EnumApplyType
    {
        [Description("全部")]
        All = 0,

        [Description("未安排")]
        NotScheduled = 1,

        [Description("已安排")]
        Scheduled = 2,

        [Description("完成")]
        Complete = 3,

        [Description("正在手术")]
        InOperation = 4,

        [Description("手术结束")]
        EndOfOperation = 5
    }
    /// <summary>  
    /// 角色：1-医师助手；2-洗手护士；3-巡回护士；4-器械师  ,5-麻醉助手,6-管理者
    /// </summary>  
    public enum EnumLsRole
    {
        [Description("医师助手")]
        PhysicianAssistant = 1,

        [Description("洗手护士")]
        HandWashingNurse = 2,

        [Description("巡回护士")]
        CircuitNurse = 3,

        [Description("器械师")]
        Mechanic = 4,

        [Description("麻醉助手")]
        AnesthesiaAssistant = 5,

        [Description("麻醉医师")]
        TheAnesthesiologist = 6,

        [Description("管理者")]
        Manager = 7

    }

    /// <summary>
    /// 病种类型
    /// </summary>
    public enum EnumDiseasesTypes
    {
        [Description("普通病种")]
        Common = 1,
        [Description("单病种")]
        Single = 2,
        [Description("特殊病种")]
        Special = 3,
        [Description("综合病种")]
        Comprehensive = 4,
        [Description("工伤病种")]
        Injury = 5,
        [Description("儿童普通病种")]
        CommonOfChildren = 6,
        [Description("儿童手术类病种")]
        SurgicalOfChildren = 7,
        [Description("顺产")]
        Delivery = 8,
        [Description("剖腹产")]
        CaesareanBirth = 9,
        [Description("难产")]
        Dystocia = 10,
        [Description("终止妊娠")]
        TerminalPregnancy = 11,
        [Description("流产安胎")]
        TocolysisAbortion = 12,
        [Description("妊娠合并疾病")]
        ConcomitantOfPregnancy = 13,
        [Description("生育类的其他病种")]
        OtherOfFamily = 14,
        [Description("上环")]
        SheungWan = 15,
        [Description("取环")]
        TakeTheRring = 16,
        [Description("结扎")]
        Ligation = 17,
        [Description("生育特殊病种")]
        SpecialOfBirth = 18
    }
    /// <summary>
    /// 睡眠障碍：1-无；2-入睡困难；3-早醒；4-梦游
    /// </summary>
    public enum EnumLsSleepTrouble
    {
        [Description("无")]
        Nothing = 1,

        [Description("入睡困难")]
        SleepDifficulties = 2,

        [Description("早醒")]
        WakeEarly = 3,

        [Description("梦游")]
        Sleepwalking = 4,

    }


    /// <summary>
    /// 体育锻炼：1-不锻炼；2-每周<3次；3-每周3次以上；4-无规律
    /// </summary>
    public enum EnumLsSport
    {
        [Description("不锻炼")]
        NoExercise = 1,

        [Description("每周<3次")]
        LessThanThreeTimemAWeek = 2,

        [Description("每周3次以上")]
        MoreThanThreeTimesAWeek = 3,

        [Description("无规律")]
        Irregular = 4,

    }

    public enum EnumLsReasonType
    {
        [Description("提前")]
        InAdvance = 1,

        [Description("推迟")]
        Delay = 2,

        [Description("新增")]
        Insert = 3,

        [Description("未做")]
        NotDone = 4,

    }

    public enum EnumCallTypeWay
    {
        [Description("等待就诊")]
        WaitingForDoctor = 1,

        [Description("呼叫就诊")]
        CallForMedicalAdvice = 2,

        [Description("挂起")]
        Hang = 3

    }

    /// <summary>
    /// 检验项目分类
    /// </summary>
    public enum EnumLsGroup
    {
        [Description("测试组")]
        Group = 1,

        [Description("测试集")]
        Profile = 2,

        [Description("单项")]
        Test = 3
    }

    /// <summary>
    /// 临时收费表的费用来源
    /// </summary>
    public enum EnumInFeeWorkActType
    {
        [Description("执行/保存医嘱")]
        AdviceExec = 1,
        [Description("药房发药插帐")]
        FixTimeRun,

        [Description("每晚定时插帐")]
        FunctionLocation,

        [Description("医技收费")]
        OPSLocation,

        [Description("麻醉手术收费")]
        OutHospital,

        [Description("出院确认插帐")]
        ChangeLocation,
        /// <summary>
        /// 转科确认插帐
    }
    /// <summary>  
    /// 窗口类型：1-针剂；2-口服；3-急诊 
    /// </summary>  
    public enum EnumWindowType
    {
        /// <summary>  
        /// 1-针剂
        /// </summary>  
        [Description("针剂")]
        Injection = 1,
        /// <summary>  
        /// 2-口服  
        /// </summary>  
        [Description("口服")]
        Orally = 2,
        /// <summary>  
        /// 3-急诊  
        /// </summary>  
        [Description("急诊")]
        EmergencyCall = 3
    }

    public enum EnumPrintStatus
    {
        No = 1,
        Yes,
    }



    /// <summary>  
    /// CTRUST/RPR：1-没检测；2-阴性；3-阳性  
    /// </summary>  
    public enum EnumLsCTrust
    {
        [Description("没检测")]
        NotDetected = 1,

        [Description("阴性")]
        Negative = 2,

        [Description("阳性")]
        Positive = 3
    }

    #region EnumSendStatus [发药状态]
    /// <summary>
    /// EnumInDrugRecipeIssueStatus [发药状态：1-已发；2-未发]
    /// </summary>
    public enum EnumIssueStatus
    {
        [Description("已发")]
        Issue = 1,

        [Description("未发")]
        NoIssue = 2

        // [Description("3-全部")]
        //All = 3
    }
    /// <summary>
    /// EnumInDrugRecipeIssueStatus [发药状态：1-已发；2-未发；3-部分发]
    /// </summary>
    public enum EnumInDrugRecipeIssueStatus
    {
        [Description("已发")]
        Issue = 1,

        [Description("未发")]
        NoIssue = 2,

        [Description("部分发")]
        IssueSome = 3
    }
    #endregion


    /// <summary>
    /// 定义基本药物类型
    /// </summary>
    public enum EnumBaseDrugType
    {
        [Description("国基")]
        GJ = 1,

        [Description("省基")]
        SJ = 2,

        [Description("非基")]
        FJ = 3,

        [Description("非基")]
        ALL = 99
    }

    public enum EnumYesNoAll
    {
        [Description("全部")]
        All = 2,

        [Description("是")]
        Yes = 1,

        [Description("否")]
        No = 0
    }

    /// <summary>
    /// EnumOuCheckRecipeSource [来源：全部，门诊，住院，体检]
    /// </summary>
    public enum EnumOuCheckRecipeSource
    {
        [Description("全部")]
        All = 1,

        [Description("门诊")]
        OutpatientService,

        [Description("住院")]
        Hospitalization,

        [Description("体检")]
        PhysicalExamination
    }

    /// <summary>  
    /// 报卡类别：1-发病报告；2-初次报告；3-订正报告；4-出院报告；5-死亡报告  
    /// </summary>  
    public enum EnumLsCardType
    {
        [Description("发病报告")]
        IncidenceReport = 1,

        [Description("初次报告")]
        InitialReport = 2,

        [Description("订正报告")]
        RevisedReport = 3,

        [Description("出院报告")]
        DischargeReport = 4,

        [Description("死亡报告")]
        DeathReport = 5
    }


    /// <summary>  
    /// 户籍类型：1-常住户籍；2-常住非户籍；3-暂住户籍；4-流动  
    /// </summary>  
    public enum EnumLsCensus
    {
        [Description("常住户籍")]
        PermanentResidence = 1,

        [Description("常住非户籍")]
        PermanentNonResidence = 2,

        [Description("暂住户籍")]
        TemporaryResidenceRegistration = 3,

        [Description("流动")]
        Flow = 4
    }

    /// <summary>  
    /// 伤害发生地点：1-家中；2-公共居住场所；3-学校与公共场所；4-体育和运动场所；5-公路/街道；6-贸易和服务场所；7-工业和建筑场所；8-农场/农田；9-其他；10-不清楚  
    /// </summary>  
    public enum EnumLsIllBase
    {
        [Description("临床")]
        Clinical = 1,

        [Description("X线 CT超声内窥镜 ")]
        XRayCTUltrasonicEndoscope = 2,

        [Description("手术 尸检（无病理）")]
        SurgicalAutopsyShowedNoPathology = 3,

        [Description("生化免疫")]
        BiochemicalImmunity = 4,

        [Description("细胞学血片")]
        CytologicBloodSheet = 5,

        [Description("病理（原发）")]
        PathologicalPrimary = 6,

        [Description("病理（继发）")]
        PathologicalSecondary = 7,

        [Description("尸检（有病理）")]
        AutopsyHasPathology = 8,

        [Description("不详")]
        Unknown = 9,

        [Description("死亡补发病 ")]
        DeathRecurrence = 0
    }

    public enum EnumIswriteStatus
    {
        [Description("未审核")]
        NotAuth = 1,

        [Description("已审核")]
        Auth = 2,

        [Description("退卡")]
        Cancel = 3,

        [Description("删除")]
        Delete = 4,
        /// <summary>
        /// 5-未书写
        /// </summary>
        NotWritten = 5

    }


    /// <summary>
    /// 会员费用支出方式：0-非支出;1-门诊挂号;2-门诊收费;3-办卡消费(不走业务)
    /// </summary>
    public enum EnumLsVipChaFromType
    {
        [Description("非支出")]
        NonExpenditure = 0,
        [Description("门诊挂号")]
        OutpatientRegistration = 1,
        [Description("门诊收费")]
        OutpatientCharge = 2,
        [Description("办卡消费")]
        CardHandlingConsumption = 3
    }


    public enum EnumIDType
    {

        [Description("余额")]
        Balance = 1,

        [Description("积分")]
        Integral = 2

    }

    /// <summary>
    /// 会员费用操作方式
    /// </summary>
    public enum EnumVipOperType
    {
        [Description("充值")]
        TopUps = 0,
        [Description("退款")]
        Refund = 1,
        [Description("赠送")]
        GiveAsAPresent = 2,
        [Description("支出")]
        Expenditure = 3
    }

    #region EnumUsageItemUsageUseArea [特定用途]
    /// <summary>
    /// EnumBsUsageItemLsUseArea [特定用途：1-门诊；2-住院；3-所有]
    /// </summary>
    public enum EnumUsageItemUsageUseArea
    {
        [Description("门诊")]
        OutPatient = 1,

        [Description("住院")]
        InPatient = 2,

        [Description("所有")]
        All = 3
    }
    #endregion

    /// <summary>
    /// EnumAdviceTypeForSearch 
    /// </summary>
    public enum EnumAdviceTypeForSearch
    {
        [Description("全部")]
        All = 0,

        [Description("长嘱")]
        Long = 1,

        [Description("临嘱")]
        Temp = 2,

        [Description("出院带药")]
        TakeOut = 3
    }

    /// <summary>
    /// EnumAdviceTypeForSearch 
    /// </summary>
    public enum EnumAdviceTypeTallySystem
    {
        [Description("全部")]
        All = 0,

        [Description("长嘱")]
        Long = 1,

        [Description("临嘱")]
        Temp = 2,

        [Description("出院带药")]
        TakeOut = 3,

        [Description("护嘱")]
        AdviceNurse = 12
    }

    #endregion

    //系统参数重要级别：1-必须;2-次要;3-可选
    public enum EnumLsImportantLevel
    {
        [Description("重要")]
        Important = 1,
        [Description("次要")]
        Secondary = 2,
        [Description("可选")]
        Optional = 3
    }

    /// <summary>
    /// 设备文件类型
    /// </summary>
    public enum EnumDeviceFileType
    {
        [Description("合同")]
        Contract = 1,

        [Description("附件")]
        Enclosure = 2,

        [Description("扫描件")]
        Scanning = 3
    }


    /// <summary>  
    /// 执行单类：1-长期；2-临时；3-其他；4-床位；5-出院带药  
    /// </summary>  
    public enum EnumLsMarkType
    {
        [Description("长期")]
        LongTerm = 1,

        [Description("临时")]
        Temporary = 2,

        [Description("其他")]
        Other = 3,

        [Description("床位")]
        Beds = 4,

        [Description("出院带药")]
        DischargeWithMedicine = 5
    }
    #region 健康体检

    /// <summary>
    ///    TabIndexOne  （  0 采集 1 接受 2 匹配仪器流水号 3 质控项目 ）
    /// </summary>
    public enum EnumTabIndexOne
    {
        采集 = 0,
        接受 = 1,
        匹配仪器流水号 = 2,
        质控项目 = 3
    }

    /// <summary>
    /// 心律
    /// </summary>
    public enum EnumRhythm
    {
        齐 = 1,
        不齐 = 2,
        绝对不齐 = 3
    }

    /// <summary>
    /// 自我评估
    /// </summary>
    public enum EnumStatusAssessment
    {
        满意 = 1,
        基本满意 = 2,
        说不清楚 = 3,
        不太清楚 = 4,
        不满意 = 5
    }

    /// <summary>
    /// 自我照顾程度
    /// </summary>
    public enum EnumSelfCare
    {
        可自理 = 1,
        轻度依赖 = 2,
        中度依赖 = 3,
        不能自理 = 4
    }

    public enum EnumCognitionScore
    {
        粗筛阴性 = 1,
        粗筛阳性 = 2
    }

    /// <summary>
    /// 酒类型
    /// </summary>
    public enum EnumAlcoholType
    {
        白酒 = 1,
        啤酒 = 2,
        红酒 = 3,
        黄酒 = 4
    }

    /// <summary>
    /// 饮食习惯
    /// </summary>
    public enum EnumDietType
    {
        荤素均衡 = 1,
        荤食 = 2,
        素食 = 3,
        嗜盐 = 4,
        嗜油 = 5,
        嗜糖 = 6
    }

    /// <summary>
    /// 口唇
    /// </summary>
    public enum EnumLips
    {
        红润 = 1,
        苍白 = 2,
        发绀 = 3,
        皲裂 = 4,
        疱疹 = 5
    }

    /// <summary>
    /// 牙齿情况
    /// </summary>
    public enum EnumDentition
    {
        正常 = 1,
        缺齿 = 2,
        龋齿 = 3,
        义齿 = 4
    }

    /// <summary>
    /// 咽腔
    /// </summary>
    public enum EnumPharynx
    {
        无充血 = 1,
        充血 = 2,
        淋巴滤泡增生 = 3
    }

    /// <summary>
    /// 皮肤
    /// </summary>
    public enum EnumSkin
    {
        正常 = 1,
        潮红 = 2,
        苍白 = 3,
        发绀 = 4,
        黄染 = 5,
        色素沉着 = 6
    }

    /// <summary>
    /// 巩膜
    /// </summary>
    public enum EnumGongMo
    {
        正常 = 1,
        黄染 = 2,
        充血 = 3
    }

    /// <summary>
    /// 淋巴结
    /// </summary>
    public enum EnumLinBaJie
    {
        未触及 = 1,
        锁骨上 = 2,
        腋窝 = 3
    }

    /// <summary>
    /// 啰音
    /// </summary>
    public enum EnumLuoYin
    {
        无 = 1,
        干啰音 = 2,
        湿罗音 = 3
    }

    /// <summary>
    /// 下肢水肿
    /// </summary>
    public enum EnumLowerShuiZhong
    {
        无 = 1,
        单侧 = 2,
        双侧不对称 = 3,
        双侧对称 = 4
    }

    /// <summary>
    /// 足背动脉搏动
    /// </summary>
    public enum EnumDongMai
    {
        未触及 = 1,
        触及及双侧对称 = 2,
        触及左侧弱或消失 = 3,
        触及右侧弱或消失 = 4
    }

    /// <summary>
    /// 肛门指诊
    /// </summary>
    public enum EnumGangMeng
    {
        未见异常 = 1,
        触痛 = 2,
        包块 = 3,
        前列腺异常 = 4
    }

    /// <summary>
    /// 乳腺
    /// </summary>
    public enum EnumRuXian
    {
        未见异常 = 1,
        乳房切除 = 2,
        异常泌乳 = 3,
        乳腺包块 = 4
    }

    /// <summary>
    /// 脑血管疾病
    /// </summary>
    public enum EnumNaoXueGuan
    {
        未发现 = 1,
        缺血性脑卒中 = 2,
        脑出血 = 3,
        蛛网膜下腔出血 = 4,
        短暂性脑缺血发作 = 5
    }

    /// <summary>
    /// 肾脏疾病
    /// </summary>
    public enum EnumShenZang
    {
        未发现 = 1,
        糖尿病肾病 = 2,
        肾衰竭 = 3,
        急性肾炎 = 4,
        慢性肾炎 = 5
    }

    /// <summary>
    /// TabIndex  4  治疗项目 3 其他项目 2 化验项目 1 中药项目 0 西药项目
    /// </summary>
    public enum EnumRecipeTabIndex
    {
        西药项目 = 0,
        中药项目 = 1,
        化验项目 = 2,
        其他项目 = 3,
        治疗项目 = 4
    }

    /// <summary>
    /// 心脏疾病
    /// </summary>
    public enum EnumXinZang
    {
        未发现 = 1,
        心肌梗死 = 2,
        心绞痛 = 3,
        冠状动脉血运重建 = 4,
        充血性心力衰竭 = 5,
        心前区疼痛 = 6
    }

    /// <summary>
    /// 血管疾病
    /// </summary>
    public enum EnumXueGuan
    {
        未发现 = 1,
        夹层动脉瘤 = 2,
        动脉闭塞性疾病 = 3
    }

    /// <summary>
    /// 眼部疾病
    /// </summary>
    public enum EnumYanBu
    {
        未发现 = 1,
        视网膜出血或渗出 = 2,
        视乳头水肿 = 3,
        白内障 = 4

    }

    /// <summary>
    /// 危险因素控制
    /// </summary>
    public enum EnumDangerControl
    {
        戒烟 = 1,
        健康饮酒 = 2,
        饮食 = 3,
        锻炼 = 4,
        减体重 = 5,
        建议接种疫苗 = 6
    }

    /// <summary>
    /// 吸烟状况
    /// </summary>
    public enum EnumSmokeStatus
    {
        从不吸烟 = 1,
        已戒烟 = 2,
        吸烟 = 3
    }

    /// <summary>
    /// 饮酒频率
    /// </summary>
    public enum EnumAlcoholRate
    {
        从不 = 1,
        偶尔 = 2,
        经常 = 3,
        每天 = 4
    }

    /// <summary>
    /// 听力
    /// </summary>
    public enum EnumHearing
    {
        听见 = 0,
        听不清或无法听不见 = 1
    }

    /// <summary>
    /// 运动功能
    /// </summary>
    public enum EnumMotorFunction
    {
        可顺利完成 = 0,
        无法独立完成其中任何一个动作 = 1
    }

    /// <summary>
    /// 太极
    /// </summary>
    public enum EnumTaiChi
    {
        阴性 = 1,
        阳性 = 2
    }

    /// <summary>
    /// 药库枚举
    /// </summary>
    public enum AuditTypeEnum
    {
        /// <summary>
        /// 药库
        /// </summary>
        HuAudit,
        /// <summary>
        /// 药房
        /// </summary>
        RmAudit
    }

    /// <summary>
    /// 两个日志查询 枚举类型
    /// </summary>
    public enum LogTypeEnum
    {
        /// <summary>
        /// 药库日志查询
        /// </summary>
        HuLog,
        /// <summary>
        /// 药房日志查询
        /// </summary>
        RmLog
    }

    public enum StoresTypeEnum
    {
        /// <summary>
        /// 药库库存查询
        /// </summary>
        HuStores,
        /// <summary>
        /// 药房库存查询
        /// </summary>
        RmStores
    }

    /// <summary>
    /// 病人详情选项卡
    /// </summary>
    public enum EnumPatientDetails
    {
        病人资料 = 0,
        就诊情况 = 1,
        收费情况 = 4,
        报告文件 = 5,
        文件加载 = 10
    }

    /// <summary>
    /// 系统产品类型 0 公共，1 his， 2 行心云
    /// </summary>
    public enum EnumSystemProductType
    {
        PublicType = 0,
        HisType = 1,
        OrmType = 2
    }

    #endregion

    #region 类
    /// <summary>
    /// 星期类
    /// </summary>
    public class WeekDayClass
    {
        public void Fill(System.Data.IDataReader dr)
        {
            throw new System.Exception("The method or operation is not implemented.");
        }

        private int _guid;
        public int GUID
        {
            get { return _guid; }
            set { _guid = value; }
        }

        private string _key;
        public string Key
        {
            set { _key = value; }
            get { return _key; }
        }

        private int _value;
        public int Value
        {
            set { _value = value; }
            get { return _value; }
        }

        private string _desc;
        public string Desc
        {
            set { _desc = value; }
            get { return _desc; }
        }
    }

    public class EnumStruct
    {
        public string GUID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
    }

    public class EnumDesc
    {
        private static Hashtable ht;
        public static string GetDesc(System.Reflection.FieldInfo field)
        {
            if (ht == null)
            {
                ht = new System.Collections.Hashtable();
                ht.Add(GetEnumFullName(EnumSex.M), "男");
                ht.Add(GetEnumFullName(EnumSex.F), "女");

                // 工单紧急程度
                ht.Add(GetEnumFullName(EnumOrderLive.一般), "一般");
                ht.Add(GetEnumFullName(EnumOrderLive.紧急), "紧急");

                // 工单状态
                ht.Add(GetEnumFullName(EnumOrderStart.未派单), "未派单");
                ht.Add(GetEnumFullName(EnumOrderStart.已派单), "已派单");

                // 工单类别
                ht.Add(GetEnumFullName(EnumOrderType.SOS紧急求助), "SOS紧急求助");
                ht.Add(GetEnumFullName(EnumOrderType.回访工单), "回访工单");
                ht.Add(GetEnumFullName(EnumOrderType.固定计划排单), "固定计划排单");
                ht.Add(GetEnumFullName(EnumOrderType.投诉工单), "投诉工单");

                //紧急程度
                ht.Add(GetEnumFullName(EnumEmergencyDegree.一般), "一般");
                ht.Add(GetEnumFullName(EnumEmergencyDegree.急), "急");
                ht.Add(GetEnumFullName(EnumEmergencyDegree.紧急), "紧急");

                // 支付状态
                ht.Add(GetEnumFullName(EnumLsPayStart.未支付), "未支付");
                ht.Add(GetEnumFullName(EnumLsPayStart.已支付), "已支付");

                // 支付方式
                ht.Add(GetEnumFullName(EnumLsPayType.现金), "现金");
                ht.Add(GetEnumFullName(EnumLsPayType.支票), "支票");
                ht.Add(GetEnumFullName(EnumLsPayType.其他), "其他");
                ht.Add(GetEnumFullName(EnumLsPayType.减免类), "减免类");
                ht.Add(GetEnumFullName(EnumLsPayType.分娩补助), "分娩补助");
                ht.Add(GetEnumFullName(EnumLsPayType.医保卡), "医保卡");
                ht.Add(GetEnumFullName(EnumLsPayType.单位挂账), "转账");
                ht.Add(GetEnumFullName(EnumLsPayType.合作医疗), "合作医疗");
                ht.Add(GetEnumFullName(EnumLsPayType.计生发票), "计生发票");
                ht.Add(GetEnumFullName(EnumLsPayType.银联卡), "银联卡");

                ht.Add(GetEnumFullName(EnumInputWay.Phoneticize), "拼音");
                ht.Add(GetEnumFullName(EnumInputWay.WuBi), "五笔");

                ht.Add(GetEnumFullName(RoomInOutEnum.ForOutPatient), "门诊");
                ht.Add(GetEnumFullName(RoomInOutEnum.ForInPatient), "住院");
                ht.Add(GetEnumFullName(RoomInOutEnum.Other), "其他");

                //ht.Add(GetEnumFullName(EnumLsPreventive.全种), "全种");
                //ht.Add(GetEnumFullName(EnumLsPreventive.部分), "部分");
                //ht.Add(GetEnumFullName(EnumLsPreventive.未种), "未种");

                ht.Add(GetEnumFullName(TextBoxTypeEnum.String), "字符");
                ht.Add(GetEnumFullName(TextBoxTypeEnum.NumDiscount), "折扣");

                ht.Add(GetEnumFullName(EnumTmpWordDetailLsOpenType.个人), "个人");
                ht.Add(GetEnumFullName(EnumTmpWordDetailLsOpenType.科室), "科室");
                ht.Add(GetEnumFullName(EnumTmpWordDetailLsOpenType.公共), "公共");


                ht.Add(GetEnumFullName(EnumTmpLsOpenType.ForPersonal), "个人");
                ht.Add(GetEnumFullName(EnumTmpLsOpenType.ForSection), "诊所");
                ht.Add(GetEnumFullName(EnumTmpLsOpenType.Commonality), "公共");

                ht.Add(GetEnumFullName(HuActTypeEnum.RK), "采购入库");
                ht.Add(GetEnumFullName(HuActTypeEnum.DB), "调拨出房");
                ht.Add(GetEnumFullName(HuActTypeEnum.TH), "退货出库");
                ht.Add(GetEnumFullName(HuActTypeEnum.BS), "报损出库");
                ht.Add(GetEnumFullName(HuActTypeEnum.OT), "其他入库");
                ht.Add(GetEnumFullName(HuActTypeEnum.CK), "领药出库");
                ht.Add(GetEnumFullName(HuActTypeEnum.SL), "其他出库");
                ht.Add(GetEnumFullName(HuActTypeEnum.PY), "盘盈入库");
                ht.Add(GetEnumFullName(HuActTypeEnum.PK), "盘亏出库");
                ht.Add(GetEnumFullName(HuActTypeEnum.TK), "药房退药");
                ht.Add(GetEnumFullName(HuActTypeEnum.PO), "收费出库");
                ht.Add(GetEnumFullName(HuActTypeEnum.CI), "作废收费入库");

                //ht.Add(GetEnumFullName(EnumLsClincType.初诊), "初诊");
                //ht.Add(GetEnumFullName(EnumLsClincType.复诊), "复诊");
                //ht.Add(GetEnumFullName(EnumLsClincType.急性发作), "急性发作");

                //ht.Add(GetEnumFullName(EnumLsCureType.MainTreatment), "主要诊疗工作");
                //ht.Add(GetEnumFullName(EnumLsCureType.EmphasisAdvice), "重点医嘱");
                //ht.Add(GetEnumFullName(EnumLsCureType.PrimaryCare), "主要护理工作");

                ht.Add(GetEnumFullName(EnumFollowType.复诊提醒), "复诊提醒");
                ht.Add(GetEnumFullName(EnumFollowType.健康教育), "健康教育");
                ht.Add(GetEnumFullName(EnumFollowType.诊后关怀), "诊后关怀");
                ht.Add(GetEnumFullName(EnumFollowType.病情跟踪), "病情跟踪");
                ht.Add(GetEnumFullName(EnumFollowType.满意度调查), "满意度调查");
                ht.Add(GetEnumFullName(EnumFollowType.用药提示), "用药提示");

                //ht.Add(GetEnumFullName(EnumLsIllnessAim.治牙), "治牙");
                ht.Add(GetEnumFullName(EnumLsIllnessAim.洁牙), "洁牙");
                ht.Add(GetEnumFullName(EnumLsIllnessAim.拔牙), "拔牙");
                ht.Add(GetEnumFullName(EnumLsIllnessAim.镶牙), "镶牙");
                ht.Add(GetEnumFullName(EnumLsIllnessAim.定期检查), "定期检查");
                ht.Add(GetEnumFullName(EnumLsIllnessAim.修复治疗), "修复治疗");
                ht.Add(GetEnumFullName(EnumLsIllnessAim.牙周治疗), "牙周治疗");
                ht.Add(GetEnumFullName(EnumLsIllnessAim.正畸治疗), "正畸治疗");
                ht.Add(GetEnumFullName(EnumLsIllnessAim.种植治疗), "种植治疗");

                ht.Add(GetEnumFullName(EnumRmActType.OF), "其它入房");
                ht.Add(GetEnumFullName(EnumRmActType.DB), "调拨出房");
                ht.Add(GetEnumFullName(EnumRmActType.TK), "退药出房");
                ht.Add(GetEnumFullName(EnumRmActType.FS), "报损出房");
                ht.Add(GetEnumFullName(EnumRmActType.FO), "其它出房");
                ht.Add(GetEnumFullName(EnumRmActType.PY), "盘盈入房");
                ht.Add(GetEnumFullName(EnumRmActType.PK), "盘亏出房");
                ht.Add(GetEnumFullName(EnumRmActType.KS), "科室领药");
                ht.Add(GetEnumFullName(EnumRmActType.KB), "科室退药");
                ht.Add(GetEnumFullName(EnumRmActType.BQ), "病区发药");
                ht.Add(GetEnumFullName(EnumRmActType.CF), "门诊发药");
                ht.Add(GetEnumFullName(EnumRmActType.QB), "病区退药");
                ht.Add(GetEnumFullName(EnumRmActType.FB), "门诊退药");
                //ht.Add(GetEnumFullName(EnumRmActType.FQ), "领药申请");
                ht.Add(GetEnumFullName(EnumRmActType.FR), "药品入房");
                ht.Add(GetEnumFullName(EnumRmActType.DR), "调拨入房");

                ht.Add(GetEnumFullName(EnumLsPeriod.新婚期), "新婚期");
                ht.Add(GetEnumFullName(EnumLsPeriod.首孩出生期), "首孩出生期");
                ht.Add(GetEnumFullName(EnumLsPeriod.学龄前儿童期), "学龄前儿童期");
                ht.Add(GetEnumFullName(EnumLsPeriod.学龄儿童期), "学龄儿童期");
                ht.Add(GetEnumFullName(EnumLsPeriod.青少年期), "青少年期");
                ht.Add(GetEnumFullName(EnumLsPeriod.孩子离家创业期), "孩子离家创业期");
                ht.Add(GetEnumFullName(EnumLsPeriod.空巢期), "空巢期");
                ht.Add(GetEnumFullName(EnumLsPeriod.退休期), "退休期");


                ht.Add(GetEnumFullName(EnumWeekDay.MD), "星期一");
                ht.Add(GetEnumFullName(EnumWeekDay.TD), "星期二");
                ht.Add(GetEnumFullName(EnumWeekDay.WD), "星期三");
                ht.Add(GetEnumFullName(EnumWeekDay.TUD), "星期四");
                ht.Add(GetEnumFullName(EnumWeekDay.FD), "星期五");
                ht.Add(GetEnumFullName(EnumWeekDay.STD), "星期六");
                ht.Add(GetEnumFullName(EnumWeekDay.SUD), "星期日");

                ht.Add(GetEnumFullName(EnumAttachment.旧牙), "旧牙");
                ht.Add(GetEnumFullName(EnumAttachment.咬合蜡), "咬合蜡");
                ht.Add(GetEnumFullName(EnumAttachment.原摸), "原摸");
                ht.Add(GetEnumFullName(EnumAttachment.照片), "照片");
                ht.Add(GetEnumFullName(EnumAttachment.数据), "数据");

                ht.Add(GetEnumFullName(EnumLsFamilyType.核心家庭), "核心家庭");
                ht.Add(GetEnumFullName(EnumLsFamilyType.主干家庭), "主干家庭");
                ht.Add(GetEnumFullName(EnumLsFamilyType.联合家庭), "联合家庭");
                ht.Add(GetEnumFullName(EnumLsFamilyType.单身家庭), "单身家庭");
                ht.Add(GetEnumFullName(EnumLsFamilyType.单亲家庭), "单亲家庭");
                ht.Add(GetEnumFullName(EnumLsFamilyType.群居家庭), "群居家庭");
                ht.Add(GetEnumFullName(EnumLsFamilyType.同居家庭), "同居家庭");
                ht.Add(GetEnumFullName(EnumLsFamilyType.同性恋家庭), "同性恋家庭");
                ht.Add(GetEnumFullName(EnumLsFamilyType.其他家庭类型), "其他家庭类型");

                ht.Add(GetEnumFullName(EnumEmergencyType.急件), "急件");
                ht.Add(GetEnumFullName(EnumEmergencyType.五天件), "5天件");
                ht.Add(GetEnumFullName(EnumEmergencyType.七天件), "7天件");

                ht.Add(GetEnumFullName(EnumStatusAssessment.满意), "满意");
                ht.Add(GetEnumFullName(EnumStatusAssessment.基本满意), "基本满意");
                ht.Add(GetEnumFullName(EnumStatusAssessment.说不清楚), "说不清楚");
                ht.Add(GetEnumFullName(EnumStatusAssessment.不太清楚), "不太清楚");
                ht.Add(GetEnumFullName(EnumStatusAssessment.不满意), "不满意");

                ht.Add(GetEnumFullName(EnumAlcoholType.白酒), "白酒");
                ht.Add(GetEnumFullName(EnumAlcoholType.啤酒), "啤酒");
                ht.Add(GetEnumFullName(EnumAlcoholType.红酒), "红酒");
                ht.Add(GetEnumFullName(EnumAlcoholType.黄酒), "黄酒");

                ht.Add(GetEnumFullName(EnumDietType.荤素均衡), "荤素均衡");
                ht.Add(GetEnumFullName(EnumDietType.荤食), "荤食");
                ht.Add(GetEnumFullName(EnumDietType.素食), "素食");
                ht.Add(GetEnumFullName(EnumDietType.嗜盐), "嗜盐");
                ht.Add(GetEnumFullName(EnumDietType.嗜油), "嗜油");
                ht.Add(GetEnumFullName(EnumDietType.嗜糖), "嗜糖");

                ht.Add(GetEnumFullName(EnumSelfCare.可自理), "可自理");
                ht.Add(GetEnumFullName(EnumSelfCare.轻度依赖), "轻度依赖");
                ht.Add(GetEnumFullName(EnumSelfCare.中度依赖), "中度依赖");
                ht.Add(GetEnumFullName(EnumSelfCare.不能自理), "不能自理");

                ht.Add(GetEnumFullName(EnumCognitionScore.粗筛阴性), "粗筛阴性");
                ht.Add(GetEnumFullName(EnumCognitionScore.粗筛阳性), "粗筛阳性");

                ht.Add(GetEnumFullName(EnumLips.红润), "红润");
                ht.Add(GetEnumFullName(EnumLips.苍白), "苍白");
                ht.Add(GetEnumFullName(EnumLips.发绀), "发绀");
                ht.Add(GetEnumFullName(EnumLips.皲裂), "皲裂");
                ht.Add(GetEnumFullName(EnumLips.疱疹), "疱疹");

                ht.Add(GetEnumFullName(EnumDentition.正常), "正常");
                ht.Add(GetEnumFullName(EnumDentition.缺齿), "缺齿");
                ht.Add(GetEnumFullName(EnumDentition.龋齿), "龋齿");
                ht.Add(GetEnumFullName(EnumDentition.义齿), "义齿");

                ht.Add(GetEnumFullName(EnumPharynx.无充血), "无充血");
                ht.Add(GetEnumFullName(EnumPharynx.充血), "充血");
                ht.Add(GetEnumFullName(EnumPharynx.淋巴滤泡增生), "淋巴滤泡增生");

                ht.Add(GetEnumFullName(EnumSkin.正常), "正常");
                ht.Add(GetEnumFullName(EnumSkin.潮红), "潮红");
                ht.Add(GetEnumFullName(EnumSkin.苍白), "苍白");
                ht.Add(GetEnumFullName(EnumSkin.发绀), "发绀");
                ht.Add(GetEnumFullName(EnumSkin.黄染), "黄染");
                ht.Add(GetEnumFullName(EnumSkin.色素沉着), "色素沉着");

                ht.Add(GetEnumFullName(EnumGongMo.正常), "正常");
                ht.Add(GetEnumFullName(EnumGongMo.黄染), "黄染");
                ht.Add(GetEnumFullName(EnumGongMo.充血), "充血");

                ht.Add(GetEnumFullName(EnumLinBaJie.未触及), "未触及");
                ht.Add(GetEnumFullName(EnumLinBaJie.锁骨上), "锁骨上");
                ht.Add(GetEnumFullName(EnumLinBaJie.腋窝), "腋窝");

                ht.Add(GetEnumFullName(EnumLuoYin.无), "无");
                ht.Add(GetEnumFullName(EnumLuoYin.干啰音), "干啰音");
                ht.Add(GetEnumFullName(EnumLuoYin.湿罗音), "湿罗音");

                ht.Add(GetEnumFullName(EnumLowerShuiZhong.无), "无");
                ht.Add(GetEnumFullName(EnumLowerShuiZhong.单侧), "单侧");
                ht.Add(GetEnumFullName(EnumLowerShuiZhong.双侧不对称), "双侧不对称");
                ht.Add(GetEnumFullName(EnumLowerShuiZhong.双侧对称), "双侧对称");

                ht.Add(GetEnumFullName(EnumDongMai.未触及), "未触及");
                ht.Add(GetEnumFullName(EnumDongMai.触及及双侧对称), "触及及双侧对称");
                ht.Add(GetEnumFullName(EnumDongMai.触及左侧弱或消失), "触及左侧弱或消失");
                ht.Add(GetEnumFullName(EnumDongMai.触及右侧弱或消失), "触及右侧弱或消失");

                ht.Add(GetEnumFullName(EnumGangMeng.未见异常), "未见异常");
                ht.Add(GetEnumFullName(EnumGangMeng.触痛), "触痛");
                ht.Add(GetEnumFullName(EnumGangMeng.包块), "包块");
                ht.Add(GetEnumFullName(EnumGangMeng.前列腺异常), "前列腺异常");

                ht.Add(GetEnumFullName(EnumRuXian.未见异常), "未见异常");
                ht.Add(GetEnumFullName(EnumRuXian.乳房切除), "乳房切除");
                ht.Add(GetEnumFullName(EnumRuXian.异常泌乳), "异常泌乳");
                ht.Add(GetEnumFullName(EnumRuXian.乳腺包块), "乳腺包块");

                ht.Add(GetEnumFullName(EnumNaoXueGuan.未发现), "未发现");
                ht.Add(GetEnumFullName(EnumNaoXueGuan.缺血性脑卒中), "缺血性脑卒中");
                ht.Add(GetEnumFullName(EnumNaoXueGuan.脑出血), "脑出血");
                ht.Add(GetEnumFullName(EnumNaoXueGuan.蛛网膜下腔出血), "蛛网膜下腔出血");
                ht.Add(GetEnumFullName(EnumNaoXueGuan.短暂性脑缺血发作), "短暂性脑缺血发作");

                ht.Add(GetEnumFullName(EnumShenZang.未发现), "未发现");
                ht.Add(GetEnumFullName(EnumShenZang.糖尿病肾病), "糖尿病肾病");
                ht.Add(GetEnumFullName(EnumShenZang.肾衰竭), "肾衰竭");
                ht.Add(GetEnumFullName(EnumShenZang.急性肾炎), "急性肾炎");
                ht.Add(GetEnumFullName(EnumShenZang.慢性肾炎), "慢性肾炎");

                ht.Add(GetEnumFullName(EnumXinZang.未发现), "未发现");
                ht.Add(GetEnumFullName(EnumXinZang.心肌梗死), "心肌梗死");
                ht.Add(GetEnumFullName(EnumXinZang.心绞痛), "心绞痛");
                ht.Add(GetEnumFullName(EnumXinZang.冠状动脉血运重建), "冠状动脉血运重建");
                ht.Add(GetEnumFullName(EnumXinZang.充血性心力衰竭), "充血性心力衰竭");
                ht.Add(GetEnumFullName(EnumXinZang.心前区疼痛), "心前区疼痛");

                ht.Add(GetEnumFullName(EnumXueGuan.未发现), "未发现");
                ht.Add(GetEnumFullName(EnumXueGuan.夹层动脉瘤), "夹层动脉瘤");
                ht.Add(GetEnumFullName(EnumXueGuan.动脉闭塞性疾病), "动脉闭塞性疾病");

                ht.Add(GetEnumFullName(EnumYanBu.未发现), "未发现");
                ht.Add(GetEnumFullName(EnumYanBu.视网膜出血或渗出), "视网膜出血或渗出");
                ht.Add(GetEnumFullName(EnumYanBu.视乳头水肿), "视乳头水肿");
                ht.Add(GetEnumFullName(EnumYanBu.白内障), "白内障");

                ht.Add(GetEnumFullName(EnumDangerControl.戒烟), "戒烟");
                ht.Add(GetEnumFullName(EnumDangerControl.健康饮酒), "健康饮酒");
                ht.Add(GetEnumFullName(EnumDangerControl.饮食), "饮食");
                ht.Add(GetEnumFullName(EnumDangerControl.锻炼), "锻炼");
                ht.Add(GetEnumFullName(EnumDangerControl.减体重), "减体重");
                ht.Add(GetEnumFullName(EnumDangerControl.建议接种疫苗), "建议接种疫苗");

                ht.Add(GetEnumFullName(EnumSmokeStatus.从不吸烟), "从不吸烟");
                ht.Add(GetEnumFullName(EnumSmokeStatus.已戒烟), "已戒烟");
                ht.Add(GetEnumFullName(EnumSmokeStatus.吸烟), "吸烟");

                ht.Add(GetEnumFullName(EnumAlcoholRate.从不), "从不");
                ht.Add(GetEnumFullName(EnumAlcoholRate.偶尔), "偶尔");
                ht.Add(GetEnumFullName(EnumAlcoholRate.经常), "经常");
                ht.Add(GetEnumFullName(EnumAlcoholRate.每天), "每天");

                ht.Add(GetEnumFullName(EnumHearing.听见), "听见");
                ht.Add(GetEnumFullName(EnumHearing.听不清或无法听不见), "听不清或无法听不见");

                ht.Add(GetEnumFullName(EnumMotorFunction.可顺利完成), "可顺利完成");
                ht.Add(GetEnumFullName(EnumMotorFunction.无法独立完成其中任何一个动作), "无法独立完成其中任何一个动作");

                ht.Add(GetEnumFullName(EnumRhythm.齐), "齐");
                ht.Add(GetEnumFullName(EnumRhythm.不齐), "不齐");
                ht.Add(GetEnumFullName(EnumRhythm.绝对不齐), "绝对不齐");

                ht.Add(GetEnumFullName(EnumTaiChi.阴性), "阴性");
                ht.Add(GetEnumFullName(EnumTaiChi.阳性), "阳性");

                ht.Add(GetEnumFullName(EnumWorkSheetStatus.未完工), "未完工");
                ht.Add(GetEnumFullName(EnumWorkSheetStatus.已完工), "已完工");
                ht.Add(GetEnumFullName(EnumWorkSheetStatus.已取件), "已取件");
                ht.Add(GetEnumFullName(EnumWorkSheetStatus.已戴走), "已戴走");
                ht.Add(GetEnumFullName(EnumWorkSheetStatus.试戴), "试戴");
                ht.Add(GetEnumFullName(EnumWorkSheetStatus.返工), "返工");

                ht.Add(GetEnumFullName(EnumIDType.Balance), "余额");
                ht.Add(GetEnumFullName(EnumIDType.Integral), "积分");

            }
            object temp = ht[field.FieldType.FullName + "." + field.Name];
            if (temp == null) return string.Empty;
            else return temp.ToString();
        }

        private static string GetEnumFullName(System.Enum eEnum)
        {
            return $"{eEnum.GetType().FullName}.{eEnum.ToString()}";
        }
    }

    /// <summary>
    /// 反射创建枚举集合
    /// </summary>
    public class EumConvertor
    {
        /// <summary>
        /// 缓存已经创建过枚举
        /// </summary>
        private static Dictionary<string, List<WeekDayClass>> dtEnums;
        private static Dictionary<string, List<EnumStruct>> dtEnums2;
        private static Dictionary<string, List<KeyValuePair<string, string>>> KeyValueEnums;
        private static Dictionary<string, List<KeyValuePair<int, string>>> KeyValueIntEnums;
        private static object locker=new object();
        static EumConvertor()
        {
            dtEnums = new Dictionary<string, List<WeekDayClass>>();
            dtEnums2 = new Dictionary<string, List<EnumStruct>>();
            KeyValueEnums = new Dictionary<string, List<KeyValuePair<string, string>>>();
            KeyValueIntEnums = new Dictionary<string, List<KeyValuePair<int, string>>>();
        }

        public static int GetEnumValue(string strEnumKey, string strEnum)
        {
            List<WeekDayClass> list = Convert(strEnum);
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Key.ToLower() == strEnumKey.ToLower()) return list[i].Value;
            }
            return 0;
        }
        public static List<WeekDayClass> Convert(Type enumType)
        {
            return Convert(enumType.FullName);
        }
        public static List<WeekDayClass> Convert(string enumName)
        {
            if (dtEnums.ContainsKey(enumName))
            {
                return dtEnums[enumName];
            }
            else
            {
                System.Type type = System.Type.GetType(enumName);
                List<WeekDayClass> list = new List<WeekDayClass>();
                System.Reflection.FieldInfo[] fields = type.GetFields();
                for (int i = 0; i < fields.Length; i++)
                {
                    if (fields[i].Name.IndexOf("_") >= 0) continue;
                    WeekDayClass obj = new WeekDayClass();
                    obj.Key = fields[i].Name;
                    obj.Value = (int)fields[i].GetRawConstantValue();
                    obj.Desc = EnumDesc.GetDesc(fields[i]);
                    list.Add(obj);
                }
                dtEnums.Add(enumName, list);
                return list;
            }
        }
        
        public static List<EnumStruct> GetEnumToList(string enumName)
        {
            lock (locker)
            {
                if (dtEnums2.ContainsKey(enumName))
                    return dtEnums2[enumName];
                else
                {
                    System.Type type = System.Type.GetType("Orm.Model.EnumDefine." + enumName);
                    List<EnumStruct> list = new List<EnumStruct>();
                    System.Reflection.FieldInfo[] fields = type.GetFields();
                    for (int i = 0; i < fields.Length; i++)
                    {
                        if (fields[i].Name.IndexOf("_") >= 0) continue;
                        EnumStruct obj = new EnumStruct();
                        obj.Code = fields[i].Name;
                        obj.GUID = fields[i].GetRawConstantValue().ToString();
                        obj.Name = EnumDesc.GetDesc(fields[i]);
                        list.Add(obj);
                    }
                    dtEnums2.Add(enumName, list);
                    return list;
                }
          
            }
        }

        /// <summary>
        /// 将枚举字符串类型 转换为键值对的List
        /// </summary>
        /// <param name="enumName"></param>
        /// <returns></returns>
        public static List<KeyValuePair<string, string>> ConvertToKeyValueList(string enumName)
        {
            if (KeyValueEnums.ContainsKey(enumName))
                return KeyValueEnums[enumName];
            else
            {
                try
                {
                    System.Type type = System.Type.GetType(enumName);
                    List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();
                    System.Reflection.FieldInfo[] fields = type.GetFields();
                    for (int i = 0; i < fields.Length; i++)
                    {
                        if (fields[i].Name.IndexOf("_") >= 0) continue;
                        list.Add(new KeyValuePair<string, string>(fields[i].GetRawConstantValue().ToString(), fields[i].Name));
                    }
                    KeyValueEnums.Add(enumName, list);
                    return list;
                }
                catch (Exception ex)
                {
                    throw new Exception(string.Format(" 获取枚举下拉数据失败:枚举{0} \r\n{1} ", enumName, ex.Message));
                }
            }
        }


        /// <summary>
        /// 将枚举  int 类型 转换为键值对的List
        /// </summary>
        /// <param name="enumName"></param>
        /// <returns></returns>
        public static List<KeyValuePair<int, string>> ConvertToKeyIntValueList(string enumName)
        {
            if (KeyValueIntEnums.ContainsKey(enumName))
                return KeyValueIntEnums[enumName];
            else
            {
                try
                {
                    System.Type type = System.Type.GetType(enumName);
                    List<KeyValuePair<int, string>> list = new List<KeyValuePair<int, string>>();
                    System.Reflection.FieldInfo[] fields = type.GetFields();
                    for (int i = 0; i < fields.Length; i++)
                    {
                        if (fields[i].Name.IndexOf("_") >= 0) continue;
                        list.Add(new KeyValuePair<int, string>((int)fields[i].GetRawConstantValue(), fields[i].Name));
                    }
                    KeyValueIntEnums.Add(enumName, list);
                    return list;
                }
                catch (Exception ex)
                {
                    throw new Exception(string.Format(" 获取枚举下拉数据失败:枚举{0} \r\n{1} ", enumName, ex.Message));
                }
            }
        }
        /// <summary>
        /// 枚举转为DataTable
        /// </summary>
        /// <param name="enumName">枚举名称</param>
        /// <returns></returns>
        public static DataTable GetEnumToDataTable(string enumName)
        {
            List<EnumDefine.WeekDayClass> list = EnumDefine.EumConvertor.Convert("Orm.Model.EnumDefine." + enumName);
            DataTable dt = new DataTable();
            dt.Columns.Add("GUID", System.Type.GetType("System.String"));
            dt.Columns.Add("Code", System.Type.GetType("System.String"));
            dt.Columns.Add("Value", System.Type.GetType("System.Int32"));
            dt.Columns.Add("Name", System.Type.GetType("System.String"));
            dt.Columns.Add("IconIndex", System.Type.GetType("System.Int32"));
            if (list == null) return dt;
            for (int i = 0; i < list.Count; i++)
            {
                DataRow dr = dt.NewRow();
                dr["GUID"] = list[i].Value;
                dr["Name"] = list[i].Desc;
                dr["Code"] = list[i].Key;
                dr["IconIndex"] = 0;
                dt.Rows.Add(dr);
            }
            return dt;
        }
        #endregion       

        #region EnumBedStatus [床位状态]
        /// <summary>
        /// EnumBsBedLsBALL [床位状态：1-床位清理；2-占用；3-开放使用；4-污染；5-被隔离；6-禁用]
        /// </summary>
        public enum EnumBedStatus
        {
            [Description("床位清理")]
            Cleaning = 1,

            [Description("占用")]
            Occupy = 2,

            [Description("开放使用")]
            Open = 3,

            [Description("污染")]
            Pollute = 4,

            [Description("被隔离")]
            Isolation = 5,

            [Description("6-禁用")]
            Forbid = 6
        }
        /// <summary>
        /// EnumBedClass [护理等级：1-一级护理；2-二级护理；3-三级护理]
        /// </summary>
        public enum EnumBedClass
        {
            [Description("一级护理")]
            ClassOne = 1,

            [Description("二级护理")]
            ClassTwo = 2,

            [Description("三级护理")]
            ClassThree = 3
        }

        public enum EnumItemTraceType
        {
            [Description("开屏蔽")]
            Active = 1,

            [Description("屏蔽")]
            InActive = 2,

            [Description("新开")]
            AddNew = 3,

            [Description("改规格")]
            ModiSpec = 4,

            [Description("改供应公司")]
            ModiCompany = 5,

            [Description("改厂商")]
            ModiManufacturer = 6,

            [Description("改名称")]
            ModiName = 7,

            [Description("改单位")]
            ModiUnit = 8
        }
        #endregion

        #region EnumDoctorStatus [在职离职状态]
        /// <summary>
        /// EnumBsDoctorLsStatus [在职离职状态：1-在职；2-离职]
        /// </summary>
        public enum EnumDoctorStatus
        {
            [Description("在职")]
            Incumbency = 1,

            [Description("离职")]
            Demission = 2
        }
        #endregion

        public enum EnumDocLevel
        {
            [Description("普通医师")]
            GeneralPractitioner = 0,

            [Description("上级医师")]
            SuperiorPhysician = 1,

            [Description("主任医师")]
            ChiefPhysician = 2
        }
        /// <summary>
        /// Pacs报告状态
        /// </summary>
        public enum EnumPsStatus
        {
            /// <summary>
            /// 未读取
            /// </summary>
            UnRead = 0,
            /// <summary>
            /// 已取消
            /// </summary>
            Cancel = 1,
            /// <summary>
            /// 已读取
            /// </summary>
            PsRead = 2,
            /// <summary>
            /// 读取取消
            /// </summary>
            CancelPsRead = 3,
            /// <summary>
            /// 已预约
            /// </summary>
            Booking = 4,
            /// <summary>
            /// 读取预约
            /// </summary>
            BookingPsRead = 5,
            /// <summary>
            /// 已报到
            /// </summary>
            ToReport = 6,
            /// <summary>
            /// 检查中
            /// </summary>
            Checking = 7,
            /// <summary>
            /// 已检查
            /// </summary>
            Checked = 8,
            /// <summary>
            /// 报告未审核
            /// </summary>
            RportUnHang = 9,
            /// <summary>
            ///报告已审核 
            /// </summary>
            RportHang = 10,
            /// <summary>
            /// 报告被采用
            /// </summary>
            RportUse = 11
        }

        /// <summary>
        /// 诊断类别
        /// </summary>
        public enum EnumLsIllnessType
        {
            [Description("门诊诊断")]
            OutpatientDiagnosis = 1,

            [Description("入院诊断")]
            AdmissionDiagnosis = 2,

            [Description("初步诊断")]
            PreliminaryDiagnosis = 3,

            [Description("转科诊断")]
            SpecialistDiagnosis = 4,

            [Description("其他诊断")]
            OtherDiagnostics = 5,

            [Description("出院诊断")]
            DischargeDiagnosis = 6,

            [Description("补充诊断")]
            SupplementaryDiagnosis = 7,

            [Description("修正诊断")]
            CorrectedDiagnosis = 8,

            [Description("最后诊断")]
            FinalDiagnosis = 9
        }

        

        




      

        #region EnumFeeTurn [长期医嘱附加收费的周期]
        /// <summary>
        /// EnumBsItemLsfeeTurn [限制门诊/住院使用：1-全部；2-门诊；3-住院]
        /// </summary>
        public enum EnumFeeTurn
        {
            [Description("全部")]
            All = 1,

            [Description("门诊")]
            OutPatient = 2,

            [Description("住院")]
            InPatient = 3
        }
        #endregion

       

        

        

        
        

    }

    /// <summary>
    /// 报告类别
    /// </summary>
    public enum EnumXType
    {
        //1-CT；2-DR；3-MR；4-CR；5-RF；6-US；7-脑电图；8-心电图；9-镜检查；10-MG；11-DSA；12-普放；13-病理；14-其它

        [Description("CT")]
        CT = 1,

        [Description("DR")]
        DR = 2,

        [Description("MR")]
        MR = 3,

        [Description("CR")]
        CR = 4,

        [Description("RF")]
        RF = 5,

        [Description("US")]
        US = 6,

        [Description("脑电图")]
        NDT = 7,

        [Description("心电图")]
        XDT = 8,

        [Description("镜检查")]
        JJC = 9,

        [Description("MG")]
        MG = 10,

        [Description("DSA")]
        DSA = 11,

        [Description("普放")]
        PF = 12,

        [Description("病理")]
        BL = 13,

        [Description("其它")]
        OTHER = 14,

        [Description("螺旋CT")]
        SCREWCT = 15,

        [Description("ECT")]
        ECT = 28,

        [Description("BMD")]
        BMD = 29,

        [Description("DGNY")]
        DGNY = 30,
        [Description("XType")]
        XType = 31
    }

    #region EnumCancelType [注销类别]
    /// <summary>
    /// EnumInDepositLsCancelType [注销类别：1-结算；2-退款；3-作废]
    /// </summary>
    public enum EnumCancelType
    {
        [Description("结算")]
        Pay = 1,

        [Description("退款")]
        Refund = 2,

        [Description("作废")]
        Cancel = 3
    }
    #endregion

    #region EnumChargeType [付款类别]
    /// <summary>
    /// EnumInInvoicePayLsChargeType [付款类别：1-按金结算支出；2-按金收入；3-结算收入；4-按金退款支出；5-结算退款支出；5-按金作废支出]
    /// </summary>
    public enum EnumChargeType
    {
        [Description("按金结算支出")]
        DepositPayOut = 1,

        [Description("按金收入")]
        DepositPayIn = 2,

        [Description("结算收入")]
        PayIn = 3,

        [Description("按金退款支出")]
        DepositRefundOut = 4,

        [Description("结算退款支出")]
        PayRefundOut = 5,

        [Description("按金作废支出")]
        DepositCancelOut = 6
    }
    #endregion

    #region EnumBedOperType [床位操作类型]
    /// <summary>
    /// EnumGblBedHistoryLsOperType [床位操作类型：1-入院分配；2-出院；3-死亡；4-转科(出)；5-转科(入)；6-转床(出)；7-转床(入)]
    /// </summary>
    public enum EnumBedOperType
    {
        [Description("入院分配")]
        EnterHospitalAssign = 1,

        [Description("出院")]
        LeaveHospital = 2,

        [Description("死亡")]
        Death = 3,

        [Description("转科(出)")]
        SectionChangeOut = 4,

        [Description("转科(入)")]
        SectionChangeIn = 5,

        [Description("转床(出)")]
        ChangeBedOut = 6,

        [Description("转床(入)")]
        ChangeBedIn = 7
    }
    #endregion/// <summary>
    /// EnumInDrugReqdtlLsMarkType [医嘱类别：1-长期；2-临时；3-其他]
    /// </summary>
    public enum EnumMarkType
    {
        [Description("长期")]
        LongAdvice = 1,

        [Description("临时")]
        TemporaryAdvice = 2,

        [Description("其他")]
        Other = 3
    }

    public enum EnumGblFuctionLs
    {
        [Description("低")]
        Low = 1,
        [Description("中")]
        centre = 2,
        [Description("高")]
        High = 3,
    }

    /// <summary>
    /// 1- BsPatient.ID；2-OuHosinfo.ID ；3-InHosInfo.ID
    /// </summary>
    public enum EnumTypes
    {
        [Description("BsPatient.ID")]
        BsPatId = 1,
        [Description("OuHosinfo.ID")]
        OuPatId = 2,
        [Description("InHosInfo.ID")]
        InPatId = 3,
    }

    /// <summary>
    ///  1- 按病历类别看;2-按就诊时间看
    /// </summary>
    public enum EnumModes
    {
        [Description("1- 按病历类别看")]
        RecordType = 1,
        [Description("2-按就诊时间看")]
        VisitTime = 2
    }

    /// 西医/中医诊断
    /// </summary>
    public enum EnumWestChin
    {

        [Description("西医诊断")]
        West = 1,

        [Description("中医诊断")]
        Chinese
    }

    /// <summary>
    /// 电子病历类型/体温单/模板/权限/状态
    /// </summary>
    public enum EnumEMR
    {
        [Description("体温单(出院)")]
        EMR_OUTBODYHEAT = 1235,

        [Description("体温单")]
        EMR_INBODYHEAT = 815,

        [Description("电子病历挂号票据查询MenuID")]
        EMR_OUHASREGCHKMENUID = 30,

        [Description("电子病历护理单权限")]
        EMR_NURSINGLIST = 35,

        [Description("编辑状态")]
        EMR_EDITSTATUS = 1,

        [Description("只读状态")]
        EMR_ONLYREADSTATUS = 2,

        [Description(" 整洁状态")]
        EMR_CLEARALLSTATUS = 3,

        [Description("医生职称")]
        EMR_DOCLEVID = 3,

        [Description("不存在节点数、FormRmOut、FrmShowQcControl、FrmShowQcControl、FrmShowQcControl")]
        EMR_NONEFILENODE = 0,

        [Description("模板维护MenuID")]
        EMR_TEMPTAMPLATEMENUID = 200,

        [Description("门诊病历MenuID")]
        EMR_OUTPATIENTMENUID = 653,

        [Description("医嘱打印MenuID")]
        EMR_PRINTADVICEMENUID = 877,

        [Description("手术申请单MenuID")]
        EMR_OPSAPPLYMENUID = 883,

        [Description("传染病报告卡参数IsMz")]
        EMR_RDINFECTIOUSISMZ = 0,

        [Description("传染病报告卡参数IsWrite")]
        EMR_RDINFECTIOUSISWRITE = 1,

        [Description("模板维护新增末尾位置")]
        EMR_TEMPTAMPLATEEND = 0,

        [Description("模板维护新增当前位置")]
        EMR_TEMPTAMPLATECURRENT = 1,

        [Description("模板维护新增另起位置")]
        EMR_TEMPTAMPLATEANTHOR = 2,

        [Description("入院记录")]
        EMR_INHOSNOTEID = 1,

        [Description("病程记录")]
        EMR_PROGRESSNOTEID = 5,

        [Description("手术记录")]
        EMR_OPERTIONID = 17,

        [Description("术后首次病程记录")]
        EMR_OPERTIONFIRSTID = 19,

        [Description("出院小结")]
        EMR_OUTHOSRESULTID = 25,

        [Description(" 死亡记录")]
        EMR_DEATHRECORDID = 26,

        [Description("转科记录(转出)")]
        EMR_CHANGERECORDID = 37,

        [Description("病案首页")]
        EMR_HOMEPAGEID = 74,

        [Description("24小时内入出院记录")]
        EMR_INOUTHOSID = 36,

        [Description("出院记录")]
        EMR_OUTHOSNOTEID = 75,

        [Description("医保患者签字")]
        EMR_PATIENTSIGNID = 119,

        [Description("术前讨论")]
        EMR_PREOPTTALKID = 132,

        [Description("诊断证明书")]
        EMR_IDENTITYID = 151,

        [Description("住院病案质量评审")]
        EMR_HOMEPAGEAUTHID = 155

    }

    /// <summary>
    /// 门诊挂号费收取模式
    /// </summary>
    public enum EnumOuRegFeeMode
    {
        [Description("挂号处收")]
        RegisterReceipt = 1,

        [Description("收费处收")]
        TollCollectionOffice = 2,

        [Description("不收")]
        DonAccept = 3
    }

    public enum EnumInInvoiceDtlLsMarkType
    {
        [Description("长期")]
        LongAdvice = 1,

        [Description("临时")]
        TemporaryAdvice = 2,

        [Description("其他")]
        Other = 3,

        [Description("床位")]
        Bed = 4,

        [Description("出院带药")]
        LeaveHospitalWithMedicine = 5,

        [Description("医技")]
        AssistantSection = 6,

        [Description("每天的执行项目记账")]
        EveryDayCarryOut = 7,

        [Description("手术插帐")]
        OPS = 8,

        [Description("麻醉插帐")]
        Anaesthesiat = 9,

        [Description("1检验")]
        Test = 10,

        [Description("中药")]
        ChinMedicine = 11,

        [Description("护嘱")]
        AdviceNurse = 12,

        [Description("手术用血")]
        OpsBank = 13,

        [Description("医嘱用血")]
        AdviceBank = 14
    }

    public enum EnumInFeeWorkLsMarkType
    {
        [Description("长期")]
        LongAdvice = 1,

        [Description("临时")]
        TemporaryAdvice = 2,

        [Description("其他")]
        Other = 3,

        [Description("床位")]
        Bed = 4,

        [Description("出院带药")]
        LeaveHospitalWithMedicine = 5,

        [Description("医技")]
        AssistantSection = 6,

        [Description("每天的执行项目记账")]
        EveryDayCarryOut = 7,

        [Description("手术插帐")]
        OPS = 8,

        [Description("麻醉插帐")]
        Anaesthesiat = 9,

        [Description("检验")]
        Test = 10,

        [Description("中药")]
        ChinMedicine = 11
    }

    public enum EnumStoresType
    {
        [Description("药库库存查询")]
        Hustores,
        [Description("药房库存查询")]
        Rmstores
    }


    public enum EnumEmergencyAll
    {
        [Description("紧急")]
        Emergency = 1,

        [Description("全部")]
        All = 2
    }

    #region EnumExtensions
    /// <summary>
    /// 获取枚举扩展类
    /// </summary>
    public static class EnumExtensions
    {
        /// <summary>
        /// 获取枚举描述
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetDescription(this Enum value)
        {
            Type type = value.GetType();
            MemberInfo[] memberInfos = type.GetMember(value.ToString());
            if (memberInfos != null && memberInfos.Length > 0)
            {
                var attrs = memberInfos[0].GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];

                if (attrs != null && attrs.Length > 0)
                {
                    return attrs[0].Description;
                }
            }

            return value.ToString();
        }
    }
    #endregion


    public enum EnumDecoctWay
    {
        [Description("无")]
        None = 1,

        [Description("先煎")]
        FirstdeCoct = 2,

        [Description("后下")]
        AfterPutIn = 3,

        [Description("锔服")]
        CuriumDose = 4,

        [Description("另熔")]
        Tomelt = 5,

        [Description("冲服")]
        WithWater = 6,

        [Description("另服")]
        OtherWay = 7
    }

    /// <summary>
    /// 住院状态:1-等待住院；2-在院；3-出院；4-请假；5-待出院 
    /// </summary>
    public enum EnumPatientInHospitalState
    {
        [Description("等待住院")]
        WaitInHospital = 1,

        [Description("在院")]
        InHospital = 2,

        [Description("出院")]
        OutHospital = 3,

        [Description("请假")]
        LeaveHospital = 4,

        [Description("待出院")]
        WaitOutHospital = 5
    }

    public enum EnumLabLsSource
    {
        [Description("门诊")]
        OutpatientService = 1,
        [Description("住院")]
        Hospitalization = 2,
        [Description("外来单位")]
        ForeignUnit = 3,
        [Description("体检")]
        PhysicalExamination = 4
    }

    public enum EnumHeatType
    {
        [Description("口表")]
        OralForm = 1,
        [Description("腋表")]
        AxillaryTable = 2,
        [Description("肛表")]
        AnalSurface = 3
    }

    #region EnumLimitDay [限额类别]
    /// <summary>
    /// EnumBsLimitGroupLsLimitDay [限额类别：1-每天限额；2-每次限额]
    /// </summary>
    public enum EnumLimitDay
    {
        [Description("每天限额")]
        Everyday = 1,

        [Description("每次限额")]
        EveryTime = 2,

        [Description("每组最高限额")]
        GroupTop = 3
    }
    #endregion

    #region EnumOuPerformFlg [执行类别]
    /// <summary>
    /// EnumOuHosInfoLsPerformFlg [执行类别：1-正常执行；2-退号；3-自动放弃]
    /// </summary>
    public enum EnumOuPerformFlg
    {
        [Description("正常执行")]
        NormalCarryOut = 1,

        [Description("退号")]
        Cancel = 2,

        [Description("自动放弃")]
        SelfGiveUp = 3
    }
    #endregion

    /// <summary>
    /// 价类
    /// </summary>
    public enum EnumLsPriceState
    {
        [Description("普通")]
        Ordinary = 0,
        [Description("特需")]
        Special = 1
    }

    #region EnumInInvoicePayType [交款类型]
    /// <summary>
    /// EnumInInvoiceLsPayType [交款类型：1-中途结算；2-出院结算；3-出院补结]
    /// </summary>
    public enum EnumInInvoicePayType
    {
        [Description("中途结算")]
        PayMidWay = 1,

        [Description("出院结算")]
        payLeaveHospital = 2,

        [Description("出院补结")]
        LeaveComplement = 3
    }
    #endregion

    /// <summary>
    /// EnumLsTestType [体检类别：1-常规体检；2-生化检查；7-临床微生物检验；13-血库检验--]
    /// </summary>
    public enum EnumLsTestType
    {
        //[Description("常规体检")]
        //Normal = 1,

        //[Description("生化检查")]
        //BioChemistry = 2,
        [Description("体检项目")]
        PhysicalExaminationProject = 1,

        [Description("检验项目")]
        InspectionItem = 2,

        [Description("临床血液手工录入")]
        ManualEntryOfClinicalBlood = 5,

        [Description("临床微生物检验")]
        ClinicalMicrobiologicalExamination = 7,

        [Description("血库检验")]
        BloodBankTest = 13,

        [Description("临床免疫检验")]
        ClinicalImmunoassay = 15
    }

    public enum EnumItemGridCustomStyle
    {
        [Description("特殊药品或项目")]
        IsSpecial = 1,

        [Description("报销项目")]
        IsDiscDiag = 2,

        [Description("公费/甲、乙类")]
        IsGfType = 4,

        [Description("市民优惠")]
        OptionPrice = 8,

        [Description("禁止临床使用的")]
        IsRpForbid = 16,
    }

    /// <summary>  
    /// 回访类别 
    /// </summary>  
    public enum EnumVisitType
    {
        [Description("复诊提醒")]
        ReExaminationReminder = 1,
        [Description("健康教育")]
        HealthEducation = 2,
        [Description("诊后关怀")]
        PostDiagnosisCare = 3,
        [Description("病情跟踪")]
        ConditionTracking = 4,
        [Description("满意度调查")]
        SatisfactionSurvey = 5,
        [Description("用药提示")]
        MedicationTips = 6
    }

    /// <summary>  
    /// 回访状态
    /// </summary>  
    public enum EnumVisitStatus
    {
        [Description("未回访")]
        NoReturnVisit = 1,
        [Description("已回访")]
        ReturnedVisit = 2,
        [Description("待跟进")]
        ToBeFollowedUp = 3
    }


    /// <summary>  
    /// 满意程度
    /// </summary> 
    public enum EnumSatisfaction
    {
        [Description("一星")]
        AStar = 1,
        [Description("二星")]
        TwoStars = 2,
        [Description("三星")]
        ThreeStars = 3,
        [Description("四星")]
        FourStars = 4,
        [Description("五星")]
        FiveStars = 5
    }
    /// <summary>
    /// QC状态
    /// </summary>
    public enum EnumQCStatus
    {
        [Description("在控")]
        InControl = 0,
        [Description("失控偏高")]
        OutOfControlHigh = 1,
        [Description("失控偏低")]
        OutOfControlLow = 2,
        [Description("没有维护QC检测")]
        QcDetectionIsNotMaintained = 3
    }
    public enum EnumTimeType
    {
        [Description("InTime")]
        InTime,

        [Description("OutTime")]
        OutTime
    }

    public enum EnumFieldName
    {
        [Description("DoctorId")]
        DoctorId = 0,
        [Description("LsInIllness")]
        LsInIllness = 1,
        [Description("LocationIdPat")]
        LocationIdPat = 2
    }
    #region EnumGFPatType [公费病人类别]
    /// <summary>
    /// EnumBsPatTypeLsGFPatType [公费病人类别：1-干部；2-家属；3-离休干部]
    /// </summary>
    public enum EnumGFPatType
    {
        [Description("国家干部")]
        StateCadre = 1,

        [Description("家属")]
        Family = 2,

        [Description("离休干部")]
        RetireCadre = 3
    }
    #endregion

    #region EnumInIllness [入院病情]
    /// <summary>
    /// EnumInHosInfoLsInIllness [入院病情：1-危；2-急；3-一般；4-重]
    /// </summary>
    public enum EnumInIllness
    {
        [Description("危")]
        Danger = 1,

        [Description("急")]
        Ungent = 2,

        [Description("一般")]
        Common = 3,

        [Description("重")]
        Heavy = 4
    }
    #endregion

    public enum EnumSource
    {
        [Description("门诊")]
        OutpatientService = 1,

        [Description("住院")]
        Hospitalization,

        [Description("外来单位")]
        ForeignUnit,

        [Description("体检")]
        PhysicalExamination,

        [Description("其他")]
        Other
    }

    public enum EnumLsTransType
    {
        [Description("反应1")]
        Reaction1 = 1,

        [Description("反应2")]
        Reaction2 = 2,

        [Description("反应3")]
        Reaction3 = 3,

        [Description("反应4")]
        Reaction4 = 4,

        [Description("反应5")]
        Reaction5 = 5,

        [Description("反应6")]
        Reaction6 = 6,

        [Description("反应7")]
        Reaction7 = 7,

        [Description("反应8")]
        Reaction8 = 8
    }

    #region EnumRoomInOut [药房分类]
    /// <summary>
    /// EnumBsRoomLsInOut [药房分类：1-门诊；2-住院；3-其他]
    /// </summary>
    public enum EnumRoomInOut
    {
        [Description("门诊")]
        ForOutPatient = 1,

        [Description("住院")]
        ForInPatient = 2,

        [Description("其他")]
        Other = 3
    }
    #endregion

    public enum EnumLsAdvType 
    {
        [Description("全部")]
        All = 0,

        [Description("长期医嘱")]
        LongTermMedicalAdvice = 1,

        [Description("临时医嘱")]
        TemporaryOrders = 2,

        [Description("出院带药")]
        DischargeWithMedicine = 3

    }
}

