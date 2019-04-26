using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.zidungyilei
{
    /// <summary>
    /// 
    /// </summary>
    public class ModelToEntity
    {
        public static CMS_Content ToEntity(CMSContentModel model)
        {
            CMS_Content cms = new CMS_Content();
            cms.CategoryId = model.CategoryId;
            cms.ColumnId = model.ColumnId;
            cms.ContentText = model.ContentText;
            cms.Description = model.Description;
            cms.ID = model.Id;
            cms.Img = model.Img;
            cms.IsRelease = model.IsRelease;
            cms.Keywords = model.Keywords;
            cms.Orderby = model.Orderby;
            cms.StateCode = model.StateCode;
            cms.Title = model.Title;
            cms.Time = model.Time;
            cms.TopOrderby = model.TopOrderby;
            return cms;
        }
    }
}
