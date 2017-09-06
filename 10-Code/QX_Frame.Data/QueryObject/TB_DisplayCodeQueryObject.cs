using QX_Frame.App.Base;
using QX_Frame.Data.Entities;
using System;
using System.Linq.Expressions;

/**
 * copyright qixiao code builder ->
 * version:4.2.0
 * author:qixiao(柒小)
 * create:2017-08-08 13:38:55
 **/

namespace QX_Frame.Data.QueryObject
{
	/// <summary>
	///class TB_DisplayCodeQueryObject
	/// </summary>
	public class TB_DisplayCodeQueryObject:WcfQueryObject<DB_QX_Frame_MS_User, TB_DisplayCode>
	{
		/// <summary>
		/// construction method
		/// </summary>
		public TB_DisplayCodeQueryObject()
		{}

		// PK（identity）  界面显示Code
		public Int32 DisplayCode { get;set; }

		// 界面显示描述
		public String DisplayDescription { get;set; }

		//query condition // null default
		public override Expression<Func<TB_DisplayCode, bool>> QueryCondition {get { return base.QueryCondition; } set { base.QueryCondition = value; } }

		//query condition func // true default //if QueryCondition != null this will be override !!!
		protected override Expression<Func<TB_DisplayCode, bool>> QueryConditionFunc()
		{
			Expression<Func<TB_DisplayCode, bool>> func = t => true;

			if (!string.IsNullOrEmpty(""))
			{
				func = func.And(t => true);
			}

			return func;
		}
	}
}
