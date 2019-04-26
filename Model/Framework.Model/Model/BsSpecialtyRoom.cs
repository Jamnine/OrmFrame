

using System;
namespace Orm.Model
{
	/// <summary>
	/// 专业科室 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsSpecialtyRoom:BaseModel
	{ 
        private string _code;
        private string _name;
        private int _HospitalID; 
        private string _wBCode;
        private string _pYCode;
        private int _orderBY;
        private bool _isActive;
        private int _iconIndex; 
         
        /// <summary>
        /// .编码
        /// </summary>
        public string Code
        {
            get
            {
                return this._code;
            }
            set
            {
                this._code = value;
            }
        }

        /// <summary>
        /// .名称
        /// </summary>
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }

        /// <summary>
        /// .医院ID
        /// </summary>
        public int HospitalID
        {
            get
            {
                return this._HospitalID;
            }
            set
            {
                this._HospitalID = value;
            }
        }


        /// <summary>
        /// .五笔码
        /// </summary>
        public string WBCode
        {
            get
            {
                return this._wBCode;
            }
            set
            {
                this._wBCode = value;
            }
        }

        /// <summary>
        /// .拼音码
        /// </summary>
        public string PYCode
        {
            get
            {
                return this._pYCode;
            }
            set
            {
                this._pYCode = value;
            }
        }

        /// <summary>
        /// .排序
        /// </summary>
        public int OrderBY
        {
            get
            {
                return this._orderBY;
            }
            set
            {
                this._orderBY = value;
            }
        }

        /// <summary>
        /// .是否有效标识
        /// </summary>
        public bool IsActive
        {
            get
            {
                return this._isActive;
            }
            set
            {
                this._isActive = value;
            }
        }

        /// <summary>
        /// .图标类型
        /// </summary>
        public int IconIndex
        {
            get
            {
                return this._iconIndex;
            }
            set
            {
                this._iconIndex = value;
            }
        }
 
     
 
      
    }  
}           


