using QX_Frame.Data.Entities;

/**
 * copyright qixiao code builder ->
 * version:4.2.0
 * author:qixiao(柒小)
 * create:2017-08-11 15:37:25
 **/

namespace QX_Frame.Data.Contract
{
	/// <summary>
	/// interface ICmsStatusNameService
	/// </summary>
	public interface ICmsStatusNameService
	{
		bool Add(TB_CmsStatusName TB_CmsStatusName);
		bool Update(TB_CmsStatusName TB_CmsStatusName);
		bool Delete(TB_CmsStatusName TB_CmsStatusName);
	}
}
