using QX_Frame.App.Base;
using QX_Frame.Data.Entities;
using System;
using System.Linq.Expressions;

/**
 * copyright qixiao code builder ->
 * version:4.2.0
 * author:qixiao(柒小)
 * create:2017-08-08 13:38:47
 **/

namespace QX_Frame.Data.QueryObject
{
	/// <summary>
	///class TB_CommentReplyQueryObject
	/// </summary>
	public class TB_CommentReplyQueryObject:WcfQueryObject<DB_QX_Frame_MS_User, TB_CommentReply>
	{
		/// <summary>
		/// construction method
		/// </summary>
		public TB_CommentReplyQueryObject()
		{}

		// PK（identity）  评论Id
		public Guid CommentUid { get;set; }

		// 主题Uid 或 评论Uid
		public Guid TopicUidOrCommentUid { get;set; }

		// 发布者Uid
		public Guid PublisherUid { get;set; }

		// 发布内容
		public String PublishContent { get;set; }

		// 发布时间
		public DateTime PublishTime { get;set; }

		//query condition // null default
		public override Expression<Func<TB_CommentReply, bool>> QueryCondition {get { return base.QueryCondition; } set { base.QueryCondition = value; } }

		//query condition func // true default //if QueryCondition != null this will be override !!!
		protected override Expression<Func<TB_CommentReply, bool>> QueryConditionFunc()
		{
			Expression<Func<TB_CommentReply, bool>> func = t => true;

			if (!string.IsNullOrEmpty(""))
			{
				func = func.And(t => true);
			}

			return func;
		}
	}
}
