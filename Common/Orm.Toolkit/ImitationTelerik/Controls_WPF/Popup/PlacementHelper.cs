using System;
using System.Windows;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
	internal class PlacementHelper
	{
		private Rect viewPortRect;
		private Rect placementRect;
		private Size popupSize;
		private Point offset;
		private FlowDirection flowDirection;

		public PlacementHelper(Rect placementRect, Size popupSize, double horizontalOffset, double verticalOffset)
			: this(placementRect, popupSize, horizontalOffset, verticalOffset, ApplicationHelper.ApplicationSize, FlowDirection.LeftToRight)
		{
		}

		public PlacementHelper(Rect placementRect, Size popupSize, double horizontalOffset, double verticalOffset, FlowDirection flowDirection)
			: this(placementRect, popupSize, horizontalOffset, verticalOffset, ApplicationHelper.ApplicationSize, flowDirection)
		{
		}

		public PlacementHelper(Rect placementRect, Size popupSize, double horizontalOffset, double verticalOffset, Size viewPortSize, FlowDirection flowDirection)
		{
			this.popupSize = popupSize;
			this.placementRect = placementRect;
			this.viewPortRect = new Rect(0, 0, viewPortSize.Width, viewPortSize.Height);
			this.offset = new Point(horizontalOffset, verticalOffset);
			this.flowDirection = flowDirection;
		}

		internal PlacementMode ActualPlacement
		{
			get;
			set;
		}

		private bool IsRightToLeft
		{
			get
			{
				return this.flowDirection == FlowDirection.RightToLeft;
			}
		}

		private double AdjustedLeftForVerticalPlacement
		{
			get
			{
				return Math.Max(0, Math.Min(this.placementRect.Left + this.offset.X, this.viewPortRect.Width - this.popupSize.Width));
			}
		}

		private double AdjustedTopForHorizontalPlacement
		{
			get
			{
				return Math.Max(0, Math.Min(this.placementRect.Top + this.offset.Y, this.viewPortRect.Height - this.popupSize.Height));
			}
		}

		public Point GetPlacementOrigin(PlacementMode placementMode)
		{
			Point placement = this.GetPlacementOriginWithoutRounding(placementMode);
			return new Point(Math.Round(placement.X, 0), Math.Round(placement.Y, 0));
		}

		private Point GetPlacementOriginWithoutRounding(PlacementMode placementMode)
		{
			bool rightToLeft = this.IsRightToLeft;
			if (rightToLeft)
			{
				if (placementMode == PlacementMode.Left)
				{
					placementMode = PlacementMode.Right;
				}
				else if (placementMode == PlacementMode.Right)
				{
					placementMode = PlacementMode.Left;
				}
			}

			switch (placementMode)
			{
				case PlacementMode.Bottom:
					if (this.CanFitBottom())
					{
						this.ActualPlacement = PlacementMode.Bottom;
						return this.FitBottom();
					}
					if (this.CanFitTop())
					{
						this.ActualPlacement = PlacementMode.Top;
						return this.FitTop();
					}
					this.ActualPlacement = PlacementMode.Bottom;
					return this.AdjustForBottom();

				case PlacementMode.Top:
					if (this.CanFitTop())
					{
						this.ActualPlacement = PlacementMode.Top;
						return this.FitTop();
					}
					if (this.CanFitBottom())
					{
						this.ActualPlacement = PlacementMode.Bottom;
						return this.FitBottom();
					}
					this.ActualPlacement = PlacementMode.Top;
					return this.AdjustForTop();

				case PlacementMode.Left:
					if (this.CanFitLeft())
					{
						this.ActualPlacement = PlacementMode.Left;
						if (rightToLeft)
						{
							return this.FitRight();
						}
						else
						{
							return this.FitLeft();
						}
					}
					if (this.CanFitRight())
					{
						this.ActualPlacement = PlacementMode.Right;
						if (rightToLeft)
						{
							return this.FitLeft();
						}
						else
						{
							return this.FitRight();
						}
					}
					if (rightToLeft)
					{
						return this.AdjustForRight();
					}
					else
					{
						return this.AdjustForLeft();
					}

				case PlacementMode.Right:
					if (this.CanFitRight())
					{
						this.ActualPlacement = PlacementMode.Right;
						if (rightToLeft)
						{
							return this.FitLeft();
						}
						else
						{
							return this.FitRight();
						}
					}
					if (this.CanFitLeft())
					{
						this.ActualPlacement = PlacementMode.Left;
						if (rightToLeft)
						{
							return this.FitRight();
						}
						else
						{
							return this.FitLeft();
						}
					}
					this.ActualPlacement = PlacementMode.Right;

					if (rightToLeft)
					{
						return this.AdjustForLeft();
					}
					else
					{
						return this.AdjustForRight();
					}

				case PlacementMode.Center:
					this.ActualPlacement = PlacementMode.Center;
					return this.FitCenter();

				case PlacementMode.Absolute:
					this.ActualPlacement = PlacementMode.Absolute;
					return this.FitAbsolute();

				default:
					throw new NotSupportedException("placementMode");
			}
		}

		private Point FitAbsolute()
		{
			return new Point(this.AdjustedLeftForVerticalPlacement, this.AdjustedTopForHorizontalPlacement);
		}

		private Point FitCenter()
		{
			Point center = new Point(
				Math.Max(0, this.placementRect.X + this.offset.X + ((this.placementRect.Width - this.popupSize.Width) / 2)),
				Math.Max(0, this.placementRect.Y + this.offset.Y + ((this.placementRect.Height - this.popupSize.Height) / 2)));

			if (center.X + this.popupSize.Width > this.viewPortRect.Width)
			{
				center.X = Math.Max(0, this.viewPortRect.Width - this.popupSize.Width);
			}
			if (center.Y + this.popupSize.Height > this.viewPortRect.Height)
			{
				center.Y = Math.Max(0, this.viewPortRect.Height - this.popupSize.Height);
			}
			return center;
		}

		private Point AdjustForRight()
		{
			return new Point(Math.Max(0, this.viewPortRect.Width - this.popupSize.Width), this.AdjustedTopForHorizontalPlacement);
		}

		private Point AdjustForLeft()
		{
			return new Point(0, this.AdjustedTopForHorizontalPlacement);
		}

		private Point FitRight()
		{
			return new Point(this.placementRect.Right + this.offset.X, this.AdjustedTopForHorizontalPlacement);
		}

		private bool CanFitRight()
		{
			return this.placementRect.Right + this.popupSize.Width + this.offset.X < this.viewPortRect.Width;
		}

		private Point FitLeft()
		{
			return new Point(this.placementRect.Left - this.popupSize.Width - this.offset.X, this.AdjustedTopForHorizontalPlacement);
		}

		private bool CanFitLeft()
		{
			return this.placementRect.Left - this.offset.X >= this.popupSize.Width;
		}

		private bool CanFitTop()
		{
			return this.placementRect.Top - this.offset.Y >= this.popupSize.Height;
		}

		private bool CanFitBottom()
		{
			return this.placementRect.Bottom + this.popupSize.Height + this.offset.Y < this.viewPortRect.Height;
		}

		private Point AdjustForTop()
		{
			return new Point(this.AdjustedLeftForVerticalPlacement, 0);
		}

		private Point AdjustForBottom()
		{
			return new Point(this.AdjustedLeftForVerticalPlacement, Math.Max(0, this.viewPortRect.Height - this.popupSize.Height));
		}

		private Point FitBottom()
		{
			return new Point(this.AdjustedLeftForVerticalPlacement, this.placementRect.Bottom + this.offset.Y);
		}

		private Point FitTop()
		{
			return new Point(this.AdjustedLeftForVerticalPlacement, this.placementRect.Top - this.popupSize.Height - this.offset.Y);
		}
	}
}