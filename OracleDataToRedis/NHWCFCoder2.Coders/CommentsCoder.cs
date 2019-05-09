using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using OracleDataToRedis.Utils;

namespace OracleDataToRedis.Coders
{
    public class CommentsCoder
    {
        public static void CreateCsComments(String comments, StreamWriter sw)
        {
            sw.WriteLine("/* =====================================================");
            sw.WriteLine("    作    者 : " + BaseParams.Author);
            sw.WriteLine("    创建时间 : " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            sw.WriteLine("    修 改 者 : ");
            sw.WriteLine("    修改时间 : ");
            sw.WriteLine("    描    述 : " + comments);
            sw.WriteLine("===================================================== */");
            sw.WriteLine("");
        }
    }
}
