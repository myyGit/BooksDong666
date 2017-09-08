/*********************************************************
 * CopyRight: QIXIAO CODE BUILDER. 
 * Version:4.2.0
 * Author:qixiao(柒小)
 * Create:2017-09-07 14:51:07
 * Update:2017-09-07 14:51:07
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
    /// public class TB_CmsStatus
    /// </summary>
    [Serializable]
    [Table(TableName = "TB_CmsStatus")]
    public class TB_CmsStatus : Entity<DB_QX_Frame_MS_CMS, TB_CmsStatus>
    {
        /// <summary>
        /// construction method
        /// </summary>
        public TB_CmsStatus() { }

        // PK（identity）  
        [Key]
        public Guid CmsUid { get; set; }
        // 
        [Column]
        public Int32 StatusId { get; set; }

        [ForeignTable(ForeignKeyFieldName = "StatusId")]
        public TB_CmsStatusName TB_CmsStatusName { get;set;}
	}
}
