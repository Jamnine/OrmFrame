using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;
using System.Net;


namespace Orm.Client.Common
{
    public class CaseHisTory
    {
//        BLL.CBsItem _objBsItem = new BLL.CBsItem();
//        BLL.CBsFrequency _objBsFrequency = new BLL.CBsFrequency();
//        BLL.CBsUnit _objBsUnit = new BLL.CBsUnit();
//        BLL.CBsUsage _objBsUsag = new BLL.CBsUsage();
//        BLL.CBsPatient _objBsPatient = new BLL.CBsPatient();
//        BLL.CBsDoctor _objBsDoctor = new BLL.CBsDoctor();
//        BLL.CBsLocation _objBsLocation = new BLL.CBsLocation();
//        BLL.CBsPatType _objBsPatType = new BLL.CBsPatType();
//        BLL.COuHosInfo _objOuHosinfo = new BLL.COuHosInfo();
//        BLL.CInHosInfo _objInHosinfo = new BLL.CInHosInfo();
//        BLL.CInHosBed _objInHosBed = new BLL.CInHosBed();
//        BLL.CBsBed _objBsBed = new BLL.CBsBed();
//        BLL.CBsUser _objBsUser = new BLL.CBsUser();
//        BLL.CCKMachineSample _objCKMachineSample = new BLL.CCKMachineSample();
//        BLL.CCkTestType _objCkTestType = new BLL.CCkTestType();
//        BLL.CCkLabResult _objCkLabResult = new BLL.CCkLabResult();
//        BLL.CCkItem _objCkItem = new BLL.CCkItem();
//        BLL.COuRecipe _objOuRecipe = new BLL.COuRecipe();
//        BLL.COuRecipeDtl _objRecipeDtl = new BLL.COuRecipeDtl();
//        BLL.COuClinicFirst _objClinicFirst = new BLL.COuClinicFirst();

//        int Id = 0;
//        int Type = 1;
//        int Mode = 1;

//        string fileName = "HisTory.html";
//        string filePath = "";
//        //分割线样式HTML代码
//        string hrString = "<br/><hr  align=\"center\" style=\"height:5px; width:99%;  color:#FFFFFF;  border: thin dashed #0000FF; background-color: #FFFFFF;\"/> <br/> ";
           

//        Model.BsPatientInfo _infoBsPatient = new Model.BsPatientInfo();
//        /// <summary>
//        /// 察看病人的网页病历
//        /// </summary>
//        /// <param name="Id">病人ＩＤ</param>
//        /// <param name="type">1- BsPatient.GUID；2-OuHosinfo.GUID ；3-InHosInfo.GUID</param>
//        /// <param name="mode">1- 按病历类别看;2-按就诊时间看</param>
       public CaseHisTory(int id, int type, int mode)
       {
//            if (id == 0) return;
//            FrmCaseHisTory frmHtml = new FrmCaseHisTory(id, type, mode);
//            //this.Id = id;// patId;
//            //this.Type = type;
//            //this.Mode = mode;
//            //filePath = System.IO.Directory.GetCurrentDirectory() + "\\" + fileName;
//            //if (Type == 1)
//            //    _infoBsPatient = _objBsPatient.GetByID(id);
//            //if (Type == 2)
//            //    _infoBsPatient = _objBsPatient.GetByID(_objOuHosinfo.GetByID(id).PatId);
//            //if (Type == 3)
//            //    _infoBsPatient = _objBsPatient.GetByID(_objInHosinfo.GetByID(id).PatID);

//            //InitHashTable();
//            //OutHisTory();
         }

//         /// <summary>
//        /// 察看旧系统病人的网页病历
//        /// </summary>
//        /// <param name="Id">病人ＩＤ</param> 
//        public CaseHisTory(Model.ModelList<Model.uspGetPatinfoJxQry> lst)
//        {
//            if (lst.Count == 0) return;
//            FrmUsedCaseHisTory frmHtml = new FrmUsedCaseHisTory(lst); 
//        }
   

//        public void OutHisTory()
//        {
//            try
//            {
//                string innerHTML = string.Empty;
//                innerHTML = getHtmlContent();

//                if (Mode == 1)
//                {
//                    innerHTML = StrReplace(innerHTML, "-OuHisTory-", getOuHisTory().ToString());
//                    innerHTML = StrReplace(innerHTML, "-InHisTory-", getInHisTory().ToString());
//                    innerHTML = StrReplace(innerHTML, "-CkHisTory-", getCkHisTory().ToString());
//                    innerHTML = StrReplace(innerHTML, "-PsHisTory-", getPsHisTory().ToString());
//                }
//                else if (Mode == 2)
//                {
//                    Model.ModelList<Model.OuHosInfoInfo> _lstOuHosInfo = new Model.ModelList<Model.OuHosInfoInfo>();
//                    Model.ModelList<Model.InHosInfoInfo> _lstInHosInfo = new Model.ModelList<Model.InHosInfoInfo>();
//                    if (Type == 1)
//                    {
//                        _lstOuHosInfo = _objOuHosinfo.OuHosInfo_SelectByPatId(Id);
//                        _lstInHosInfo = _objInHosinfo.InHosInfo_SelectByPatID(Id);
//                    }
//                    else if (Type == 2)
//                    {
//                        Model.OuHosInfoInfo _infoOuHosInfo = _objOuHosinfo.GetByID(Id);
//                        _lstOuHosInfo.Add(_infoOuHosInfo);
//                    }
//                    else
//                    {
//                        Model.InHosInfoInfo _infoInHosInfo = _objInHosinfo.GetByID(Id);
//                        _lstInHosInfo.Add(_infoInHosInfo);
//                    }
//                    hosIterative(_lstOuHosInfo, _lstInHosInfo);

//                    innerHTML = StrReplace(innerHTML, "-HisTory-", sb.ToString());

//                }
//                Model.Configuration.Global info = BLL.ConfigFilesManager<Model.Configuration.Global>.GetFromXml(Utilities.ConfigTypes.GLOBAL_CONFIG);
//                innerHTML = StrReplace(innerHTML, "-某某医院-", info.HospitalName.ToString());
//                innerHTML = StrReplace(innerHTML, "-病人名字-", _infoBsPatient.Name); 
                
//                FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate);
//                fs.Close();
//                fs.Dispose();
//                StreamWriter sw = new StreamWriter(filePath, false, Encoding.UTF8);
//                sw.WriteLine(innerHTML);
//                sw.Close();
//                sw.Dispose();
//                System.Diagnostics.Process.Start("IEXPLORE.EXE", filePath);
//            }
//            catch (Exception)
//            {
//                throw;
//            }
//        }

//        StringBuilder sb = new StringBuilder();

//        private void hosIterative(Model.ModelList<Model.OuHosInfoInfo> _lstOuHosInfo, Model.ModelList<Model.InHosInfoInfo> _lstInHosInfo)
//        {
//            object o = new object();
//            if (_lstOuHosInfo.Count == 0 && _lstInHosInfo.Count > 0) o = _lstInHosInfo[0];
//            else if (_lstOuHosInfo.Count > 0 && _lstInHosInfo.Count == 0) o = _lstOuHosInfo[0];
//            else
//            {
//                o = _lstInHosInfo[0];
//                foreach (Model.InHosInfoInfo inInfo in _lstInHosInfo)
//                {
//                    if (o is Model.OuHosInfoInfo)
//                    {
//                        Model.OuHosInfoInfo _infoOuHosInfo = o as Model.OuHosInfoInfo;
//                        if (inInfo.InTime < _infoOuHosInfo.RegTime) o = inInfo;
//                    }
//                    if (o is Model.InHosInfoInfo)
//                    {
//                        Model.InHosInfoInfo _infoInHosInfo = o as Model.InHosInfoInfo;
//                        if (inInfo.InTime < _infoInHosInfo.InTime) o = inInfo;
//                    }
//                }
//                foreach (Model.OuHosInfoInfo ouInfo in _lstOuHosInfo)
//                {
//                    if (o is Model.OuHosInfoInfo)
//                    {
//                        Model.OuHosInfoInfo _infoOuHosInfo = o as Model.OuHosInfoInfo;
//                        if (ouInfo.RegTime < _infoOuHosInfo.RegTime) o = ouInfo;
//                    }
//                    if (o is Model.InHosInfoInfo)
//                    {
//                        Model.InHosInfoInfo _infoInHosInfo = o as Model.InHosInfoInfo;
//                        if (ouInfo.RegTime < _infoInHosInfo.InTime) o = ouInfo;
//                    }
//                }
//            }

//            if (o is Model.OuHosInfoInfo)
//            {
//                Model.OuHosInfoInfo _infoOuHosInfo = o as Model.OuHosInfoInfo;
//                Type = 2;
//                Id = _infoOuHosInfo.GUID;
//                sb.Append(getOuHisTory().ToString());
//                sb.Append(getCkHisTory().ToString());
//                sb.Append(getPsHisTory().ToString());
//                _lstOuHosInfo.Remove(_infoOuHosInfo);
//            }
//            else if (o is Model.InHosInfoInfo)
//            {
//                Model.InHosInfoInfo _infoInHosInfo = o as Model.InHosInfoInfo;
//                Type = 3;
//                Id = _infoInHosInfo.GUID;
//                sb.Append(getInHisTory().ToString());
//                sb.Append(getCkHisTory().ToString());
//                sb.Append(getPsHisTory().ToString());
//                _lstInHosInfo.Remove(_infoInHosInfo);
//            }
//            if (_lstOuHosInfo.Count != 0 || _lstInHosInfo.Count != 0) hosIterative(_lstOuHosInfo, _lstInHosInfo);

//        }


//        #region 得到门诊病历
//        private StringBuilder getOuHisTory()
//        {
//            StringBuilder returnSb = new StringBuilder();

//            Model.ModelList<Model.OuHosInfoInfo> _lstOuHosInfo = new Model.ModelList<Model.OuHosInfoInfo>();
//            // Model.ModelList<Model.oui> _lstOuClinicFirst = new Model.ModelList<Model.OuClinicFirstInfo>(); 

//            if (Type == 1)
//                _lstOuHosInfo = _objOuHosinfo.OuHosInfo_SelectByPatId(Id);
//            if (Type == 2)
//                _lstOuHosInfo.Add(_objOuHosinfo.GetByID(Id));
//            if (Type == 3)
//                _lstOuHosInfo = new Model.ModelList<Model.OuHosInfoInfo>();



//            _lstOuHosInfo = _lstOuHosInfo.Filter("IsCancel", "True");
//            if (_lstOuHosInfo.Count <= 0)
//            {
//                returnSb.Append("--暂无门诊记录--");
//                return returnSb;
//            }
//            foreach (Model.OuHosInfoInfo _infoOuHosinfo in _lstOuHosInfo)
//            {
//                returnSb.Append(getOuHisToryContent(_infoOuHosinfo).ToString());
//            }
//            return returnSb;
//        }

//        private StringBuilder getOuHisToryContent(Model.OuHosInfoInfo _infoOuHosinfo)
//        {
//            Model.ModelList<Model.OuRecipeInfo> _lstOuRecipe = new Model.ModelList<Model.OuRecipeInfo>();
//            Model.ModelList<Model.OuRecipeDtlInfo> _lstOuRecipeDtl = new Model.ModelList<Model.OuRecipeDtlInfo>();
//            Model.ModelList<Model.OuClinicFirstInfo> _lstOuClinicFirst = new Model.ModelList<Model.OuClinicFirstInfo>();
//            Model.ModelList<Model.OuClincDiagInfo> _lstOuClincDiagInfo = new Model.ModelList<Model.OuClincDiagInfo>();



//            StringBuilder returnSb = new StringBuilder();
//            string ouContent = getOuContentString();//得到门诊模板  
//            string LsMarriage = _infoBsPatient.LsMarriage == 1 ? "儿童" : _infoBsPatient.LsMarriage == 2 ? "未婚" : _infoBsPatient.LsMarriage == 3 ? "初婚" : _infoBsPatient.LsMarriage == 4 ? "再婚" : _infoBsPatient.LsMarriage == 5 ? "离异" : _infoBsPatient.LsMarriage == 6 ? "丧偶" : "其它";

//            ouContent = StrReplace(ouContent, "lblAddress", _infoBsPatient.AddressHome);
//            ouContent = StrReplace(ouContent, "lblLsMarriage", LsMarriage);
//            ouContent = StrReplace(ouContent, "lblBirthDate", FormatTime(_infoBsPatient.BirthDate, 2));
//            ouContent = StrReplace(ouContent, "-就诊时间-", "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;就诊时间：" + FormatTime(_infoOuHosinfo.RegTime, 1)); 
//            if (_infoOuHosinfo.DoctorId > 0)
//            {
//                ouContent = StrReplace(ouContent, "lblDoctor", _objBsDoctor.GetByID(_infoOuHosinfo.DoctorId).Name);
//            }
//            else
//            {
//                ouContent = StrReplace(ouContent, "lblDoctor", "-");
//            }
//            ouContent = StrReplace(ouContent, "lblMedicareNo", _infoBsPatient.MedicareNo);
//            ouContent = StrReplace(ouContent, "lblMzRegNo", _infoOuHosinfo.MzRegNo);
//            ouContent = StrReplace(ouContent, "lblName", _infoOuHosinfo.Name);
//            ouContent = StrReplace(ouContent, "lblLocation", _infoOuHosinfo.RegDept > 0 ? _objBsLocation.GetByID(_infoOuHosinfo.RegDept).Name : "");
//            ouContent = StrReplace(ouContent, "lblOccupation", _infoBsPatient.Occupation);
//            ouContent = StrReplace(ouContent, "lblSex", _infoBsPatient.Sex.Trim() == "M" ? "男" : _infoBsPatient.Sex.Trim() == "F" ? "女" : "未知");
//            ouContent = StrReplace(ouContent, "lblPatType", _infoBsPatient.PatTypeId > 0 ? _objBsPatType.GetByID(_infoBsPatient.PatTypeId).Name : "");
           
//            _lstOuClincDiagInfo = new BLL.COuClincDiag().OuClincDiag_SelectByMzRegId(_infoOuHosinfo.GUID);
//            _lstOuClinicFirst = new BLL.COuClinicFirst().OuClinicFirst_SelectByMzRegId(_infoOuHosinfo.GUID);
 
//            Hashtable shValue = new Hashtable(); 
//            string CaseHisToryStringFormat = BLL.Common.Utils.GetSystemSetting("CaseHisToryStringFormat");
//            if (_lstOuClinicFirst.Count > 0)
//            {
//                Model.OuClinicFirstInfo OuClinicFirstInfo = new Model.OuClinicFirstInfo();
//                SetClinicFirstFieldContent(shValue, _lstOuClinicFirst[0].XMLEMR);
//                foreach (string var in shValue.Keys)
//                    if (CaseHisToryStringFormat.Contains(var))
//                        CaseHisToryStringFormat = StrReplace(CaseHisToryStringFormat, var, shValue[var].ToString()); 
//                ouContent = StrReplace(ouContent, "CaseHisToryStringFormat", CaseHisToryStringFormat); 
//            }
//            else
//            {
//                ouContent = StrReplace(ouContent, "CaseHisToryStringFormat", " <strong>主诉:</strong><br /> &nbsp;&nbsp;&nbsp;&nbsp; -<br /> <strong>现病史:</strong><br /> &nbsp;&nbsp;&nbsp;&nbsp; -<br /> <strong>体格检查:</strong>  <br /> &nbsp;&nbsp;&nbsp;&nbsp;-　 <br /><strong>辅助检查:</strong><br />&nbsp;&nbsp;&nbsp;&nbsp;-　<br />	 <strong>处理及建议:</strong><br />&nbsp;&nbsp;&nbsp;&nbsp;　-");
//            }
//            if (_lstOuClincDiagInfo.Count > 0)
//            {
//                string illness = string.Empty;

//                foreach (Model.OuClincDiagInfo info in _lstOuClincDiagInfo)
//                {
//                    if (info.IcdId > 0)
//                    {
//                        Model.BsIllnessInfo _infoBsIllness = new BLL.CBsIllness().GetByID(info.IcdId);
//                        illness += _infoBsIllness.Code;
//                        illness += " :" + _infoBsIllness.Name;
//                    }
//                    illness += " " + info.IllDesc;
//                } 
//                ouContent = StrReplace(ouContent, "lblXML", illness);
//            }
//            else
//            {
//                ouContent = StrReplace(ouContent, "lblXML", "-");
//            }
          



//            _lstOuRecipe = _objOuRecipe.OuRecipe_SelectByMzRegId(_infoOuHosinfo.GUID);
//            string dispose = string.Empty;
//            foreach (Model.OuRecipeInfo ouRecipe in _lstOuRecipe)
//            {
//                dispose += "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<strong style=\"color:#993399\">";
//                dispose += ouRecipe.LsRepType == 1 ? "西药" : ouRecipe.LsRepType == 2 ? "中药   "+ouRecipe.HowMany+" 剂" : "检查/检验/治疗";
//                dispose += "</strong><br/>";
//                _lstOuRecipeDtl = _objRecipeDtl.OuRecipeDtl_SelectByRecipeId(ouRecipe.GUID);
//                _lstOuRecipeDtl.Filter("IsCancel", "True");
//                foreach (Model.OuRecipeDtlInfo ouRecipeDtl in _lstOuRecipeDtl)
//                {
//                    Model.BsItemInfo bsItem = BLL.MemoryDate.GetBaseTableRowInfo<Model.BsItemInfo>("BsItem", ouRecipeDtl.ItemId);
//                    dispose += "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" + bsItem.Name  +" ";
//                    if (ouRecipe.LsRepType != 3)
//                    {
//                        dispose += bsItem.Spec + "";
//                        dispose += "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;用法：";
//                        dispose += ouRecipeDtl.Dosage > 0 ? "每次" + ouRecipeDtl.Dosage + (ouRecipeDtl.UnitTakeId > 0 ? _objBsUnit.GetByID(ouRecipeDtl.UnitTakeId).Name + " " : " ") + (ouRecipeDtl.UsageId > 0 ? _objBsUsag.GetByID(ouRecipeDtl.UsageId).Name : " ") : " ";
//                        dispose += ouRecipeDtl.FrequencyId > 0 ? "，频率：" + _objBsFrequency.GetByID(ouRecipeDtl.FrequencyId).Name : "";
//                        dispose += ouRecipeDtl.Days > 0 ? "；服 " + ouRecipeDtl.Days + " 天. " : "";
//                        dispose += "  总量：" + ouRecipeDtl.Totality + (ouRecipeDtl.UnitDiagId > 0 ? _objBsUnit.GetByID(ouRecipeDtl.UnitDiagId).Name : "") + "。\r\n<br/>";
//                    }
//                    else
//                    {
//                        dispose += ouRecipeDtl.Totality;
//                        dispose += ouRecipeDtl.UnitDiagId > 0 ? _objBsUnit.GetByID(ouRecipeDtl.UnitDiagId).Name : "项";
//                        dispose += "\r\n<br/>";
//                    }
//                }
//            }
//            ouContent = StrReplace(ouContent, "lblDispose", dispose);
//            returnSb.Append(ouContent);
//            return returnSb;
//        }

//        private void SetClinicFirstFieldContent(Hashtable sh, byte[] xml)
//        {
//            UTF8Encoding bytes = new UTF8Encoding();
//            string xmlContentString = bytes.GetString(xml, 0, xml.Length);
//            System.IO.StringReader stringReader = new StringReader(xmlContentString);
//            System.Xml.XmlDocument xmlDocument = new System.Xml.XmlDocument();
//            xmlDocument.Load(stringReader);
//            System.Xml.XmlNodeList xmlNodeListParent = xmlDocument.SelectNodes("/");
//            System.Xml.XmlNodeList xmlNodeListChild = xmlNodeListParent[0].ChildNodes[xmlNodeListParent[0].ChildNodes.Count - 1].ChildNodes;
//            for (int i = 0; i < xmlNodeListChild.Count; i++)
//                sh.Add(xmlNodeListChild[i].Name.Substring(3), xmlNodeListChild[i].InnerText.Trim()== "" ? " - " : xmlNodeListChild[i].InnerText); 
             
//        }
//        #endregion

//        #region 得到住院病历
//        string strFile = string.Empty;
//        Hashtable _htTopTableField = new Hashtable();

//        #region Hashtable
//        /// <summary>
//        /// infopath的内容如果要写入表格中。都必须在此hashtable中定义。
//        /// </summary>
//        private void InitHashTable()
//        {
//            _htTopTableField.Clear();
//            _htTopTableField.Add("LocationName", "科别");
//            _htTopTableField.Add("病区", "病区");
//            _htTopTableField.Add("BedName", "床号");
//            _htTopTableField.Add("HospNo", "住院病历号");
//            _htTopTableField.Add("PatientName", "姓名");
//            _htTopTableField.Add("Sex", "性别");
//            _htTopTableField.Add("日期", "日期");
//            _htTopTableField.Add("出生", "出生");
//            _htTopTableField.Add("BirthDate", "出生年月");
//            _htTopTableField.Add("Age", "年龄");
//            _htTopTableField.Add("NationName", "民族");
//            _htTopTableField.Add("PatTypeName", "职业");
//            _htTopTableField.Add("出生地", "出生地");
//            _htTopTableField.Add("MarriageName", "婚姻状况");
//            _htTopTableField.Add("AddressWork", "工作单位住址");
//            _htTopTableField.Add("PhoneWork", "工作单位电话");
//            _htTopTableField.Add("WorkTypeName", "职业");
//            //_htTopTableField.Add("AddressHome", "家庭住址");
//            _htTopTableField.Add("AddressHome", "常住住址");
//            _htTopTableField.Add("PhoneHome", "家庭电话");
//            _htTopTableField.Add("LinkmanAddress", "联系人地址");
//            _htTopTableField.Add("LinkmanNameAndRelation", "联系人(与患者的关系)");
//            _htTopTableField.Add("InTime", "入院日期");
//            _htTopTableField.Add("OutTime", "出院日期");
//            _htTopTableField.Add("Native", "籍贯");
//            _htTopTableField.Add("Month", "月");
//            _htTopTableField.Add("记录时间", "记录时间");
//            _htTopTableField.Add("InDaySum", "住院天数");
//            _htTopTableField.Add("输血目的", "输血目的");
//            _htTopTableField.Add("输血成分", "输血成分");
//            _htTopTableField.Add("小结时间", "小结时间");
//            _htTopTableField.Add("记录日期", "记录日期");
//            _htTopTableField.Add("手术日期", "手术日期");
//            _htTopTableField.Add("病史采集时间", "病史采集时间");
//            _htTopTableField.Add("病史陈述者", "病史陈述者");
//            _htTopTableField.Add("发病节气", "发病节气");
//            _htTopTableField.Add("交接班时间", "交接班时间");
//            _htTopTableField.Add("送检日期时间", "送检日期时间");
//            _htTopTableField.Add("收到日期时间", "收到日期时间");
//            _htTopTableField.Add("送检医院", "送检医院");
//            _htTopTableField.Add("门诊号", "门诊号");
//            _htTopTableField.Add("死亡时间", "死亡时间");
//            _htTopTableField.Add("死亡讨论日期", "死亡讨论日期");
//            _htTopTableField.Add("转出时间", "转出时间");
//            _htTopTableField.Add("转入时间", "转入时间");
//            _htTopTableField.Add("讨论时间", "讨论时间");
//            _htTopTableField.Add("父亲姓名", "父亲姓名");
//            _htTopTableField.Add("父亲工作单位及电话", "父亲工作单位及电话");
//            _htTopTableField.Add("母亲姓名", "母亲姓名");
//            _htTopTableField.Add("母亲工作单位及电话", "母亲工作单位及电话");
//            _htTopTableField.Add("病史陈术者__", "病史陈术者");
//            _htTopTableField.Add("与患者关系__", "与患者关系");

//        }
//        #endregion


//        string documentTopRtf1 = "<table width=\"100%\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" align=\"center\" ><tr><td colspan=\"6\" align=\"center\"><h3 >{0}</H3></td></tr>";
//        string documentTopRtf2 = " <tr><td  colspan=\"2\" width=\"20%\" class=\"dd\">&nbsp;</td><td  width=\"30%\"  align=\"left\"  class=\"dd\" >{0}&nbsp; ";
//        string documentTopRtf3 = "</td><td  width=\"30%\"  align=\"left\"  class=\"dd\">{0}&nbsp; </td><td width=\"20%\"  colspan=\"2\"  class=\"dd\">&nbsp;</td></tr>";
//        string documentTopRtf4 = "</table><br/>";
//        string documentTopRtf5 = "<strong>{0}</strong><br/>&nbsp;&nbsp;&nbsp;&nbsp;";
//        string documentTopRtf6 = "<strong>{0}:</strong>&nbsp;&nbsp;";
//        StringBuilder stringBuilder = new StringBuilder("");

//        BLL.CInEMR _objInEMR = new BLL.CInEMR();
//        BLL.CGblEMRCatalog _objGblEMRCatalog = new BLL.CGblEMRCatalog();
//        private StringBuilder getInHisTory()
//        {
//            StringBuilder returnSb = new StringBuilder();


//            Model.ModelList<Model.InHosInfoInfo> _lstInHosinfo = new Model.ModelList<Model.InHosInfoInfo>();
//            Model.ModelList<Model.InEMRInfo> _lstInEMRInfo = new Model.ModelList<Model.InEMRInfo>();

//            if (Type == 1)
//                _lstInHosinfo = _objInHosinfo.InHosInfo_SelectByPatID(Id);
//            if (Type == 2)
//                _lstInHosinfo = new Model.ModelList<Model.InHosInfoInfo>();
//            if (Type == 3)
//                _lstInHosinfo.Add(_objInHosinfo.GetByID(Id));

//            if (_lstInHosinfo.Count <= 0)
//            {
//                returnSb.Append("--暂无住院记录--");
//                return returnSb;
//            }

//            foreach (Model.InHosInfoInfo inHosInfoInfo in _lstInHosinfo)
//            {
//                returnSb.Append(getInHisToryContent(inHosInfoInfo).ToString());
//            }

//            return returnSb;
//        }
 

//        private StringBuilder getInHisToryContent(Model.InHosInfoInfo inHosInfoInfo)
//        {
//            StringBuilder returnSb = new StringBuilder();
//            Model.ModelList<Model.InEMRInfo> _lstInEmR = _objInEMR.InEMR_SelectByHospId(inHosInfoInfo.GUID);

//            stringBuilder = new StringBuilder();
//            returnSb.Append(string.Format("<div colspan=\"6\" style=\"text-align:left;height: 26px; text-align:left; color:#CCCC66; \"> 住院时间从 {0} → {1}", FormatTime(inHosInfoInfo.InTime, 3), FormatTime(inHosInfoInfo.OutTime, 3).Trim() == "" ? "至今" : FormatTime(inHosInfoInfo.OutTime, 3)));
//            if (_lstInEmR.Count <= 0)
//                returnSb.Append(string.Format("        --没有电子病历--"));

//            returnSb.Append(string.Format(" </div>"));
//            if (_lstInEmR.Count > 0)
//            {

//                Tools.Control.EMREditor emrEditor = new Tools.Control.EMREditor();
//                System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEMR)); 
//                emrEditor.Enabled = true; 
//                emrEditor.Name = "emrEditor";
//                emrEditor.OcxState = ((System.Windows.Forms.AxHost.State)( resources.GetObject("emrEditor.OcxState")));

//                ((System.ComponentModel.ISupportInitialize)(emrEditor)).BeginInit();  
//                ((System.ComponentModel.ISupportInitialize)(emrEditor)).EndInit();

//                foreach (Model.InEMRInfo _infoInEMR in _lstInEmR)
//                { 
//                    #region  保存为html文件,读取html文件
//                    if (_infoInEMR.Content == null || _infoInEMR.Content.Length <= 0) continue;

//                    try
//                    {

//                        emrEditor.SetDocumentStatus(1);
//                        emrEditor.FileOpen(_infoInEMR.Content);

//                        string fileAddress = string.Format("Temp\\{0}.html", _infoInEMR.GUID);
//                        //if (Convert.ToBoolean(BLL.Common.Utils.ReadLocalRegitFile("IsRemoteConnect")))
//                        //    MessageBox.Show("开始进入主界面");

//                        emrEditor.FileSaveAs(fileAddress, 7, 0);

//                        StreamReader sr = new StreamReader(fileAddress, Encoding.Default);
//                        string html = sr.ReadToEnd();
//                        foreach (Match m in Regex.Matches(html, @"<body.+?[\s\S]*?</body>"))
//                        {
//                            stringBuilder.Append(m.Value.ToString());
//                        }

//                        string catalogName = _objGblEMRCatalog.GetByID(_infoInEMR.CatalogId).Name;
//                        stringBuilder.Remove(0, stringBuilder.Length);
//                        stringBuilder.Append(string.Format(documentTopRtf5, catalogName));

//                    }
//                    catch (Exception e)
//                    {
 
//                    }
                   
//                    #endregion


//                }
//            }
//            returnSb.Append(stringBuilder.ToString());

//            returnSb.Append(hrString);
//            return returnSb;
//        }
//        #endregion

//        #region 得到检验报告

//        string row1 = "<tr><td align='left' style='width: 136px'>{0}</td><td align='left'>{1}</td><td align='left' style='width: 40px'>{2}</td><td align='left'>{3}</td>";
//        string row2 = "<td align='left' style='width: 136px'>{0}</td> <td align='left'>{1}</td> <td align='left' style='width: 40px'>{2}</td><td align='left'>{3}</td></tr>";

//        private StringBuilder getCkHisTory()
//        {
//            StringBuilder returnSb = new StringBuilder();

//            Model.ModelList<Model.CkLabInfo> _lstCkLab = new Model.ModelList<Model.CkLabInfo>();

//            BLL.CCkLab _objCkLab = new BLL.CCkLab();

//            if (Type == 1)
//                _lstCkLab = _objCkLab.CkLab_SelectByPatId(Id);
//            if (Type == 2)
//                _lstCkLab = _objCkLab.CkLab_SelectByMzRegId(Id);
//            if (Type == 3)
//                _lstCkLab = _objCkLab.CkLab_SelectByHospId(Id);


//            _lstCkLab = _lstCkLab.Filter("IsCancel", "True");
//            if (_lstCkLab.Count <= 0)
//            {
//                if (Mode==1)
//                {
//                   returnSb.Append("--没有检验报告--"); 
//                }
//                return returnSb;
//            }

//            foreach (Model.CkLabInfo _infoCkLab in _lstCkLab)
//            {
//                returnSb.Append(getCkHisToryContent(_infoCkLab));
//            }
//            return returnSb;
//        }

//        private StringBuilder getCkHisToryContent(Model.CkLabInfo _infoCkLab)
//        {
//            StringBuilder returnSb = new StringBuilder();
//            string ckContent = getCkContentString();//得到检验模板  
//            if (_infoCkLab.HospId != 0)
//            {
//                Model.InHosInfoInfo inhosinfo = _objInHosinfo.GetByID(_infoCkLab.HospId);
//                ckContent = StrReplace(ckContent, "lblBed", inhosinfo.BedId > 0 ? _objBsBed.GetByID(inhosinfo.BedId).Name : "");
//                ckContent = StrReplace(ckContent, "lblDoctor", inhosinfo.DoctorId > 0 ? _objBsDoctor.GetByID(inhosinfo.DoctorId).Name : "");
//                ckContent = StrReplace(ckContent, "lblLocation", inhosinfo.HospitalID > 0 ? _objBsLocation.GetByID(inhosinfo.HospitalID).Name : "");
//            }
//            else
//            {
//                ckContent = StrReplace(ckContent, "lblBed", "-");
//            }
//            if (_infoCkLab.MzRegId != 0)
//            {
//                Model.OuHosInfoInfo ouhosinfo = _objOuHosinfo.GetByID(_infoCkLab.MzRegId);
//                ckContent = StrReplace(ckContent, "lblDoctor", ouhosinfo.DoctorId > 0 ? _objBsDoctor.GetByID(ouhosinfo.DoctorId).Name : "");
//                ckContent = StrReplace(ckContent, "lblLocation", ouhosinfo.DiagnDept > 0 ? _objBsLocation.GetByID(ouhosinfo.DiagnDept).Name : "");
//            }


//            ckContent = StrReplace(ckContent, "lblName", _infoBsPatient.Name);
//            ckContent = StrReplace(ckContent, "lblNo", _objCKMachineSample.CKMachineSample_SelectByLabID(_infoCkLab.GUID).Count > 0 ? _objCKMachineSample.CKMachineSample_SelectByLabID(_infoCkLab.GUID)[0].SampleNum + "" : "");
//            ckContent = StrReplace(ckContent, "lblNum", _infoCkLab.LabNum);
//            ckContent = StrReplace(ckContent, "lblSex", _infoBsPatient.Sex.Trim() == "M" ? "男" : _infoBsPatient.Sex.Trim() == "F" ? "女" : "未知");
//            ckContent = StrReplace(ckContent, "BlblTestType", _objCkTestType.GetByID(_infoCkLab.TestTypeId).Name);
//            ckContent = StrReplace(ckContent, "TlblTestType", _objCkTestType.GetByID(_infoCkLab.TestTypeId).Name);

//            if (_infoCkLab.RecieveOperId > 0)
//            {
//                ckContent = StrReplace(ckContent, "lblRecieveOper", _objBsUser.GetByID(_infoCkLab.RecieveOperId).Name);
//                ckContent = StrReplace(ckContent, "lblRecieveTime", _infoCkLab.RecieveTime.ToString());
//            }
//            else
//            {
//                ckContent = StrReplace(ckContent, "lblRecieveOper", "-");
//                ckContent = StrReplace(ckContent, "lblRecieveTime", "-");
//            }
//            if (_infoCkLab.ResultOperId > 0)
//            {
//                ckContent = StrReplace(ckContent, "lblResultOper", _objBsUser.GetByID(_infoCkLab.ResultOperId).Name);
//                ckContent = StrReplace(ckContent, "lblResultTime", _infoCkLab.ResultTime.ToString());
//            }
//            else
//            {
//                ckContent = StrReplace(ckContent, "lblResultOper", "-");
//                ckContent = StrReplace(ckContent, "lblResultTime", "-");
//            }
//            if (_infoCkLab.ReportOperId > 0)
//            {
//                ckContent = StrReplace(ckContent, "lblReportOper", _objBsUser.GetByID(_infoCkLab.ReportOperId).Name);
//                ckContent = StrReplace(ckContent, "lblReportTime", _infoCkLab.ReportTime.ToString());
//            }
//            else
//            {
//                ckContent = StrReplace(ckContent, "lblReportOper", "-");
//                ckContent = StrReplace(ckContent, "lblReportTime", "-");
//            }
//            ckContent = StrReplace(ckContent, "lblBirthDate", (System.DateTime.Now.Year - _infoBsPatient.BirthDate.Year) + "");
//            ckContent = StrReplace(ckContent, "lblCardNo", _infoBsPatient.CardNo);


//            Model.ModelList<Model.CkLabResultInfo> _lstCkLabResult = _objCkLabResult.CkLabResult_SelectByLabId(_infoCkLab.GUID);
//            string result = string.Empty;
//            int tableIndex = 0;
//            if (_lstCkLabResult.Count > 0)
//            {
//                foreach (Model.CkLabResultInfo _infoCkLabResult in _lstCkLabResult)
//                {
//                    string resultString = _infoCkLabResult.Result;
//                    try
//                    {
//                        resultString += Convert.ToDouble(_infoCkLabResult.Result) < _infoCkLabResult.LowValue ? "<strong style='color: #009900'>&nbsp;↓&nbsp;</strong>" : "";
//                        resultString += Convert.ToDouble(_infoCkLabResult.Result) > _infoCkLabResult.HighValue ? "<strong style='color: #FF0000'>&nbsp;↑&nbsp;</strong>" : "";
//                    }
//                    catch (Exception) { }

//                    if (tableIndex % 2 == 0)
//                        result += string.Format(row1, _objCkItem.GetByID(_infoCkLabResult.TestId).Name, resultString, _infoCkLabResult.Unit, _infoCkLabResult.LowValue + " ― " + _infoCkLabResult.HighValue);
//                    else
//                        result += string.Format(row2, _objCkItem.GetByID(_infoCkLabResult.TestId).Name, resultString, _infoCkLabResult.Unit, _infoCkLabResult.LowValue + " ― " + _infoCkLabResult.HighValue);

//                    tableIndex++;
//                }
//                if (tableIndex % 2 != 0) result += string.Format(row2, "", "", "", "");
//                ckContent = StrReplace(ckContent, "lblRow", result);
//            }
//            else
//            {
//                ckContent = StrReplace(ckContent, "lblRow", "<h3 style='color: #009900'>此次检验还没有结果！</h3>");
//            }
//            returnSb.Append(ckContent);
//            return returnSb;
//        }

//        #endregion 

//        #region 得到影像报告

//        public string getType(int type)
//        {
//            string XType = string.Empty;
//            switch (type)
//            {
//                case 1: XType = "CT"; break;
//                case 2: XType = "DR"; break;
//                case 3: XType = "MR"; break;
//                case 4: XType = "CR"; break;
//                case 5: XType = "RF"; break;
//                case 6: XType = "US"; break;
//                case 7: XType = "脑电图"; break;
//                case 8: XType = "心电图"; break;
//                case 9: XType = "镜检查"; break;
//                case 10: XType = "MG"; break;
//                case 11: XType = "DSA"; break;
//                default: XType = "DSA"; break;
//            }
//            return XType;
//        }

//        BLL.CPsApplyReport _objPsApplyReport = new BLL.CPsApplyReport();

//        private StringBuilder getPsHisTory()
//        {
//            StringBuilder returnSb = new StringBuilder();


//            Model.ModelList<Model.PsApplyReportInfo> _lstPsApplyReport = new Model.ModelList<Model.PsApplyReportInfo>();

//            if (Type == 1)
//                _lstPsApplyReport = _objPsApplyReport.PsApplyReport_SelectByPatId(Id);
//            if (Type == 2)
//                _lstPsApplyReport = _objPsApplyReport.PsApplyReport_SelectByMzRegId(Id);
//            if (Type == 3)
//                _lstPsApplyReport = _objPsApplyReport.PsApplyReport_SelectByHospId(Id);


//            if (_lstPsApplyReport.Count == 0)
//            {
//                if (Mode == 1)
//                {
//                    returnSb.Append("--没有影像报告--");
//                }
//                return returnSb;
//            }

//            foreach (Model.PsApplyReportInfo _infoPsApplyReport in _lstPsApplyReport)
//            {
//                returnSb.Append(getPsHisToryContent(_infoPsApplyReport).ToString());
//            }
//            return returnSb;
//        }

//        private StringBuilder getPsHisToryContent(Model.PsApplyReportInfo _infoPsApplyReport)
//        {
//            StringBuilder returnSb = new StringBuilder();
//            string psContent = getPsContentString();
//            if (_infoPsApplyReport.HospId != 0)
//            {
//                Model.InHosInfoInfo inhosinfo = _objInHosinfo.GetByID(_infoPsApplyReport.HospId);
//                psContent = StrReplace(psContent, "lblBed", inhosinfo.BedId > 0 ? _objBsBed.GetByID(inhosinfo.BedId).Name : "");
//                psContent = StrReplace(psContent, "lblDoctor", inhosinfo.DoctorId > 0 ? _objBsDoctor.GetByID(inhosinfo.DoctorId).Name : "");
//                psContent = StrReplace(psContent, "lblLocation", inhosinfo.HospitalID > 0 ? _objBsLocation.GetByID(inhosinfo.HospitalID).Name : "");
//            }
//            else
//            {
//                psContent = StrReplace(psContent, "lblBed", "-");
//            }
//            if (_infoPsApplyReport.MzRegId != 0)
//            {
//                Model.OuHosInfoInfo ouhosinfo = _objOuHosinfo.GetByID(_infoPsApplyReport.MzRegId);
//                psContent = StrReplace(psContent, "lblDoctor", ouhosinfo.DoctorId > 0 ? _objBsDoctor.GetByID(ouhosinfo.DoctorId).Name : "");
//                psContent = StrReplace(psContent, "lblLocation", ouhosinfo.DiagnDept > 0 ? _objBsLocation.GetByID(ouhosinfo.DiagnDept).Name : "");
//                psContent = StrReplace(psContent, "lblNo", ouhosinfo.MzRegNo);
//            }
//            psContent = StrReplace(psContent, "lblName", _infoBsPatient.Name);
//            psContent = StrReplace(psContent, "lblCardNo", _infoBsPatient.CardNo);
//            psContent = StrReplace(psContent, "lblSex", _infoBsPatient.Sex.Trim() == "M" ? "男" : _infoBsPatient.Sex.Trim() == "F" ? "女" : "未知");
//            string XType = this.getType(_infoPsApplyReport.XType);

//            psContent = StrReplace(psContent, "lblTestType", XType);
//            psContent = StrReplace(psContent, "lblCheckBody", _infoPsApplyReport.CheckBody);
//            psContent = StrReplace(psContent, "lblCheckAdvice", _infoPsApplyReport.CheckAdvice);
//            psContent = StrReplace(psContent, "lblCheckDesc", _infoPsApplyReport.CheckDesc);
//            psContent = StrReplace(psContent, "lblCheckResult", _infoPsApplyReport.CheckResult);
//            psContent = StrReplace(psContent, "lblApplyMemo", _infoPsApplyReport.ApplyMemo);
//            psContent = StrReplace(psContent, "lblCheckParm", _infoPsApplyReport.CheckParm);
//            psContent = StrReplace(psContent, "lblIsAbNormal", _infoPsApplyReport.IsAbNormal ? "是" : "否");
//            psContent = StrReplace(psContent, "lblEquipment", _infoPsApplyReport.Equipment);
//            psContent = StrReplace(psContent, "lblApplyNo", _infoPsApplyReport.ApplyNo);
//            psContent = StrReplace(psContent, "lblBirthDate", (System.DateTime.Now.Year - _infoBsPatient.BirthDate.Year) + "");



//            if (_infoPsApplyReport.OperId > 0)
//            {
//                psContent = StrReplace(psContent, "lblOperTime", _infoPsApplyReport.OperTime.ToString());
//                psContent = StrReplace(psContent, "lblOper", _objBsUser.GetByID(_infoPsApplyReport.OperId).Name);
//            }
//            else
//            {
//                psContent = StrReplace(psContent, "lblOperTime", "-");
//                psContent = StrReplace(psContent, "lblOper", "-");
//            }

//            if (_infoPsApplyReport.CheckOperId > 0)
//            {
//                psContent = StrReplace(psContent, "lblCheckTime", _infoPsApplyReport.CheckTime.ToString());
//                psContent = StrReplace(psContent, "lblCheckOper", _objBsUser.GetByID(_infoPsApplyReport.CheckOperId).Name);
//            }
//            else
//            {
//                psContent = StrReplace(psContent, "lblCheckTime", "-");
//                psContent = StrReplace(psContent, "lblCheckOper", "-");
//            }
//            psContent = StrReplace(psContent, "TblLocations", _infoPsApplyReport.HospitalID > 0 ? _objBsLocation.GetByID(_infoPsApplyReport.HospitalID).Name : "-");
//            psContent = StrReplace(psContent, "lblExecLoc", _infoPsApplyReport.ExecLocId > 0 ? _objBsLocation.GetByID(_infoPsApplyReport.ExecLocId).Name : "-");

//            if (_infoPsApplyReport.ReportOperId > 0)
//            {
//                psContent = StrReplace(psContent, "lblReportTime", _infoPsApplyReport.ReportTime.ToString());
//                psContent = StrReplace(psContent, "lblReportOper", _objBsUser.GetByID(_infoPsApplyReport.ReportOperId).Name);
//            }
//            else
//            {
//                psContent = StrReplace(psContent, "lblReportTime", "-");
//                psContent = StrReplace(psContent, "lblReportOper", "-");
//            }
//            returnSb.Append(psContent);
//            returnSb.Append(hrString);

//            return returnSb;
//        }
//        #endregion 

//        #region 得到整个网页模板
//        public string getHtmlContent()
//        {
//            StringBuilder sb = new StringBuilder();
//            if (Mode == 1)
//            {
//                sb.Append("<!DOCTYPE   html   PUBLIC   \"-//W3C//DTD   XHTML   1.0   Transitional//EN \"   \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd \"> ");
//                sb.Append("<html   xmlns= \"http://www.w3.org/1999/xhtml \"> ");
//                sb.Append("<head> ");
//                sb.Append("<meta   http-equiv= \"Content-Type \"   content= \"text/html;   charset=gb2312 \"   /> ");
//                sb.Append("<title>-某某医院-病人--病人名字--电子病历</title> ");
//                sb.Append("<style>  ");
//                sb.Append("    A:link {");
//                sb.Append("	COLOR: #000000; TEXT-DECORATION: none");
//                sb.Append("}");
//                sb.Append("A:visited {");
//                sb.Append("	COLOR: #000000; TEXT-DECORATION: none");
//                sb.Append("}");
//                sb.Append("form {");
//                sb.Append("	PADDING-RIGHT: 1px; PADDING-LEFT: 1px; PADDING-BOTTOM: 1px; MARGIN: 1px; PADDING-TOP: 1px");
//                sb.Append("}");
//                sb.Append("");
//                sb.Append("div{FONT-SIZE: 12px; line-height:23px}");
//                sb.Append("");
//                sb.Append("");
//                sb.Append("/* 定义文本框样式*/");
//                sb.Append(".inputBox {");
//                sb.Append("	BORDER-RIGHT: lightgrey 0px solid; ");
//                sb.Append("	BORDER-TOP: navy 0px solid; FONT-SIZE: 12pt;");
//                sb.Append("	 BORDER-LEFT: lightgrey 0px solid; COLOR: black;");
//                sb.Append("	 BORDER-BOTTOM: black 1px solid; FONT-FAMILY: Arial;");
//                sb.Append("	  BACKGROUND-COLOR: transparent	 ");
//                sb.Append("}");
//                sb.Append("");
//                sb.Append("/* 定义DataGrid边样式  */");
//                sb.Append(".grayBorder");
//                sb.Append("{");
//                sb.Append("	border:solid #999999 1px;");
//                sb.Append("}");
//                sb.Append("");
//                sb.Append("/* DataGrid表头样式 */");
//                sb.Append(".headerCenter {");
//                sb.Append("	PADDING-RIGHT: 4px; PADDING-LEFT: 4px;  PADDING-BOTTOM: 1px; BORDER-LEFT: #808080 0px solid; PADDING-TOP: 2px; BORDER-BOTTOM: #808080 1px solid; BACKGROUND-COLOR: #e8e5e1; TEXT-ALIGN:center! important;");
//                sb.Append("}");
//                sb.Append("");
//                sb.Append("/* 输入文字样式*/");
//                sb.Append(".inputCss {  ");
//                sb.Append("    font-size: 12pt; ");
//                sb.Append("    color: #003399; ");
//                sb.Append("    font-family: \"宋体\"; ");
//                sb.Append("    font-style: normal; ");
//                sb.Append("    border-color: #F86A6A #F86A6A #F86A6A #F86A6A ; ");
//                sb.Append("    border: 1px #F86A6A solid; ");
//                sb.Append("}");
//                sb.Append("");
//                sb.Append("/* 输入文字样式*/");
//                sb.Append(".dropDownListInputCss {  ");
//                sb.Append("    font-size: 12pt; ");
//                sb.Append("    color: #003399; ");
//                sb.Append("    font-family: \"宋体\"; ");
//                sb.Append("    font-style: normal; ");
//                sb.Append("    border-color: #93BEE2 #93BEE2 #93BEE2 #93BEE2 ; ");
//                sb.Append("    border: 1px #93BEE2 solid; ");
//                sb.Append("}");
//                sb.Append("");
//                sb.Append("/*定义文本区输入样式 */");
//                sb.Append(".textArea ");
//                sb.Append("{");
//                sb.Append("	BORDER-RIGHT: gray 1px solid; BORDER-TOP: gray 1px solid; BORDER-LEFT: gray 1px solid; BORDER-BOTTOM:gray 1px solid;OVERFLOW: auto;  FONT-FAMILY: 宋体; BACKGROUND-COLOR:#ffffff");
//                sb.Append("}");
//                sb.Append("");
//                sb.Append("/* 下拉菜单样式*/");
//                sb.Append(".ddlCss");
//                sb.Append("{");
//                sb.Append("    font-size  : 12pt; ");
//                sb.Append("    color: #003399; ");
//                sb.Append("    font-family: \"宋体\"; ");
//                sb.Append("    font-style: normal; ");
//                sb.Append("    border:0px;    ");
//                sb.Append("}");
//                sb.Append("");
//                sb.Append("/*按钮样式*/");
//                sb.Append(".buttonCss {");
//                sb.Append("    font-family: \"Tahoma\", \"宋体\";");
//                sb.Append("    font-size: 12pt; color: #003399;");
//                sb.Append("    border: 1px #003399 solid;");
//                sb.Append("    color:#006699;");
//                sb.Append("    BORDER-BOTTOM: #93bee2 1px solid; ");
//                sb.Append("    BORDER-LEFT: #93bee2 1px solid; ");
//                sb.Append("    BORDER-RIGHT: #93bee2 1px solid; ");
//                sb.Append("    BORDER-TOP: #93bee2 1px solid;");
//                sb.Append("    background-image:url(images/bluebuttonbg.gif);");
//                sb.Append("    background-color: #e8f4ff;");
//                sb.Append("    CURSOR: hand;");
//                sb.Append("    font-style: normal ;");
//                sb.Append("}");
//                sb.Append("");
//                sb.Append(" .title_ul2{");
//                sb.Append("	height:30px;");
//                sb.Append("	background-color:#ebefee;");
//                sb.Append("	text-decoration:none;");
//                sb.Append("	margin-left:0;");
//                sb.Append("   }");
//                sb.Append("  .title_booklist0{");
//                sb.Append("    float:left;");
//                sb.Append("    width:35%;");
//                sb.Append("	}	");
//                sb.Append("  .title_booklist1{");
//                sb.Append("    float:left;");
//                sb.Append("	width:20%;");
//                sb.Append("");
//                sb.Append("	}");
//                sb.Append("  .title_booklist2{");
//                sb.Append("    float:left;");
//                sb.Append("	margin-left:auto;");
//                sb.Append("	width:20%;");
//                sb.Append("");
//                sb.Append("	}");
//                sb.Append("  .title_booklist3{");
//                sb.Append("    float:left;");
//                sb.Append("	width:15%;");
//                sb.Append("	");
//                sb.Append("	}");
//                sb.Append("  .title_booklist4{");
//                sb.Append("    float:left;");
//                sb.Append("	width:10%;");
//                sb.Append("");
//                sb.Append("	}");
//                sb.Append("	");
//                sb.Append(".dd {");
//                sb.Append("	border-bottom-width: thin;");
//                sb.Append("	border-bottom-style: solid;");
//                sb.Append("	border-bottom-color: #555555;");
//                sb.Append("    }");
//                sb.Append("    ");
//                sb.Append(".dts");
//                sb.Append("   { ");
//                sb.Append("	border-right-width: thin;");
//                sb.Append("	border-right-style: solid;");
//                sb.Append("	border-right-color: #555555; ");
//                sb.Append("	}");
//                sb.Append("    ");
//                sb.Append("    ");
//                sb.Append("*   {   margin:0;   padding:0;} ");
//                sb.Append(" table{ border:solid 1px #000000; } "); 
//                sb.Append("body   {   text-align:center;   font:75%   Verdana,   Arial,   Helvetica,   sans-serif;} ");
//                sb.Append("h1   {   font:125%   Arial,   Helvetica,   sans-serif;   text-align:left;   font-weight:bolder;   background:#ced1d5;     padding:3px;   display:block;   } ");
//                sb.Append(".class1   {   width:75%;    position:relative;   margin:0   auto;   padding:5px;} ");
//                sb.Append("span   {   position:absolute;   right:10px;   top:8px;   cursor:pointer;   color:#0000ff; } ");
//                sb.Append("p   {   text-align:left;   line-height:20px;    padding:3px;   margin-top:5px;   } ");
//                sb.Append("#class1content   {   height:300px;overflow:hidden} ");
//                sb.Append("</style> ");
//                sb.Append("<script type=\"text/javascript\" language=\"javascript\"> ");
//                sb.Append(" ");
//                sb.Append("function clicks(btns,divs){  ");
//                sb.Append("       var   div1= document.getElementById(divs); ");
//                sb.Append("      if(div1.style.display == 'none'){  ");
//                sb.Append("        btns.innerHTML= '收缩︽ '; ");
//                sb.Append("        div1.style.display = 'block'; ");
//                sb.Append("      }else{  ");
//                sb.Append("        btns.innerHTML= '展开︾'; ");
//                sb.Append("        div1.style.display = 'none';");
//                sb.Append("      } ");
//                sb.Append("} ");
//                sb.Append("");
//                sb.Append("</script> ");
//                sb.Append("</head> ");
//                sb.Append("<body>  ");
//                sb.Append("");
//                sb.Append("<div style=\"text-align:center\">\r\n");
//                sb.Append(" <br />\r\n");
//                sb.Append("<h3 style=\"font-family: 华文行楷;font-size: x-large;\">-某某医院-病人电子病历</h3>\r\n");
//                sb.Append("        <br />\r\n");
//                sb.Append("        <hr />\r\n");
//                sb.Append("<div  class= \"class1 \"> ");
//                sb.Append("<h1 style=\"font-family: 华文楷体; font-size:medium\">门诊病历 </h1> ");
//                sb.Append("<span   id= \"btnInHisTory \"   onclick= \"clicks(this,'divOuHisTory') \"> 收缩︽ </span> ");
//                sb.Append("        <br />\r\n");
//                sb.Append("<div id=\"divOuHisTory\" style=\"display:block\">\r\n");
//                sb.Append(" -OuHisTory-");
//                sb.Append("");
//                sb.Append("</div>\r\n");
//                sb.Append("</div> ");
//                sb.Append("<div  class= \"class1 \"> ");
//                sb.Append("<h1  style=\"font-family: 华文楷体; font-size:medium\">住院病历 </h1> ");
//                sb.Append("<span   id= \"Span2\"   onclick= \"clicks(this,'divInHisTory') \"> 收缩︽ </span> ");
//                sb.Append("<div id=\"divInHisTory\" style=\"display:block\">\r\n");
//                sb.Append("-InHisTory-");
//                sb.Append("");
//                sb.Append("</div>\r\n");
//                sb.Append("</div> ");
//                sb.Append("<div  class= \"class1 \"> ");
//                sb.Append("<h1  style=\"font-family: 华文楷体; font-size:medium\">检验报告</h1> ");
//                sb.Append("<span   id= \"Span3\"   onclick= \"clicks(this,'divCkHisTory') \"> 收缩︽ </span> ");
//                sb.Append("<div id=\"divCkHisTory\" style=\"display:block\">\r\n");
//                sb.Append(" -CkHisTory-");
//                sb.Append("");
//                sb.Append("</div>\r\n");
//                sb.Append("</div> ");
//                sb.Append("<div  class= \"class1 \"> ");
//                sb.Append("<h1  style=\"font-family: 华文楷体; font-size:medium\">影像报告 </h1> ");
//                sb.Append("<span   id= \"Span1\"   onclick= \"clicks(this,'divPsHisTory') \"> 收缩︽ </span> ");
//                sb.Append("<div id=\"divPsHisTory\" style=\"display:block\">\r\n");
//                sb.Append(" -PsHisTory-");
//                sb.Append("");
//                sb.Append("</div>\r\n");
//                sb.Append("</div> ");
//                sb.Append("");
//                sb.Append("   <div class= \"class1 \"    style=\"width:80%;height:70px;position:relative;background-color:#ced1d5;text-align:center;  \">\r\n");
//                sb.Append("         <br/>-某某医院-病人电子病历浏览<br/>\r\n");
//                //sb.Append("         ©2009 广州市联胜数码科技有限公司版权所有 ");
//                //sb.Append("        <br/> ");
//                sb.Append("  </div>\r\n");
//                sb.Append("");
//                sb.Append("  </div>\r\n");
//                sb.Append("");
//                sb.Append("</body> ");
//                sb.Append("</html> ");
//                sb.Append(" ");
//            }
//            else
//            {
//                sb.Append("<!DOCTYPE   html   PUBLIC   \"-//W3C//DTD   XHTML   1.0   Transitional//EN \"   \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd \"> ");
//                sb.Append("<html   xmlns= \"http://www.w3.org/1999/xhtml \"> ");
//                sb.Append("<head> ");
//                sb.Append("<meta   http-equiv= \"Content-Type \"   content= \"text/html;   charset=gb2312 \"   /> ");
//                sb.Append("<title>-某某医院-病人--病人名字--电子病历</title> ");
//                sb.Append("<style>  ");
//                sb.Append("    A:link {");
//                sb.Append("	COLOR: #000000; TEXT-DECORATION: none");
//                sb.Append("}");
//                sb.Append("A:visited {");
//                sb.Append("	COLOR: #000000; TEXT-DECORATION: none");
//                sb.Append("}");
//                sb.Append("form {");
//                sb.Append("	PADDING-RIGHT: 1px; PADDING-LEFT: 1px; PADDING-BOTTOM: 1px; MARGIN: 1px; PADDING-TOP: 1px");
//                sb.Append("}");
//                sb.Append("");
//                sb.Append("div{FONT-SIZE: 12px; line-height:23px}");
//                sb.Append("");
//                sb.Append("");
//                sb.Append("/* 定义文本框样式*/");
//                sb.Append(".inputBox {");
//                sb.Append("	BORDER-RIGHT: lightgrey 0px solid; ");
//                sb.Append("	BORDER-TOP: navy 0px solid; FONT-SIZE: 12pt;");
//                sb.Append("	 BORDER-LEFT: lightgrey 0px solid; COLOR: black;");
//                sb.Append("	 BORDER-BOTTOM: black 1px solid; FONT-FAMILY: Arial;");
//                sb.Append("	  BACKGROUND-COLOR: transparent	 ");
//                sb.Append("}");
//                sb.Append("");
//                sb.Append("/* 定义DataGrid边样式  */");
//                sb.Append(".grayBorder");
//                sb.Append("{");
//                sb.Append("	border:solid #999999 1px;");
//                sb.Append("}");
//                sb.Append("");
//                sb.Append("/* DataGrid表头样式 */");
//                sb.Append(".headerCenter {");
//                sb.Append("	PADDING-RIGHT: 4px; PADDING-LEFT: 4px;  PADDING-BOTTOM: 1px; BORDER-LEFT: #808080 0px solid; PADDING-TOP: 2px; BORDER-BOTTOM: #808080 1px solid; BACKGROUND-COLOR: #e8e5e1; TEXT-ALIGN:center! important;");
//                sb.Append("}");
//                sb.Append("");
//                sb.Append("/* 输入文字样式*/");
//                sb.Append(".inputCss {  ");
//                sb.Append("    font-size: 12pt; ");
//                sb.Append("    color: #003399; ");
//                sb.Append("    font-family: \"宋体\"; ");
//                sb.Append("    font-style: normal; ");
//                sb.Append("    border-color: #F86A6A #F86A6A #F86A6A #F86A6A ; ");
//                sb.Append("    border: 1px #F86A6A solid; ");
//                sb.Append("}");
//                sb.Append("");
//                sb.Append("/* 输入文字样式*/");
//                sb.Append(".dropDownListInputCss {  ");
//                sb.Append("    font-size: 12pt; ");
//                sb.Append("    color: #003399; ");
//                sb.Append("    font-family: \"宋体\"; ");
//                sb.Append("    font-style: normal; ");
//                sb.Append("    border-color: #93BEE2 #93BEE2 #93BEE2 #93BEE2 ; ");
//                sb.Append("    border: 1px #93BEE2 solid; ");
//                sb.Append("}");
//                sb.Append("");
//                sb.Append("/*定义文本区输入样式 */");
//                sb.Append(".textArea ");
//                sb.Append("{");
//                sb.Append("	BORDER-RIGHT: gray 1px solid; BORDER-TOP: gray 1px solid; BORDER-LEFT: gray 1px solid; BORDER-BOTTOM:gray 1px solid;OVERFLOW: auto;  FONT-FAMILY: 宋体; BACKGROUND-COLOR:#ffffff");
//                sb.Append("}");
//                sb.Append("");
//                sb.Append("/* 下拉菜单样式*/");
//                sb.Append(".ddlCss");
//                sb.Append("{");
//                sb.Append("    font-size  : 12pt; ");
//                sb.Append("    color: #003399; ");
//                sb.Append("    font-family: \"宋体\"; ");
//                sb.Append("    font-style: normal; ");
//                sb.Append("    border:0px;    ");
//                sb.Append("}");
//                sb.Append("");
//                sb.Append("/*按钮样式*/");
//                sb.Append(".buttonCss {");
//                sb.Append("    font-family: \"Tahoma\", \"宋体\";");
//                sb.Append("    font-size: 12pt; color: #003399;");
//                sb.Append("    border: 1px #003399 solid;");
//                sb.Append("    color:#006699;");
//                sb.Append("    BORDER-BOTTOM: #93bee2 1px solid; ");
//                sb.Append("    BORDER-LEFT: #93bee2 1px solid; ");
//                sb.Append("    BORDER-RIGHT: #93bee2 1px solid; ");
//                sb.Append("    BORDER-TOP: #93bee2 1px solid;");
//                sb.Append("    background-image:url(images/bluebuttonbg.gif);");
//                sb.Append("    background-color: #e8f4ff;");
//                sb.Append("    CURSOR: hand;");
//                sb.Append("    font-style: normal ;");
//                sb.Append("}");
//                sb.Append("");
//                sb.Append(" .title_ul2{");
//                sb.Append("	height:30px;");
//                sb.Append("	background-color:#ebefee;");
//                sb.Append("	text-decoration:none;");
//                sb.Append("	margin-left:0;");
//                sb.Append("   }");
//                sb.Append("  .title_booklist0{");
//                sb.Append("    float:left;");
//                sb.Append("    width:35%;");
//                sb.Append("	}	");
//                sb.Append("  .title_booklist1{");
//                sb.Append("    float:left;");
//                sb.Append("	width:20%;");
//                sb.Append("");
//                sb.Append("	}");
//                sb.Append("  .title_booklist2{");
//                sb.Append("    float:left;");
//                sb.Append("	margin-left:auto;");
//                sb.Append("	width:20%;");
//                sb.Append("");
//                sb.Append("	}");
//                sb.Append("  .title_booklist3{");
//                sb.Append("    float:left;");
//                sb.Append("	width:15%;");
//                sb.Append("	");
//                sb.Append("	}");
//                sb.Append("  .title_booklist4{");
//                sb.Append("    float:left;");
//                sb.Append("	width:10%;");
//                sb.Append("");
//                sb.Append("	}");
//                sb.Append("	");
//                sb.Append(".dd {");
//                sb.Append("	border-bottom-width: thin;");
//                sb.Append("	border-bottom-style: solid;");
//                sb.Append("	border-bottom-color: #555555;");
//                sb.Append("    }");
//                sb.Append("    ");
//                sb.Append(".dts");
//                sb.Append("   { ");
//                sb.Append("	border-right-width: thin;");
//                sb.Append("	border-right-style: solid;");
//                sb.Append("	border-right-color: #555555; ");
//                sb.Append("	}");
//                sb.Append("    ");
//                sb.Append("    ");
//                sb.Append("*   {   margin:0;   padding:0;} ");
//                sb.Append(" table{ border:solid 1px #000000; } "); 
//                sb.Append("body   {   text-align:center;   font:75%   Verdana,   Arial,   Helvetica,   sans-serif;} ");
//                sb.Append("h1   {   font:125%   Arial,   Helvetica,   sans-serif;   text-align:left;   font-weight:bolder;   background:#ced1d5;     padding:3px;   display:block;   } ");
//                sb.Append(".class1   {   width:75%;    position:relative;   margin:0   auto;   padding:5px;} ");
//                sb.Append("span   {   position:absolute;   right:10px;   top:8px;   cursor:pointer;   color:#0000ff; } ");
//                sb.Append("p   {   text-align:left;   line-height:20px;    padding:3px;   margin-top:5px;   } ");
//                sb.Append("#class1content   {   height:300px;overflow:hidden} ");
//                sb.Append("</style> ");
//                sb.Append("<script type=\"text/javascript\" language=\"javascript\"> ");
//                sb.Append(" ");
//                sb.Append("function clicks(btns,divs){  ");
//                sb.Append("       var   div1= document.getElementById(divs); ");
//                sb.Append("      if(div1.style.display == 'none'){  ");
//                sb.Append("        btns.innerHTML= '收缩︽ '; ");
//                sb.Append("        div1.style.display = 'block'; ");
//                sb.Append("      }else{  ");
//                sb.Append("        btns.innerHTML= '展开︾'; ");
//                sb.Append("        div1.style.display = 'none';");
//                sb.Append("      } ");
//                sb.Append("} ");
//                sb.Append("");
//                sb.Append("</script> ");
//                sb.Append("</head> ");
//                sb.Append("<body>  ");
//                sb.Append("");
//                sb.Append("<div style=\"text-align:center\">\r\n");
//                sb.Append(" <br />\r\n");
//                sb.Append("<h3 style=\"font-family: 华文行楷;font-size: x-large;\">-某某医院-病人电子病历</h3>\r\n");
//                sb.Append("        <br />\r\n");
//                sb.Append("        <hr />\r\n");

//                sb.Append("<div  class= \"class1 \"> ");
//                sb.Append("<h1 style=\"font-family: 华文楷体; font-size:medium\"> </h1> ");
//                sb.Append("<div id=\"divOuHisTory\" style=\"display:block\">\r\n");
//                sb.Append(" -HisTory-");
//                sb.Append("");
//                sb.Append("</div>\r\n");
//                sb.Append("</div> ");

//                sb.Append("");
//                sb.Append("   <div class= \"class1 \"    style=\"width:80%;height:70px;position:relative;background-color:#ced1d5;text-align:center;  \">\r\n");
//                sb.Append("         <br/>-某某医院-病人电子病历浏览<br/>\r\n");
//                //sb.Append("         ©2009 广州市联胜数码科技有限公司版权所有 ");
//                //sb.Append("        <br/> ");
//                sb.Append("  </div>\r\n");
//                sb.Append("");
//                sb.Append("  </div>\r\n");
//                sb.Append("");
//                sb.Append("</body> ");
//                sb.Append("</html> ");
//                sb.Append(" ");

//            }

//            return sb.ToString();
//        }
//        #endregion

//        #region 门诊模板
//        public string getOuContentString()
//        {
//            StringBuilder sb = new StringBuilder();
//            sb.Append("");
//            sb.Append(" <div style=\"text-align:center\">\r\n");
//            sb.Append("     <table width=\"700xp\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\"  align=\"center\">\r\n");
//            sb.Append("<tr  class=\"dd\">\r\n");
//            sb.Append("<td  class=\"dd\"   colspan=\"6\" style=\"height: 42px; text-align:center;font-family: 华文楷体;  \"><h2> -某某医院-门诊记录</h2></td>\r\n");
//            sb.Append("</tr>  <tr  class=\"dd\">\r\n"); 
//            sb.Append("  <tr  class=\"dd\">\r\n");
//            sb.Append("    <td  class=\"dd\"  colspan=\"6\" style=\"height: 12px; text-align:left; color:#CCCC66; \"> -就诊时间-</td>\r\n");
//            sb.Append("  </tr>\r\n");
//            sb.Append("  <tr>\r\n");
//            sb.Append("    <td align=\"left\" style=\"width: 87px; height: 23px; text-align: right;\">门 诊 号：</td>\r\n");
//            sb.Append("    <td align=\"left\" style=\"width: 157px; color: #0000ff; text-align: left; height: 23px;\">\r\n");
//            sb.Append("        lblMzRegNo ");
//            sb.Append("    </td>\r\n");
//            sb.Append("    <td align=\"left\" style=\"width: 83px; height: 23px; text-align: right;\">医疗证号：</td>\r\n");
//            sb.Append("    <td align=\"left\" style=\"width: 157px; color: #0000ff; text-align: left; height: 23px;\">\r\n");
//            sb.Append("         lblMedicareNo ");
//            sb.Append("    </td>\r\n");
//            sb.Append("    <td align=\"left\" style=\"width: 81px; height: 23px; text-align: right;\">\r\n");
//            sb.Append("        费 &nbsp; &nbsp;&nbsp; 别：</td>\r\n");
//            sb.Append("    <td align=\"left\" style=\"width: 157px; color: #0000ff; text-align: left; height: 23px;\">\r\n");
//            sb.Append("        lblPatType ");
//            sb.Append("    </td>\r\n");
//            sb.Append("  </tr>\r\n");
//            sb.Append("  <tr>\r\n");
//            sb.Append("    <td align=\"left\" style=\"width: 87px; height: 23px; text-align: right;\">\r\n");
//            sb.Append("        姓 &nbsp;&nbsp;&nbsp; 名：</td>\r\n");
//            sb.Append("    <td align=\"left\" style=\"width: 157px; color: #0000ff; text-align: left;\">\r\n");
//            sb.Append("        lblName");
//            sb.Append("    </td>\r\n");
//            sb.Append("    <td align=\"left\" style=\"width: 83px; height: 23px; text-align: right;\">\r\n");
//            sb.Append("        性 &nbsp; &nbsp;&nbsp; 别：</td>\r\n");
//            sb.Append("    <td align=\"left\" style=\"width: 157px; color: #0000ff; text-align: left;\">\r\n");
//            sb.Append("         lblSex ");
//            sb.Append("    </td>\r\n");
//            sb.Append("    <td align=\"left\" style=\"width: 81px; height: 23px; text-align: right;\">出生日期：</td>\r\n");
//            sb.Append("    <td align=\"left\" style=\"width: 157px; color: #0000ff; text-align: left;\">\r\n");
//            sb.Append("        lblBirthDate ");
//            sb.Append("    </td>\r\n");
//            sb.Append("  </tr>\r\n");
//            sb.Append("  <tr>\r\n");
//            sb.Append("    <td align=\"left\" style=\"width: 87px; text-align: right;\">\r\n");
//            sb.Append("        科 &nbsp; &nbsp;&nbsp;室：</td>\r\n");
//            sb.Append("    <td align=\"left\" style=\"width: 157px; color: #0000ff; text-align: left;\">\r\n");
//            sb.Append("        lblLocation  ");
//            sb.Append("    </td>\r\n");
//            sb.Append("    <td align=\"left\" style=\"width: 83px; text-align: right;\">婚姻状况：</td>\r\n");
//            sb.Append("    <td align=\"left\" style=\"width: 157px; color: #0000ff; text-align: left;\">\r\n");
//            sb.Append("       lblLsMarriage ");
//            sb.Append("    </td>\r\n");
//            sb.Append("    <td align=\"left\" style=\"width: 81px; text-align: right;\">\r\n");
//            sb.Append("        职 &nbsp;&nbsp;&nbsp;&nbsp; 业：</td>\r\n");
//            sb.Append("    <td align=\"left\" style=\"width: 157px; color: #0000ff; text-align: left\">\r\n");
//            sb.Append("       lblOccupation");
//            sb.Append("    </td>\r\n");
//            sb.Append("  </tr>\r\n");
//            sb.Append("  <tr  >\r\n");
//            sb.Append("    <td class=\"dd\" align=\"left\" style=\"width: 87px; text-align: right;\">\r\n");
//            sb.Append("        地 &nbsp;&nbsp;&nbsp; 址：</td>\r\n");
//            sb.Append("    <td  class=\"dd\" align=\"left\" colspan=\"3\" style=\"width: 157px; color: #0000ff; text-align: left\">\r\n");
//            sb.Append("      lblAddress");
//            sb.Append("    </td>\r\n");
//            sb.Append("    <td  class=\"dd\" align=\"left\" style=\"width: 81px; text-align: right;\">就诊医生：</td>\r\n");
//            sb.Append("    <td  class=\"dd\" align=\"left\" style=\"width: 157px; color: #0000ff; text-align: left\">lblDoctor ");
//            sb.Append("    </td>\r\n");
//            sb.Append("  </tr>\r\n");
//            sb.Append("  <tr class=\"dd\">\r\n");
//            sb.Append("    <td class=\"dd\"  colspan=\"6\" align=\"left\" style=\"height: 25px\" ></td>\r\n");
//            sb.Append("  </tr>\r\n");
//            sb.Append("  <tr>\r\n");
//            sb.Append("    <td colspan=\"6\" align=\"left\" class=\"style2\"> CaseHisToryStringFormat </td>\r\n"); 
//            sb.Append("  </tr>\r\n");
//            sb.Append("  <tr>\r\n");
//            sb.Append("    <td colspan=\"6\" align=\"left\"><strong>诊断</strong></td>\r\n");
//            sb.Append("  </tr>\r\n");
//            sb.Append("  <tr>\r\n");
//            sb.Append("    <td colspan=\"6\" align=\"left\" class=\"style1\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; lblXML </td>\r\n");
//            sb.Append("  </tr>\r\n");
//            sb.Append("  <tr>\r\n");
//            sb.Append("    <td colspan=\"6\" align=\"left\"><strong>处理</strong></td>\r\n");
//            sb.Append("  </tr>\r\n");
//            sb.Append("  <tr>\r\n");
//            sb.Append("    <td colspan=\"6\" align=\"left\" style=\"height: 32px\">\r\n");
//            sb.Append("        lblDispose ");
//            sb.Append("    </td>\r\n");
//            sb.Append("  </tr>\r\n");

//            sb.Append("</table>\r\n");
//            sb.Append("<br />\r\n");
//            sb.Append(hrString);
//            sb.Append("<br />\r\n");
//            sb.Append("</div>\r\n");

//            return sb.ToString();
//        }
//        #endregion

//        #region 检验模板
//        public string getCkContentString()
//        {
//            StringBuilder returnSb = new StringBuilder();
//            returnSb.Append(" <div style=\"text-align:center\">\r\n");
//            returnSb.Append("    <table width=\"700\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" align=\"center\">\r\n");
//            returnSb.Append("  <tr>\r\n");
//            returnSb.Append("    <td colspan=\"10\" align=\"center\"><strong style=\"font-size: 16px; font-weight: bold;\">-某某医院-TlblTestType单</strong></td>\r\n");
//            returnSb.Append("  </tr>\r\n");
//            returnSb.Append("  <tr>\r\n");
//            returnSb.Append("    <td colspan=\"10\" align=\"center\"><strong>地址：茂名市油城五路7号&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;联系方式：2286245</strong></td>\r\n");
//            returnSb.Append("  </tr>\r\n");
//            returnSb.Append("  <tr>\r\n");
//            returnSb.Append("    <td align=\"right\">姓名：</td>\r\n");
//            returnSb.Append("    <td align=\"left\">\r\n");
//            returnSb.Append("        lblName &nbsp;</td>\r\n");
//            returnSb.Append("    <td align=\"right\">性别：</td>\r\n");
//            returnSb.Append("    <td align=\"left\"> lblSex  </td>\r\n");
//            returnSb.Append("    <td align=\"right\">年龄：</td>\r\n");
//            returnSb.Append("    <td align=\"left\"> lblBirthDate </td>\r\n");
//            returnSb.Append("    <td align=\"right\">诊疗卡：</td>\r\n");
//            returnSb.Append("    <td align=\"left\"> lblCardNo </td>\r\n");
//            returnSb.Append("    <td align=\"right\">标本类型：</td>\r\n");
//            returnSb.Append("    <td align=\"left\">\r\n");
//            returnSb.Append("        BlblTestType &nbsp;</td>\r\n");
//            returnSb.Append("  </tr>\r\n");
//            returnSb.Append("  <tr>\r\n");
//            returnSb.Append("    <td class=\"dd\" align=\"right\">\r\n");
//            returnSb.Append("        诊所：</td>\r\n");
//            returnSb.Append("    <td class=\"dd\" align=\"left\">\r\n");
//            returnSb.Append("        lblLocation &nbsp;</td>\r\n");
//            returnSb.Append("    <td class=\"dd\" align=\"right\">床号：</td>\r\n");
//            returnSb.Append("    <td class=\"dd\" align=\"left\">\r\n");
//            returnSb.Append("        lblBed &nbsp;</td>\r\n");
//            returnSb.Append("    <td class=\"dd\" align=\"right\">医生：</td>\r\n");
//            returnSb.Append("    <td class=\"dd\" align=\"left\">\r\n");
//            returnSb.Append("         lblDoctor &nbsp;</td>\r\n");
//            returnSb.Append("    <td class=\"dd\" align=\"right\">流水号：</td>\r\n");
//            returnSb.Append("    <td class=\"dd\" align=\"left\"> lblNo &nbsp; </td>\r\n");
//            returnSb.Append("    <td class=\"dd\" align=\"right\">标本编号：</td>\r\n");
//            returnSb.Append("    <td class=\"dd\" align=\"left\">\r\n");
//            returnSb.Append("        lblNum &nbsp;</td>\r\n");
//            returnSb.Append("  </tr>\r\n");
//            returnSb.Append("  <tr >\r\n");
//            returnSb.Append("    <td colspan=\"10\" style=\"height: 71px\" >\r\n");
//            returnSb.Append("    <table width=\"100%\" border=\"0\" cellspacing=\"0\" cellpadding=\"0\">\r\n");
//            returnSb.Append("  <tr>\r\n");
//            returnSb.Append("    <td align=\"left\" class=\"dd\" style=\"width: 136px\">&nbsp;<strong>检验项目</strong></td>\r\n");
//            returnSb.Append("    <td align=\"left\" class=\"dd\" style=\"width: 63px\">&nbsp;<strong>结果</strong></td>\r\n");
//            returnSb.Append("    <td align=\"left\" class=\"dd\" style=\"width: 50px\">&nbsp;<strong>单位</strong></td>\r\n");
//            returnSb.Append("    <td align=\"left\" class=\"dd\">&nbsp;<strong>参考值</strong></td>\r\n");
//            returnSb.Append("    <td align=\"left\" class=\"dd\" style=\"width: 136px\">&nbsp;<strong>检验项目</strong></td>\r\n");
//            returnSb.Append("    <td align=\"left\" class=\"dd\" style=\"width: 55px\">&nbsp;<strong>结果</strong></td>\r\n");
//            returnSb.Append("    <td align=\"left\" class=\"dd\" style=\"width: 50px\">&nbsp;<strong>单位</strong></td>\r\n");
//            returnSb.Append("    <td align=\"left\" class=\"dd\">&nbsp;<strong>参考值</strong></td>\r\n");
//            returnSb.Append("  </tr> \r\n");
//            returnSb.Append("   lblRow </table>\r\n");
//            returnSb.Append("\r\n");
//            returnSb.Append("	</td>\r\n");
//            returnSb.Append("  </tr>\r\n");
//            returnSb.Append("  \r\n");
//            returnSb.Append("  <tr>\r\n");
//            returnSb.Append("    <td colspan=\"10\" class=\"dd\">&nbsp;</td>\r\n");
//            returnSb.Append("  </tr>\r\n");
//            returnSb.Append("  <tr>\r\n");
//            returnSb.Append("    <td colspan=\"10\"><table width=\"100%\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\">\r\n");
//            returnSb.Append("  <tr>\r\n");
//            returnSb.Append("    <td width=\"8%\" align=\"left\">接收时间：</td>\r\n");
//            returnSb.Append("    <td width=\"14%\" align=\"left\"> lblRecieveTime </td>\r\n");
//            returnSb.Append("    <td width=\"8%\" align=\"left\">接收者：</td>\r\n");
//            returnSb.Append("    <td width=\"11%\" align=\"left\">\r\n");
//            returnSb.Append("        lblRecieveOper </td>\r\n");
//            returnSb.Append("    <td width=\"5%\">&nbsp;</td>\r\n");
//            returnSb.Append("    <td align=\"left\" width=\"8%\">测试时间：</td>\r\n");
//            returnSb.Append("    <td width=\"16%\" align=\"left\"> lblResultTime </td>\r\n");
//            returnSb.Append("    <td width=\"8%\" align=\"left\">测试者：</td>\r\n");
//            returnSb.Append("    <td width=\"14%\" align=\"left\">\r\n");
//            returnSb.Append("        &nbsp; lblResultOper </td>\r\n");
//            returnSb.Append("  </tr>\r\n");
//            returnSb.Append("  <tr>\r\n");
//            returnSb.Append("    <td align=\"left\">审核时间：</td>\r\n");
//            returnSb.Append("    <td align=\"left\">&nbsp; lblReportTime </td>\r\n");
//            returnSb.Append("    <td align=\"left\">审核者：</td>\r\n");
//            returnSb.Append("    <td align=\"left\">\r\n");
//            returnSb.Append("        lblReportOper &nbsp;</td>\r\n");
//            returnSb.Append("    <td>&nbsp;</td>\r\n");
//            returnSb.Append("    <td colspan=\"4\" align=\"left\">备注：升高(↑)，降低(↓)，危险(*)，阳性(+)，阴性(-)。</td>\r\n");
//            returnSb.Append("    </tr>\r\n");
//            returnSb.Append("  <tr>\r\n");
//            returnSb.Append("    <td colspan=\"9\" align=\"left\">此检测仅对采样负责，如果对结果有疑意，请在报告后3个工作日与我们联系。多谢合作！ </td>\r\n");
//            returnSb.Append("    </tr>\r\n");
//            returnSb.Append("</table>\r\n");
//            returnSb.Append("</td>\r\n");
//            returnSb.Append("  </tr>\r\n");
//            returnSb.Append("</table>\r\n");
//            returnSb.Append("\r\n");
//            returnSb.Append("   </div>\r\n");
//            returnSb.Append(hrString);

//            return returnSb.ToString();
//        }
//        #endregion

//        #region 报告模板
//        public string getPsContentString()
//        {
//            StringBuilder returnSb = new StringBuilder();
//            returnSb.Append("    <div style=\"text-align:center\"> \r\n");
//            returnSb.Append("   \r\n");
//            returnSb.Append("  <table width=\"700\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" align=\"center\">\r\n");
//            returnSb.Append("  <tr>\r\n");
//            returnSb.Append("    <td colspan=\"10\" align=\"center\"><strong style=\"font-size: 16px; font-weight: bold;\">-某某医院-影像报告单</strong></td>\r\n");
//            returnSb.Append("  </tr>\r\n");
//            returnSb.Append("  <tr>\r\n");
//            returnSb.Append("    <td colspan=\"10\" align=\"center\">&nbsp;</td>\r\n");
//            returnSb.Append("  </tr>\r\n");
//            returnSb.Append("  <tr>\r\n");
//            returnSb.Append("    <td align=\"right\">姓名：</td>\r\n");
//            returnSb.Append("    <td align=\"left\">\r\n");
//            returnSb.Append("        lblName &nbsp;</td>\r\n");
//            returnSb.Append("    <td align=\"right\">性别：</td>\r\n");
//            returnSb.Append("    <td align=\"left\"> lblSex </td>\r\n");
//            returnSb.Append("    <td align=\"right\">年龄：</td>\r\n");
//            returnSb.Append("    <td align=\"left\"> lblBirthDate </td>\r\n");
//            returnSb.Append("    <td align=\"right\">诊疗卡：</td>\r\n");
//            returnSb.Append("    <td align=\"left\"> lblCardNo </td>\r\n");
//            returnSb.Append("    <td align=\"right\">申请类别：</td>\r\n");
//            returnSb.Append("    <td align=\"left\">\r\n");
//            returnSb.Append("        lblTestType &nbsp;</td>\r\n");
//            returnSb.Append("  </tr>\r\n");
//            returnSb.Append("  <tr>\r\n");
//            returnSb.Append("    <td class=\"dd\" align=\"right\">\r\n");
//            returnSb.Append("        诊所：</td>\r\n");
//            returnSb.Append("    <td class=\"dd\" align=\"left\">\r\n");
//            returnSb.Append("       lblLocation &nbsp;</td>\r\n");
//            returnSb.Append("    <td class=\"dd\" align=\"right\">住院号：</td>\r\n");
//            returnSb.Append("    <td class=\"dd\" align=\"left\">\r\n");
//            returnSb.Append("         lblBed &nbsp;</td>\r\n");
//            returnSb.Append("    <td class=\"dd\" align=\"right\">医生：</td>\r\n");
//            returnSb.Append("    <td class=\"dd\" align=\"left\">\r\n");
//            returnSb.Append("        lblDoctor &nbsp;</td>\r\n");
//            returnSb.Append("    <td class=\"dd\" align=\"right\">流水号：</td>\r\n");
//            returnSb.Append("    <td class=\"dd\" align=\"left\"> lblNo &nbsp; </td>\r\n");
//            returnSb.Append("    <td class=\"dd\" align=\"right\">申请单号：</td>\r\n");
//            returnSb.Append("    <td class=\"dd\" align=\"left\">\r\n");
//            returnSb.Append("       lblApplyNo &nbsp;</td>\r\n");
//            returnSb.Append("  </tr>\r\n");
//            returnSb.Append("  <tr >\r\n");
//            returnSb.Append("    <td colspan=\"10\" class=\"dd\" style=\"height: 71px\" align=\"left\" ><table width=\"100%\" border=\"0\" cellspacing=\"0\" cellpadding=\"0\">\r\n");
//            returnSb.Append("      <tr>\r\n");
//            returnSb.Append("        <td width=\"11%\" align=\"right\"><strong>检查部位：</strong></td>\r\n");
//            returnSb.Append("        <td width=\"77%\" align=\"left\">&nbsp;</td>\r\n");
//            returnSb.Append("        <td width=\"12%\">&nbsp;</td>\r\n");
//            returnSb.Append("      </tr>\r\n");
//            returnSb.Append("      <tr>\r\n");
//            returnSb.Append("        <td align=\"right\">&nbsp;</td>\r\n");
//            returnSb.Append("        <td align=\"left\">&nbsp; lblCheckBody </td>\r\n");
//            returnSb.Append("        <td>&nbsp;</td>\r\n");
//            returnSb.Append("      </tr>\r\n");
//            returnSb.Append("      <tr>\r\n");
//            returnSb.Append("        <td align=\"right\"><strong>检查参数：</strong></td>\r\n");
//            returnSb.Append("        <td align=\"left\">&nbsp;</td>\r\n");
//            returnSb.Append("        <td>&nbsp;</td>\r\n");
//            returnSb.Append("      </tr>\r\n");
//            returnSb.Append("      <tr>\r\n");
//            returnSb.Append("        <td align=\"right\" style=\"height: 23px\">&nbsp;</td>\r\n");
//            returnSb.Append("        <td align=\"left\" style=\"height: 23px\">&nbsp; lblCheckParm </td>\r\n");
//            returnSb.Append("        <td style=\"height: 23px\">&nbsp;</td>\r\n");
//            returnSb.Append("      </tr>\r\n");
//            returnSb.Append("      <tr>\r\n");
//            returnSb.Append("        <td align=\"right\"><strong>检查描述：</strong></td>\r\n");
//            returnSb.Append("        <td align=\"left\">&nbsp;</td>\r\n");
//            returnSb.Append("        <td>&nbsp;</td>\r\n");
//            returnSb.Append("      </tr>\r\n");
//            returnSb.Append("      <tr>\r\n");
//            returnSb.Append("        <td align=\"right\">&nbsp;</td>\r\n");
//            returnSb.Append("        <td align=\"left\">&nbsp; lblCheckDesc </td>\r\n");
//            returnSb.Append("        <td>&nbsp;</td>\r\n");
//            returnSb.Append("      </tr>\r\n");
//            returnSb.Append("      <tr>\r\n");
//            returnSb.Append("        <td align=\"right\"><strong>检查结果：</strong></td>\r\n");
//            returnSb.Append("        <td align=\"left\">&nbsp;</td>\r\n");
//            returnSb.Append("        <td>&nbsp;</td>\r\n");
//            returnSb.Append("      </tr>\r\n");
//            returnSb.Append("      <tr>\r\n");
//            returnSb.Append("        <td align=\"right\">&nbsp;</td>\r\n");
//            returnSb.Append("        <td align=\"left\">&nbsp; lblCheckResult </td>\r\n");
//            returnSb.Append("        <td>&nbsp;</td>\r\n");
//            returnSb.Append("      </tr>\r\n");
//            returnSb.Append("      <tr>\r\n");
//            returnSb.Append("        <td align=\"right\"><strong>检查建议：</strong></td>\r\n");
//            returnSb.Append("        <td align=\"left\">&nbsp;</td>\r\n");
//            returnSb.Append("        <td>&nbsp;</td>\r\n");
//            returnSb.Append("      </tr>\r\n");
//            returnSb.Append("      <tr>\r\n");
//            returnSb.Append("        <td align=\"right\">&nbsp;</td>\r\n");
//            returnSb.Append("        <td align=\"left\">&nbsp; lblCheckAdvice </td>\r\n");
//            returnSb.Append("        <td>&nbsp;</td>\r\n");
//            returnSb.Append("      </tr>\r\n");
//            returnSb.Append("      <tr>\r\n");
//            returnSb.Append("        <td align=\"right\" style=\"height: 23px\"></td>\r\n");
//            returnSb.Append("        <td align=\"left\" style=\"height: 23px\">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;\r\n");
//            returnSb.Append("        </td>\r\n");
//            returnSb.Append("        <td style=\"height: 23px\">&nbsp;</td>\r\n");
//            returnSb.Append("      </tr>\r\n");
//            returnSb.Append("    </table>阳性结果: lblIsAbNormal \r\n");
//            returnSb.Append("        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;\r\n");
//            returnSb.Append("        &nbsp; &nbsp; &nbsp;检查仪器 lblEquipment </td>\r\n");
//            returnSb.Append("  </tr>\r\n");
//            returnSb.Append("   \r\n");
//            returnSb.Append("  <tr>\r\n");
//            returnSb.Append("    <td colspan=\"10\"  ><table width=\"100%\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\">\r\n");
//            returnSb.Append("  <tr>\r\n");
//            returnSb.Append("    <td width=\"8%\" align=\"left\">申请时间：</td>\r\n");
//            returnSb.Append("    <td width=\"13%\" align=\"left\"> lblOperTime </td>\r\n");
//            returnSb.Append("    <td width=\"8%\" align=\"left\">申请人：</td>\r\n");
//            returnSb.Append("    <td width=\"8%\" align=\"left\"> lblOper </td>\r\n");
//            returnSb.Append("    <td width=\"8%\" align=\"left\">申请诊所：</td>\r\n");
//            returnSb.Append("    <td width=\"12%\" align=\"left\" style=\"width: 8%\"> TblLocations </td>\r\n");
//            returnSb.Append("    <td width=\"9%\" align=\"left\">执行诊所：</td>\r\n");
//            returnSb.Append("    <td width=\"11%\" align=\"left\"> lblExecLoc </td>\r\n");
//            returnSb.Append("    </tr>\r\n");
//            returnSb.Append("  <tr>\r\n");
//            returnSb.Append("    <td align=\"left\">检查时间：</td>\r\n");
//            returnSb.Append("    <td align=\"left\"> lblCheckTime </td>\r\n");
//            returnSb.Append("    <td align=\"left\">检查人：</td>\r\n");
//            returnSb.Append("    <td align=\"left\"> lblCheckOper </td>\r\n");
//            returnSb.Append("    <td align=\"left\">审核时间：</td>\r\n");
//            returnSb.Append("    <td align=\"left\"> lblReportTime </td>\r\n");
//            returnSb.Append("    <td align=\"left\">审核人：</td>\r\n");
//            returnSb.Append("    <td align=\"left\"> lblReportOper </td>\r\n");
//            returnSb.Append("    </tr>\r\n");
//            returnSb.Append("  <tr>\r\n");
//            returnSb.Append("    <td colspan=\"8\" align=\"left\">申请备注 lblApplyMemo </td>\r\n");
//            returnSb.Append("    </tr>\r\n");
//            returnSb.Append("</table>\r\n");
//            returnSb.Append("        </td>\r\n");
//            returnSb.Append("  </tr>\r\n");
//            returnSb.Append("</table> \r\n");
//            returnSb.Append("  \r\n");
//            returnSb.Append("</div>\r\n");
//            return returnSb.ToString();
//        }
//        #endregion
 
//        /// <summary>
//        /// 格式化日期
//        /// </summary>
//        /// <param name="dtime">日期</param>
//        /// <param name="type">1-年月日 点，2-年月日，3 dddd/mm/dd</param>
//        /// <returns>格式化后字符串</returns>
//        public string FormatTime(DateTime dtime, int type)
//        {
//            if (dtime == null || dtime == DateTime.MinValue)
//                return "";
//            if (type == 1) return string.Format("{0}年{1}月{2}日 {3}点", dtime.Year, dtime.Month, dtime.Day, dtime.Hour);
//            if (type == 2) return string.Format("{0}年{1}月{2}日", dtime.Year, dtime.Month, dtime.Day);
//            if (type == 3) return string.Format("{0}", dtime.Date.ToString().Substring(0, dtime.Date.ToString().LastIndexOf("0:00:00")));

//            return "";
//        }

//        #region 字符串处理辅助方法
//        #region 替换字符串中的字符串
//        /// <summary>
//        /// 替换字符串中的字符串
//        /// </summary>
//        /// <param name="str">字符串</param>
//        /// <param name="findPattern">用于查找的字符串</param>
//        /// <param name="replacedBy">用于替换的字符串</param>
//        /// <returns>替换后的字符串</returns>
//        public static string StrReplace(string str, string findPattern, string replacedBy)
//        {
//            string result = string.Empty;
//            string inputText = string.Empty;
//            string replacement = replacedBy.Trim()== "" ? "　" : replacedBy;
//            string pat = findPattern;
//            Regex r = new Regex(pat, RegexOptions.IgnoreCase);

//            if (str.Contains(findPattern))
//            {
//                try
//                {
//                    inputText = str;
//                    if (r.IsMatch(inputText))
//                    {
//                        result = r.Replace(inputText, replacement);
//                    }
//                }
//                catch (Exception e)
//                {
//                    throw (e);
//                }
//            }
//            return result;
//        }
//        #endregion

//        #region SplitString

//        //检查在字符串str里有‘.’的时候，'.'前面是否有字符a
//        private bool CheckString(string str, string a)
//        {
//            bool c1 = false;
//            if (str.Contains("."))
//            {
//                if (str.StartsWith("r"))
//                {
//                    return c1;
//                }
//                string[] str1 = str.Split('.');
//                if (str1[0].Contains(a))
//                {
//                    c1 = true;
//                }
//            }
//            return c1;

//        }

//        //对选择节点做出处理
//        private void SelectDeal(string c, string d)
//        {
//            if (d.Trim()!= "")
//            {
//                string[] b;
//                b = SplitString(c, "_.");
//                int g = int.Parse(d.Trim());
//                if (c.StartsWith("Q"))
//                {
//                    stringBuilder.Append(b[g].ToString() + b[0].ToString().Substring(2).ToString());
//                }
//                else if (c.StartsWith("W"))
//                {
//                    stringBuilder.Append(b[0].ToString().Substring(2).ToString() + b[g].ToString());
//                }
//                else
//                {
//                    stringBuilder.Append(b[0].ToString().Substring(1).ToString() + ":" + b[g].ToString());
//                }

//            }
//        }

//        #region SplitString
//        /// <summary>
//        /// 用str2将str1分割，返回分割后的字符数组
//        /// </summary>
//        /// <param name="str1">待分割的字符</param>
//        /// <param name="str2">按此字符进行分割</param>
//        /// <returns></returns>
//        private string[] SplitString(string str1, string str2)
//        {
//            str1 = str1.Replace(str2, "⊙");
//            return str1.Split('⊙');
//        }
//        #endregion

//        //是否为有要输入中间值的节点_
//        private void MiddleDeal(string c, string d)
//        {
//            string[] b;
//            if (c.Contains("r"))
//            {
//                c = c.Substring(3);
//                stringBuilder.Append(" " + d + " " + c);
//            }
//            else
//            {
//                b = c.Split('_');
//                stringBuilder.Append(b[0].Substring(1).ToString() + " " + d + " " + b[1].ToString());
//            }
//        }

//        //基本数据处理，主要处理多选框为f
//        private void BasicDeal(string c, string d)
//        {
//            if (CheckString(c, "V"))
//            {
//                //if (stringBuilder.ToString().Substring(stringBuilder.Length - 5).Trim() != "<br/>")
//                //    stringBuilder.Append(@"<br/>");
//                stringBuilder.Append(string.Format(documentTopRtf5, c.Substring(c.LastIndexOf('.') + 1)));

//                stringBuilder.Append(d + "<br/>");
//            }
//            else
//            {
//                if (c.StartsWith("Q"))
//                {
//                    stringBuilder.Append(d + c.Substring(startTitlePosition).ToString());
//                }
//                else if (c.StartsWith("W"))
//                {
//                    stringBuilder.Append(c.Substring(startTitlePosition).ToString() + d);
//                }
//                else
//                {
//                    stringBuilder.Append(c.Substring(c.IndexOf(".") + 1).ToString() + ": " + d);
//                }
//            }

//        }

//        //处理有多个选择的项 的数据。只处理为TRUE的情况（多选框）
//        private void MultiDeal(string c)
//        {
//            if (CheckString(c, "d"))
//            {
//                if (c.Substring(c.IndexOf(".") + 1).ToString().Length < 2 || c.Substring(c.IndexOf(".") + 1).ToString().Contains("是否"))
//                {
//                    stringBuilder.Append(c.Substring(c.IndexOf(".") + 1).ToString() + "、");
//                }
//            }
//            else if (CheckString(c, "Y"))
//            {
//                stringBuilder.Append(c.Substring(c.IndexOf(".") + 1).ToString() + "  ");
//            }
//        }

//        private void VarCharDeal(string c, string d)
//        {
//            //检查是否为选择按钮（单选框）
//            if (c.Contains("_."))
//            {
//                SelectDeal(c, d);
//            }
//            //时间_年
//            //检查是否有要输入的数据
//            else if (c.Contains("_"))
//            {
//                MiddleDeal(c, d);
//            }
//            else if (d.Trim() == "true")
//            {
//                MultiDeal(c);
//            }
//            else
//            {
//                BasicDeal(c, d);
//            }
//        }

//        int startTitlePosition = 2;
//        private void ExecuteDeal(string c, string d)
//        {
//            startTitlePosition = 2;
//            if (c.Contains(".._"))
//            {
//                c = c.Replace(".._", "℃");
//            }
//            if (c.Contains("._"))//检查是否有符号._，如果有的转化为字符‘/’
//            {
//                c = c.Replace("._", "/");
//            }
//            if (c.Contains("-.."))
//            {
//                c = c.Replace("-..", "(");
//            }
//            if (c.Contains("-."))
//            {
//                c = c.Replace("-.", ")");
//            }
//            if (c.Contains("-_"))//检查是否有符号-_，如果有的转化为字符‘±’Ⅰº
//            {
//                c = c.Replace("-_", "±");
//            }
//            if (c.Contains("_-"))//检查是否有符号_-，如果有的转化为字符‘º’
//            {
//                c = c.Replace("_-", "º");
//                //c = removeRepeat(c, '7', 'º');
//            }
//            if (CheckString(c, "k"))//查看是否前面有要换行的标志
//            {
//                if (stringBuilder[stringBuilder.Length - 1] == ',')
//                {
//                    stringBuilder.Remove((stringBuilder.Length - 1), 1);
//                }
//                int i = c.IndexOf("k");
//                string nextKchar = c.Substring(i + 1);
//                if ((Convert.ToChar(nextKchar.Substring(0, 1))) >= '0' && (Convert.ToChar(nextKchar.Substring(0, 1))) <= '9' && !nextKchar.StartsWith("."))
//                {
//                    startTitlePosition = 4;
//                    if (stringBuilder.ToString().Substring(stringBuilder.Length - 5).Trim() != "<br/>")
//                        stringBuilder.Append(@"<br/>");

//                    int tabTimes = Convert.ToInt32(nextKchar.Substring(0, 1));
//                    for (int j = 0; j < tabTimes; j++)
//                    {
//                        stringBuilder.Append("       ");
//                    }
//                }
//                else
//                {
//                    if (c.Substring(c.IndexOf(".") + 1).ToString().Length < 2 || !c.Contains("是否"))
//                    {
//                        if (stringBuilder.ToString().Substring(stringBuilder.Length - 5).Trim() != "<br/>")
//                            stringBuilder.Append(@"<br/>" + "       ");
//                    }
//                }
//                c = c.Substring(c.IndexOf("k") + 1);
//            }
//            if (CheckString(c, "l"))//查看是否有接逗号的标志
//            {
//                c = c.Substring(c.IndexOf("l") + 1);
//                VarCharDeal(c, d);
//                if ((CheckString(c, "Y") && d.Trim() == "true") || (d.Trim() != "true" && !(CheckString(c, "d") && d.Trim() == "false")))
//                {
//                    if (!(d.Trim() == "false" && CheckString(c, "Y")))
//                    {
//                        stringBuilder.Append(",");
//                    }
//                }
//            }
//            else if (CheckString(c, "j"))// 查看是否有接句号（。）的标志
//            {
//                c = c.Substring(c.IndexOf("j") + 1);
//                VarCharDeal(c, d);

//                if ((CheckString(c, "Y") && d.Trim() == "true") || (d.Trim() != "true" && !(CheckString(c, "d") && d.Trim() == "false")))
//                {
//                    if (!(d.Trim() == "false" && CheckString(c, "Y")))
//                    {
//                        stringBuilder.Append("。");
//                    }
//                }
//            }
//            else if (CheckString(c, "g"))// 查看是否有接‘；’的标志
//            {
//                if (stringBuilder.ToString().Substring(stringBuilder.Length - 5).Trim() == "<br/>")
//                    stringBuilder.Remove(stringBuilder.ToString().Length - 5, 5);
//                c = c.Substring(c.IndexOf("g") + 1);
//                VarCharDeal(c, d);
//                if ((CheckString(c, "Y") && d.Trim() == "true") || (d.Trim() != "true" && !(CheckString(c, "d") && d.Trim() == "false")))
//                {
//                    if (!(d.Trim() == "false" && CheckString(c, "Y")))
//                    {
//                        stringBuilder.Append("；");
//                    }
//                }
//            }
//            else if (CheckString(c, "f"))// 查看是否有接‘=’的标志
//            {
//                c = c.Substring(c.IndexOf("f") + 1);
//                VarCharDeal(c, d);

//                if ((CheckString(c, "Y") && d.Trim() == "true") || (d.Trim() != "true" && !(CheckString(c, "d") && d.Trim() == "false")))
//                {
//                    if (!(d.Trim() == "false" && CheckString(c, "Y")))
//                    {
//                        stringBuilder.Append(" = ");
//                    }
//                }
//            }
//            else if (CheckString(c, "a")) // 查看是否有接‘-’的标志
//            {
//                c = c.Substring(c.IndexOf("a") + 1);
//                VarCharDeal(c, d);

//                if ((CheckString(c, "Y") && d.Trim() == "true") || (d.Trim() != "true" && !(CheckString(c, "d") && d.Trim() == "false")))
//                {
//                    if (!(d.Trim() == "false" && CheckString(c, "Y")))
//                    {
//                        stringBuilder.Append(" - ");
//                    }
//                }
//            }
//            else if (CheckString(c, "s")) // 查看是否有接‘+’的标志
//            {
//                c = c.Substring(c.IndexOf("s") + 1);
//                VarCharDeal(c, d);

//                if ((CheckString(c, "Y") && d.Trim() == "true") || (d.Trim() != "true" && !(CheckString(c, "Y") && d.Trim() == "false")))
//                {
//                    if (!(d.Trim() == "false" && CheckString(c, "Y")))
//                    {
//                        stringBuilder.Append(" + ");
//                    }
//                }
//            }
//            else//什么都不接的情况下。
//            {
//                VarCharDeal(c, d);
//            }

//        }

//        private string removeRepeat(string c, char removeChar, char newChar)
//        {
//            if (c.IndexOf(removeChar.ToString() + removeChar.ToString()) > 0)
//            {
//                for (int i = 0; i < c.Length - 1; i++)
//                {
//                    if (c[i] == removeChar && c[i + 1] == removeChar)
//                    {
//                        c = c.Remove((i), 1);
//                    }
//                }
//            }
//            else
//            {
//                c = c.Replace(removeChar, newChar);
//            }
//            return c;

//        }
//        #endregion
//        #endregion
   }
 }
