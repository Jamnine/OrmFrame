using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Client.Common
{

    public class BaseControlConfig : absConfigModel
    {

        public BaseControlConfig() { }


        #region Type
        protected string _Type;
        /// <summary>
        /// Type
        /// </summary>
        public string Type
        {
            set { _Type = value; }
            get { return _Type; }
        }
        #endregion

        #region StoredProcedure
        protected string _storedProcedure;
        /// <summary>
        /// StoredProcedure
        /// </summary>
        public string StoredProcedure
        {
            set { _storedProcedure = value; }
            get { return _storedProcedure; }
        }
        #endregion

        #region IConfigModel 成员

        protected string _key;
        /// <summary>
        /// Key
        /// </summary>
        public override  string  Key
        {
            set { _key = value; }
            get { return _key; }
        }

        #endregion

        #region OrderByExpression
        protected string _orderByExpression;
        /// <summary>
        /// OrderByExpression
        /// </summary>
        public string OrderByExpression
        {
            set { _orderByExpression = value; }
            get { return _orderByExpression; }
        }
        #endregion

        #region WhereCondition
        protected string _whereCondition;
        /// <summary>
        /// WhereCondition
        /// </summary>
        public string WhereCondition
        {
            set { _whereCondition = value; }
            get { return _whereCondition; }
        }
        #endregion

        #region ID
        protected string _ID;
        /// <summary>
        /// ID
        /// </summary>
        public string ID
        {
            set { _ID = value; }
            get { return _ID; }
        }
        #endregion

        #region Code
        protected string _Code;
        /// <summary>
        /// Code
        /// </summary>
        public string Code
        {
            set { _Code = value; }
            get { return _Code; }
        }
        #endregion

        #region Name
        protected string _Name;
        /// <summary>
        /// Name
        /// </summary>
        public string Name
        {
            set { _Name = value; }
            get { return _Name; }
        }
        #endregion

       
    }

}
