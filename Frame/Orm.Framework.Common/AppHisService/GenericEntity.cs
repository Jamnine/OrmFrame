using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Runtime.Serialization;

namespace Orm.Framework.Common
{
    [Serializable]
    [DataContract]
    public abstract class GenericEntity<TId> : Entity, IGenericEntity<TId>
    {
        [DataMember(Order = 1)]
        //[JsonProperty(Order = 1)]
        public virtual TId GUID { get; set; }

        /// <summary>
        /// Checks if this entity is transient (it has not an Id).
        /// </summary>
        /// <returns>True, if this entity is transient</returns>
        public virtual bool IsTransient()
        {
            if (EqualityComparer<TId>.Default.Equals(GUID, default(TId)))
            {
                return true;
            }

            //Workaround for EF Core since it sets int/long to min value when attaching to dbcontext
            if (typeof(TId) == typeof(int))
            {
                return Convert.ToInt32(GUID) <= 0;
            }

            if (typeof(TId) == typeof(long))
            {
                return Convert.ToInt64(GUID) <= 0;
            }

            return false;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is GenericEntity<TId>))
            {
                return false;
            }

            //Same instances must be considered as equal
            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            //Transient objects are not considered as equal
            var other = (GenericEntity<TId>)obj;
            if (IsTransient() && other.IsTransient())
            {
                return false;
            }

            //Must have a IS-A relation of types or must be same type
            var typeOfThis = GetType();
            var typeOfOther = other.GetType();
            if (!typeOfThis.GetTypeInfo().IsAssignableFrom(typeOfOther) && !typeOfOther.GetTypeInfo().IsAssignableFrom(typeOfThis))
            {
                return false;
            }

            //if (this is IMayHaveTenant && other is IMayHaveTenant &&
            //    this.As<IMayHaveTenant>().TenantId != other.As<IMayHaveTenant>().TenantId)
            //{
            //    return false;
            //}

            //if (this is IMustHaveTenant && other is IMustHaveTenant &&
            //    this.As<IMustHaveTenant>().TenantId != other.As<IMustHaveTenant>().TenantId)
            //{
            //    return false;
            //}

            return GUID.Equals(other.GUID);
        }

        public static bool operator ==(GenericEntity<TId> left, GenericEntity<TId> right)
        {
            if (Equals(left, null))
            {
                return Equals(right, null);
            }

            return left.Equals(right);
        }

        public static bool operator !=(GenericEntity<TId> left, GenericEntity<TId> right)
        {
            return !(left == right);
        }

        public override string ToString()
        {
            return $"[{GetType().Name} {GUID}]";
        }

        public override int GetHashCode()
        {
            return GUID.GetHashCode();
        }
    }
}
