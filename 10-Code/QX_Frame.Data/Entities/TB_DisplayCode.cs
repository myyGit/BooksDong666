/*********************************************************
 * CopyRight: QIXIAO CODE BUILDER. 
 * Version:4.2.0
 * Author:qixiao(柒小)
 * Create:2017-09-07 14:51:37
 * Update:2017-09-07 14:51:37
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
	/// public class TB_DisplayCode
	/// </summary>
	[Serializable]
	[Table(TableName = "TB_DisplayCode")]
	public class TB_DisplayCode: Entity<DB_QX_Frame_MS_User, TB_DisplayCode>
	{
		/// <summary>
		/// construction method
		/// </summary>
		public TB_DisplayCode(){}

		// PK（identity）  界面显示Code
		[Key]
		[AutoIncrease]
		public Int32 DisplayCode { get;set; }
		// 界面显示描述
		[Column]
		public String DisplayDescription { get;set; }
	}
}
