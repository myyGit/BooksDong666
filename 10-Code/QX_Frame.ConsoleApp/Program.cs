using Autofac;
using QX_Frame.App.Base;
using QX_Frame.Data.Contract;
using QX_Frame.Data.Entities;
using QX_Frame.Data.QueryObject;
using QX_Frame.Data.Service;
using QX_Frame.Bantina;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QX_Frame.App.Base.AOP;
using System.Data;
using QX_Frame.App.Base.Options;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Data.Entity;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;

namespace QX_Frame.ConsoleApp
{
    class Program : AppBase
    {
        static void Main(string[] args)
        {
            #region Wcf Test
            new Config.ClassRegisters();   //register classes
            new Config.ConfigBootStrap();

            using (var fact = Wcf<UserAccountService>())
            {
                var channel = fact.CreateChannel();
                List<TB_UserAccount> userAccountList = channel.QueryAll(new TB_UserAccountQueryObject()).Cast<List<TB_UserAccount>>();
                foreach (var item in userAccountList)
                {
                    Console.WriteLine($"Uid = {item.UserUid} , loginId = {item.LoginId}");
                }
            }

            #endregion

            #region 繁体字和简体字转换 法2
            //string value = "刘备乃中山镜王之后";
            //string newValue = Two.StringConvert(value, "1");
            //if (!string.IsNullOrEmpty(newValue))
            //{
            //    Console.WriteLine(newValue);
            //}
            //string value2 = "发财";
            //string newValue2 = Two.StringConvert(value2, "1");
            //if (!string.IsNullOrEmpty(newValue2))
            //{
            //    Console.WriteLine(newValue2);
            //}
            //string value3 = "头发";
            //string newValue3 = Two.StringConvert(value3, "1");
            //if (!string.IsNullOrEmpty(newValue3))
            //{
            //    Console.WriteLine(newValue3);
            //}
            //string value31 = "后面";
            //string newValue31 = Two.StringConvert(value31, "1");
            //if (!string.IsNullOrEmpty(newValue31))
            //{
            //    Console.WriteLine(newValue31);
            //}
            //string value1 = "媽一這是一段蕑體字";
            //string newValue1 = Two.StringConvert(value1, "2");
            //if (!string.IsNullOrEmpty(newValue1))
            //{
            //    Console.WriteLine(newValue1);
            //}
            #endregion

            //string filePath = "importExcel.xlsx";

            //DataTable table = Office_Helper_DG.ImportExceltoDt(filePath, 0, 0);

            Console.WriteLine("any key to exit ...");
            Console.ReadKey();
        }
       
     
    }
     
    /// <summary>
    /// 中文字符工具类
    /// </summary>
    public static class ChineseStringUtility
    {
        private const int LOCALE_SYSTEM_DEFAULT = 0x0800;
        private const int LCMAP_SIMPLIFIED_CHINESE = 0x02000000;
        private const int LCMAP_TRADITIONAL_CHINESE = 0x04000000;

        [DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int LCMapString(int Locale, int dwMapFlags, string lpSrcStr, int cchSrc, [Out] string lpDestStr, int cchDest);

        /// <summary>
        /// 将字符转换成简体中文
        /// </summary>
        /// <param name="source">输入要转换的字符串</param>
        /// <returns>转换完成后的字符串</returns>
        public static string ToSimplified(string source)
        {
            String target = new String(' ', source.Length);
            int ret = LCMapString(LOCALE_SYSTEM_DEFAULT, LCMAP_SIMPLIFIED_CHINESE, source, source.Length, target, source.Length);
            return target;
        }

        /// <summary>
        /// 将字符转换为繁体中文
        /// </summary>
        /// <param name="source">输入要转换的字符串</param>
        /// <returns>转换完成后的字符串</returns>
        public static string ToTraditional(string source)
        {
            String target = new String(' ', source.Length);
            int ret = LCMapString(LOCALE_SYSTEM_DEFAULT, LCMAP_TRADITIONAL_CHINESE, source, source.Length, target, source.Length);
            return target;
        }
    
     
 
    }
    public class Two
    {
        public static string StringConvert(string x, string type)
         {
            String value = String.Empty;
             switch (type)
             {
                 case "1"://转繁体
                     value =  Strings.StrConv(x, VbStrConv.TraditionalChinese,0);
                     break;
                 case "2":
                     value = Strings.StrConv(x, VbStrConv.SimplifiedChinese, 0);
                     break;
                 default:
                     break;
             }
             return value;
         }
    }
    
}
