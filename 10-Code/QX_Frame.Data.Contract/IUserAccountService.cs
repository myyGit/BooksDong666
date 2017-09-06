using QX_Frame.Data.Entities;

/**
 * copyright qixiao code builder ->
 * version:4.2.0
 * author:qixiao(柒小)
 * create:2017-08-08 13:39:09
 **/

namespace QX_Frame.Data.Contract
{
	/// <summary>
	/// interface IUserAccountService
	/// </summary>
	public interface IUserAccountService
	{
		bool Add(TB_UserAccount TB_UserAccount);
		bool Update(TB_UserAccount TB_UserAccount);
		bool Delete(TB_UserAccount TB_UserAccount);
	}
}
