using QX_Frame.App.Base;
using QX_Frame.Data.Contract;
using QX_Frame.Data.Entities;

/**
 * copyright qixiao code builder ->
 * version:4.2.0
 * author:qixiao(柒小)
 * create:2017-08-09 12:00:48
 **/

namespace QX_Frame.Data.Service
{
	/// <summary>
	/// class UserRoleNameService
	/// </summary>
	public class UserRoleNameService:WcfService, IUserRoleNameService
	{
		private TB_UserRoleName _TB_UserRoleName;
		/// <summary>
		/// construction method
		/// </summary>
		public UserRoleNameService()
		{}

		public UserRoleNameService(TB_UserRoleName TB_UserRoleName)
		{
			this._TB_UserRoleName = TB_UserRoleName;
		}
		public bool Add(TB_UserRoleName TB_UserRoleName)
		{
			return TB_UserRoleName.Add(TB_UserRoleName);
		}
		public bool Update(TB_UserRoleName TB_UserRoleName)
		{
			return TB_UserRoleName.Update(TB_UserRoleName);
		}
		public bool Delete(TB_UserRoleName TB_UserRoleName)
		{
			return TB_UserRoleName.Delete(TB_UserRoleName);
		}
	}
}
