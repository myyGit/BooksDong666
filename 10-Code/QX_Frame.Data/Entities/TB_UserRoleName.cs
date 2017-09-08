/*********************************************************
 * CopyRight: QIXIAO CODE BUILDER. 
 * Version:4.2.0
 * Author:qixiao(柒小)
 * Create:2017-09-07 14:52:12
 * Update:2017-09-07 14:52:12
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
	/// public class TB_UserRoleName
	/// </summary>
	[Serializable]
	[Table(TableName = "TB_UserRoleName")]
	public class TB_UserRoleName: Entity<DB_QX_Frame_MS_User, TB_UserRoleName>
	{
		/// <summary>
		/// construction method
		/// </summary>
		public TB_UserRoleName(){}

		// PK（identity）  角色ID
		[Key]
		public Int32 RoleId { get;set; }
		// 用户角色名称
		[Column]
		public String RoleName { get;set; }
	}
}
