/*********************************************************
 * CopyRight: QIXIAO CODE BUILDER. 
 * Version:4.2.0
 * Author:qixiao(柒小)
 * Create:2017-09-07 14:51:54
 * Update:2017-09-07 14:51:54
 * E-mail: dong@qixiao.me | wd8622088@foxmail.com 
 * GitHub: https://github.com/dong666 
 * Personal web site: http://qixiao.me 
 * Technical WebSit: http://www.cnblogs.com/qixiaoyizhan/ 
 * Description:
 * Thx , Best Regards ~
 *********************************************************/

using System;
using QX_Frame.App.Base;
using QX_Frame.Bantina.Bankinate;

namespace QX_Frame.Data.Entities
{
	/// <summary>
	/// public class TB_UserAccount
	/// </summary>
	[Serializable]
	[Table(TableName = "TB_UserAccount")]
	public class TB_UserAccount: Entity<DB_QX_Frame_MS_User, TB_UserAccount>
	{
		/// <summary>
		/// construction method
		/// </summary>
		public TB_UserAccount(){}

		// PK（identity）  User UID
		[Key]
		public Guid UserUid { get;set; }
		// 登录名
		[Column]
		public String LoginId { get;set; }
		// 用户密码 MD5方式加密
		[Column]
		public String Password { get;set; }
		// 邮箱
		[Column]
		public String Email { get;set; }
		// 电话号码
		[Column]
		public String Tel { get;set; }
	}
}
