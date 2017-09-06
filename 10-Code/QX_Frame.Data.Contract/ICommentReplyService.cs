using QX_Frame.Data.Entities;

/**
 * copyright qixiao code builder ->
 * version:4.2.0
 * author:qixiao(柒小)
 * create:2017-08-08 13:38:47
 **/

namespace QX_Frame.Data.Contract
{
	/// <summary>
	/// interface ICommentReplyService
	/// </summary>
	public interface ICommentReplyService
	{
		bool Add(TB_CommentReply TB_CommentReply);
		bool Update(TB_CommentReply TB_CommentReply);
		bool Delete(TB_CommentReply TB_CommentReply);
	}
}
