// =================================================================== 
// 项目说明
//====================================================================
// yangxg。@Copy Right 2014
// 文件： ArticleCls.cs
// 项目名称：买车网
// 创建时间：2016/4/2
// 负责人：yangxg
// ===================================================================
using System;
using System.Collections.Generic;
using System.Text;
using Weifenxiao.DAL;
using Weifenxiao.Entity;

namespace Weifenxiao.BLL
{
    public partial class ArticleClsBLL : BaseBLL< ArticleClsBLL>

    {
        ArticleClsDataAccessLayer articleClsdal;
        public ArticleClsBLL()
        {
            articleClsdal = new ArticleClsDataAccessLayer();
        }

        public int Insert(ArticleClsEntity articleClsEntity)
        {
            return articleClsdal.Insert(articleClsEntity);            
        }

        public void Update(ArticleClsEntity articleClsEntity)
        {
            articleClsdal.Update(articleClsEntity);
        }

        public ArticleClsEntity GetAdminSingle(int clsId)
        {
           return articleClsdal.Get_ArticleClsEntity(clsId);
        }

        public IList<ArticleClsEntity> GetArticleClsList()
        {
            IList<ArticleClsEntity> articleClsList = new List<ArticleClsEntity>();
            articleClsList=articleClsdal.Get_ArticleClsAll();
            return articleClsList;
        }
    }
}
