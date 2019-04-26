
using System.Windows.Input;


namespace Orm.Toolkit.Telerik.Windows.Controls
{

    /// <summary>
    /// Specifies constants that define actions performed by the mouse wheel.
    /// </summary>
    public enum MouseWheelAction
    {
        /// <summary>
        /// Any movement.
        /// </summary>
        AnyMovement,

        /// <summary>
        /// Mouse wheel wheeled up.
        /// </summary>
        WheelUp,

        /// <summary>
        /// Mouse wheel wheeled down.
        /// </summary>
        WheelDown
    }

    /// <summary>
    /// Defines a mouse wheel input gesture that can be used to invoke a command.
    /// </summary>
    public class MouseWheelGesture : MouseGesture
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MouseWheelGesture"/> class.
        /// </summary>
        public MouseWheelGesture() : base(MouseAction.WheelClick)
        {
            this.MouseWheelAction = MouseWheelAction.AnyMovement;
        }

        /// <summary>
        /// Gets or sets the <see cref="MouseWheelAction"/> associated with this gesture.
        /// </summary>
        /// <value>The mouse wheel action.</value>
        public MouseWheelAction MouseWheelAction { get; set; }

        /// <summary>
        /// Determines whether <see cref="MouseWheelGesture"/> matches the input associated with the specified <see cref="MouseWheelAction"/> object.
        /// </summary>
        /// <param name="targetElement">The target.</param>
        /// <param name="inputEventArgs">The input event data to compare with this gesture.</param>
        /// <returns>
        /// True if the event data matches this <see cref="MouseWheelGesture"/>; otherwise, false.
        /// </returns>
        public override bool Matches(object targetElement, InputEventArgs inputEventArgs)
        {
            if (base.Matches(targetElement, inputEventArgs))
            {
                var wheelArgs = inputEventArgs as MouseWheelEventArgs;
                if (wheelArgs != null)
                {
                    if (this.MouseWheelAction == MouseWheelAction.AnyMovement
                        || (this.MouseWheelAction == MouseWheelAction.WheelDown && wheelArgs.Delta < 0)
                        || (this.MouseWheelAction == MouseWheelAction.WheelUp && wheelArgs.Delta > 0))
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}