using QX_Frame.Data.Entities;

/**
 * copyright qixiao code builder ->
 * version:4.2.0
 * author:qixiao(柒小)
 * create:2017-08-08 13:39:02
 **/

namespace QX_Frame.Data.Contract
{
	/// <summary>
	/// interface ILimitCodeService
	/// </summary>
	public interface ILimitCodeService
	{
		bool Add(TB_LimitCode TB_LimitCode);
		bool Update(TB_LimitCode TB_LimitCode);
		bool Delete(TB_LimitCode TB_LimitCode);
	}
}
