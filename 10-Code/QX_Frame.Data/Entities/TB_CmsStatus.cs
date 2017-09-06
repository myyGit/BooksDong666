namespace QX_Frame.Data.Entities
{
    using QX_Frame.App.Base;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_CmsStatus : Entity<DB_QX_Frame_MS_CMS, TB_Book>
    {
        [Key]
        public Guid CmsUid { get; set; }

        public int StatusId { get; set; }
    }
}
