using QX_Frame.App.Web;
using QX_Frame.Data.Entities;
using QX_Frame.Data.QueryObject;
using QX_Frame.Data.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QX_Frame.Web.Filter
{
    public class AuthenCheckAttribute : ActionFilterAttribute
    {
        public int LimitCode { get; set; }
        public int DisplayCode { get; set; }
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (filterContext.HttpContext.Session["uid"] != null)
            {
                Guid uid = Guid.Parse(filterContext.HttpContext.Session["uid"].ToString());

                using (var fact= WebControllerBase.Wcf<UserAuthenCodesService>())
                {
                    var channel = fact.CreateChannel();
                    TB_UserAuthenCodes userAuthenCodes = channel.QuerySingle(new TB_UserAuthenCodesQueryObject { QueryCondition = t => t.UserUid == uid }).Cast<TB_UserAuthenCodes>();

                    if (this.LimitCode!=default(int))
                    {
                        string[] limitCodes = userAuthenCodes.UserLimitCodes.Split(',');
                        if (limitCodes.FirstOrDefault(t => t.Equals(this.LimitCode.ToString())) != null)
                        {
                            base.OnActionExecuting(filterContext);
                        }
                        else
                        {
                            filterContext.Result = new ContentResult { Content = "<script>alert('您没有权限！')</script>" };
                        }
                    }

                    if (this.DisplayCode!=default(int))
                    {
                        string[] displayCodes = userAuthenCodes.UserDisplayCodes.Split(',');
                        if (displayCodes.FirstOrDefault(t => t.Equals(this.DisplayCode.ToString())) != null)
                        {
                            base.OnActionExecuting(filterContext);
                        }
                        else
                        {
                            filterContext.Result = new ContentResult { Content = "<script>alert('您没有权限！')</script>" };
                        }
                    }
                }
            }
            else
            {
                filterContext.Result = new ContentResult { Content = "<script>alert('请先登录！');window.location = '/User/Login';</script>" };
                //filterContext.Result = new RedirectResult("/User/Login");
            }
            
        }
    }
}