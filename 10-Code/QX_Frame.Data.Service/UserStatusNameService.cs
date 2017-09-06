using QX_Frame.App.Base;
using QX_Frame.Data.Contract;
using QX_Frame.Data.Entities;

/**
 * copyright qixiao code builder ->
 * version:4.2.0
 * author:qixiao(柒小)
 * create:2017-08-09 12:00:44
 **/

namespace QX_Frame.Data.Service
{
	/// <summary>
	/// class UserStatusNameService
	/// </summary>
	public class UserStatusNameService:WcfService, IUserStatusNameService
	{
		private TB_UserStatusName _TB_UserStatusName;
		/// <summary>
		/// construction method
		/// </summary>
		public UserStatusNameService()
		{}

		public UserStatusNameService(TB_UserStatusName TB_UserStatusName)
		{
			this._TB_UserStatusName = TB_UserStatusName;
		}
		public bool Add(TB_UserStatusName TB_UserStatusName)
		{
			return TB_UserStatusName.Add(TB_UserStatusName);
		}
		public bool Update(TB_UserStatusName TB_UserStatusName)
		{
			return TB_UserStatusName.Update(TB_UserStatusName);
		}
		public bool Delete(TB_UserStatusName TB_UserStatusName)
		{
			return TB_UserStatusName.Delete(TB_UserStatusName);
		}
	}
}
