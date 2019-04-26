using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orm.Model;

namespace Orm.Model.Custom
{
   public class UspOuClincDiagCache:BaseModel
    {
    
        /// <summary>
        /// 门诊流水号
        /// </summary>
        public string MzRegId
        {
            get;
            set;
        }

        /// <summary>
        /// 序号
        /// </summary>
        public int ListNum
        {
            get;
            set;
        }

        /// <summary>
        /// 初诊（ICD码）
        /// </summary>
        public string IcdId
        {
            get;
            set;
        }

        /// <summary>
        /// 诊断（ICD名称）
        /// </summary>
        public string IllDesc
        {
            get;
            set;
        }

        /// <summary>
        /// 诊断类别：1-初诊；2-复诊;3-疑诊；4-急性发作
        /// </summary>
        public int LsDiagType
        {
            get;
            set;
        }

        /// <summary>
        /// 序号
        /// </summary>
        public int SequenceNum
        {
            get;
            set;
        }

        /// <summary>
        /// 中医诊断编码
        /// </summary>
        public string IcdCodeZy
        {
            get;
            set;
        }

        /// <summary>
        /// 中医诊断名称
        /// </summary>
        public string IllDescZy
        {
            get;
            set;
        }

        /// <summary>
        /// 录入时间
        /// </summary>
        public DateTime OperTime
        {
            get;
            set;
        }

        /// <summary>
        /// 是否医生录入
        /// </summary>
        public bool IsDocInput
        {
            get;
            set;
        }

        /// <summary>
        /// 已经封存，不可改删
        /// </summary>
        public bool IsAuthed
        {
            get;
            set;
        }

        /// <summary>
        /// 医院ID
        /// </summary>
        public int HosPitalID
        {
            get;
            set;
        }

        /// <summary>
        /// ICD码疾病名称
        /// </summary>
        public string IcdName { get; set; }
    }
}
