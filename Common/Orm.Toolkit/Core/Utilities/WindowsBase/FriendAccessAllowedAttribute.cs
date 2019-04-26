using System;
namespace Orm.Toolkit.Core.Utilities.WindowsBase
{

    [AttributeUsage(AttributeTargets.Delegate | AttributeTargets.Interface | AttributeTargets.Field | AttributeTargets.Property | AttributeTargets.Method | AttributeTargets.Constructor | AttributeTargets.Enum | AttributeTargets.Struct | AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    internal sealed class FriendAccessAllowedAttribute : Attribute
    {
    }
}
