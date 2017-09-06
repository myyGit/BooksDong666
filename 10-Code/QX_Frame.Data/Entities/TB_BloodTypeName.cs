namespace QX_Frame.Data.Entities
{
    using QX_Frame.App.Base;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_BloodTypeName:Entity<DB_QX_Frame_MS_User, TB_BloodTypeName>
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_BloodTypeName()
        {
            TB_UserInfo = new HashSet<TB_UserInfo>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BloodTypeId { get; set; }

        [Required]
        [StringLength(2)]
        public string BloodTypeName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_UserInfo> TB_UserInfo { get; set; }
    }
}