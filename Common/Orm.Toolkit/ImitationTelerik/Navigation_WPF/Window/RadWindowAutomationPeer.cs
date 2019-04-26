using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
	/// <summary>
	/// Automation Peer for the RadWindow class.
	/// </summary>
	public partial class RadWindowAutomationPeer
		: FrameworkElementAutomationPeer,
		ITransformProvider,
		IWindowProvider
	{
		/// <summary>
		/// Initializes a new instance of the RadWindowAutomationPeer class.
		/// </summary>
		/// <param name="owner">The owner <see cref="RadWindow"/> instance.</param>
		public RadWindowAutomationPeer(RadWindow owner)
			: base(owner)
		{
		}

		/// <summary>
		/// IWindowProvider implementation.
		/// Gets the interaction state of the window.
		/// </summary>
		public WindowInteractionState InteractionState
		{
			get
			{
				// TODO: currently we do not support interaction state set...
				return WindowInteractionState.Running;
			}
		}

		/// <summary>
		/// IWindowProvider implementation.
		/// Gets a value that specifies whether the window is modal.
		/// </summary>
		public bool IsModal
		{
			get
			{
				return this.OwnerAsRadWindow().IsModal;
			}
		}

		/// <summary>
		/// IWindowProvider implementation.
		/// Gets a value that specifies whether the window is the topmost element in the z-order.
		/// </summary>
		public bool IsTopmost
		{
			get
			{
				return this.OwnerAsRadWindow().IsActiveWindow;
			}
		}

		/// <summary>
		/// IWindowProvider implementation.
		/// Gets a value that specifies whether the window can be maximized.
		/// </summary>
		public bool Maximizable
		{
			get
			{
				return this.OwnerAsRadWindow().ResizeMode == ResizeMode.CanResize;
			}
		}

		/// <summary>
		/// IWindowProvider implementation.
		/// Gets a value that specifies whether the window can be minimized.
		/// </summary>
		public bool Minimizable
		{
			get
			{
				return this.OwnerAsRadWindow().ResizeMode == ResizeMode.CanResize
					|| this.OwnerAsRadWindow().ResizeMode == ResizeMode.CanMinimize;
			}
		}

		/// <summary>
		/// IWindowProvider implementation.
		/// Gets the visual state of the window.
		/// </summary>
		public WindowVisualState VisualState
		{
			get
			{
				switch (this.OwnerAsRadWindow().WindowState)
				{
					case System.Windows.WindowState.Maximized:
						return WindowVisualState.Maximized;
                    case System.Windows.WindowState.Minimized:
						return WindowVisualState.Minimized;
					default:
						return WindowVisualState.Normal;
				}
			}
		}

		/// <summary>
		/// ITransformProvider implementation.
		/// Gets a value that indicates whether the control can be rotated.
		/// </summary>
		public bool CanRotate
		{
			get
			{
				return false;
			}
		}

		/// <summary>
		/// ITransformProvider implementation.
		/// Gets a value that indicates whether the UI Automation element can be resized.
		/// </summary>
		public bool CanResize
		{
			get
			{
				return this.OwnerAsRadWindow().ResizeMode == ResizeMode.CanResize;
			}
		}

		/// <summary>
		/// ITransformProvider implementation.
		/// Gets a value that indicates whether the control can be moved.
		/// </summary>
		public bool CanMove
		{
			get
			{
				return this.OwnerAsRadWindow().CanMove &&
                    this.OwnerAsRadWindow().WindowState != System.Windows.WindowState.Maximized;
			}
		}

		/// <summary>
		/// IWindowProvider implementation.
		/// </summary>
		public void Close()
		{
			this.OwnerAsRadWindow().Close();
		}

		/// <summary>
		/// IWindowProvider implementation.
		/// </summary>
		/// <param name="state">The visual state of the window to change to.</param>
		public void SetVisualState(WindowVisualState state)
		{
			switch (state)
			{
				case WindowVisualState.Maximized:
                    this.OwnerAsRadWindow().WindowState = System.Windows.WindowState.Maximized;
					break;
				case WindowVisualState.Minimized:
                    this.OwnerAsRadWindow().WindowState = System.Windows.WindowState.Minimized;
					break;
				default:
                    this.OwnerAsRadWindow().WindowState = System.Windows.WindowState.Normal;
					break;
			}
		}

		/// <summary>
		/// IWindowProvider implementation.
		/// Blocks the calling code for the specified time or until the associated process
		/// enters an idle state, whichever completes first.
		/// </summary>
		/// <param name="milliseconds">The amount of time, in milliseconds,
		/// to wait for the associated process to become idle.
		/// The maximum is System.Int32.MaxValue.</param>
		/// <returns>True if the window has entered the idle state; false if the timeout occurred.</returns>
		public bool WaitForInputIdle(int milliseconds)
		{
			// TODO: Currently we do not support Idle.
			return false;
		}

		/// <summary>
		/// ITransformProvider implementation.
		/// Rotates the control.
		/// Still not supported.
		/// </summary>
		/// <param name="degrees">The number of degrees to rotate the control.
		/// A positive number rotates the control clockwise.
		/// A negative number rotates the control counterclockwise.</param>
		public void Rotate(double degrees)
		{
			throw new InvalidOperationException("RadWindow still do not support rotation.");
		}

		/// <summary>
		/// ITransformProvider implementation.
		/// Resizes the control.
		/// </summary>
		/// <param name="width">The new width of the window, in pixels.</param>
		/// <param name="height">The new height of the window, in pixels.</param>
		public void Resize(double width, double height)
		{
			this.GuarantyEnabled();
			if (!this.CanResize)
			{
				throw new InvalidOperationException("Can not resize non resizable RadWindow.");
			}
			if (double.IsInfinity(width) || double.IsNaN(width) || 0.0 > width)
			{
				throw new ArgumentOutOfRangeException("width");
			}
			if (double.IsInfinity(height) || double.IsNaN(height) || 0.0 > height)
			{
				throw new ArgumentOutOfRangeException("height");
			}
			this.OwnerAsRadWindow().Width = width;
			this.OwnerAsRadWindow().Height = height;
		}

		/// <summary>
		/// ITransformProvider implementation.
		/// Moves the control.
		/// </summary>
		/// <param name="x">The absolute screen coordinates of the left side of the control.</param>
		/// <param name="y">The absolute screen coordinates of the top of the control.</param>
		public void Move(double x, double y)
		{
			this.GuarantyEnabled();
			if (!this.CanMove)
			{
				throw new InvalidOperationException("Can not move non movable RadWindow.");
			}
			if (double.IsInfinity(x) || double.IsNaN(x))
			{
				throw new ArgumentOutOfRangeException("x");
			}
			if (double.IsInfinity(y) || double.IsNaN(y))
			{
				throw new ArgumentOutOfRangeException("y");
			}
			this.OwnerAsRadWindow().Left = x;
			this.OwnerAsRadWindow().Top = y;
		}

		/// <summary>
		/// Gets a control pattern that is associated with this AutomationPeer.
		/// </summary>
		/// <param name="patternInterface">One of the enumeration values that indicates the control pattern.</param>
		/// <returns>The object that implements the pattern interface, or null.</returns>
		public override object GetPattern(PatternInterface patternInterface)
		{
			if (patternInterface == PatternInterface.Window ||
				patternInterface == PatternInterface.Transform)
			{
				return this;
			}
			return base.GetPattern(patternInterface);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="oldState"></param>
		/// <param name="newState"></param>
		internal void RaiseAutomationWindowStateChanged(object oldState, object newState)
		{
			this.RaisePropertyChangedEvent(WindowPatternIdentifiers.WindowVisualStateProperty, oldState, newState);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="oldParam"></param>
		/// <param name="newParam"></param>
		internal void RaiseAutomationBoundingRectangleChanged(object oldParam, object newParam)
		{
			this.RaisePropertyChangedEvent(AutomationElementIdentifiers.BoundingRectangleProperty, oldParam, newParam);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="newState"></param>
		internal void RaiseAutomationHasKeyboardFocusChanged(bool newState)
		{
			this.RaisePropertyChangedEvent(AutomationElementIdentifiers.HasKeyboardFocusProperty, !newState, newState);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		protected override AutomationControlType GetAutomationControlTypeCore()
		{
			return AutomationControlType.Window;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		protected override string GetClassNameCore()
		{
			return "RadWindow";
		}

		/// <summary>
		/// Returns the text label of the FrameworkElement associated with this AutomationPeers.
		/// Called by AutomationPeer.GetName.
		/// </summary>
		/// <returns>A text label of the Element associated with this Automation Peer.</returns>
		protected override string GetNameCore()
		{
			string nameCore = base.GetNameCore();
			if (string.IsNullOrEmpty(nameCore))
			{
				nameCore = "Rad Window";
			}
			return nameCore;
		}

		private RadWindow OwnerAsRadWindow()
		{
			RadWindow radWindow = this.Owner as RadWindow;
			if (null == radWindow)
			{
				throw new InvalidOperationException("The Owner have to be RadWindow");
			}
			return radWindow;
		}

		private void GuarantyEnabled()
		{
			if (!IsEnabled())
			{
				throw new ElementNotEnabledException();
			}
		}
	}
}