using QX_Frame.App.Base;
using QX_Frame.Data.Contract;
using QX_Frame.Data.Entities;

/**
 * copyright qixiao code builder ->
 * version:4.2.0
 * author:qixiao(柒小)
 * create:2017-08-10 16:13:46
 **/

namespace QX_Frame.Data.Service
{
	/// <summary>
	/// class BookService
	/// </summary>
	public class BookService:WcfService, IBookService
	{
		private TB_Book _TB_Book;
		/// <summary>
		/// construction method
		/// </summary>
		public BookService()
		{}

		public BookService(TB_Book TB_Book)
		{
			this._TB_Book = TB_Book;
		}
		public bool Add(TB_Book TB_Book)
		{
			return TB_Book.Add(TB_Book);
		}
		public bool Update(TB_Book TB_Book)
		{
			return TB_Book.Update(TB_Book);
		}
		public bool Delete(TB_Book TB_Book)
		{
			return TB_Book.Delete(TB_Book);
		}
	}
}
