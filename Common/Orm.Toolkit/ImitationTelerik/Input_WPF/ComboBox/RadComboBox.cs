using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;

using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;

using System.Windows.Shapes;
using System.Windows.Threading;
using Orm.Toolkit.Telerik.Windows.Controls.Animation;


namespace Orm.Toolkit.Telerik.Windows.Controls
{


	/// <summary>
	/// Represents a selection control with a drop-down list that can be shown or hidden by 
	/// clicking the arrow on the control. 
	/// </summary>

	[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling")]
	[DefaultProperty("SelectedValue")]
	[DefaultEvent("SelectionChanged")]
	[StyleTypedProperty(Property = "ItemContainerStyle", StyleTargetType = typeof(RadComboBoxItem))]
	public class RadComboBox : Selector, IThemable
	{
		/// <summary>
		/// Identifies the Command dependency property.
		/// </summary>
		public static readonly DependencyProperty CommandProperty =
			DependencyProperty.Register("Command", typeof(ICommand), typeof(RadComboBox), new PropertyMetadata(OnCommandChanged));

		/// <summary>
		/// Identifies the CommandParameter dependency property.
		/// </summary>
		public static readonly DependencyProperty CommandParameterProperty =
			DependencyProperty.Register("CommandParameter", typeof(object), typeof(RadComboBox), new PropertyMetadata(OnCommandParameterChanged));

		/// <summary>
		/// Identifies the CommandParameter dependency property.
		/// </summary>
		public static readonly DependencyProperty CommandTargetProperty =
			DependencyProperty.Register("CommandTarget", typeof(IInputElement), typeof(RadComboBox), new PropertyMetadata(OnCommandTargetChanged));

		/// <summary>
		/// Identifies the IsWatermarkVisible dependency property.
		/// </summary>
		public static readonly DependencyProperty IsWatermarkVisibleProperty;

		/// <summary>
		/// Identifies the CanAutocompleteSelectItems dependency property.
		/// </summary>
		public static readonly DependencyProperty CanAutocompleteSelectItemsProperty =
			DependencyProperty.Register("CanAutocompleteSelectItems", typeof(bool?), typeof(RadComboBox), new PropertyMetadata(null));

		/// <summary>
		/// Identifies the CanKeyboardNavigationSelectItems dependency property.
		/// </summary>
		public static readonly DependencyProperty CanKeyboardNavigationSelectItemsProperty =
			DependencyProperty.Register("CanKeyboardNavigationSelectItems", typeof(bool?), typeof(RadComboBox), new PropertyMetadata(null));

		/// <summary>
		/// Identifies the NonEditableTemplate dependency property.
		/// </summary>
		public static readonly DependencyProperty NonEditableTemplateProperty =
			DependencyProperty.Register("NonEditableTemplate", typeof(ControlTemplate), typeof(RadComboBox), new PropertyMetadata(OnTemplateChanged));

		/// <summary>
		/// Identifies the EditableTemplate dependency property.
		/// </summary>
		public static readonly DependencyProperty EditableTemplateProperty =
			DependencyProperty.Register("EditableTemplate", typeof(ControlTemplate), typeof(RadComboBox), new PropertyMetadata(OnTemplateChanged));

		/// <summary>
		/// Identifies the MinDropDownWidth readonly dependency property.
		/// </summary>
		public static readonly DependencyProperty MinDropDownWidthProperty;

		/// <summary>
		/// Identifies the IsDropDownOpen dependency property.
		/// </summary>
		public static readonly DependencyProperty IsDropDownOpenProperty =
			DependencyProperty.Register("IsDropDownOpen", typeof(bool), typeof(RadComboBox), new PropertyMetadata(false, OnIsDropDownOpenChanged));

		/// <summary>
		/// Identifies the MaxDropDownHeight dependency property.
		/// </summary>
		public static readonly DependencyProperty MaxDropDownHeightProperty =
			DependencyProperty.Register("MaxDropDownHeight", typeof(double), typeof(RadComboBox), new PropertyMetadata(200d));

		/// <summary>
		/// Identifies the IsReadOnly dependency property.
		/// </summary>
		public static readonly DependencyProperty IsReadOnlyProperty =
			DependencyProperty.Register("IsReadOnly", typeof(bool), typeof(RadComboBox), null);

		/// <summary>
		/// Identifies the IsEditable dependency property.
		/// </summary>
		public static readonly DependencyProperty IsEditableProperty =
			DependencyProperty.Register("IsEditable", typeof(bool), typeof(RadComboBox), new PropertyMetadata(false, OnIsEditableChanged));

		/// <summary>
		/// Identifies the IsMouseWheelEnabledProperty dependency property.
		/// </summary>
		public static readonly DependencyProperty IsMouseWheelEnabledProperty =
			DependencyProperty.Register("IsMouseWheelEnabled", typeof(bool), typeof(RadComboBox), new PropertyMetadata(true, OnIsMouseWheelEnabledChanged));

		/// <summary>
		/// Identifies the OpenDropDownOnFocus dependency property.
		/// </summary>
		public static readonly DependencyProperty OpenDropDownOnFocusProperty =
			DependencyProperty.Register("OpenDropDownOnFocus", typeof(bool), typeof(RadComboBox), null);

		/// <summary>
		/// Identifies the SelectionBoxItem dependency property.
		/// </summary>
		public static readonly DependencyProperty SelectionBoxItemProperty;

		/// <summary>
		/// Identifies the SelectionBoxItemTemplate dependency property.
		/// </summary>
		public static readonly DependencyProperty SelectionBoxItemTemplateProperty;

		/// <summary>
		/// Identifies the SelectionBoxTemplate dependency property.
		/// </summary>
		public static readonly DependencyProperty SelectionBoxTemplateProperty =
			DependencyProperty.Register("SelectionBoxTemplate", typeof(DataTemplate), typeof(RadComboBox), null);

		/// <summary>
		/// Identifies the EmptySelectionBoxTemplate dependency property.
		/// </summary>
		public static readonly DependencyProperty EmptySelectionBoxTemplateProperty =
			DependencyProperty.Register("EmptySelectionBoxTemplate", typeof(DataTemplate), typeof(RadComboBox), null);

		/// <summary>
		/// Identifies the EmptyText dependency property.
		/// </summary>
		public static readonly DependencyProperty EmptyTextProperty =
			DependencyProperty.Register("EmptyText", typeof(string), typeof(RadComboBox), new PropertyMetadata(null, OnEmptyTextChanged));

		/// <summary>
		/// Identifies the Text dependency property.
		/// </summary>
		public static readonly DependencyProperty TextProperty =
			DependencyProperty.Register("Text", typeof(string), typeof(RadComboBox), new PropertyMetadata(null, OnTextChanged));

		/// <summary>
		/// Identifies the FilteringMode dependency property.
		/// </summary>
		public static readonly DependencyProperty IsFilteringEnabledProperty =
			DependencyProperty.Register("IsFilteringEnabled", typeof(bool), typeof(RadComboBox), new PropertyMetadata(false));

		/// <summary>
		/// Identifies the FilteringMode dependency property.
		/// </summary>
		public static readonly DependencyProperty TextSearchModeProperty =
			DependencyProperty.Register("TextSearchMode", typeof(TextSearchMode), typeof(RadComboBox), new PropertyMetadata(TextSearchMode.StartsWith));

		/// <summary>
		/// Identifies the FilteringMode dependency property.
		/// </summary>
		public static readonly DependencyProperty FilteringModeProperty =
			DependencyProperty.Register("FilteringMode", typeof(FilteringMode), typeof(RadComboBox), new PropertyMetadata(FilteringMode.None));

		/// <summary>
		/// Identifies the IsHighlighted dependency property.
		/// </summary>
		public static readonly DependencyProperty IsHighlightedProperty =
			DependencyProperty.Register("IsHighlighted", typeof(bool), typeof(RadComboBox), new PropertyMetadata(false, OnIsHighlightedChanged));

		/// <summary>
		/// Identifies the StaysOpenOnEdit dependency property.
		/// </summary>
		public static readonly DependencyProperty StaysOpenOnEditProperty =
			DependencyProperty.Register("StaysOpenOnEdit", typeof(bool), typeof(RadComboBox), null);

		/// <summary>
		/// Identifies the learSelectionButtonVisibility dependency property.
		/// </summary>
		public static readonly DependencyProperty ClearSelectionButtonVisibilityProperty =
			DependencyProperty.Register("ClearSelectionButtonVisibility", typeof(Visibility), typeof(RadComboBox), new PropertyMetadata(Visibility.Collapsed));

		/// <summary>
		/// Identifies the ClearSelectionButtonContent dependency property.
		/// </summary>
		public static readonly DependencyProperty ClearSelectionButtonContentProperty =
			DependencyProperty.Register("ClearSelectionButtonContent", typeof(object), typeof(RadComboBox), new PropertyMetadata(null));

		/// <summary>
		/// Identifies the SelectAllTextEvents dependency property.
		/// </summary>
		public static readonly DependencyProperty SelectAllTextEventProperty =
			DependencyProperty.Register("SelectAllTextEvent", typeof(SelectAllTextEvents), typeof(RadComboBox), new PropertyMetadata(SelectAllTextEvents.All));

		/// <summary>
		/// Identifies the CanSelectPartialMatches dependency property.
		/// </summary>
		internal static readonly DependencyProperty CanAutocompleteSelectPartialMatchesProperty =
			DependencyProperty.Register("CanAutocompleteSelectPartialMatches", typeof(bool), typeof(RadComboBox), new PropertyMetadata(true));

		private static readonly DependencyPropertyKey SelectionBoxItemTemplatePropertyKey;
		private static readonly DependencyPropertyKey SelectionBoxItemPropertyKey;
		private static readonly DependencyPropertyKey MinDropDownWidthPropertyKey;
		private static readonly DependencyPropertyKey IsWatermarkVisiblePropertyKey;

		private static DataTemplate stringContentTemplate;

		private bool suppressSelectionChanged;
		private System.Windows.Controls.SelectionChangedEventArgs suppressedSelectionChangedEventArgs;
		private bool focusIsInside = false;
		private bool openDropDownOnLoad;
		private bool closeDropDownOnLoad;
		private FrameworkElement clonedElement;
		private WeakReference highlightedElement;
		private bool isLoaded;
		private bool isTemplateApplied;
		private bool updatingTemplate;
		private ToggleButton dropDownButton;
		private Popup dropDownPopup;
		private Button clearButton;
		private DispatcherTimer timeoutTracker;

		private Point lastMousePosition;

		private ScrollViewer scrollViewer;
		private bool updatingSelectedItem;
		private string textInput = string.Empty;
		private TextBox editableTextBox;

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = "Source Analysis")]
		static RadComboBox()
		{
			IsWatermarkVisiblePropertyKey = DependencyPropertyExtensions.RegisterReadOnly("IsWatermarkVisible", typeof(bool), typeof(RadComboBox), new PropertyMetadata(OnIsWatermarkVisibleChanged));
			SelectionBoxItemPropertyKey = DependencyPropertyExtensions.RegisterReadOnly("SelectionBoxItem", typeof(object), typeof(RadComboBox), null);
			MinDropDownWidthPropertyKey = DependencyPropertyExtensions.RegisterReadOnly("MinDropDownWidth", typeof(double), typeof(RadComboBox), null);
			SelectionBoxItemTemplatePropertyKey = DependencyPropertyExtensions.RegisterReadOnly("SelectionBoxItemTemplate", typeof(DataTemplate), typeof(RadComboBox), null);

			IsWatermarkVisibleProperty = IsWatermarkVisiblePropertyKey.DependencyProperty;
			SelectionBoxItemTemplateProperty = SelectionBoxItemTemplatePropertyKey.DependencyProperty;
			SelectionBoxItemProperty = SelectionBoxItemPropertyKey.DependencyProperty;
			MinDropDownWidthProperty = MinDropDownWidthPropertyKey.DependencyProperty;

			CreateStringContentTemplate();


			IsTextSearchEnabledProperty.OverrideMetadata(typeof(RadComboBox), new FrameworkPropertyMetadata(true));

            //DefaultStyleKeyProperty.OverrideMetadata(typeof(RadComboBox),
            //    new FrameworkPropertyMetadata(new ThemeResourceKey(typeof(Office_BlackTheme), typeof(RadComboBox))));

            DefaultStyleKeyProperty.OverrideMetadata(typeof(RadComboBox),
            new FrameworkPropertyMetadata( typeof(RadComboBox)));

			KeyboardNavigation.TabNavigationProperty.OverrideMetadata(typeof(RadComboBox), new FrameworkPropertyMetadata(KeyboardNavigationMode.Local));
			KeyboardNavigation.ControlTabNavigationProperty.OverrideMetadata(typeof(RadComboBox), new FrameworkPropertyMetadata(KeyboardNavigationMode.None));
			KeyboardNavigation.DirectionalNavigationProperty.OverrideMetadata(typeof(RadComboBox), new FrameworkPropertyMetadata(KeyboardNavigationMode.None));

			EventManager.RegisterClassHandler(typeof(RadComboBox), Mouse.PreviewMouseDownEvent, new MouseButtonEventHandler(RadComboBox.OnPreviewMouseButtonDown));

		}

		/// <summary>
		/// Initializes a new instance of the <see cref="RadComboBox"/> class.
		/// </summary>
		public RadComboBox()
		{
            //TelerikLicense.Verify(this);//禁止验证许可

			this.GotFocus += this.RadComboBoxGotFocus;
			this.LostFocus += this.RadComboBoxLostFocus;
			this.Loaded += this.RadComboBoxLoaded;
			this.SizeChanged += this.RadComboBoxSizeChanged;
			this.MouseEnter += this.RadComboBoxMouseEnter;
			this.MouseLeave += this.RadComboBoxMouseLeave;
			this.IsEnabledChanged += (sender, e) => this.ChangeVisualState(true);

			this.AddHandler(RadComboBox.KeyDownEvent, new KeyEventHandler(this.RadComboBoxKeyDown), true);

		}

		/// <summary>
		/// Occurs when the drop-down list of the combo box closes.
		/// </summary>
		public event EventHandler DropDownClosed;

		/// <summary>
		/// Occurs when the drop-down list of the combo box opens.
		/// </summary>
		public event EventHandler DropDownOpened;

		/// <summary>
		/// Gets or sets the command that will be executed when the command source is invoked.
		/// </summary>
		[TypeConverter(typeof(CommandConverter))]
		public ICommand Command
		{
			get { return (ICommand)GetValue(CommandProperty); }
			set { SetValue(CommandProperty, value); }
		}

		/// <summary>
		/// Represents a user defined data value that can be passed to the command when it is executed.
		/// </summary>
		public object CommandParameter
		{
			get { return (object)GetValue(CommandParameterProperty); }
			set { SetValue(CommandParameterProperty, value); }
		}

		/// <summary>
		/// The object that the command is being executed on.
		/// </summary>
		public IInputElement CommandTarget
		{
			get { return (IInputElement)GetValue(CommandTargetProperty); }
			set { SetValue(CommandTargetProperty, value); }
		}

		/// <summary>
		/// Gets or sets the value specifying whether typing a text in a RadComboBox should change the selection.
		/// </summary>
		/// <returns>true if the control should change its selection when the user types text. False when the selection should not be changed. Null when the default behavior should be used.</returns>

		public bool? CanAutocompleteSelectItems
		{
			get { return (bool?)GetValue(CanAutocompleteSelectItemsProperty); }
			set { SetValue(CanAutocompleteSelectItemsProperty, value); }
		}

		/// <summary>
		/// Gets or sets the value specifying whether the keyboard navigation in a RadComboBox should change the selection.
		/// </summary>
		/// <returns>true if the control should change its selection when the user navigates with the keyboard. False when the selection should not be changed. Null when the default behavior should be used.</returns>

		public bool? CanKeyboardNavigationSelectItems
		{
			get { return (bool?)GetValue(CanKeyboardNavigationSelectItemsProperty); }
			set { SetValue(CanKeyboardNavigationSelectItemsProperty, value); }
		}

		/// <summary>
		/// Gets or sets the ControlTemplate for RadCombBox when IsEditable is false.
		/// </summary>
		public ControlTemplate NonEditableTemplate
		{
			get { return (ControlTemplate)GetValue(NonEditableTemplateProperty); }
			set { SetValue(NonEditableTemplateProperty, value); }
		}

		/// <summary>
		/// Gets or sets the ControlTemplate for RadCombBox when IsEditable is true.
		/// </summary>
		public ControlTemplate EditableTemplate
		{
			get { return (ControlTemplate)GetValue(EditableTemplateProperty); }
			set { SetValue(EditableTemplateProperty, value); }
		}

		/// <summary>
		/// Specifies the filtering mode for the RadComboBox. This is a dependency property.
		/// </summary>
		public TextSearchMode TextSearchMode
		{
			get
			{
				return (TextSearchMode)GetValue(TextSearchModeProperty);
			}
			set
			{
				SetValue(TextSearchModeProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets the value indicating whether the filtering is enabled. This is a dependency property.
		/// </summary>
		public bool IsFilteringEnabled
		{
			get
			{
				return (bool)GetValue(IsFilteringEnabledProperty);
			}
			set
			{
				SetValue(IsFilteringEnabledProperty, value);
			}
		}

		/// <summary>
		/// Specifies the filtering mode for the RadComboBox.
		/// </summary>
		[Obsolete("Please, use IsFilteringEnabled and TextSearchMode properties instead", false)]
		public FilteringMode FilteringMode
		{
			get
			{
				if (this.IsFilteringEnabled)
				{
					if (this.TextSearchMode.IsContains())
						return FilteringMode.Contains;
					else if (this.TextSearchMode.IsStartsWith())
						return FilteringMode.StartsWith;
				}
				return FilteringMode.None;
			}
			set
			{
				switch (value)
				{
					case FilteringMode.Contains:
						this.IsFilteringEnabled = true;
						this.TextSearchMode = TextSearchMode.Contains;
						break;
					case FilteringMode.StartsWith:
						this.IsFilteringEnabled = true;
						this.TextSearchMode = TextSearchMode.StartsWith;
						break;
					case FilteringMode.None:
					default:
						this.IsFilteringEnabled = false;
						break;
				}
			}
		}

		/// <summary>
		/// Gets or sets the value that indicates whether the RadComboBox dropdown is 
		/// currently open. This is a dependency property.
		/// </summary>
		public bool IsDropDownOpen
		{
			get
			{
				return (bool)GetValue(IsDropDownOpenProperty);
			}
			set
			{
				SetValue(IsDropDownOpenProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets a value that enables or disables editing of the text 
		/// in text box of the RadComboBox. This is a dependency property.
		/// </summary>
		public bool IsEditable
		{
			get
			{
				return (bool)GetValue(IsEditableProperty);
			}
			set
			{
				SetValue(IsEditableProperty, value);
			}
		}

		/// <summary>
		/// Gets a value indicating whether the watermark of this instance should be visible, or not.
		/// </summary>
		public bool IsWatermarkVisible
		{
			get { return (bool)GetValue(IsWatermarkVisibleProperty); }
			private set { this.SetValue(IsWatermarkVisiblePropertyKey, value); }
		}

		/// <summary>
		/// Gets or sets a value indicating whether this instance is highlighted.
		/// </summary>
		public bool IsHighlighted
		{
			get
			{
				return (bool)GetValue(IsHighlightedProperty);
			}
			set
			{
				SetValue(IsHighlightedProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets a value that specifies whether the dropdown should be opened when the control gets the focus, or not. This is a dependency property.
		/// </summary>
		public bool OpenDropDownOnFocus
		{
			get { return (bool)GetValue(OpenDropDownOnFocusProperty); }
			set { SetValue(OpenDropDownOnFocusProperty, value); }
		}

		/// <summary>
		/// Gets or sets a value that enables selection-only mode, in which the contents of the RadComboBox
		/// are selectable but not editable. This is a dependency property.
		/// </summary>
		public bool IsReadOnly
		{
			get
			{
				return (bool)GetValue(IsReadOnlyProperty);
			}
			set
			{
				SetValue(IsReadOnlyProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets the maximum height for a RadComboBox drop-down. This is a dependency property. 
		/// </summary>
		public double MaxDropDownHeight
		{
			get
			{
				return (double)GetValue(MaxDropDownHeightProperty);
			}
			set
			{
				SetValue(MaxDropDownHeightProperty, value);
			}
		}

		/// <summary>
		/// Gets the minimum width of a RadComboBox drop-down. This is a readonly dependency property. 
		/// </summary>
		public double MinDropDownWidth
		{
			get { return (double)this.GetValue(MinDropDownWidthProperty); }
			private set { this.SetValue(MinDropDownWidthPropertyKey, value); }
		}

		/// <summary>
		/// Gets the item that is currently visible in the selection box ContentPresenter. This is a dependency property.
		/// </summary>
		public object SelectionBoxItem
		{
			get
			{
				return (object)GetValue(SelectionBoxItemProperty);
			}
			private set
			{
				this.SetValue(SelectionBoxItemPropertyKey, value);
			}
		}

		/// <summary>
		/// Gets or sets the DataTemplate that should be applied on the selection box ContentPresenter when there is a selected item. This is a dependency property.
		/// </summary>
		public DataTemplate SelectionBoxTemplate
		{
			get { return (DataTemplate)GetValue(SelectionBoxTemplateProperty); }
			set { SetValue(SelectionBoxTemplateProperty, value); }
		}

		/// <summary>
		/// Gets or sets a string that should be displayed in the selection box ContentPresenter when there is no selection. This is a dependency property.
		/// </summary>
		public string EmptyText
		{
			get { return (string)GetValue(EmptyTextProperty); }
			set { SetValue(EmptyTextProperty, value); }
		}

		/// <summary>
		/// Gets or sets the DataTemplate that should be applied on the selection box ContentPresenter when there is no selection. This is a dependency property.
		/// </summary>
		public DataTemplate EmptySelectionBoxTemplate
		{
			get { return (DataTemplate)GetValue(EmptySelectionBoxTemplateProperty); }
			set { SetValue(EmptySelectionBoxTemplateProperty, value); }
		}

		/// <summary>
		/// Gets the DataTemplate that will be applied on the selection box ContentPresenter. This is a dependency property.
		/// </summary>
		public DataTemplate SelectionBoxItemTemplate
		{
			get
			{
				return (DataTemplate)GetValue(SelectionBoxItemTemplateProperty);
			}
			private set
			{
				this.SetValue(SelectionBoxItemTemplatePropertyKey, value);
			}
		}

		/// <summary>
		/// Gets or sets whether a ComboBox that is open and displays a drop-down control 
		/// will remain open when a user clicks the TextBox. This is a dependency property. 
		/// </summary>
		public bool StaysOpenOnEdit
		{
			get { return (bool)GetValue(StaysOpenOnEditProperty); }
			set { SetValue(StaysOpenOnEditProperty, value); }
		}

		/// <summary>
		/// Gets or sets the value indicating whether the instance will 
		/// respond to MouseWheel events when the dropdown is not open.
		/// </summary>
		public bool IsMouseWheelEnabled
		{
			get
			{
				return (bool)GetValue(IsMouseWheelEnabledProperty);
			}
			set
			{
				SetValue(IsMouseWheelEnabledProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets the text of the currently selected item. This is a dependency property. 
		/// </summary>
		public string Text
		{
			get
			{
				return (string)GetValue(TextProperty);
			}
			set
			{
				SetValue(TextProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets the visibility of the button clearing the selection. This is a dependency property. 
		/// </summary>
		public Visibility ClearSelectionButtonVisibility
		{
			get
			{
				return (Visibility)GetValue(ClearSelectionButtonVisibilityProperty);
			}
			set
			{
				SetValue(ClearSelectionButtonVisibilityProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets the content of the button clearing the selection. This is a dependency property. 
		/// </summary>
		public object ClearSelectionButtonContent
		{
			get
			{
				return (object)GetValue(ClearSelectionButtonContentProperty);
			}
			set
			{
				SetValue(ClearSelectionButtonContentProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets the value that specifies the name of the event that will select the text of the TextBox when IsEditable=true.
		/// </summary>
		public SelectAllTextEvents SelectAllTextEvent
		{
			get { return (SelectAllTextEvents)GetValue(SelectAllTextEventProperty); }
			set { SetValue(SelectAllTextEventProperty, value); }
		}

		/// <summary>
		/// Gets or sets the value specifying whether the partially matching items should be automatically selected, or the user will be required to press Enter to commit the selection.
		/// </summary>
		/// <returns>True if the control select partially mathing items. False when the selection should be commited by pressing Enter.</returns>
		internal bool CanAutocompleteSelectPartialMatches
		{
			get { return (bool)GetValue(CanAutocompleteSelectPartialMatchesProperty); }
			set { SetValue(CanAutocompleteSelectPartialMatchesProperty, value); }
		}

		internal int TextBoxSelectionStart { get; set; }
		internal bool UpdatingText { get; set; }

		internal TextBox EditableTextBox
		{
			get
			{
				return this.editableTextBox;
			}
			set
			{
				if (this.editableTextBox != null)
				{
					this.editableTextBox.TextChanged -= this.OnEditableTextBoxTextChanged;
					this.editableTextBox.SelectionChanged -= this.OnEditableTextBoxSelectionChanged;

				}
				this.editableTextBox = value;
				if (this.editableTextBox != null)
				{
					this.editableTextBox.TextChanged += this.OnEditableTextBoxTextChanged;
					this.editableTextBox.SelectionChanged += this.OnEditableTextBoxSelectionChanged;

				}
			}
		}

		internal object HighlightedItem
		{
			get
			{
				RadComboBoxItem element = this.HighlightedElement;
				if (element != null && element.Visibility == Visibility.Visible)
				{
					return this.ItemContainerGenerator.ItemFromContainer(element);
				}
				return null;
			}
		}

		internal RadComboBoxItem HighlightedElement
		{
			get
			{
				if (this.highlightedElement == null)
				{
					return null;
				}
				return this.highlightedElement.Target as RadComboBoxItem;
			}
			set
			{
				RadComboBoxItem item = (this.highlightedElement != null) ? (this.highlightedElement.Target as RadComboBoxItem) : null;
				if (item != null)
				{
					item.SetIsHighlighted(false);
				}
				if (value != null)
				{
					this.highlightedElement = new WeakReference(value);
					value.SetIsHighlighted(true);
				}
				else
				{
					this.highlightedElement = null;
				}
			}
		}

		internal bool IsDropDownPopupOpen
		{
			get
			{
				return this.dropDownPopup != null && this.dropDownPopup.IsOpen;
			}
		}

		internal bool ShouldHandleKeyboardInput
		{
			get
			{
				return (!this.IsEditable || this.IsReadOnly) && this.IsTextSearchEnabled;
			}
		}

		internal bool IsVirtualizing
		{
			get
			{
				var isVirtualizing = this.ReadLocalValue(VirtualizingStackPanel.IsVirtualizingProperty);
				return isVirtualizing is bool ? (bool)isVirtualizing : false;
			}
		}

		/// <summary>
		/// Gets a value that indicates whether a control supports scrolling.
		/// </summary>
		/// <value></value>
		/// <returns>true if the control has a <see cref="T:System.Windows.Controls.ScrollViewer"/> in its style and has a custom keyboard scrolling behavior; otherwise, false.
		/// </returns>
		protected override bool HandlesScrolling
		{
			get
			{
				return true;
			}
		}

		private bool IsInDesignMode
		{
			get
			{
				return DesignerProperties.GetIsInDesignMode(this);
			}
		}

		private bool IsItemsHostVisible
		{
			get
			{
				return (this.dropDownPopup != null && this.dropDownPopup.IsOpen) || this.dropDownPopup == null;
			}
		}

		private bool KeyboardNavigationShouldSelectItems
		{
			get
			{
				bool keyboardNavigationShouldSelectItems;
				if (this.CanKeyboardNavigationSelectItems.HasValue)
				{
					keyboardNavigationShouldSelectItems = this.CanKeyboardNavigationSelectItems.Value;
				}
				else
				{
					keyboardNavigationShouldSelectItems = this.IsEditable && !this.IsFilteringEnabled;
				}
				return keyboardNavigationShouldSelectItems || !this.IsItemsHostVisible;
			}
		}

		private bool AutoCompleteShouldSelectItems
		{
			get
			{
				bool autoCompleteShouldSelectItems;
				if (this.CanAutocompleteSelectItems.HasValue)
				{
					autoCompleteShouldSelectItems = this.CanAutocompleteSelectItems.Value;
				}
				else
				{
					autoCompleteShouldSelectItems = this.IsEditable;
				}
				return autoCompleteShouldSelectItems || !this.IsItemsHostVisible;
			}
		}

		private bool AutoCompleteShouldSelectPartialMatches
		{
			get
			{
				return this.CanAutocompleteSelectPartialMatches || !this.IsItemsHostVisible;
			}
		}

		private bool IsFocusWithin
		{
			get
			{
				FrameworkElement focusedElement = this.GetFocusedElement() as FrameworkElement;
				if (focusedElement != null)
				{
					return
						focusedElement == this ||
						this.IsAncestorOf(focusedElement) ||
						(this.dropDownPopup != null && (this.dropDownPopup.Child as FrameworkElement).IsAncestorOf(focusedElement));
				}
				return false;
			}
		}

		/// <summary>
		/// When overridden in a derived class, is invoked whenever application code or internal processes (such as a rebuilding layout pass) call <see cref="M:System.Windows.Controls.Control.ApplyTemplate"/>.
		/// </summary>
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();

			// Stop the rest of the initialization if the template is changed
			if (this.UpdateTemplate())
			{
				return;
			}

			this.InitializeDropDownPopup();

			this.InitializeClearButton();

			this.InitializeScrollViewer();

			this.InitializeDropDownButton();

			this.EditableTextBox = GetTemplateChild("PART_EditableTextBox") as TextBox;

			this.UpdateWatermark();

			this.Update();

			this.ChangeVisualState(false);

			this.isTemplateApplied = true;

			if (this.openDropDownOnLoad)
			{
				this.openDropDownOnLoad = false;
				this.OpenDropDownInternal();
			}
			if (this.closeDropDownOnLoad)
			{
				this.closeDropDownOnLoad = false;
				this.CloseDropDownInternal();
			}

			this.ClearAnimationCache();
		}

		void IThemable.ResetTheme()
		{

            //this.DefaultStyleKey = ThemeResourceKey.GetDefaultStyleKey(StyleManager.GetTheme(this), typeof(RadComboBox));

            this.DefaultStyleKey = typeof(RadComboBox);

			this.UpdateTemplate();

		}

		internal RadComboBoxItem ContainerFromItemOrContainer(object item)
		{
			return item as RadComboBoxItem ?? this.ItemContainerGenerator.ContainerFromItem(item) as RadComboBoxItem;
		}

		internal void MoveNext()
		{
			if (this.KeyboardNavigationShouldSelectItems)
			{
				this.SelectNext(1);
			}
			else
			{
				this.NavigateNext(1);
			}
		}

		internal void MoveNextPage()
		{
			if (this.KeyboardNavigationShouldSelectItems)
			{
				this.SelectNext(10);
			}
			else
			{
				this.NavigateNext(10);
			}
		}

		internal void MovePrev()
		{
			if (this.KeyboardNavigationShouldSelectItems)
			{
				this.SelectPrev(1);
			}
			else
			{
				this.NavigatePrev(1);
			}
		}

		internal void MovePrevPage()
		{
			if (this.KeyboardNavigationShouldSelectItems)
			{
				this.SelectPrev(10);
			}
			else
			{
				this.NavigatePrev(10);
			}
		}

		internal void MoveFirst()
		{
			if (this.KeyboardNavigationShouldSelectItems)
			{
				this.SelectFirst();
			}
			else
			{
				this.NavigateFirst();
			}
		}

		internal void MoveLast()
		{
			if (this.KeyboardNavigationShouldSelectItems)
			{
				this.SelectLast();
			}
			else
			{
				this.NavigateLast();
			}
		}

		internal void NavigateToItem(object item)
		{
			if (item != null && this.IsDropDownOpen)
			{
				this.ScrollIntoView(item);

				this.UpdateLayout();

				var container = this.ContainerFromItemOrContainer(item);
				this.HighlightedElement = container;
			}
		}

		internal void NavigateFirst()
		{
			int firstSelectableIndex = this.GetNextSelectableItem(-1);

			if (firstSelectableIndex >= 0)
			{
				this.NavigateToItem(this.Items[firstSelectableIndex]);
				this.ResetTextInputString();
			}
		}

		internal void NavigateLast()
		{
			int lastSelectableIndex = this.GetPreviousSelectableItem(this.Items.Count);

			if (lastSelectableIndex >= 0)
			{
				this.NavigateToItem(this.Items[lastSelectableIndex]);
				this.ResetTextInputString();
			}
		}

		internal void NavigateNext(int increment)
		{
			if (this.Items.Count > 0)
			{
				int highlightedItemIndex = -1;
				if (this.HighlightedElement != null)
				{
					highlightedItemIndex = this.ItemContainerGenerator.IndexFromContainer(this.HighlightedElement);
				}

				for (int i = 0; i < increment; i++)
				{
					highlightedItemIndex = this.GetNextSelectableItem(highlightedItemIndex);

					if (highlightedItemIndex == this.Items.Count - 1)
					{
						break;
					}
				}

				if (highlightedItemIndex >= 0)
				{
					this.NavigateToItem(this.Items[highlightedItemIndex]);
					this.ResetTextInputString();
				}
			}
		}

		internal void NavigatePrev(int increment)
		{
			if (this.Items.Count > 0)
			{
				int highlightedItemIndex = -1;
				if (this.HighlightedElement != null)
				{
					highlightedItemIndex = this.ItemContainerGenerator.IndexFromContainer(this.HighlightedElement);
				}
				for (int i = 0; i < increment; i++)
				{
					if (highlightedItemIndex == -1)
					{
						highlightedItemIndex = this.Items.Count - 1;
						break;
					}
					else
					{
						highlightedItemIndex = this.GetPreviousSelectableItem(highlightedItemIndex);
					}
				}
				this.NavigateToItem(this.Items[highlightedItemIndex]);
				this.ResetTextInputString();
			}
		}

		internal void NotifyComboBoxItemMouseUp(RadComboBoxItem comboBoxItem)
		{
			if (this.IsSelectableHelper(comboBoxItem))
			{
				object item = this.ItemContainerGenerator.ItemFromContainer(comboBoxItem);
				if (item != null && !item.Equals(this.SelectedItem))
				{
					this.SelectItemDelayedSelectionChanged(item);
				}
				this.Close();
			}
		}

		internal bool DidMouseMove()
		{
			Point position = Mouse.GetPosition(null);
			if (position != this.lastMousePosition)
			{
				this.lastMousePosition = position;
				return true;
			}
			return false;
		}

		internal void NotifyComboBoxItemEnter(RadComboBoxItem comboBoxItem)
		{

			if (this.IsDropDownOpen && Mouse.Captured == this && this.DidMouseMove())

			{
				this.HighlightedElement = comboBoxItem;

				if (!this.IsEditable && !comboBoxItem.IsKeyboardFocusWithin)

				{
					comboBoxItem.Focus();
				}
			}
		}

		internal void SelectedItemUpdated()
		{
			try
			{
				this.updatingSelectedItem = true;
				if (!this.UpdatingText)
				{
					string primaryTextFromItem = this.GetPrimaryText(this.SelectedItem);
					if (this.Text != primaryTextFromItem)
					{
						this.Text = primaryTextFromItem;
					}
				}
				this.Update();
			}
			finally
			{
				this.updatingSelectedItem = false;
			}
		}

		internal void SelectFirst()
		{
			this.SelectItemHelper(0, 1, this.Items.Count);
		}

		internal void SelectLast()
		{
			this.SelectItemHelper(this.Items.Count - 1, -1, -1);
		}

		internal void SelectNext(int increment)
		{
			int count = this.Items.Count;
			if (count > 0)
			{
				int selectedIndex = Math.Min(count - 1, this.SelectedIndex + increment);

				this.SelectItemHelper(selectedIndex, increment, count);
			}
		}

		internal void SelectPrev(int increment)
		{
			int count = this.Items.Count;
			if (count > 0)
			{
				int selectedIndex = Math.Max(0, this.SelectedIndex - increment);

				this.SelectItemHelper(selectedIndex, -increment, -1);
			}
		}

		internal void UpdateItemsVisibility(bool showAll, List<int> matchIndices)
		{
			ItemCollection items = this.Items;

			for (int i = 0; i < items.Count; i++)
			{
				FrameworkElement element = this.ItemContainerGenerator.ContainerFromItem(items[i]) as FrameworkElement;
				if (element != null)
				{
					bool isMatch = matchIndices.Contains(i);

					var visibility = showAll || isMatch ? Visibility.Visible : Visibility.Collapsed;

					element.Visibility = visibility;
				}
			}

			this.AdjustPopupLocation();
		}

		internal string GetPrimaryText(object item)
		{
			return TextSearch.GetPrimaryText(item, TextSearch.GetPrimaryTextPath(this));
		}

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
		internal void TextUpdated(string newText, bool textBoxUpdated)
		{
			if (this.UpdatingText || this.updatingSelectedItem)
				return;

			try
			{
				this.UpdatingText = true;

				if (this.IsTextSearchEnabled)
				{
					List<int> matchIndices;
					int fullMatchIndex = this.FindMatchingIndices(newText, out matchIndices);

					if (this.IsFilteringEnabled && this.IsDropDownOpen)
					{
						this.UpdateItemsVisibility(string.IsNullOrEmpty(newText), matchIndices);
					}

					if (matchIndices.Count > 0)
					{
						if (fullMatchIndex < 0 && this.AutoCompleteShouldSelectPartialMatches)
						{
							fullMatchIndex = matchIndices[0];
						}

						object matchingItem = this.Items[matchIndices[0]];

						string matchingItemText = this.GetPrimaryText(matchingItem);

						if (textBoxUpdated)
						{
							if (this.EditableTextBox != null)
							{
								int selectionStart = this.EditableTextBox.SelectionStart;

								var enableAutocomplete = !this.IsFilteringEnabled && this.TextSearchMode.IsStartsWith();
								if (enableAutocomplete)
								{
									if ((this.IsEditable && this.IsReadOnly) || ((selectionStart == newText.Length) && (selectionStart > this.TextBoxSelectionStart)))
									{
										this.EditableTextBox.Text = matchingItemText;
										this.EditableTextBox.SelectionStart = newText.Length;
										this.EditableTextBox.SelectionLength = matchingItemText.Length - newText.Length;

										newText = matchingItemText;
									}
								}
								else
								{
									this.EditableTextBox.Text = newText;
								}
							}
							else if (this.AutoCompleteShouldSelectItems && !this.TextSearchMode.IsCaseSensitive())
							{
								newText = matchingItemText;
							}

							if (this.IsDropDownOpen)
							{
								this.NavigateToItem(matchingItem);
							}
						}
						else
						{
							newText = matchingItemText;
						}
					}

					if (fullMatchIndex != -1 || (fullMatchIndex == -1 && (string.IsNullOrEmpty(newText) || !this.ShouldHandleKeyboardInput)))
					{
						if (fullMatchIndex != this.SelectedIndex && (this.AutoCompleteShouldSelectItems || !textBoxUpdated))
						{
							this.SelectIndexDelayedSelectionChanged(fullMatchIndex);
						}
					}
				}

				if (textBoxUpdated)
				{
					if (this.AutoCompleteShouldSelectItems || !this.ShouldHandleKeyboardInput)
					{
						this.Text = newText;
					}
				}

				if (!textBoxUpdated || (textBoxUpdated && this.IsEditable && this.IsReadOnly && string.IsNullOrEmpty(newText)))
				{
					this.textInput = newText;
					if (this.EditableTextBox != null)
					{
						this.EditableTextBox.Text = newText;
					}
				}
			}
			finally
			{
				this.UpdatingText = false;
			}
		}

		internal void ScrollIntoView(object item)
		{
			var container = this.ItemContainerGenerator.ContainerFromItem(item) as RadComboBoxItem;
			if (container != null)
			{
				container.BringIntoView();
			}
			else
			{
				var itemIndex = this.Items.IndexOf(item);
				if (itemIndex < 0)
				{
					itemIndex = 0;
				}

				this.BringIntoView(itemIndex, 1);
			}
		}

		internal void BringIntoView(int offset, int height)
		{
			if (this.scrollViewer != null)
			{
				var verticalOffset = this.scrollViewer.VerticalOffset;
				if (offset + height > verticalOffset + this.scrollViewer.ViewportHeight)
				{
					this.scrollViewer.ScrollToVerticalOffset(offset - this.scrollViewer.ViewportHeight + height);
				}
				else if (offset < verticalOffset)
				{
					this.scrollViewer.ScrollToVerticalOffset(offset);
				}
			}
		}

		internal void ClearButtonClicked(object sender, RoutedEventArgs e)
		{
			this.SelectIndexDelayedSelectionChanged(-1);
			this.Close();
		}

		internal void RemoveFromTextInputString(int count)
		{
			if (this.textInput.Length > count - 1)
			{
				this.textInput = this.textInput.Remove(this.textInput.Length - count);
				this.TextUpdated(this.textInput, true);

				this.ResetTimeout();
			}
		}

		internal void AddTextInputString(char ch)
		{
			if (!char.IsControl(ch))
			{
				List<int> matchIndices;
				this.FindMatchingIndices(this.textInput + ch, out matchIndices);

				if (matchIndices.Count > 0)
				{
					this.textInput += ch;
					this.TextUpdated(this.textInput, true);
				}

				this.ResetTimeout();
			}
		}

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "platformKeyCode"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
		internal bool HandleKeyDown(Key systemKey, int platformKeyCode)
		{
			switch (systemKey)
			{
				case Key.Escape:
					if (this.IsItemsHostVisible)
					{
						this.KeyboardCloseDropDown(false);
						return true;
					}
					break;

				case Key.PageUp:
					if (this.IsItemsHostVisible)
					{
						this.MovePrevPage();
					}
					else
					{
						this.KeyboardToggleDropDown(true, false);
					}
					return true;

				case Key.PageDown:
					if (this.IsItemsHostVisible)
					{
						this.MoveNextPage();
					}
					else
					{
						this.KeyboardToggleDropDown(true, false);
					}
					return true;

				case Key.F4:
					if ((Keyboard.Modifiers & ModifierKeys.Alt) == ModifierKeys.None)
					{
						this.KeyboardToggleDropDown(true);
						return true;
					}
					break;

				case Key.End:
					if (this.IsEditable)
					{
						break;
					}

					this.MoveLast();
					return true;

				case Key.Home:
					if (this.IsEditable)
					{
						break;
					}

					this.MoveFirst();
					return true;

				case Key.Left:
					if (this.IsEditable)
					{
						break;
					}

					this.MovePrev();
					return true;

				case Key.Right:
					if (this.IsEditable)
					{
						break;
					}

					this.MoveNext();
					return true;

				case Key.Up:
					if ((Keyboard.Modifiers & ModifierKeys.Alt) == ModifierKeys.Alt)
					{
						this.KeyboardToggleDropDown(true, false);
					}
					else
					{
						this.MovePrev();
					}
					return true;

				case Key.Down:
					if ((Keyboard.Modifiers & ModifierKeys.Alt) == ModifierKeys.Alt)
					{
						this.KeyboardToggleDropDown(true, false);
					}
					else
					{
						this.MoveNext();
					}
					return true;


				case Key.Oem5:
					if ((Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control)
					{
						this.NavigateToItem(this.SelectedItem);
						return true;
					}
					break;

				case Key.Space:
					if (this.ShouldHandleKeyboardInput)
					{

						// HACK: The TextInput event is not fired on Space keypress
						if (this.IsReadOnly && this.IsEditable)
						{
							this.AddTextInputString(' ');
							return true;
						}

					}
					break;

				case Key.Enter:
					if (this.IsDropDownOpen)
					{
						this.KeyboardCloseDropDown(true);
						return true;
					}
					break;

				case Key.Back:
					if (this.ShouldHandleKeyboardInput)
					{
						this.RemoveFromTextInputString(1);
						return true;
					}
					break;

				case Key.Tab:
					break;
			}

			return false;
		}

		/// <summary>
		/// Updates the visual state of the control.
		/// </summary>
		/// <param name="useTransitions">Indicates whether transitions should be used.</param>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "useTransitions")]
		protected internal void ChangeVisualState(bool useTransitions)
		{
		}


		/// <summary>
		/// Raises the <see cref="E:System.Windows.FrameworkElement.Initialized"/> event. This method is invoked whenever <see cref="P:System.Windows.FrameworkElement.IsInitialized"/> is set to true internally.
		/// </summary>
		/// <param name="e">The <see cref="T:System.Windows.RoutedEventArgs"/> that contains the event data.</param>
		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			(this as IThemable).ResetTheme();
		}



		/// <summary>
		/// Invoked when an unhandled <see cref="E:System.Windows.Input.Mouse.LostMouseCapture"/> attached event reaches an element in its route that is derived from this class. Implement this method to add class handling for this event.
		/// </summary>
		/// <param name="e">The <see cref="T:System.Windows.Input.MouseEventArgs"/> that contains event data.</param>
		protected override void OnLostMouseCapture(MouseEventArgs e)
		{
			FrameworkElement element = e.OriginalSource as FrameworkElement;
			var combo = element.ParentOfType<RadComboBox>();
			if (combo != null && combo == this && element != this.EditableTextBox)
			{
				Mouse.Capture(this, CaptureMode.SubTree);
			}
			base.OnLostMouseCapture(e);
		}

		/// <summary>
		/// When overridden in a derived class, undoes the effects of the <see cref="M:System.Windows.Controls.ItemsControl.PrepareContainerForItemOverride(System.Windows.DependencyObject,System.Object)"/> method.
		/// </summary>
		/// <param name="element">The container element.</param>
		/// <param name="item">The Item.</param>
		protected override void ClearContainerForItemOverride(DependencyObject element, object item)
		{
			var comboBoxItem = element as RadComboBoxItem;
			if (this.HighlightedElement == comboBoxItem)
			{
				this.HighlightedElement = null;
			}

			base.ClearContainerForItemOverride(element, item);
		}

		/// <summary>
		/// Creates or identifies the element that is used to display the given item.
		/// </summary>
		/// <returns></returns>
		protected override DependencyObject GetContainerForItemOverride()
		{
			return new RadComboBoxItem();
		}

		/// <summary>
		/// Determines if the specified item is (or is eligible to be) its own container.
		/// </summary>
		/// <param name="item">The item to check.</param>
		/// <returns>
		/// True if the item is (or is eligible to be) its own container; otherwise, false.
		/// </returns>
		protected override bool IsItemItsOwnContainerOverride(object item)
		{
			return item is RadComboBoxItem;
		}

		/// <summary>
		/// Prepares the specified element to display the specified item.
		/// </summary>
		/// <param name="element">Element used to display the specified item.</param>
		/// <param name="item">Specified item.</param>
		protected override void PrepareContainerForItemOverride(DependencyObject element, object item)
		{
			base.PrepareContainerForItemOverride(element, item);


			StyleManager.SetTheme(element, StyleManager.GetTheme(this));

		}

		/// <summary>
		/// Invoked when the System.Windows.Controls.ItemsControl.Items property changes.
		/// </summary>
		/// <param name="e">Information about the change.</param>
		protected override void OnItemsChanged(System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			base.OnItemsChanged(e);

			this.AdjustPopupLocation();
		}

		/// <summary>
		/// Raises the <see cref="E:DropDownClosed"/> event.
		/// </summary>
		/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
		protected virtual void OnDropDownClosed(EventArgs e)
		{
			if (this.DropDownClosed != null)
			{
				this.DropDownClosed(this, e);
			}
		}

		/// <summary>
		/// Raises the <see cref="E:DropDownOpened"/> event.
		/// </summary>
		/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
		protected virtual void OnDropDownOpened(EventArgs e)
		{
			if (this.DropDownOpened != null)
			{
				this.DropDownOpened(this, e);
			}
		}

		/// <summary>
		/// Called when the IsDropDownOpen property is changed.
		/// </summary>
		/// <param name="oldValue">The old value of the IsDropDownOpen property.</param>
		/// <param name="newValue">The new value of the IsDropDownOpen property.</param>
		protected virtual void OnIsDropDownOpenChanged(bool oldValue, bool newValue)
		{
			if (newValue)
			{
				if (this.isTemplateApplied)
				{
					this.OpenDropDownInternal();
				}
				else
				{
					this.openDropDownOnLoad = true;
				}
			}
			else
			{
				if (this.isTemplateApplied)
				{
					this.CloseDropDownInternal();
				}
				else
				{
					this.closeDropDownOnLoad = true;
				}
			}

			this.ChangeVisualState(true);
		}

		/// <summary>
		/// Called when the IsEditable property is changed.
		/// </summary>
		/// <param name="oldValue">The old value of the IsEditable property.</param>
		/// <param name="isEditable">The new value of the IsEditable property.</param>
		protected virtual void OnIsEditableChanged(bool oldValue, bool isEditable)
		{
			if (this.isLoaded)
			{
				this.UpdateTemplate();
			}

			this.IsTabStop = !isEditable;
		}

		/// <summary>
		/// Called when the IsMouseWheelEnabled property is changed.
		/// </summary>
		/// <param name="oldValue">The old value of the IsMouseWheelEnabled property.</param>
		/// <param name="isEnabled">The new value of the IsMouseWheelEnabled property.</param>
		protected virtual void OnIsMouseWheelEnabledChanged(bool oldValue, bool isEnabled)
		{
		}

		/// <summary>
		/// Called when the selection changes.
		/// </summary>
		/// <param name="e">The event data.</param>
		protected override void OnSelectionChanged(System.Windows.Controls.SelectionChangedEventArgs e)
		{
			// HACK: When a commanding toolkit that uses attached properties is used (MVVM Lite, Prism, etc.)
			// and when the CommandParameter attached property is bound to SelectedItem (or SelectedIndex)
			// the binding is updated AFTER the SelectionChanged event, which is used to trigger the command.
			if (!this.suppressSelectionChanged)
			{
				this.SelectedItemUpdated();

				base.OnSelectionChanged(e);

				if (this.IsDropDownOpen)
				{
					this.NavigateToItem(this.SelectedItem);
				}

				this.UpdateWatermark();

				this.ExecuteCommand();
			}
			else
			{
				this.suppressedSelectionChangedEventArgs = e;
			}
		}

		/// <summary>
		/// Called when the Text property is changed.
		/// </summary>
		/// <param name="oldValue">The old value of the Text property.</param>
		/// <param name="newValue">The new value of the Text property.</param>
		protected virtual void OnTextChanged(string oldValue, string newValue)
		{
			this.TextUpdated(newValue, false);
		}

		/// <summary>
		/// Called before the <see cref="E:System.Windows.UIElement.MouseWheel"/> event occurs to provide handling for the event in a derived class without attaching a delegate.
		/// </summary>
		/// <param name="e">A <see cref="T:System.Windows.Input.MouseWheelEventArgs"/> that contains the event data.</param>
		protected override void OnMouseWheel(MouseWheelEventArgs e)
		{
			e.Handled = this.HandleMouseWheel(e.Delta);

			base.OnMouseWheel(e);
		}

		/// <summary>
		/// Invoked when the <see cref="E:System.Windows.UIElement.TextInput"/> event is received.
		/// </summary>
		/// <param name="e">Information about the event.</param>
		protected override void OnTextInput(TextCompositionEventArgs e)
		{
			if (this.ShouldHandleKeyboardInput && !string.IsNullOrEmpty(e.Text))
			{
				this.AddTextInputString(e.Text[0]);

				e.Handled = true;
			}

			base.OnTextInput(e);
		}

		/// <summary>
		/// Called when the <see cref="P:System.Windows.UIElement.IsKeyboardFocusWithin"/> property has changed.
		/// </summary>
		/// <param name="e">The event data.</param>
		protected override void OnIsKeyboardFocusWithinChanged(DependencyPropertyChangedEventArgs e)
		{
			base.OnIsKeyboardFocusWithinChanged(e);

			// This is usually used to close the dropdown when the application is switched
			if (this.IsDropDownOpen && !this.IsKeyboardFocusWithin)
			{
				DependencyObject focusedElement = Keyboard.FocusedElement as DependencyObject;
				if (focusedElement == null)
				{
					this.Close();
				}
			}
		}

		/// <summary>
		/// Invoked when an unhandled MouseLeftButtonDown routed event is raised on this element. Implement this 
		/// method to add class handling for this event.
		/// </summary>
		/// <param name="e">
		/// The MouseButtonEventArgs that contains the event data. The event data reports that 
		/// the left mouse button was pressed.
		/// </param>
		protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
		{
			base.OnMouseLeftButtonDown(e);

			e.Handled = true;
			if ((Mouse.Captured == this) && (e.OriginalSource == this))
			{
				this.Close();
			}
		}

		/// <summary>
		/// Invoked when an unhandled MouseLeftButtonUp routed event reaches an element in its route that is derived 
		/// from this class. Implement this method to add class handling for this event.
		/// </summary>
		/// <param name="e">
		/// The MouseButtonEventArgs that contains the event data. The event data reports 
		/// that the left mouse button was released.
		/// </param>
		protected override void OnMouseLeftButtonUp(MouseButtonEventArgs e)
		{
			bool editableTextBoxWasClicked = this.EditableTextBox != null && !this.EditableTextBox.IsAncestorOf(e.OriginalSource as FrameworkElement);

			if (this.dropDownPopup != null && !this.IsMouseOverItemsHost(e.GetPosition(this.dropDownPopup)) &&
				this.IsDropDownOpen && (editableTextBoxWasClicked || this.EditableTextBox == null))
			{
				this.Close();
				e.Handled = true;
			}
			base.OnMouseLeftButtonUp(e);
		}

		private static void OnPreviewMouseButtonDown(object sender, MouseButtonEventArgs e)
		{
			RadComboBox combo = (RadComboBox)sender;
			if (combo.IsEditable)
			{
				Visual originalSource = e.OriginalSource as Visual;
				Visual editableTextBoxSite = combo.EditableTextBox;
				if (((originalSource != null) && (editableTextBoxSite != null)) && editableTextBoxSite.IsAncestorOf(originalSource))
				{
					if (combo.IsDropDownOpen && !combo.StaysOpenOnEdit)
					{
						combo.Close();
					}
					else if (!combo.IsKeyboardFocusWithin)
					{
						combo.Focus();
						e.Handled = true;
					}
				}
			}
		}

		private static void CreateStringContentTemplate()
		{

			stringContentTemplate = new DataTemplate();
			var factory = new FrameworkElementFactory(typeof(TextBlock));
			factory.SetValue(TextBlock.TextProperty, new TemplateBindingExtension(ContentPresenter.ContentProperty));
			stringContentTemplate.VisualTree = factory;
			stringContentTemplate.Seal();

		}

		private static void OnCommandChanged(DependencyObject d, DependencyPropertyChangedEventArgs args)
		{
			(d as RadComboBox).ChangeCommand((ICommand)args.OldValue, (ICommand)args.NewValue);
		}

		private static void OnCommandParameterChanged(DependencyObject d, DependencyPropertyChangedEventArgs args)
		{
			(d as RadComboBox).CanExecuteChanged();
		}

		private static void OnCommandTargetChanged(DependencyObject d, DependencyPropertyChangedEventArgs args)
		{
			(d as RadComboBox).CanExecuteChanged();
		}

		private static void OnTemplateChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
		{
			RadComboBox comboBox = sender as RadComboBox;
			if (null != comboBox && comboBox.isLoaded)
			{
				comboBox.UpdateTemplate();
			}
		}

		private static void OnIsDropDownOpenChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
		{
			RadComboBox comboBox = sender as RadComboBox;
			if (null != comboBox)
			{
				bool oldValue = (bool)e.OldValue;
				bool newValue = (bool)e.NewValue;

				RadComboBoxAutomationPeer peer = FrameworkElementAutomationPeer.FromElement(comboBox) as RadComboBoxAutomationPeer;
				if (null != peer)
				{
					peer.RaiseExpandCollapseAutomationEvent(oldValue, newValue);
				}

				comboBox.OnIsDropDownOpenChanged(oldValue, newValue);
			}
		}

		private static void OnIsEditableChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
		{
			(sender as RadComboBox).OnIsEditableChanged((bool)e.OldValue, (bool)e.NewValue);
		}

		private static void OnIsMouseWheelEnabledChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
		{
			(sender as RadComboBox).OnIsMouseWheelEnabledChanged((bool)e.OldValue, (bool)e.NewValue);
		}

		private static void OnEmptyTextChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
		{
			(sender as RadComboBox).Update();
		}

		private static void OnTextChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
		{
			(sender as RadComboBox).OnTextChanged((string)e.OldValue, (string)e.NewValue);
		}

		private static void OnIsWatermarkVisibleChanged(DependencyObject d, DependencyPropertyChangedEventArgs args)
		{
			(d as RadComboBox).ChangeVisualState(true);
		}

		private static void OnIsHighlightedChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
		{
			(sender as RadComboBox).ChangeVisualState(true);
		}

		private static string ExtractString(DependencyObject d)
		{
			string str = string.Empty;
			TextBlock block = d as TextBlock;
			if (block != null)
			{
				return block.Text;
			}
			UIElement reference = d as UIElement;
			if (reference != null)
			{
				int childrenCount = VisualTreeHelper.GetChildrenCount(reference);
				for (int i = 0; i < childrenCount; i++)
				{
					str = str + ExtractString(VisualTreeHelper.GetChild(reference, i));
				}
				return str;
			}
			if (d != null)
			{
				str = d.ToString();
			}
			return str;
		}

		private bool IsMouseOverItemsHost(Point mousePosition)
		{
			return mousePosition.X > 0 && mousePosition.Y > 0 && mousePosition.X < this.dropDownPopup.Width && mousePosition.Y < this.dropDownPopup.Height;
		}

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic"), System.Diagnostics.Conditional("SILVERLIGHT")]
		private void AdjustPopupLocation()
		{

		}

		private void CloseDropDownInternal()
		{

			if (this.IsKeyboardFocusWithin)
			{
				if (this.IsEditable)
				{
					if (this.EditableTextBox != null && !this.EditableTextBox.IsKeyboardFocusWithin)
					{
						this.Focus();
					}
				}
				else
				{
					this.Focus();
				}
			}

			this.HighlightedElement = null;


			if (Mouse.Captured == this)
			{
				Mouse.Capture(null);
			}

			this.dropDownPopup.IsOpen = false;

			if (this.dropDownButton != null)
			{
				this.dropDownButton.IsChecked = false;
			}
		}

		private void OpenDropDownInternal()
		{

			Mouse.Capture(this, CaptureMode.SubTree);

			if (this.IsEditable && (this.EditableTextBox != null) && !this.UpdatingText)
			{
				if ((this.SelectAllTextEvent & SelectAllTextEvents.DropDownOpen) == SelectAllTextEvents.DropDownOpen)
				{
					this.EditableTextBox.SelectAll();
				}
			}


			this.dropDownPopup.IsOpen = true;

			if (this.dropDownButton != null)
			{
				this.dropDownButton.IsChecked = true;
			}
		}

		private SlideMode GetSlideMode()
		{

			if (this.dropDownPopup != null)
			{
				switch (this.dropDownPopup.Placement)
				{
					case System.Windows.Controls.Primitives.PlacementMode.Absolute:
					case System.Windows.Controls.Primitives.PlacementMode.Center:
					case System.Windows.Controls.Primitives.PlacementMode.Left:
					case System.Windows.Controls.Primitives.PlacementMode.Right:
					case System.Windows.Controls.Primitives.PlacementMode.Top:
						return SlideMode.Bottom;
					case System.Windows.Controls.Primitives.PlacementMode.Bottom:
						return SlideMode.Top;
				}
			}

			return SlideMode.Bottom;
		}

		private void ClearAnimationCache()
		{
			if (this.Resources.Contains("Expand"))
				this.Resources.Remove("Expand");
			if (this.Resources.Contains("Collapse"))
				this.Resources.Remove("Collapse");
		}

		private void Close()
		{
			if (this.IsDropDownOpen)
			{
				this.IsDropDownOpen = false;
			}
		}

		private void CanExecuteChanged(object sender, EventArgs e)
		{
			this.CanExecuteChanged();
		}

		private void CanExecuteChanged()
		{
			if (this.Command != null)
			{
				RoutedCommand routedCommand = this.Command as RoutedCommand;
				if (routedCommand == null)
				{
					this.IsEnabled = this.CommandCanExecute(this.Command);
				}
				else
				{
					this.IsEnabled = this.CommandCanExecute(routedCommand);
				}
			}
		}

		private void ChangeCommand(ICommand oldCommand, ICommand newCommand)
		{
			if (oldCommand != null)
			{
				oldCommand.CanExecuteChanged -= this.CanExecuteChanged;
			}
			if (newCommand != null)
			{
				newCommand.CanExecuteChanged += this.CanExecuteChanged;
			}
			this.CanExecuteChanged();
		}

		private void ExecuteCommand()
		{
			RoutedCommand routedCommand = this.Command as RoutedCommand;
			if (routedCommand != null)
			{
				if (this.CommandCanExecute(routedCommand))
				{
					routedCommand.Execute(this.CommandParameter, this.CommandTarget ?? this);
				}
			}
			else
			{
				ICommand command = this.Command;
				if (command != null)
				{
					if (this.CommandCanExecute(command))
					{
						command.Execute(this.CommandParameter);
					}
				}
			}
		}

		private bool CommandCanExecute(ICommand command)
		{
			return command.CanExecute(this.CommandParameter);
		}

		private bool CommandCanExecute(RoutedCommand routedCommand)
		{
			return routedCommand.CanExecute(this.CommandParameter, this.CommandTarget ?? this);
		}

		private void SelectIndexDelayedSelectionChanged(int index)
		{
			// HACK: When a commanding toolkit that uses attached properties is used (MVVM Lite, Prism, etc.)
			// and when the CommandParameter attached property is bound to SelectedIndex (or SelectedItem)
			// the binding is updated AFTER the SelectionChanged event, which is used to trigger the command.
			try
			{
				this.suppressSelectionChanged = true;
				this.SelectedIndex = index;
			}
			finally
			{
				this.suppressSelectionChanged = false;
				if (this.suppressedSelectionChangedEventArgs != null)
				{
					this.OnSelectionChanged(this.suppressedSelectionChangedEventArgs);
					this.suppressedSelectionChangedEventArgs = null;
				}
			}
		}

		private void SelectItemDelayedSelectionChanged(object item)
		{
			// HACK: When a commanding toolkit that uses attached properties is used (MVVM Lite, Prism, etc.)
			// and when the CommandParameter attached property is bound to SelectedItem (or SelectedIndex)
			// the binding is updated AFTER the SelectionChanged event, which is used to trigger the command.
			try
			{
				this.suppressSelectionChanged = true;
				this.SelectedItem = item;
			}
			finally
			{
				this.suppressSelectionChanged = false;
				if (this.suppressedSelectionChangedEventArgs != null)
				{
					this.OnSelectionChanged(this.suppressedSelectionChangedEventArgs);
					this.suppressedSelectionChangedEventArgs = null;
				}
			}
		}

		private int FindMatchingIndices(string text, out List<int> matchIndices)
		{
			return TextSearch.FindMatchingItems(this, text, this.TextSearchMode, 0, out matchIndices);
		}

		private void DropDownPopupOpened(object sender, EventArgs e)
		{
			Dispatcher.BeginInvoke(new Action(() =>
				{
					this.NavigateToItem(this.SelectedItem);
				}));

			this.UpdateItemsVisibility(true, new List<int>());

			this.OnDropDownOpened(EventArgs.Empty);

			this.ResetTextInputString();
		}

		private void DropDownPopupClosed(object sender, EventArgs e)
		{
			this.OnDropDownClosed(EventArgs.Empty);

			this.ResetTextInputString();

			if (this.ShouldHandleKeyboardInput)
			{
				this.SelectedItemUpdated();
			}

			this.IsDropDownOpen = false;
		}

		private void DropDownButtonClick(object sender, RoutedEventArgs e)
		{
			this.IsDropDownOpen = (bool)this.dropDownButton.IsChecked;

			if (!this.IsFocused)
			{
				this.Focus();
			}
		}

		private int GetPreviousSelectableItem(int startIndex)
		{
			int index = startIndex - 1;
			while (index > -1)
			{
				if (this.IsSelectableHelper(this.ItemContainerGenerator.ContainerFromIndex(index)))
				{
					return index;
				}

				index--;
			}
			return startIndex;
		}

		private int GetNextSelectableItem(int startIndex)
		{
			int index = startIndex + 1;

			while (index < this.Items.Count)
			{
				if (this.IsSelectableHelper(this.ItemContainerGenerator.ContainerFromIndex(index)))
				{
					return index;
				}

				index++;
			}
			return startIndex;
		}

		private bool IsSelectableHelper(object o)
		{
			ContentControl contentControl = o as ContentControl;
			if (contentControl != null)
			{
				return contentControl.IsEnabled && (!this.IsDropDownOpen || (this.IsDropDownOpen && contentControl.Visibility == Visibility.Visible));
			}
			return true;
		}

		private void InitializeDropDownButton()
		{
			if (this.dropDownButton != null)
			{
				this.dropDownButton.Click -= new RoutedEventHandler(this.DropDownButtonClick);
			}
			this.dropDownButton = (GetTemplateChild("PART_DropDownButton") ?? GetTemplateChild("DropDownButton")) as ToggleButton;
			if (this.dropDownButton != null)
			{
				this.dropDownButton.Click += new RoutedEventHandler(this.DropDownButtonClick);
				this.dropDownButton.IsTabStop = false;
			}
		}

		private void InitializeScrollViewer()
		{
			if (this.scrollViewer != null && !this.IsInDesignMode)
			{
				if (!this.IsEditable && this.scrollViewer.Content != null)
				{
					(this.scrollViewer.Content as FrameworkElement).KeyDown -= this.RadComboBoxKeyDown;
				}

			}
			this.scrollViewer = GetTemplateChild("PART_ScrollViewer") as ScrollViewer;
			if (this.scrollViewer != null && !this.IsInDesignMode)
			{
				if (!this.IsEditable && this.scrollViewer.Content != null)
				{
					(this.scrollViewer.Content as FrameworkElement).KeyDown += this.RadComboBoxKeyDown;
				}

			}
		}

		private void InitializeDropDownPopup()
		{
			if (this.dropDownPopup != null)
			{
				this.dropDownPopup.Closed -= new EventHandler(this.DropDownPopupClosed);
				this.dropDownPopup.Opened -= new EventHandler(this.DropDownPopupOpened);


			}
			this.dropDownPopup = GetTemplateChild("PART_Popup") as Popup;
			if (this.dropDownPopup != null)
			{

				this.dropDownPopup.Closed += new EventHandler(this.DropDownPopupClosed);
				this.dropDownPopup.Opened += new EventHandler(this.DropDownPopupOpened);
			}
		}

		private void InitializeClearButton()
		{
			if (this.clearButton != null)
			{
				this.clearButton.Click -= new RoutedEventHandler(this.ClearButtonClicked);
			}
			this.clearButton = GetTemplateChild("PART_ClearButton") as Button;
			if (this.clearButton != null)
			{
				this.clearButton.Click += new RoutedEventHandler(this.ClearButtonClicked);
			}
		}

		private void DropDownPopupWrapperClickedOutsidePopup(object sender, EventArgs e)
		{
			this.IsDropDownOpen = false;
		}

		private void KeyboardCloseDropDown(bool commitSelection)
		{
			this.KeyboardToggleDropDown(false, commitSelection);
		}

		private void KeyboardToggleDropDown(bool commitSelection)
		{
			this.KeyboardToggleDropDown(!this.IsDropDownOpen, commitSelection);
		}

		private void KeyboardToggleDropDown(bool openDropDown, bool commitSelection)
		{
			object item = null;
			if (commitSelection)
			{
				item = this.HighlightedItem;
			}
			this.IsDropDownOpen = openDropDown;
			if ((!openDropDown && commitSelection) && (item != null))
			{
				if (item != null && item != this.SelectedItem)
				{
					this.SelectItemDelayedSelectionChanged(item);
				}
				else
				{
					//// IsEditable=true, type some text to highlight an 
					//// item and when the control autocompletes the item text, hit backspace
					//// to clear the highlight, then hit enter to select the item. The Text 
					//// is not updated. This workarounds the problem.
					this.Text = this.GetPrimaryText(this.SelectedItem);
				}
			}
			this.ResetTextInputString();
		}

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
		private object GetFocusedElement()
		{

			return FocusManager.GetFocusedElement(FocusManager.GetFocusScope(this));

		}

		private void RadComboBoxGotFocus(object sender, RoutedEventArgs e)
		{



			var handled = e.Handled;

			if ((!handled && this.IsEditable) && (this.EditableTextBox != null))
			{
				if (e.OriginalSource == this)
				{
					this.EditableTextBox.Focus();
					handled = true;
				}
				else if (e.OriginalSource == this.EditableTextBox)
				{
					if ((this.SelectAllTextEvent & SelectAllTextEvents.GotFocus) == SelectAllTextEvents.GotFocus)
					{
						this.EditableTextBox.SelectAll();
					}
				}
			}

			e.Handled = handled;

			if (!this.focusIsInside && this.OpenDropDownOnFocus && (this.EditableTextBox == null || (this.EditableTextBox != null && e.OriginalSource == this.EditableTextBox)))
			{
				Dispatcher.BeginInvoke(new Action(() => this.IsDropDownOpen = true));
			}

			this.focusIsInside = true;

			this.UpdateWatermark();
		}

		private void RadComboBoxLostFocus(object sender, RoutedEventArgs e)
		{
			if (!this.IsFocusWithin)
			{

				this.ResetTextInputString();
				this.Close();

				// Refresh the UI in case the autocomplete selected an item, but
				// the Text/EditableTextBox.Text are not synchronized yet. 
				if (this.IsReadOnly)
				{
					this.SelectedItemUpdated();
				}

				this.focusIsInside = false;
			}

			this.UpdateWatermark();
		}

		private void OnEditableTextBoxTextChanged(object sender, TextChangedEventArgs e)
		{
			if (this.IsEditable && !this.IsReadOnly)
			{
				this.TextUpdated(this.EditableTextBox.Text, true);
			}
		}

		private void OnEditableTextBoxSelectionChanged(object sender, RoutedEventArgs e)
		{
			this.TextBoxSelectionStart = this.EditableTextBox.SelectionStart;
		}

		private bool HandleMouseWheel(int delta)
		{
			if (this.IsDropDownOpen || !this.IsMouseWheelEnabled)
			{
				return false;
			}

			if (delta < 0)
			{
				if (this.SelectedIndex < this.Items.Count - 1)
				{
					this.SelectNext(1);
					return true;
				}
			}
			else
			{
				if (this.SelectedIndex > 0)
				{
					this.SelectPrev(1);
					return true;
				}
			}
			return false;
		}

		private void RadComboBoxMouseLeave(object sender, MouseEventArgs e)
		{
			this.IsHighlighted = false;
		}

		private void RadComboBoxMouseEnter(object sender, MouseEventArgs e)
		{
			this.IsHighlighted = true;
		}

		private void RadComboBoxKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
		{
			Key systemKey = e.Key;

			// When IsEditable=false and an item is focused, the KeyDown event is handled twice, hence
			// pressing Up/Down/etc. moves the selection by two instead of one.
			if (e.Handled && e.OriginalSource is RadComboBoxItem)
				return;

			if (systemKey == Key.System)
			{
				systemKey = e.SystemKey;
			}

			int keycode = 0;

			if (this.HandleKeyDown(systemKey, keycode))
			{
				e.Handled = true;
			}
		}

		private void ResetTimeout()
		{
			if (this.IsEditable || this.IsReadOnly)
			{
				return;
			}
			if (this.timeoutTracker == null)
			{
				this.timeoutTracker = new DispatcherTimer();
				this.timeoutTracker.Interval = TextSearch.AutoCompleteTimeout;
				this.timeoutTracker.Tick += (s, e) => this.ClearSearch();
			}
			else
			{
				this.timeoutTracker.Stop();
			}

			this.timeoutTracker.Start();
		}

		private void ClearSearch()
		{
			this.ResetTextInputString();
			if (this.timeoutTracker != null)
			{
				this.timeoutTracker.Stop();
			}
			this.timeoutTracker = null;
		}

		private void ResetTextInputString()
		{
			this.textInput = string.Empty;
		}

		private void RadComboBoxSizeChanged(object sender, SizeChangedEventArgs e)
		{
			if (this.IsInDesignMode)
			{
				return;
			}

			double newWidth = e.NewSize.Width;

			if (!double.IsInfinity(newWidth) &&
				!double.IsNaN(newWidth) &&
				newWidth > 0)
			{
				this.MinDropDownWidth = newWidth;
			}
		}

		private void RadComboBoxLoaded(object sender, RoutedEventArgs e)
		{
			this.isLoaded = true;

			this.CanExecuteChanged();
		}

		private void SelectItemHelper(int startIndex, int increment, int stopIndex)
		{
			for (int i = startIndex; (increment > 0 && i < stopIndex) || (increment < 0 && i > stopIndex); i += increment)
			{
				object item = this.Items[i];
				if (this.IsSelectableHelper(item) && this.IsSelectableHelper(this.ItemContainerGenerator.ContainerFromIndex(i)))
				{
					this.SelectItemDelayedSelectionChanged(item);

					this.ResetTextInputString();
					return;
				}
			}
		}

		private void Update()
		{
			if (this.IsEditable)
			{
				this.UpdateEditableTextBox();
			}
			else
			{
				this.UpdateSelectionBoxItem();
			}
		}

		private void UpdateEditableTextBox()
		{
			if (this.UpdatingText)
			{
				return;
			}

			try
			{
				this.UpdatingText = true;

				string text = this.Text;
				if (text == null)
				{
					text = string.Empty;
				}
				if ((this.EditableTextBox != null) && (this.EditableTextBox.Text != text))
				{
					this.EditableTextBox.Text = text;

					if ((this.SelectAllTextEvent & SelectAllTextEvents.SelectionChanged) == SelectAllTextEvents.SelectionChanged)
					{
						this.EditableTextBox.SelectAll();
					}
				}
			}
			finally
			{
				this.UpdatingText = false;
			}
		}

		private void UpdateSelectionBoxItem()
		{

			if (!this.IsInitialized)
			{
				return;
			}

			object selectedItem = this.SelectedItem;
			DataTemplate itemTemplate = this.SelectionBoxTemplate ?? this.ItemTemplate;
			string itemStringFormat = null;

			itemStringFormat = this.ItemStringFormat;

			ContentControl control = selectedItem as ContentControl;
			if (control != null)
			{
				selectedItem = control.Content;
				itemTemplate = control.ContentTemplate; // ?? this.SelectionBoxItemTemplate;

				itemStringFormat = control.ContentStringFormat;

			}
			if (this.clonedElement != null)
			{
				this.clonedElement.LayoutUpdated -= new EventHandler(this.CloneLayoutUpdated);
				this.clonedElement = null;
			}
			if (((itemTemplate == null) && (this.ItemTemplateSelector == null)) && (itemStringFormat == null))
			{
				if (!string.IsNullOrEmpty(this.DisplayMemberPath))
				{
					if (selectedItem != null)
					{
						selectedItem = this.GetPrimaryText(selectedItem);
					}
				}
				else
				{
					DependencyObject d = selectedItem as DependencyObject;
					if (d != null)
					{
						this.clonedElement = d as FrameworkElement;
						if (this.clonedElement != null)
						{
							this.clonedElement.LayoutUpdated += new EventHandler(this.CloneLayoutUpdated);

							VisualBrush brush = new VisualBrush(this.clonedElement)
							{
								Stretch = Stretch.None,
								ViewboxUnits = BrushMappingMode.Absolute,
								Viewbox = new Rect(this.clonedElement.RenderSize),
								ViewportUnits = BrushMappingMode.Absolute,
								Viewport = new Rect(this.clonedElement.RenderSize)
							};
							FlowDirection direction = (FlowDirection)this.clonedElement.GetValue(FrameworkElement.FlowDirectionProperty);
							DependencyObject parent = VisualTreeHelper.GetParent(this.clonedElement);
							FlowDirection direction2 = (parent == null) ? this.FlowDirection : ((FlowDirection)parent.GetValue(FrameworkElement.FlowDirectionProperty));
							if ((direction != this.FlowDirection) != (direction != direction2))
							{
								brush.Transform = new MatrixTransform(new Matrix(-1.0, 0.0, 0.0, 1.0, this.clonedElement.RenderSize.Width, 0.0));
							}

							Rectangle rectangle = new Rectangle
							{
								Fill = brush,
								Width = this.clonedElement.RenderSize.Width,
								Height = this.clonedElement.RenderSize.Height
							};

							selectedItem = rectangle;
							itemTemplate = null;
						}
						else
						{
							selectedItem = ExtractString(d);
						}
					}
				}
			}

			if (itemTemplate == null && selectedItem != null)
			{
				ContentControl comboBoxItem = this.ItemContainerGenerator.ContainerFromItem(selectedItem) as ContentControl;
				if (comboBoxItem != null)
				{
					itemTemplate = comboBoxItem.ContentTemplate;
				}
				if (itemTemplate == null && this.ItemTemplateSelector != null)
				{
					itemTemplate = this.ItemTemplateSelector.SelectTemplate(selectedItem, null);
				}
			}

			if (selectedItem == null)
			{
				selectedItem = this.EmptyText;
				itemTemplate = this.EmptySelectionBoxTemplate ?? stringContentTemplate;
			}
			this.SelectionBoxItem = selectedItem;
			this.SelectionBoxItemTemplate = itemTemplate;
			////this.SelectionBoxItemStringFormat = itemStringFormat;
		}

		private void UpdateWatermark()
		{
			this.IsWatermarkVisible = !this.IsFocusWithin && this.SelectedItem == null && string.IsNullOrEmpty(this.Text);
		}

		private void CloneLayoutUpdated(object sender, EventArgs e)
		{
			Rectangle selectionBoxItem = (Rectangle)this.SelectionBoxItem;

			selectionBoxItem.Width = this.clonedElement.RenderSize.Width;
			selectionBoxItem.Height = this.clonedElement.RenderSize.Height;
			VisualBrush fill = (VisualBrush)selectionBoxItem.Fill;
			fill.Viewbox = new Rect(this.clonedElement.RenderSize);
			fill.Viewport = new Rect(this.clonedElement.RenderSize);

		}

		/// <summary>
		/// Changes the control template, depending on the IsEditable property.
		/// </summary>
		/// <returns>True when the template is changed, otherwise false.</returns>
		private bool UpdateTemplate()
		{
			if (this.updatingTemplate)
			{
				return false;
			}
			try
			{
				this.updatingTemplate = true;

				ControlTemplate template = null;
				if (this.IsEditable)
				{
					template = this.EditableTemplate;
				}
				else
				{
					template = this.NonEditableTemplate;
				}

				if (this.Template != template)
				{
					this.Template = template;
					this.ApplyTemplate();
					return true;
				}
				return false;
			}
			finally
			{
				this.updatingTemplate = false;
			}
		}

	}
}