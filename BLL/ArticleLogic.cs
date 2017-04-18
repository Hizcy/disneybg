// =================================================================== 
// 项目说明
//====================================================================
// yangxg。@Copy Right 2014
// 文件： Article.cs
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
    public partial class ArticleBLL : BaseBLL< ArticleBLL>

    {
        ArticleDataAccessLayer articledal;
        public ArticleBLL()
        {
            articledal = new ArticleDataAccessLayer();
        }

        public int Insert(ArticleEntity articleEntity)
        {
            return articledal.Insert(articleEntity);            
        }

        public void Update(ArticleEntity articleEntity)
        {
            articledal.Update(articleEntity);
        }

        public ArticleEntity GetAdminSingle(int articleId)
        {
           return articledal.Get_ArticleEntity(articleId);
        }

        public IList<ArticleEntity> GetArticleList()
        {
            IList<ArticleEntity> articleList = new List<ArticleEntity>();
            articleList=articledal.Get_ArticleAll();
            return articleList;
        }
    }
}
