using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 打印会员充值记录类
    /// </summary>
    [Serializable]
    public class PrintOuRecharge:BaseModel
    {
         public PrintOuRecharge()
         {
                
         }

         /// <summary>  
         ///  诊所名称
         /// </summary>  
         public string HospitalName
         {
             get;
             set;
         }
        public string ReadMark
        {
            get;
            set;
        }

        /// <summary>  
        ///   ID(流水号)
        /// </summary>  
        public string GuId
         {
             get;
             set;
         }

         /// <summary>  
         ///   病人ID
         /// </summary>  
         public string PatID
         {
             get;
             set;
         }

         /// <summary>  
         ///  卡号 
         /// </summary>  
         public string CardNo
         {
             get;
             set;
         }

         /// <summary>  
         ///  姓名 
         /// </summary>  
         public string PatientName
         {
             get;
             set;
         }

         /// <summary>
         /// 操作方式：充值 ，退款
         /// </summary>
         public string RechargeType
         {
             get;
             set;
         }


         /// <summary>  
         /// 充值（退款）金额
         /// </summary>  
         public double Amount
         {
             get;
             set;
         } 

         /// <summary>  
         /// 赠送金额 
         /// </summary>  
         public double GiveAmount
         {
             get;
             set;
         }

         /// <summary>  
         /// 余额 
         /// </summary>  
         public double Balance
         {
             get;
             set;
         }
         /// <summary>  
         /// 操作时间 
         /// </summary>  
         public DateTime OperTime
         {
             get;
             set;
         }
        public string OperName { get; set; }
        /// <summary>
        /// 打印时间
        /// </summary>
        public DateTime PrintTime { get; set; }
         /// <summary>  
         ///  会员等级 
         /// </summary>  
         public string VipLevel
         {
             get;
             set;
         }

        /// <summary>  
        ///  自付金额（总）
        /// </summary>  
        public double IndividualPay
        {
            get;
            set;
        }
        /// <summary>  
        ///  赠送金额（总）
        /// </summary>  
        public double Givenamount
        {
            get;
            set;
        }

        /// <summary>  
        ///  扣除自付金额(或充值)
        /// </summary>  
        public double IndividualPayhis
        {
            get;
            set;
        }
        /// <summary>  
        /// 扣除赠送金额 (或充值)
        /// </summary>  
        public double Givenamounthis
        {
            get;
            set;
        }
        /// <summary>
        /// 有效期
        /// </summary>
        public string validityUntil { get; set; }

        /// <summary>  
        ///  扣除自付金额(或充值) 大写
        /// </summary>  
        public string IndividualPayhisCN
        {
            get;
            set;
        }
    }
}
