namespace QX_Frame.Data.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using QX_Frame.Data.Configs;

    public partial class DB_QX_Frame_MS_CMS : DbContext
    {
        public DB_QX_Frame_MS_CMS()
            : base(QX_Frame_Data_Config.ConnectionString_DB_QX_Frame_CMS)
        {
        }

        public virtual DbSet<TB_Book> TB_Book { get; set; }
        public virtual DbSet<TB_Category> TB_Category { get; set; }
        public virtual DbSet<TB_CmsStatus> TB_CmsStatus { get; set; }
        public virtual DbSet<TB_CmsStatusName> TB_CmsStatusName { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TB_Category>()
                .HasMany(e => e.TB_Book)
                .WithRequired(e => e.TB_Category)
                .WillCascadeOnDelete(false);
        }
    }
}
