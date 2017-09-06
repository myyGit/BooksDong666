using QX_Frame.App.Base;
using QX_Frame.Data.Contract;
using QX_Frame.Data.Entities;

/**
 * copyright qixiao code builder ->
 * version:4.2.0
 * author:qixiao(柒小)
 * create:2017-08-08 13:39:02
 **/

namespace QX_Frame.Data.Service
{
	/// <summary>
	/// class LimitCodeService
	/// </summary>
	public class LimitCodeService:WcfService, ILimitCodeService
	{
		private TB_LimitCode _TB_LimitCode;
		/// <summary>
		/// construction method
		/// </summary>
		public LimitCodeService()
		{}

		public LimitCodeService(TB_LimitCode TB_LimitCode)
		{
			this._TB_LimitCode = TB_LimitCode;
		}
		public bool Add(TB_LimitCode TB_LimitCode)
		{
			return TB_LimitCode.Add(TB_LimitCode);
		}
		public bool Update(TB_LimitCode TB_LimitCode)
		{
			return TB_LimitCode.Update(TB_LimitCode);
		}
		public bool Delete(TB_LimitCode TB_LimitCode)
		{
			return TB_LimitCode.Delete(TB_LimitCode);
		}
	}
}
