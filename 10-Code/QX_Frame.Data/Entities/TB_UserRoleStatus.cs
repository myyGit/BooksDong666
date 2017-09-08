/*********************************************************
 * CopyRight: QIXIAO CODE BUILDER. 
 * Version:4.2.0
 * Author:qixiao(柒小)
 * Create:2017-09-07 14:52:16
 * Update:2017-09-07 14:52:16
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
	/// public class TB_UserRoleStatus
	/// </summary>
	[Serializable]
	[Table(TableName = "TB_UserRoleStatus")]
	public class TB_UserRoleStatus: Entity<DB_QX_Frame_MS_User, TB_UserRoleStatus>
	{
		/// <summary>
		/// construction method
		/// </summary>
		public TB_UserRoleStatus(){}

		// PK（identity）  Uid
		[Key]
		public Guid UserUid { get;set; }
		// 用户角色id
		[Column]
		public Int32 RoleId { get;set; }

        [ForeignTable(ForeignKeyFieldName = "RoleId")]
        public TB_UserRoleName TB_UserRoleName { get; set; }
                                           // 用户状态id
        [Column]
		public Int32 StatusId { get;set; }

        [ForeignTable(ForeignKeyFieldName = "StatusId")]
        public TB_UserStatusName TB_UserStatusName { get; set; }
    }
}
