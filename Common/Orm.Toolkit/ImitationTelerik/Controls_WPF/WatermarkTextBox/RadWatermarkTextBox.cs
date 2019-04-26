using System;
using System.Windows;
using System.Windows.Controls;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
	/// <summary>
	/// This class represents a TextBox that shows a different content when empty and not focus.
	/// </summary>

	[TemplatePart(Name = WATERMARKVISUALELEMENT, Type = typeof(ContentPresenter))]
	public class RadWatermarkTextBox : TextBox, IThemable
	{
		/// <summary>
		/// Identifies the WatermarkTemplate dependency property.
		/// </summary>
		public static readonly DependencyProperty WatermarkTemplateProperty =
			DependencyProperty.Register("WatermarkTemplate", typeof(DataTemplate), typeof(RadWatermarkTextBox), null);

		/// <summary>
		/// Identifies the WatermarkContent dependency property.
		/// </summary>
		public static readonly DependencyProperty WatermarkContentProperty =
			DependencyProperty.Register("WatermarkContent", typeof(object), typeof(RadWatermarkTextBox), null);

		/// <summary>
		/// Identifies the CurrentText dependency property.
		/// </summary>
		public static readonly DependencyProperty CurrentTextProperty =
			DependencyProperty.Register("CurrentText", typeof(string), typeof(RadWatermarkTextBox), null);

		/// <summary>
		/// Identifies the SelectionOnFocus property.
		/// </summary>
		public static readonly DependencyProperty SelectionOnFocusProperty =
			DependencyProperty.Register("SelectionOnFocus", typeof(SelectionOnFocus), typeof(RadWatermarkTextBox), null);

		/// <summary>
		/// Identifies the IsWatermarkVisible dependency property.
		/// </summary>
		public static readonly DependencyProperty IsWatermarkVisibleProperty;

		private static readonly DependencyPropertyKey IsWatermarkVisiblePropertyKey =
			DependencyPropertyExtensions.RegisterReadOnly("IsWatermarkVisible",
															typeof(bool),
															typeof(RadWatermarkTextBox),
															new PropertyMetadata(OnIsWatermarkVisibleChanged));

		private const string WATERMARKSTATES = "WatermarkStates";
		private const string WATERMARKHIDDENSTATE = "WatermarkHidden";
		private const string WATERMARKVISIBLESTATE = "WatermarkVisible";
		private const string WATERMARKVISUALELEMENT = "WatermarkVisualElement";

		static RadWatermarkTextBox()
		{

            //DefaultStyleKeyProperty.OverrideMetadata(typeof(RadWatermarkTextBox), new FrameworkPropertyMetadata(new ThemeResourceKey(typeof(Office_BlackTheme), typeof(RadWatermarkTextBox))));

            DefaultStyleKeyProperty.OverrideMetadata(typeof(RadWatermarkTextBox), new FrameworkPropertyMetadata(typeof(RadWatermarkTextBox)));


			IsWatermarkVisibleProperty = IsWatermarkVisiblePropertyKey.DependencyProperty;
		}

		/// <summary>
		/// Initializes a new instance of the RadWatermarkTextBox class.
		/// </summary>
		public RadWatermarkTextBox()
		{

			this.GotFocus += this.OnGotFocus;
			this.LostFocus += this.OnLostFocus;
			this.TextChanged += this.OnTextChanged;
		}

		/// <summary>
		/// Gets or sets the content to be shown when the TextBox is empty and not focused.
		/// </summary>
		public object WatermarkContent
		{
			get { return GetValue(WatermarkContentProperty); }
			set { SetValue(WatermarkContentProperty, value); }
		}

		/// <summary>
		/// Gets or sets the template for presenting the content, shown when the TextBox is empty and not focused.
		/// </summary>
		public DataTemplate WatermarkTemplate
		{
			get { return (DataTemplate)GetValue(WatermarkTemplateProperty); }
			set { SetValue(WatermarkTemplateProperty, value); }
		}

		/// <summary>
		/// Gets or sets the text of the TextBox.
		/// This property is meant to be used for TwoWay binding in order to be 
		/// updated on each change of the text and not when the focus is lost.
		/// </summary>
		public string CurrentText
		{
			get { return (string)GetValue(CurrentTextProperty); }
			set { SetValue(CurrentTextProperty, value); }
		}

		/// <summary>
		/// Gets a value indicating whether the Watermark is visible or not.
		/// </summary>
		public bool IsWatermarkVisible
		{
			get { return (bool)GetValue(IsWatermarkVisibleProperty); }
			private set { this.SetValue(IsWatermarkVisiblePropertyKey, value); }
		}

		/// <summary>
		/// Specifies the modification over the selection when the control receives focus.
		/// </summary>
		public SelectionOnFocus SelectionOnFocus
		{
			get
			{
				return (SelectionOnFocus)this.GetValue(SelectionOnFocusProperty);
			}
			set
			{
				this.SetValue(SelectionOnFocusProperty, value);
			}
		}



		/// <summary>
		/// Resets the theme.
		/// </summary>
		void IThemable.ResetTheme()
		{

			this.SetDefaultStyleKey();

		}

		/// <summary>
		/// When overridden in a derived class, is invoked whenever application code
		/// or internal processes (such as a rebuilding layout pass) call System.Windows.Controls.Control.ApplyTemplate().
		/// In simplest terms, this means the method is called just before a UI element
		/// displays in an application. For more information, see Remarks.
		/// </summary>
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();

			this.IsWatermarkVisible = string.IsNullOrEmpty(this.Text);

		}


		/// <summary>
		/// Raises the <see cref="E:System.Windows.FrameworkElement.Initialized"/> event. This method is invoked whenever <see cref="P:System.Windows.FrameworkElement.IsInitialized"/> is set to true internally.
		/// </summary>
		/// <param name="e">The <see cref="T:System.Windows.RoutedEventArgs"/> that contains the event data.</param>
		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);
			this.SetDefaultStyleKey();
		}


		private static void OnIsWatermarkVisibleChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{

		}

		private void OnGotFocus(object sender, RoutedEventArgs e)
		{
			if (this.IsWatermarkVisible)
			{
				this.IsWatermarkVisible = false;
			}

			this.UpdateSelection();
		}

		private void OnLostFocus(object sender, RoutedEventArgs e)
		{
			if (!this.IsWatermarkVisible && string.IsNullOrEmpty(this.Text))
			{
				this.IsWatermarkVisible = true;
			}
		}

		private void OnTextChanged(object sender, TextChangedEventArgs e)
		{
			this.CurrentText = this.Text;

			this.IsWatermarkVisible = !this.IsFocused && string.IsNullOrEmpty(this.Text);
		}

		private void UpdateSelection()
		{
			switch (this.SelectionOnFocus)
			{
				case SelectionOnFocus.Unchanged:
					break;
				case SelectionOnFocus.CaretToBeginning:
					this.SelectionStart = 0;
					break;
				case SelectionOnFocus.CaretToEnd:
					this.SelectionStart = this.Text.Length;
					break;
				case SelectionOnFocus.SelectAll:
					this.SelectAll();
					break;
			}
		}


		private void SetDefaultStyleKey()
		{
            //Theme theme = StyleManager.GetTheme(this);
            //this.DefaultStyleKey = ThemeResourceKey.GetDefaultStyleKey(theme, typeof(RadWatermarkTextBox));

       
            this.DefaultStyleKey = typeof(RadWatermarkTextBox);
		}

	}
}
