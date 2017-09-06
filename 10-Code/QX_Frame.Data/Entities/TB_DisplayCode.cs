namespace QX_Frame.Data.Entities
{
    using QX_Frame.App.Base;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_DisplayCode : Entity<DB_QX_Frame_MS_User, TB_DisplayCode>
    {
        [Key]
        public int DisplayCode { get; set; }

        [Required]
        [StringLength(50)]
        public string DisplayDescription { get; set; }
    }
}
