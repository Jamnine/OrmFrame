using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using Orm.Config;
using Orm.Framework.Services;
using Orm.Framework.Services.Utility;
using Orm.Model;
using Orm.Model.EnumDefine;
using Orm.Model.InterFace;

namespace Orm.Client.Common
{
    public class SynchronousBsitem
    {
        public static string GetItemPosInfoUpdate(string code, string feemzId)
        {
            string ItemInfo, content;
            code = GetInterfaceData(code, feemzId, out  ItemInfo, out  content);
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
                    BsItem bsItem = Config.Service.DBClientService.Get<BsItem>("Code=@0 and HospitalId=@1", PharmacyInfoListlist[0].goods_code, (int)EnumMainLocation.总店);
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
            int unitNO =Config.DBClientBaseInRedis.GetAllList<BsUnit>().Count();
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

        private static string GetInterfaceData(string code, string feemzId, out string ItemInfo, out string content)
        {
            ItemInfo = string.Empty;
            content = string.Empty;
            string strURL = string.Empty;
            if (feemzId == "5602")//生鲜项目
            {
                strURL = "http://fenyd.succhi.com:10043/api/His/GetGoodsWithHis";
                code = code.Substring(2);
            }
            else
            {
                strURL = "http://fenyd.succhi.com:10042/api/His/GetGoodsWithHis";
            }
            string timestamp = HttpRequestHelper.GetTimeStamp(Orm.Config.Service.DBClientService.GetServerTime());
            string md5 = MD5Helper.GetStringByMd5(timestamp);
            string token = MD5Helper.GetStringByMd5(md5 + "his9aa1_3db6303565bc");
            DataMain data_main = new DataMain()
            {
                goods_code = code,
                timestamp = timestamp,
                token = token,
            };
            JavaScriptSerializer jsc = new JavaScriptSerializer();
            System.Text.StringBuilder jsonData = new System.Text.StringBuilder();
            jsc.Serialize(data_main, jsonData);
            string dataDetail = jsonData.ToString();
            content = HttpRequestHelper.PostPage(strURL, dataDetail);
            return code;
        }
    }
}
