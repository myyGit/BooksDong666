using QX_Frame.App.Base;
using QX_Frame.Data.Contract;
using QX_Frame.Data.Entities;

/**
 * copyright qixiao code builder ->
 * version:4.2.0
 * author:qixiao(柒小)
 * create:2017-08-08 13:38:45
 **/

namespace QX_Frame.Data.Service
{
	/// <summary>
	/// class ChineseZodiacNameService
	/// </summary>
	public class ChineseZodiacNameService:WcfService, IChineseZodiacNameService
	{
		private TB_ChineseZodiacName _TB_ChineseZodiacName;
		/// <summary>
		/// construction method
		/// </summary>
		public ChineseZodiacNameService()
		{}

		public ChineseZodiacNameService(TB_ChineseZodiacName TB_ChineseZodiacName)
		{
			this._TB_ChineseZodiacName = TB_ChineseZodiacName;
		}
		public bool Add(TB_ChineseZodiacName TB_ChineseZodiacName)
		{
			return TB_ChineseZodiacName.Add(TB_ChineseZodiacName);
		}
		public bool Update(TB_ChineseZodiacName TB_ChineseZodiacName)
		{
			return TB_ChineseZodiacName.Update(TB_ChineseZodiacName);
		}
		public bool Delete(TB_ChineseZodiacName TB_ChineseZodiacName)
		{
			return TB_ChineseZodiacName.Delete(TB_ChineseZodiacName);
		}
	}
}
