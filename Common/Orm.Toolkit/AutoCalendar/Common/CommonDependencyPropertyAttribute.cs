using System;
using System.Diagnostics;

namespace Orm.Toolkit
{
    [Conditional("COMMONDPS")]
    internal sealed class CommonDependencyPropertyAttribute : Attribute
    {
    }
}
