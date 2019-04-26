using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Framework.Services
{
    public interface IZip
    {
        /// <summary>
        /// 将多个文件压缩成一个zip
        /// </summary>
        /// <param name="zipfile">压缩后的zip文件名(绝对路径)</param>
        /// <param name="files">多个文件，数组的每一条指定一个绝对路径文件名(不可重复)</param>
        /// <returns>是否成功</returns>
        bool CreateZipFile(string zipfile, string[] files);

        /// <summary>
        /// 将一个目录压缩成一个zip
        /// </summary>
        /// <param name="zipfile">压缩后的zip文件名(绝对路径)</param>
        /// <param name="dir">要压缩的目录(绝对路径)</param>
        /// <returns></returns>
        bool CreateZipFile(string zipfile, string dir);

        /// <summary>
        /// 将多个文件添加到一个已经存在的zip包
        /// </summary>
        /// <param name="zipfile">zip文件名</param>
        /// <param name="files">多个文件，数组的每一条指定一个绝对路径文件名(不可重复)</param>
        /// <returns></returns>
        bool AddFileToZip(string zipfile, string[] files);

        /// <summary>
        ///  从一个zip包中删除多个文件
        /// </summary>
        /// <param name="zipfile">zip文件名</param>
        /// <param name="files">要删除的文件名,数组的每一条指定一个文件名(不可重复，只要带扩展名的文件名，不含路径信息)</param>
        /// <returns></returns>
        bool RemoveFileFromZip(string zipfile, string[] files);

        /// <summary>
        /// 解压zip文件中文件到指定目录下
        /// </summary>
        /// <param name="zipfile">zip文件名</param>
        /// <param name="dir">指定一个存在的目录用于存放解压结果</param>
        /// <returns></returns>
        bool ExtractZipFile(string zipfile, string dir);

        /// <summary>
        /// 列出zip包中文件
        /// </summary>
        /// <param name="zipfile">zip文件名</param>
        /// <returns></returns>
        string[] ListZipFile(string zipfile);
    }
}
