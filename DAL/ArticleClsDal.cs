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
    /// 数据层实例化接口类 dbo.ArticleCls.
    /// </summary>
    public partial class ArticleClsDataAccessLayer 
    {
		#region 构造函数


		/// <summary>
		/// 
		/// </summary>
		public ArticleClsDataAccessLayer()
		{
		}
		#endregion

        #region -----------实例化接口函数-----------
		
		#region 添加更新删除
		/// <summary>
		/// 向数据库中插入一条新记录。
		/// </summary>
		/// <param name="_ArticleClsModel">ArticleCls实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(ArticleClsEntity _ArticleClsModel)
		{
			string sqlStr="insert into ArticleCls([ShopId],[Clsname],[Status],[Addtime],[Updatetime]) values(@ShopId,@Clsname,@Status,@Addtime,@Updatetime) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@ShopId",SqlDbType.Int),
			new SqlParameter("@Clsname",SqlDbType.VarChar),
			new SqlParameter("@Status",SqlDbType.Int),
			new SqlParameter("@Addtime",SqlDbType.DateTime),
			new SqlParameter("@Updatetime",SqlDbType.DateTime)
			};			
			_param[0].Value=_ArticleClsModel.ShopId;
			_param[1].Value=_ArticleClsModel.Clsname;
			_param[2].Value=_ArticleClsModel.Status;
			_param[3].Value=_ArticleClsModel.Addtime;
			_param[4].Value=_ArticleClsModel.Updatetime;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.WfxRW,CommandType.Text,sqlStr,_param));
			return res;
		}
		/// <summary>
		/// 向数据库中插入一条新记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_ArticleClsModel">ArticleCls实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(SqlTransaction sp,ArticleClsEntity _ArticleClsModel)
		{
			string sqlStr="insert into ArticleCls([ShopId],[Clsname],[Status],[Addtime],[Updatetime]) values(@ShopId,@Clsname,@Status,@Addtime,@Updatetime) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@ShopId",SqlDbType.Int),
			new SqlParameter("@Clsname",SqlDbType.VarChar),
			new SqlParameter("@Status",SqlDbType.Int),
			new SqlParameter("@Addtime",SqlDbType.DateTime),
			new SqlParameter("@Updatetime",SqlDbType.DateTime)
			};			
			_param[0].Value=_ArticleClsModel.ShopId;
			_param[1].Value=_ArticleClsModel.Clsname;
			_param[2].Value=_ArticleClsModel.Status;
			_param[3].Value=_ArticleClsModel.Addtime;
			_param[4].Value=_ArticleClsModel.Updatetime;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(sp,CommandType.Text,sqlStr,_param));
			return res;
		}


		/// <summary>
		/// 向数据表ArticleCls更新一条记录。
		/// </summary>
		/// <param name="_ArticleClsModel">_ArticleClsModel</param>
		/// <returns>影响的行数</returns>
		public int Update(ArticleClsEntity _ArticleClsModel)
		{
            string sqlStr="update ArticleCls set [ShopId]=@ShopId,[Clsname]=@Clsname,[Status]=@Status,[Addtime]=@Addtime,[Updatetime]=@Updatetime where ClsId=@ClsId";
			SqlParameter[] _param={				
				new SqlParameter("@ClsId",SqlDbType.Int),
				new SqlParameter("@ShopId",SqlDbType.Int),
				new SqlParameter("@Clsname",SqlDbType.VarChar),
				new SqlParameter("@Status",SqlDbType.Int),
				new SqlParameter("@Addtime",SqlDbType.DateTime),
				new SqlParameter("@Updatetime",SqlDbType.DateTime)
				};				
				_param[0].Value=_ArticleClsModel.ClsId;
				_param[1].Value=_ArticleClsModel.ShopId;
				_param[2].Value=_ArticleClsModel.Clsname;
				_param[3].Value=_ArticleClsModel.Status;
				_param[4].Value=_ArticleClsModel.Addtime;
				_param[5].Value=_ArticleClsModel.Updatetime;
			return SqlHelper.ExecuteNonQuery(WebConfig.WfxRW,CommandType.Text,sqlStr,_param);
		}
		/// <summary>
		/// 向数据表ArticleCls更新一条记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_ArticleClsModel">_ArticleClsModel</param>
		/// <returns>影响的行数</returns>
		public int Update(SqlTransaction sp,ArticleClsEntity _ArticleClsModel)
		{
            string sqlStr="update ArticleCls set [ShopId]=@ShopId,[Clsname]=@Clsname,[Status]=@Status,[Addtime]=@Addtime,[Updatetime]=@Updatetime where ClsId=@ClsId";
			SqlParameter[] _param={				
				new SqlParameter("@ClsId",SqlDbType.Int),
				new SqlParameter("@ShopId",SqlDbType.Int),
				new SqlParameter("@Clsname",SqlDbType.VarChar),
				new SqlParameter("@Status",SqlDbType.Int),
				new SqlParameter("@Addtime",SqlDbType.DateTime),
				new SqlParameter("@Updatetime",SqlDbType.DateTime)
				};				
				_param[0].Value=_ArticleClsModel.ClsId;
				_param[1].Value=_ArticleClsModel.ShopId;
				_param[2].Value=_ArticleClsModel.Clsname;
				_param[3].Value=_ArticleClsModel.Status;
				_param[4].Value=_ArticleClsModel.Addtime;
				_param[5].Value=_ArticleClsModel.Updatetime;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}		
		
		
		/// <summary>
		/// 删除数据表ArticleCls中的一条记录
		/// </summary>
	    /// <param name="ClsId">clsId</param>
		/// <returns>影响的行数</returns>
		public int Delete(int ClsId)
		{
			string sqlStr="delete from ArticleCls where [ClsId]=@ClsId";
			SqlParameter[] _param={			
			new SqlParameter("@ClsId",SqlDbType.Int),
			
			};			
			_param[0].Value=ClsId;
			return SqlHelper.ExecuteNonQuery(WebConfig.WfxRW,CommandType.Text,sqlStr,_param);
		}
		
		/// <summary>
		/// 删除数据表ArticleCls中的一条记录,带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
	    /// <param name="ClsId">clsId</param>
		/// <returns>影响的行数</returns>
		public int Delete(SqlTransaction sp,int ClsId)
		{
			string sqlStr="delete from ArticleCls where [ClsId]=@ClsId";
			SqlParameter[] _param={			
			new SqlParameter("@ClsId",SqlDbType.Int),
			
			};			
			_param[0].Value=ClsId;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}
		#endregion
		
		#region 数据实体
		/// <summary>
		/// 得到  articlecls 数据实体
		/// </summary>
		/// <param name="row">row</param>
		/// <returns>articlecls 数据实体</returns>
		public ArticleClsEntity Populate_ArticleClsEntity_FromDr(DataRow row)
		{
			ArticleClsEntity Obj = new ArticleClsEntity();
			if(row!=null)
			{
				Obj.ClsId = (( row["ClsId"])==DBNull.Value)?0:Convert.ToInt32( row["ClsId"]);
				Obj.ShopId = (( row["ShopId"])==DBNull.Value)?0:Convert.ToInt32( row["ShopId"]);
				Obj.Clsname =  row["Clsname"].ToString();
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
		/// 得到  articlecls 数据实体
		/// </summary>
		/// <param name="dr">dr</param>
		/// <returns>articlecls 数据实体</returns>
		public ArticleClsEntity Populate_ArticleClsEntity_FromDr(IDataReader dr)
		{
			ArticleClsEntity Obj = new ArticleClsEntity();
			
				Obj.ClsId = (( dr["ClsId"])==DBNull.Value)?0:Convert.ToInt32( dr["ClsId"]);
				Obj.ShopId = (( dr["ShopId"])==DBNull.Value)?0:Convert.ToInt32( dr["ShopId"]);
				Obj.Clsname =  dr["Clsname"].ToString();
				Obj.Status = (( dr["Status"])==DBNull.Value)?0:Convert.ToInt32( dr["Status"]);
				Obj.Addtime = (( dr["Addtime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( dr["Addtime"]);
				Obj.Updatetime = (( dr["Updatetime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( dr["Updatetime"]);
			
			return Obj;
		}
		#endregion
		
		/// <summary>
		/// 根据ID,返回一个ArticleCls对象
		/// </summary>
		/// <param name="clsId">clsId</param>
		/// <returns>ArticleCls对象</returns>
		public ArticleClsEntity Get_ArticleClsEntity (int clsId)
		{
			ArticleClsEntity _obj=null;
			SqlParameter[] _param={
			new SqlParameter("@ClsId",SqlDbType.Int)
			};
			_param[0].Value=clsId;
			string sqlStr="select * from ArticleCls with(nolock) where ClsId=@ClsId";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.WfxRW,CommandType.Text,sqlStr,_param))
			{
				while(dr.Read())
				{
            		_obj=Populate_ArticleClsEntity_FromDr(dr);
				}
			}
			return _obj;
		}
		/// <summary>
		/// 得到数据表ArticleCls所有记录
		/// </summary>
		/// <returns>数据集</returns>
		public IList< ArticleClsEntity> Get_ArticleClsAll()
		{
			IList< ArticleClsEntity> Obj=new List< ArticleClsEntity>();
			string sqlStr="select * from ArticleCls";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.WfxRW,CommandType.Text,sqlStr))
			{
				while(dr.Read())
				{
					Obj.Add(Populate_ArticleClsEntity_FromDr(dr));
				}
			}
			return Obj;
		}
		/// <summary>
        /// 检测是否存在根据主键
        /// </summary>
        /// <param name="clsId">clsId</param>
        /// <returns>是/否</returns>
		public bool IsExistArticleCls(int clsId)
		{
			SqlParameter[] _param={
                                      new SqlParameter("@clsId",SqlDbType.Int)
                                  };
            _param[0].Value=clsId;
            string sqlStr="select Count(*) from ArticleCls where ClsId=@clsId";
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
