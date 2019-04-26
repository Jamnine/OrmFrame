using System;
using System.Runtime.CompilerServices;
using System.Windows;

namespace Orm.Toolkit.Metro
{
    public class Accent
    {
        public ResourceDictionary Resources;

        public Accent()
        {
        }

        public Accent(string name, Uri resourceAddress)
        {
            this.Name = name;
            ResourceDictionary dictionary = new ResourceDictionary
            {
                Source = resourceAddress
            };
            this.Resources = dictionary;
        }

        public string Name { get; set; }
    }
}
