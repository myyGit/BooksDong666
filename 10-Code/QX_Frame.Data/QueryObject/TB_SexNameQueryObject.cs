using QX_Frame.App.Base;
using QX_Frame.Data.Entities;
using System;
using System.Linq.Expressions;

/**
 * copyright qixiao code builder ->
 * version:4.2.0
 * author:qixiao(柒小)
 * create:2017-08-08 13:39:07
 **/

namespace QX_Frame.Data.QueryObject
{
	/// <summary>
	///class TB_SexNameQueryObject
	/// </summary>
	public class TB_SexNameQueryObject:WcfQueryObject<DB_QX_Frame_MS_User, TB_SexName>
	{
		/// <summary>
		/// construction method
		/// </summary>
		public TB_SexNameQueryObject()
		{}

		// PK（identity）  性别Id
		public Int32 SexId { get;set; }

		// 性别名称
		public String SexName { get;set; }

		//query condition // null default
		public override Expression<Func<TB_SexName, bool>> QueryCondition {get { return base.QueryCondition; } set { base.QueryCondition = value; } }

		//query condition func // true default //if QueryCondition != null this will be override !!!
		protected override Expression<Func<TB_SexName, bool>> QueryConditionFunc()
		{
			Expression<Func<TB_SexName, bool>> func = t => true;

			if (!string.IsNullOrEmpty(""))
			{
				func = func.And(t => true);
			}

			return func;
		}
	}
}
