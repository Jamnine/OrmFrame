using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model
{
    [Serializable]
    public class BsBankcardIYWT : BaseModel
    {
        private string login_id;
        private string card;
        private string bank;
        private string cardType;

        public string Login_id
        {
            get { return login_id; }
            set { login_id = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Card
        {
            get { return card; }
            set { card = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Bank
        {
            get { return bank; }
            set { bank = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CardType
        {
            get { return cardType; }
            set { cardType = value; }
        }
    }
}
