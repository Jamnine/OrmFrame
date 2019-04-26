using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
    /// <summary>
    /// Positions child elements in sequential position from left to right, breaking content 
    /// to the next line at the edge of the containing box. Subsequent ordering happens 
    /// sequentially from top to bottom or from right to left, depending on the value of 
    /// the Orientation property.
    /// </summary>
	[DefaultProperty("Orientation")]	
    public class RadWrapPanel : Panel
    {
        /// <summary>
        /// Identifies the ItemHeight dependency property.
        /// </summary>
        public static readonly DependencyProperty ItemHeightProperty =
            DependencyProperty.Register("ItemHeight", 
            typeof(double), 
            typeof(RadWrapPanel),
            new PropertyMetadata(OnItemHeightChanged));

        /// <summary>
        /// Identifies the ItemWidth dependency property.
        /// </summary>
        public static readonly DependencyProperty ItemWidthProperty =
            DependencyProperty.Register("ItemWidth", 
            typeof(double), 
            typeof(RadWrapPanel),
            new PropertyMetadata(OnItemHeightChanged));

        /// <summary>
        /// Identifies the Orientation dependency property.
        /// </summary>
        public static readonly DependencyProperty OrientationProperty =
            DependencyProperty.Register("Orientation", 
            typeof(Orientation), 
            typeof(RadWrapPanel),
            new PropertyMetadata(Orientation.Horizontal, RadWrapPanel.OnOrientationChanged));

        /// <summary>
        /// Identifies the AnimationDuration dependency property.
        /// </summary>
        public static readonly DependencyProperty AnimationDurationProperty =
            DependencyProperty.Register("AnimationDuration", typeof(int), typeof(RadWrapPanel), null);

		/// <summary>
		/// Identifies the IsAnimated dependency property.
		/// </summary>
		public static readonly DependencyProperty IsAnimatedProperty =
            DependencyProperty.Register("IsAnimated", typeof(bool), typeof(RadWrapPanel), null);

        private Dictionary<UIElement, Point> previousTopLeftArrangePoint;

        /// <summary>
        /// Initializes a new instance of the <see cref="RadWrapPanel"/> class.
        /// </summary>
        public RadWrapPanel()
        {
            //TelerikLicense.Verify(this);//禁止验证许可

            this.ItemHeight = Double.NaN;
            this.ItemWidth = Double.NaN;

            this.previousTopLeftArrangePoint = new Dictionary<UIElement, Point>();
            this.AnimationDuration = 400;
        }

        /// <summary>
        /// Gets or sets the duration of the animation.
        /// </summary>
        /// <value>The duration of the animation.</value>
        public int AnimationDuration
        {
            get { return (int)GetValue(AnimationDurationProperty); }
            set { SetValue(AnimationDurationProperty, value); }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this RadWrapPanel is animated.
        /// </summary>
        /// <value>
        /// 	<c>True</c> if this instance is animated; otherwise, <c>false</c>.
        /// </value>
        public bool IsAnimated
        {
            get { return (bool)GetValue(IsAnimatedProperty); }
            set { SetValue(IsAnimatedProperty, value); }
        }

        /// <summary>
        /// Gets or sets a value that specifies the height of all items that are 
        /// contained within a WrapPanel. This is a dependency property.
        /// </summary>
        public double ItemHeight
        {
            get
            {
                return (double)GetValue(ItemHeightProperty);
            }
            set
            {
                SetValue(ItemHeightProperty, value);
            }
        }

        /// <summary>
        /// Gets or sets a value that specifies the width of all items that are 
        /// contained within a WrapPanel. This is a dependency property.
        /// </summary>
        public double ItemWidth
        {
            get
            {
                return (double)GetValue(ItemWidthProperty);
            }
            set
            {
                SetValue(ItemWidthProperty, value);
            }
        }

        /// <summary>
        /// Gets or sets a value that specifies the dimension in which child 
        /// content is arranged. This is a dependency property.
        /// </summary>
        public Orientation Orientation
        {
            get
            {
                return (Orientation)this.GetValue(OrientationProperty);
            }
            set
            {
                SetValue(OrientationProperty, value);
            }
        }

        /// <summary>
        /// Provides the behavior for the "Arrange" pass of Silverlight layout. Classes can override this method to define their own arrange pass behavior.
        /// </summary>
        /// <param name="finalSize">The final area within the parent that this element should use to arrange itself and its children.</param>
        /// <returns>The actual size used.</returns>
        protected override Size ArrangeOverride(Size finalSize)
        {
            int start = 0;
            double itemWidth = this.ItemWidth;
            double itemHeight = this.ItemHeight;
            double v = 0.0;
            double itemU = (this.Orientation == Orientation.Horizontal) ? itemWidth : itemHeight;
            UVSize size = new UVSize(this.Orientation);
            UVSize size2 = new UVSize(this.Orientation, finalSize.Width, finalSize.Height);
            bool flag = !Double.IsNaN(itemWidth);
            bool flag2 = !Double.IsNaN(itemHeight);
            bool useItemU = (this.Orientation == Orientation.Horizontal) ? flag : flag2;
            UIElementCollection internalChildren = Children;
            int end = 0;
            int count = internalChildren.Count;

            List<UIElement> readyForDeletion = new List<UIElement>();
            foreach (KeyValuePair<UIElement, Point> item in this.previousTopLeftArrangePoint)
            {
                if (!Children.Contains(item.Key))
                {
                    readyForDeletion.Add(item.Key);
                }
            }

            foreach (UIElement item in readyForDeletion)
            {
                this.previousTopLeftArrangePoint.Remove(item);
            }

            while (end < count)
            {
                UIElement element = internalChildren[end];
                if (element != null && element.Visibility == Visibility.Visible)
                {
                    UVSize size3 = new UVSize(this.Orientation, flag ? itemWidth : element.DesiredSize.Width, flag2 ? itemHeight : element.DesiredSize.Height);
                    if ((size.U + size3.U) > size2.U)
                    {
                        this.ArrangeLine(v, size.V, start, end, useItemU, itemU);
                        v += size.V;
                        size = size3;
                        if (size3.U > size2.U)
                        {
                            this.ArrangeLine(v, size3.V, end, ++end, useItemU, itemU);
                            v += size3.V;
                            size = new UVSize(this.Orientation);
                        }
                        start = end;
                    }
                    else
                    {
                        size.U += size3.U;
                        size.V = Math.Max(size3.V, size.V);
                    }
                }
                end++;
            }
            if (start < internalChildren.Count)
            {
                this.ArrangeLine(v, size.V, start, internalChildren.Count, useItemU, itemU);
            }
            return finalSize;
        }

        /// <summary>
        /// Provides the behavior for the "measure" pass of Silverlight layout. Classes can override this method to define their own measure pass behavior.
        /// </summary>
        /// <param name="availableSize">The available size that this element can give to child elements. Infinity can be specified as a value to indicate that the element will size to whatever content is available.</param>
        /// <returns>
        /// The size that this element determines it needs during layout, based on its calculations of child element sizes.
        /// </returns>
        protected override Size MeasureOverride(Size availableSize)
        {
            UVSize size = new UVSize(this.Orientation);
            UVSize size2 = new UVSize(this.Orientation);
            UVSize size3 = new UVSize(this.Orientation, availableSize.Width, availableSize.Height);
            double itemWidth = this.ItemWidth;
            double itemHeight = this.ItemHeight;
            bool flag = !Double.IsNaN(itemWidth);
            bool flag2 = !Double.IsNaN(itemHeight);
            Size remainingSize = new Size(flag ? itemWidth : availableSize.Width, flag2 ? itemHeight : availableSize.Height);
            UIElementCollection internalChildren = Children;
            int num3 = 0;
            int count = internalChildren.Count;

            while (num3 < count)
            {
                UIElement element = internalChildren[num3];
                if (!this.previousTopLeftArrangePoint.ContainsKey(element))
                {
                    this.previousTopLeftArrangePoint.Add(element, new Point());
                }
                if (element != null)
                {
                    element.Measure(remainingSize);
                    UVSize size5 = new UVSize(this.Orientation, flag ? itemWidth : element.DesiredSize.Width, flag2 ? itemHeight : element.DesiredSize.Height);
                    if ((size.U + size5.U) > size3.U)
                    {
                        size2.U = Math.Max(size.U, size2.U);
                        size2.V += size.V;
                        size = size5;
                        if (size5.U > size3.U)
                        {
                            size2.U = Math.Max(size5.U, size2.U);
                            size2.V += size5.V;
                            size = new UVSize(this.Orientation);
                        }
                    }
                    else
                    {
                        size.U += size5.U;
                        size.V = Math.Max(size5.V, size.V);
                    }
                }
                num3++;
            }
            size2.U = Math.Max(size.U, size2.U);
            size2.V += size.V;
            return new Size(size2.Width, size2.Height);
        }

        private static TranslateTransform GetTranslateTransform(UIElement element, ref int index)
        {
            TranslateTransform translate = null;
            TransformGroup tg = element.RenderTransform as TransformGroup;
            if (tg != null)
            {
                foreach (Transform transform in tg.Children)
                {
                    translate = transform as TranslateTransform;
                    if (translate != null)
                    {
                        index = tg.Children.IndexOf(translate);
                        break;
                    }
                }
            }
            else
            {
                translate = element.RenderTransform as TranslateTransform;
            }
            return translate;
        }

        private static TranslateTransform CreateTranslateTransfort(UIElement element)
        {
            TransformGroup group = new TransformGroup();
            TranslateTransform translation = new TranslateTransform();
            group.Children.Add(translation);
            element.RenderTransform = group;
            return translation;
        }

        private static void OnItemHeightChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!RadWrapPanel.IsWidthHeightValid(e.NewValue))
            {
                throw new ArgumentException("Invalid value");
            }

            RadWrapPanel panel = d as RadWrapPanel;
            if (panel != null)
            {
                panel.InvalidateMeasure();
            }
        }

        private static bool IsWidthHeightValid(object value)
        {
            double num = (double)value;
            return Double.IsNaN(num) || ((num >= 0.0) && !double.IsPositiveInfinity(num));
        }

        private static void OnOrientationChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            RadWrapPanel panel = (RadWrapPanel)d;
            if (panel != null)
            {
                panel.InvalidateMeasure();
                panel.InvalidateArrange();
            }
        }

        private void AnimateLocation(UIElement element, Point previousTopLeft, Point newTopLeft)
        {
            int index = -1;
            TranslateTransform translate = GetTranslateTransform(element, ref index);

            PropertyPath path = null;
            PropertyPath path2 = null;
            if (translate == null)
            {
                translate = CreateTranslateTransfort(element);
                index = 0;
            }

            if (index == -1)
            {
                path = new PropertyPath("(UIElement.RenderTransform).(TranslateTransform.X)");
                path2 = new PropertyPath("(UIElement.RenderTransform).(TranslateTransform.Y)");
            }
            else
            {
                path = new PropertyPath(string.Format(CultureInfo.InvariantCulture, "(UIElement.RenderTransform).(TransformGroup.Children)[{0}].(TranslateTransform.X)", index));
                path2 = new PropertyPath(string.Format(CultureInfo.InvariantCulture, "(UIElement.RenderTransform).(TransformGroup.Children)[{0}].(TranslateTransform.Y)", index));
            }

            Storyboard storyboard = new Storyboard();
            DoubleAnimation doubleAnimationX = this.SetupDoubleAnimation(previousTopLeft.X, newTopLeft.X);
            DoubleAnimation doubleAnimationY = this.SetupDoubleAnimation(previousTopLeft.Y, newTopLeft.Y);

            storyboard.Children.Add(doubleAnimationX);
            storyboard.Children.Add(doubleAnimationY);
            Storyboard.SetTarget(doubleAnimationX, element);
            Storyboard.SetTargetProperty(doubleAnimationX, path);
            Storyboard.SetTarget(doubleAnimationY, element);
            Storyboard.SetTargetProperty(doubleAnimationY, path2);

            storyboard.Begin();
        }

        private DoubleAnimation SetupDoubleAnimation(double from, double to)
        {
            DoubleAnimation customDoubleAnimation = new DoubleAnimation();
            customDoubleAnimation.From = from - to;
            customDoubleAnimation.To = 0;
            customDoubleAnimation.Duration = new Duration(TimeSpan.FromMilliseconds(this.AnimationDuration));
            customDoubleAnimation.AutoReverse = false;

            return customDoubleAnimation;
        }

        private void ArrangeLine(double v, double lineV, int start, int end, bool useItemU, double itemU)
        {
            double num = 0.0;
            bool flag = this.Orientation == Orientation.Horizontal;
            UIElementCollection internalChildren = Children;
            for (int i = start; i < end; i++)
            {
                UIElement element = internalChildren[i];
                if (element != null)
                {
                    UVSize size = new UVSize(this.Orientation, element.DesiredSize.Width, element.DesiredSize.Height);
                    double num3 = useItemU ? itemU : size.U;
                    Rect finalRect = new Rect(flag ? num : v, flag ? v : num, flag ? num3 : lineV, flag ? lineV : num3);

                    Point previousTopLeft = this.previousTopLeftArrangePoint[element];
                    Point newTopLeft = new Point(finalRect.Left, finalRect.Top);

                    int index = -1;
                    TranslateTransform tt = GetTranslateTransform(element, ref index);

                    if (element.Visibility == Visibility.Visible && this.IsAnimated)
                    {
                        if (tt != null && tt.X != previousTopLeft.X && tt.Y != previousTopLeft.Y)
                        {
                            previousTopLeft.X = -tt.X;
                            previousTopLeft.Y = -tt.Y;
                        }
                        if (newTopLeft != previousTopLeft)
                        {
                            this.AnimateLocation(element, previousTopLeft, newTopLeft);
                        }
                    }
                    else
                    {
                        if (tt != null)
                        {
                            tt.X = tt.Y = 0;
                        }
                    }

                    this.previousTopLeftArrangePoint[element] = newTopLeft;

                    element.Arrange(finalRect);
                    if (element.Visibility == Visibility.Visible)
                    {
                        num += num3;
                    }                    
                }
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct UVSize
        {
            internal double U;
            internal double V;
            private Orientation orientation;
            internal UVSize(Orientation orientation, double width, double height)
            {
                this.U = this.V = 0.0;
                this.orientation = orientation;
                this.Width = width;
                this.Height = height;
            }

            internal UVSize(Orientation orientation)
            {
                this.U = this.V = 0.0;
                this.orientation = orientation;
            }

            internal double Width
            {
                get
                {
                    if (this.orientation != Orientation.Horizontal)
                    {
                        return this.V;
                    }
                    return this.U;
                }
                set
                {
                    if (this.orientation == Orientation.Horizontal)
                    {
                        this.U = value;
                    }
                    else
                    {
                        this.V = value;
                    }
                }
            }
            internal double Height
            {
                get
                {
                    if (this.orientation != Orientation.Horizontal)
                    {
                        return this.U;
                    }
                    return this.V;
                }
                set
                {
                    if (this.orientation == Orientation.Horizontal)
                    {
                        this.V = value;
                    }
                    else
                    {
                        this.U = value;
                    }
                }
            }
        }
    }
}
