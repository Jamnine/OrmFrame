using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;

namespace Orm.Framework.Services.Utility
{
    public class SerializeHelper<T> where T : class
    {
        public void Serialize(bool useBinary, string fileName, T data)
        {

            Stream file = File.Open(fileName, FileMode.Create);
            IFormatter formatter = useBinary ? (IFormatter)new BinaryFormatter() : (IFormatter)new SoapFormatter();

            formatter.Serialize(file, data);

            file.Close();
        }

        public T Deserialize(bool useBinary, string fileName)
        {
            if (!File.Exists(fileName))
            {
                throw (new Exception("files error"));
            }
            Stream file = File.Open(fileName, FileMode.Open);
            IFormatter formatter = useBinary ? (IFormatter)new BinaryFormatter() : (IFormatter)new SoapFormatter();
            try
            {
                T data = formatter.Deserialize(file) as T;
                return data;
            }
            catch (System.Exception ex)
            {
                throw (ex);
            }
            finally
            {
                file.Close();
            }

        }
    }

}

