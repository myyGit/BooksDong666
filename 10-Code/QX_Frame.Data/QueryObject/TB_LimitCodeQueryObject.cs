using QX_Frame.App.Base;
using QX_Frame.Data.Entities;
using System;
using System.Linq.Expressions;

/**
 * copyright qixiao code builder ->
 * version:4.2.0
 * author:qixiao(柒小)
 * create:2017-08-08 13:39:02
 **/

namespace QX_Frame.Data.QueryObject
{
	/// <summary>
	///class TB_LimitCodeQueryObject
	/// </summary>
	public class TB_LimitCodeQueryObject:WcfQueryObject<DB_QX_Frame_MS_User, TB_LimitCode>
	{
		/// <summary>
		/// construction method
		/// </summary>
		public TB_LimitCodeQueryObject()
		{}

		// PK（identity）  权限代码
		public Int32 LimitCodeId { get;set; }

		// 权限描述
		public String LimitDescription { get;set; }

		//query condition // null default
		public override Expression<Func<TB_LimitCode, bool>> QueryCondition {get { return base.QueryCondition; } set { base.QueryCondition = value; } }

		//query condition func // true default //if QueryCondition != null this will be override !!!
		protected override Expression<Func<TB_LimitCode, bool>> QueryConditionFunc()
		{
			Expression<Func<TB_LimitCode, bool>> func = t => true;

			if (!string.IsNullOrEmpty(""))
			{
				func = func.And(t => true);
			}

			return func;
		}
	}
}
