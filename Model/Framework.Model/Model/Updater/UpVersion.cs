// ===================================================================   
// Model  
// ===================================================================   
// File: UpVersion.cs  
//   
// Copyright   
// History:  
// 2015/1/28 10:58:36: Chen Envision   Original Version  
//   
// ===================================================================  

using System;

namespace Orm.Model
{
    /// <summary>  
    ///更新版本信息
    /// </summary> 
    [Serializable]
    public partial class UpVersion : BaseModel
    {
        private int _versionId;
        private int _versionNum;
        private int _operId;
        private DateTime _operTime;
        private string _upLoadHostName = String.Empty;
        private string _upLoadIp = String.Empty;
        private int _testId;
        private bool _isMust;
        private int _lastVersion;
        private string _memo = String.Empty;

        public UpVersion()
        {
        }

        public   int ID { get; set; }
        /// <summary>  
        /// 版本id
        /// </summary>  
        public int VersionId
        {
            get { return this._versionId; }
            set { this._versionId = value; }
        }

        /// <summary>  
        /// 版本号  
        /// </summary>  
        public int VersionNum
        {
            get { return this._versionNum; }
            set { this._versionNum = value; }
        }

        /// <summary>
        /// 数据库版本号
        /// </summary>
        public int DbVersionNum { get; set; }

        /// <summary>  
        /// 操作人id
        /// </summary>  
        public int OperId
        {
            get { return this._operId; }
            set { this._operId = value; }
        }

        /// <summary>  
        /// 操作时间
        /// </summary>  
        public DateTime OperTime
        {
            get { return this._operTime; }
            set { this._operTime = value; }
        }

        /// <summary>  
        /// 上传的电脑  
        /// </summary>  
        public string UpLoadHostName
        {
            get { return this._upLoadHostName; }
            set { this._upLoadHostName = value; }
        }

        /// <summary>  
        /// 上传的电脑ip  
        /// </summary>  
        public string UpLoadIp
        {
            get { return this._upLoadIp; }
            set { this._upLoadIp = value; }
        }

        /// <summary>  
        /// 测试id
        /// </summary>  
        public int TestId
        {
            get { return this._testId; }
            set { this._testId = value; }
        }

        /// <summary>  
        /// 是否必须更新  
        /// </summary>  
        public bool IsMust
        {
            get { return this._isMust; }
            set { this._isMust = value; }
        }

        /// <summary>  
        /// 在哪个版本之上更新  
        /// </summary>  
        public int LastVersion
        {
            get { return this._lastVersion; }
            set { this._lastVersion = value; }
        }

        /// <summary>  
        /// 备注
        /// </summary>  
        public string Memo
        {
            get { return this._memo; }
            set { this._memo = value; }
        }

        /// <summary>
        /// 版本的IIS文件路径
        /// </summary>
        public string VersionIisFilePath { get; set; }
    }
}
