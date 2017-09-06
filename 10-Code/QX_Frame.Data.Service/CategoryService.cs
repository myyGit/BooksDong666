using QX_Frame.App.Base;
using QX_Frame.Data.Contract;
using QX_Frame.Data.Entities;

/**
 * copyright qixiao code builder ->
 * version:4.2.0
 * author:qixiao(柒小)
 * create:2017-08-10 16:13:48
 **/

namespace QX_Frame.Data.Service
{
	/// <summary>
	/// class CategoryService
	/// </summary>
	public class CategoryService:WcfService, ICategoryService
	{
		private TB_Category _TB_Category;
		/// <summary>
		/// construction method
		/// </summary>
		public CategoryService()
		{}

		public CategoryService(TB_Category TB_Category)
		{
			this._TB_Category = TB_Category;
		}
		public bool Add(TB_Category TB_Category)
		{
			return TB_Category.Add(TB_Category);
		}
		public bool Update(TB_Category TB_Category)
		{
			return TB_Category.Update(TB_Category);
		}
		public bool Delete(TB_Category TB_Category)
		{
			return TB_Category.Delete(TB_Category);
		}
	}
}
