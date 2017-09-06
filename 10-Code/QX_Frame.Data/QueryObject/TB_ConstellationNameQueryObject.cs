using QX_Frame.App.Base;
using QX_Frame.Data.Entities;
using System;
using System.Linq.Expressions;

/**
 * copyright qixiao code builder ->
 * version:4.2.0
 * author:qixiao(柒小)
 * create:2017-08-08 13:38:52
 **/

namespace QX_Frame.Data.QueryObject
{
	/// <summary>
	///class TB_ConstellationNameQueryObject
	/// </summary>
	public class TB_ConstellationNameQueryObject:WcfQueryObject<DB_QX_Frame_MS_User, TB_ConstellationName>
	{
		/// <summary>
		/// construction method
		/// </summary>
		public TB_ConstellationNameQueryObject()
		{}

		// PK（identity）  星座Id
		public Int32 ConstellationId { get;set; }

		// 星座名称
		public String ConstellationName { get;set; }

		//query condition // null default
		public override Expression<Func<TB_ConstellationName, bool>> QueryCondition {get { return base.QueryCondition; } set { base.QueryCondition = value; } }

		//query condition func // true default //if QueryCondition != null this will be override !!!
		protected override Expression<Func<TB_ConstellationName, bool>> QueryConditionFunc()
		{
			Expression<Func<TB_ConstellationName, bool>> func = t => true;

			if (!string.IsNullOrEmpty(""))
			{
				func = func.And(t => true);
			}

			return func;
		}
	}
}
