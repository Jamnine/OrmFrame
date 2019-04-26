using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model
{
    public class InLogStatusIn : BaseModel
    {
        private DateTime _operTime;

        private int _lsinillness;

        private string _lsinstatus;

        private string _bedname;

        private bool _isbaby;

        private bool _issum;

        private string _hospitalID;

        private string _locationID;

        private string _hospID;

        private string _bedID;

        private int _histype;

        private DateTime _inserttime;



        public DateTime OperTime
        {
            get { return _operTime; }
            set { _operTime = value; }
        }
        public int LsInIllness
        {
            get { return _lsinillness; }
            set { _lsinillness = value; }
        }
        public string Lsinstatus
        {
            get { return _lsinstatus; }
            set { _lsinstatus = value; }
        }
        public string Bedname
        {
            get { return _bedname; }
            set { _bedname = value; }
        }
        public bool Isbaby
        {
            get { return _isbaby; }
            set { _isbaby = value; }
        }
        public bool IsSum
        {
            get { return _issum; }
            set { _issum = value; }
        }
        public string HospitalID
        {
            get { return _hospitalID; }
            set { _hospitalID = value; }
        }


        public string LocationId
        {
            get { return _locationID; }
            set { _locationID = value; }
        }
        public string HospId
        {
            get { return _hospID; }
            set { _hospID = value; }
        }
        public string Bedid
        {
            get { return _bedID; }
            set { _bedID = value; }
        }
        public int Histype
        {
            get { return _histype; }
            set { _histype = value; }
        }
        public DateTime Inserttime
        {
            get { return _inserttime; }
            set { _inserttime = value; }
        }
    }
}
