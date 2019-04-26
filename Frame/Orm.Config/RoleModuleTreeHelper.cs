using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Orm.Model.Custom;

namespace Orm.Config
{
    /// <summary>
    /// 角色模块/权限树状结构帮助类
    /// </summary>
    public class RoleModuleTreeHelper
    {
        private RoleModuleTreeHelper()
        {


        }

        #region 全局变量

        private readonly static string[] assemblyNames =
        {
            "Orm.MainWindow",
            "Orm.Client.HuRmSystem",
            "Orm.Client.OuPatient",
           "Orm.Client.SystemMaintenance",
            "Orm.Client.DataAnalysis",
            "Orm.Client.Treatment",
           "Orm.Client.FrontDesk",
            "Orm.Client.HomeHealth",
            "Orm.Client.Base",
             #region SystemMaintenance插件化配置
            //"SystemMaintenance_Plugln_ChangedLog",//修改日志查询
            //"SystemMaintenance_Plugln_FrmInvoiceManage",//发票管理
            //"SystemMaintenance_Plugln_FrmDictionaryMaintain1",//项目字典维护综合
            //"SystemMaintenance_Plugln_FrmRecordTemplate",//病例模版维护
            //"SystemMaintenance_Plugln_FrmLocation",//诊所信息
            //"SystemMaintenance_Plugln_FrmComboMaintain",//组合套餐维护
            //"SystemMaintenance_Plugln_FrmMaintenanceIndex",//装载窗体
            //"SystemMaintenance_Plugln_FrmHospitalUnionManage",//医联体管理
            //"SystemMaintenance_Plugln_UcBackupRestore",//数据备份
            //"SystemMaintenance_Plugln_SysSettingMaintain",//参数配置维护
            //"SystemMaintenance_Plugln_FrmStaffMaintain",//账号管理
            //"SystemMaintenance_Plugln_FrmRecipeTemplate",//处方模版维护
            //"SystemMaintenance_Plugln_FrmLocalParSetting",//系统设置
            //"SystemMaintenance_Plugln_FrmPhysicalPackage",//体检套餐维护
            //"SystemMaintenance_Plugln_FrmBasicListMaintain",//基本表维护
            //"SystemMaintenance_Plugln_FrmJurisdictionSet",//权限设置
            //"SystemMaintenance_Plugln_FrmDiagnoseAdvise",//诊断建议维护
            //"SystemMaintenance_Plugln_FrmLocationSetting",//体检科室维护
            //"SystemMaintenance_Plugln_FrmKunShanDictionary",//口腔项目字典
            //"SystemMaintenance_Plugln_FrmRecordSphrase",//口腔病例模版维护
            //"SystemMaintenance_Plugln_FrmDictionaryMaintain1",//综合项目字典维护
            //"SystemMaintenance_Plugln_FrmSpecialist",//专家管理
            //"SystemMaintenance_Plugln_FrmAppeal",//云端专家
            #endregion
              #region FrontDesk插件化配置
             // "FrontDesk_PlugIn_FrmExecute",
             // "FrontDesk_PlugIn_Newarchives",
             // "FrontDesk_PlugIn_FrmNewistally",
             //"FrontDesk_PlugIn_DistributeMedicine",
             //"FrontDesk_PlugIn_FrmCashierReportSet",
             //"FrontDesk_PlugIn_FrmNewEditBooking",
             //"FrontDesk_PlugIn_FrmDocumentQuery",
             //"FrontDesk_PlugIn_FrmPatientQuery",
             //"FrontDesk_PlugIn_FrmCashier",
             // "FrontDesk_PlugIn_Nurseindex",//装载窗体
             // "FrontDesk_PlugIn_Reciprocalmg_AiDing",
             // "FrontDesk_PlugIn_Scheduling",
             // "FrontDesk_PlugIn_FrmKunShanVIPManagement",
            #endregion
              #region HuRmSystem插件化配置
             // "HuRmSystem_Plugln_FrmApply",
             // "HuRmSystem_Plugln_FrmBillSearch",
             // "HuRmSystem_Plugln_FrmBuyPlan",
             //"HuRmSystem_Plugln_FrmDocument",
             //"HuRmSystem_Plugln_FrmInventory",
             //"HuRmSystem_Plugln_FrmInventoryModify",
             //"HuRmSystem_Plugln_FrmInventoryQuery",
             //"HuRmSystem_Plugln_FrmLogQuery",
             //"HuRmSystem_Plugln_FrmOutBound",
             // "HuRmSystem_Plugln_FrmOutStockAlarm",
             // "HuRmSystem_Plugln_FrmStorage",
             // "HuRmSystem_Plugln_FrmValidityAlert",
             // "HuRmSystem_Plugln_instrument",
             // "HuRmSystem_Plugln_Inventoryindex",
            #endregion

            #region HomeHealth插件化配置

            //"HomeHealth_Plugln_FrmOrderManage",//派工单
            //"HomeHealth_Plugln_FrmLifeService",//生活服务
            //"HomeHealth_Plugln_FrmInformFamilyMember",//通知家属
            //"HomeHealth_Plugln_FrmHealthManagement",//健康管理方案
            //"HomeHealth_Plugln_HomeHealthIndex",//装载窗体



            #endregion



        };
        /// <summary>
        /// 命名空间名称集合
        /// </summary>
        private readonly static string[] namespaceNames = {
            "Orm.MainWindow",
            "Orm.MainWindow.DataAnalysis",
            "Orm.MainWindow.HomePage",
            "Orm.Client.HuRmSystem",
            "Orm.Client.OuPatient",
            "Orm.Client.SystemMaintenance",
            "Orm.MainWindow.DoctorPatientCommunication",
            "Orm.Client.DataAnalysis",
            "Orm.Client.Treatment",
           "Orm.Client.FrontDesk",
            "Orm.Client.HomeHealth",
            "Orm.Client.Base",
            #region SystemMaintenance插件化配置
            //"SystemMaintenance_Plugln_FrmKunShanDictionaryMaintain",
            //"SystemMaintenance_Plugln_FrmHospitalUnionManage",//医联体管理
            //"SystemMaintenance_Plugln_ChangedLog",//修改日志查询
            //"SystemMaintenance_Plugln_FrmInvoiceManage",//发票管理
            //"SystemMaintenance_Plugln_FrmRecordTemplate",//病例模版维护
            //"SystemMaintenance_Plugln_FrmLocation",//诊所信息
            //"SystemMaintenance_Plugln_FrmComboMaintain",//组合套餐维护
            //"SystemMaintenance_Plugln_FrmMaintenanceIndex",//装载窗体
            //"SystemMaintenance_Plugln_SysSettingMaintain",//参数配置维护
            //"SystemMaintenance_Plugln_UcBackupRestore",//数据备份
            //"SystemMaintenance_Plugln_FrmStaffMaintain",//账号管理
            //"SystemMaintenance_Plugln_FrmRecipeTemplate",//处方模版维护
            //"SystemMaintenance_Plugln_FrmLocalParSetting",//系统设置
            //"SystemMaintenance_Plugln_FrmPhysicalPackage",//体检套餐维护
            //"SystemMaintenance_Plugln_FrmBasicListMaintain",//基本表维护
            //"SystemMaintenance_Plugln_FrmJurisdictionSet",//权限设置
            //"SystemMaintenance_Plugln_FrmDiagnoseAdvise",//诊断建议维护
            //"SystemMaintenance_Plugln_FrmLocationSetting",//体检科室维护
            //"SystemMaintenance_Plugln_FrmKunShanDictionary",//口腔项目字典
            //"SystemMaintenance_Plugln_FrmDictionaryMaintain1",//综合项目字典维护
            //"SystemMaintenance_Plugln_FrmRecordSphrase",//口腔病例模版维护
            ////"SystemMaintenance_Plugln_FrmSpecialist",//专家管理
            ////"SystemMaintenance_Plugln_FrmAppeal",//云端专家
            #endregion
               #region FrontDesk插件化配置
          //  "FrontDesk_PlugIn_FrmExecute",
          //"FrontDesk_PlugIn_Newarchives",
          //"FrontDesk_PlugIn_FrmNewistally",
          //  "FrontDesk_PlugIn_DistributeMedicine",
          //  "FrontDesk_PlugIn_FrmCashierReportSet",
          //  "FrontDesk_PlugIn_FrmNewEditBooking",
          //  "FrontDesk_PlugIn_FrmDocumentQuery",
          //"FrontDesk_PlugIn_FrmPatientQuery",
          //"FrontDesk_PlugIn_FrmCashier",
          //  "FrontDesk_PlugIn_Nurseindex",//装载窗体
          //"FrontDesk_PlugIn_Reciprocalmg_AiDing",
          //"FrontDesk_PlugIn_Scheduling",
          //  "FrontDesk_PlugIn_FrmKunShanVIPManagement",
            #endregion
            #region HuRmSystem插件化配置
             // "HuRmSystem_Plugln_FrmApply",
             // "HuRmSystem_Plugln_FrmBillSearch",
             // "HuRmSystem_Plugln_FrmBuyPlan",
             //"HuRmSystem_Plugln_FrmDocument",
             //"HuRmSystem_Plugln_FrmInventory",
             //"HuRmSystem_Plugln_FrmInventoryModify",
             //"HuRmSystem_Plugln_FrmInventoryQuery",
             //"HuRmSystem_Plugln_FrmLogQuery",
             //"HuRmSystem_Plugln_FrmOutBound",
             // "HuRmSystem_Plugln_FrmOutStockAlarm",
             // "HuRmSystem_Plugln_FrmStorage",
             // "HuRmSystem_Plugln_FrmValidityAlert",
             // "HuRmSystem_Plugln_instrument",
             // "HuRmSystem_Plugln_Inventoryindex",
            #endregion
             #region HomeHealth插件化配置

            //"HomeHealth_Plugln_FrmOrderManage",//派工单
            //"HomeHealth_Plugln_FrmLifeService",//生活服务
            //"HomeHealth_Plugln_FrmInformFamilyMember",//通知家属
            //"HomeHealth_Plugln_FrmHealthManagement",//健康管理方案
            //"HomeHealth_Plugln_HomeHealthIndex",//装载窗体



            #endregion


        };

        private static System.Reflection.Assembly[] assemblies = null;

        #endregion

        #region 对外方法

        /// <summary>
        /// 获取树状权限数据
        /// </summary>
        /// <param name="lstUspRoleModule"></param>
        /// <returns></returns>
        public static Collection<TreeClass<uspRoleModuleQry>> GetTreeViewRoleModule(List<uspRoleModuleQry> lstUspRoleModule)
        {
            var tempLstQry = lstUspRoleModule.Where(q => q.ParentID == "0" || string.IsNullOrEmpty(q.ParentID)).ToList();
            lstUspRoleModule.RemoveAll(q => q.ParentID == "0" || string.IsNullOrEmpty(q.ParentID));
            int count = tempLstQry.Count();
            var tempLstTreeClass = new Collection<TreeClass<uspRoleModuleQry>>();
            for (int i = 0; i < count; i++)
            {
                tempLstTreeClass.Add(TreeViewRoleModuleQry(tempLstQry[i], lstUspRoleModule));
            }
            return tempLstTreeClass;
        }


        /// <summary>
        /// 获取树状结构，权限显示
        /// </summary>
        /// <param name="qry"></param>
        private static TreeClass<uspRoleModuleQry> TreeViewRoleModuleQry(uspRoleModuleQry qry, List<uspRoleModuleQry> lstQry)
        {
            if (lstQry == null)
            {
                return null;//截断
            }
            var tempLstQry = lstQry.Where(q => q.ParentID == qry.ID).ToList();
            lstQry.RemoveAll(q => q.ParentID == qry.ID);

            int count = tempLstQry.Count;
            var tempLstTreeClass = new Collection<TreeClass<uspRoleModuleQry>>();
            for (int i = 0; i < count; i++)
            {
                var temp = TreeViewRoleModuleQry(tempLstQry[i], lstQry);
                tempLstTreeClass.Add(temp);
            }
            var tempTreeClass = new TreeClass<uspRoleModuleQry>
            {
                Key = qry,
                Value = tempLstTreeClass
            };
            return tempTreeClass;
        }


        /// <summary>
        /// 获取相关的展示模块(DisplayModule)
        /// </summary>
        /// <param name="lstTcDisplayModule"></param>
        /// <returns></returns>
        public static List<Orm.Model.Custom.DisplayModule> GetListDisplayModule(List<Orm.Model.Custom.TreeClass<Orm.Model.Custom.DisplayModule>> lstTcDisplayModule)
        {
            var tempLstDisplayModule = new List<Orm.Model.Custom.DisplayModule>();
            if (lstTcDisplayModule == null)
            {
                return tempLstDisplayModule;
            }
            //int count = Orm.Config.UserProfiles.CurrentAuthority.Count;
            int count = lstTcDisplayModule.Count;
            for (int i = 0; i < count; i++)
            {
                if (lstTcDisplayModule[i].Key.EntityName != null)
                {
                    lstTcDisplayModule[i].Key.CreateElement = CreateElement;
                    tempLstDisplayModule.Add(lstTcDisplayModule[i].Key);
                }
            }
            return tempLstDisplayModule;
        }

        private static object CreateElement(string entityName)
        {
            return SelectFrameworkElement(entityName);
        }

        public static System.Windows.FrameworkElement SelectFrameworkElement(string entityName, params object[] args)
        {
            return FromEntityNameToTypeObject<System.Windows.FrameworkElement>(entityName, args);
        }


        public static System.Windows.Window SelectWindow(string entityName, params object[] args)
        {
            return FromEntityNameToTypeObject<System.Windows.Window>(entityName, args);
        }

        static T FromEntityNameToTypeObject<T>(string entityName, params object[] args) where T : System.Windows.FrameworkElement
        {
            if (assemblies == null)
            {
                int length = assemblyNames.Length;
                assemblies = new System.Reflection.Assembly[length];
                for (int index = 0; index < length; index++)
                {
                    assemblies[index] = AppDomain.CurrentDomain.Load(assemblyNames[index]);
                }
            }

            int act = assemblies.Length;
            T tempTypeObject = null;
            bool flag = true;
            if (!String.IsNullOrEmpty(entityName))
            {
                if (entityName.Split('.').Count() > 1)
                {
                    flag = false;
                }
                try
                {
                    for (int i = 0; i < act; i++)
                    {
                        if (flag)
                        {
                            tempTypeObject = SelectFrameworkElement<T>(assemblies[i], namespaceNames, entityName, args);
                        }
                        else
                        {
                            tempTypeObject = SelectFrameworkElement<T>(assemblies[i], entityName, args);
                        }
                        if (tempTypeObject != null)
                        {
                            break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.ToString() + entityName);
                }
            }
            return tempTypeObject;
        }

        static T SelectFrameworkElement<T>(System.Reflection.Assembly assembly, string[] namespaceNames, string entityName, params object[] args) where T : System.Windows.FrameworkElement
        {
            if (assembly == null)
            {
                return null;
            }
            Object obj = null;
            int tempLength = namespaceNames.Length;
            for (int i = 0; i < tempLength; i++)
            {
                var type = assembly.GetType(string.Format("{0}.{1}", namespaceNames[i], entityName));
                if (type != null)
                {
                    obj = Activator.CreateInstance(type, args);
                }
                if (obj is T)
                {
                    return obj as T;
                }
            }
            return null;
        }



        static T SelectFrameworkElement<T>(System.Reflection.Assembly assembly, string entityName, params object[] args) where T : System.Windows.FrameworkElement
        {
            if (assembly == null)
            {
                return null;
            }
            var type = assembly.GetType(entityName);
            Object obj = null;
            if (type != null)
            {
                obj = Activator.CreateInstance(type, args);
            }
            if (obj is T)
            {
                return obj as T;
            }
            return null;
        }
        #endregion
    }
}
