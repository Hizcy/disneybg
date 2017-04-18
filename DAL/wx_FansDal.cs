// =================================================================== 
// 项目说明
//====================================================================
// yangxg。@Copy Right 2014
// 文件： wx_Fans.cs
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
    /// 数据层实例化接口类 dbo.wx_Fans.
    /// </summary>
    public partial class wx_FansDataAccessLayer 
    {
		#region 构造函数


		/// <summary>
		/// 
		/// </summary>
		public wx_FansDataAccessLayer()
		{
		}
		#endregion

        #region -----------实例化接口函数-----------
		
		#region 添加更新删除
		/// <summary>
		/// 向数据库中插入一条新记录。
		/// </summary>
		/// <param name="_wx_FansModel">wx_Fans实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(wx_FansEntity _wx_FansModel)
		{
			string sqlStr="insert into wx_Fans([ShopId],[Me],[uid],[Status],[Addtime]) values(@ShopId,@Me,@uid,@Status,@Addtime) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@ShopId",SqlDbType.Int),
			new SqlParameter("@Me",SqlDbType.Int),
			new SqlParameter("@uid",SqlDbType.Int),
			new SqlParameter("@Status",SqlDbType.Int),
			new SqlParameter("@Addtime",SqlDbType.DateTime)
			};			
			_param[0].Value=_wx_FansModel.ShopId;
			_param[1].Value=_wx_FansModel.Me;
			_param[2].Value=_wx_FansModel.uid;
			_param[3].Value=_wx_FansModel.Status;
			_param[4].Value=_wx_FansModel.Addtime;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.WfxRW,CommandType.Text,sqlStr,_param));
			return res;
		}
		/// <summary>
		/// 向数据库中插入一条新记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_wx_FansModel">wx_Fans实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(SqlTransaction sp,wx_FansEntity _wx_FansModel)
		{
			string sqlStr="insert into wx_Fans([ShopId],[Me],[uid],[Status],[Addtime]) values(@ShopId,@Me,@uid,@Status,@Addtime) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@ShopId",SqlDbType.Int),
			new SqlParameter("@Me",SqlDbType.Int),
			new SqlParameter("@uid",SqlDbType.Int),
			new SqlParameter("@Status",SqlDbType.Int),
			new SqlParameter("@Addtime",SqlDbType.DateTime)
			};			
			_param[0].Value=_wx_FansModel.ShopId;
			_param[1].Value=_wx_FansModel.Me;
			_param[2].Value=_wx_FansModel.uid;
			_param[3].Value=_wx_FansModel.Status;
			_param[4].Value=_wx_FansModel.Addtime;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(sp,CommandType.Text,sqlStr,_param));
			return res;
		}


		/// <summary>
		/// 向数据表wx_Fans更新一条记录。
		/// </summary>
		/// <param name="_wx_FansModel">_wx_FansModel</param>
		/// <returns>影响的行数</returns>
		public int Update(wx_FansEntity _wx_FansModel)
		{
            string sqlStr="update wx_Fans set [ShopId]=@ShopId,[Me]=@Me,[uid]=@uid,[Status]=@Status,[Addtime]=@Addtime where Id=@Id";
			SqlParameter[] _param={				
				new SqlParameter("@Id",SqlDbType.Int),
				new SqlParameter("@ShopId",SqlDbType.Int),
				new SqlParameter("@Me",SqlDbType.Int),
				new SqlParameter("@uid",SqlDbType.Int),
				new SqlParameter("@Status",SqlDbType.Int),
				new SqlParameter("@Addtime",SqlDbType.DateTime)
				};				
				_param[0].Value=_wx_FansModel.Id;
				_param[1].Value=_wx_FansModel.ShopId;
				_param[2].Value=_wx_FansModel.Me;
				_param[3].Value=_wx_FansModel.uid;
				_param[4].Value=_wx_FansModel.Status;
				_param[5].Value=_wx_FansModel.Addtime;
			return SqlHelper.ExecuteNonQuery(WebConfig.WfxRW,CommandType.Text,sqlStr,_param);
		}
		/// <summary>
		/// 向数据表wx_Fans更新一条记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_wx_FansModel">_wx_FansModel</param>
		/// <returns>影响的行数</returns>
		public int Update(SqlTransaction sp,wx_FansEntity _wx_FansModel)
		{
            string sqlStr="update wx_Fans set [ShopId]=@ShopId,[Me]=@Me,[uid]=@uid,[Status]=@Status,[Addtime]=@Addtime where Id=@Id";
			SqlParameter[] _param={				
				new SqlParameter("@Id",SqlDbType.Int),
				new SqlParameter("@ShopId",SqlDbType.Int),
				new SqlParameter("@Me",SqlDbType.Int),
				new SqlParameter("@uid",SqlDbType.Int),
				new SqlParameter("@Status",SqlDbType.Int),
				new SqlParameter("@Addtime",SqlDbType.DateTime)
				};				
				_param[0].Value=_wx_FansModel.Id;
				_param[1].Value=_wx_FansModel.ShopId;
				_param[2].Value=_wx_FansModel.Me;
				_param[3].Value=_wx_FansModel.uid;
				_param[4].Value=_wx_FansModel.Status;
				_param[5].Value=_wx_FansModel.Addtime;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}		
		
		
		/// <summary>
		/// 删除数据表wx_Fans中的一条记录
		/// </summary>
	    /// <param name="Id">id</param>
		/// <returns>影响的行数</returns>
		public int Delete(int Id)
		{
			string sqlStr="delete from wx_Fans where [Id]=@Id";
			SqlParameter[] _param={			
			new SqlParameter("@Id",SqlDbType.Int),
			
			};			
			_param[0].Value=Id;
			return SqlHelper.ExecuteNonQuery(WebConfig.WfxRW,CommandType.Text,sqlStr,_param);
		}
		
		/// <summary>
		/// 删除数据表wx_Fans中的一条记录,带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
	    /// <param name="Id">id</param>
		/// <returns>影响的行数</returns>
		public int Delete(SqlTransaction sp,int Id)
		{
			string sqlStr="delete from wx_Fans where [Id]=@Id";
			SqlParameter[] _param={			
			new SqlParameter("@Id",SqlDbType.Int),
			
			};			
			_param[0].Value=Id;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}
		#endregion
		
		#region 数据实体
		/// <summary>
		/// 得到  wx_fans 数据实体
		/// </summary>
		/// <param name="row">row</param>
		/// <returns>wx_fans 数据实体</returns>
		public wx_FansEntity Populate_wx_FansEntity_FromDr(DataRow row)
		{
			wx_FansEntity Obj = new wx_FansEntity();
			if(row!=null)
			{
				Obj.Id = (( row["Id"])==DBNull.Value)?0:Convert.ToInt32( row["Id"]);
				Obj.ShopId = (( row["ShopId"])==DBNull.Value)?0:Convert.ToInt32( row["ShopId"]);
				Obj.Me = (( row["Me"])==DBNull.Value)?0:Convert.ToInt32( row["Me"]);
				Obj.uid = (( row["uid"])==DBNull.Value)?0:Convert.ToInt32( row["uid"]);
				Obj.Status = (( row["Status"])==DBNull.Value)?0:Convert.ToInt32( row["Status"]);
				Obj.Addtime = (( row["Addtime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( row["Addtime"]);
			}
			else
			{
				return null;
			}
			return Obj;
		}
		
        /// <summary>
		/// 得到  wx_fans 数据实体
		/// </summary>
		/// <param name="dr">dr</param>
		/// <returns>wx_fans 数据实体</returns>
		public wx_FansEntity Populate_wx_FansEntity_FromDr(IDataReader dr)
		{
			wx_FansEntity Obj = new wx_FansEntity();
			
				Obj.Id = (( dr["Id"])==DBNull.Value)?0:Convert.ToInt32( dr["Id"]);
				Obj.ShopId = (( dr["ShopId"])==DBNull.Value)?0:Convert.ToInt32( dr["ShopId"]);
				Obj.Me = (( dr["Me"])==DBNull.Value)?0:Convert.ToInt32( dr["Me"]);
				Obj.uid = (( dr["uid"])==DBNull.Value)?0:Convert.ToInt32( dr["uid"]);
				Obj.Status = (( dr["Status"])==DBNull.Value)?0:Convert.ToInt32( dr["Status"]);
				Obj.Addtime = (( dr["Addtime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( dr["Addtime"]);
			
			return Obj;
		}
		#endregion
		
		/// <summary>
		/// 根据ID,返回一个wx_Fans对象
		/// </summary>
		/// <param name="id">id</param>
		/// <returns>wx_Fans对象</returns>
		public wx_FansEntity Get_wx_FansEntity (int id)
		{
			wx_FansEntity _obj=null;
			SqlParameter[] _param={
			new SqlParameter("@Id",SqlDbType.Int)
			};
			_param[0].Value=id;
			string sqlStr="select * from wx_Fans with(nolock) where Id=@Id";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.WfxRW,CommandType.Text,sqlStr,_param))
			{
				while(dr.Read())
				{
            		_obj=Populate_wx_FansEntity_FromDr(dr);
				}
			}
			return _obj;
		}
		/// <summary>
		/// 得到数据表wx_Fans所有记录
		/// </summary>
		/// <returns>数据集</returns>
		public IList< wx_FansEntity> Get_wx_FansAll()
		{
			IList< wx_FansEntity> Obj=new List< wx_FansEntity>();
			string sqlStr="select * from wx_Fans";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.WfxRW,CommandType.Text,sqlStr))
			{
				while(dr.Read())
				{
					Obj.Add(Populate_wx_FansEntity_FromDr(dr));
				}
			}
			return Obj;
		}
		/// <summary>
        /// 检测是否存在根据主键
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>是/否</returns>
		public bool IsExistwx_Fans(int id)
		{
			SqlParameter[] _param={
                                      new SqlParameter("@id",SqlDbType.Int)
                                  };
            _param[0].Value=id;
            string sqlStr="select Count(*) from wx_Fans where Id=@id";
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
