using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Custom
{
    [Serializable]
    #region class of Model:vIEWMATCHQry
    /// <summary>   
    /// This object represents the properties and methods of a vIEWMATCH.   
    /// </summary>   
    public class vIEWMATCHQry : BaseModel  
    {
        private string _mATCH_TYPE = String.Empty;
        private string _iTEM_CODE = String.Empty;
        private string _iTEM_NAME = String.Empty;
        private string _mODEL = String.Empty;
        private string _hOSP_ITALID = String.Empty;
        private string _hOSP_CODE = String.Empty;
        private string _hOSP_NAME = String.Empty;
        private string _hOSP_MODEL = String.Empty;
        private string _hOSP_STANDARD = String.Empty;
        private string _sTAPLE_FLAG = String.Empty;
        private string _aUDIT_FLAG = String.Empty;


        public vIEWMATCHQry()
        {
        }



        #region Public Properties
        /// <summary>  
        ///   
        /// </summary>  
        public string MATCH_TYPE
        {
            get { return _mATCH_TYPE; }
            set { _mATCH_TYPE = value; }
        }

        /// <summary>  
        ///   
        /// </summary>  
        public string ITEM_CODE
        {
            get { return _iTEM_CODE; }
            set { _iTEM_CODE = value; }
        }

        /// <summary>  
        ///   
        /// </summary>  
        public string ITEM_NAME
        {
            get { return _iTEM_NAME; }
            set { _iTEM_NAME = value; }
        }

        /// <summary>  
        ///   
        /// </summary>  
        public string MODEL
        {
            get { return _mODEL; }
            set { _mODEL = value; }
        }

        /// <summary>  
        ///   
        /// </summary>  
        public string HOSPITAL_ID
        {
            get { return _hOSP_ITALID; }
            set { _hOSP_ITALID = value; }
        }

        /// <summary>  
        ///   
        /// </summary>  
        public string HOSP_CODE
        {
            get { return _hOSP_CODE; }
            set { _hOSP_CODE = value; }
        }

        /// <summary>  
        ///   
        /// </summary>  
        public string HOSP_NAME
        {
            get { return _hOSP_NAME; }
            set { _hOSP_NAME = value; }
        }

        /// <summary>  
        ///   
        /// </summary>  
        public string HOSP_MODEL
        {
            get { return _hOSP_MODEL; }
            set { _hOSP_MODEL = value; }
        }

        /// <summary>  
        ///   
        /// </summary>  
        public string HOSP_STANDARD
        {
            get { return _hOSP_STANDARD; }
            set { _hOSP_STANDARD = value; }
        }

        /// <summary>  
        ///   
        /// </summary>  
        public string STAPLE_FLAG
        {
            get { return _sTAPLE_FLAG; }
            set { _sTAPLE_FLAG = value; }
        }

        /// <summary>  
        ///   
        /// </summary>  
        public string AUDIT_FLAG
        {
            get { return _aUDIT_FLAG; }
            set { _aUDIT_FLAG = value; }
        }

        #endregion

    }
    #endregion
}






