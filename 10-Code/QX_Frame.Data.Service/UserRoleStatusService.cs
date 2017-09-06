using QX_Frame.App.Base;
using QX_Frame.Data.Contract;
using QX_Frame.Data.Entities;

/**
 * copyright qixiao code builder ->
 * version:4.2.0
 * author:qixiao(柒小)
 * create:2017-08-09 12:00:40
 **/

namespace QX_Frame.Data.Service
{
	/// <summary>
	/// class UserRoleStatusService
	/// </summary>
	public class UserRoleStatusService:WcfService, IUserRoleStatusService
	{
		private TB_UserRoleStatus _TB_UserRoleStatus;
		/// <summary>
		/// construction method
		/// </summary>
		public UserRoleStatusService()
		{}

		public UserRoleStatusService(TB_UserRoleStatus TB_UserRoleStatus)
		{
			this._TB_UserRoleStatus = TB_UserRoleStatus;
		}
		public bool Add(TB_UserRoleStatus TB_UserRoleStatus)
		{
			return TB_UserRoleStatus.Add(TB_UserRoleStatus);
		}
		public bool Update(TB_UserRoleStatus TB_UserRoleStatus)
		{
			return TB_UserRoleStatus.Update(TB_UserRoleStatus);
		}
		public bool Delete(TB_UserRoleStatus TB_UserRoleStatus)
		{
			return TB_UserRoleStatus.Delete(TB_UserRoleStatus);
		}
	}
}
