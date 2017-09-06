using QX_Frame.App.Base;
using QX_Frame.Data.Service;
//using QX_Frame.Data.Service.QX_Frame;

namespace QX_Frame.ConsoleApp.Config
{
    /**
     * author:qixiao
     * time:2017-2-21 14:48:28
     **/
    public class ClassRegisters : AppBase
    {
        public ClassRegisters()
        {
            //register region --
            //AppBase.Register(c => new QX_Frame.Helper_DG.Service.RabbitMQ_Service_DG());
            AppBase.Register(c => new BloodTypeNameService());
            AppBase.Register(c => new BookService());
            AppBase.Register(c => new CategoryService());
            AppBase.Register(c => new ChineseZodiacNameService());
            AppBase.Register(c => new CommentReplyService());
            AppBase.Register(c => new ConstellationNameService());
            AppBase.Register(c => new DisplayCodeService());
            AppBase.Register(c => new LimitCodeService());
            AppBase.Register(c => new SexNameService());
            AppBase.Register(c => new UserAccountService());
            AppBase.Register(c => new UserAuthenCodesService());
            AppBase.Register(c => new UserInfoService());
            AppBase.Register(c => new UserRoleStatusService());
            AppBase.Register(c => new UserRoleStatusService());
            AppBase.Register(c => new CmsStatusNameService());
            AppBase.Register(c => new CmsStatusService());



            //end register region --
            AppBase.RegisterComplex();
        }
    }
}
