using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model
{
    /// <summary>
    /// 数据分析查询条件设置 - 实体类
    /// </summary>
    [Serializable]
    public class GblAnalysisQuerySetting:BaseModel
    {
        private string _keyName;
        private string _settingID;
        private bool _isActive;
        private string _parmName;
        private int _parameterType;
        private string _setValue;


        /// <summary>
        /// 键
        /// </summary>
        public string KeyName { get { return _keyName;} set { _keyName = value;} }
        
        /// <summary>
        /// 数据分析设置编号
        /// </summary>
        public string SettingID { get { return _settingID; } set { _settingID = value;} }
        /// <summary>
        /// 是否有效
        /// </summary>
        public bool IsActive { get { return _isActive; } set { _isActive = value;} }
        /// <summary>
        /// 参数名称
        /// </summary>
        public string ParmName
        {
            get
            {
                return _parmName;
            }

            set
            {
                _parmName = value;
            }
        }
        /// <summary>
        /// 参数类型
        /// </summary>
        public int ParameterType { get { return _parameterType; } set { _parameterType = value; } }

        /// <summary>
        /// 值
        /// </summary>
        public string SetValue { get { return _setValue; } set { _setValue = value; } }
    }
}
