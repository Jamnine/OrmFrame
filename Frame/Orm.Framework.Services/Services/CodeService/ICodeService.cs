namespace Orm.Framework.Services
{
    /// <summary>
    /// 提供一个服务，用于根据配置规则生成单据号
    /// </summary>
    public interface ICodeService
    {
        void RefreshConfig();

        long Next(string code);

        long Next(string code,string cust);

        long Next(string code, string cust,string machineId);

        string NextCode(string code);

        string NextCode(string code, string cust);

        string NextCode(string code, string cust, string machineId);

       
     
    }
}
