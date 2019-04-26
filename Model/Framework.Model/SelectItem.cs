using System;

namespace Orm.Model
{
    /// <summary>
    /// 所选项目
    /// </summary>
    [Serializable]
    public class SelectItem 
    {
        public SelectItem()
        {
        }

        private int _iD;
        protected string _code = String.Empty;
        protected string _name = String.Empty;
        protected bool _isSelect;
        protected string _f1 = String.Empty;
        protected string _f2 = String.Empty;
        protected string _f3 = String.Empty;
        protected string _f4 = String.Empty;
        protected string _f5 = String.Empty;
        protected string _f6 = String.Empty;
        protected string _f7 = String.Empty;
        protected string _f8 = String.Empty;
        protected string _f9 = String.Empty;
        protected string _f10 = String.Empty;
        protected string _f11 = String.Empty;
        protected string _f12 = String.Empty;
        
        /// <summary>
        /// ID
        /// </summary>
        public  int ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        /// <summary>
        /// 检查项目编码
        /// </summary>
        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }
        
        /// <summary>
        /// 英文全称
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// 选择标志
        /// </summary>
        public bool IsSelect
        {
            get { return _isSelect; }
            set { _isSelect = value; }
        }

        /// <summary>
        /// F1
        /// </summary>
        public string F1
        {
            get { return _f1; }
            set { _f1 = value; }
        }

        /// <summary>
        /// F2
        /// </summary>
        public string F2
        {
            get { return _f2; }
            set { _f2 = value; }
        }

        /// <summary>
        /// F3
        /// </summary>
        public string F3
        {
            get { return _f3; }
            set { _f3 = value; }
        }

        /// <summary>
        /// F4
        /// </summary>
        public string F4
        {
            get { return _f4; }
            set { _f4 = value; }
        }

        /// <summary>
        /// F5
        /// </summary>
        public string F5
        {
            get { return _f5; }
            set { _f5 = value; }
        }

        /// <summary>
        /// F6
        /// </summary>
        public string F6
        {
            get { return _f6; }
            set { _f6 = value; }
        }

        /// <summary>
        /// F7
        /// </summary>
        public string F7
        {
            get { return _f7; }
            set { _f7 = value; }
        }

        /// <summary>
        /// F8
        /// </summary>
        public string F8
        {
            get { return _f8; }
            set { _f8 = value; }
        }

        /// <summary>
        /// F9
        /// </summary>
        public string F9
        {
            get { return _f9; }
            set { _f9 = value; }
        }

        /// <summary>
        /// F10
        /// </summary>
        public string F10
        {
            get { return _f10; }
            set { _f10 = value; }
        }

        /// <summary>
        /// F11
        /// </summary>
        public string F11
        {
            get { return _f11; }
            set { _f11 = value; }
        }

        /// <summary>
        /// F12
        /// </summary>
        public string F12
        {
            get { return _f12; }
            set { _f12 = value; }
        }
    }
}
