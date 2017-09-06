using QX_Frame.Data.Entities;

/**
 * copyright qixiao code builder ->
 * version:4.2.0
 * author:qixiao(柒小)
 * create:2017-08-11 15:37:23
 **/

namespace QX_Frame.Data.Contract
{
	/// <summary>
	/// interface ICmsStatusService
	/// </summary>
	public interface ICmsStatusService
	{
		bool Add(TB_CmsStatus TB_CmsStatus);
		bool Update(TB_CmsStatus TB_CmsStatus);
		bool Delete(TB_CmsStatus TB_CmsStatus);
	}
}
