using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 电子病历信息
    /// </summary>
    [Serializable]
    public class UspMedicalRecord
    {
        public ToothEmr _mainToothEmr = new ToothEmr();
        private List<ToothCheck> _childToothCheck = new List<ToothCheck>();
        private List<ToothXRay> _childToothXRay = new List<ToothXRay>();
        private List<ToothDiagnose> _childToothDiagnose = new List<ToothDiagnose>();
        private List<ToothCoures> _childToothCoures = new List<ToothCoures>();
        private List<ToothTreatmentPlan> _childToothTreatmentPlan = new List<ToothTreatmentPlan>();

        private string _name = "";
        /// <summary>
        /// 名称
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _doctorId = string.Empty;
        /// <summary>
        /// 医生ID
        /// </summary>
        public string DoctorId
        {
            get { return _doctorId; }
            set { _doctorId = value; }
        }

        /// <summary>
        /// 电子病历主表
        /// </summary>
        public ToothEmr MainToothEmr
        {
            get { return _mainToothEmr; }
            set { _mainToothEmr = value; }
        }
        private int _preRegType = 2;
        /// <summary>
        /// 0.未预约 1.已预约  2.全部
        /// </summary>
        public int PreRegType
        {
            get { return _preRegType; }
            set { _preRegType = value; }
        }

        private int _selectedAttachType = 2;
        /// <summary>
        /// 0.未执行 1.已执行  2.全部
        /// </summary>
        public int SelectedAttachType
        {
            get { return _selectedAttachType; }
            set { _selectedAttachType = value; }
        }

        /// <summary>
        /// 电子病历检查表
        /// </summary>
        public List<ToothCheck> ChildToothCheck
        {
            get
            {
                return _childToothCheck;
            }
            set { _childToothCheck = value; }
        }
        /// <summary>
        /// 电子病历X线表
        /// </summary>
        public List<ToothXRay> ChildToothXRay
        {
            get
            {
                return _childToothXRay;
            }
            set { _childToothXRay = value; }
        }
        /// <summary>
        /// 电子病历诊断表
        /// </summary>
        public List<ToothDiagnose> ChildToothDiagnose
        {
            get
            {
                return _childToothDiagnose;
            }
            set { _childToothDiagnose = value; }
        }
        /// <summary>
        /// 电子病历治疗过程表
        /// </summary>
        public List<ToothCoures> ChildToothCoures
        {
            get
            {
                return _childToothCoures;
            }
            set { _childToothCoures = value; }
        }
        /// <summary>
        /// 电子病历治疗方案表
        /// </summary>
        public List<ToothTreatmentPlan> ChildToothTreatmentPlan
        {
            get
            {
                return _childToothTreatmentPlan;
            }
            set { _childToothTreatmentPlan = value; }
        }

        /// <summary>
        /// 牙位(适用于一个牙位一个病历的情况)
        /// </summary>
        public string ToothPosition { get; set; }

        /// <summary>
        /// 当前病历对应的挂号信息
        /// </summary>
        //public OuHosInfo CurrentOuHosInfo { get; set; }

        /// <summary>
        /// 就诊医生名字
        /// </summary>
        public string DoctorName { get; set; }

      
 
        /// <summary>
        /// 流水号ID
        /// </summary>
        public string MzRegID { get; set; }
        #region 昆山
        /// <summary>
        /// 是否Simple
        /// </summary>
        public bool IsSimple { get; set; }


        #endregion

    }
}