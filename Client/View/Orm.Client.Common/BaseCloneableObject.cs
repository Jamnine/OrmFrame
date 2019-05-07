using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Client.Common
{
    [Serializable]
    public abstract class BaseCloneableObject : ICloneable
    {
        //private static readonly BindingFlags BINDING_FLAGS
        //    = BindingFlags.Instance | BindingFlags.Public
        //    | BindingFlags.GetProperty | BindingFlags.SetProperty
        //    | BindingFlags.GetField | BindingFlags.SetField;
        /// <summary>
        /// Clone对象，并返回对象引用
        /// </summary>
        /// <returns>返回对新Clone对象</returns>
        public object Clone()
        {
            BindingFlags BINDING_FLAGS
			= BindingFlags.Instance | BindingFlags.Public 
			| BindingFlags.GetProperty | BindingFlags.SetProperty
			| BindingFlags.GetField  | BindingFlags.SetField;
            //先创建一个新实例
            object newObject = Activator.CreateInstance(this.GetType());

            //取出成员数组
            FieldInfo[] fields = newObject.GetType().GetFields(
                );

            int i = 0;

            foreach (FieldInfo fi in this.GetType().GetFields())
            {
                //如果成员类型支持Clone;
                Type ICloneType = fi.FieldType.GetInterface("ICloneable", true);

                if (ICloneType != null)
                {
                    //从对象取得ICloneable
                    ICloneable IClone = (ICloneable)fi.GetValue(this);

                    //给成员设置值
                    fields[i].SetValue(newObject, IClone.Clone());
                }
                else
                {
                    //如果不支持clone，则
                    fields[i].SetValue(newObject, fi.GetValue(this));
                }

                //如果它是IEnumerable
                Type IEnumerableType = fi.FieldType.GetInterface("IEnumerable", true);
                if (IEnumerableType != null)
                {
                    //取得IEnumerable接口
                    IEnumerable IEnum = (IEnumerable)fi.GetValue(this);

                    //支持IList和IDictionary interfaces
                    Type IListType = fields[i].FieldType.GetInterface("IList", true);
                    Type IDicType = fields[i].FieldType.GetInterface("IDictionary", true);

                    int j = 0;
                    if (IListType != null)
                    {
                        //取得IList接口
                        IList list = (IList)fields[i].GetValue(newObject);

                        foreach (object obj in IEnum)
                        {
                            //检查是否实现ICloneable
                            ICloneType = obj.GetType().GetInterface("ICloneable", true);

                            if (ICloneType != null)
                            {
                                ICloneable clone = (ICloneable)obj;

                                list[j] = clone.Clone();
                            }

                            j++;
                        }
                    }
                    else if (IDicType != null)
                    {
                        //取得dictionary接口.
                        IDictionary dic = (IDictionary)fields[i].GetValue(newObject);
                        j = 0;
                        foreach (DictionaryEntry de in IEnum)
                        {
                           
                            ICloneType = de.Value.GetType().GetInterface("ICloneable", true);

                            if (ICloneType != null)
                            {
                                ICloneable clone = (ICloneable)de.Value;

                                dic[de.Key] = clone.Clone();
                            }
                            j++;
                        }
                    }
                }
                i++;
            }
            System.Reflection.PropertyInfo[] properties = newObject.GetType().GetProperties(BINDING_FLAGS);
            for (int k = 0; k < properties.Length; k++)
            {
                object val= Orm.Client.Common.Property.DynaAccessUtils.GetProperty(this,properties[k].Name);
                if (val == null) continue;
                Property.DynaAccessUtils.SetProperty(newObject, properties[k].Name, val);
            }
            return newObject;
        }
    }
}

