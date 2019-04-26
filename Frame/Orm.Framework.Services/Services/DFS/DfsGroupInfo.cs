namespace Orm.Framework.Services
{
    /// <summary>
    /// Group描述信息
    /// </summary>
    public sealed class DfsGroupInfo
    {
        public const int GroupInfo_LEN= 97; //(16+1)+8*10

        public readonly string GroupName;
        public readonly long FreeSpace; //单位MB
        public readonly long TrunkFreeSpace;
        public readonly int StorageServerCount;
        public readonly int StorageServerPort;
        public readonly int StorageServerHttpPort;
        public readonly int ActiveServerCount;
        public readonly int Current_Write_Server_Index;
        public readonly int StorePathCount;
        public readonly int SubdirCount;
        public readonly long Current_Trunk_FileId;

        public DfsGroupInfo(string group, long freespace, long trunkfreespace, int storagecount, int storageport, int httpport,
            int activeservercount, int currentwriteindex, int storepathcount, int subdircount, long currenttrunkfileId)
        {
            GroupName = group;
            FreeSpace = freespace;
            TrunkFreeSpace = trunkfreespace;
            StorageServerCount = storagecount;
            StorageServerPort = storageport;
            StorageServerHttpPort = httpport;
            ActiveServerCount = activeservercount;
            Current_Write_Server_Index = currentwriteindex;
            StorePathCount = storepathcount;
            SubdirCount = subdircount;
            Current_Trunk_FileId = currenttrunkfileId;
        }
    }
}
