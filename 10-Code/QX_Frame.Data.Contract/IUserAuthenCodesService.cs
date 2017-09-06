using QX_Frame.Data.Entities;

/**
 * copyright qixiao code builder ->
 * version:4.2.0
 * author:qixiao(柒小)
 * create:2017-08-08 13:39:13
 **/

namespace QX_Frame.Data.Contract
{
	/// <summary>
	/// interface IUserAuthenCodesService
	/// </summary>
	public interface IUserAuthenCodesService
	{
		bool Add(TB_UserAuthenCodes TB_UserAuthenCodes);
		bool Update(TB_UserAuthenCodes TB_UserAuthenCodes);
		bool Delete(TB_UserAuthenCodes TB_UserAuthenCodes);
	}
}
