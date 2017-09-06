using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QX_Frame.Data.Options
{
    public enum opt_CmsStatus:int
    {
        /// <summary>
        /// normal status (default)
        /// </summary>
        NORMAL=1,
        /// <summary>
        /// account stop
        /// </summary>
        DELETE=2,
    }
}
