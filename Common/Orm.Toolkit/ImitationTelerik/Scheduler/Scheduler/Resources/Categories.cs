using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace Orm.Toolkit.Telerik.Windows.Controls.Scheduler
{
    /// <summary>
    /// Categorys class.
    /// </summary>
    public sealed class Categories
    {
		private static Category redCategory;
		private static Category greenCategory;
		private static Category blueCategory;
		private static Category purpleCategory;
		private static Category yellowCategory;
		private static Category oliveCategory;
		private static Category pinkCategory;
		private static Category orangeCategory;
		
		private Categories()
        {
        }

        /// <summary>
        /// Gets all categories.
        /// </summary>
        /// <returns></returns>
        public static CategoryCollection AllCategories
        {
            get
            {
                CategoryCollection categories = new CategoryCollection();
                categories.Add(Categories.RedCategory);
                categories.Add(Categories.GreenCategory);
                categories.Add(Categories.BlueCategory);
                categories.Add(Categories.PurpleCategory);
                categories.Add(Categories.YellowCategory);
                categories.Add(Categories.OliveCategory);
                categories.Add(Categories.PinkCategory);
                categories.Add(Categories.OrangeCategory);
                return categories;
            }
        }

        /// <summary>
        /// Gets the red category.
        /// </summary>
        /// <value>Red Category.</value>
        public static Category RedCategory
        {
            get
            {
				if (redCategory == null)
				{
					LinearGradientBrush brush = GetCategoryBrush("#FFE8807D", "#FFF7D4D2", new Point(0.5, 0), new Point(0.5, 1));
					redCategory = new Category("Red Category", brush);
				}
				return redCategory;
            }
        }

        /// <summary>
        /// Gets the out of green category.
        /// </summary>
        /// <value>Green category.</value>
        public static Category GreenCategory
        {
            get
            {
				if (greenCategory == null)
				{
					LinearGradientBrush brush = GetCategoryBrush("#FF99CC66", "#FFCCFF99", new Point(0.5, 0), new Point(0.5, 1));

					greenCategory = new Category("Green Category", brush);
				}

				return greenCategory;
            }
        }

        /// <summary>
        /// Gets the blue category.
        /// </summary>
        /// <value>Blue category.</value>
        public static Category BlueCategory
        {
            get
            {
				if (blueCategory == null)
				{
					LinearGradientBrush brush = GetCategoryBrush("#FF6C92BF", "#FFC3D6EC", new Point(0.5, 0), new Point(0.5, 1));
					blueCategory = new Category("Blue Category", brush);
				}
				return blueCategory;
            }
        }

        /// <summary>
        /// Gets the purple category.
        /// </summary>
        /// <value>Purple category.</value>
        public static Category PurpleCategory
        {
            get
            {
				if (purpleCategory == null)
				{
					LinearGradientBrush brush = GetCategoryBrush("#FFB687B8", "#FFE9D7EB", new Point(0.5, 0), new Point(0.5, 1));

					purpleCategory = new Category("Purple Category", brush);
				}
				return purpleCategory;
            }
        }

        /// <summary>
        /// Gets the yellow category.
        /// </summary>
        /// <value>Yellow category.</value>
        public static Category YellowCategory
        {
            get
            {
				if (yellowCategory == null)
				{
					LinearGradientBrush brush = GetCategoryBrush("#FFFFD351", "#FFFFFF99", new Point(0.5, 0), new Point(0.5, 1));

					yellowCategory = new Category("Yellow Category", brush);
				}
				return yellowCategory;
            }
        }

        /// <summary>
        /// Gets the olve category.
        /// </summary>
        /// <value>Olive category.</value>
        public static Category OliveCategory
        {
            get
            {
				if (oliveCategory == null)
				{
					LinearGradientBrush brush = GetCategoryBrush("#FFA3AD70", "#FFE5F0CA", new Point(0.5, 0), new Point(0.5, 1));

					oliveCategory = new Category("Olive Category", brush);
				}
				return oliveCategory;
            }
        }

        /// <summary>
        /// Gets the pink category.
        /// </summary>
        /// <value>Pink category.</value>
        public static Category PinkCategory
        {
            get
            {
				if (pinkCategory == null)
				{
					LinearGradientBrush brush = GetCategoryBrush("#FFCE66A2", "#FFF8A2D3", new Point(0.5, 0), new Point(0.5, 1));

					pinkCategory = new Category("Pink Category", brush);
				}
				return pinkCategory;
            }
        }

        /// <summary>
        /// Gets the orange category.
        /// </summary>
        /// <value>Orange category.</value>
        public static Category OrangeCategory
        {
            get
            {
				if (orangeCategory == null)
				{
					LinearGradientBrush brush = GetCategoryBrush("#FFF57238", "#FFFFCC00", new Point(0.5, 0), new Point(0.5, 1));

					orangeCategory = new Category("Orange Category", brush);
				}
				return orangeCategory;
            }
        }
        private static Color GetColorFromCode(string value)
        {
            byte byA = Convert.ToByte(value.Substring(1, 2), 16);
            byte byR = Convert.ToByte(value.Substring(3, 2), 16);
            byte byG = Convert.ToByte(value.Substring(5, 2), 16);
            byte byB = Convert.ToByte(value.Substring(7, 2), 16);
            Color c = Color.FromArgb(byA, byR, byG, byB);
            return c;
        }

        private static LinearGradientBrush GetCategoryBrush(string color1, string color2, Point start, Point end)
        {
            LinearGradientBrush brush = new LinearGradientBrush();
            brush.EndPoint = start;
            brush.StartPoint = end;
            GradientStopCollection stops = new GradientStopCollection();
            var stop1 = new GradientStop();
            stop1.Color = Categories.GetColorFromCode(color1);
            stop1.Offset = 1;
            var stop2 = new GradientStop();
            stop2.Color = Categories.GetColorFromCode(color2);
            stop2.Offset = 0;
            stops.Add(stop1);
            stops.Add(stop2);
            brush.GradientStops = stops;
            return brush;
        }
    }
}
