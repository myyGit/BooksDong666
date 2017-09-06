using QX_Frame.App.Base;
using QX_Frame.Data.Contract;
using QX_Frame.Data.Entities;

/**
 * copyright qixiao code builder ->
 * version:4.2.0
 * author:qixiao(柒小)
 * create:2017-08-08 13:39:09
 **/

namespace QX_Frame.Data.Service
{
	/// <summary>
	/// class UserAccountService
	/// </summary>
	public class UserAccountService:WcfService, IUserAccountService
	{
		private TB_UserAccount _TB_UserAccount;
		/// <summary>
		/// construction method
		/// </summary>
		public UserAccountService()
		{}

		public UserAccountService(TB_UserAccount TB_UserAccount)
		{
			this._TB_UserAccount = TB_UserAccount;
		}
		public bool Add(TB_UserAccount TB_UserAccount)
		{
			return TB_UserAccount.Add(TB_UserAccount);
		}
		public bool Update(TB_UserAccount TB_UserAccount)
		{
			return TB_UserAccount.Update(TB_UserAccount);
		}
		public bool Delete(TB_UserAccount TB_UserAccount)
		{
			return TB_UserAccount.Delete(TB_UserAccount);
		}
	}
}
