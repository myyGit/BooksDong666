using QX_Frame.App.Base;
using QX_Frame.Data.Entities;
using System;
using System.Linq.Expressions;

/**
 * copyright qixiao code builder ->
 * version:4.2.0
 * author:qixiao(柒小)
 * create:2017-08-08 13:39:22
 **/

namespace QX_Frame.Data.QueryObject
{
	/// <summary>
	///class TB_UserInfoQueryObject
	/// </summary>
	public class TB_UserInfoQueryObject:WcfQueryObject<DB_QX_Frame_MS_User, TB_UserInfo>
	{
		/// <summary>
		/// construction method
		/// </summary>
		public TB_UserInfoQueryObject()
		{}

		// PK（identity）  Uid
		public Guid UserUid { get;set; }

		// 登录名
		public String LoginId { get;set; }

		// 昵称
		public String NickName { get;set; }

		// 头像地址
		public String HeadImageUrl { get;set; }

		// 年龄
		public Int32 Age { get;set; }

		// 性别
		public Int32 SexId { get;set; }

		// 出生日期
		public DateTime? Birthday { get;set; }

		// 血型
		public Int32 BloodTypeId { get;set; }

		// 地址
		public String Address { get;set; }

		// 职位
		public String Position { get;set; }

		// 学校
		public String School { get;set; }

		// 公司
		public String Company { get;set; }

		// 星座
		public Int32 ConstellationId { get;set; }

		// 生肖
		public Int32 ChineseZodiacId { get;set; }

		// 个性签名
		public String PersonalizedSignature { get;set; }

		// 个人说明
		public String PersonalizedDescription { get;set; }

		// 注册日期
		public DateTime RegisterTime { get;set; }

		//query condition // null default
		public override Expression<Func<TB_UserInfo, bool>> QueryCondition {get { return base.QueryCondition; } set { base.QueryCondition = value; } }

		//query condition func // true default //if QueryCondition != null this will be override !!!
		protected override Expression<Func<TB_UserInfo, bool>> QueryConditionFunc()
		{
			Expression<Func<TB_UserInfo, bool>> func = t => true;

			if (!string.IsNullOrEmpty(""))
			{
				func = func.And(t => true);
			}

            if (this.UserUid != default(Guid))
            {
                func = func.And(t => t.UserUid == this.UserUid);
            }

            if (!string.IsNullOrEmpty(this.LoginId))
            {
                func = func.And(tt => tt.LoginId.Contains(this.LoginId));
            }

            if (!string.IsNullOrEmpty(this.NickName))
            {
                func = func.And(tt => tt.NickName.Contains(this.NickName));
            }

            return func;
		}
	}
}
