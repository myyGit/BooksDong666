using QX_Frame.App.Base;
using QX_Frame.Data.Entities;
using System;
using System.Linq.Expressions;

/**
 * copyright qixiao code builder ->
 * version:4.2.0
 * author:qixiao(柒小)
 * create:2017-08-09 12:00:48
 **/

namespace QX_Frame.Data.QueryObject
{
	/// <summary>
	///class TB_UserRoleNameQueryObject
	/// </summary>
	public class TB_UserRoleNameQueryObject:WcfQueryObject<DB_QX_Frame_MS_User, TB_UserRoleName>
	{
		/// <summary>
		/// construction method
		/// </summary>
		public TB_UserRoleNameQueryObject()
		{}

		// PK（identity）  角色ID
		public Int32 RoleId { get;set; }

		// 用户角色名称
		public String RoleName { get;set; }

		//query condition // null default
		public override Expression<Func<TB_UserRoleName, bool>> QueryCondition {get { return base.QueryCondition; } set { base.QueryCondition = value; } }

		//query condition func // true default //if QueryCondition != null this will be override !!!
		protected override Expression<Func<TB_UserRoleName, bool>> QueryConditionFunc()
		{
			Expression<Func<TB_UserRoleName, bool>> func = t => true;

			if (!string.IsNullOrEmpty(""))
			{
				func = func.And(t => true);
			}

			return func;
		}
	}
}
