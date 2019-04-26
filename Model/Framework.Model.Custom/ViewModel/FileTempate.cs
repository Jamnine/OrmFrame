using System;
using System.Collections.Generic;
using System.Windows.Input;
using Orm.Model.EnumDefine;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 文件模板
    /// </summary>
    [Serializable]
    public class FileTempate
    {
        public FileTempate() { }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreationTime { get; set; }

        /// <summary>
        /// 最后写入时间
        /// </summary>
        public DateTime LastWriteTime { get; set; }

        private string _name = "";
        /// <summary>
        /// 文件名
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _fileSize = "0KB";
        /// <summary>
        /// 文件大小
        /// </summary>
        public string FileSize
        {
            get { return _fileSize; }
            set { _fileSize = value; }
        }

        private int _status = 0;
        /// <summary>
        /// 文件状态 0未下载 1已下载 2正在下载
        /// </summary>
        public int Status
        {
            get { return _status; }
            set { _status = value; }
        }

        private List<CommandInfo> _commandList = new List<CommandInfo>();
        /// <summary>
        /// 命令集合 0下载 1打开 2重新下载 3删除
        /// </summary>
        public List<CommandInfo> CommandList
        {
            get { return _commandList; }
            set { _commandList = value; }
        }

        public bool IsLocalFile { get; set; }

        /// <summary>
        /// 下载地址
        /// </summary>
        public string FileLink { get; set; }

        /// <summary>
        /// 文件地址
        /// </summary>
        public string FilePath { get; set; }

        /// <summary>
        /// 病人姓名
        /// </summary>
        public string PatName { get; set; }
        private bool _isHaveDownloaded = false;
        public bool u_IsHaveDownloaded
        {
            get
            {
                if (Status == (int)EnumFileTempateStatus.已下载)
                {
                    _isHaveDownloaded = true;
                }
                else
                {
                    _isHaveDownloaded = false;
                }
                return _isHaveDownloaded;
            }
            set { _isHaveDownloaded = value; }
        }
        private bool _isNotDownloaded = false;
        public bool u_IsNotDownloaded
        {
            get
            {
                if (Status == (int)EnumFileTempateStatus.未下载)
                {
                    _isNotDownloaded = true;
                }
                else
                {
                    _isNotDownloaded = false;
                }
                return _isNotDownloaded;
            }
            set { _isNotDownloaded = value; }
        }
    }

    /// <summary>
    /// 命令列表
    /// </summary>
    [Serializable]
    public class CommandInfo
    {
        public CommandInfo() { }

        private string _cmdIcon = "";
        /// <summary>
        /// 命令图标
        /// </summary>
        public string CmdIcon
        {
            get { return _cmdIcon; }
            set { _cmdIcon = value; }
        }

        private string _cmdName = "";
        /// <summary>
        /// 命令名称
        /// </summary>
        public string CmdName
        {
            get { return _cmdName; }
            set { _cmdName = value; }
        }

        private bool _isCmdEditable = false;
        /// <summary>
        /// 命令是否可用
        /// </summary>
        public bool IsCmdEditable
        {
            get { return _isCmdEditable; }
            set { _isCmdEditable = value; }
        }

        private ICommand _command = null;
        /// <summary>
        /// 命令 0下载 1打开 2重新下载 3删除
        /// </summary>
        public ICommand Command
        {
            get { return _command; }
            set { _command = value; }
        }
    }
}
