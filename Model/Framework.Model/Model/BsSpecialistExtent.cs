

using System;
namespace Orm.Model
{
	/// <summary>
	/// 行心云:专家管理 - 实体类
	/// </summary> 
	public partial class BsSpecialist:BaseModel
	{

        private bool _isSelect;
        /// <summary>
        /// 是否选中
        /// </summary>
        public bool IsSelect
        {
            get { return _isSelect; }
            set
            {
                _isSelect = value;
            }
        }

    }  
}           


