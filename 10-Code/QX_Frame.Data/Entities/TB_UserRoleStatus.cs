namespace QX_Frame.Data.Entities
{
    using QX_Frame.App.Base;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_UserRoleStatus : Entity<DB_QX_Frame_MS_User, TB_UserRoleStatus>
    {
        [Key]
        public Guid UserUid { get; set; }

        public int RoleId { get; set; }

        public int StatusId { get; set; }

        public virtual TB_UserRoleName TB_UserRoleName { get; set; }

        public virtual TB_UserStatusName TB_UserStatusName { get; set; }
    }
}
