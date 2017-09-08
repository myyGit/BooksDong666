/*********************************************************
 * CopyRight: QIXIAO CODE BUILDER. 
 * Version:4.2.0
 * Author:qixiao(柒小)
 * Create:2017-09-07 15:40:58
 * Update:2017-09-07 15:40:58
 * E-mail: dong@qixiao.me | wd8622088@foxmail.com 
 * GitHub: https://github.com/dong666 
 * Personal web site: http://qixiao.me 
 * Technical WebSit: http://www.cnblogs.com/qixiaoyizhan/ 
 * Description:
 * Thx , Best Regards ~
 *********************************************************/

using System;
using QX_Frame.App.Base;
using QX_Frame.Bantina.Bankinate;

namespace QX_Frame.Data.Entities
{
	/// <summary>
	/// public class TB_CommentReply
	/// </summary>
	[Serializable]
	[Table(TableName = "TB_CommentReply")]
	public class TB_CommentReply: Entity<DB_QX_Frame_MS_User, TB_CommentReply>
	{
		/// <summary>
		/// construction method
		/// </summary>
		public TB_CommentReply(){}

		// PK（identity）  评论Id
		[Key]
		public Guid CommentUid { get;set; }
		// 主题Uid 或 评论Uid
		[Column]
		public Guid TopicUidOrCommentUid { get;set; }
		// 发布者Uid
		[Column]
		public Guid PublisherUid { get;set; }
		// 发布内容
		[Column]
		public String PublishContent { get;set; }
		// 发布时间
		[Column]
		public DateTime PublishTime { get;set; }
	}
}
