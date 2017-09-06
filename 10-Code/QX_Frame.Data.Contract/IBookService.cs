using QX_Frame.Data.Entities;

/**
 * copyright qixiao code builder ->
 * version:4.2.0
 * author:qixiao(柒小)
 * create:2017-08-10 16:13:46
 **/

namespace QX_Frame.Data.Contract
{
	/// <summary>
	/// interface IBookService
	/// </summary>
	public interface IBookService
	{
		bool Add(TB_Book TB_Book);
		bool Update(TB_Book TB_Book);
		bool Delete(TB_Book TB_Book);
	}
}
