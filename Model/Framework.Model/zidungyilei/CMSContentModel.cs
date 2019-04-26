using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.zidungyilei
{
    public class CMSContentModel
    {
        public int Id { get; set; }
        //[Required]
        //[Display(Name = "栏目Id")]
        public int ColumnId { get; set; }
        //[Required]
        //[Display(Name = "类别Id")]
        public int CategoryId { get; set; }
        //[Required]
        //[Display(Name = "标题")]
        //[StringLength(60)]
        public string Title { get; set; }
        //[Display(Name = "关键字")]
        //[DisplayFormat(ConvertEmptyStringToNull = false)]
        //[StringLength(100)]
        public string Keywords { get; set; }
        //[Display(Name = "描述")]
        //[DisplayFormat(ConvertEmptyStringToNull = false)]
        //[StringLength(100)]
        public string Description { get; set; }
        //[Required]
        //[Display(Name = "添加时间")]
        public System.DateTime Time { get; set; }
        //[Required]
        //[Display(Name = "内容")]
        public string ContentText { get; set; }
        public string Img { get; set; }
        public int Orderby { get; set; }
        public int TopOrderby { get; set; }
        public int StateCode { get; set; }
        public bool IsRelease { get; set; }

        public string ColumnName { get; set; }
        /// <summary>
        /// 验证数据库实体方法
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        //public CMS_Content ToEntity(CMSContentModel model)
        //{
        //    CMS_Content cms = new CMS_Content();
        //    cms.CategoryId = model.CategoryId;
        //    cms.ColumnId = model.ColumnId;
        //    cms.ContentText = model.ContentText;
        //    cms.Description = model.Description;
        //    cms.Id = model.Id;
        //    cms.Img = model.Img;
        //    cms.IsRelease = model.IsRelease;
        //    cms.Keywords = model.Keywords;
        //    cms.Orderby = model.Orderby;
        //    cms.StateCode = model.StateCode;
        //    cms.Title = model.Title;
        //    cms.Time = model.Time;
        //    cms.TopOrderby = model.TopOrderby;
        //    return cms;
        //}
    }
}
