using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Media.Imaging;

namespace Orm.Model.Custom
{
    [Serializable]
    public class TjItemRecordCollection 
    {
        public TjItemRecordCollection(List<uspTjItemRecord> list)
        {
            
            foreach (var item in list)
            {
                if (!item.IsGroup)
                    this.LstTjItemRecordEx.Add(CopyFrom(item));
                else
                {
                    this.GroupItem = CopyFrom(item);
                    if (this.GroupItem.IsOver) 
                        CanEdit = false;
                    else
                        CanEdit = true;
                    this.LstImageSource1 = new ObservableCollection<TjResultImageSources1>();
                }
            }
        }

        #region 属性
        /// <summary>
        /// 组合
        /// </summary>
        public TjItemRecordEx GroupItem { get; set; }

        private List<TjItemRecordEx> _lstTjItemRecordEx = new List<TjItemRecordEx>();
        public List<TjItemRecordEx> LstTjItemRecordEx
        {
            get { return _lstTjItemRecordEx; }
            set { _lstTjItemRecordEx = value; }
        }

        private bool _canEdit = true;
        public bool CanEdit
        {
            get { return _canEdit; }
            set { _canEdit = value; }
        }

        private ObservableCollection<TjResultImageSources1> _lstImageSource1 = new ObservableCollection<TjResultImageSources1>();
        /// <summary>
        /// 结果谱图图片
        /// </summary>
        public ObservableCollection<TjResultImageSources1> LstImageSource1
        {
            get { return _lstImageSource1; }
            set { _lstImageSource1 = value; }
        }
        #endregion

        public class TjResultImageSources1
        {
            public string  OuRecipedID { get; set; }
            public BitmapImage BitmapImage1 { get; set; }
            public string ImgPath { get; set; }
            public byte[] ImageBye { get; set; }
        }
        
        private TjItemRecordEx CopyFrom(uspTjItemRecord item)
        {
            var tjItemRecordEx = new TjItemRecordEx();
            tjItemRecordEx.GUID = item.GUID;
            tjItemRecordEx.ItemId = item.ItemId;
            tjItemRecordEx.ItemCode = item.ItemCode;
            tjItemRecordEx.GroupItemCode = item.GroupItemCode;
            tjItemRecordEx.ItemName = item.ItemName;
            tjItemRecordEx.OperId = item.OperId;
            tjItemRecordEx.ItemUnit = item.ItemUnit;
            tjItemRecordEx.IsGroup = item.IsGroup;
            tjItemRecordEx.TjResult = item.TjResult;
            tjItemRecordEx.IsAbnormal = item.IsAbnormal;
            tjItemRecordEx.AbnormalTips = item.AbnormalTips;
            tjItemRecordEx.DoctorID = item.DoctorID;
            tjItemRecordEx.TjLocationID = item.TjLocationID;
            tjItemRecordEx.OperTime = item.OperTime;
            tjItemRecordEx.ReferRange = item.ReferRange;
            tjItemRecordEx.LastTjResult = item.LastTjResult;
            tjItemRecordEx.DataType = item.DataType;
            tjItemRecordEx.IsCharge = item.IsCharge;
            tjItemRecordEx.IsOver = item.IsOver;
            tjItemRecordEx.RecipeDtlId = item.RecipeDtlId;
            tjItemRecordEx.ItemId = item.ItemId;
            tjItemRecordEx.ItemInterface = item.ItemInterface;
            tjItemRecordEx.SourceId = item.SourceId;
        
            tjItemRecordEx.SampleNum = item.SampleNum;
            tjItemRecordEx.VeryLowLimit = item.VeryLowLimit;
            tjItemRecordEx.VeryTopLimit = item.VeryTopLimit;
            tjItemRecordEx.LimitLow = item.LimitLow;
            tjItemRecordEx.LimitHigh = item.LimitHigh;
            tjItemRecordEx.SendStatus = item.SendStatus;
            tjItemRecordEx.ItemInterfaceChannel = item.ItemInterfaceChannel;
            tjItemRecordEx.SourceName = item.SourceName;
       
            tjItemRecordEx.CKMId = item.CKMId;
            tjItemRecordEx.QCReagentlot = item.QCReagentlot;
            tjItemRecordEx.DecimalDigits = item.DecimalDigits;
            tjItemRecordEx.TjResultCopy = item.TjResultCopy;
            tjItemRecordEx.IsApproval = item.IsApproval;
            tjItemRecordEx.Commentary = item.Commentary;
            tjItemRecordEx.Labid = item.Labid;
            tjItemRecordEx.Testid = item.Testid;
            tjItemRecordEx.AuthDocTime = item.AuthDocTime;
            tjItemRecordEx.CommonProblem = item.CommonProblem;
            tjItemRecordEx.LsrefFlag = item.LsrefFlag;
            tjItemRecordEx.LowValue = item.LowValue;
            tjItemRecordEx.HighValue = item.HighValue; 
            tjItemRecordEx.TestIllustration = item.TestIllustration;
            tjItemRecordEx.LastResult = item.LastResult;
            tjItemRecordEx.Unit = item.Unit;
            tjItemRecordEx.Memo = item.Memo;
            tjItemRecordEx.HospitalID = item.HospitalID; 
            return tjItemRecordEx;
        }
    }
}
