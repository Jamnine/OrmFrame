using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orm.Model;
using Orm.Model.EnumDefine;

namespace Orm.Framework.Services
{
    public class SysParamService : DBClientBase, ISysParamService
    {
        private const char LeftSquareBracket = '[';
        private const char RightSquareBracket = ']';
        private const char Comma = ',';
        private const char VerticalLine = '|';
        #region 获取系统参数

        public T GetByName<T>(string name)
        {
            var param = GetParamByName(name);

            var value = param.SetValue;

            if (string.IsNullOrWhiteSpace(value))
            {
                if (typeof(T).Equals(typeof(string)))
                {
                    return (T)Convert.ChangeType(string.Empty, typeof(T));
                }

                return default(T);
            }

            return (T)Convert.ChangeType(value, typeof(T));
        }

        public T[] GetByName<T>(string name, ParamDelimiter delimiter)
        {
            var value = GetByName<string>(name);

            if (string.IsNullOrWhiteSpace(value))
            {
                return new T[] { };
            }

            return GetArrayByDelimiter<T>(value, delimiter);
        }

        public bool Contains<T>(string name, T value, ParamDelimiter delimiter)
        {
            var paramArray = GetByName<T>(name, delimiter);

            return paramArray.Where(x => x.Equals(value)).Any();
        }

        public List<GblSetting> GetByNames(string[] names)
        {
            IEnumerable<GblSetting> lstParamSystem = new List<GblSetting>();
            var sysParams = this.GetAllList<GblSetting>();
            //var sysParams = this.DataRepository().GetQueryable<GblSetting>();
            var lstSysParam = sysParams.Where(x => names.Contains(x.KeyNum)).ToList();
            lstParamSystem = from sysParam in lstSysParam
                             select new GblSetting
                             {
                                 KeyNum = sysParam.KeyNum,
                                 SetValue = sysParam.SetValue
                             };
            if (lstParamSystem.Count() != names.Length)
            {
                var notSysParam = names.Where(t => !lstParamSystem.Where(m => string.Equals(m.KeyNum, t, StringComparison.InvariantCultureIgnoreCase)).Select(x => x.KeyNum).Any()).ToList();
                var errMsg = $"Invalid param name: {string.Join(",", notSysParam)}";

                throw new Exception(errMsg);
            }
            return lstParamSystem.ToList();
        }

        public List<GblSetting> GetByNames(IEnumerable<string> names)
        {
            var result = this.GetByNames(names.ToArray());
            return result;
        }
        private T[] GetArrayByDelimiter<T>(string paramValue, ParamDelimiter delimiter)
        {
            var separator = new char[] { };

            switch (delimiter)
            {
                case ParamDelimiter.Bracket:
                    separator = new char[] { LeftSquareBracket, RightSquareBracket };
                    break;

                case ParamDelimiter.Comma:
                    separator = new char[] { Comma };
                    break;

                case ParamDelimiter.VerticalLine:
                    separator = new char[] { VerticalLine };
                    break;

                default:
                    separator = new char[] { LeftSquareBracket, RightSquareBracket };
                    break;
            }

            var paramArray = paramValue.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            return Array.ConvertAll(paramArray, new Converter<string, T>(Converter<T>));
        }
        private T Converter<T>(string str)
        {
            return (T)Convert.ChangeType(str, typeof(T));
        }
        private GblSetting GetParamByName(string name)
        {
            GblSetting gblSetting = null;
            var sysParams = this.GetAllList<GblSetting>();
            //var sysParams = this.DataRepository().GetQueryable<GblSetting>();
            gblSetting = sysParams.Where(t => t.KeyNum == name).SingleOrDefault();

            if (gblSetting == null)
            {
                var errMsg = $"Invalid param name: {name}";
                throw new Exception(errMsg);
            }
            return gblSetting;
        }
        #endregion
    }
}
