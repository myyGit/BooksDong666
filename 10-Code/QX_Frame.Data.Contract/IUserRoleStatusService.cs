using QX_Frame.Data.Entities;

/**
 * copyright qixiao code builder ->
 * version:4.2.0
 * author:qixiao(柒小)
 * create:2017-08-09 12:00:40
 **/

namespace QX_Frame.Data.Contract
{
	/// <summary>
	/// interface IUserRoleStatusService
	/// </summary>
	public interface IUserRoleStatusService
	{
		bool Add(TB_UserRoleStatus TB_UserRoleStatus);
		bool Update(TB_UserRoleStatus TB_UserRoleStatus);
		bool Delete(TB_UserRoleStatus TB_UserRoleStatus);
	}
}
