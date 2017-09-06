using QX_Frame.App.Base;
using QX_Frame.Data.Contract;
using QX_Frame.Data.Entities;

/**
 * copyright qixiao code builder ->
 * version:4.2.0
 * author:qixiao(柒小)
 * create:2017-08-08 13:38:47
 **/

namespace QX_Frame.Data.Service
{
	/// <summary>
	/// class CommentReplyService
	/// </summary>
	public class CommentReplyService:WcfService, ICommentReplyService
	{
		private TB_CommentReply _TB_CommentReply;
		/// <summary>
		/// construction method
		/// </summary>
		public CommentReplyService()
		{}

		public CommentReplyService(TB_CommentReply TB_CommentReply)
		{
			this._TB_CommentReply = TB_CommentReply;
		}
		public bool Add(TB_CommentReply TB_CommentReply)
		{
			return TB_CommentReply.Add(TB_CommentReply);
		}
		public bool Update(TB_CommentReply TB_CommentReply)
		{
			return TB_CommentReply.Update(TB_CommentReply);
		}
		public bool Delete(TB_CommentReply TB_CommentReply)
		{
			return TB_CommentReply.Delete(TB_CommentReply);
		}
	}
}
