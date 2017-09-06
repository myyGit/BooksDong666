using QX_Frame.Data.Entities;

/**
 * copyright qixiao code builder ->
 * version:4.2.0
 * author:qixiao(柒小)
 * create:2017-08-08 13:38:40
 **/

namespace QX_Frame.Data.Contract
{
	/// <summary>
	/// interface IBloodTypeNameService
	/// </summary>
	public interface IBloodTypeNameService
	{
		bool Add(TB_BloodTypeName TB_BloodTypeName);
		bool Update(TB_BloodTypeName TB_BloodTypeName);
		bool Delete(TB_BloodTypeName TB_BloodTypeName);
	}
}
