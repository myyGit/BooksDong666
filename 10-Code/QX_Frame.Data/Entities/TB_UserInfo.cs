namespace QX_Frame.Data.Entities
{
    using QX_Frame.App.Base;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_UserInfo : Entity<DB_QX_Frame_MS_User, TB_UserInfo>
    {
        [Key]
        public Guid UserUid { get; set; }

        [Required]
        [StringLength(20)]
        public string LoginId { get; set; }

        [StringLength(20)]
        public string NickName { get; set; }

        [StringLength(200)]
        public string HeadImageUrl { get; set; }

        public int Age { get; set; }

        public int SexId { get; set; }

        public DateTime? Birthday { get; set; } = DateTime.Now;

        public int BloodTypeId { get; set; }

        [StringLength(50)]
        public string Address { get; set; }

        [StringLength(50)]
        public string Position { get; set; }

        [StringLength(50)]
        public string School { get; set; }

        [StringLength(50)]
        public string Company { get; set; }

        public int ConstellationId { get; set; }

        public int ChineseZodiacId { get; set; }

        [StringLength(50)]
        public string PersonalizedSignature { get; set; }

        [StringLength(200)]
        public string PersonalizedDescription { get; set; }

        public DateTime RegisterTime { get; set; } = DateTime.Now;

        public virtual TB_BloodTypeName TB_BloodTypeName { get; set; }

        public virtual TB_ChineseZodiacName TB_ChineseZodiacName { get; set; }

        public virtual TB_ConstellationName TB_ConstellationName { get; set; }

        public virtual TB_SexName TB_SexName { get; set; }
    }
}
