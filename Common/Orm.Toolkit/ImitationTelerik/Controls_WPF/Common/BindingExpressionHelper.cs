using System;
using System.Windows;
using System.Windows.Data;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
	/// <summary>
	/// Provides methods that allow getting property values without reflection.
	/// </summary>
	public class BindingExpressionHelper : FrameworkElement
	{
		private static readonly DependencyProperty ValueProperty = DependencyProperty.Register("Value", typeof(object), typeof(BindingExpressionHelper), null);

		/// <summary>
		/// Gets the value of the property specified by the provided propertyPath.
		/// </summary>
		/// <param name="item">The instance which property value will be returned.</param>
		/// <param name="propertyPath">The path of the property which value will be returned.</param>
		public static object GetValue(object item, string propertyPath)
		{
			if (item == null)
				return null;

			return CreateGetValueFunc(item.GetType(), propertyPath)(item);
		}

		/// <summary>
		/// Returns a Func that will return the value of the property, specified by the provided propertyPath.
		/// </summary>
		/// <param name="itemType">The type of the instance which property will be returned.</param>
		/// <param name="propertyPath">The path of the property which value will be returned.</param>
		public static Func<object, object> CreateGetValueFunc(Type itemType, string propertyPath)
		{
			if (propertyPath != null && propertyPath.IndexOfAny(new char[] { '.', '[', ']', '(', ')' }) > 0)
			{
				return (item) => BindingExpressionHelper.GetValueThroughBinding(item, propertyPath);
			}

			var parameter = System.Linq.Expressions.Expression.Parameter(itemType, "item");

			System.Linq.Expressions.Expression get;
			if (string.IsNullOrEmpty(propertyPath))
			{
				get = parameter;
			}
			else
			{
				try
				{
					get = System.Linq.Expressions.Expression.PropertyOrField(parameter, propertyPath);
				}
				catch (ArgumentException)
				{
					get = System.Linq.Expressions.Expression.Constant(null);
				}
			}

			var lambda = System.Linq.Expressions.Expression.Lambda(get, parameter);

			var compiled = lambda.Compile();

			var methodInfo = typeof(BindingExpressionHelper)
				.GetMethod("ToUntypedFunc", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static)
				.MakeGenericMethod(new[] { itemType, lambda.Body.Type });

			return ((Func<object, object>)methodInfo.Invoke(null, new object[] { compiled }));
		}

		internal static object GetValue(object item, Binding binding)
		{
			return GetValueThroughBinding(item, binding);
		}

		private static object GetValueThroughBinding(object item, Binding binding)
		{
			BindingExpressionHelper helper = new BindingExpressionHelper();
			try
			{
				helper.DataContext = item;
				BindingOperations.SetBinding(helper, ValueProperty, binding);
				return helper.GetValue(ValueProperty);
			}
			finally
			{
				helper.ClearValue(BindingExpressionHelper.ValueProperty);
			}
		}

		private static object GetValueThroughBinding(object item, string propertyPath)
		{
			return GetValueThroughBinding(item, new Binding(propertyPath ?? "."));
		}

		private static Func<object, object> ToUntypedFunc<T, TResult>(Func<T, TResult> func)
		{
			return item => func.Invoke((T)item);
		}
	}
}
