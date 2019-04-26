using System.Windows;

namespace Orm.Toolkit.Telerik.Windows.Controls.RadWindowPopup
{
	internal abstract class WindowPopupFactory
	{
		public WindowPopup GetPopup(UIElement child, UIElement modalCanvas, bool isTopMost)
		{
			var popup = this.CreatePopup(child);
			popup.Configure(child, modalCanvas, isTopMost);
			return popup;
		}

		protected abstract WindowPopup CreatePopup(UIElement content);
	}
}
