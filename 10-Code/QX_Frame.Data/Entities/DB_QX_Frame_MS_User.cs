namespace QX_Frame.Data.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using QX_Frame.Data.Configs;

    public partial class DB_QX_Frame_MS_User : DbContext
    {
        public DB_QX_Frame_MS_User()
            : base(QX_Frame_Data_Config.ConnectionString_DB_QX_Frame_User)
        {
        }

        public virtual DbSet<TB_BloodTypeName> TB_BloodTypeName { get; set; }
        public virtual DbSet<TB_ChineseZodiacName> TB_ChineseZodiacName { get; set; }
        public virtual DbSet<TB_CommentReply> TB_CommentReply { get; set; }
        public virtual DbSet<TB_ConstellationName> TB_ConstellationName { get; set; }
        public virtual DbSet<TB_DisplayCode> TB_DisplayCode { get; set; }
        public virtual DbSet<TB_LimitCode> TB_LimitCode { get; set; }
        public virtual DbSet<TB_SexName> TB_SexName { get; set; }
        public virtual DbSet<TB_UserAccount> TB_UserAccount { get; set; }
        public virtual DbSet<TB_UserAuthenCodes> TB_UserAuthenCodes { get; set; }
        public virtual DbSet<TB_UserInfo> TB_UserInfo { get; set; }
        public virtual DbSet<TB_UserRoleName> TB_UserRoleName { get; set; }
        public virtual DbSet<TB_UserRoleStatus> TB_UserRoleStatus { get; set; }
        public virtual DbSet<TB_UserStatusName> TB_UserStatusName { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TB_BloodTypeName>()
                .HasMany(e => e.TB_UserInfo)
                .WithRequired(e => e.TB_BloodTypeName)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TB_ChineseZodiacName>()
                .HasMany(e => e.TB_UserInfo)
                .WithRequired(e => e.TB_ChineseZodiacName)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TB_ConstellationName>()
                .HasMany(e => e.TB_UserInfo)
                .WithRequired(e => e.TB_ConstellationName)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TB_SexName>()
                .HasMany(e => e.TB_UserInfo)
                .WithRequired(e => e.TB_SexName)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TB_UserRoleName>()
                .HasMany(e => e.TB_UserRoleStatus)
                .WithRequired(e => e.TB_UserRoleName)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TB_UserStatusName>()
                .HasMany(e => e.TB_UserRoleStatus)
                .WithRequired(e => e.TB_UserStatusName)
                .WillCascadeOnDelete(false);
        }
    }
}
