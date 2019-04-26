using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.MvvmFrame.Auxiliary
{
    [AttributeUsage(AttributeTargets.Parameter, Inherited = false), __DynamicallyInvokable]
    public sealed class CallerMemberNameAttribute : Attribute
    {

    }

    [AttributeUsage(AttributeTargets.All, Inherited = false)]
    internal sealed class __DynamicallyInvokableAttribute : Attribute
    {
    }
}
