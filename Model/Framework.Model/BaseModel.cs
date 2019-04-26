using System;
using System.Collections.Generic;
using System.Reflection;
using Orm.Model.EnumDefine;

namespace Orm.Model
{
    public interface IModel
    {

    }

    /// <summary>
    /// 基础Model
    /// </summary>
    [Serializable]
    public class BaseModel : IModel
    {
        /// <summary>
        /// 是否修改
        /// </summary>
        public bool IsModify { get ; set; }
        /// <summary>
        /// ID
        /// </summary>
        public virtual int ID {get; set; }
        /// <summary>
        /// GUID
        /// </summary>
        public virtual string GUID {get; set; }

        /// <summary>
        /// 医院ID
        /// </summary>
        public virtual int HospitalId { get; set; }

        /// <summary>
        /// 行状态
        /// </summary>
        public int RowStatus { get; set; }
        /// <summary>
        /// HisType 产品类型：0 共享 1 His 2 行心云 3养老1 2 3表示某种系统独有
        /// </summary>
        public virtual int HisType { get; set; }

        /// <summary>
        /// 默认构造方法
        /// </summary>
        public BaseModel()
        {

        }
        private bool _isGUIDNull = false;
        public bool u_IsGUIDNull
        {
            get
            {
                if (string.IsNullOrWhiteSpace(GUID))
                {
                    _isGUIDNull = true;
                }
                return _isGUIDNull;
            }
            set { _isGUIDNull = value; }
        }
        private bool _isNotGUIDNull = false;
        public bool u_IsNotGUIDNull
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(GUID))
                {
                    _isNotGUIDNull = true;
                }
                else
                {
                    _isNotGUIDNull = false;
                }
                return _isNotGUIDNull;
            }
            set { _isNotGUIDNull = value; }
        }
        /// <summary>
        /// 系统缓存
        /// </summary>
        public static Dictionary<string, object> Caches = new Dictionary<string, object>();

        public virtual void Fill(System.Data.IDataReader dr) { }

        /// <summary>
        /// New对象时，将字符串字段赋值为空格。
        /// </summary>
        public void SetStringValue()
        {
            BindingFlags BINDING_FLAGS = BindingFlags.Instance | BindingFlags.NonPublic
                                            | BindingFlags.GetField | BindingFlags.SetField;
            FieldInfo[] fields = this.GetType().GetFields(BINDING_FLAGS);
            foreach (var field in fields)
            {
                if (field.FieldType == typeof(string))
                {
                    object value = field.GetValue(this);

                    //if (value == null || value.ToString() == string.Empty)
                     //field.SetValue(this, "");
                    if(value == null||value.ToString()==string.Empty)
                    {
                        field.SetValue(this, null);
                    }

                }
                else if (field.FieldType == typeof(int))
                {
                    object value = field.GetValue(this);
                    if (value == null)
                        field.SetValue(this, 0);
                }
            }
        }

        /// <summary>
        /// redis查询条件的值的集合
        /// </summary>
        public string RedisConditionValus
        {
            get;
            set;
        }
        private bool _isNotGUID = false;
        public bool u_IsNotGUID
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(GUID))
                {
                    _isNotGUID = true;
                }
                else
                {
                    _isNotGUID = false;
                }
                return _isNotGUID;
            }
            set { _isNotGUID = value; }
        }
        private bool _isGUID = false;
        public bool u_IsGUID
        {
            get
            {
                if (string.IsNullOrWhiteSpace(GUID))
                {
                    _isGUID = true;
                }
                else
                {
                    _isGUID = false;
                }
                return _isGUID;
            }
            set { _isGUID = value; }
        }
        private bool _isWestern = false;
        public bool u_IsWestern
        {
            get
            {
                if (GUID == EnumRecipeType.西药.ToString())
                {
                    _isWestern = true;
                }
                else
                {
                    _isWestern = false;
                }
                return _isWestern;
            }
            set { _isWestern = value; }
        }
    }
}
