using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Orm.Model.Parameter
{
    /// <summary>
    /// 电子病历信息
    /// </summary>
    [Serializable]
    public class PMMedicalRecord
    {
        public ToothEmr _mainToothEmr = new ToothEmr();
        private ObservableCollection<ToothCheck> _childToothCheck = new ObservableCollection<ToothCheck>();
        private ObservableCollection<ToothXRay> _childToothXRay = new ObservableCollection<ToothXRay>();
        private ObservableCollection<ToothDiagnose> _childToothDiagnose = new ObservableCollection<ToothDiagnose>();
        private ObservableCollection<ToothCoures> _childToothCoures = new ObservableCollection<ToothCoures>();
        private ObservableCollection<ToothTreatmentPlan> _childToothTreatmentPlan = new ObservableCollection<ToothTreatmentPlan>();

        /// <summary>
        /// 电子病历主表
        /// </summary>
        public ToothEmr MainToothEmr
        {
            get { return _mainToothEmr; }
            set { _mainToothEmr = value; }
        }

        /// <summary>
        /// 电子病历检查表
        /// </summary>
        public ObservableCollection<ToothCheck> ChildToothCheck
        {
            get
            {
                if (_childToothCheck.Count == 0)
                    _childToothCheck.Add(new ToothCheck());
                return _childToothCheck;
            }
            set { _childToothCheck = value; }
        }
        /// <summary>
        /// 电子病历X线表
        /// </summary>
        public ObservableCollection<ToothXRay> ChildToothXRay
        {
            get
            {
                if (_childToothXRay.Count == 0)
                    _childToothXRay.Add(new ToothXRay());
                return _childToothXRay;
            }
            set { _childToothXRay = value; }
        }
        /// <summary>
        /// 电子病历诊断表
        /// </summary>
        public ObservableCollection<ToothDiagnose> ChildToothDiagnose
        {
            get
            {
                if (_childToothDiagnose.Count == 0)
                    _childToothDiagnose.Add(new ToothDiagnose());
                return _childToothDiagnose;
            }
            set { _childToothDiagnose = value; }
        }
        /// <summary>
        /// 电子病历治疗过程表
        /// </summary>
        public ObservableCollection<ToothCoures> ChildToothCoures
        {
            get
            {
                if (_childToothCoures.Count == 0)
                    _childToothCoures.Add(new ToothCoures());
                return _childToothCoures;
            }
            set { _childToothCoures = value; }
        }
        /// <summary>
        /// 电子病历治疗方案表
        /// </summary>
        public ObservableCollection<ToothTreatmentPlan> ChildToothTreatmentPlan
        {
            get
            {
                if (_childToothTreatmentPlan.Count == 0)
                    _childToothTreatmentPlan.Add(new ToothTreatmentPlan());
                return _childToothTreatmentPlan;
            }
            set { _childToothTreatmentPlan = value; }
        }
    }
}
