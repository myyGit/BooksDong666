using QX_Frame.App.Base;
using QX_Frame.Data.Contract;
using QX_Frame.Data.Entities;

/**
 * copyright qixiao code builder ->
 * version:4.2.0
 * author:qixiao(柒小)
 * create:2017-08-08 13:39:13
 **/

namespace QX_Frame.Data.Service
{
	/// <summary>
	/// class UserAuthenCodesService
	/// </summary>
	public class UserAuthenCodesService:WcfService, IUserAuthenCodesService
	{
		private TB_UserAuthenCodes _TB_UserAuthenCodes;
		/// <summary>
		/// construction method
		/// </summary>
		public UserAuthenCodesService()
		{}

		public UserAuthenCodesService(TB_UserAuthenCodes TB_UserAuthenCodes)
		{
			this._TB_UserAuthenCodes = TB_UserAuthenCodes;
		}
		public bool Add(TB_UserAuthenCodes TB_UserAuthenCodes)
		{
			return TB_UserAuthenCodes.Add(TB_UserAuthenCodes);
		}
		public bool Update(TB_UserAuthenCodes TB_UserAuthenCodes)
		{
			return TB_UserAuthenCodes.Update(TB_UserAuthenCodes);
		}
		public bool Delete(TB_UserAuthenCodes TB_UserAuthenCodes)
		{
			return TB_UserAuthenCodes.Delete(TB_UserAuthenCodes);
		}
	}
}
