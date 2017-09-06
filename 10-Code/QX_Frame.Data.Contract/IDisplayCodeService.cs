using QX_Frame.Data.Entities;

/**
 * copyright qixiao code builder ->
 * version:4.2.0
 * author:qixiao(柒小)
 * create:2017-08-08 13:38:55
 **/

namespace QX_Frame.Data.Contract
{
	/// <summary>
	/// interface IDisplayCodeService
	/// </summary>
	public interface IDisplayCodeService
	{
		bool Add(TB_DisplayCode TB_DisplayCode);
		bool Update(TB_DisplayCode TB_DisplayCode);
		bool Delete(TB_DisplayCode TB_DisplayCode);
	}
}
