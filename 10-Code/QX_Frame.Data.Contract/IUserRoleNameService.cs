using QX_Frame.Data.Entities;

/**
 * copyright qixiao code builder ->
 * version:4.2.0
 * author:qixiao(柒小)
 * create:2017-08-09 12:00:48
 **/

namespace QX_Frame.Data.Contract
{
	/// <summary>
	/// interface IUserRoleNameService
	/// </summary>
	public interface IUserRoleNameService
	{
		bool Add(TB_UserRoleName TB_UserRoleName);
		bool Update(TB_UserRoleName TB_UserRoleName);
		bool Delete(TB_UserRoleName TB_UserRoleName);
	}
}
