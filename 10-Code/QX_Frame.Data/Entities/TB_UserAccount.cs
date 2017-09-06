namespace QX_Frame.Data.Entities
{
    using QX_Frame.App.Base;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_UserAccount : Entity<DB_QX_Frame_MS_User, TB_UserAccount>
    {
        [Key]
        public Guid UserUid { get; set; }

        [Required]
        [StringLength(20)]
        public string LoginId { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Tel { get; set; }
    }
}
