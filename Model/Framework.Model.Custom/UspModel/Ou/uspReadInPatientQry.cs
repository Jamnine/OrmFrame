using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Custom
{

    [Serializable]
    #region class of Model:uspReadInPatientQry
    /// <summary>
    /// This object represents the properties and methods of a uspReadInPatient.
    /// </summary>
    public class uspReadInPatientQry : BaseModel  
    {
        private string _jYDJH = String.Empty;
        private string _yYBH = String.Empty;
        private string _gMSFHM = String.Empty;
        private string _xM = String.Empty;
        private string _dWMC = String.Empty;
        private string _xB = String.Empty;
        private DateTime _cSRQ;
        private string _rYLB = String.Empty;
        private string _gWYJB = String.Empty;
        private string _zYH = String.Empty;
        private string _jZLB = String.Empty;
        private DateTime _rYRQ;
        private string _rYZD = String.Empty;
        private string _rYZDGJDM = String.Empty;
        private string _bQDM = String.Empty;
        private string _cWDH = String.Empty;
        private double _tZDXSPH;
        private string _bZ1 = String.Empty;
        private string _bZ2 = String.Empty;
        private string _bZ3 = String.Empty;
        private int _dRBZ;

        public uspReadInPatientQry()
        {
        }



        #region Public Properties
            public string JYDJH
        {
            get { return _jYDJH; }
            set { _jYDJH = value; }
        }

        public string YYBH
        {
            get { return _yYBH; }
            set { _yYBH = value; }
        }

        public string GMSFHM
        {
            get { return _gMSFHM; }
            set { _gMSFHM = value; }
        }

        public string XM
        {
            get { return _xM; }
            set { _xM = value; }
        }

        public string DWMC
        {
            get { return _dWMC; }
            set { _dWMC = value; }
        }

        public string XB
        {
            get { return _xB; }
            set { _xB = value; }
        }

        public DateTime CSRQ
        {
            get { return _cSRQ; }
            set { _cSRQ = value; }
        }

        public string RYLB
        {
            get { return _rYLB; }
            set { _rYLB = value; }
        }

        public string GWYJB
        {
            get { return _gWYJB; }
            set { _gWYJB = value; }
        }

        public string ZYH
        {
            get { return _zYH; }
            set { _zYH = value; }
        }

        public string JZLB
        {
            get { return _jZLB; }
            set { _jZLB = value; }
        }

        public DateTime RYRQ
        {
            get { return _rYRQ; }
            set { _rYRQ = value; }
        }

        public string RYZD
        {
            get { return _rYZD; }
            set { _rYZD = value; }
        }

        public string RYZDGJDM
        {
            get { return _rYZDGJDM; }
            set { _rYZDGJDM = value; }
        }

        public string BQDM
        {
            get { return _bQDM; }
            set { _bQDM = value; }
        }

        public string CWDH
        {
            get { return _cWDH; }
            set { _cWDH = value; }
        }

        public double TZDXSPH
        {
            get { return _tZDXSPH; }
            set { _tZDXSPH = value; }
        }

        public string BZ1
        {
            get { return _bZ1; }
            set { _bZ1 = value; }
        }

        public string BZ2
        {
            get { return _bZ2; }
            set { _bZ2 = value; }
        }

        public string BZ3
        {
            get { return _bZ3; }
            set { _bZ3 = value; }
        }

        public int DRBZ
        {
            get { return _dRBZ; }
            set { _dRBZ = value; }
        }
        #endregion
    }
    #endregion
}







