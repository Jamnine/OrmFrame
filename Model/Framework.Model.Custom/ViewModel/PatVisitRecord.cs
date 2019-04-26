using System;
using System.Collections.Generic;
using Orm.Model;
using Orm.Model.Custom;

namespace Orm.Model.Custom
{
    [Serializable]
    public class PatVisitRecord
    {
        public PatVisitRecord()
        {

        }
        /// <summary>
        /// 是否选中
        /// </summary>
        public bool IsSelect { get; set; }

        private UspOuHosInfoQry _patOuHosInfo = new UspOuHosInfoQry();

        public UspOuHosInfoQry PatOuHosInfo
        {
            get { return _patOuHosInfo; }
            set { _patOuHosInfo = value; }
        }

        private List<OuRecipeDtl> _OuRecipeDtlList = new List<OuRecipeDtl>();
        public List<OuRecipeDtl> OuRecipeDtlList
        {
            get { return _OuRecipeDtlList; }
            set
            {
                _OuRecipeDtlList = value;
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
