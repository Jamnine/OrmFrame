using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Windows.Controls
{
    /// <summary>
    /// 磁贴服务
    /// 为磁贴提供有组织的动画
    /// </summary>
    public static class HubTileService
    {
        /// <summary>
        /// 在管路中的步骤的数目
        /// </summary>
        private const int WaitingPipelineSteps = 3;
        /// <summary>
        /// 磁贴的数量，可以是动画在完全相同的时间数
        /// </summary>
        private const int NumberOfSimultaneousAnimations = 1;
        /// <summary>
        /// 监视活动状态是否是弱引用
        /// </summary>
        private const bool TrackResurrection = false;




    }
}
