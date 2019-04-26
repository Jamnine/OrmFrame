using System;

namespace Orm.Model
{
    [Serializable]
    public class BsBedFloor : BaseModel
    {
        private string _code { get; set; }// 编码

        private bool _isActive { get; set; }// 有效标志

        private string _locationId { get; set; }// 养老:科室GUID

        private string _name { get; set; }// 名称

        private int? _nurse { get; set; }// 当前楼层的护士人数

        private int? _nurseStaff { get; set; }// 当前楼层的护理员人数

        private Int16 _orderBy { get; set; }// 显示顺序

        private string _printName { get; set; }// 别名

        private string _pyCode { get; set; }// 拼音码

        private string _wbCode { get; set; }// 五笔码

        public BsBedFloor()
        {

        }

        /// <summary>
        /// 编码
        /// </summary>	
        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }

        /// <summary>
        /// 有效标志
        /// </summary>	
        public bool IsActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }

        /// <summary>
        /// 养老:科室GUID
        /// </summary>	
        public string LocationId
        {
            get { return _locationId; }
            set { _locationId = value; }
        }

        /// <summary>
        /// 名称
        /// </summary>	
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// 当前楼层的护士人数
        /// </summary>	
        public int? Nurse
        {
            get { return _nurse; }
            set { _nurse = value; }
        }

        /// <summary>
        /// 当前楼层的护理员人数
        /// </summary>	
        public int? NurseStaff
        {
            get { return _nurseStaff; }
            set { _nurseStaff = value; }
        }

        /// <summary>
        /// 显示顺序
        /// </summary>	
        public Int16 OrderBy
        {
            get { return _orderBy; }
            set { _orderBy = value; }
        }

        /// <summary>
        /// 别名
        /// </summary>	
        public string PrintName
        {
            get { return _printName; }
            set { _printName = value; }
        }

        /// <summary>
        /// 拼音码
        /// </summary>	
        public string PyCode
        {
            get { return _pyCode; }
            set { _pyCode = value; }
        }

        /// <summary>
        /// 五笔码
        /// </summary>	
        public string WbCode
        {
            get { return _wbCode; }
            set { _wbCode = value; }
        }
    }
}
