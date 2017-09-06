using QX_Frame.App.Base;
using QX_Frame.Data.Contract;
using QX_Frame.Data.Entities;

/**
 * copyright qixiao code builder ->
 * version:4.2.0
 * author:qixiao(柒小)
 * create:2017-08-08 13:38:52
 **/

namespace QX_Frame.Data.Service
{
	/// <summary>
	/// class ConstellationNameService
	/// </summary>
	public class ConstellationNameService:WcfService, IConstellationNameService
	{
		private TB_ConstellationName _TB_ConstellationName;
		/// <summary>
		/// construction method
		/// </summary>
		public ConstellationNameService()
		{}

		public ConstellationNameService(TB_ConstellationName TB_ConstellationName)
		{
			this._TB_ConstellationName = TB_ConstellationName;
		}
		public bool Add(TB_ConstellationName TB_ConstellationName)
		{
			return TB_ConstellationName.Add(TB_ConstellationName);
		}
		public bool Update(TB_ConstellationName TB_ConstellationName)
		{
			return TB_ConstellationName.Update(TB_ConstellationName);
		}
		public bool Delete(TB_ConstellationName TB_ConstellationName)
		{
			return TB_ConstellationName.Delete(TB_ConstellationName);
		}
	}
}
