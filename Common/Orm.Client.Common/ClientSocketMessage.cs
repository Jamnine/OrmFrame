using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orm.Config;

namespace Orm.Client.Common
{

    /// <summary>
    /// Socket 消息发送
    /// </summary>
    public class ClientSocketMessage
    {

        /// <summary>
        /// 登陆信息
        /// </summary>
        /// <param name="userID">用户</param>
        /// <param name="userName">用户名称</param>
        /// <param name="expertStatus">是否专家</param>
        public static void SocketMessageLoginInformation(String userID, String userName,int expertStatus)
        {
            UserProfiles.socketMessageClient.setMessage($"登陆信息#{userID}#{userName}#{expertStatus}#");
        }

        /// <summary>
        /// 发送消息
        /// </summary>
        /// <param name="userID">用户</param>
        /// <param name="userName">用户名称</param>
        /// <param name="expertStatus">是否专家</param>
        public static void SocketSenMessage(String userID, String userName, String roomCode, string Content )
        {
            UserProfiles.socketMessageClient.setMessage($"发送消息#{userID}#{userName}#{roomCode}##{Content}#");
        }

        /// <summary>
        /// 远程会诊中
        /// </summary>
        /// <param name="userID">当前用户</param>
        /// <param name="WaitTime">等待时间</param>
        public static void SocketMessageTeleconsultation(String userID, String WaitTime)
        {
            UserProfiles.socketMessageClient.setMessage($"远程会诊中#{userID}#{WaitTime}#");
        }

        /// <summary>
        /// 专家挂号
        /// </summary>
        /// <param name="RegistrationStatus">状态 1</param>
        /// <param name="userID">当前用户id</param>
        /// <param name="expertID">专家id</param>
        /// <param name="IsSevaSendCommand">是否保存挂号</param>
        /// <param name="ouhosinfoID">挂号ID</param>
        public static void SocketMessageExpertRegistration(int RegistrationStatus, String userID, String expertID, string IsSevaSendCommand,string ouhosinfoID, string suijishu)
        {
            string SendCommand = "专家挂号#" + $"{RegistrationStatus}#" + $"{userID}#" + expertID + "#" + IsSevaSendCommand.ToString() + "#" + ouhosinfoID +   "#" + suijishu + "#";
            UserProfiles.socketMessageClient.setMessage(SendCommand);
        }

        /// <summary>
        /// 刷新处方
        /// </summary>
        /// <param name="RegistrationStatus">状态 1</param>
        /// <param name="userID">当前用户id</param>
        /// <param name="expertID">通知的对象的ID</param>
        /// <param name="IsSevaSendCommand">是否保存挂号</param>
        /// <param name="ouhosinfoID">挂号ID</param>
        public static void SocketMessageRefreshPrescription(int RegistrationStatus, String userID, String expertID, string IsSevaSendCommand, string ouhosinfoID, string suijishu)
        {
            // UserProfiles.socketMessageClient.setMessage($"刷新处方#{UserProfiles.UserID}#{CurrentPatient.PatId}#{CurrentPatient.GUID}#");
            string SendCommand = "刷新处方#" + $"{RegistrationStatus}#" + $"{userID}#" + expertID + "#" + IsSevaSendCommand.ToString() + "#" + ouhosinfoID + "#" + suijishu + "#";
            UserProfiles.socketMessageClient.setMessage(SendCommand);
        }
    }
}
