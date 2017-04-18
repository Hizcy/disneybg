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
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Jnwf.Utils.Data;
using Weifenxiao.Entity;



namespace Weifenxiao.DAL
{
    /// <summary>
    /// 数据层实例化接口类 dbo.Article.
    /// </summary>
    public partial class ArticleDataAccessLayer 
    {
		#region 构造函数


		/// <summary>
		/// 
		/// </summary>
		public ArticleDataAccessLayer()
		{
		}
		#endregion

        #region -----------实例化接口函数-----------
		
		#region 添加更新删除
		/// <summary>
		/// 向数据库中插入一条新记录。
		/// </summary>
		/// <param name="_ArticleModel">Article实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(ArticleEntity _ArticleModel)
		{
			string sqlStr="insert into Article([ShopId],[ArticleCls],[ArticleTitle],[Author],[ArticleContent],[ArticleUrl],[Status],[Addtime],[Updatetime]) values(@ShopId,@ArticleCls,@ArticleTitle,@Author,@ArticleContent,@ArticleUrl,@Status,@Addtime,@Updatetime) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@ShopId",SqlDbType.Int),
			new SqlParameter("@ArticleCls",SqlDbType.Int),
			new SqlParameter("@ArticleTitle",SqlDbType.VarChar),
			new SqlParameter("@Author",SqlDbType.VarChar),
			new SqlParameter("@ArticleContent",SqlDbType.VarChar),
			new SqlParameter("@ArticleUrl",SqlDbType.VarChar),
			new SqlParameter("@Status",SqlDbType.Int),
			new SqlParameter("@Addtime",SqlDbType.DateTime),
			new SqlParameter("@Updatetime",SqlDbType.DateTime)
			};			
			_param[0].Value=_ArticleModel.ShopId;
			_param[1].Value=_ArticleModel.ArticleCls;
			_param[2].Value=_ArticleModel.ArticleTitle;
			_param[3].Value=_ArticleModel.Author;
			_param[4].Value=_ArticleModel.ArticleContent;
			_param[5].Value=_ArticleModel.ArticleUrl;
			_param[6].Value=_ArticleModel.Status;
			_param[7].Value=_ArticleModel.Addtime;
			_param[8].Value=_ArticleModel.Updatetime;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.WfxRW,CommandType.Text,sqlStr,_param));
			return res;
		}
		/// <summary>
		/// 向数据库中插入一条新记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_ArticleModel">Article实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(SqlTransaction sp,ArticleEntity _ArticleModel)
		{
			string sqlStr="insert into Article([ShopId],[ArticleCls],[ArticleTitle],[Author],[ArticleContent],[ArticleUrl],[Status],[Addtime],[Updatetime]) values(@ShopId,@ArticleCls,@ArticleTitle,@Author,@ArticleContent,@ArticleUrl,@Status,@Addtime,@Updatetime) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@ShopId",SqlDbType.Int),
			new SqlParameter("@ArticleCls",SqlDbType.Int),
			new SqlParameter("@ArticleTitle",SqlDbType.VarChar),
			new SqlParameter("@Author",SqlDbType.VarChar),
			new SqlParameter("@ArticleContent",SqlDbType.VarChar),
			new SqlParameter("@ArticleUrl",SqlDbType.VarChar),
			new SqlParameter("@Status",SqlDbType.Int),
			new SqlParameter("@Addtime",SqlDbType.DateTime),
			new SqlParameter("@Updatetime",SqlDbType.DateTime)
			};			
			_param[0].Value=_ArticleModel.ShopId;
			_param[1].Value=_ArticleModel.ArticleCls;
			_param[2].Value=_ArticleModel.ArticleTitle;
			_param[3].Value=_ArticleModel.Author;
			_param[4].Value=_ArticleModel.ArticleContent;
			_param[5].Value=_ArticleModel.ArticleUrl;
			_param[6].Value=_ArticleModel.Status;
			_param[7].Value=_ArticleModel.Addtime;
			_param[8].Value=_ArticleModel.Updatetime;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(sp,CommandType.Text,sqlStr,_param));
			return res;
		}


		/// <summary>
		/// 向数据表Article更新一条记录。
		/// </summary>
		/// <param name="_ArticleModel">_ArticleModel</param>
		/// <returns>影响的行数</returns>
		public int Update(ArticleEntity _ArticleModel)
		{
            string sqlStr="update Article set [ShopId]=@ShopId,[ArticleCls]=@ArticleCls,[ArticleTitle]=@ArticleTitle,[Author]=@Author,[ArticleContent]=@ArticleContent,[ArticleUrl]=@ArticleUrl,[Status]=@Status,[Addtime]=@Addtime,[Updatetime]=@Updatetime where ArticleId=@ArticleId";
			SqlParameter[] _param={				
				new SqlParameter("@ArticleId",SqlDbType.Int),
				new SqlParameter("@ShopId",SqlDbType.Int),
				new SqlParameter("@ArticleCls",SqlDbType.Int),
				new SqlParameter("@ArticleTitle",SqlDbType.VarChar),
				new SqlParameter("@Author",SqlDbType.VarChar),
				new SqlParameter("@ArticleContent",SqlDbType.VarChar),
				new SqlParameter("@ArticleUrl",SqlDbType.VarChar),
				new SqlParameter("@Status",SqlDbType.Int),
				new SqlParameter("@Addtime",SqlDbType.DateTime),
				new SqlParameter("@Updatetime",SqlDbType.DateTime)
				};				
				_param[0].Value=_ArticleModel.ArticleId;
				_param[1].Value=_ArticleModel.ShopId;
				_param[2].Value=_ArticleModel.ArticleCls;
				_param[3].Value=_ArticleModel.ArticleTitle;
				_param[4].Value=_ArticleModel.Author;
				_param[5].Value=_ArticleModel.ArticleContent;
				_param[6].Value=_ArticleModel.ArticleUrl;
				_param[7].Value=_ArticleModel.Status;
				_param[8].Value=_ArticleModel.Addtime;
				_param[9].Value=_ArticleModel.Updatetime;
			return SqlHelper.ExecuteNonQuery(WebConfig.WfxRW,CommandType.Text,sqlStr,_param);
		}
		/// <summary>
		/// 向数据表Article更新一条记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_ArticleModel">_ArticleModel</param>
		/// <returns>影响的行数</returns>
		public int Update(SqlTransaction sp,ArticleEntity _ArticleModel)
		{
            string sqlStr="update Article set [ShopId]=@ShopId,[ArticleCls]=@ArticleCls,[ArticleTitle]=@ArticleTitle,[Author]=@Author,[ArticleContent]=@ArticleContent,[ArticleUrl]=@ArticleUrl,[Status]=@Status,[Addtime]=@Addtime,[Updatetime]=@Updatetime where ArticleId=@ArticleId";
			SqlParameter[] _param={				
				new SqlParameter("@ArticleId",SqlDbType.Int),
				new SqlParameter("@ShopId",SqlDbType.Int),
				new SqlParameter("@ArticleCls",SqlDbType.Int),
				new SqlParameter("@ArticleTitle",SqlDbType.VarChar),
				new SqlParameter("@Author",SqlDbType.VarChar),
				new SqlParameter("@ArticleContent",SqlDbType.VarChar),
				new SqlParameter("@ArticleUrl",SqlDbType.VarChar),
				new SqlParameter("@Status",SqlDbType.Int),
				new SqlParameter("@Addtime",SqlDbType.DateTime),
				new SqlParameter("@Updatetime",SqlDbType.DateTime)
				};				
				_param[0].Value=_ArticleModel.ArticleId;
				_param[1].Value=_ArticleModel.ShopId;
				_param[2].Value=_ArticleModel.ArticleCls;
				_param[3].Value=_ArticleModel.ArticleTitle;
				_param[4].Value=_ArticleModel.Author;
				_param[5].Value=_ArticleModel.ArticleContent;
				_param[6].Value=_ArticleModel.ArticleUrl;
				_param[7].Value=_ArticleModel.Status;
				_param[8].Value=_ArticleModel.Addtime;
				_param[9].Value=_ArticleModel.Updatetime;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}		
		
		
		/// <summary>
		/// 删除数据表Article中的一条记录
		/// </summary>
	    /// <param name="ArticleId">articleId</param>
		/// <returns>影响的行数</returns>
		public int Delete(int ArticleId)
		{
			string sqlStr="delete from Article where [ArticleId]=@ArticleId";
			SqlParameter[] _param={			
			new SqlParameter("@ArticleId",SqlDbType.Int),
			
			};			
			_param[0].Value=ArticleId;
			return SqlHelper.ExecuteNonQuery(WebConfig.WfxRW,CommandType.Text,sqlStr,_param);
		}
		
		/// <summary>
		/// 删除数据表Article中的一条记录,带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
	    /// <param name="ArticleId">articleId</param>
		/// <returns>影响的行数</returns>
		public int Delete(SqlTransaction sp,int ArticleId)
		{
			string sqlStr="delete from Article where [ArticleId]=@ArticleId";
			SqlParameter[] _param={			
			new SqlParameter("@ArticleId",SqlDbType.Int),
			
			};			
			_param[0].Value=ArticleId;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}
		#endregion
		
		#region 数据实体
		/// <summary>
		/// 得到  article 数据实体
		/// </summary>
		/// <param name="row">row</param>
		/// <returns>article 数据实体</returns>
		public ArticleEntity Populate_ArticleEntity_FromDr(DataRow row)
		{
			ArticleEntity Obj = new ArticleEntity();
			if(row!=null)
			{
				Obj.ArticleId = (( row["ArticleId"])==DBNull.Value)?0:Convert.ToInt32( row["ArticleId"]);
				Obj.ShopId = (( row["ShopId"])==DBNull.Value)?0:Convert.ToInt32( row["ShopId"]);
				Obj.ArticleCls = (( row["ArticleCls"])==DBNull.Value)?0:Convert.ToInt32( row["ArticleCls"]);
				Obj.ArticleTitle =  row["ArticleTitle"].ToString();
				Obj.Author =  row["Author"].ToString();
				Obj.ArticleContent =  row["ArticleContent"].ToString();
				Obj.ArticleUrl =  row["ArticleUrl"].ToString();
				Obj.Status = (( row["Status"])==DBNull.Value)?0:Convert.ToInt32( row["Status"]);
				Obj.Addtime = (( row["Addtime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( row["Addtime"]);
				Obj.Updatetime = (( row["Updatetime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( row["Updatetime"]);
			}
			else
			{
				return null;
			}
			return Obj;
		}
		
        /// <summary>
		/// 得到  article 数据实体
		/// </summary>
		/// <param name="dr">dr</param>
		/// <returns>article 数据实体</returns>
		public ArticleEntity Populate_ArticleEntity_FromDr(IDataReader dr)
		{
			ArticleEntity Obj = new ArticleEntity();
			
				Obj.ArticleId = (( dr["ArticleId"])==DBNull.Value)?0:Convert.ToInt32( dr["ArticleId"]);
				Obj.ShopId = (( dr["ShopId"])==DBNull.Value)?0:Convert.ToInt32( dr["ShopId"]);
				Obj.ArticleCls = (( dr["ArticleCls"])==DBNull.Value)?0:Convert.ToInt32( dr["ArticleCls"]);
				Obj.ArticleTitle =  dr["ArticleTitle"].ToString();
				Obj.Author =  dr["Author"].ToString();
				Obj.ArticleContent =  dr["ArticleContent"].ToString();
				Obj.ArticleUrl =  dr["ArticleUrl"].ToString();
				Obj.Status = (( dr["Status"])==DBNull.Value)?0:Convert.ToInt32( dr["Status"]);
				Obj.Addtime = (( dr["Addtime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( dr["Addtime"]);
				Obj.Updatetime = (( dr["Updatetime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( dr["Updatetime"]);
			
			return Obj;
		}
		#endregion
		
		/// <summary>
		/// 根据ID,返回一个Article对象
		/// </summary>
		/// <param name="articleId">articleId</param>
		/// <returns>Article对象</returns>
		public ArticleEntity Get_ArticleEntity (int articleId)
		{
			ArticleEntity _obj=null;
			SqlParameter[] _param={
			new SqlParameter("@ArticleId",SqlDbType.Int)
			};
			_param[0].Value=articleId;
			string sqlStr="select * from Article with(nolock) where ArticleId=@ArticleId";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.WfxRW,CommandType.Text,sqlStr,_param))
			{
				while(dr.Read())
				{
            		_obj=Populate_ArticleEntity_FromDr(dr);
				}
			}
			return _obj;
		}
		/// <summary>
		/// 得到数据表Article所有记录
		/// </summary>
		/// <returns>数据集</returns>
		public IList< ArticleEntity> Get_ArticleAll()
		{
			IList< ArticleEntity> Obj=new List< ArticleEntity>();
			string sqlStr="select * from Article";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.WfxRW,CommandType.Text,sqlStr))
			{
				while(dr.Read())
				{
					Obj.Add(Populate_ArticleEntity_FromDr(dr));
				}
			}
			return Obj;
		}
		/// <summary>
        /// 检测是否存在根据主键
        /// </summary>
        /// <param name="articleId">articleId</param>
        /// <returns>是/否</returns>
		public bool IsExistArticle(int articleId)
		{
			SqlParameter[] _param={
                                      new SqlParameter("@articleId",SqlDbType.Int)
                                  };
            _param[0].Value=articleId;
            string sqlStr="select Count(*) from Article where ArticleId=@articleId";
            int a=Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.WfxRW,CommandType.Text,sqlStr,_param));
            if(a>0)
            {
                return true;
            }
            else
            {
                return false;
            }
		}

        #endregion
		
		#region----------自定义实例化接口函数----------
		#endregion
    }
}
