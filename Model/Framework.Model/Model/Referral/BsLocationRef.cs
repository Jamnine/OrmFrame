using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model
{
    /// <summary>
    /// 门诊机构 对应数据库BsLocation表
    /// </summary>
    [Serializable]
    public partial class BsLocationRef : BaseModel
    {
        private string _code;
        private string _name;
        private int _lsinout;
        private bool _isforWomen;
        private string _phoneCode;
        private int _medicineratio;
        private int _orderBy;
        private bool _isActive;
        private int _iconIndex;
        private int _specialityId;
        private int _bedSum;
        private string _basysCode; 
        private string _director;

        private int _depttypeID; 
        private bool _iscostapp;
        private int _applevel;
         
        private string _pyCode;
        private string _wbCode;
        private int _area;
        private int _ouroomId;
        private int _inroomId;
        private bool _isPriceSub;
        private bool _isclinical;
        private bool _ischinLocation;
        private bool _isregLocation;
        private bool _isAllLocation;
        private DateTime _modiTime;
        private long _modiOperId;
        private int _hospitalId;


        /// <summary>
        /// 默认构造方法.
        /// </summary>
        public BsLocationRef() { }
        
        /// <summary>
        /// 1-住院科室;2-门诊科室;3-所有业务科室;4-后勤科室;5-大科室;6-医技科室;7-药剂科室;8-物资仓库
        /// </summary>
        public int IsInOut
        {
            get { return _lsinout; }
            set { _lsinout = value; }
        }

        /// <summary>
        ///所属分院
        /// </summary>
        public int HospitalId
        {
            get { return _hospitalId; }
            set { _hospitalId = value; }
        }
        

        /// <summary>
        /// 女性科室
        /// </summary>
        public bool IsForWomen
        {
            get { return _isforWomen; }
            set { _isforWomen = value; }
        }

        /// <summary>
        /// 1-CT；2-DR；3-MR；4-CR；5-RF；6-US；7-脑电图；8-心电图；9-镜检查；10-MG；11-DSA
        /// </summary>
        public string PhoneCode
        {
            get { return _phoneCode; }
            set { _phoneCode = value; }
        }
         
        /// <summary>
        /// 控制药比
        /// </summary>
        public int MedicIneratio
        {
            get { return _medicineratio; }
            set { _medicineratio = value; }
        }
        

        /// <summary>
        /// 门诊机构编码 
        /// </summary> 
        public string Code
        {
            get { return this._code; }
            set { this._code = value; }
        }

        /// <summary>
        /// 诊所名称
        /// </summary> 
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }


        /// <summary>
        /// 排序
        /// </summary> 
        public int OrderBy
        {
            get { return this._orderBy; }
            set { this._orderBy = value; }
        }

        /// <summary>
        /// 是否可用
        /// </summary> 
        public bool IsActive
        {
            get { return this._isActive; }
            set { this._isActive = value; }
        }

        /// <summary>
        /// 图标
        /// </summary> 
        public int IconIndex
        {
            get { return this._iconIndex; }
            set { this._iconIndex = value; }
        }

        /// <summary>
        /// 科室专业
        /// </summary> 
        public int SpeciAlityId
        {
            get { return this._specialityId; }
            set { this._specialityId = value; }
        }

        /// <summary>
        /// 床位编制数
        /// </summary> 
        public int BedSum
        {
            get { return this._bedSum; }
            set { this._bedSum = value; }
        }



        /// <summary>
        /// 病案编码
        /// </summary> 
        public string BasysCode
        {
            get { return this._basysCode; }
            set { this._basysCode = value; }
        }


        /// <summary>
        /// 科室主任
        /// </summary> 
        public string Director
        {
            get { return this._director; }
            set { this._director = value; }
        }

        /// <summary>
        /// 部门类别
        /// </summary> 
        public int DeptTypeID
        {
            get { return this._depttypeID; }
            set { this._depttypeID = value; }
        }

        /// <summary>
        /// 参与成本分摊标志
        /// </summary> 
        public bool Iscostapp
        {
            get { return this._iscostapp; }
            set { this._iscostapp = value; }
        }

        /// <summary>
        /// 科室分摊级别
        /// </summary> 
        public int AppLevel
        {
            get { return this._applevel; }
            set { this._applevel = value; }
        }
        


        /// <summary>
        /// 拼音码
        /// </summary> 
        public string PyCode
        {
            get { return this._pyCode; }
            set { this._pyCode = value; }
        }

        /// <summary>
        /// 五笔码.
        /// </summary> 
        public string WbCode
        {
            get { return this._wbCode; }
            set { this._wbCode = value; }
        }

        /// <summary>
        /// 面积. 
        public int Area
        {
            get { return this._area; }
            set { this._area = value; }
        }

        /// <summary>
        /// 门诊药房. 
        public int OuRoomId
        {
            get { return this._ouroomId; }
            set { this._ouroomId = value; }
        }

        /// <summary>
        /// 住院药房. 
        public int InRoomId
        {
            get { return this._inroomId; }
            set { this._inroomId = value; }
        }
        

        /// <summary>
        /// 最后修改时间.
        /// </summary> 
        public DateTime ModiTime
        {
            get { return this._modiTime; }
            set { this._modiTime = value; }
        }

        /// <summary>
        /// 最后修改人.
        /// </summary> 
        public long ModiOperId
        {
            get { return this._modiOperId; }
            set { this._modiOperId = value; }
        }

        /// <summary>
        /// 是否特殊价格
        /// </summary> 
        public bool IsPriceSub
        {
            get { return this._isPriceSub; }
            set { this._isPriceSub = value; }
        }

        /// <summary>
        /// 是否临床科室
        /// </summary> 
        public bool IsClinical
        {
            get { return this._isclinical; }
            set { this._isclinical = value; }
        }

        /// <summary>
        /// 标识是否为中医科
        /// </summary> 
        public bool IsChinLocation
        {
            get { return this._ischinLocation; }
            set { this._ischinLocation = value; }
        }

        /// <summary>
        /// 是否公共科室
        /// </summary> 
        public bool IsRegLocation
        {
            get { return this._isregLocation; }
            set { this._isregLocation = value; }
        }

        /// <summary>
        /// 是否住院护士可以管理整个病区的病人（不分科）
        /// </summary> 
        public bool IsAllLocation
        {
            get { return this._isAllLocation; }
            set { this._isAllLocation = value; }
        } 
    }
}