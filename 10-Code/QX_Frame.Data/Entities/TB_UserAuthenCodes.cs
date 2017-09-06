namespace QX_Frame.Data.Entities
{
    using QX_Frame.App.Base;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_UserAuthenCodes : Entity<DB_QX_Frame_MS_User, TB_UserAuthenCodes>
    {
        [Key]
        public Guid UserUid { get; set; }

        [StringLength(1000)]
        public string UserDisplayCodes { get; set; }

        [StringLength(1000)]
        public string UserLimitCodes { get; set; }
    }
}
