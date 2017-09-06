using QX_Frame.App.Base;
using QX_Frame.Data.Contract;
using QX_Frame.Data.Entities;

/**
 * copyright qixiao code builder ->
 * version:4.2.0
 * author:qixiao(柒小)
 * create:2017-08-08 13:39:22
 **/

namespace QX_Frame.Data.Service
{
	/// <summary>
	/// class UserInfoService
	/// </summary>
	public class UserInfoService:WcfService, IUserInfoService
	{
		private TB_UserInfo _TB_UserInfo;
		/// <summary>
		/// construction method
		/// </summary>
		public UserInfoService()
		{}

		public UserInfoService(TB_UserInfo TB_UserInfo)
		{
			this._TB_UserInfo = TB_UserInfo;
		}
		public bool Add(TB_UserInfo TB_UserInfo)
		{
			return TB_UserInfo.Add(TB_UserInfo);
		}
		public bool Update(TB_UserInfo TB_UserInfo)
		{
			return TB_UserInfo.Update(TB_UserInfo);
		}
		public bool Delete(TB_UserInfo TB_UserInfo)
		{
			return TB_UserInfo.Delete(TB_UserInfo);
		}
	}
}
