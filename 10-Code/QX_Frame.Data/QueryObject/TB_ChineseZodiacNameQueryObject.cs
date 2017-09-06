using QX_Frame.App.Base;
using QX_Frame.Data.Entities;
using System;
using System.Linq.Expressions;

/**
 * copyright qixiao code builder ->
 * version:4.2.0
 * author:qixiao(柒小)
 * create:2017-08-08 13:38:45
 **/

namespace QX_Frame.Data.QueryObject
{
	/// <summary>
	///class TB_ChineseZodiacNameQueryObject
	/// </summary>
	public class TB_ChineseZodiacNameQueryObject:WcfQueryObject<DB_QX_Frame_MS_User, TB_ChineseZodiacName>
	{
		/// <summary>
		/// construction method
		/// </summary>
		public TB_ChineseZodiacNameQueryObject()
		{}

		// PK（identity）  生肖Id
		public Int32 ChineseZodiacId { get;set; }

		// 生肖名称
		public String ChineseZodiacName { get;set; }

		//query condition // null default
		public override Expression<Func<TB_ChineseZodiacName, bool>> QueryCondition {get { return base.QueryCondition; } set { base.QueryCondition = value; } }

		//query condition func // true default //if QueryCondition != null this will be override !!!
		protected override Expression<Func<TB_ChineseZodiacName, bool>> QueryConditionFunc()
		{
			Expression<Func<TB_ChineseZodiacName, bool>> func = t => true;

			if (!string.IsNullOrEmpty(""))
			{
				func = func.And(t => true);
			}

			return func;
		}
	}
}
