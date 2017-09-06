namespace QX_Frame.Data.Entities
{
    using QX_Frame.App.Base;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Book:Entity<DB_QX_Frame_MS_CMS, TB_Book>
    {
        [Key]
        public Guid BookUid { get; set; } = Guid.NewGuid();

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [StringLength(50)]
        public string Title2 { get; set; }

        public int Volume { get; set; }

        [StringLength(10)]
        public string Dynasty { get; set; }

        public int CategoryId { get; set; }

        [StringLength(20)]
        public string Functionary { get; set; }

        [StringLength(20)]
        public string Publisher { get; set; }

        [StringLength(20)]
        public string Version { get; set; }

        [StringLength(50)]
        public string FromBF49 { get; set; }

        [StringLength(50)]
        public string FromAF49 { get; set; }

        [StringLength(2000)]
        public string ImageUris { get; set; } = "";

        [StringLength(200)]
        public string Notice { get; set; }

        public virtual TB_Category TB_Category { get; set; }
    }
}
