using QX_Frame.Data.Entities;

/**
 * copyright qixiao code builder ->
 * version:4.2.0
 * author:qixiao(柒小)
 * create:2017-08-08 13:38:52
 **/

namespace QX_Frame.Data.Contract
{
	/// <summary>
	/// interface IConstellationNameService
	/// </summary>
	public interface IConstellationNameService
	{
		bool Add(TB_ConstellationName TB_ConstellationName);
		bool Update(TB_ConstellationName TB_ConstellationName);
		bool Delete(TB_ConstellationName TB_ConstellationName);
	}
}
