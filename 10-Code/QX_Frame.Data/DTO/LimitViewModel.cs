using QX_Frame.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * author:qixiao
 * create:2017-8-9 14:24:18
 * */
namespace QX_Frame.Data.DTO
{
    public class LimitViewModel
    {
        public UserViewModel UserViewModel { get; set; }
        public List<TB_LimitCode> LimitCodeList { get; set; }
        public List<TB_DisplayCode> DisplayCodeList { get; set; }
    }
}
