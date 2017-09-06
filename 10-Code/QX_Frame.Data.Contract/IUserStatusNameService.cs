using QX_Frame.Data.Entities;

/**
 * copyright qixiao code builder ->
 * version:4.2.0
 * author:qixiao(柒小)
 * create:2017-08-09 12:00:44
 **/

namespace QX_Frame.Data.Contract
{
	/// <summary>
	/// interface IUserStatusNameService
	/// </summary>
	public interface IUserStatusNameService
	{
		bool Add(TB_UserStatusName TB_UserStatusName);
		bool Update(TB_UserStatusName TB_UserStatusName);
		bool Delete(TB_UserStatusName TB_UserStatusName);
	}
}
