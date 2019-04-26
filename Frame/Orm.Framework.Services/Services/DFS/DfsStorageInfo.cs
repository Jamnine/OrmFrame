namespace Orm.Framework.Services
{
    public class DfsStorageInfo
    {
        public readonly string GroupName;
        public readonly string IP;
        public readonly int Port;
        public readonly byte Store_Path_Index;

        public DfsStorageInfo(string group,string ip,int port,byte storepathindex)
        {
            GroupName = group;
            IP = ip;
            Port = port;
            Store_Path_Index = storepathindex;
        }
    }
}
