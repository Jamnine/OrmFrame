using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Client.Common
{
    #region public interface IConfigModel

    [Serializable]
    public abstract class absConfigModel : BaseCloneableObject
    {
        public abstract string Key
        {
            set;
            get;
        }

    }
    #endregion

    #region public class ConfigurationList<T>
    [Serializable]
    public class ConfigurationList<T> : System.Collections.ICollection where T : absConfigModel, new()
    {

        private System.Collections.SortedList list = new System.Collections.SortedList();

        public void Add(string key, T info)
        {
            if (list.ContainsKey(key))
                list.Remove(key);

            list.Add(key, info);
        }
        public void Add(T info)
        {

            if (list.ContainsKey(info.Key))
                list.Remove(info.Key);

            list.Add(info.Key, info);
        }

        public T this[string index]
        {
            get { return (T)list[index]; }
        }

        public T this[int index]
        {
            get { return (T)list.GetByIndex(index); }
        }


        public bool IsSynchronized
        {
            get
            {
                return false;
            }
        }

        public int Count
        {
            get
            {
                return list.Count;
            }
        }

        public void CopyTo(Array array, int index)
        {
            list.CopyTo(array, index);
        }

        public object SyncRoot
        {
            get
            {

                return this;
            }
        }

        public void CopyTo(T[] ary)
        {

            for (int i = 0; i < this.Count; i++)
            {
                ary[i] = this[i];
            }
        }

        public T[] Sort(string key)
        {

            T[] ary = new T[list.Count];
            this.CopyTo(ary);
            int j;
            for (int i = 0; i < ary.Length - 1; i++)
            {
                for (j = i + 1; j < ary.Length; j++)
                {
                    if (CompareTo(ary[i], ary[j], key) > 0)
                    {
                        T temp = (T)ary[i].Clone();
                        ary[i] = (T)ary[j].Clone();
                        ary[j] = temp;
                    }
                }
            }
            return ary;
        }

        private int CompareTo(T compareFrom, T comparedTo, string key)
        {
            string a1 = Client.Common.Property.DynaAccessUtils.GetProperty(compareFrom, key).ToString();
            string a2 = Client.Common.Property.DynaAccessUtils.GetProperty(comparedTo, key).ToString();
            if (Orm.Utilities.Common.IsNumeric(a1) && Orm.Utilities.Common.IsNumeric(a2))
            {
                if (Decimal.Parse(a1) - Decimal.Parse(a2) > 0)
                    return 1;
                else if (Decimal.Parse(a1) - Decimal.Parse(a2) == 0)
                    return 0;
                else
                    return -1;
            }
            if (Orm.Utilities.Common.IsDate(a1) && Orm.Utilities.Common.IsDate(a2))
                return DateTime.Compare(DateTime.Parse(a1), DateTime.Parse(a2));

            return System.String.Compare(a1, a2);

        }

        public System.Collections.IEnumerator GetEnumerator()
        {
            return list.GetEnumerator();
        }
    }

    #endregion

}
