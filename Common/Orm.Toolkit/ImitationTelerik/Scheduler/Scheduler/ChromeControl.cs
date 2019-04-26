using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
	/// <summary>
	/// A Chrome control class.
	/// </summary>
	[TemplateVisualState(Name = "Normal", GroupName = "CommonStates")]
	[TemplateVisualState(Name = "MouseOver", GroupName = "CommonStates")]
	[TemplateVisualState(Name = "Selected", GroupName = "CommonStates")]
	[TemplateVisualState(Name = "SelectedMouseOver", GroupName = "CommonStates")]
	public class ChromeControl : ContentControl
	{
		/// <summary>
		/// Identifies the <see cref="IsSelected"/> property.
		/// </summary>
		/// <returns>The identifier for the <see cref="IsSelected"/> property.</returns>
		public static readonly DependencyProperty IsSelectedProperty =
		   DependencyProperty.Register("IsSelected", typeof(bool), typeof(ChromeControl), new PropertyMetadata(false, new PropertyChangedCallback(IsSelectedChanged)));

		/// <summary>
		/// Identifies the <see cref="MouseOverBackground"/> property.
		/// </summary>
		/// <returns>The identifier for the <see cref="MouseOverBackground"/> property.</returns>
		public static readonly DependencyProperty MouseOverBackgroundProperty =
			DependencyProperty.Register("MouseOverBackground", typeof(Brush), typeof(ChromeControl), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender, OnMouseOverBackgroundChanged));

		/// <summary>
		/// Identifies the <see cref="SelectedBackground"/> property.
		/// </summary>
		/// <returns>The identifier for the <see cref="SelectedBackground"/> property.</returns>
		public static readonly DependencyProperty SelectedBackgroundProperty =
		DependencyProperty.Register("SelectedBackground", typeof(Brush), typeof(ChromeControl), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender, OnSelectedBackgroundChanged));

		/// <summary>
		/// Gets or sets the mouse over background.
		/// </summary>
		/// <value>The mouse over background.</value>
		public Brush MouseOverBackground
		{
			get { return (Brush)GetValue(MouseOverBackgroundProperty); }
			set { SetValue(MouseOverBackgroundProperty, value); }
		}

		/// <summary>
		/// Gets or sets the pressed background.
		/// </summary>
		/// <value>The pressed background.</value>
		public Brush SelectedBackground
		{
			get { return (Brush)GetValue(SelectedBackgroundProperty); }
			set { SetValue(SelectedBackgroundProperty, value); }
		}

		/// <summary>
		/// Gets or sets a value indicating whether this instance is selected.
		/// </summary>
		/// <value>
		/// 	<c>True</c> if this instance is selected; otherwise, <c>false</c>.
		/// </value>
		public bool IsSelected
		{
			get { return (bool)GetValue(IsSelectedProperty); }
			set { SetValue(IsSelectedProperty, value); }
		}

		/// <summary>
		/// When overridden in a derived class, is invoked whenever application code or internal processes call <see cref="M:System.Windows.FrameworkElement.ApplyTemplate"/>.
		/// </summary>
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();

		}


		private static void IsSelectedChanged(DependencyObject o, DependencyPropertyChangedEventArgs e)
		{

		}

		private static void OnSelectedBackgroundChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{

		}

		private static void OnMouseOverBackgroundChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{

		}


	}
}
