// =================================================================== 
// 项目说明
//====================================================================
// yangxg。@Copy Right 2014
// 文件： wx_Shop.cs
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
    /// 数据层实例化接口类 dbo.wx_Shop.
    /// </summary>
    public partial class wx_ShopDataAccessLayer 
    {
		#region 构造函数


		/// <summary>
		/// 
		/// </summary>
		public wx_ShopDataAccessLayer()
		{
		}
		#endregion

        #region -----------实例化接口函数-----------
		
		#region 添加更新删除
		/// <summary>
		/// 向数据库中插入一条新记录。
		/// </summary>
		/// <param name="_wx_ShopModel">wx_Shop实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(wx_ShopEntity _wx_ShopModel)
		{
			string sqlStr="insert into wx_Shop([ShopName],[Description],[Images],[Status],[AddTime],[UpdateTime]) values(@ShopName,@Description,@Images,@Status,@AddTime,@UpdateTime) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@ShopName",SqlDbType.VarChar),
			new SqlParameter("@Description",SqlDbType.VarChar),
			new SqlParameter("@Images",SqlDbType.VarChar),
			new SqlParameter("@Status",SqlDbType.Int),
			new SqlParameter("@AddTime",SqlDbType.DateTime),
			new SqlParameter("@UpdateTime",SqlDbType.DateTime)
			};			
			_param[0].Value=_wx_ShopModel.ShopName;
			_param[1].Value=_wx_ShopModel.Description;
			_param[2].Value=_wx_ShopModel.Images;
			_param[3].Value=_wx_ShopModel.Status;
			_param[4].Value=_wx_ShopModel.AddTime;
			_param[5].Value=_wx_ShopModel.UpdateTime;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.WfxRW,CommandType.Text,sqlStr,_param));
			return res;
		}
		/// <summary>
		/// 向数据库中插入一条新记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_wx_ShopModel">wx_Shop实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(SqlTransaction sp,wx_ShopEntity _wx_ShopModel)
		{
			string sqlStr="insert into wx_Shop([ShopName],[Description],[Images],[Status],[AddTime],[UpdateTime]) values(@ShopName,@Description,@Images,@Status,@AddTime,@UpdateTime) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@ShopName",SqlDbType.VarChar),
			new SqlParameter("@Description",SqlDbType.VarChar),
			new SqlParameter("@Images",SqlDbType.VarChar),
			new SqlParameter("@Status",SqlDbType.Int),
			new SqlParameter("@AddTime",SqlDbType.DateTime),
			new SqlParameter("@UpdateTime",SqlDbType.DateTime)
			};			
			_param[0].Value=_wx_ShopModel.ShopName;
			_param[1].Value=_wx_ShopModel.Description;
			_param[2].Value=_wx_ShopModel.Images;
			_param[3].Value=_wx_ShopModel.Status;
			_param[4].Value=_wx_ShopModel.AddTime;
			_param[5].Value=_wx_ShopModel.UpdateTime;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(sp,CommandType.Text,sqlStr,_param));
			return res;
		}


		/// <summary>
		/// 向数据表wx_Shop更新一条记录。
		/// </summary>
		/// <param name="_wx_ShopModel">_wx_ShopModel</param>
		/// <returns>影响的行数</returns>
		public int Update(wx_ShopEntity _wx_ShopModel)
		{
            string sqlStr="update wx_Shop set [ShopName]=@ShopName,[Description]=@Description,[Images]=@Images,[Status]=@Status,[AddTime]=@AddTime,[UpdateTime]=@UpdateTime where ShopId=@ShopId";
			SqlParameter[] _param={				
				new SqlParameter("@ShopId",SqlDbType.Int),
				new SqlParameter("@ShopName",SqlDbType.VarChar),
				new SqlParameter("@Description",SqlDbType.VarChar),
				new SqlParameter("@Images",SqlDbType.VarChar),
				new SqlParameter("@Status",SqlDbType.Int),
				new SqlParameter("@AddTime",SqlDbType.DateTime),
				new SqlParameter("@UpdateTime",SqlDbType.DateTime)
				};				
				_param[0].Value=_wx_ShopModel.ShopId;
				_param[1].Value=_wx_ShopModel.ShopName;
				_param[2].Value=_wx_ShopModel.Description;
				_param[3].Value=_wx_ShopModel.Images;
				_param[4].Value=_wx_ShopModel.Status;
				_param[5].Value=_wx_ShopModel.AddTime;
				_param[6].Value=_wx_ShopModel.UpdateTime;
			return SqlHelper.ExecuteNonQuery(WebConfig.WfxRW,CommandType.Text,sqlStr,_param);
		}
		/// <summary>
		/// 向数据表wx_Shop更新一条记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_wx_ShopModel">_wx_ShopModel</param>
		/// <returns>影响的行数</returns>
		public int Update(SqlTransaction sp,wx_ShopEntity _wx_ShopModel)
		{
            string sqlStr="update wx_Shop set [ShopName]=@ShopName,[Description]=@Description,[Images]=@Images,[Status]=@Status,[AddTime]=@AddTime,[UpdateTime]=@UpdateTime where ShopId=@ShopId";
			SqlParameter[] _param={				
				new SqlParameter("@ShopId",SqlDbType.Int),
				new SqlParameter("@ShopName",SqlDbType.VarChar),
				new SqlParameter("@Description",SqlDbType.VarChar),
				new SqlParameter("@Images",SqlDbType.VarChar),
				new SqlParameter("@Status",SqlDbType.Int),
				new SqlParameter("@AddTime",SqlDbType.DateTime),
				new SqlParameter("@UpdateTime",SqlDbType.DateTime)
				};				
				_param[0].Value=_wx_ShopModel.ShopId;
				_param[1].Value=_wx_ShopModel.ShopName;
				_param[2].Value=_wx_ShopModel.Description;
				_param[3].Value=_wx_ShopModel.Images;
				_param[4].Value=_wx_ShopModel.Status;
				_param[5].Value=_wx_ShopModel.AddTime;
				_param[6].Value=_wx_ShopModel.UpdateTime;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}		
		
		
		/// <summary>
		/// 删除数据表wx_Shop中的一条记录
		/// </summary>
	    /// <param name="ShopId">shopId</param>
		/// <returns>影响的行数</returns>
		public int Delete(int ShopId)
		{
			string sqlStr="delete from wx_Shop where [ShopId]=@ShopId";
			SqlParameter[] _param={			
			new SqlParameter("@ShopId",SqlDbType.Int),
			
			};			
			_param[0].Value=ShopId;
			return SqlHelper.ExecuteNonQuery(WebConfig.WfxRW,CommandType.Text,sqlStr,_param);
		}
		
		/// <summary>
		/// 删除数据表wx_Shop中的一条记录,带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
	    /// <param name="ShopId">shopId</param>
		/// <returns>影响的行数</returns>
		public int Delete(SqlTransaction sp,int ShopId)
		{
			string sqlStr="delete from wx_Shop where [ShopId]=@ShopId";
			SqlParameter[] _param={			
			new SqlParameter("@ShopId",SqlDbType.Int),
			
			};			
			_param[0].Value=ShopId;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}
		#endregion
		
		#region 数据实体
		/// <summary>
		/// 得到  wx_shop 数据实体
		/// </summary>
		/// <param name="row">row</param>
		/// <returns>wx_shop 数据实体</returns>
		public wx_ShopEntity Populate_wx_ShopEntity_FromDr(DataRow row)
		{
			wx_ShopEntity Obj = new wx_ShopEntity();
			if(row!=null)
			{
				Obj.ShopId = (( row["ShopId"])==DBNull.Value)?0:Convert.ToInt32( row["ShopId"]);
				Obj.ShopName =  row["ShopName"].ToString();
				Obj.Description =  row["Description"].ToString();
				Obj.Images =  row["Images"].ToString();
				Obj.Status = (( row["Status"])==DBNull.Value)?0:Convert.ToInt32( row["Status"]);
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
		/// 得到  wx_shop 数据实体
		/// </summary>
		/// <param name="dr">dr</param>
		/// <returns>wx_shop 数据实体</returns>
		public wx_ShopEntity Populate_wx_ShopEntity_FromDr(IDataReader dr)
		{
			wx_ShopEntity Obj = new wx_ShopEntity();
			
				Obj.ShopId = (( dr["ShopId"])==DBNull.Value)?0:Convert.ToInt32( dr["ShopId"]);
				Obj.ShopName =  dr["ShopName"].ToString();
				Obj.Description =  dr["Description"].ToString();
				Obj.Images =  dr["Images"].ToString();
				Obj.Status = (( dr["Status"])==DBNull.Value)?0:Convert.ToInt32( dr["Status"]);
				Obj.AddTime = (( dr["AddTime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( dr["AddTime"]);
				Obj.UpdateTime = (( dr["UpdateTime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( dr["UpdateTime"]);
			
			return Obj;
		}
		#endregion
		
		/// <summary>
		/// 根据ID,返回一个wx_Shop对象
		/// </summary>
		/// <param name="shopId">shopId</param>
		/// <returns>wx_Shop对象</returns>
		public wx_ShopEntity Get_wx_ShopEntity (int shopId)
		{
			wx_ShopEntity _obj=null;
			SqlParameter[] _param={
			new SqlParameter("@ShopId",SqlDbType.Int)
			};
			_param[0].Value=shopId;
			string sqlStr="select * from wx_Shop with(nolock) where ShopId=@ShopId";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.WfxRW,CommandType.Text,sqlStr,_param))
			{
				while(dr.Read())
				{
            		_obj=Populate_wx_ShopEntity_FromDr(dr);
				}
			}
			return _obj;
		}
		/// <summary>
		/// 得到数据表wx_Shop所有记录
		/// </summary>
		/// <returns>数据集</returns>
		public IList< wx_ShopEntity> Get_wx_ShopAll()
		{
			IList< wx_ShopEntity> Obj=new List< wx_ShopEntity>();
			string sqlStr="select * from wx_Shop";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.WfxRW,CommandType.Text,sqlStr))
			{
				while(dr.Read())
				{
					Obj.Add(Populate_wx_ShopEntity_FromDr(dr));
				}
			}
			return Obj;
		}
		/// <summary>
        /// 检测是否存在根据主键
        /// </summary>
        /// <param name="shopId">shopId</param>
        /// <returns>是/否</returns>
		public bool IsExistwx_Shop(int shopId)
		{
			SqlParameter[] _param={
                                      new SqlParameter("@shopId",SqlDbType.Int)
                                  };
            _param[0].Value=shopId;
            string sqlStr="select Count(*) from wx_Shop where ShopId=@shopId";
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
