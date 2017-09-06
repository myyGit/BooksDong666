using QX_Frame.Data.Entities;

/**
 * copyright qixiao code builder ->
 * version:4.2.0
 * author:qixiao(柒小)
 * create:2017-08-08 13:39:22
 **/

namespace QX_Frame.Data.Contract
{
	/// <summary>
	/// interface IUserInfoService
	/// </summary>
	public interface IUserInfoService
	{
		bool Add(TB_UserInfo TB_UserInfo);
		bool Update(TB_UserInfo TB_UserInfo);
		bool Delete(TB_UserInfo TB_UserInfo);
	}
}
