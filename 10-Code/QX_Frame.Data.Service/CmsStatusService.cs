using QX_Frame.App.Base;
using QX_Frame.Data.Contract;
using QX_Frame.Data.Entities;

/**
 * copyright qixiao code builder ->
 * version:4.2.0
 * author:qixiao(柒小)
 * create:2017-08-11 15:37:23
 **/

namespace QX_Frame.Data.Service
{
	/// <summary>
	/// class CmsStatusService
	/// </summary>
	public class CmsStatusService:WcfService, ICmsStatusService
	{
		private TB_CmsStatus _TB_CmsStatus;
		/// <summary>
		/// construction method
		/// </summary>
		public CmsStatusService()
		{}

		public CmsStatusService(TB_CmsStatus TB_CmsStatus)
		{
			this._TB_CmsStatus = TB_CmsStatus;
		}
		public bool Add(TB_CmsStatus TB_CmsStatus)
		{
			return TB_CmsStatus.Add(TB_CmsStatus);
		}
		public bool Update(TB_CmsStatus TB_CmsStatus)
		{
			return TB_CmsStatus.Update(TB_CmsStatus);
		}
		public bool Delete(TB_CmsStatus TB_CmsStatus)
		{
			return TB_CmsStatus.Delete(TB_CmsStatus);
		}
	}
}
