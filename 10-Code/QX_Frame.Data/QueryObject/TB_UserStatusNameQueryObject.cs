using QX_Frame.App.Base;
using QX_Frame.Data.Entities;
using System;
using System.Linq.Expressions;

/**
 * copyright qixiao code builder ->
 * version:4.2.0
 * author:qixiao(柒小)
 * create:2017-08-09 12:00:44
 **/

namespace QX_Frame.Data.QueryObject
{
	/// <summary>
	///class TB_UserStatusNameQueryObject
	/// </summary>
	public class TB_UserStatusNameQueryObject:WcfQueryObject<DB_QX_Frame_MS_User, TB_UserStatusName>
	{
		/// <summary>
		/// construction method
		/// </summary>
		public TB_UserStatusNameQueryObject()
		{}

		// PK（identity）  状态ID
		public Int32 StatusId { get;set; }

		// 用户状态名称
		public String StatusName { get;set; }

		//query condition // null default
		public override Expression<Func<TB_UserStatusName, bool>> QueryCondition {get { return base.QueryCondition; } set { base.QueryCondition = value; } }

		//query condition func // true default //if QueryCondition != null this will be override !!!
		protected override Expression<Func<TB_UserStatusName, bool>> QueryConditionFunc()
		{
			Expression<Func<TB_UserStatusName, bool>> func = t => true;

			if (!string.IsNullOrEmpty(""))
			{
				func = func.And(t => true);
			}

			return func;
		}
	}
}
