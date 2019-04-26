using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading;
using System.Windows;
using Orm.Toolkit.Metro.Controls;

namespace Orm.Toolkit.Metro
{
    public static class ThemeManager
    {
        private static IList<Accent> _accents;
        internal static readonly ResourceDictionary DarkResource;
        internal static readonly ResourceDictionary LightResource;

        public static event EventHandler<OnThemeChangedEventArgs> IsThemeChanged;

        static ThemeManager()
        {
            ResourceDictionary dictionary = new ResourceDictionary
            {
                Source = new Uri("pack://application:,,,/Orm.Toolkit;component/AutoMetroControl/Themes/Accents/BaseLight.xaml")
            };
            LightResource = dictionary;
            ResourceDictionary dictionary2 = new ResourceDictionary
            {
                Source = new Uri("pack://application:,,,/Orm.Toolkit;component/AutoMetroControl/Themes/Accents/BaseDark.xaml")
            };
            DarkResource = dictionary2;
        }

        private static void ApplyResourceDictionary(ResourceDictionary newRd, ResourceDictionary oldRd)
        {
            oldRd.BeginInit();
            foreach (DictionaryEntry entry in newRd)
            {
                if (oldRd.Contains(entry.Key))
                {
                    oldRd.Remove(entry.Key);
                }
                oldRd.Add(entry.Key, entry.Value);
            }
            oldRd.EndInit();
        }

        [SecurityCritical]
        public static void ChangeTheme(Application app, Accent newAccent, Theme newTheme)
        {
            if (app == null)
            {
                throw new ArgumentNullException("app");
            }
            Tuple<Theme, Accent> oldThemeInfo = DetectTheme(app);
            ChangeTheme(app.Resources, oldThemeInfo, newAccent, newTheme);
        }

        [SecurityCritical]
        public static void ChangeTheme(ResourceDictionary resources, Accent newAccent, Theme newTheme)
        {
            if (resources == null)
            {
                throw new ArgumentNullException("resources");
            }
            ResourceDictionary newRd = (newTheme == Theme.Light) ? LightResource : DarkResource;
            ApplyResourceDictionary(newAccent.Resources, resources);
            ApplyResourceDictionary(newRd, resources);
        }

        [SecurityCritical]
        public static void ChangeTheme(Window window, Accent newAccent, Theme newTheme)
        {
            if (window == null)
            {
                throw new ArgumentNullException("window");
            }
            Tuple<Theme, Accent> oldThemeInfo = DetectTheme(window);
            ChangeTheme(window.Resources, oldThemeInfo, newAccent, newTheme);
        }

        [SecurityCritical]
        private static void ChangeTheme(ResourceDictionary resources, Tuple<Theme, Accent> oldThemeInfo, Accent newAccent, Theme newTheme)
        {
            bool flag = false;
            if (oldThemeInfo != null)
            {
                Func<ResourceDictionary, bool> predicate = null;
                Accent oldAccent = oldThemeInfo.Item2;
                if ((oldAccent != null) && (oldAccent.Name != newAccent.Name))
                {
                    if (predicate == null)
                    {
                        predicate = d => d.Source == oldAccent.Resources.Source;
                    }
                    ResourceDictionary item = resources.MergedDictionaries.FirstOrDefault<ResourceDictionary>(predicate);
                    if (item != null)
                    {
                        resources.MergedDictionaries.Add(newAccent.Resources);
                        resources.MergedDictionaries.Remove(item);
                        flag = true;
                    }
                }
                Theme theme = oldThemeInfo.Item1;
                if (theme != newTheme)
                {
                    ResourceDictionary oldThemeResource = (theme == Theme.Light) ? LightResource : DarkResource;
                    ResourceDictionary dictionary2 = resources.MergedDictionaries.FirstOrDefault<ResourceDictionary>(d => d.Source == oldThemeResource.Source);
                    if (dictionary2 != null)
                    {
                        ResourceDictionary dictionary3 = (newTheme == Theme.Light) ? LightResource : DarkResource;
                        resources.MergedDictionaries.Add(dictionary3);
                        resources.MergedDictionaries.Remove(dictionary2);
                        flag = true;
                    }
                }
            }
            else
            {
                ChangeTheme(resources, newAccent, newTheme);
                flag = true;
            }
            if (flag)
            {
                OnThemeChanged(newAccent, newTheme);
            }
        }

        public static Tuple<Theme, Accent> DetectTheme()
        {
            try
            {
                return DetectTheme(Application.Current.MainWindow);
            }
            catch (Exception)
            {
                return DetectTheme(Application.Current);
            }
        }

        public static Tuple<Theme, Accent> DetectTheme(Application app)
        {
            if (app == null)
            {
                throw new ArgumentNullException("app");
            }
            return DetectTheme(app.Resources);
        }

        private static Tuple<Theme, Accent> DetectTheme(ResourceDictionary resources)
        {
            if (resources == null)
            {
                throw new ArgumentNullException("resources");
            }
            Theme light = Theme.Light;
            ResourceDictionary themeRd = null;
            Tuple<Theme, Accent> detectedAccentTheme = null;
            if (DetectThemeFromResources(ref light, ref themeRd, resources) && GetThemeFromResources(light, resources, ref detectedAccentTheme))
            {
                return new Tuple<Theme, Accent>(detectedAccentTheme.Item1, detectedAccentTheme.Item2);
            }
            return null;
        }

        public static Tuple<Theme, Accent> DetectTheme(Window window)
        {
            if (window == null)
            {
                throw new ArgumentNullException("window");
            }
            return DetectTheme(window.Resources);
        }

        internal static bool DetectThemeFromAppResources(out Theme detectedTheme, out ResourceDictionary themeRd)
        {
            detectedTheme = Theme.Light;
            themeRd = null;
            return DetectThemeFromResources(ref detectedTheme, ref themeRd, Application.Current.Resources);
        }

        private static bool DetectThemeFromResources(ref Theme detectedTheme, ref ResourceDictionary themeRd, ResourceDictionary dict)
        {
            IEnumerator<ResourceDictionary> enumerator = dict.MergedDictionaries.GetEnumerator();
            while (enumerator.MoveNext())
            {
                ResourceDictionary current = enumerator.Current;
                if ((current.Source == LightResource.Source) || (current.Source == DarkResource.Source))
                {
                    detectedTheme = (current.Source == LightResource.Source) ? Theme.Light : Theme.Dark;
                    themeRd = current;
                    enumerator.Dispose();
                    return true;
                }
                if (DetectThemeFromResources(ref detectedTheme, ref themeRd, current))
                {
                    return true;
                }
            }
            enumerator.Dispose();
            return false;
        }

        internal static bool GetThemeFromResources(Theme presetTheme, ResourceDictionary dict, ref Tuple<Theme, Accent> detectedAccentTheme)
        {
            Theme theme = presetTheme;
            Accent accent = null;
            Accent accent2 = null;
            accent2 = ((List<Accent>)DefaultAccents).Find(x => x.Resources.Source == dict.Source);
            if (accent2 != null)
            {
                accent = accent2;
                detectedAccentTheme = Tuple.Create<Theme, Accent>(theme, accent);
                return true;
            }
            foreach (ResourceDictionary dictionary in dict.MergedDictionaries)
            {
                if (GetThemeFromResources(presetTheme, dictionary, ref detectedAccentTheme))
                {
                    return true;
                }
            }
            return false;
        }

        [SecurityCritical]
        private static void OnThemeChanged(Accent newAccent, Theme newTheme)
        {
            OnThemeChangedEventArgs args = new OnThemeChangedEventArgs
            {
                Theme = newTheme,
                Accent = newAccent
            };
            SafeRaise.Raise<OnThemeChangedEventArgs>(IsThemeChanged, Application.Current, args);
            MethodInfo method = typeof(SystemColors).GetMethod("InvalidateCache", BindingFlags.NonPublic | BindingFlags.Static);
            if (method != null)
            {
                method.Invoke(null, null);
            }
            Assembly assembly = Assembly.GetAssembly(typeof(Window));
            if (assembly != null)
            {
                Type type = assembly.GetType("System.Windows.SystemResources");
                if (type != null)
                {
                    MethodInfo info2 = type.GetMethod("OnThemeChanged", BindingFlags.NonPublic | BindingFlags.Static);
                    if (info2 != null)
                    {
                        info2.Invoke(null, null);
                    }
                    MethodInfo info3 = type.GetMethod("InvalidateResources", BindingFlags.NonPublic | BindingFlags.Static);
                    if (info3 != null)
                    {
                        info3.Invoke(null, new object[] { false });
                    }
                }
            }
        }

        public static IList<Accent> DefaultAccents
        {
            get
            {
                if (_accents == null)
                {
                    //string[] strArray = new string[] { 
                    //    "Red", "Green", "Blue", "Purple", "Orange", "Lime", "Emerald", "Teal", "Cyan", "Cobalt", "Indigo", "Violet", "Pink", "Magenta", "Crimson", "Amber", 
                    //    "Yellow", "Brown", "Olive", "Steel", "Mauve", "Sienna"
                    // };
                    string[] strArray = new string[] { 
                        "Red"
                     };
                    _accents = new List<Accent>(strArray.Length);
                    foreach (string str in strArray)
                    {
                        _accents.Add(new Accent(str, new Uri(string.Format("pack://application:,,,/Orm.Toolkit;component/AutoMetroControl/Themes/Accents/{0}.xaml", str))));
                    }
                }
                return _accents;
            }
        }
    }
}
