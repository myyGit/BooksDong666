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
using System.Linq;
using System.Web;
using System.Web.Mvc;

/**
 * author:qixiao
 * create:2017-8-3 10:24:39
 * */
namespace QX_Frame.Web.Controllers
{
    public class UserController : App.Web.WebControllerBase
    {
        // Login
        public ActionResult Login() => View();

        // Register
        public ActionResult Register() => View();

        // Detail/id
        [AuthenCheckAttribute(LimitCode = 0)]
        public ActionResult Detail(Guid id)
        {
            using (var fact = Wcf<UserAccountService>())
            {
                var channel = fact.CreateChannel();
                TB_UserInfo userInfo = channel.QuerySingle(new TB_UserInfoQueryObject { QueryCondition = t => t.UserUid == id }).Cast<TB_UserInfo>();
                TB_UserAuthenCodes userAuthenCodes = channel.QuerySingle(new TB_UserAuthenCodesQueryObject { QueryCondition = t => t.UserUid == id }).Cast<TB_UserAuthenCodes>();

                UserViewModel userViewModel = new UserViewModel();
                userViewModel.UserUid = id;
                userViewModel.LoginId = userInfo?.LoginId;
                userViewModel.Name = userInfo?.NickName;
                userViewModel.LimitCode = userAuthenCodes?.UserLimitCodes;
                return View(userViewModel);
            }
        }

      
        [AuthenCheckAttribute(LimitCode = 1015)]
        public ActionResult ReDeleteDeal(Guid id)
        {
            using (var fact = Wcf<UserRoleStatusService>())
            {
                var channel = fact.CreateChannel();
                TB_UserRoleStatus userRoleStatus = channel.QuerySingle(new TB_UserRoleStatusQueryObject { QueryCondition = t => t.UserUid == id }).Cast<TB_UserRoleStatus>();
                userRoleStatus.StatusId = opt_UserStatus.NORMAL.ToInt();
                if (channel.Update(userRoleStatus))
                {
                    return OK("恢复成功！");
                }
                else
                {
                    return ERROR("恢复失败！");
                }
            }
        }

        // Limit Magemen
        [AuthenCheckAttribute(LimitCode = 1016)]
        public ActionResult LimitMgmt(Guid id)
        {
            using (var fact = Wcf<UserAccountService>())
            {
                var channel = fact.CreateChannel();
                TB_UserInfo userInfo = channel.QuerySingle(new TB_UserInfoQueryObject { QueryCondition = t => t.UserUid == id }).Cast<TB_UserInfo>();
                TB_UserAuthenCodes userAuthenCodes = channel.QuerySingle(new TB_UserAuthenCodesQueryObject { QueryCondition = t => t.UserUid == id }).Cast<TB_UserAuthenCodes>();

                UserViewModel userViewModel = new UserViewModel();
                userViewModel.UserUid = id;
                userViewModel.LoginId = userInfo?.LoginId;
                userViewModel.Name = userInfo?.NickName;
                userViewModel.LimitCode = userAuthenCodes?.UserLimitCodes;
                userViewModel.DisplayCode = userAuthenCodes?.UserDisplayCodes;

                LimitViewModel limitViewModel = new LimitViewModel();
                limitViewModel.UserViewModel = userViewModel;
                limitViewModel.LimitCodeList = channel.QueryAll(new TB_LimitCodeQueryObject()).Cast<List<TB_LimitCode>>();
                limitViewModel.DisplayCodeList = channel.QueryAll(new TB_DisplayCodeQueryObject()).Cast<List<TB_DisplayCode>>();

                return View(limitViewModel);
            }
        }

        // Limit Update
        [AuthenCheckAttribute(LimitCode = 1016)]
        public ActionResult LimitUpdate(Guid id)
        {
            string limitCode = Request["limitCode"];
            string displayCode = Request["displayCode"];

            using (var fact = Wcf<UserAuthenCodesService>())
            {
                var channel = fact.CreateChannel();
                TB_UserAuthenCodes userAuthenCodes = channel.QuerySingle(new TB_UserAuthenCodesQueryObject { QueryCondition = t => t.UserUid == id }).Cast<TB_UserAuthenCodes>();
                userAuthenCodes.UserLimitCodes = limitCode;
                userAuthenCodes.UserDisplayCodes = displayCode;

                if (channel.Update(userAuthenCodes))
                {
                    return OK("修改成功！");
                }
                else
                {
                    return ERROR("修改失败！");
                }
            }
        }

        [HttpPost]
        public ActionResult LoginDeal()
        {
            try
            {
                string account = Request["account"];
                string password = Request["password"];
                string validateCode = Request["validateCode"];
                int online = Request["online"].ToInt();

                if (!Cache_Helper_DG.Cache_Get("ValidateCode").ToString().ToUpper().Equals(validateCode.ToUpper()))
                {
                    return ERROR("验证码错误！");
                }

                using (var fact = Wcf<UserAccountService>())
                {
                    var channel = fact.CreateChannel();
                    TB_UserAccount userAccount = channel.QuerySingle(new TB_UserAccountQueryObject { QueryCondition = t => t.LoginId.Equals(account) }).Cast<TB_UserAccount>();
                    if (userAccount != null)
                    {
                        if (userAccount.Password.Equals(Encrypt_Helper_DG.MD5_Encrypt(password)))
                        {
                            Session["uid"] = userAccount.UserUid;
                            Session["loginId"] = userAccount.LoginId;
                            if (online == 1)
                            {
                                Cookie_Helper_DG.Add("loginId", userAccount.LoginId, DateTime.Now.AddDays(1));
                                Cookie_Helper_DG.Add("uid", userAccount.UserUid.ToString(), DateTime.Now.AddDays(1));
                            }
                            return OK("登录成功！");
                        }
                    }
                    return ERROR("账号或密码错误！");
                }
            }
            catch (Exception ex)
            {
                return ERROR(ex.ToString(), 0, 0, System.Net.HttpStatusCode.InternalServerError);
            }
        }

        public ActionResult LoginOut()
        {
            Session.Remove("uid");
            Session.Remove("loginId");
            return Redirect("/User/Login");
        }
    }
}