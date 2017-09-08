using Microsoft.VisualBasic;
using QX_Frame.App.Web;
using QX_Frame.Data.DTO;
using QX_Frame.Data.Entities;
using QX_Frame.Data.Options;
using QX_Frame.Data.QueryObject;
using QX_Frame.Data.Service;
using QX_Frame.Bantina;
using QX_Frame.Bantina.Extends;
using QX_Frame.Web.Filter;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace QX_Frame.Web.Controllers
{
    public class ArticleController : WebControllerBase
    {
        public ActionResult List()
        {
            int categoryId = Request["categoryId"].ToInt();
            string title = Request["title"];

            using (var fact = Wcf<BookService>())
            {
                var channel = fact.CreateChannel();

                TB_BookQueryObject bookQuery = new TB_BookQueryObject();

                bookQuery.CategoryId = categoryId;
                bookQuery.Title = title;
                if (!string.IsNullOrEmpty(title))
                {
                    bookQuery.NameFan = Strings.StrConv(title, VbStrConv.TraditionalChinese, 0);
                    bookQuery.NameJian = Strings.StrConv(title, VbStrConv.SimplifiedChinese, 0);
                }

                List<TB_Book> bookList = channel.QueryAll(bookQuery).Cast<List<TB_Book>>();

                List<BookViewModel> bookViewList = new List<BookViewModel>();

                foreach (var item in bookList)
                {
                    BookViewModel bookViewModel = new BookViewModel();
                    TB_CmsStatus cmsStatus = channel.QuerySingle(new TB_CmsStatusQueryObject { QueryCondition = t => t.CmsUid == item.BookUid }).Cast<TB_CmsStatus>();
                    int bookStatus = cmsStatus.StatusId;

                    if (bookStatus == opt_CmsStatus.NORMAL.ToInt())
                    {
                        bookViewModel.BookUid = item.BookUid;
                        bookViewModel.Title = item.Title;
                        bookViewModel.Title2 = item.Title2;
                        bookViewModel.Volume = item.Volume;
                        bookViewModel.Dynasty = item.Dynasty;
                        bookViewModel.CategoryId = item.CategoryId;
                        bookViewModel.CategoryName = item.TB_Category?.CategoryName;
                        bookViewModel.Functionary = item.Functionary;
                        bookViewModel.Publisher = item.Publisher;
                        bookViewModel.Version = item.Version;
                        bookViewModel.FromBF49 = item.FromBF49;
                        bookViewModel.FromAF49 = item.FromAF49;
                        bookViewModel.ImageUris = item.ImageUris;
                        bookViewModel.Notice = item.Notice;

                        bookViewList.Add(bookViewModel);
                    }
                }

                return View(bookViewList);
            }
        }
        public ActionResult MuchList()
        {
            int categoryId = Request["categoryId1"].ToInt();
            string title = Request["title1"];
            int categoryId2 = Request["categoryId2"].ToInt();
            string title2 = Request["title2"];

            using (var fact = Wcf<BookService>())
            {
                var channel = fact.CreateChannel();

                TB_BookQueryObject bookQuery = new TB_BookQueryObject();

            bookQuery.CategoryId = categoryId;
            bookQuery.Title = title;
            bookQuery.CategoryId2 = categoryId2;
            bookQuery.Title2 = title2;
            if (!string.IsNullOrEmpty(title))
            {
                bookQuery.NameFan = Strings.StrConv(title, VbStrConv.TraditionalChinese, 0);
                bookQuery.NameJian = Strings.StrConv(title, VbStrConv.SimplifiedChinese, 0);
            }
            if (!string.IsNullOrEmpty(title2))
            {
                bookQuery.NameFan2 = Strings.StrConv(title2, VbStrConv.TraditionalChinese, 0);
                bookQuery.NameJian2 = Strings.StrConv(title2, VbStrConv.SimplifiedChinese, 0);
            }
                List<TB_Book> bookList = channel.QueryAll(bookQuery).Cast<List<TB_Book>>();

                List<BookViewModel> bookViewList = new List<BookViewModel>();

                foreach (var item in bookList)
                {
                    BookViewModel bookViewModel = new BookViewModel();
                    TB_CmsStatus cmsStatus = channel.QuerySingle(new TB_CmsStatusQueryObject { QueryCondition = t => t.CmsUid == item.BookUid }).Cast<TB_CmsStatus>();
                    int bookStatus = cmsStatus.StatusId;

                    if (bookStatus == opt_CmsStatus.NORMAL.ToInt())
                    {
                        bookViewModel.BookUid = item.BookUid;
                        bookViewModel.Title = item.Title;
                        bookViewModel.Title2 = item.Title2;
                        bookViewModel.Volume = item.Volume;
                        bookViewModel.Dynasty = item.Dynasty;
                        bookViewModel.CategoryId = item.CategoryId;
                        bookViewModel.CategoryName = item.TB_Category?.CategoryName;
                        bookViewModel.Functionary = item.Functionary;
                        bookViewModel.Publisher = item.Publisher;
                        bookViewModel.Version = item.Version;
                        bookViewModel.FromBF49 = item.FromBF49;
                        bookViewModel.FromAF49 = item.FromAF49;
                        bookViewModel.ImageUris = item.ImageUris;
                        bookViewModel.Notice = item.Notice;

                        bookViewList.Add(bookViewModel);
                    }
                }

                return View(bookViewList);
            }
        }
        // Detail
        public ActionResult Detail(Guid id)
        {
            using (var fact = Wcf<BookService>())
            {
                var channel = fact.CreateChannel();
                TB_Book book = channel.QuerySingle(new TB_BookQueryObject { QueryCondition = t => t.BookUid == id }).Cast<TB_Book>();

                BookViewModel bookViewModel = new BookViewModel();

                bookViewModel.BookUid = book.BookUid;
                bookViewModel.Title = book.Title;
                bookViewModel.Title2 = book.Title2;
                bookViewModel.Volume = book.Volume;
                bookViewModel.Dynasty = book.Dynasty;
                bookViewModel.CategoryId = book.CategoryId;
                bookViewModel.CategoryName = book.TB_Category.CategoryName;
                bookViewModel.Functionary = book.Functionary;
                bookViewModel.Publisher = book.Publisher;
                bookViewModel.Version = book.Version;
                bookViewModel.FromBF49 = book.FromBF49;
                bookViewModel.FromAF49 = book.FromAF49;
                bookViewModel.ImageUris = book.ImageUris;
                bookViewModel.Notice = book.Notice;

                return View(bookViewModel);
            }
        }

        public ActionResult Read(Guid id)
        {
            using (var fact = Wcf<BookService>())
            {
                var channel = fact.CreateChannel();
                TB_Book book = channel.QuerySingle(new TB_BookQueryObject { QueryCondition = t => t.BookUid == id }).Cast<TB_Book>();

                BookViewModel bookViewModel = new BookViewModel();

                bookViewModel.BookUid = book.BookUid;
                bookViewModel.Title = book.Title;
                bookViewModel.Title2 = book.Title2;
                bookViewModel.Volume = book.Volume;
                bookViewModel.Dynasty = book.Dynasty;
                bookViewModel.CategoryId = book.CategoryId;
                bookViewModel.CategoryName = book.TB_Category.CategoryName;
                bookViewModel.Functionary = book.Functionary;
                bookViewModel.Publisher = book.Publisher;
                bookViewModel.Version = book.Version;
                bookViewModel.FromBF49 = book.FromBF49;
                bookViewModel.FromAF49 = book.FromAF49;
                bookViewModel.ImageUris = book.ImageUris;
                bookViewModel.Notice = book.Notice;

                return View(bookViewModel);
            }
        }

        public JsonResult DownLoadImages(Guid id,string title)
        {
            string dirInput =Path.Combine(Server.MapPath("~/Uploads"),id.ToString());
            string outPutZipFile = Path.Combine(Server.MapPath("~/Uploads/OutPut"), title+".zip");
            string OutPutZipDir = Server.MapPath("~/Uploads/OutPut");

            if (!Directory.Exists(dirInput))
            {
                Directory.CreateDirectory(dirInput);
            }

            IO_Helper_DG.ZipDir(dirInput, outPutZipFile);

            Task_Helper_DG.TaskRun(() =>
            {
                foreach (var item in Directory.GetFiles(OutPutZipDir))
                {
                    if (!item.Equals(outPutZipFile))
                    {
                        System.IO.File.Delete(item);
                    }
                } 
            });

            FileStream fileStream = new FileStream(outPutZipFile, FileMode.Open);
            long fileSize = fileStream.Length;
            byte[] fileBuffer = new byte[fileSize];
            fileStream.Read(fileBuffer, 0, (int)fileSize);
            //如果不写fileStream.Close()语句，用户在下载过程中选择取消，将不能再次下载
            fileStream.Close();

            Response.ContentType = "application/octet-stream";
            Response.AppendHeader("Content-Disposition", "attachment;filename=" + HttpUtility.UrlEncode(title+".zip", Encoding.UTF8));
            Response.AddHeader("Content-Length", fileSize.ToString());
            
            Response.BinaryWrite(fileBuffer);
            Response.End();
            Response.Close();

            return OK("download success");
        }

        
    }
}