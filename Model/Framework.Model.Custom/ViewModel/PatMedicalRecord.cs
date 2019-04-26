using System;
using Orm.Model.Custom;

namespace Orm.Model.Custom
{
    [Serializable]
    public class PatMedicalRecord
    {
        public PatMedicalRecord() { }

        private UspOuHosInfoQry _patOuHosInfo = new UspOuHosInfoQry();

        public UspOuHosInfoQry PatOuHosInfo
        {
            get { return _patOuHosInfo; }
            set { _patOuHosInfo = value; }
        }

        private UspMedicalRecord _medicalRecord = new UspMedicalRecord();
        public UspMedicalRecord MedicalRecord
        {
            get { return _medicalRecord; }
            set
            {
                _medicalRecord = value;
                ProgressIsBusy = false;
            }
        }

        private bool _progressIsBusy = false;
        /// <summary>
        /// 进度君
        /// </summary>
        public bool ProgressIsBusy
        {
            get { return _progressIsBusy; }
            set
            {
                _progressIsBusy = value;
                IsEditStatus = !value;
            }
        }

        private bool _isEditStatus = true;
        /// <summary>
        /// 页面编辑状态
        /// </summary>
        public bool IsEditStatus
        {
            get { return _isEditStatus; }
            set { _isEditStatus = value; }
        }
    }
}
