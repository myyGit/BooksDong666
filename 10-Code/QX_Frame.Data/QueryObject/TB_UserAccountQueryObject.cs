using QX_Frame.App.Base;
using QX_Frame.Data.Entities;
using System;
using System.Linq.Expressions;

/**
 * copyright qixiao code builder ->
 * version:4.2.0
 * author:qixiao(柒小)
 * create:2017-08-08 13:39:09
 **/

namespace QX_Frame.Data.QueryObject
{
	/// <summary>
	///class TB_UserAccountQueryObject
	/// </summary>
	public class TB_UserAccountQueryObject:WcfQueryObject<DB_QX_Frame_MS_User, TB_UserAccount>
	{
		/// <summary>
		/// construction method
		/// </summary>
		public TB_UserAccountQueryObject()
		{}

		// PK（identity）  User UID
		public Guid UserUid { get;set; }

		// 登录名
		public String LoginId { get;set; }

		// 用户密码 MD5方式加密
		public String Password { get;set; }

		// 邮箱
		public String Email { get;set; }

		// 电话号码
		public String Tel { get;set; }

		//query condition // null default
		public override Expression<Func<TB_UserAccount, bool>> QueryCondition {get { return base.QueryCondition; } set { base.QueryCondition = value; } }

		//query condition func // true default //if QueryCondition != null this will be override !!!
		protected override Expression<Func<TB_UserAccount, bool>> QueryConditionFunc()
		{
			Expression<Func<TB_UserAccount, bool>> func = t => true;

			if (!string.IsNullOrEmpty(""))
			{
				func = func.And(t => true);
			}

			return func;
		}
	}
}
