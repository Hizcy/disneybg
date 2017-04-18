// =================================================================== 
// 项目说明
//====================================================================
// yangxg。@Copy Right 2014
// 文件： T_OrdersItem.cs
// 项目名称：买车网
// 创建时间：2016/8/11
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
    /// 数据层实例化接口类 dbo.T_OrdersItem.
    /// </summary>
    public partial class T_OrdersItemDataAccessLayer 
    {
		#region 构造函数


		/// <summary>
		/// 
		/// </summary>
		public T_OrdersItemDataAccessLayer()
		{
		}
		#endregion

        #region -----------实例化接口函数-----------
		
		#region 添加更新删除
		/// <summary>
		/// 向数据库中插入一条新记录。
		/// </summary>
		/// <param name="_T_OrdersItemModel">T_OrdersItem实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(T_OrdersItemEntity _T_OrdersItemModel)
		{
			string sqlStr="insert into T_OrdersItem([OrderId],[ProductId],[Number],[Price],[CostPrice],[ProductSkuId]) values(@OrderId,@ProductId,@Number,@Price,@CostPrice,@ProductSkuId) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@OrderId",SqlDbType.Int),
			new SqlParameter("@ProductId",SqlDbType.Int),
			new SqlParameter("@Number",SqlDbType.Int),
			new SqlParameter("@Price",SqlDbType.Decimal),
			new SqlParameter("@CostPrice",SqlDbType.Decimal),
			new SqlParameter("@ProductSkuId",SqlDbType.Int)
			};			
			_param[0].Value=_T_OrdersItemModel.OrderId;
			_param[1].Value=_T_OrdersItemModel.ProductId;
			_param[2].Value=_T_OrdersItemModel.Number;
			_param[3].Value=_T_OrdersItemModel.Price;
			_param[4].Value=_T_OrdersItemModel.CostPrice;
			_param[5].Value=_T_OrdersItemModel.ProductSkuId;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.WfxRW,CommandType.Text,sqlStr,_param));
			return res;
		}
		/// <summary>
		/// 向数据库中插入一条新记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_T_OrdersItemModel">T_OrdersItem实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(SqlTransaction sp,T_OrdersItemEntity _T_OrdersItemModel)
		{
			string sqlStr="insert into T_OrdersItem([OrderId],[ProductId],[Number],[Price],[CostPrice],[ProductSkuId]) values(@OrderId,@ProductId,@Number,@Price,@CostPrice,@ProductSkuId) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@OrderId",SqlDbType.Int),
			new SqlParameter("@ProductId",SqlDbType.Int),
			new SqlParameter("@Number",SqlDbType.Int),
			new SqlParameter("@Price",SqlDbType.Decimal),
			new SqlParameter("@CostPrice",SqlDbType.Decimal),
			new SqlParameter("@ProductSkuId",SqlDbType.Int)
			};			
			_param[0].Value=_T_OrdersItemModel.OrderId;
			_param[1].Value=_T_OrdersItemModel.ProductId;
			_param[2].Value=_T_OrdersItemModel.Number;
			_param[3].Value=_T_OrdersItemModel.Price;
			_param[4].Value=_T_OrdersItemModel.CostPrice;
			_param[5].Value=_T_OrdersItemModel.ProductSkuId;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(sp,CommandType.Text,sqlStr,_param));
			return res;
		}


		/// <summary>
		/// 向数据表T_OrdersItem更新一条记录。
		/// </summary>
		/// <param name="_T_OrdersItemModel">_T_OrdersItemModel</param>
		/// <returns>影响的行数</returns>
		public int Update(T_OrdersItemEntity _T_OrdersItemModel)
		{
            string sqlStr="update T_OrdersItem set [OrderId]=@OrderId,[ProductId]=@ProductId,[Number]=@Number,[Price]=@Price,[CostPrice]=@CostPrice,[ProductSkuId]=@ProductSkuId where OrderItemId=@OrderItemId";
			SqlParameter[] _param={				
				new SqlParameter("@OrderItemId",SqlDbType.Int),
				new SqlParameter("@OrderId",SqlDbType.Int),
				new SqlParameter("@ProductId",SqlDbType.Int),
				new SqlParameter("@Number",SqlDbType.Int),
				new SqlParameter("@Price",SqlDbType.Decimal),
				new SqlParameter("@CostPrice",SqlDbType.Decimal),
				new SqlParameter("@ProductSkuId",SqlDbType.Int)
				};				
				_param[0].Value=_T_OrdersItemModel.OrderItemId;
				_param[1].Value=_T_OrdersItemModel.OrderId;
				_param[2].Value=_T_OrdersItemModel.ProductId;
				_param[3].Value=_T_OrdersItemModel.Number;
				_param[4].Value=_T_OrdersItemModel.Price;
				_param[5].Value=_T_OrdersItemModel.CostPrice;
				_param[6].Value=_T_OrdersItemModel.ProductSkuId;
			return SqlHelper.ExecuteNonQuery(WebConfig.WfxRW,CommandType.Text,sqlStr,_param);
		}
		/// <summary>
		/// 向数据表T_OrdersItem更新一条记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_T_OrdersItemModel">_T_OrdersItemModel</param>
		/// <returns>影响的行数</returns>
		public int Update(SqlTransaction sp,T_OrdersItemEntity _T_OrdersItemModel)
		{
            string sqlStr="update T_OrdersItem set [OrderId]=@OrderId,[ProductId]=@ProductId,[Number]=@Number,[Price]=@Price,[CostPrice]=@CostPrice,[ProductSkuId]=@ProductSkuId where OrderItemId=@OrderItemId";
			SqlParameter[] _param={				
				new SqlParameter("@OrderItemId",SqlDbType.Int),
				new SqlParameter("@OrderId",SqlDbType.Int),
				new SqlParameter("@ProductId",SqlDbType.Int),
				new SqlParameter("@Number",SqlDbType.Int),
				new SqlParameter("@Price",SqlDbType.Decimal),
				new SqlParameter("@CostPrice",SqlDbType.Decimal),
				new SqlParameter("@ProductSkuId",SqlDbType.Int)
				};				
				_param[0].Value=_T_OrdersItemModel.OrderItemId;
				_param[1].Value=_T_OrdersItemModel.OrderId;
				_param[2].Value=_T_OrdersItemModel.ProductId;
				_param[3].Value=_T_OrdersItemModel.Number;
				_param[4].Value=_T_OrdersItemModel.Price;
				_param[5].Value=_T_OrdersItemModel.CostPrice;
				_param[6].Value=_T_OrdersItemModel.ProductSkuId;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}		
		
		
		/// <summary>
		/// 删除数据表T_OrdersItem中的一条记录
		/// </summary>
	    /// <param name="OrderItemId">orderItemId</param>
		/// <returns>影响的行数</returns>
		public int Delete(int OrderItemId)
		{
			string sqlStr="delete from T_OrdersItem where [OrderItemId]=@OrderItemId";
			SqlParameter[] _param={			
			new SqlParameter("@OrderItemId",SqlDbType.Int),
			
			};			
			_param[0].Value=OrderItemId;
			return SqlHelper.ExecuteNonQuery(WebConfig.WfxRW,CommandType.Text,sqlStr,_param);
		}
		
		/// <summary>
		/// 删除数据表T_OrdersItem中的一条记录,带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
	    /// <param name="OrderItemId">orderItemId</param>
		/// <returns>影响的行数</returns>
		public int Delete(SqlTransaction sp,int OrderItemId)
		{
			string sqlStr="delete from T_OrdersItem where [OrderItemId]=@OrderItemId";
			SqlParameter[] _param={			
			new SqlParameter("@OrderItemId",SqlDbType.Int),
			
			};			
			_param[0].Value=OrderItemId;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}
		#endregion
		
		#region 数据实体
		/// <summary>
		/// 得到  t_ordersitem 数据实体
		/// </summary>
		/// <param name="row">row</param>
		/// <returns>t_ordersitem 数据实体</returns>
		public T_OrdersItemEntity Populate_T_OrdersItemEntity_FromDr(DataRow row)
		{
			T_OrdersItemEntity Obj = new T_OrdersItemEntity();
			if(row!=null)
			{
				Obj.OrderItemId = (( row["OrderItemId"])==DBNull.Value)?0:Convert.ToInt32( row["OrderItemId"]);
				Obj.OrderId = (( row["OrderId"])==DBNull.Value)?0:Convert.ToInt32( row["OrderId"]);
				Obj.ProductId = (( row["ProductId"])==DBNull.Value)?0:Convert.ToInt32( row["ProductId"]);
				Obj.Number = (( row["Number"])==DBNull.Value)?0:Convert.ToInt32( row["Number"]);
				Obj.Price = (( row["Price"])==DBNull.Value)?0:Convert.ToDecimal( row["Price"]);
				Obj.CostPrice = (( row["CostPrice"])==DBNull.Value)?0:Convert.ToDecimal( row["CostPrice"]);
				Obj.ProductSkuId = (( row["ProductSkuId"])==DBNull.Value)?0:Convert.ToInt32( row["ProductSkuId"]);
			}
			else
			{
				return null;
			}
			return Obj;
		}
		
        /// <summary>
		/// 得到  t_ordersitem 数据实体
		/// </summary>
		/// <param name="dr">dr</param>
		/// <returns>t_ordersitem 数据实体</returns>
		public T_OrdersItemEntity Populate_T_OrdersItemEntity_FromDr(IDataReader dr)
		{
			T_OrdersItemEntity Obj = new T_OrdersItemEntity();
			
				Obj.OrderItemId = (( dr["OrderItemId"])==DBNull.Value)?0:Convert.ToInt32( dr["OrderItemId"]);
				Obj.OrderId = (( dr["OrderId"])==DBNull.Value)?0:Convert.ToInt32( dr["OrderId"]);
				Obj.ProductId = (( dr["ProductId"])==DBNull.Value)?0:Convert.ToInt32( dr["ProductId"]);
				Obj.Number = (( dr["Number"])==DBNull.Value)?0:Convert.ToInt32( dr["Number"]);
				Obj.Price = (( dr["Price"])==DBNull.Value)?0:Convert.ToDecimal( dr["Price"]);
				Obj.CostPrice = (( dr["CostPrice"])==DBNull.Value)?0:Convert.ToDecimal( dr["CostPrice"]);
				Obj.ProductSkuId = (( dr["ProductSkuId"])==DBNull.Value)?0:Convert.ToInt32( dr["ProductSkuId"]);
			
			return Obj;
		}
		#endregion
		
		/// <summary>
		/// 根据ID,返回一个T_OrdersItem对象
		/// </summary>
		/// <param name="orderItemId">orderItemId</param>
		/// <returns>T_OrdersItem对象</returns>
		public T_OrdersItemEntity Get_T_OrdersItemEntity (int orderItemId)
		{
			T_OrdersItemEntity _obj=null;
			SqlParameter[] _param={
			new SqlParameter("@OrderItemId",SqlDbType.Int)
			};
			_param[0].Value=orderItemId;
			string sqlStr="select * from T_OrdersItem with(nolock) where OrderItemId=@OrderItemId";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.WfxRW,CommandType.Text,sqlStr,_param))
			{
				while(dr.Read())
				{
            		_obj=Populate_T_OrdersItemEntity_FromDr(dr);
				}
			}
			return _obj;
		}
		/// <summary>
		/// 得到数据表T_OrdersItem所有记录
		/// </summary>
		/// <returns>数据集</returns>
		public IList< T_OrdersItemEntity> Get_T_OrdersItemAll()
		{
			IList< T_OrdersItemEntity> Obj=new List< T_OrdersItemEntity>();
			string sqlStr="select * from T_OrdersItem";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.WfxRW,CommandType.Text,sqlStr))
			{
				while(dr.Read())
				{
					Obj.Add(Populate_T_OrdersItemEntity_FromDr(dr));
				}
			}
			return Obj;
		}
		/// <summary>
        /// 检测是否存在根据主键
        /// </summary>
        /// <param name="orderItemId">orderItemId</param>
        /// <returns>是/否</returns>
		public bool IsExistT_OrdersItem(int orderItemId)
		{
			SqlParameter[] _param={
                                      new SqlParameter("@orderItemId",SqlDbType.Int)
                                  };
            _param[0].Value=orderItemId;
            string sqlStr="select Count(*) from T_OrdersItem where OrderItemId=@orderItemId";
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
