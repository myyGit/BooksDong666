using QX_Frame.App.Web;
using QX_Frame.Data.Service;

/**
 * author:qixiao 
 * create：2017-2-21 14:21:41
 **/
namespace QX_Frame.Web.Config
{
    //class registers
    public class ClassRegisters : WebControllerBase
    {
        public ClassRegisters()
        {
            //register region --
            WebControllerBase.Register(c => new BloodTypeNameService());
            WebControllerBase.Register(c => new BookService());
            WebControllerBase.Register(c => new CategoryService());
            WebControllerBase.Register(c => new ChineseZodiacNameService());
            WebControllerBase.Register(c => new CommentReplyService());
            WebControllerBase.Register(c => new ConstellationNameService());
            WebControllerBase.Register(c => new DisplayCodeService());
            WebControllerBase.Register(c => new LimitCodeService());
            WebControllerBase.Register(c => new SexNameService());
            WebControllerBase.Register(c => new UserAccountService());
            WebControllerBase.Register(c => new UserAuthenCodesService());
            WebControllerBase.Register(c => new UserInfoService());
            WebControllerBase.Register(c => new UserRoleStatusService());
            WebControllerBase.Register(c => new UserRoleStatusService());
            WebControllerBase.Register(c => new CmsStatusNameService());
            WebControllerBase.Register(c => new CmsStatusService());



            //end register region --
            WebControllerBase.RegisterComplex();
        }
    }
}