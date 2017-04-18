// =================================================================== 
// 项目说明
//====================================================================
// yangxg。@Copy Right 2014
// 文件： wx_OpenInfo.cs
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
    /// 数据层实例化接口类 dbo.wx_OpenInfo.
    /// </summary>
    public partial class wx_OpenInfoDataAccessLayer 
    {
		#region 构造函数


		/// <summary>
		/// 
		/// </summary>
		public wx_OpenInfoDataAccessLayer()
		{
		}
		#endregion

        #region -----------实例化接口函数-----------
		
		#region 添加更新删除
		/// <summary>
		/// 向数据库中插入一条新记录。
		/// </summary>
		/// <param name="_wx_OpenInfoModel">wx_OpenInfo实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(wx_OpenInfoEntity _wx_OpenInfoModel)
		{
			string sqlStr="insert into wx_OpenInfo([access_token],[expires_in],[refresh_token],[openid],[scope],[AddTime],[UpdateTime]) values(@access_token,@expires_in,@refresh_token,@openid,@scope,@AddTime,@UpdateTime) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@access_token",SqlDbType.VarChar),
			new SqlParameter("@expires_in",SqlDbType.Int),
			new SqlParameter("@refresh_token",SqlDbType.VarChar),
			new SqlParameter("@openid",SqlDbType.VarChar),
			new SqlParameter("@scope",SqlDbType.VarChar),
			new SqlParameter("@AddTime",SqlDbType.DateTime),
			new SqlParameter("@UpdateTime",SqlDbType.DateTime)
			};			
			_param[0].Value=_wx_OpenInfoModel.access_token;
			_param[1].Value=_wx_OpenInfoModel.expires_in;
			_param[2].Value=_wx_OpenInfoModel.refresh_token;
			_param[3].Value=_wx_OpenInfoModel.openid;
			_param[4].Value=_wx_OpenInfoModel.scope;
			_param[5].Value=_wx_OpenInfoModel.AddTime;
			_param[6].Value=_wx_OpenInfoModel.UpdateTime;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.WfxRW,CommandType.Text,sqlStr,_param));
			return res;
		}
		/// <summary>
		/// 向数据库中插入一条新记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_wx_OpenInfoModel">wx_OpenInfo实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(SqlTransaction sp,wx_OpenInfoEntity _wx_OpenInfoModel)
		{
			string sqlStr="insert into wx_OpenInfo([access_token],[expires_in],[refresh_token],[openid],[scope],[AddTime],[UpdateTime]) values(@access_token,@expires_in,@refresh_token,@openid,@scope,@AddTime,@UpdateTime) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@access_token",SqlDbType.VarChar),
			new SqlParameter("@expires_in",SqlDbType.Int),
			new SqlParameter("@refresh_token",SqlDbType.VarChar),
			new SqlParameter("@openid",SqlDbType.VarChar),
			new SqlParameter("@scope",SqlDbType.VarChar),
			new SqlParameter("@AddTime",SqlDbType.DateTime),
			new SqlParameter("@UpdateTime",SqlDbType.DateTime)
			};			
			_param[0].Value=_wx_OpenInfoModel.access_token;
			_param[1].Value=_wx_OpenInfoModel.expires_in;
			_param[2].Value=_wx_OpenInfoModel.refresh_token;
			_param[3].Value=_wx_OpenInfoModel.openid;
			_param[4].Value=_wx_OpenInfoModel.scope;
			_param[5].Value=_wx_OpenInfoModel.AddTime;
			_param[6].Value=_wx_OpenInfoModel.UpdateTime;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(sp,CommandType.Text,sqlStr,_param));
			return res;
		}


		/// <summary>
		/// 向数据表wx_OpenInfo更新一条记录。
		/// </summary>
		/// <param name="_wx_OpenInfoModel">_wx_OpenInfoModel</param>
		/// <returns>影响的行数</returns>
		public int Update(wx_OpenInfoEntity _wx_OpenInfoModel)
		{
            string sqlStr="update wx_OpenInfo set [access_token]=@access_token,[expires_in]=@expires_in,[refresh_token]=@refresh_token,[openid]=@openid,[scope]=@scope,[AddTime]=@AddTime,[UpdateTime]=@UpdateTime where Id=@Id";
			SqlParameter[] _param={				
				new SqlParameter("@Id",SqlDbType.Int),
				new SqlParameter("@access_token",SqlDbType.VarChar),
				new SqlParameter("@expires_in",SqlDbType.Int),
				new SqlParameter("@refresh_token",SqlDbType.VarChar),
				new SqlParameter("@openid",SqlDbType.VarChar),
				new SqlParameter("@scope",SqlDbType.VarChar),
				new SqlParameter("@AddTime",SqlDbType.DateTime),
				new SqlParameter("@UpdateTime",SqlDbType.DateTime)
				};				
				_param[0].Value=_wx_OpenInfoModel.Id;
				_param[1].Value=_wx_OpenInfoModel.access_token;
				_param[2].Value=_wx_OpenInfoModel.expires_in;
				_param[3].Value=_wx_OpenInfoModel.refresh_token;
				_param[4].Value=_wx_OpenInfoModel.openid;
				_param[5].Value=_wx_OpenInfoModel.scope;
				_param[6].Value=_wx_OpenInfoModel.AddTime;
				_param[7].Value=_wx_OpenInfoModel.UpdateTime;
			return SqlHelper.ExecuteNonQuery(WebConfig.WfxRW,CommandType.Text,sqlStr,_param);
		}
		/// <summary>
		/// 向数据表wx_OpenInfo更新一条记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_wx_OpenInfoModel">_wx_OpenInfoModel</param>
		/// <returns>影响的行数</returns>
		public int Update(SqlTransaction sp,wx_OpenInfoEntity _wx_OpenInfoModel)
		{
            string sqlStr="update wx_OpenInfo set [access_token]=@access_token,[expires_in]=@expires_in,[refresh_token]=@refresh_token,[openid]=@openid,[scope]=@scope,[AddTime]=@AddTime,[UpdateTime]=@UpdateTime where Id=@Id";
			SqlParameter[] _param={				
				new SqlParameter("@Id",SqlDbType.Int),
				new SqlParameter("@access_token",SqlDbType.VarChar),
				new SqlParameter("@expires_in",SqlDbType.Int),
				new SqlParameter("@refresh_token",SqlDbType.VarChar),
				new SqlParameter("@openid",SqlDbType.VarChar),
				new SqlParameter("@scope",SqlDbType.VarChar),
				new SqlParameter("@AddTime",SqlDbType.DateTime),
				new SqlParameter("@UpdateTime",SqlDbType.DateTime)
				};				
				_param[0].Value=_wx_OpenInfoModel.Id;
				_param[1].Value=_wx_OpenInfoModel.access_token;
				_param[2].Value=_wx_OpenInfoModel.expires_in;
				_param[3].Value=_wx_OpenInfoModel.refresh_token;
				_param[4].Value=_wx_OpenInfoModel.openid;
				_param[5].Value=_wx_OpenInfoModel.scope;
				_param[6].Value=_wx_OpenInfoModel.AddTime;
				_param[7].Value=_wx_OpenInfoModel.UpdateTime;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}		
		
		
		/// <summary>
		/// 删除数据表wx_OpenInfo中的一条记录
		/// </summary>
	    /// <param name="Id">id</param>
		/// <returns>影响的行数</returns>
		public int Delete(int Id)
		{
			string sqlStr="delete from wx_OpenInfo where [Id]=@Id";
			SqlParameter[] _param={			
			new SqlParameter("@Id",SqlDbType.Int),
			
			};			
			_param[0].Value=Id;
			return SqlHelper.ExecuteNonQuery(WebConfig.WfxRW,CommandType.Text,sqlStr,_param);
		}
		
		/// <summary>
		/// 删除数据表wx_OpenInfo中的一条记录,带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
	    /// <param name="Id">id</param>
		/// <returns>影响的行数</returns>
		public int Delete(SqlTransaction sp,int Id)
		{
			string sqlStr="delete from wx_OpenInfo where [Id]=@Id";
			SqlParameter[] _param={			
			new SqlParameter("@Id",SqlDbType.Int),
			
			};			
			_param[0].Value=Id;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}
		#endregion
		
		#region 数据实体
		/// <summary>
		/// 得到  wx_openinfo 数据实体
		/// </summary>
		/// <param name="row">row</param>
		/// <returns>wx_openinfo 数据实体</returns>
		public wx_OpenInfoEntity Populate_wx_OpenInfoEntity_FromDr(DataRow row)
		{
			wx_OpenInfoEntity Obj = new wx_OpenInfoEntity();
			if(row!=null)
			{
				Obj.Id = (( row["Id"])==DBNull.Value)?0:Convert.ToInt32( row["Id"]);
				Obj.access_token =  row["access_token"].ToString();
				Obj.expires_in = (( row["expires_in"])==DBNull.Value)?0:Convert.ToInt32( row["expires_in"]);
				Obj.refresh_token =  row["refresh_token"].ToString();
				Obj.openid =  row["openid"].ToString();
				Obj.scope =  row["scope"].ToString();
				Obj.AddTime = (( row["AddTime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( row["AddTime"]);
				Obj.UpdateTime = (( row["UpdateTime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( row["UpdateTime"]);
			}
			else
			{
				return null;
			}
			return Obj;
		}
		
        /// <summary>
		/// 得到  wx_openinfo 数据实体
		/// </summary>
		/// <param name="dr">dr</param>
		/// <returns>wx_openinfo 数据实体</returns>
		public wx_OpenInfoEntity Populate_wx_OpenInfoEntity_FromDr(IDataReader dr)
		{
			wx_OpenInfoEntity Obj = new wx_OpenInfoEntity();
			
				Obj.Id = (( dr["Id"])==DBNull.Value)?0:Convert.ToInt32( dr["Id"]);
				Obj.access_token =  dr["access_token"].ToString();
				Obj.expires_in = (( dr["expires_in"])==DBNull.Value)?0:Convert.ToInt32( dr["expires_in"]);
				Obj.refresh_token =  dr["refresh_token"].ToString();
				Obj.openid =  dr["openid"].ToString();
				Obj.scope =  dr["scope"].ToString();
				Obj.AddTime = (( dr["AddTime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( dr["AddTime"]);
				Obj.UpdateTime = (( dr["UpdateTime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( dr["UpdateTime"]);
			
			return Obj;
		}
		#endregion
		
		/// <summary>
		/// 根据ID,返回一个wx_OpenInfo对象
		/// </summary>
		/// <param name="id">id</param>
		/// <returns>wx_OpenInfo对象</returns>
		public wx_OpenInfoEntity Get_wx_OpenInfoEntity (int id)
		{
			wx_OpenInfoEntity _obj=null;
			SqlParameter[] _param={
			new SqlParameter("@Id",SqlDbType.Int)
			};
			_param[0].Value=id;
			string sqlStr="select * from wx_OpenInfo with(nolock) where Id=@Id";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.WfxRW,CommandType.Text,sqlStr,_param))
			{
				while(dr.Read())
				{
            		_obj=Populate_wx_OpenInfoEntity_FromDr(dr);
				}
			}
			return _obj;
		}
		/// <summary>
		/// 得到数据表wx_OpenInfo所有记录
		/// </summary>
		/// <returns>数据集</returns>
		public IList< wx_OpenInfoEntity> Get_wx_OpenInfoAll()
		{
			IList< wx_OpenInfoEntity> Obj=new List< wx_OpenInfoEntity>();
			string sqlStr="select * from wx_OpenInfo";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.WfxRW,CommandType.Text,sqlStr))
			{
				while(dr.Read())
				{
					Obj.Add(Populate_wx_OpenInfoEntity_FromDr(dr));
				}
			}
			return Obj;
		}
		/// <summary>
        /// 检测是否存在根据主键
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>是/否</returns>
		public bool IsExistwx_OpenInfo(int id)
		{
			SqlParameter[] _param={
                                      new SqlParameter("@id",SqlDbType.Int)
                                  };
            _param[0].Value=id;
            string sqlStr="select Count(*) from wx_OpenInfo where Id=@id";
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
