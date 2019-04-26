namespace Orm.Framework.Services
{
    /// <summary>
    /// Tracker描述信息
    /// </summary>
    public sealed class DfsTrackerInfo
	{
        public string Group { get; set; }
        public string IP { get; set; }
        public int Port { get; set; }
        public string FileSite { get; set; }

        public DfsTrackerInfo()
        {
        }

        public DfsTrackerInfo(string group, string ip, int port, string fileSite)
        {
			this.Group = group;
			this.IP = ip;
			this.Port = port;
			this.FileSite = fileSite.TrimEnd('/');
		}
	}
}
