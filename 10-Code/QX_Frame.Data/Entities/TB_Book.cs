/*********************************************************
 * CopyRight: QIXIAO CODE BUILDER. 
 * Version:4.2.0
 * Author:qixiao(柒小)
 * Create:2017-09-07 14:50:47
 * Update:2017-09-07 14:50:47
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
	/// public class TB_Book
	/// </summary>
	[Serializable]
	[Table(TableName = "TB_Book")]
	public class TB_Book: Entity<DB_QX_Frame_MS_CMS, TB_Book>
	{
		/// <summary>
		/// construction method
		/// </summary>
		public TB_Book(){}

		// PK（identity）  
		[Key]
		public Guid BookUid { get;set; }
		// 
		[Column]
		public String Title { get;set; }
		// 
		[Column]
		public String Title2 { get;set; }
		// 
		[Column]
		public Int32 Volume { get;set; }
		// 
		[Column]
		public String Dynasty { get;set; }
		// 
		[Column]
		public Int32 CategoryId { get;set; }

        [ForeignTable(ForeignKeyFieldName = "CategoryId")]
        public TB_Category TB_Category { get; set; }
		// 
		[Column]
		public String Functionary { get;set; }
		// 
		[Column]
		public String Publisher { get;set; }
		// 
		[Column]
		public String Version { get;set; }
		// 
		[Column]
		public String FromBF49 { get;set; }
		// 
		[Column]
		public String FromAF49 { get;set; }
		// 
		[Column]
		public String ImageUris { get;set; }
		// 
		[Column]
		public String Notice { get;set; }
	}
}
