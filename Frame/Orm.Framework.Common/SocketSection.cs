using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Framework.Common
{
    public class SocketSection : ConfigurationSection
    {
        // Declare the UrlsCollection collection property.
        [ConfigurationProperty("clients", IsDefaultCollection = false)]
        [ConfigurationCollection(typeof(ClientsCollection),
            AddItemName = "add",
            ClearItemsName = "clear",
            RemoveItemName = "remove")]
        public ClientsCollection Clients
        {
            get
            {
                ClientsCollection clientsCollection =
                    (ClientsCollection)base["clients"];

                return clientsCollection;
            }

            set
            {
                ClientsCollection urlsCollection = value;
            }

        }

        // Create a new instance of the UrlsSection.
        // This constructor creates a configuration element 
        // using the UrlConfigElement default values.
        // It assigns this element to the collection.
        public SocketSection()
        {
            ClientConfigElement client = new ClientConfigElement();
            Clients.Add(client);

        }
    }


    // Define the UrlsCollection that contains the 
    // UrlsConfigElement elements.
    // This class shows how to use the ConfigurationElementCollection.
    public class ClientsCollection : ConfigurationElementCollection
    {


        public ClientsCollection()
        {

        }

        public override ConfigurationElementCollectionType CollectionType
        {
            get
            {
                return ConfigurationElementCollectionType.AddRemoveClearMap;
            }
        }

        protected override ConfigurationElement CreateNewElement()
        {
            return new ClientConfigElement();
        }

        protected override Object GetElementKey(ConfigurationElement element)
        {
            return ((ClientConfigElement)element).Name;
        }

        public ClientConfigElement this[int index]
        {
            get
            {
                return (ClientConfigElement)BaseGet(index);
            }
            set
            {
                if (BaseGet(index) != null)
                {
                    BaseRemoveAt(index);
                }
                BaseAdd(index, value);
            }
        }

        new public ClientConfigElement this[string Name]
        {
            get
            {
                return (ClientConfigElement)BaseGet(Name);
            }
        }


        public int IndexOf(ClientConfigElement url)
        {
            return BaseIndexOf(url);
        }

        public void Add(ClientConfigElement url)
        {
            BaseAdd(url);

            // Your custom code goes here.

        }

        protected override void BaseAdd(ConfigurationElement element)
        {
            BaseAdd(element, false);

            // Your custom code goes here.

        }

        public void Remove(ClientConfigElement client)
        {
            if (BaseIndexOf(client) >= 0)
            {
                BaseRemove(client.Name);
            }
        }

        public void RemoveAt(int index)
        {
            BaseRemoveAt(index);

            // Your custom code goes here.

        }

        public void Remove(string name)
        {
            BaseRemove(name);

            // Your custom code goes here.

        }

        public void Clear()
        {
            BaseClear();
        }

    }

    // Define the UrlsConfigElement elements that are contained 
    // by the UrlsCollection.
    public class ClientConfigElement : ConfigurationElement
    {
        public ClientConfigElement()
        {

        }

        [ConfigurationProperty("name", DefaultValue = "Contoso",
            IsRequired = true, IsKey = true)]
        public string Name
        {
            get
            {
                return (string)this["name"];
            }
            set
            {
                this["name"] = value;
            }
        }

        [ConfigurationProperty("ip", DefaultValue = "Any",
            IsRequired = true)]
        public string Ip
        {
            get
            {
                return (string)this["ip"];
            }
            set
            {
                this["ip"] = value;
            }
        }

        [ConfigurationProperty("port", DefaultValue = (int)5555, IsRequired = false)]
        [IntegerValidator(MinValue = 0, MaxValue = 8080, ExcludeRange = false)]
        public int Port
        {
            get
            {
                return (int)this["port"];
            }
            set
            {
                this["port"] = value;
            }
        }
        [ConfigurationProperty("receiveBufferSize", DefaultValue = (int)4096, IsRequired = false)]
        public int ReceiveBufferSize
        {
            get
            {
                return (int)this["receiveBufferSize"];
            }
            set
            {
                this["receiveBufferSize"] = value;
            }
        }
        [ConfigurationProperty("sendBufferSize", DefaultValue = (int)2048, IsRequired = false)]
        public int SendBufferSize
        {
            get
            {
                return (int)this["sendBufferSize"];
            }
            set
            {
                this["sendBufferSize"] = value;
            }
        }
    }
}
