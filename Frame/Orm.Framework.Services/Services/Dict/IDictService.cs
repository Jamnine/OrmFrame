using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Framework.Services
{
    public sealed class DictItem
    {
        public string DictId { get; set; }

        public string DictValue { get; set; }
        public string DictText { get; set; }

        public string ParentValue { get; set; }

        public int OrderNo { get; set; }

        public string ID { get; set; }

        public string DICTPINYIN { get; set; }

        public List<DictItem> Children { get; set; }

        public string Property1 { get; set; }
        public string Property2 { get; set; }
        public string Property3 { get; set; }
        public string Property4 { get; set; }

        public string Property5 { get; set; }
    }

    /// <summary>
    /// 通用字典服务
    /// </summary>
    public interface IDictService
    {
        DictItem GetValue(string dictId, string itemValue);

        List< DictItem> GetCollection(string dictId);
    }
}
