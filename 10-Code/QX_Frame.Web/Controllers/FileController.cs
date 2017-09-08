using QX_Frame.App.Web;
using QX_Frame.Bantina;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QX_Frame.Web.Controllers
{
    public class FileController : WebControllerBase
    {
        [HttpPost]
        //uploadify是逐次触发Uploadify的，所以每次只有一个文件，不需要foreach，
        public JsonResult Uploadify()
        {
            string folderName = Request["folder"];
            HttpPostedFileBase uploadfile = Request.Files[0];
            if (uploadfile != null && uploadfile.ContentLength > 0)
            {
                var fileName = Path.GetFileName(uploadfile.FileName);
                string folder = Path.Combine(Server.MapPath("~/Uploads/"), folderName);
                var path = Path.Combine(folder, fileName);
                if (!System.IO.Directory.Exists(folder))
                    Directory.CreateDirectory(folder);
                if (System.IO.File.Exists(path))
                    System.IO.File.Delete(path);
                uploadfile.SaveAs(path);
                string returnPath = Path.Combine("/Uploads/", folderName, fileName);
                return OK(returnPath);
            }
            return ERROR("upload faild!");
        }
        /// <summary>
        /// Return Validate Code Iamge
        /// </summary>
        /// <returns></returns>
        public FileContentResult ValidateCodeImage()
        {
            string code = String_Helper_DG.GetRandomString(4); //Code Length is four(4)
            Cache_Helper_DG.Cache_Add("ValidateCode", code); //storage SecurityCode to cache
            return File(Graphic_Helper_DG.CreateValidateGraphic(code), "image/Jpeg");
        }
    }
}