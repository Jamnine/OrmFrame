

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	
	public partial class VipBinding:BaseModel
	{
        private string _patName;
        private string _cardNo;
        private string _sex;
        private int _age;
        public string PatName
        {
            get { return _patName; }
            set { _patName = value; }
        }
        public string CardNo
        {
            get { return _cardNo; }
            set { _cardNo = value; }
        }
        public string Sex
        {
            get { return _sex; }
            set { _sex = value; }
        }
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
    }  
}           


