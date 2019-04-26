using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Toolkit
{
    /// <summary>
    /// Indicates the directions in which a ContentControl3D can rotate.
    /// </summary>
    public enum RotationDirection
    {
        LeftToRight,
        RightToLeft,
        TopToBottom,
        BottomToTop,
        TopLeftToBottomRight,
        TopRightToBottomLeft,
        BottomLeftToTopRight,
        BottomRightToTopLeft
    }
}
