using QX_Frame.Data.Entities;

/**
 * copyright qixiao code builder ->
 * version:4.2.0
 * author:qixiao(柒小)
 * create:2017-08-08 13:38:45
 **/

namespace QX_Frame.Data.Contract
{
	/// <summary>
	/// interface IChineseZodiacNameService
	/// </summary>
	public interface IChineseZodiacNameService
	{
		bool Add(TB_ChineseZodiacName TB_ChineseZodiacName);
		bool Update(TB_ChineseZodiacName TB_ChineseZodiacName);
		bool Delete(TB_ChineseZodiacName TB_ChineseZodiacName);
	}
}
