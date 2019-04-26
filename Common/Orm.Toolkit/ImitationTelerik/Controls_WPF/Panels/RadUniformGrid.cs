using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace Orm.Toolkit.Telerik.Windows.Controls.Primitives
{
	/// <summary>
	/// Uniform grid panel with orientation.
	/// </summary>
	[DefaultProperty("ChildrenFlow")]
	public class RadUniformGrid : Panel
	{
		/// <summary>
		/// Identifies the HideFirstColumn dependency property. 
		/// </summary>
		public static readonly DependencyProperty HideFirstColumnProperty =
			DependencyProperty.Register("HideFirstColumn", typeof(bool), typeof(RadUniformGrid), new PropertyMetadata(OnHideChanged));

		/// <summary>
		/// Identifies the HideFirstRow dependency property. 
		/// </summary>
		public static readonly DependencyProperty HideFirstRowProperty =
			DependencyProperty.Register("HideFirstRow", typeof(bool), typeof(RadUniformGrid), new PropertyMetadata(OnHideChanged));
        
		/// <summary>
		/// Identifies the PreserveSpaceForCollapsedChildren dependency property. 
		/// </summary>
		public static readonly DependencyProperty PreserveSpaceForCollapsedChildrenProperty =
			DependencyPropertyExtensions.Register("PreserveSpaceForCollapsedChildren", typeof(bool), typeof(RadUniformGrid), new PropertyMetadata(false, null, null));

		/// <summary>
		/// Identifies the ChildrenFlow dependency property. 
		/// </summary>

        public static readonly DependencyProperty ChildrenFlowProperty =
            DependencyPropertyExtensions.Register("ChildrenFlow", 
            typeof(Orientation),
            typeof(RadUniformGrid),
			new FrameworkPropertyMetadata(Orientation.Horizontal, FrameworkPropertyMetadataOptions.AffectsArrange));


		/// <summary>
		/// Identifies the <see cref="P:Telerik.Windows.Controls.Primitives.RadUniformGrid.Columns"></see> dependency property. 
		/// </summary>
		/// <returns>
		/// The identifier for the <see cref="P:Telerik.Windows.Controls.Primitives.RadUniformGrid.Columns"></see> dependency property.
		/// </returns>

            public static readonly DependencyProperty ColumnsProperty =
            DependencyPropertyExtensions.Register("Columns", 
            typeof(int), 
            typeof(RadUniformGrid),
			new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.AffectsMeasure, OnPropertyChanged));


		/// <summary>
		/// Identifies the <see cref="P:Telerik.Windows.Controls.Primitives.RadUniformGrid.FirstColumn"></see> dependency property. 
		/// </summary>
		/// <returns>
		/// The identifier for the <see cref="P:Telerik.Windows.Controls.Primitives.RadUniformGrid.FirstColumn"></see> dependency property.
		/// </returns>

        public static readonly DependencyProperty FirstColumnProperty = 
            DependencyPropertyExtensions.Register("FirstColumn",
            typeof(int),
            typeof(RadUniformGrid),
			new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.AffectsMeasure, OnPropertyChanged));


		/// <summary>
		/// Identifies the <see cref="P:Telerik.Windows.Controls.Primitives.RadUniformGrid.Rows"></see> dependency property. 
		/// </summary>
		/// <returns>
		/// The identifier for the <see cref="P:Telerik.Windows.Controls.Primitives.RadUniformGrid.Rows"></see> dependency property.
		/// </returns>

        public static readonly DependencyProperty RowsProperty =
			DependencyProperty.Register("Rows", 
            typeof(int), 
            typeof(RadUniformGrid),
			new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.AffectsMeasure, OnPropertyChanged));


		private static readonly DependencyProperty PositionInfoProperty =
			DependencyProperty.RegisterAttached("PositionInfo", typeof(PositionInfo), typeof(RadUniformGrid), null);

		private int columns;
		private int rows;

		/// <summary>
		/// Initializes a new instance of the RadUniformGrid class.
		/// </summary>
		public RadUniformGrid()
		{
            //TelerikLicense.Verify(this);//禁止验证许可


		}

		/// <summary>
		/// Gets or sets the number of columns that are in the grid.
		/// </summary>
		/// <returns>
		/// The number of columns that are in the grid. The default value is zero (0). 
		/// </returns>
		public int Columns
		{
			get
			{
				return (int)GetValue(ColumnsProperty);
			}
			set
			{
				SetValue(ColumnsProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets the number of leading blank cells in the first row of the grid.
		/// </summary>
		/// <returns>
		/// The number of empty cells that are in the first row of the grid. The default value is zero (0).
		/// </returns>
		public int FirstColumn
		{
			get
			{
				return (int)GetValue(FirstColumnProperty);
			}
			set
			{
				SetValue(FirstColumnProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets the number of rows that are in the grid.
		/// </summary>
		/// <returns>
		/// The number of rows that are in the grid. The default value is zero (0).
		/// </returns>
		public int Rows
		{
			get
			{
				return (int)GetValue(RowsProperty);
			}
			set
			{
				SetValue(RowsProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets a value specifying whether a collapsed child's size should be preserved.
		/// </summary>
		public bool PreserveSpaceForCollapsedChildren
		{
			get { return (bool)GetValue(PreserveSpaceForCollapsedChildrenProperty); }
			set { SetValue(PreserveSpaceForCollapsedChildrenProperty, value); }
		}

		/// <summary>
		/// Gets or sets a value that specifies the dimension in which child content is arranged.
		/// </summary>
		/// <returns>
		/// An <see cref="T:System.Windows.Controls.Orientation"></see> value that represents the physical orientation of content within the <see cref="T:Telerik.Windows.Controls.Primitives.RadUniformGrid"></see> as horizontal or vertical. The default value is <see cref="F:System.Windows.Controls.Orientation.Horizontal"></see>.
		/// </returns>
		public Orientation ChildrenFlow
		{
			get { return (Orientation)GetValue(ChildrenFlowProperty); }
			set { SetValue(ChildrenFlowProperty, value); }
		}

		/// <summary>
		/// Gets or sets value that hide or show the first column. This is a Dependency property.
		/// </summary>
		public bool HideFirstColumn
		{
			get { return (bool)GetValue(HideFirstColumnProperty); }
			set { SetValue(HideFirstColumnProperty, value); }
		}

		/// <summary>
		/// Gets or sets value that hide or show the first row. This is a Dependency property.
		/// </summary>
		public bool HideFirstRow
		{
			get { return (bool)GetValue(HideFirstRowProperty); }
			set { SetValue(HideFirstRowProperty, value); }
		}

		private int CalculatedFirstColumn
		{
			get
			{
				int current = this.ChildrenFlow == Orientation.Horizontal ? this.columns : this.rows;
				if (this.FirstColumn >= current)
				{
					return 0;
				}
				else
				{
					return this.FirstColumn;
				}
			}
		}

		private int CalculatedRows
		{
			get
			{
				if (this.HideFirstRow)
				{
					int localRows = this.rows - 1;
					if (localRows < 0)
					{
						return 0;
					}
					return localRows;
				}
				else
				{
					return this.rows;
				}
			}
		}

		private int CalculatedColumns
		{
			get
			{
				if (this.HideFirstColumn)
				{
					int localColumns = this.columns - 1;
					if (localColumns < 0)
					{
						return 0;
					}
					return localColumns;
				}
				else
				{
					return this.columns;
				}
			}
		}

		/// <summary>
		/// Defines the layout of the <see cref="T:Telerik.Windows.Controls.Primitives.RadUniformGrid"></see> by distributing space evenly among all of the child elements.
		/// </summary>
		/// <returns>
		/// The actual <see cref="T:System.Windows.Size"></see> of the grid that is rendered to display the child elements that are visible.
		/// </returns>
		/// <param name="finalSize">
		/// The <see cref="T:System.Windows.Size"></see> of the area for the grid to use.
		/// </param>
		protected override Size ArrangeOverride(Size finalSize)
		{

            bool useRounding = this.SnapsToDevicePixels;
            UIElementCollection collection = this.InternalChildren;

			// TODO: not implemented in the arange algorithm
			// bool horizontal = this.ChildrenFlow == Orientation.Horizontal;

			// TODO: this.CalculatedFirstColumn doesn't have CalculatedFirstRow counterpart! ... should be used here:
			int firstColumn = this.HideFirstColumn ? 1 : 0;
			int firstRow = this.HideFirstRow ? 1 : 0;

			int columnCount = this.CalculatedColumns != 0 ? this.CalculatedColumns : 1;
            int rowCount = this.CalculatedRows != 0 ? this.CalculatedRows : 1;

			double width = finalSize.Width / columnCount;
			double height = finalSize.Height / rowCount;

			int horizontalExtra = 0;
			int verticalExtra = 0;

			Rect currentRect = new Rect();

			if (useRounding)
			{
				width = Math.Floor(width);
				height = Math.Floor(height);

				horizontalExtra = (int)finalSize.Width - ((int)width * columnCount);
				verticalExtra = (int)finalSize.Height - ((int)height * rowCount);

				horizontalExtra = CountMissingExtra(horizontalExtra, columnCount);
				verticalExtra = CountMissingExtra(verticalExtra, rowCount);

				int[] columnX = new int[columnCount];
				int[] columnWidth = new int[columnCount];
				int[] rowY = new int[rowCount];
				int[] rowHeight = new int[rowCount];

				int horizontalSignificientBits = (int)Math.Ceiling(Math.Log(columnCount, 2));
				int verticalSignificientBits = (int)Math.Ceiling(Math.Log(rowCount, 2));

				int currentColumnX = 0, currentRowY = 0, currentColumnWidth = 0, currentRowHeight = 0;
				for (var i = 0; i < columnCount; i++)
				{
					columnX[i] = currentColumnX;
					currentColumnWidth = (int)width + (horizontalExtra > FlipInt(i, horizontalSignificientBits) ? 1 : 0);
					columnWidth[i] = currentColumnWidth;
					currentColumnX += currentColumnWidth;
				}
				for (var i = 0; i < rowCount; i++)
				{
					rowY[i] = currentRowY;
					currentRowHeight = (int)height + (verticalExtra > FlipInt(i, verticalSignificientBits) ? 1 : 0);
					rowHeight[i] = currentRowHeight;
					currentRowY += currentRowHeight;
				}

				foreach (UIElement element in collection)
				{
					PositionInfo pi = GetPositionInfo(element);

					if (pi.Column < firstColumn || pi.Row < firstRow || pi.Row - firstRow >= rowCount || pi.Column - firstColumn >= columnCount)
					{
						// this row or column is hidden so we will move away the child
						currentRect.Width = 0;
						currentRect.Height = 0;
						currentRect.X = double.MinValue;
						currentRect.Y = double.MinValue;
						element.Arrange(currentRect);
					}
					else if (element.Visibility != Visibility.Collapsed || this.PreserveSpaceForCollapsedChildren)
					{
						// this row and column is visible and the child is not collapsed
						currentRect.Width = columnWidth[pi.Column - firstColumn];
						currentRect.Height = rowHeight[pi.Row - firstRow];
						currentRect.X = columnX[pi.Column - firstColumn];
						currentRect.Y = rowY[pi.Row - firstRow];
						element.Arrange(currentRect);
					}
				}
			}
			else
			{
				foreach (UIElement element in collection)
				{
					PositionInfo pi = GetPositionInfo(element);

					currentRect.Width = width;
					currentRect.Height = height;

					if (pi.Column < firstColumn || pi.Row < firstRow)
					{
						// this row or column is hidden so we will move away the child
						currentRect.X = double.MinValue;
						currentRect.Y = double.MinValue;
						element.Arrange(currentRect);
					}
					else if (element.Visibility != Visibility.Collapsed || this.PreserveSpaceForCollapsedChildren)
					{
						// this row and column is visible and the child is not collapsed
						currentRect.X = ((pi.Column - firstColumn) * width) + Math.Min(horizontalExtra, pi.Column - firstColumn);
						currentRect.Y = ((pi.Row - firstRow) * height) + Math.Min(verticalExtra, pi.Row - firstRow);
						element.Arrange(currentRect);
					}
				}
			}

			return finalSize;
		}

		/// <summary>
		/// Computes the desired size of the <see cref="T:Telerik.Windows.Controls.Primitives.RadUniformGrid"></see> by measuring all of the child elements.
		/// </summary>
		/// <returns>
		/// The desired <see cref="T:System.Windows.Size"></see> based on the child content of the grid and the constraint parameter.
		/// </returns>
		/// <param name="availableSize">
		/// The <see cref="T:System.Windows.Size"></see> of the available area for the grid.
		/// </param>
		protected override Size MeasureOverride(Size availableSize)
		{
			this.UpdateComputedValues();
			Size calculatedSize = new Size(availableSize.Width / ((double)this.CalculatedColumns), availableSize.Height / ((double)this.CalculatedRows));

            if (this.SnapsToDevicePixels)

            {
                calculatedSize.Width = Math.Floor(calculatedSize.Width);
                calculatedSize.Height = Math.Floor(calculatedSize.Height);
            }
			double width = 0.0;
			double height = 0.0;
			int start = 0;
			int row = 0;
			int column = 0;

			bool horizontal = this.ChildrenFlow == Orientation.Horizontal;
			if (horizontal)
			{
				column = this.CalculatedFirstColumn;
			}
			else
			{
				row = this.CalculatedFirstColumn;
			}

            int count = this.InternalChildren.Count;

			while (start < count)
			{

                UIElement element = InternalChildren[start];


				PositionInfo pi = GetPositionInfo(element);
				if (pi == null)
				{
					pi = new PositionInfo();
					SetPositionInfo(element, pi);
				}

				pi.Column = column;
				pi.Row = row;

				if (horizontal)
				{
					column++;
					if (column >= this.columns)
					{
						column = 0;
						row++;
					}
				}
				else
				{
					row++;
					if (row >= this.rows)
					{
						row = 0;
						column++;
					}
				}

				element.Measure(calculatedSize);
				Size desiredSize = element.DesiredSize;
				if (width < desiredSize.Width)
				{
					width = desiredSize.Width;
				}
				if (height < desiredSize.Height)
				{
					height = desiredSize.Height;
				}


				if (this.SnapsToDevicePixels)

				{
					width = Math.Ceiling(width);
					height = Math.Ceiling(height);
				}

				start++;
			}
            
            return new Size(width * this.CalculatedColumns, height * this.CalculatedRows);
		}

		private static void OnHideChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			RadUniformGrid ug = d as RadUniformGrid;
			if (ug != null)
			{
				ug.InvalidateMeasure();
				ug.InvalidateArrange();
			}
		}



		private static void OnPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			bool valid = ValidateValue(e.NewValue);
			if (!valid)
			{
				throw new ArgumentOutOfRangeException(e.Property.ToString());
			}
			RadUniformGrid ug = d as RadUniformGrid;
			if (ug != null)
			{
				ug.InvalidateMeasure();
				ug.InvalidateArrange();
			}
		}

		private static PositionInfo GetPositionInfo(DependencyObject obj)
		{
			return (PositionInfo)obj.GetValue(PositionInfoProperty);
		}

		private static void SetPositionInfo(DependencyObject obj, PositionInfo value)
		{
			obj.SetValue(PositionInfoProperty, value);
		}

		private static bool ValidateValue(object o)
		{
			return (int)o >= 0;
		}

		private static int FlipInt(int number, int bitCount)
		{
			int r = 0;
			for (int c = 0; c < bitCount; c++)
			{
				r <<= 1;
				r |= number & 1;
				number >>= 1;
			}
			return r;
		}

		private static int CountMissingExtra(int extra, int cells)
		{
			if (cells <= 0) return extra;
			int significientBits = (int)Math.Ceiling(Math.Log(cells, 2));
			int protoExtraPixels = extra;
			int nextPow = (int)Math.Pow(significientBits, 2) - 1;
			for (int extraToPow = cells; extraToPow < nextPow; extraToPow++)
			{
				if (FlipInt(extraToPow, significientBits) < extra) protoExtraPixels++;
			}
			return protoExtraPixels;
		}

		private void UpdateComputedValues()
		{
			this.columns = this.Columns;
			this.rows = this.Rows;

			if ((this.rows <= 0) || (this.columns <= 0))
			{
				int num = 0;
				int num2 = 0;
				int count = Children.Count;
				while (num2 < count)
				{

                    UIElement element = InternalChildren[num2];

					if (element.Visibility != Visibility.Collapsed || this.PreserveSpaceForCollapsedChildren)
					{
						num++;
					}
					num2++;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (this.rows <= 0)
				{
					if (this.columns > 0)
					{
						this.rows = ((num + this.CalculatedFirstColumn) + (this.columns - 1)) / this.columns;
					}
					else
					{
						this.rows = (int)Math.Sqrt((double)num);
						if ((this.rows * this.rows) < num)
						{
							this.rows++;
						}
						this.columns = this.rows;
					}
				}
				else if (this.columns <= 0)
				{
					this.columns = (num + (this.rows - 1)) / this.rows;
				}
			}
		}
	}
}