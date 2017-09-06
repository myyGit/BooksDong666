using QX_Frame.App.Base;
using QX_Frame.Data.Contract;
using QX_Frame.Data.Entities;

/**
 * copyright qixiao code builder ->
 * version:4.2.0
 * author:qixiao(柒小)
 * create:2017-08-08 13:38:40
 **/

namespace QX_Frame.Data.Service
{
	/// <summary>
	/// class BloodTypeNameService
	/// </summary>
	public class BloodTypeNameService:WcfService, IBloodTypeNameService
	{
		private TB_BloodTypeName _TB_BloodTypeName;
		/// <summary>
		/// construction method
		/// </summary>
		public BloodTypeNameService()
		{}

		public BloodTypeNameService(TB_BloodTypeName TB_BloodTypeName)
		{
			this._TB_BloodTypeName = TB_BloodTypeName;
		}
		public bool Add(TB_BloodTypeName TB_BloodTypeName)
		{
			return TB_BloodTypeName.Add(TB_BloodTypeName);
		}
		public bool Update(TB_BloodTypeName TB_BloodTypeName)
		{
			return TB_BloodTypeName.Update(TB_BloodTypeName);
		}
		public bool Delete(TB_BloodTypeName TB_BloodTypeName)
		{
			return TB_BloodTypeName.Delete(TB_BloodTypeName);
		}
	}
}
