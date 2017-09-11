using QX_Frame.App.Base;
using QX_Frame.Data.Entities;
using System;
using System.Linq.Expressions;

/**
 * copyright qixiao code builder ->
 * version:4.2.0
 * author:qixiao(柒小)
 * create:2017-08-10 16:13:46
 **/

namespace QX_Frame.Data.QueryObject
{
    /// <summary>
    ///class TB_BookQueryObject
    /// </summary>
    public class TB_BookQueryObject : WcfQueryObject<DB_QX_Frame_MS_CMS, TB_Book>
    {
        /// <summary>
        /// construction method
        /// </summary>
        public TB_BookQueryObject()
        { }

        // PK（identity）  
        public Guid BookUid { get; set; }

        // 
        public String Title { get; set; }

        // 
        public String Title2 { get; set; }

        // 
        public Int32 Volume { get; set; }

        // 
        public String Dynasty { get; set; }

        // 
        public Int32 CategoryId { get; set; }

        // 
        public String Functionary { get; set; }

        // 
        public String Publisher { get; set; }

        // 
        public String Version { get; set; }

        // 
        public String FromBF49 { get; set; }

        // 
        public String FromAF49 { get; set; }

        // 
        public String ImageUris { get; set; }

        // 
        public String Notice { get; set; }
        public String NameFan { get; set; }
        public String NameJian { get; set; }
        public String Query1 { get; set; }
        public String Query2 { get; set; }
        public String Query3 { get; set; }
        public String Query4 { get; set; }
        public String Query5 { get; set; }
        /// <summary>
        /// 查询条件
        /// </summary>
        public Int32 CategoryId2 { get; set; }
        /// <summary>
        /// 查询的输入参数
        /// </summary>
        public String TxtTitle2 { get; set; }
        public String NameFan2 { get; set; }
        public String NameJian2 { get; set; }

        //query condition // null default
        public override Expression<Func<TB_Book, bool>> QueryCondition { get { return base.QueryCondition; } set { base.QueryCondition = value; } }

        //query condition func // true default //if QueryCondition != null this will be override !!!
        protected override Expression<Func<TB_Book, bool>> QueryConditionFunc()
        {
            Expression<Func<TB_Book, bool>> func = t => true;

            if (!string.IsNullOrEmpty(this.Title))
            {
                if (this.CategoryId == 0)
                {
                    func = func.And(tt => tt.Title.Contains(this.NameJian) || tt.Title.Contains(this.NameFan)
                                   || tt.Title2.Contains(this.NameJian) || tt.Title2.Contains(this.NameFan)
                                   || tt.Publisher.Contains(this.NameJian) || tt.Publisher.Contains(this.NameFan)
                                   || tt.Dynasty.Contains(this.NameJian) || tt.Dynasty.Contains(this.NameFan)
                                   || tt.Functionary.Contains(this.NameJian) || tt.Functionary.Contains(this.NameFan));
                                   //|| (tt.TB_Category != null && tt.TB_Category.CategoryName.Contains(this.NameJian))
                                   //|| (tt.TB_Category != null && tt.TB_Category.CategoryName.Contains(this.NameFan)));
                }
                if (this.CategoryId == 1)
                {
                    func = func.And(tt => tt.Title.Contains(this.NameJian) || tt.Title.Contains(this.NameFan));
                }
                if (this.CategoryId == 2)
                {
                    func = func.And(tt => tt.Functionary.Contains(this.NameJian) || tt.Functionary.Contains(this.NameFan));
                }
                if (this.CategoryId == 3)
                {
                    func = func.And(tt => tt.Publisher.Contains(this.NameJian) || tt.Publisher.Contains(this.NameFan));
                }
                if (this.CategoryId == 4)
                {
                    func = func.And(tt => tt.Dynasty.Contains(this.NameJian) || tt.Dynasty.Contains(this.NameFan));
                }
                if (this.CategoryId == 5)
                {
                    func = func.And(tt => tt.Title2.Contains(this.NameJian) || tt.Title2.Contains(this.NameFan));
                }
            }
            if (!string.IsNullOrEmpty(this.TxtTitle2))
            {
                if (this.CategoryId2 == 0)
                {
                    func = func.And(tt => tt.Title.Contains(this.NameJian2) || tt.Title.Contains(this.NameFan2)
                                   || tt.Title2.Contains(this.NameJian2) || tt.Title2.Contains(this.NameFan2)
                                   || tt.Publisher.Contains(this.NameJian2) || tt.Publisher.Contains(this.NameFan2)
                                   || tt.Dynasty.Contains(this.NameJian2) || tt.Dynasty.Contains(this.NameFan2)
                                   || tt.Functionary.Contains(this.NameJian2) || tt.Functionary.Contains(this.NameFan2));
                                   //|| (tt.TB_Category != null && tt.TB_Category.CategoryName.Contains(this.NameJian2))
                                   //|| (tt.TB_Category != null && tt.TB_Category.CategoryName.Contains(this.NameFan2)));
                }
                if (this.CategoryId2 == 1)
                {
                    func = func.And(tt => tt.Title.Contains(this.NameJian2) || tt.Title.Contains(this.NameFan2));
                }
                if (this.CategoryId2 == 2)
                {
                    func = func.And(tt => tt.Functionary.Contains(this.NameJian2) || tt.Functionary.Contains(this.NameFan2));
                }
                if (this.CategoryId2 == 3)
                {
                    func = func.And(tt => tt.Publisher.Contains(this.NameJian2) || tt.Publisher.Contains(this.NameFan2));
                }
                if (this.CategoryId2 == 4)
                {
                    func = func.And(tt => tt.Dynasty.Contains(this.NameJian2) || tt.Dynasty.Contains(this.NameFan2));
                }
                if (this.CategoryId2 == 5)
                {
                    func = func.And(tt => tt.Title2.Contains(this.NameJian2) || tt.Title2.Contains(this.NameFan2));
                }
            }
            return func;
        }
    }
}
