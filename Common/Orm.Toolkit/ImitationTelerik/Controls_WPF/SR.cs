using System.Resources;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
	internal partial class SR
	{
		internal const string NotAllowedEditorSettings = "NotAllowedEditorSettings";
		internal const string CannotUseItemsSource = "CannotUseItemsSource";
		internal const string ItemsSourceInUse = "ItemsSourceInUse";

        private const string DefaultNamespace = "Orm.Toolkit.ImitationTelerik";

		public static ResourceManager Resources
		{
			get
			{
				return SRLoader<SR>.GetResources(DefaultNamespace);
			}
		}

		public static object GetObject(string name)
		{
			return SRLoader<SR>.GetObject(DefaultNamespace, name);
		}

		public static string GetString(string name)
		{
			return SRLoader<SR>.GetString(DefaultNamespace, name);
		}

		public static string GetString(string name, params object[] args)
		{
			return SRLoader<SR>.GetString(DefaultNamespace, name, args);
		}
	}
}