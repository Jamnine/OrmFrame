using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Data;

namespace Orm.Client.Common
{
  
        /// <summary>
        /// 一个通用的类型转换器，可以提供更多转换控制参数
        /// </summary>
        internal class GenericTypeConverter : IValueConverter
        {
            //public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
            //{
            //    if (value.ToString() == parameter.ToString())
            //    {
            //        return true;
            //    }
            //    return false;
            //}

            //public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
            //{
            //    if (value is bool)
            //    {
            //        if ((bool)value)
            //        {
            //            return parameter;
            //        }
            //    }
            //    return null;
            //}

            /// <summary>
            /// 是否反转转换源参数值
            /// 仅对bool类型的值有效
            /// </summary>
           //private bool IsReverse { get; set; }

            /// <summary>
            /// 用于将转换结果映射为其它字符串
            /// 例如：Alias=True:是|False:否
            /// </summary>
            private Dictionary<object,object> Alias { get; set; }

            ///// <summary>
            ///// 解析转换参数
            ///// </summary>
            //private void AnalyseConvertParameter(string convertParameter)
            //{
            //    /*设置参数默认值*/
            //   // IsReverse = false;
            //    Alias = null;

            //    if (!string.IsNullOrEmpty(convertParameter))
            //    {
            //        var pkvs = convertParameter.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            //        foreach (var pkv in pkvs)
            //        {
            //            var pkvo = pkv.Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
            //            if (pkvo.Length != 2)
            //                throw new NotSupportedException("不支持设置：" + pkv);
            //            var pk = pkvo[0].Trim();
            //            var pv = pkvo[1].Trim();

            //            switch (pk)
            //            {
            //                //case "IsReverse":
            //                //    bool b;
            //                //    if (!bool.TryParse(pv, out b))
            //                //        throw new NotSupportedException("参数取值错误：" + pkv);
            //                //    else
            //                //        IsReverse = b;
            //                //    break;
            //                case "Alias":
            //                    {
            //                        Alias = new Dictionary<object, string>();
            //                        var dfkvs = pv.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
            //                        foreach (var dfkv in dfkvs)
            //                        {
            //                            var dfkvo = dfkv.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
            //                            if (dfkvo.Length != 2)
            //                                throw new NotSupportedException("不支持设置：" + dfkvo);
            //                            var dfk = dfkvo[0].Trim();
            //                            var dfv = dfkvo[1].Trim();

            //                            object oKey = null;
            //                            int i;
            //                            if (dfk.Equals("true", StringComparison.OrdinalIgnoreCase))
            //                                oKey = true;
            //                            else if (dfk.Equals("false", StringComparison.OrdinalIgnoreCase))
            //                                oKey = false;
            //                            else if (dfk.Equals("other", StringComparison.OrdinalIgnoreCase))
            //                                oKey = "other";
            //                            else if (int.TryParse(dfk, out i))
            //                                oKey = i;
            //                            else
            //                                throw new NotSupportedException("参数取值错误：" + dfkv);

            //                            Alias[oKey] = dfv;
            //                        }
            //                    }
            //                    break;
            //                default:
            //                    throw new NotSupportedException("不支持的参数名：" + pk);
            //            }
            //        }
            //    }
            //}



            /// <summary>
            /// 解析转换参数
            /// </summary>
            private void AnalyseConvertParameter(string convertParameter, Type sourceType, Type targetType, System.Globalization.CultureInfo culture)
            {
                /*设置参数默认值*/
                // IsReverse = false;
                Alias = null;

                if (!string.IsNullOrEmpty(convertParameter))
                {
                    var pkvs = convertParameter.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (var pkv in pkvs)
                    {
                        var pkvo = pkv.Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
                        if (pkvo.Length != 2)
                            throw new NotSupportedException("不支持设置：" + pkv);
                        var pk = pkvo[0].Trim();
                        var pv = pkvo[1].Trim();

                        switch (pk)
                        {
                            case "Alias":
                                {
                                    Alias = new Dictionary<object, object>();
                                    var dfkvs = pv.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                                    foreach (var dfkv in dfkvs)
                                    {
                                        var dfkvo = dfkv.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                                        if (dfkvo.Length != 2)
                                            throw new NotSupportedException("不支持设置：" + dfkvo);
                                        var dfk = dfkvo[0].Trim();
                                        var dfv = dfkvo[1].Trim();
                                        if (sourceType == typeof(String) && targetType == typeof(bool?))
                                        {
                                            bool flag;
                                            if (bool.TryParse(dfv,out flag) || bool.TryParse(dfv, out flag))
                                            {
                                                Alias.Add(dfk, flag);
                                            }
                                            else {
                                                throw new NotSupportedException("参数取值错误："+dfv+"不支持Bool类型转换");
                                            }
                                        }else if(sourceType==typeof(String) && targetType==typeof(Visibility))
                                        {
                                            Visibility visibility = Visibility.Collapsed;
                                            switch (dfv)
                                            {
                                                case "Collapsed":
                                                    visibility = Visibility.Collapsed;
                                                    break;
                                                case "Visible":
                                                    visibility = Visibility.Visible;
                                                    break;
                                                case "Hidden":
                                                    visibility = Visibility.Hidden;
                                                    break;
                                                default:
                                                    throw new NotSupportedException("参数取值错误：" + dfv + "不支持Visibility类型转换");
                                            }
                                            Alias.Add(dfk,visibility);
                                        }
                                      
                                    }
                                }
                                break;
                            default:
                                throw new NotSupportedException("不支持的参数名：" + pk);
                        }
                    }
                }
            }


            /// <summary>
            /// 解析转换参数
            /// </summary>
            private void AnalyseConvertParameter2(string convertParameter, Type sourceType, Type targetType, System.Globalization.CultureInfo culture)
            {
                /*设置参数默认值*/
                // IsReverse = false;
                Alias = null;

                if (!string.IsNullOrEmpty(convertParameter))
                {
                    var pkvs = convertParameter.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (var pkv in pkvs)
                    {
                        var pkvo = pkv.Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
                        if (pkvo.Length != 2)
                            throw new NotSupportedException("不支持设置：" + pkv);
                        var pk = pkvo[0].Trim();
                        var pv = pkvo[1].Trim();

                        switch (pk)
                        {
                            case "Alias":
                                {
                                    Alias = new Dictionary<object, object>();
                                    var dfkvs = pv.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                                    foreach (var dfkv in dfkvs)
                                    {
                                        var dfkvo = dfkv.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                                        if (dfkvo.Length != 2)
                                            throw new NotSupportedException("不支持设置：" + dfkvo);
                                        var dfk = dfkvo[0].Trim();
                                        var dfv = dfkvo[1].Trim();

                                        if (sourceType == typeof(bool) && targetType == typeof(string))
                                        {
                                            bool flag;
                                            if (bool.TryParse(dfv, out flag) || bool.TryParse(dfv, out flag))
                                            {
                                                if(!Alias.ContainsKey(flag))
                                                    Alias.Add(flag,dfk);
                                            }
                                            else
                                            {
                                                throw new NotSupportedException("参数取值错误：" + dfv + "不支持Bool类型转换");
                                            }
                                        }else if (sourceType == typeof(Visibility) && targetType == typeof(String))
                                        {
                                            Visibility visibility = Visibility.Collapsed;
                                            switch (dfv)
                                            {
                                                case "Collapsed":
                                                    visibility = Visibility.Collapsed;
                                                    break;
                                                case "Visible":
                                                    visibility = Visibility.Visible;
                                                    break;
                                                case "Hidden":
                                                    visibility = Visibility.Hidden;
                                                    break;
                                                default:
                                                    throw new NotSupportedException("参数取值错误：" + dfv + "不支持Visibility类型转换");
                                            }
                                            Alias.Add(visibility,dfk);
                                        }
                                    }
                                }
                                break;
                            default:
                                throw new NotSupportedException("不支持的参数名：" + pk);
                        }
                    }
                }
            }

            public object Convert(object value, Type targetType, object parameter,System.Globalization.CultureInfo culture)
            {
                AnalyseConvertParameter(parameter as string,value.GetType(),targetType,culture);

                try
                {
                       if (Alias != null && Alias.ContainsKey(value))
                            return Alias[value];
                       else if(Alias!=null && Alias.ContainsKey("other"))
                            return Alias["other"];

                    return System.Convert.ChangeType(value,targetType);
                }
                catch
                {
                    return null;
                }
            }

            public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
            {
                AnalyseConvertParameter2(parameter as string, value.GetType(), targetType, culture);
                if (Alias != null && Alias.ContainsKey(value)) { 
                    if (Object.Equals(Alias[value],"other"))
                    {
                        return null;
                    }
                    else
                    {
                        return Alias[value];
                    }
                }
                return System.Convert.ChangeType(value, targetType);
            }


            #region MyRegion
            
            #endregion

            #region 责任链内部类

            public abstract class AbstractHandler
            {
                private AbstractHandler nexthandler;
                public AbstractHandler NextHandler { get { return nexthandler; } set { this.nexthandler=value;} }

                public abstract void Handle<T>(T parameter);
            }

            public class HanderHelper
            {
                public HanderHelper(){
                    topHander = new TopHander();
                }

                private AbstractHandler topHander;

                public void AddHander(AbstractHandler hander)
                {
                    RecursiveHander(topHander).NextHandler=hander;
                }

                private AbstractHandler RecursiveHander(AbstractHandler hander)
                {
                    if (hander.NextHandler == null)
                    {
                        return hander;
                    }
                    else
                    {
                       return RecursiveHander(hander.NextHandler);
                    }
                }

                private class TopHander:AbstractHandler
                {
                    
                public override void Handle<T>(T parameter)
                {
 	                if(this.NextHandler!=null)
                    {
                        this.NextHandler.Handle(parameter);
                    }
                }
}
            }


            #endregion


        }

}
