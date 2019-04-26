using System.Globalization;
using System.Resources;
using System.Threading;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
	internal class SRLoader<T>
	{
		private static object internalSyncObject;
		private static SRLoader<T> loader;
		private ResourceManager resources;

		private SRLoader(string defaultNamespace)
		{
            var str = string.Format(CultureInfo.CurrentCulture, "{0}.Strings", defaultNamespace);
            this.resources = new ResourceManager(string.Format(CultureInfo.CurrentCulture, "{0}.Strings", defaultNamespace), typeof(T).Assembly);
            //this.resources = new ResourceManager(string.Format(CultureInfo.GetCultureInfo("EN-US"), "{0}.Strings", defaultNamespace), typeof(T).Assembly);
	
		}

		private static CultureInfo Culture
		{
			get
			{
				return null;
			}
		}

		private static object InternalSyncObject
		{
			get
			{
				if (internalSyncObject == null)
				{
					object newObject = new object();
					Interlocked.CompareExchange(ref internalSyncObject, newObject, null);
				}
				return internalSyncObject;
			}
		}

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes")]
		public static object GetObject(string defaultNamespace, string name)
		{
			SRLoader<T> loader = GetLoader(defaultNamespace);
			if (loader == null)
				return null;

			return loader.resources.GetObject(name, Culture);
		}

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes")]
		public static string GetString(string defaultNamespace, string name)
		{
			SRLoader<T> loader = GetLoader(defaultNamespace);
			if (loader == null)
				return null;

			return loader.resources.GetString(name, Culture);
		}

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes")]
		public static string GetString(string defaultNamespace, string name, params object[] args)
		{
			SRLoader<T> loader = GetLoader(defaultNamespace);
			if (loader == null)
				return null;

			string format = loader.resources.GetString(name, Culture);
			if ((args == null) || (args.Length <= 0))
				return format;

			for (int i = 0; i < args.Length; i++)
			{
				string stringArg = args[i] as string;
				if ((stringArg != null) && (stringArg.Length > 1024))
				{
					args[i] = stringArg.Substring(0, 1021) + "...";
				}
			}
			return string.Format(CultureInfo.CurrentCulture, format, args);
		}

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes")]
		public static ResourceManager GetResources(string defaultNamespace)
		{
			return GetLoader(defaultNamespace).resources;
		}

		private static SRLoader<T> GetLoader(string defaultNamespace)
		{
			if (loader == null)
			{
				lock (InternalSyncObject)
				{
					if (loader == null)
					{
						loader = new SRLoader<T>(defaultNamespace);
					}
				}
			}
			return loader;
		}
	}
}