using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model
{
    public class DataMain
    {


        private string _shop_code;

        private double _amount;

        private string _order_sn;

        private string _pay_name;

        private string _creater;

        private string _state;

        private string _token;

        private string _hospital_code;

        private string _goods_code;

        private string _timestamp;

        private string _mobilephone;

        private string _address;

        private string _consignee;

        private string _deliverytimebymember;

        private string _order_id;
        public string order_id
        {
            get { return _order_id; }
            set { _order_id = value; }
        }

        public List<data_detail> data_detail;
        public string shop_code
        {
            get { return _shop_code; }
            set { _shop_code = value; }
        }

        public string hospital_code
        {
            get { return _hospital_code; }
            set { _hospital_code = value; }
        }

        public string goods_code
        {
            get { return _goods_code; }
            set { _goods_code = value; }
        }


        public double amount
        {
            get { return _amount; }
            set { _amount = value; }
        }
        public string order_sn
        {
            get { return _order_sn; }
            set { _order_sn = value; }
        }
        public string pay_name
        {
            get { return _pay_name; }
            set { _pay_name = value; }
        }
        public string creater
        {
            get { return _creater; }
            set { _creater = value; }
        }
        public string state
        {
            get { return _state; }
            set { _state = value; }
        }
        public string token
        {
            get { return _token; }
            set { _token = value; }
        }
        public string timestamp
        {
            get { return _timestamp; }
            set { _timestamp = value; }
        }

        public string consignee
        {
            get { return _consignee; }
            set { _consignee = value; }
        }
        public string address
        {
            get { return _address; }
            set { _address = value; }
        }

        public string mobile_phone
        {
            get { return _mobilephone; }
            set { _mobilephone = value; }
        }

        public string deliverytimebymember
        {
            get { return _deliverytimebymember; }
            set { _deliverytimebymember = value; }
        }
    }

    public class data_detail
    {
        private string _goods_code;

        private double _qty;
        private double _price;
        private double _subtotal;

        private string _memo;

        public string goods_code
        {
            get { return _goods_code; }
            set { _goods_code = value; }
        }
        public double qty
        {
            get { return _qty; }
            set { _qty = value; }
        }

        public double price
        {
            get { return _price; }
            set { _price = value; }
        }

        public double subtotal
        {
            get { return _subtotal; }
            set { _subtotal = value; }
        }

        public string memo
        {
            get { return _memo; }
            set { _memo = value; }
        }

    }

    /// <summary>
    ///  药房信息
    /// </summary>
    public class PharmacyInfo
    {
        private string _dept_name;  //名称
        private string _dept_no;    //药房编码
        private string _address;    // 地址
        private string _hospital_code;  //诊所ID
        private string _defaultdept;  // 是否默认药房   1为默认 0 为非默认
        private bool _isActive;
        private bool _isDefult;
        private bool _isSelect;
        private string _guid;
        private int _pharmacyType;

        public int PharmacyType
        {
            get { return _pharmacyType; }
            set { _pharmacyType = value; }
        }
        public string GUID
        {
            get { return _guid; }
            set { _guid = value; }
        }
        public bool IsSelect
        {
            get { return _isSelect; }
            set { _isSelect = value; }
        }

        public bool IsActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }

        public bool IsDefult
        {
            get { return _isDefult; }
            set { _isDefult = value; }
        }

        public string dept_name
        {
            get { return _dept_name; }
            set { _dept_name = value; }
        }
        public string dept_no
        {
            get { return _dept_no; }
            set { _dept_no = value; }
        }
        public string address
        {
            get { return _address; }
            set { _address = value; }
        }
        public string hospital_code
        {
            get { return _hospital_code; }
            set { _hospital_code = value; }
        }
        public string defaultdept
        {
            get { return _defaultdept; }
            set { _defaultdept = value; }
        }
    }
}
