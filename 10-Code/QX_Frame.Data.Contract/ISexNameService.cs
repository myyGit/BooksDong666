using QX_Frame.Data.Entities;

/**
 * copyright qixiao code builder ->
 * version:4.2.0
 * author:qixiao(柒小)
 * create:2017-08-08 13:39:07
 **/

namespace QX_Frame.Data.Contract
{
	/// <summary>
	/// interface ISexNameService
	/// </summary>
	public interface ISexNameService
	{
		bool Add(TB_SexName TB_SexName);
		bool Update(TB_SexName TB_SexName);
		bool Delete(TB_SexName TB_SexName);
	}
}
