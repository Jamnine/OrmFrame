
namespace Orm.Toolkit.Telerik.Windows.Controls
{
	/// <summary>
	/// Describes the placement of where a Popup control appears on the screen.
	/// </summary>
	public enum PlacementMode
	{
		/// <summary>
		/// A position of the Popup control relative to the upper-left corner of 
		/// the screen and at an offset that is defined by the HorizontalOffset 
		/// and VerticalOffset property values. If the screen edge obscures the 
		/// Popup, the control then repositions itself to align with the edge.
		/// </summary>
		Absolute,

		// Relative,

		/// <summary>
		/// A position of the Popup control where the control aligns its upper edge 
		/// with the lower edge of the PlacementTarget and aligns its left edge with 
		/// the left edge of the PlacementTarget. If the lower screen-edge obscures 
		/// the Popup, the control repositions itself so that its lower edge aligns 
		/// with the upper edge of the PlacementTarget. If the upper screen-edge 
		/// obscures the Popup, the control then repositions itself so that its upper 
		/// edge aligns with the upper screen-edge.
		/// </summary>
		Bottom,

		/// <summary>
		/// A position of the Popup control where it is centered over the PlacementTarget. 
		/// If a screen edge obscures the Popup, the control repositions itself to align 
		/// with the screen edge. 
		/// </summary>
		Center,

		/// <summary>
		/// A position of the Popup control that aligns its left edge with the right edge 
		/// of the PlacementTarget and aligns its upper edge with the upper edge of the 
		/// PlacementTarget. If the right screen-edge obscures the Popup, the control 
		/// repositions itself so that its left edge aligns with the left edge of the 
		/// PlacementTarget. If the left screen-edge obscures the Popup, the control 
		/// repositions itself so that its left edge aligns with the left screen-edge. 
		/// If the upper or lower screen-edge obscures the Popup, the control then 
		/// repositions itself to align with the obscuring screen edge.
		/// </summary>
		Right,

        ////AbsolutePoint,
        ////RelativePoint,
        ////Mouse,
        ////MousePoint,

		/// <summary>
		/// A Popup control that aligns its right edge with the left edge of the PlacementTarget 
		/// and aligns its upper edge with the upper edge of the PlacementTarget. If the left 
		/// screen-edge obscures the Popup, the Popup repositions itself so that its left edge 
		/// aligns with the right edge of the PlacementTarget. If the right screen-edge obscures 
		/// the Popup, the right edge of the control aligns with the right screen-edge. If the 
		/// upper or lower screen-edge obscures the Popup, the control repositions itself to 
		/// align with the obscuring screen edge.
		/// </summary>
		Left,

		/// <summary>
		/// A position of the Popup control that aligns its lower edge with the upper edge of 
		/// the PlacementTarget and aligns its left edge with the left edge of the PlacementTarget. 
		/// If the upper screen-edge obscures the Popup, the control repositions itself so that 
		/// its upper edge aligns with the lower edge of the PlacementTarget. If the lower 
		/// screen-edge obscures the Popup, the lower edge of the control aligns with the 
		/// lower screen-edge. If the left or right screen-edge obscures the Popup, it then 
		/// repositions itself to align with the obscuring screen.
		/// </summary>
		Top

		////Custom
	}
}