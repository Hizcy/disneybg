// =================================================================== 
// 项目说明
//====================================================================
// yangxg。@Copy Right 2014
// 文件： Carts.cs
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
    /// 数据层实例化接口类 dbo.Carts.
    /// </summary>
    public partial class CartsDataAccessLayer 
    {
		#region 构造函数


		/// <summary>
		/// 
		/// </summary>
		public CartsDataAccessLayer()
		{
		}
		#endregion

        #region -----------实例化接口函数-----------
		
		#region 添加更新删除
		/// <summary>
		/// 向数据库中插入一条新记录。
		/// </summary>
		/// <param name="_CartsModel">Carts实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(CartsEntity _CartsModel)
		{
			string sqlStr="insert into Carts([ProductId],[uid],[Number],[Status],[AddTime],[UpdateTime]) values(@ProductId,@uid,@Number,@Status,@AddTime,@UpdateTime) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@ProductId",SqlDbType.Int),
			new SqlParameter("@uid",SqlDbType.VarChar),
			new SqlParameter("@Number",SqlDbType.Int),
			new SqlParameter("@Status",SqlDbType.Int),
			new SqlParameter("@AddTime",SqlDbType.DateTime),
			new SqlParameter("@UpdateTime",SqlDbType.DateTime)
			};			
			_param[0].Value=_CartsModel.ProductId;
			_param[1].Value=_CartsModel.uid;
			_param[2].Value=_CartsModel.Number;
			_param[3].Value=_CartsModel.Status;
			_param[4].Value=_CartsModel.AddTime;
			_param[5].Value=_CartsModel.UpdateTime;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.WfxRW,CommandType.Text,sqlStr,_param));
			return res;
		}
		/// <summary>
		/// 向数据库中插入一条新记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_CartsModel">Carts实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(SqlTransaction sp,CartsEntity _CartsModel)
		{
			string sqlStr="insert into Carts([ProductId],[uid],[Number],[Status],[AddTime],[UpdateTime]) values(@ProductId,@uid,@Number,@Status,@AddTime,@UpdateTime) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@ProductId",SqlDbType.Int),
			new SqlParameter("@uid",SqlDbType.VarChar),
			new SqlParameter("@Number",SqlDbType.Int),
			new SqlParameter("@Status",SqlDbType.Int),
			new SqlParameter("@AddTime",SqlDbType.DateTime),
			new SqlParameter("@UpdateTime",SqlDbType.DateTime)
			};			
			_param[0].Value=_CartsModel.ProductId;
			_param[1].Value=_CartsModel.uid;
			_param[2].Value=_CartsModel.Number;
			_param[3].Value=_CartsModel.Status;
			_param[4].Value=_CartsModel.AddTime;
			_param[5].Value=_CartsModel.UpdateTime;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(sp,CommandType.Text,sqlStr,_param));
			return res;
		}


		/// <summary>
		/// 向数据表Carts更新一条记录。
		/// </summary>
		/// <param name="_CartsModel">_CartsModel</param>
		/// <returns>影响的行数</returns>
		public int Update(CartsEntity _CartsModel)
		{
            string sqlStr="update Carts set [ProductId]=@ProductId,[uid]=@uid,[Number]=@Number,[Status]=@Status,[AddTime]=@AddTime,[UpdateTime]=@UpdateTime where CartId=@CartId";
			SqlParameter[] _param={				
				new SqlParameter("@CartId",SqlDbType.Int),
				new SqlParameter("@ProductId",SqlDbType.Int),
				new SqlParameter("@uid",SqlDbType.VarChar),
				new SqlParameter("@Number",SqlDbType.Int),
				new SqlParameter("@Status",SqlDbType.Int),
				new SqlParameter("@AddTime",SqlDbType.DateTime),
				new SqlParameter("@UpdateTime",SqlDbType.DateTime)
				};				
				_param[0].Value=_CartsModel.CartId;
				_param[1].Value=_CartsModel.ProductId;
				_param[2].Value=_CartsModel.uid;
				_param[3].Value=_CartsModel.Number;
				_param[4].Value=_CartsModel.Status;
				_param[5].Value=_CartsModel.AddTime;
				_param[6].Value=_CartsModel.UpdateTime;
			return SqlHelper.ExecuteNonQuery(WebConfig.WfxRW,CommandType.Text,sqlStr,_param);
		}
		/// <summary>
		/// 向数据表Carts更新一条记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_CartsModel">_CartsModel</param>
		/// <returns>影响的行数</returns>
		public int Update(SqlTransaction sp,CartsEntity _CartsModel)
		{
            string sqlStr="update Carts set [ProductId]=@ProductId,[uid]=@uid,[Number]=@Number,[Status]=@Status,[AddTime]=@AddTime,[UpdateTime]=@UpdateTime where CartId=@CartId";
			SqlParameter[] _param={				
				new SqlParameter("@CartId",SqlDbType.Int),
				new SqlParameter("@ProductId",SqlDbType.Int),
				new SqlParameter("@uid",SqlDbType.VarChar),
				new SqlParameter("@Number",SqlDbType.Int),
				new SqlParameter("@Status",SqlDbType.Int),
				new SqlParameter("@AddTime",SqlDbType.DateTime),
				new SqlParameter("@UpdateTime",SqlDbType.DateTime)
				};				
				_param[0].Value=_CartsModel.CartId;
				_param[1].Value=_CartsModel.ProductId;
				_param[2].Value=_CartsModel.uid;
				_param[3].Value=_CartsModel.Number;
				_param[4].Value=_CartsModel.Status;
				_param[5].Value=_CartsModel.AddTime;
				_param[6].Value=_CartsModel.UpdateTime;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}		
		
		
		/// <summary>
		/// 删除数据表Carts中的一条记录
		/// </summary>
	    /// <param name="CartId">cartId</param>
		/// <returns>影响的行数</returns>
		public int Delete(int CartId)
		{
			string sqlStr="delete from Carts where [CartId]=@CartId";
			SqlParameter[] _param={			
			new SqlParameter("@CartId",SqlDbType.Int),
			
			};			
			_param[0].Value=CartId;
			return SqlHelper.ExecuteNonQuery(WebConfig.WfxRW,CommandType.Text,sqlStr,_param);
		}
		
		/// <summary>
		/// 删除数据表Carts中的一条记录,带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
	    /// <param name="CartId">cartId</param>
		/// <returns>影响的行数</returns>
		public int Delete(SqlTransaction sp,int CartId)
		{
			string sqlStr="delete from Carts where [CartId]=@CartId";
			SqlParameter[] _param={			
			new SqlParameter("@CartId",SqlDbType.Int),
			
			};			
			_param[0].Value=CartId;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}
		#endregion
		
		#region 数据实体
		/// <summary>
		/// 得到  carts 数据实体
		/// </summary>
		/// <param name="row">row</param>
		/// <returns>carts 数据实体</returns>
		public CartsEntity Populate_CartsEntity_FromDr(DataRow row)
		{
			CartsEntity Obj = new CartsEntity();
			if(row!=null)
			{
				Obj.CartId = (( row["CartId"])==DBNull.Value)?0:Convert.ToInt32( row["CartId"]);
				Obj.ProductId = (( row["ProductId"])==DBNull.Value)?0:Convert.ToInt32( row["ProductId"]);
				Obj.uid =  row["uid"].ToString();
				Obj.Number = (( row["Number"])==DBNull.Value)?0:Convert.ToInt32( row["Number"]);
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
		/// 得到  carts 数据实体
		/// </summary>
		/// <param name="dr">dr</param>
		/// <returns>carts 数据实体</returns>
		public CartsEntity Populate_CartsEntity_FromDr(IDataReader dr)
		{
			CartsEntity Obj = new CartsEntity();
			
				Obj.CartId = (( dr["CartId"])==DBNull.Value)?0:Convert.ToInt32( dr["CartId"]);
				Obj.ProductId = (( dr["ProductId"])==DBNull.Value)?0:Convert.ToInt32( dr["ProductId"]);
				Obj.uid =  dr["uid"].ToString();
				Obj.Number = (( dr["Number"])==DBNull.Value)?0:Convert.ToInt32( dr["Number"]);
				Obj.Status = (( dr["Status"])==DBNull.Value)?0:Convert.ToInt32( dr["Status"]);
				Obj.AddTime = (( dr["AddTime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( dr["AddTime"]);
				Obj.UpdateTime = (( dr["UpdateTime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( dr["UpdateTime"]);
			
			return Obj;
		}
		#endregion
		
		/// <summary>
		/// 根据ID,返回一个Carts对象
		/// </summary>
		/// <param name="cartId">cartId</param>
		/// <returns>Carts对象</returns>
		public CartsEntity Get_CartsEntity (int cartId)
		{
			CartsEntity _obj=null;
			SqlParameter[] _param={
			new SqlParameter("@CartId",SqlDbType.Int)
			};
			_param[0].Value=cartId;
			string sqlStr="select * from Carts with(nolock) where CartId=@CartId";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.WfxRW,CommandType.Text,sqlStr,_param))
			{
				while(dr.Read())
				{
            		_obj=Populate_CartsEntity_FromDr(dr);
				}
			}
			return _obj;
		}
		/// <summary>
		/// 得到数据表Carts所有记录
		/// </summary>
		/// <returns>数据集</returns>
		public IList< CartsEntity> Get_CartsAll()
		{
			IList< CartsEntity> Obj=new List< CartsEntity>();
			string sqlStr="select * from Carts";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.WfxRW,CommandType.Text,sqlStr))
			{
				while(dr.Read())
				{
					Obj.Add(Populate_CartsEntity_FromDr(dr));
				}
			}
			return Obj;
		}
		/// <summary>
        /// 检测是否存在根据主键
        /// </summary>
        /// <param name="cartId">cartId</param>
        /// <returns>是/否</returns>
		public bool IsExistCarts(int cartId)
		{
			SqlParameter[] _param={
                                      new SqlParameter("@cartId",SqlDbType.Int)
                                  };
            _param[0].Value=cartId;
            string sqlStr="select Count(*) from Carts where CartId=@cartId";
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
