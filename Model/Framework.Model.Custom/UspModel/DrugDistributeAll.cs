using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 发药信息类 包含已发药 未发药
    /// </summary>
    [Serializable]
    public class DrugDistributeAll : BaseModel
    {

        private List<OuRecipeTemp> _noOuDrugDistribute;
        private List<OuRecipeTemp> _ouDrugDistribute;

        /// <summary>
        /// 未发药
        /// </summary>
        public List<OuRecipeTemp> NoOuDrugDistribute
        {
            get { return _noOuDrugDistribute; }
            set { _noOuDrugDistribute = value; }
        }

        /// <summary>
        /// 已发药
        /// </summary>   
        public List<OuRecipeTemp> OuDrugDistribute
        {
            get { return _ouDrugDistribute; }
            set { _ouDrugDistribute = value; }
        } 
    }
}
