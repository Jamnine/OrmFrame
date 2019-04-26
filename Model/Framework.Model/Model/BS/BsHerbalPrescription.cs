using System;
using System.Collections.Generic;

namespace Orm.Model
{
    /// <summary>
    /// 中药处方(辩证治疗/名家名医)
    /// </summary>
    [Serializable]
    public partial class BsHerbalPrescription : BaseModel
    {
        string _illName;
        /// <summary>
        /// 疾病名称
        /// </summary>
        public string IllName
        {
            get
            {
                return _illName;
            }
            set
            {
                _illName = value;
            }
        }

        string _illDetial;
        /// <summary>
        /// 疾病详细
        /// </summary>
        public string IllDetial
        {
            get
            {
                return _illDetial;
            }
            set
            {
                _illDetial = value;
            }
        }
        string _author;
        /// <summary>
        /// 名家名医
        /// </summary>
        public string Author
        {
            get
            {
                return _author;
            }
            set
            {
                _author = value;
            }
        }
        string _typeOfSyndrome;
        /// <summary>
        /// 证型
        /// </summary>
        public string TypeOfSyndrome
        {
            get
            {
                return _typeOfSyndrome;
            }
            set
            {
                _typeOfSyndrome = value;
            }
        }
        string _therapy;
        /// <summary>
        /// 治法
        /// </summary>
        public string Therapy
        {
            get
            {
                return _therapy;
            }
            set
            {
                _therapy = value;
            }
        }
        string _prescription;
        /// <summary>
        /// 推荐方剂
        /// </summary>
        public string Prescription
        {
            get
            {
                return _prescription;
            }
            set
            {
                _prescription = value;
            }
        }
        string _authorIntro;
        /// <summary>
        /// 名家名医简介
        /// </summary>
        public string AuthorIntro
        {
            get
            {
                return _authorIntro;
            }
            set
            {
                _authorIntro = value;
            }
        }
        string _explain;
        /// <summary>
        /// 说明
        /// </summary>
        public string Explain
        {
            get
            {
                return _explain;
            }
            set
            {
                _explain = value;
            }
        }
        string _experience;
        /// <summary>
        /// 经验方
        /// </summary>
        public string Experience
        {
            get
            {
                return _experience;
            }
            set
            {
                _experience = value;
            }
        }
        string _addAndSubtract;
        /// <summary>
        /// 加减法详情
        /// </summary>
        public string AddAndSubtract
        {
            get
            {
                return _addAndSubtract;
            }
            set
            {
                _addAndSubtract = value;
            }
        }
        int _prescriptionType;
        /// <summary>
        /// 0.辩证疗法 1.名家名医经验方
        /// </summary>
        public int PrescriptionType
        {
            get
            {
                return _prescriptionType;
            }
            set
            {
                _prescriptionType = value;
            }
        }
        int _orderby;
        /// <summary>
        /// 排序
        /// </summary>
        public int Orderby
        {
            get
            {
                return _orderby;
            }
            set
            {
                _orderby = value;
            }
        }
        string _usage;
        /// <summary>
        /// 辩证治疗用法
        /// </summary>
        public string Usage
        {
            get { return _usage; }
            set { _usage = value; }
        }
        /// <summary>
        /// 详细处方内容 基本处方
        /// </summary>
        public List<BsHerbalPrescriptionDtl> LstBase { get; set; }
        /// <summary>
        /// 详细处方内容 加减法
        /// </summary>
        public List<BsHerbalPrescriptionDtl> LstAddAndSub { get; set; }
    }
}



