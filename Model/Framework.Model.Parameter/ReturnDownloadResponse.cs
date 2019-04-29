using System;

namespace Orm.Model.Parameter
{
    /// <summary>
    /// 接受下载文件类
    /// </summary>
    [Serializable]
    public class ReturnDownloadResponse
    {
        private long _bytesReceived;
        /// <summary>
        /// 获取收到的字节数
        /// </summary>
        public long BytesReceived { get { return _bytesReceived; } set { _bytesReceived = value; } }

        private int _readNumber;
        /// <summary>
        /// 读取量 真正接收道德数据量
        /// </summary>
        public int ReadNumber { get { return _readNumber; } set { _readNumber = value; } }

        private long _totalBytesToReceive;
        /// <summary>
        /// 数据下载操作中的字节总数
        /// </summary>
        public long TotalBytesToReceive { get { return _totalBytesToReceive; } set { _totalBytesToReceive = value; } }

        private bool _isComplete;
        /// <summary>
        /// 是否完成
        /// </summary>
        public bool IsComplete { get { return _isComplete; } set { _isComplete = value; } }

        private byte[] _readBuffer;
        /// <summary>
        /// 读取的数据
        /// </summary>
        public byte[] ReadBuffer { get { return _readBuffer; } set { _readBuffer = value; } }

    }
}
