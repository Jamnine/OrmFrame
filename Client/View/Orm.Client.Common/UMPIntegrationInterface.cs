using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Xml;
using System.Xml.Serialization;
using Orm.Config;
using Orm.Framework.Services;
using Orm.Framework.Services.Utility;
using Orm.Model;
using Orm.Model.EnumDefine;
using Orm.Model.InterFace;
using Orm.Model.Parameter;

namespace Orm.Client.Common
{
    /// <summary>
    /// 药品对接项目集成平台接口调用
    /// </summary>
    public class UMPIntegrationInterface
    {
        #region 变量
        public static string strURL = "http://183.60.189.46:8060/platformByHis";
        public static string flag = "5400";
        public static string method = "";
        public static string strToken = "his9aa1_3db6303565bc";
        public static JavaScriptSerializer jsSerializer = new JavaScriptSerializer();
        #endregion

        #region 接口服务器Model参数常亮
        //集成平台model对应的值
        public static string ShopStocks = "StocksModels";
        public static string AddBigOrders = "BigOrderModels";
        public static string ReturnGoods = "ReturnModels";
        public static string invalidOrders = "ReturnModels";
        public static string GetDeptListByHospital = "hospitalModels";
        public static string AddHospital = "HospitalModel";
        public static string GetGoodsWithHis = "GoodsInModels";
        public static string GetDeptList = "GenericModels";
        #endregion

        #region 构造josn参数数据
        public static string SetParametersJson(IDictionary<string, string> parameters, DataMain data_main)
        {
            string Data_Json = "";
            JavaScriptSerializer jsSerializer = new JavaScriptSerializer();
            System.Text.StringBuilder data_mainJson = new System.Text.StringBuilder();
            jsSerializer.Serialize(data_main, data_mainJson);
            string dataDetail = data_mainJson.ToString();
            parameters.Add("data", dataDetail);

            System.Text.StringBuilder data_Json = new System.Text.StringBuilder();
            jsSerializer.Serialize(parameters, data_Json);
            return Data_Json = data_Json.ToString();
        }
        #endregion

        #region 库存查询接口ShopStocks
        /// <summary>
        /// 根据单个商品编码和药店编码查询库存是否足够
        /// </summary>
        /// <param name="LsRepType">处方类型</param>
        /// <param name="code">编码</param>
        /// <param name="RecipeDtlTotality">数量</param>
        /// <param name="ShopCode">药店编码</param>
        /// <returns></returns>
        public static bool ShopStocksSingle(int LsRepType, string code, double RecipeDtlTotality, string ShopCode)
        {
            if (Service.DBClientService.GetModelByID<BsHospital>(UserProfiles.HospitalID).IsInterface)
            {
                flag = "5400";
                string shop_code = ShopCode;
                if (LsRepType == (int)EnumRecipeType.生鲜)//生鲜项目
                {
                    flag = "5602";
                    code = code.Substring(2);
                }
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(strURL);
                //参数 
                IDictionary<string, string> parameters = new Dictionary<string, string>();
                string timestamp, token;
                SetBaseInterfcaeParameters(out timestamp, out token);
                parameters.Add("method", nameof(ShopStocks));
                parameters.Add("flag", flag);
                parameters.Add("model", ShopStocks);
                DataMain data_main = new DataMain()
                {
                    shop_code = shop_code,
                    goods_code = code,
                    timestamp = timestamp,
                    token = token
                };
                string Data_Json = SetParametersJson(parameters, data_main);
                string jsonString = HttpRequestHelper.PostPage(strURL, Data_Json);
                ShopStock returnData = jsSerializer.Deserialize<ShopStock>(jsonString);

                double stocks = 0;
                if (returnData.data == null)
                {
                    //Orm.Client.Base.FrmMessageRemind.Show("没有查询到该项目库存，请更换药品或者手动删除项目");
                    return false;
                }
                else if (returnData.data.Count > 0)
                {
                    stocks = double.Parse(returnData.data[0].stocks);
                    if (RecipeDtlTotality > stocks)
                    {
                        if (LsRepType == (int)EnumOuRecipeLsRepType.中药)
                        {
                            //Orm.Client.Base.FrmMessageBox.ShowDialog(string.Format("【{0}】处方总数【{1}】库存剩余数【{2}】，该项目库存不足，请更换药品或者手动更改数量", returnData.data[0].name, RecipeDtlTotality * 10, stocks * 10), "系统提示");
                        }
                        else
                        {
                            //Client.Base.FrmMessageBox.ShowDialog(string.Format("【{0}】处方总数【{1}】库存剩余数【{2}】，该项目库存不足，请更换药品或者手动更改数量", returnData.data[0].name, RecipeDtlTotality, stocks), "系统提示");
                        }
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    //Orm.Client.Base.FrmMessageBox.ShowDialog(string.Format("没有查询到该项目库存，请更换药品或者手动删除项目"), "系统提示");
                    return false;
                }
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// 通过webservice接口获取药品的库存
        /// </summary>
        public static List<SeverStock> GetStore(string BillNo)
        {
            String No = BillNo;
            // String No = "JZ20190121000331";
            string content = string.Empty;

            string strURL = "http://oa.succhi.com:10050/newwebservice.asmx/Get_连锁配送清单?No=" + No + "";

            HttpWebRequest request = (System.Net.HttpWebRequest)WebRequest.Create(strURL);
            request.Method = "GET";
            request.ContentType = "text/html;charset=UTF-8";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream myResponseStream = response.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.UTF8);
            string retString = myStreamReader.ReadToEnd();
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(retString);
            string jsonText = JsonConvert.SerializeXmlNode(doc);
            List<SeverStock> SeverStocklist = JsonDatatText(jsonText);
            myStreamReader.Close();
            myResponseStream.Close();
            return SeverStocklist;
        }
      
    


        /// <summary>   
        /// XML转化为Model的方法   
        /// </summary>   
        /// <param name="xml">要转化的XML</param>   
        /// <param name="SampleModel">Model的实体示例，New一个出来即可</param>   
        /// <returns></returns>     
        public static object XMLToModel(string xml, object SampleModel)
        {
            if (string.IsNullOrEmpty(xml))
                return SampleModel;
            else
            {
                XmlDocument xmldoc = new XmlDocument();
                xmldoc.LoadXml(xml);

                XmlNodeList attributes = xmldoc.SelectSingleNode("/NewDataSet/Table").ChildNodes;
                foreach (XmlNode node in attributes)
                {
                    foreach (PropertyInfo property in SampleModel.GetType().GetProperties())
                    {
                        if (node.Name == property.Name)
                        {
                            if (node.InnerText != "")
                            {
                                if (property.PropertyType == typeof(System.Guid))
                                    property.SetValue(SampleModel, new Guid(node.InnerText), null);
                                else
                                    property.SetValue(SampleModel, Convert.ChangeType(node.InnerText, property.PropertyType), null);
                            }
                            else
                                property.SetValue(SampleModel, null, null);
                        }
                    }
                }
                return SampleModel;
            }
        }


        public static object Deserialize(Type type, string xml)
        {
            try
            {
                using (StringReader sr = new StringReader(xml))
                {
                    XmlSerializer xmldes = new XmlSerializer(type);
                    return xmldes.Deserialize(sr);
                }
            }
            catch (Exception e)
            {

                return null;
            }
        }

        /// <summary>
        /// 获取药店所有药品库存
        /// </summary>
        /// <param name="ShopCode">药店编码</param>
        /// <param name="LsRepType">处方类型</param>
        /// <returns></returns>
        public static ShopStock GetAllShopStocks(string ShopCode, int LsRepType)
        {
            SetFlagValue(LsRepType);
            string shop_code = ShopCode;
            HttpWebRequest request = (System.Net.HttpWebRequest)WebRequest.Create(strURL);
            //参数 
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            string timestamp, token;
            SetBaseInterfcaeParameters(out timestamp, out token);
            parameters.Add("method", nameof(ShopStocks));
            parameters.Add("flag", flag);
            parameters.Add("model", ShopStocks);
            DataMain data_main = new DataMain()
            {
                shop_code = shop_code,
                goods_code = "",
                timestamp = timestamp,
                token = token
            };
            string Data_Json = SetParametersJson(parameters, data_main);
            string jsonString = HttpRequestHelper.PostPage(strURL, Data_Json);
            ShopStock returnData = jsSerializer.Deserialize<ShopStock>(jsonString);
            return returnData;
        }

        private static void SetBaseInterfcaeParameters(out string timestamp, out string token)
        {
            timestamp = HttpRequestHelper.GetTimeStamp(Orm.Config.Service.DBClientService.GetServerTime());
            string md5 = MD5Helper.GetStringByMd5(timestamp);
            token = MD5Helper.GetStringByMd5(md5 + strToken);
        }

        private static void SetFlagValue(int LsRepType)
        {
            if (LsRepType == (int)EnumRecipeType.生鲜 || LsRepType == (int)EnumPharmacyType.生鲜药房)//生鲜项目
            {
                flag = "5602";
            }
            else
            {
                flag = "5400";
            }
        }
        #endregion

        #region 退药接口 invalidOrders ReturnGoods
        public static JsonToAbject ReturnGoodsInterface(string orderId, int type)
        {
            SetFlagValue(type);
            System.Net.HttpWebRequest request = (System.Net.HttpWebRequest)WebRequest.Create(strURL);
            //参数 
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            string timestamp, token;
            SetBaseInterfcaeParameters(out timestamp, out token);
            parameters.Add("method", nameof(invalidOrders));
            parameters.Add("flag", flag);
            parameters.Add("model", invalidOrders);
            DataMain data_main = new DataMain()
            {
                order_id = orderId,
                token = token,
                timestamp = timestamp,
            };
            string Data_Json = SetParametersJson(parameters, data_main);
            string jsonString = HttpRequestHelper.PostPage(strURL, Data_Json);
            JsonToAbject jsonToAbject = HttpRequestHelper.JsonToObject<JsonToAbject>(jsonString);
            return jsonToAbject;
        }
        #endregion

        #region 结算接口 AddBigOrders
        public static string AddBigOrdersInterface(PMSaveBalanceInfo balanceInfo, int LsRepType)
        {
            string shop_code = string.Empty;
            string jsonString = string.Empty;
            if (balanceInfo.OuInvoice != null && balanceInfo.OuInvoiceDtlList != null)
            {
                foreach (var item in balanceInfo.ouRecipeList)
                {
                    if (LsRepType == 17)
                    {
                        if (item.LsRepType == 17)
                        {
                            shop_code = item.DeptNo;
                        }
                    }
                    else
                    {
                        if (item.LsRepType != 17)
                        {
                            shop_code = item.DeptNo;
                        }
                    }
                }
                if (shop_code == string.Empty)
                {
                    return "NONE";
                }
                List<data_detail> detailList = new List<data_detail>();
                double ypprice = 0;
                double sxprice = 0;
                foreach (OuInvoiceDtl ouInvoiceDtl in balanceInfo.OuInvoiceDtlList)
                {
                    if (LsRepType == (int)EnumRecipeType.生鲜)//生鲜项目
                    {
                        if (ouInvoiceDtl.FeeId == Config.DBClientBaseInRedis.GetList<BsMzFeety>("Name=@0", "生鲜").FirstOrDefault().GUID)
                        {
                            data_detail data_detail = new data_detail
                            {
                                goods_code = Config.DBClientBaseInRedis.GetModelByGuid<BsItem>(ouInvoiceDtl.ItemId).Code.Substring(2),
                                qty = ouInvoiceDtl.Totality,
                                price = ouInvoiceDtl.Price,
                                subtotal = ouInvoiceDtl.Amount,
                                memo = ouInvoiceDtl.Memo
                            };
                            sxprice += data_detail.price * data_detail.qty;
                            detailList.Add(data_detail);
                        }
                    }
                    if (LsRepType == (int)EnumRecipeType.西药)
                    {
                        if (ouInvoiceDtl.FeeId == Config.DBClientBaseInRedis.GetList<BsMzFeety>("Name=@0", "西药/中成药").FirstOrDefault().GUID)
                        {
                            data_detail data_detail = new data_detail
                            {
                                goods_code = Config.DBClientBaseInRedis.GetModelByGuid<BsItem>(ouInvoiceDtl.ItemId).Code,
                                qty = ouInvoiceDtl.Totality,
                                price = ouInvoiceDtl.Price,
                                subtotal = ouInvoiceDtl.Amount,
                                memo = ouInvoiceDtl.Memo
                            };
                            ypprice += data_detail.price * data_detail.qty;
                            detailList.Add(data_detail);
                        }
                        if (ouInvoiceDtl.FeeId == Config.DBClientBaseInRedis.GetList<BsMzFeety>("Name=@0", "中药").FirstOrDefault().GUID)
                        {
                            BsItem bsItems = Config.DBClientBaseInRedis.GetModelByGuid<BsItem>(ouInvoiceDtl.ItemId);
                            //Orm.Config.Common.UtilsLocCache.GetCache<BsItem>(t => t.ID == ouInvoiceDtl.ItemId && t.LocationId== UserProfiles.LocationID);
                            data_detail data_detail = new data_detail
                            {
                                goods_code = bsItems.Code,
                                qty = ouInvoiceDtl.Totality/ (bsItems.PharmacyRatio == 0 ? 10 : bsItems.PharmacyRatio),
                                price = Math.Round(ouInvoiceDtl.Price * (bsItems.PharmacyRatio == 0 ? 10 : bsItems.PharmacyRatio), 2),
                                subtotal = Math.Round(ouInvoiceDtl.Amount, 2),
                                memo = ouInvoiceDtl.Memo
                            };
                            ypprice += data_detail.price * data_detail.qty;
                            detailList.Add(data_detail);
                        }
                    }
                }
                if (detailList.Count == 0)
                {
                    return "NONE";
                }

                string strPayWay = string.Empty;
                if (balanceInfo.OuInvoicePayList != null && balanceInfo.OuInvoicePayList.Count > 0)
                {
                    for (int i = 0; i < balanceInfo.OuInvoicePayList.Count; i++)
                    {
                        if (i == 0)
                        {
                            strPayWay = strPayWay + string.Format("{0}", balanceInfo.OuInvoicePayList[i].PayWayName);
                        }
                        else
                        {
                            strPayWay = strPayWay + string.Format("/{0}", balanceInfo.OuInvoicePayList[i].PayWayName);
                        }
                    }
                }

                //配送相关信息
                string address = string.Empty;
                string deliverytimebymember = string.Empty;
                string mobile_phone = string.Empty;
                string consignee = string.Empty;

                if (balanceInfo.ouRecipeList != null && balanceInfo.ouRecipeList.Count > 0)
                {
                    if (balanceInfo.CurrentPatient.IsTakeMedicine > 0)
                    {
                        deliverytimebymember = balanceInfo.CurrentPatient.DistributionPeriod;
                        mobile_phone = balanceInfo.CurrentPatient.Mobile;
                        consignee = balanceInfo.CurrentPatient.PatientName;
                        address = balanceInfo.CurrentPatient.DistributionAddress;
                    }
                    else
                    {
                        mobile_phone = balanceInfo.CurrentPatient.Mobile;
                        consignee = balanceInfo.CurrentPatient.PatientName;
                    }
                }

                IDictionary<string, string> parameters = new Dictionary<string, string>();
                string timestamp, token;
                SetFlagValue(LsRepType);
                SetBaseInterfcaeParameters(out timestamp, out token);

                parameters.Add("tran_serial_no", flag);
                parameters.Add("operate_ip", flag);
                parameters.Add("method", nameof(AddBigOrders));
                parameters.Add("flag", flag);
                parameters.Add("model", AddBigOrders);

                DataMain data_main = new DataMain()
                {
                    shop_code = shop_code,
                    amount = 0,
                    order_sn = balanceInfo.OuInvoice.InvoNo,
                    pay_name = strPayWay,
                    mobile_phone = mobile_phone,
                    address = address,
                    consignee = consignee,
                    deliverytimebymember = deliverytimebymember,
                    creater = Orm.Config.UserProfiles.UserName,
                    state = "1",
                    timestamp = timestamp,
                    token = token,
                    data_detail = detailList,
                };
                if (LsRepType == 17)
                {
                    data_main.amount = sxprice;
                }
                else
                {
                    data_main.amount = ypprice;
                }
                string Data_Json = SetParametersJson(parameters, data_main);
                jsonString = HttpRequestHelper.PostPage(strURL, Data_Json);
                if (!jsonString.Contains("ok"))
                {
                    return jsonString;
                }
                else
                {
                    return jsonString;
                }
            }
            return jsonString;
        }
        #endregion

        #region 门店接口 GetDeptList
        public static List<PharmacyInfo> GetPharmacyInfoListlist(int type, int CurrHospital)
        {
            ReturnValue returnValue = new ReturnValue();
            SetFlagValue(type);
            method = "GetDeptList";
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            string timestamp = HttpRequestHelper.GetTimeStamp(Orm.Config.Service.DBClientService.GetServerTime());
            string md5 = MD5Helper.GetStringByMd5(timestamp);
            string token = MD5Helper.GetStringByMd5(md5 + strToken);
            parameters.Add("method", nameof(GetDeptList));
            parameters.Add("flag", flag);
            parameters.Add("model", GetDeptList);
            DataMain data_main = new DataMain()
            {
                timestamp = timestamp,
                token = token
            };
            string dataDetail = SetParametersJson(parameters, data_main);
            string returnJsonDate = HttpRequestHelper.PostPage(strURL, dataDetail);
            if (returnJsonDate.Contains("ok"))
            {
                if (returnJsonDate.Contains("[") & returnJsonDate.Contains("]"))
                {
                    int IndexofA = returnJsonDate.IndexOf("[");
                    int IndexofB = returnJsonDate.IndexOf("]");
                    string contentList = returnJsonDate.Substring(IndexofA, IndexofB - IndexofA + 1);
                    if (type == (int)EnumPharmacyType.药品药房)
                    {
                        List<PharmacyInfo> PharmacyInfoListlist = jsSerializer.Deserialize<List<PharmacyInfo>>(contentList);
                        return MergeMessage(type, PharmacyInfoListlist, CurrHospital);
                    }
                    else
                    {
                        List<PharmacyInfo> SXPharmacyInfoListlist = jsSerializer.Deserialize<List<PharmacyInfo>>(contentList);
                        return MergeMessage(type, SXPharmacyInfoListlist, CurrHospital);
                    }
                }
                else
                {
                    return new List<PharmacyInfo>();
                }
            }
            else
            {
                return new List<PharmacyInfo>();
            }
        }

        private static List<PharmacyInfo> MergeMessage(int type, List<PharmacyInfo> pharmacyLists, int CurrHospital)
        {
            List<PharmacyInfo> PharmacyInfoListlist = new List<PharmacyInfo>();
            var PharmacyLists = Config.DBClientBaseInRedis.GetList<BsPharmacyConfig>("HosPharmacyId=@0", CurrHospital).Where(t => t.IsActive == true).ToList();
            if (PharmacyLists != null || PharmacyLists.Count > 0)
            {
                for (int i = 0; i < PharmacyLists.Count; i++)
                {
                    for (int j = 0; j < pharmacyLists.Count; j++)
                    {
                        if (PharmacyLists[i].Pharmacytype == type)
                        {
                            if (PharmacyLists[i].PharmacyNo == pharmacyLists[j].dept_no)
                            {
                                if (PharmacyLists[i].IsDefault)
                                {
                                    pharmacyLists[j].IsDefult = true;
                                }
                                pharmacyLists[j].IsSelect = true;
                                pharmacyLists[j].GUID = PharmacyLists[i].GUID;
                            }
                        }
                    }
                }
                if (type == (int)EnumPharmacyType.药品药房)
                {
                    PharmacyInfoListlist = pharmacyLists.OrderBy(t => t.IsSelect).Reverse().ToList();
                }
                else
                {
                    PharmacyInfoListlist = pharmacyLists.OrderBy(t => t.IsSelect).Reverse().ToList();
                }
                return PharmacyInfoListlist;
            }
            else
            {
                return new List<PharmacyInfo>();
            }
        }
        #endregion

        #region 项目基本信息接口 GetGoodsWithHis
        public static string GetItemPosInfoUpdate(string code, string feemzId)
        {
            string ItemInfo, content;
            code = GetInterfaceData(code, feemzId, out ItemInfo, out content);
            if (content.Contains("[") & content.Contains("]"))
            {
                List<ApiAddItemInfo> PharmacyInfoListlist = TransformationJsonData(content);
                if (PharmacyInfoListlist.Count == 0)
                {
                    ItemInfo = "没有找到该药品信息,同步操作取消";
                    return ItemInfo;
                }
                else
                {
                    //单位
                    string _unitId = AddUnit(PharmacyInfoListlist);
                    //厂商
                    string _bsManufacturerId = AddManufacturer(PharmacyInfoListlist);
                    //基础信息
                    BsItem bsItem = null;
                    if (feemzId!="5602")
                    {
                        bsItem = Config.Service.DBClientService.Get<BsItem>("Code=@0 and HospitalId=@1", PharmacyInfoListlist[0].goods_code, (int)EnumMainLocation.总店);
                    }else
                    {
                        bsItem = Config.Service.DBClientService.Get<BsItem>("Code=@0 and HospitalId=@1", "SX"+PharmacyInfoListlist[0].goods_code, (int)EnumMainLocation.总店);
                    }
                    
                    if (bsItem == null || bsItem.GUID == null)
                    {
                        string count;
                        AddItem(feemzId, out ItemInfo, PharmacyInfoListlist, _unitId, _bsManufacturerId, out count);
                        if (!string.IsNullOrEmpty(count))
                        {
                            ItemInfo = "同步成功," + PharmacyInfoListlist[0].goods_code + "," + PharmacyInfoListlist[0].goods_name;
                            return ItemInfo;
                        }
                    }
                    else
                    {
                        ItemInfo = "已存在相同项目,同步操作取消," + PharmacyInfoListlist[0].goods_code + "," + PharmacyInfoListlist[0].goods_name;
                        return ItemInfo;
                    }
                }
                return ItemInfo;
            }
            else
            {
                ItemInfo = "接口返回信息错误";
                return ItemInfo;
            }
        }

        private static void AddItem(string feemzId, out string ItemInfo, List<ApiAddItemInfo> PharmacyInfoListlist, string _unitId, string _bsManufacturerId, out string count)
        {
            ItemInfo = PharmacyInfoListlist[0].goods_code + "" + PharmacyInfoListlist[0].goods_name;
            BsItem model = new BsItem
            {
                IsOnlyForSys = true,
                Code = PharmacyInfoListlist[0].goods_code,
                WbCode = Utilities.PyWbHelper.SixBitWBCode(PharmacyInfoListlist[0].goods_name),
                PyCode = Utilities.PyWbHelper.SixBitPYCode(PharmacyInfoListlist[0].goods_name),
                Name = PharmacyInfoListlist[0].goods_name,
                PriceDiag = PharmacyInfoListlist[0].goods_price,
                PriceIn = PharmacyInfoListlist[0].goods_price,
                UnitDiagId = _unitId,
                UnitDiag = PharmacyInfoListlist[0].unit_name,
                Dosage = 1,
                FeeMzId = "cc610dde7cd84afc8611f8892257abd8",//待处理
                IsRpForbid = false,
                IsActive = true,
                InsertTime = Service.DBClientService.GetServerTime(),
                ManuId = _bsManufacturerId,
                Spec = PharmacyInfoListlist[0].goods_spec,
                IsDiscounts=false,
                HospitalId = UserProfiles.HospitalID,
                GroupMainId = null, //药品分类
                FeeZyId = null,
                OperId = "663C86A0855E6986E050AA0A313010F4",  //UserProfilesService.UserID,
                Memo = DateTime.Now.ToString() + "【新增】字典维护导入"
            };
            if (PharmacyInfoListlist[0].unit_name == "十克")
            {
                model.FeeMzIdCode = 5400;//中药
                model.PharmacyRatio = 10;
            }
            if (feemzId == "5602")
            {
                model.FeeMzId = "";//生鲜
                model.Code = "SX" + PharmacyInfoListlist[0].goods_code;
            }
            count = Config.Service.DBClientService.Add(model);
        }

        private static string AddManufacturer(List<ApiAddItemInfo> PharmacyInfoListlist)
        {
            int bsmanufacturerSeqNo = Config.DBClientBaseInRedis.GetAllList<BsManufacturer>().Count();
            BsManufacturer bsManufacturer = Config.Service.DBClientService.Get<BsManufacturer>("Name=@0", PharmacyInfoListlist[0].manufacturer);
            string _bsManufacturerId = "";
            if (bsManufacturer == null || bsManufacturer.GUID == "")
            {
                _bsManufacturerId = Config.Service.DBClientService.Add<BsManufacturer>(new BsManufacturer()
                {
                    Name = PharmacyInfoListlist[0].manufacturer,
                    IsActive = true,
                    Code = bsmanufacturerSeqNo.ToString(),
                    OrderBy = bsmanufacturerSeqNo,
                    WbCode = Utilities.PyWbHelper.SixBitWBCode(PharmacyInfoListlist[0].manufacturer),
                    PyCode = Utilities.PyWbHelper.SixBitPYCode(PharmacyInfoListlist[0].manufacturer),
                    IconIndex = 1
                });
            }
            else
            {
                _bsManufacturerId = bsManufacturer.GUID;
            }

            return _bsManufacturerId;
        }

        private static string AddUnit(List<ApiAddItemInfo> PharmacyInfoListlist)
        {
            BsUnit bsUnit = Config.Service.DBClientService.Get<BsUnit>("Name=@0", PharmacyInfoListlist[0].unit_name);
            int unitNO = Config.DBClientBaseInRedis.GetAllList<BsUnit>().Count();
            string _unitId = "";
            if (bsUnit == null || bsUnit.GUID == null)
            {
                _unitId = Config.Service.DBClientService.Add<BsUnit>(new BsUnit()
                {
                    Code = unitNO.ToString(),
                    Name = PharmacyInfoListlist[0].unit_name,
                    PrintName = PharmacyInfoListlist[0].unit_name,
                    WbCode = Utilities.PyWbHelper.SixBitWBCode(PharmacyInfoListlist[0].unit_name),
                    PyCode = Utilities.PyWbHelper.SixBitPYCode(PharmacyInfoListlist[0].unit_name),
                    IsActive = true,
                    IconIndex = 0,
                    OrderBy = unitNO,
                    ModiTime = Config.Service.DBClientService.GetServerTime()
                });
            }
            else
            {
                _unitId = bsUnit.GUID;
            }

            return _unitId;
        }

        private static List<ApiAddItemInfo> TransformationJsonData(string content)
        {
            int IndexofA = content.IndexOf("[");
            int IndexofB = content.IndexOf("],");
            string contentList = content.Substring(IndexofA, IndexofB - IndexofA + 1);
            JavaScriptSerializer Serializer = new JavaScriptSerializer();
            List<ApiAddItemInfo> PharmacyInfoListlist = Serializer.Deserialize<List<ApiAddItemInfo>>(contentList);
            return PharmacyInfoListlist;
        }

        private static List<SeverStock> JsonDatatText(string content)
        {
            List<SeverStock> SeverStocklist = new List<SeverStock>();
            int IndexofText = content.LastIndexOf("DocumentElement");
            if(IndexofText != -1)
            {
                int leng = content.LastIndexOf("}");
                string TEXT = content.Substring(IndexofText).ToString();
                int IndexofTEXT2 = TEXT.IndexOf("[");
                if (IndexofTEXT2 > -1)
                {
                    int IndexofA = content.LastIndexOf("[");
                    int IndexofB = content.LastIndexOf("]");
                    string contentList = content.Substring(IndexofA, IndexofB - IndexofA + 1);
                    contentList = contentList.Replace(@"@diffgr:", "");
                    contentList = contentList.Replace(@"@msdata:", "");
                    JavaScriptSerializer Serializer = new JavaScriptSerializer();
                    SeverStocklist = Serializer.Deserialize<List<SeverStock>>(contentList);
                }
                else
                {
                    TEXT = content.Substring(IndexofText, leng - IndexofText - 4).ToString() + "]";
                    string sdf = "\"OU\":";
                    TEXT = TEXT.Replace(sdf, "[");
                    int IndexofA = TEXT.LastIndexOf("[");
                    int IndexofB = TEXT.LastIndexOf("]");
                    string contentList = TEXT.Substring(IndexofA, IndexofB - IndexofA + 1);
                    contentList = contentList.Replace(@"@diffgr:", "");
                    contentList = contentList.Replace(@"@msdata:", "");
                    JavaScriptSerializer Serializer = new JavaScriptSerializer();
                    SeverStocklist = Serializer.Deserialize<List<SeverStock>>(contentList);
                }
            }
            
            return SeverStocklist;
        }


        private static string GetInterfaceData(string code, string feemzId, out string ItemInfo, out string content)
        {
            ItemInfo = string.Empty;
            content = string.Empty;
            if (feemzId == "5602")//生鲜项目
            {
                flag = "5602";
                code = code.Substring(2);
            }
            else
            {
                flag = "5400";
            }
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            string timestamp, token;
            SetBaseInterfcaeParameters(out timestamp, out token);
            parameters.Add("method", nameof(GetGoodsWithHis));
            parameters.Add("flag", flag);
            parameters.Add("model", GetGoodsWithHis);
            DataMain data_main = new DataMain()
            {
                goods_code = code,
                timestamp = timestamp,
                token = token,
            };
            string Data_Json = SetParametersJson(parameters, data_main);
            content = HttpRequestHelper.PostPage(strURL, Data_Json);
            return code;
        }
        #endregion

        #region 云门诊调取HIS病患病历信息

        public static ApiResultInfo GetHisPatientInfo(string patid)
        {
            if (Service.DBClientService.GetModelByID<BsHospital>(UserProfiles.HospitalID).IsInterface)
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(strURL);
                //参数 
                IDictionary<string, string> parameters = new Dictionary<string, string>();
                string timestamp, token;
                SetBaseInterfcaeParameters(out timestamp, out token);
                parameters.Add("method", "YMZ_From_HIS_getPatientInfo");
                parameters.Add("patient", patid);

                System.Text.StringBuilder data_Json = new System.Text.StringBuilder();
                jsSerializer.Serialize(parameters, data_Json);
                
                string jsonString = HttpRequestHelper.PostPage(strURL, data_Json.ToString());
                if (jsonString.Contains("此病患ID号不存在"))
                {
                    return new ApiResultInfo();
                }
                ApiResultInfo PharmacyInfoListlist = JsonHelper.JSONToObject<ApiResultInfo>(jsonString);
                return PharmacyInfoListlist;
            }
            else
            {
                return new ApiResultInfo();
            }
        }
        #endregion

        #region 云门诊调取HIS病患检验信息

        public static ApiResultInfo GetLisReportUrl(string patid, string times)
        {
            if (Service.DBClientService.GetModelByID<BsHospital>(UserProfiles.HospitalID).IsInterface)
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(strURL);
                //参数 
                IDictionary<string, string> parameters = new Dictionary<string, string>();
                parameters.Add("method", "YMZ_From_HIS_getLisReportUrl");
                parameters.Add("patient", patid);
                parameters.Add("times", times);

                System.Text.StringBuilder data_Json = new System.Text.StringBuilder();
                jsSerializer.Serialize(parameters, data_Json);

                string jsonString = HttpRequestHelper.PostPage(strURL, data_Json.ToString());
                ApiResultInfo PharmacyInfoListlist = JsonHelper.JSONToObject<ApiResultInfo>(jsonString);
                return PharmacyInfoListlist;
            }
            else
            {
                return new ApiResultInfo();
            }
        }
        #endregion

        #region 云门诊调取HIS医嘱信息
        public static ApiResultInfo GetPatientOrdersInfo(string patid, string times)
        {
            if (Service.DBClientService.GetModelByID<BsHospital>(UserProfiles.HospitalID).IsInterface)
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(strURL);
                //参数 
                IDictionary<string, string> parameters = new Dictionary<string, string>();
                parameters.Add("method", "YMZ_From_HIS_getPatientOrdersInfo");
                parameters.Add("patient", patid);
                parameters.Add("times", times);

                System.Text.StringBuilder data_Json = new System.Text.StringBuilder();
                jsSerializer.Serialize(parameters, data_Json);

                string jsonString = HttpRequestHelper.PostPage(strURL, data_Json.ToString());
                ApiResultInfo PharmacyInfoListlist = JsonHelper.JSONToObject<ApiResultInfo>(jsonString);
                return PharmacyInfoListlist;
            }
            else
            {
                return new ApiResultInfo();
            }
        }
        #endregion

        #region 云门诊调取门诊病历信息
        public static ApiResultInfo GetPatientBLInfo(string patid, string times)
        {
            if (Service.DBClientService.GetModelByID<BsHospital>(UserProfiles.HospitalID).IsInterface)
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(strURL);
                //参数 
                IDictionary<string, string> parameters = new Dictionary<string, string>();
                parameters.Add("method", "YMZ_From_HIS_getPatientBLInfo");
                parameters.Add("patient", patid);
                parameters.Add("times", times);
                System.Text.StringBuilder data_Json = new System.Text.StringBuilder();
                jsSerializer.Serialize(parameters, data_Json);

                string jsonString = HttpRequestHelper.PostPage(strURL, data_Json.ToString());
                ApiResultInfo PharmacyInfoListlist = JsonHelper.JSONToObject<ApiResultInfo>(jsonString);
                return PharmacyInfoListlist;
            }
            else
            {
                return new ApiResultInfo();
            }
        }
        #endregion

        #region 写入转诊信息（转出）
        public static ReturnValue AddReferralInfo(InOutHospital inOutHospital)
        {
            ReturnValue returnValue = new ReturnValue();
            //if (Config.Service.DBClientService.GetModelByID<BsHospital>(inOutHospital.OutHospitalID).IsInterface)
            //{

                BsPatient currPatInfo = Config.Service.DBClientService.GetModelByGuid<BsPatient>(inOutHospital.PatId);
                string strURL = "http://183.60.189.46:8060/platformByHis";
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(strURL);
                //参数 
                IDictionary<string, string> parameters = new Dictionary<string, string>
                {
                    { "method", "YMZ_to_HIS_Patient" },
                    { "Tokencode", "8ab6c803f9a380df2796315cad1b4280" },
                    { "hospId", inOutHospital.HospId },
                    { "mzregId", inOutHospital.MzregId },
                    { "patId", inOutHospital.PatId },
                    { "outHospitalID", inOutHospital.OutHospitalID.ToString()},
                    { "outoperTime", inOutHospital.OutoperTime.ToString() },
                    { "outoperId", inOutHospital.OutoperId??"" },
                    { "outDoctorId", inOutHospital.OutDoctorId??""},
                    { "isOutSign", inOutHospital.IsOutSign.ToString()},
                    { "outSignOperId", inOutHospital.OutSignOperId??""},
                    { "outSignTime", inOutHospital.OutSignTime.ToString() },
                    { "outSignMemo", inOutHospital.OutSignMemo ??""},
                    { "inHospitalID", inOutHospital.InHospitalID ??""},
                    { "inOperTime", inOutHospital.InOperTime.ToString() },
                    { "inOperId", inOutHospital.InOperId ??"" },
                    { "inDoctorId", inOutHospital.InDoctorId ??"" },
                    { "isInsign", inOutHospital.IsInsign.ToString()},
                    { "inSignOperId", inOutHospital.InSignOperId??"" },
                    { "inSignTime", inOutHospital.InSignTime.ToString() },
                    { "inSignMemo", inOutHospital.InSignMemo??"" },
                    { "refNo", inOutHospital.RefNo??"" },
                    { "treatmentPro", inOutHospital.TreatmentPro.ToString() },
                    { "diagGoal", inOutHospital.DiagGoal.ToString() },
                    { "lsEmergency", inOutHospital.LsEmergency.ToString() },
                    { "inlocationid", inOutHospital.Inlocationid.ToString() },
                    { "PatName", currPatInfo.Name??"" },
                    { "InHospName", inOutHospital.InHospName??"" },
                    { "InlocationName", inOutHospital.InlocationName??"" },
                    { "OutDocName", inOutHospital.OutDocName??"" },
                    { "LsemergencyName", inOutHospital.LsemergencyName??"" },
                    { "InDocName", inOutHospital.InDocName??"" },
                    { "inHospitalName", inOutHospital.InHospitalName??"" },
                    { "CardNo", currPatInfo.CardNo??""},
                    { "Sex", currPatInfo.Sex??"" },
                    { "BirthDate", currPatInfo.BirthDate.ToString() },
                    { "BloodGroup", currPatInfo.BloodGroup??"" },
                    { "Mobile", currPatInfo.Mobile??"" },
                    { "Email", currPatInfo.Email??"" },
                    { "Phone", currPatInfo.Phone??"" },
                    { "PatTypeId", currPatInfo.PatTypeId??"" },
                    { "PatType", currPatInfo.PatType??"" },
                    { "IdCardNo", currPatInfo.IdCardNo??"" },
                    { "MedicareNo", currPatInfo.MedicareNo??""}
                };
                JavaScriptSerializer jsSerializer = new JavaScriptSerializer();
                System.Text.StringBuilder data_Json = new System.Text.StringBuilder();
                jsSerializer.Serialize(parameters, data_Json);
                string Data_Json = data_Json.ToString();
                string jsonString = HttpRequestHelper.PostPage(strURL, Data_Json);
                return returnValue = jsSerializer.Deserialize<ReturnValue>(jsonString);
            //}
            //else
            //{
            //    return returnValue;
            //}
        }
        #endregion

        public static List<SeverStock> GetBsitemStore(string No)
        {
            GetDrugStoreDtl.ZhongShanDrugStorePortTypeClient zhongShanDrugStorePortTypeClient = new GetDrugStoreDtl.ZhongShanDrugStorePortTypeClient();
            var XMLText = zhongShanDrugStorePortTypeClient.GetDistributionList(No);
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(XMLText);
            string jsonText = JsonConvert.SerializeXmlNode(doc);
            return JsonDatatText(jsonText);
        }

   
    }

}
