/*********************************************************
 * CopyRight: QIXIAO CODE BUILDER. 
 * Version:4.2.0
 * Author:qixiao(柒小)
 * Create:2017-09-07 14:52:01
 * Update:2017-09-07 14:52:01
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
	/// public class TB_UserAuthenCodes
	/// </summary>
	[Serializable]
	[Table(TableName = "TB_UserAuthenCodes")]
	public class TB_UserAuthenCodes: Entity<DB_QX_Frame_MS_User, TB_UserAuthenCodes>
	{
		/// <summary>
		/// construction method
		/// </summary>
		public TB_UserAuthenCodes(){}

		// PK（identity）  用户Uid
		[Key]
		public Guid UserUid { get;set; }
		// 用户显示代码数组
		[Column]
		public String UserDisplayCodes { get;set; }

         // 用户权限代码组
        [Column]
		public String UserLimitCodes { get;set; }
    }
}
