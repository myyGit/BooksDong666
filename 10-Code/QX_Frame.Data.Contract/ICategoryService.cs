using QX_Frame.Data.Entities;

/**
 * copyright qixiao code builder ->
 * version:4.2.0
 * author:qixiao(柒小)
 * create:2017-08-10 16:13:48
 **/

namespace QX_Frame.Data.Contract
{
	/// <summary>
	/// interface ICategoryService
	/// </summary>
	public interface ICategoryService
	{
		bool Add(TB_Category TB_Category);
		bool Update(TB_Category TB_Category);
		bool Delete(TB_Category TB_Category);
	}
}
