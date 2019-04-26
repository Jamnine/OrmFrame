

using System;
namespace Orm.Model
{
	/// <summary>
	/// 角色权限 - 实体类
	/// </summary>
	public partial class GblRoleModule : BaseModel
    {
            private int _day;
            public int Day
            {
                get { return _day; }
                set { _day = value; }
            }
    }
}           


