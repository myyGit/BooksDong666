using QX_Frame.App.Base;
using QX_Frame.Data.Entities;
using System;
using System.Linq.Expressions;

/**
 * copyright qixiao code builder ->
 * version:4.2.0
 * author:qixiao(柒小)
 * create:2017-08-08 13:39:13
 **/

namespace QX_Frame.Data.QueryObject
{
	/// <summary>
	///class TB_UserAuthenCodesQueryObject
	/// </summary>
	public class TB_UserAuthenCodesQueryObject:WcfQueryObject<DB_QX_Frame_MS_User, TB_UserAuthenCodes>
	{
		/// <summary>
		/// construction method
		/// </summary>
		public TB_UserAuthenCodesQueryObject()
		{}

		// PK（identity）  用户Uid
		public Guid UserUid { get;set; }

		// 用户显示代码数组
		public String UserDisplayCodes { get;set; }

		// 用户权限代码组
		public String UserLimitCodes { get;set; }

		//query condition // null default
		public override Expression<Func<TB_UserAuthenCodes, bool>> QueryCondition {get { return base.QueryCondition; } set { base.QueryCondition = value; } }

		//query condition func // true default //if QueryCondition != null this will be override !!!
		protected override Expression<Func<TB_UserAuthenCodes, bool>> QueryConditionFunc()
		{
			Expression<Func<TB_UserAuthenCodes, bool>> func = t => true;

			if (!string.IsNullOrEmpty(""))
			{
				func = func.And(t => true);
			}

			return func;
		}
	}
}
