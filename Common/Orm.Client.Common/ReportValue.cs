using System;
using System.Data;
using System.Data.Common;

namespace Orm.Client.Common
{

    #region class of Model:ReportValueQry
    /// <summary>
    /// This object represents the properties and methods of a ReportValue.
    /// </summary>
    public class ReportValueQry 
    {
        protected int _iD;
        protected string _rptKey = String.Empty;
        protected string _rptValue = String.Empty;
        protected string _describtion = String.Empty;

        public ReportValueQry()
        {
        }

        #region Public Properties
        public  int ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        public string RptKey
        {
            get { return _rptKey; }
            set { _rptKey = value; }
        }

        public string RptValue
        {
            get { return _rptValue; }
            set { _rptValue = value; }
        }

        public string Describtion
        {
            get { return _describtion; }
            set { _describtion = value; }
        }
        #endregion

        public static bool IsSaveYBReport = false;
        public static byte[] ReportContent;
    }
    #endregion
}




