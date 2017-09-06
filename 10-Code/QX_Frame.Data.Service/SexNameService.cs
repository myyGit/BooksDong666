using QX_Frame.App.Base;
using QX_Frame.Data.Contract;
using QX_Frame.Data.Entities;

/**
 * copyright qixiao code builder ->
 * version:4.2.0
 * author:qixiao(柒小)
 * create:2017-08-08 13:39:07
 **/

namespace QX_Frame.Data.Service
{
	/// <summary>
	/// class SexNameService
	/// </summary>
	public class SexNameService:WcfService, ISexNameService
	{
		private TB_SexName _TB_SexName;
		/// <summary>
		/// construction method
		/// </summary>
		public SexNameService()
		{}

		public SexNameService(TB_SexName TB_SexName)
		{
			this._TB_SexName = TB_SexName;
		}
		public bool Add(TB_SexName TB_SexName)
		{
			return TB_SexName.Add(TB_SexName);
		}
		public bool Update(TB_SexName TB_SexName)
		{
			return TB_SexName.Update(TB_SexName);
		}
		public bool Delete(TB_SexName TB_SexName)
		{
			return TB_SexName.Delete(TB_SexName);
		}
	}
}
