using System;
using System.Collections.Generic;
using Orm.Model.Custom;

namespace Orm.Model.Custom
{
    [Serializable]
    public class TJRecordsInfo
    {
        public TJRecordsInfo() { }

        private uspTjTotalSummary _tjTotalSummaryInfo = new uspTjTotalSummary();

        public uspTjTotalSummary TJTotalSummaryInfo
        {
            get { return _tjTotalSummaryInfo; }
            set { _tjTotalSummaryInfo = value; }
        }

        private List<TjItemResultInfo> _tjItemRecordResultList = new List<TjItemResultInfo>();
        public List<TjItemResultInfo> TJItemRecordResultList
        {
            get { return _tjItemRecordResultList; }
            set
            {
                _tjItemRecordResultList = value;
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
            set { _progressIsBusy = value; }
        }
    }

    [Serializable]
    public class TjItemResultInfo
    {
        public TjItemResultInfo() { }

        private string _tjLocationName = string.Empty;
        /// <summary>
        /// 科室名称
        /// </summary>
        public string TjLocationName
        {
            get { return _tjLocationName; }
            set { _tjLocationName = value; }
        }

        private string _summary = string.Empty;
        /// <summary>
        /// 科室小结
        /// </summary>
        public string Summary
        {
            get { return _summary; }
            set { _summary = value; }
        }

        private string _suggestion = string.Empty;
        /// <summary>
        /// 医生建议
        /// </summary>
        public string Suggestion
        {
            get { return _suggestion; }
            set { _suggestion = value; }
        }

        private string _doctorName = string.Empty;
        /// <summary>
        /// 小结时间
        /// </summary>
        public string DoctorName
        {
            get { return _doctorName; }
            set { _doctorName = value; }
        }

        private bool _isCheckLocation = false;
        /// <summary>
        /// 是否检验科
        /// </summary>
        public bool IsCheckLocation
        {
            get { return _isCheckLocation; }
            set { _isCheckLocation = value; }
        }

        private DateTime _summaryOperTime = DateTime.MinValue;
        /// <summary>
        /// 小结时间
        /// </summary>
        public DateTime SummaryOperTime
        {
            get { return _summaryOperTime; }
            set { _summaryOperTime = value; }
        }

        private bool _isOver = false;
        /// <summary>
        /// 是否完成
        /// </summary>
        public bool IsOver
        {
            get { return _isOver; }
            set { _isOver = value; }
        }

        private List<uspTjItemRecordResult> _tjItemRecordResultInfo = new List<uspTjItemRecordResult>();
        public List<uspTjItemRecordResult> TJItemRecordResultInfo
        {
            get { return _tjItemRecordResultInfo; }
            set { _tjItemRecordResultInfo = value; }
        }
    }
}
