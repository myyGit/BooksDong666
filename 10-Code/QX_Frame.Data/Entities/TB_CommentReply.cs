namespace QX_Frame.Data.Entities
{
    using QX_Frame.App.Base;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_CommentReply : Entity<DB_QX_Frame_MS_User, TB_CommentReply>
    {
        [Key]
        public Guid CommentUid { get; set; }

        public Guid TopicUidOrCommentUid { get; set; }

        public Guid PublisherUid { get; set; }

        [Required]
        [StringLength(500)]
        public string PublishContent { get; set; }

        public DateTime PublishTime { get; set; }
    }
}
