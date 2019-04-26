using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model
{
    [Serializable]
    public class ShopStock
    {
        public string status
        {
            get; set;
        }

        public string errorinfo
        {
            get; set;
        }

        public List<Data> data;


    }

    public class Data
    {
        private string _code;
        private string _name;
        private string _spec;
        private string _yieldly;
        private string _barcode;
        private string _unit_name;
        private string _stocks;
        private string _goods_price;
        private int _type;
        public int type
        {
            get { return _type; }
            set { _type = value; }
        }
        public string code
        {
            get { return _code; }
            set { _code = value; }
        }

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string spec
        {
            get { return _spec; }
            set { _spec = value; }
        }
        public string yieldly
        {
            get { return _yieldly; }
            set { _yieldly = value; }
        }
        public string barcode
        {
            get { return _barcode; }
            set { _barcode = value; }
        }
        public string unit_name
        {
            get { return _unit_name; }
            set { _unit_name = value; }

        }

        public string stocks
        {
            get { return _stocks; }
            set { _stocks = value; }
        }

        public string goods_price
        {
            get { return _goods_price; }
            set { _goods_price = value; }
        }
    }
}
