

using System;
namespace Orm.Model
{
	/// <summary>
	/// 行心云:患者回访表 - 实体类
	/// </summary>
	public partial class FollowPatient
	{

        private bool _isHideIllness; // 特殊病人

        /// <summary>
        /// 是否特殊病人
        /// </summary>
        public bool IsHideIllness
        {
            get { return this._isHideIllness; }
            set { this._isHideIllness = value; }
        }
         
        private bool _isSpecial;
        /// <summary>
        /// 是否特殊病人
        /// </summary>
        public bool IsSpecial
        {
            get { return this._isSpecial; }
            set { this._isSpecial = value; }
        }

    }  
}           


