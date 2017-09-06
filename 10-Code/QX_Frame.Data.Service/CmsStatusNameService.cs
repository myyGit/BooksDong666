using QX_Frame.App.Base;
using QX_Frame.Data.Contract;
using QX_Frame.Data.Entities;

/**
 * copyright qixiao code builder ->
 * version:4.2.0
 * author:qixiao(柒小)
 * create:2017-08-11 15:37:25
 **/

namespace QX_Frame.Data.Service
{
	/// <summary>
	/// class CmsStatusNameService
	/// </summary>
	public class CmsStatusNameService:WcfService, ICmsStatusNameService
	{
		private TB_CmsStatusName _TB_CmsStatusName;
		/// <summary>
		/// construction method
		/// </summary>
		public CmsStatusNameService()
		{}

		public CmsStatusNameService(TB_CmsStatusName TB_CmsStatusName)
		{
			this._TB_CmsStatusName = TB_CmsStatusName;
		}
		public bool Add(TB_CmsStatusName TB_CmsStatusName)
		{
			return TB_CmsStatusName.Add(TB_CmsStatusName);
		}
		public bool Update(TB_CmsStatusName TB_CmsStatusName)
		{
			return TB_CmsStatusName.Update(TB_CmsStatusName);
		}
		public bool Delete(TB_CmsStatusName TB_CmsStatusName)
		{
			return TB_CmsStatusName.Delete(TB_CmsStatusName);
		}
	}
}
