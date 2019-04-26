using System;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
	/// <summary>
    /// 通知客户时，开始和结束的布局更新。变更通知。Add ChenChunRu
	/// Notifies client when starts and finishes updating the layout.
	/// </summary>
	public interface INotifyLayoutChange
	{
		/// <summary>
        /// 发生布局更改时发生。
		/// Occurs when the layout change is started.
		/// </summary>
		event EventHandler LayoutChangeStarted;

		/// <summary>
        /// 当布局更改结束时发生。
		/// Occurs when the layout change is ended.
		/// </summary>
		event EventHandler LayoutChangeEnded;

		/// <summary>
        /// 获取一个值，该值指示该实例是否布局更改。
		/// Gets a value indicating whether this instance is layout changing.
		/// </summary>
		/// <value>
		/// 	<c>True</c> if this instance is layout changing; otherwise, <c>false</c>.
		/// </value>
		bool IsLayoutChanging { get; }
	}
}
