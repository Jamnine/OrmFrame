using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Orm.Config;

namespace Orm.Client.Common
{
    public class WeatherHelper
    {
        private String HttpResponse(String urlStr)
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlStr);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                using (var stream = response.GetResponseStream())
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        sb.Append(reader.ReadToEnd());
                        reader.Close();
                    }
                }
            }
            catch 
            {
                //异常无视
                //Orm.Utilities.Common.ShowMsgBox("获取天气失败");
            }
            return sb.ToString();
        }

        public void GetWeather(ref string[] weatherPlace, ref string[] weatherTemperature, ref string[] days, ref string[] Weather, ref string[] weather_icon,ref  string[] weatherWeek,  ref  string cityCode)
        {
            //获取城市代码http://61.4.185.48:81/g/
            // 获取天气http://api.k780.com:88/?app=weather.today&weaid=101280101&appkey=10003&sign=b59bc3ef6191eb9f747dd4e83c99f2a4&format=json
            // 获取天气气象局http://www.weather.com.cn/data/cityinfo/"+this.GetCityCode()+".html
            string cityname = GetCityName();
            cityname = cityname == string.Empty ? this.GetCityCode(cityCode) : cityname;
            string strUrl = "http://api.k780.com:88/?app=weather.future&weaid=" + cityname + "&appkey=24094&sign=744e2d1285d331e0a44313c249a70a91&format=json";
            try
            {
                StringBuilder sb = new StringBuilder();
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(strUrl);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                using (var stream = response.GetResponseStream())
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        sb.Append(reader.ReadToEnd());
                        reader.Close();
                    }
                }

                // string strResult = this.HttpResponse(strUrl);
                JObject obj = JObject.Parse(sb.ToString());
                if (obj["success"].ToString() == "1")
                {
                    for (int i = 0; i < 3; i++)
                    {
                        Orm.Config.UserProfiles.CurrCity = weatherPlace[i] = obj["result"][i]["citynm"].ToString();
                        weatherTemperature[i] = string.Format("{0}℃~{1}℃", obj["result"][i]["temp_low"].ToString(), obj["result"][i]["temp_high"].ToString());
                        days[i] = string.Format("日期：{0}", obj["result"][i]["days"].ToString());
                        Weather[i] = string.Format("天气：{0}", obj["result"][i]["weather"].ToString());
                        weather_icon[i] = obj["result"][i]["weatid"].ToString();
                        weatherWeek[i] = obj["result"][i]["week"].ToString();
                    }
                }
                else
                {
                    //Orm.Client.Base.FrmMessageRemind.Show("输入的地址匹配天气失败，请确认输入地址是否正确");
                    //Orm.Utilities.Common.ShowMsgBox("输入的地址匹配天气失败，请确认输入地址是否正确");
                    cityCode = Orm.Config.UserProfiles.CurrCity;
                    SetCityName(cityCode);
                }
            }
            catch
            {
                
                //异常无视
                //Orm.Utilities.Common.ShowMsgBox("获取天气失败");
            }
            //parseJson(strUrl);
            // return "";
        }


        public string GetCityCode(string cityCodeOrName)
        {
            //string strUrl = "http://61.4.185.48:81/g/";
            string strUrl = null;
            if (!string.IsNullOrWhiteSpace(cityCodeOrName))
            {
                return cityCodeOrName;
            }
            else
            {
                strUrl = "http://61.4.185.48:81/g/";
            }
            try
            {
                StringBuilder sb = new StringBuilder();
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(strUrl);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                using (var stream = response.GetResponseStream())
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        sb.Append(reader.ReadToEnd());
                        reader.Close();
                    }
                }
                var dd = sb.ToString();
                return dd.Split('=', ';')[3];
            }
            catch
            {
                return "101280101";
            }
        }

        public string GetCityName()
        {
            KeyConfig loginUserConfig = ConfigManager<KeyConfig>.GetInfo("WeatherCitySetting", "CityName");
            if (loginUserConfig == null)
            {
                return "";
            }
            string returnValue = loginUserConfig.KeyValue;
            return returnValue;
        }

        public void SetCityName(string name)
        {
            ConfigurationList<KeyConfig> list = ConfigManager<KeyConfig>.GetList("WeatherCitySetting");
            if (list != null)
            {
                list["CityName"].KeyValue = name;
                ConfigManager<KeyConfig>.SaveList("WeatherCitySetting", list);
            }
            else
            {
                 list = new ConfigurationList<KeyConfig>();
                 list.Add(new KeyConfig{ Key = "CityName", KeyValue=name});
                 ConfigManager<KeyConfig>.SaveList("WeatherCitySetting", list);
            }
        }

        //private void parseJson(String jsonData)
        //{
        //    try
        //    {
        //        JObject obj = JObject.Parse(jsonData);

        //        // Newtonsoft.Json.JsonReader
        //        //  Newtonsoft.Json.JsonReader allWeatherData = new Newtonsoft.Json.JsonTextReader(new StringReader(jsonData));
        //        //JSONObject weatherData = allWeatherData.getJSONObject("weatherinfo");
        //        // 第一天的<strong>天气</strong>情况  
        //        weatherInfo1 = new StringBuilder();
        //        weatherInfo1.Append("地点:" + obj["weatherinfo"]["city"].ToString());
        //        weatherInfo1.Append("\n时间:" + obj["weatherinfo"]["date_y"].ToString()
        //                + "     " + obj["weatherinfo"]["week"].ToString());
        //        weatherInfo1.Append("\n今日<strong>天气</strong>:" + obj["weatherinfo"]["weather1"].ToString());
        //        weatherInfo1.Append("\n温度:" + obj["weatherinfo"]["temp1"].ToString());
        //        weatherPicUrl1 = obj["weatherinfo"]["img1"].ToString();
        //        weatherPicUrl2 = obj["weatherinfo"]["img2"].ToString(); ;
        //        weatherInfo1.Append("\n风速:" + obj["weatherinfo"]["wind1"].ToString() + "    "
        //                + obj["weatherinfo"]["fl1"].ToString());
        //        // 第二天的<strong>天气</strong>情况  
        //        //weatherInfo2 = new StringBuilder();
        //        //weatherInfo2.Append("明天<strong>天气</strong>:" + obj["weatherinfo"]["weather2"].ToString());
        //        //weatherInfo2.Append("\n温度:" + obj["weatherinfo"]["temp2"].ToString());
        //        //weatherPicUrl3 = obj["weatherinfo"]["img3"].ToString();
        //        //weatherPicUrl4 = obj["weatherinfo"]["img4"].ToString();
        //        //weatherInfo2.Append("\n风速:" + obj["weatherinfo"]["wind2"].ToString() + "    "
        //        //        + obj["weatherinfo"]["fl2"].ToString());
        //        //// 第三天的<strong>天气</strong>情况  
        //        //weatherInfo3 = new StringBuilder();
        //        //weatherInfo3.Append("后天<strong>天气</strong>:" + obj["weatherinfo"]["weather3"].ToString());
        //        //weatherInfo3.Append("\n温度:" + obj["weatherinfo"]["temp3"].ToString());
        //        //weatherPicUrl5 = obj["weatherinfo"]["img5"].ToString();
        //        //weatherPicUrl6 = obj["weatherinfo"]["img6"].ToString();
        //        //weatherInfo3.Append("\n风速:" + obj["weatherinfo"]["wind3"].ToString() + "    "
        //        //        + obj["weatherinfo"]["fl3"].ToString());

        //    }
        //    catch (Exception e)
        //    {
        //        Orm.Utilities.Common.ShowMsgBox(e.Message);
        //    }
        //}
    }
}
