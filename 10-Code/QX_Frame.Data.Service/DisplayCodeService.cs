using QX_Frame.App.Base;
using QX_Frame.Data.Contract;
using QX_Frame.Data.Entities;

/**
 * copyright qixiao code builder ->
 * version:4.2.0
 * author:qixiao(柒小)
 * create:2017-08-08 13:38:55
 **/

namespace QX_Frame.Data.Service
{
	/// <summary>
	/// class DisplayCodeService
	/// </summary>
	public class DisplayCodeService:WcfService, IDisplayCodeService
	{
		private TB_DisplayCode _TB_DisplayCode;
		/// <summary>
		/// construction method
		/// </summary>
		public DisplayCodeService()
		{}

		public DisplayCodeService(TB_DisplayCode TB_DisplayCode)
		{
			this._TB_DisplayCode = TB_DisplayCode;
		}
		public bool Add(TB_DisplayCode TB_DisplayCode)
		{
			return TB_DisplayCode.Add(TB_DisplayCode);
		}
		public bool Update(TB_DisplayCode TB_DisplayCode)
		{
			return TB_DisplayCode.Update(TB_DisplayCode);
		}
		public bool Delete(TB_DisplayCode TB_DisplayCode)
		{
			return TB_DisplayCode.Delete(TB_DisplayCode);
		}
	}
}
