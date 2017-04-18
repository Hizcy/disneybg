// =================================================================== 
// 项目说明
//====================================================================
// yangxg。@Copy Right 2014
// 文件： OrdersItem.cs
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
    /// 数据层实例化接口类 dbo.OrdersItem.
    /// </summary>
    public partial class OrdersItemDataAccessLayer 
    {
		#region 构造函数


		/// <summary>
		/// 
		/// </summary>
		public OrdersItemDataAccessLayer()
		{
		}
		#endregion

        #region -----------实例化接口函数-----------
		
		#region 添加更新删除
		/// <summary>
		/// 向数据库中插入一条新记录。
		/// </summary>
		/// <param name="_OrdersItemModel">OrdersItem实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(OrdersItemEntity _OrdersItemModel)
		{
			string sqlStr="insert into OrdersItem([OrderId],[ProductId],[Number],[Price],[CostPrice]) values(@OrderId,@ProductId,@Number,@Price,@CostPrice) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@OrderId",SqlDbType.Int),
			new SqlParameter("@ProductId",SqlDbType.Int),
			new SqlParameter("@Number",SqlDbType.Int),
			new SqlParameter("@Price",SqlDbType.Decimal),
			new SqlParameter("@CostPrice",SqlDbType.Decimal)
			};			
			_param[0].Value=_OrdersItemModel.OrderId;
			_param[1].Value=_OrdersItemModel.ProductId;
			_param[2].Value=_OrdersItemModel.Number;
			_param[3].Value=_OrdersItemModel.Price;
			_param[4].Value=_OrdersItemModel.CostPrice;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.WfxRW,CommandType.Text,sqlStr,_param));
			return res;
		}
		/// <summary>
		/// 向数据库中插入一条新记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_OrdersItemModel">OrdersItem实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(SqlTransaction sp,OrdersItemEntity _OrdersItemModel)
		{
			string sqlStr="insert into OrdersItem([OrderId],[ProductId],[Number],[Price],[CostPrice]) values(@OrderId,@ProductId,@Number,@Price,@CostPrice) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@OrderId",SqlDbType.Int),
			new SqlParameter("@ProductId",SqlDbType.Int),
			new SqlParameter("@Number",SqlDbType.Int),
			new SqlParameter("@Price",SqlDbType.Decimal),
			new SqlParameter("@CostPrice",SqlDbType.Decimal)
			};			
			_param[0].Value=_OrdersItemModel.OrderId;
			_param[1].Value=_OrdersItemModel.ProductId;
			_param[2].Value=_OrdersItemModel.Number;
			_param[3].Value=_OrdersItemModel.Price;
			_param[4].Value=_OrdersItemModel.CostPrice;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(sp,CommandType.Text,sqlStr,_param));
			return res;
		}


		/// <summary>
		/// 向数据表OrdersItem更新一条记录。
		/// </summary>
		/// <param name="_OrdersItemModel">_OrdersItemModel</param>
		/// <returns>影响的行数</returns>
		public int Update(OrdersItemEntity _OrdersItemModel)
		{
            string sqlStr="update OrdersItem set [OrderId]=@OrderId,[ProductId]=@ProductId,[Number]=@Number,[Price]=@Price,[CostPrice]=@CostPrice where OrderItemId=@OrderItemId";
			SqlParameter[] _param={				
				new SqlParameter("@OrderItemId",SqlDbType.Int),
				new SqlParameter("@OrderId",SqlDbType.Int),
				new SqlParameter("@ProductId",SqlDbType.Int),
				new SqlParameter("@Number",SqlDbType.Int),
				new SqlParameter("@Price",SqlDbType.Decimal),
				new SqlParameter("@CostPrice",SqlDbType.Decimal)
				};				
				_param[0].Value=_OrdersItemModel.OrderItemId;
				_param[1].Value=_OrdersItemModel.OrderId;
				_param[2].Value=_OrdersItemModel.ProductId;
				_param[3].Value=_OrdersItemModel.Number;
				_param[4].Value=_OrdersItemModel.Price;
				_param[5].Value=_OrdersItemModel.CostPrice;
			return SqlHelper.ExecuteNonQuery(WebConfig.WfxRW,CommandType.Text,sqlStr,_param);
		}
		/// <summary>
		/// 向数据表OrdersItem更新一条记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_OrdersItemModel">_OrdersItemModel</param>
		/// <returns>影响的行数</returns>
		public int Update(SqlTransaction sp,OrdersItemEntity _OrdersItemModel)
		{
            string sqlStr="update OrdersItem set [OrderId]=@OrderId,[ProductId]=@ProductId,[Number]=@Number,[Price]=@Price,[CostPrice]=@CostPrice where OrderItemId=@OrderItemId";
			SqlParameter[] _param={				
				new SqlParameter("@OrderItemId",SqlDbType.Int),
				new SqlParameter("@OrderId",SqlDbType.Int),
				new SqlParameter("@ProductId",SqlDbType.Int),
				new SqlParameter("@Number",SqlDbType.Int),
				new SqlParameter("@Price",SqlDbType.Decimal),
				new SqlParameter("@CostPrice",SqlDbType.Decimal)
				};				
				_param[0].Value=_OrdersItemModel.OrderItemId;
				_param[1].Value=_OrdersItemModel.OrderId;
				_param[2].Value=_OrdersItemModel.ProductId;
				_param[3].Value=_OrdersItemModel.Number;
				_param[4].Value=_OrdersItemModel.Price;
				_param[5].Value=_OrdersItemModel.CostPrice;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}		
		
		
		/// <summary>
		/// 删除数据表OrdersItem中的一条记录
		/// </summary>
	    /// <param name="OrderItemId">orderItemId</param>
		/// <returns>影响的行数</returns>
		public int Delete(int OrderItemId)
		{
			string sqlStr="delete from OrdersItem where [OrderItemId]=@OrderItemId";
			SqlParameter[] _param={			
			new SqlParameter("@OrderItemId",SqlDbType.Int),
			
			};			
			_param[0].Value=OrderItemId;
			return SqlHelper.ExecuteNonQuery(WebConfig.WfxRW,CommandType.Text,sqlStr,_param);
		}
		
		/// <summary>
		/// 删除数据表OrdersItem中的一条记录,带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
	    /// <param name="OrderItemId">orderItemId</param>
		/// <returns>影响的行数</returns>
		public int Delete(SqlTransaction sp,int OrderItemId)
		{
			string sqlStr="delete from OrdersItem where [OrderItemId]=@OrderItemId";
			SqlParameter[] _param={			
			new SqlParameter("@OrderItemId",SqlDbType.Int),
			
			};			
			_param[0].Value=OrderItemId;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}
		#endregion
		
		#region 数据实体
		/// <summary>
		/// 得到  ordersitem 数据实体
		/// </summary>
		/// <param name="row">row</param>
		/// <returns>ordersitem 数据实体</returns>
		public OrdersItemEntity Populate_OrdersItemEntity_FromDr(DataRow row)
		{
			OrdersItemEntity Obj = new OrdersItemEntity();
			if(row!=null)
			{
				Obj.OrderItemId = (( row["OrderItemId"])==DBNull.Value)?0:Convert.ToInt32( row["OrderItemId"]);
				Obj.OrderId = (( row["OrderId"])==DBNull.Value)?0:Convert.ToInt32( row["OrderId"]);
				Obj.ProductId = (( row["ProductId"])==DBNull.Value)?0:Convert.ToInt32( row["ProductId"]);
				Obj.Number = (( row["Number"])==DBNull.Value)?0:Convert.ToInt32( row["Number"]);
				Obj.Price = (( row["Price"])==DBNull.Value)?0:Convert.ToDecimal( row["Price"]);
				Obj.CostPrice = (( row["CostPrice"])==DBNull.Value)?0:Convert.ToDecimal( row["CostPrice"]);
			}
			else
			{
				return null;
			}
			return Obj;
		}
		
        /// <summary>
		/// 得到  ordersitem 数据实体
		/// </summary>
		/// <param name="dr">dr</param>
		/// <returns>ordersitem 数据实体</returns>
		public OrdersItemEntity Populate_OrdersItemEntity_FromDr(IDataReader dr)
		{
			OrdersItemEntity Obj = new OrdersItemEntity();
			
				Obj.OrderItemId = (( dr["OrderItemId"])==DBNull.Value)?0:Convert.ToInt32( dr["OrderItemId"]);
				Obj.OrderId = (( dr["OrderId"])==DBNull.Value)?0:Convert.ToInt32( dr["OrderId"]);
				Obj.ProductId = (( dr["ProductId"])==DBNull.Value)?0:Convert.ToInt32( dr["ProductId"]);
				Obj.Number = (( dr["Number"])==DBNull.Value)?0:Convert.ToInt32( dr["Number"]);
				Obj.Price = (( dr["Price"])==DBNull.Value)?0:Convert.ToDecimal( dr["Price"]);
				Obj.CostPrice = (( dr["CostPrice"])==DBNull.Value)?0:Convert.ToDecimal( dr["CostPrice"]);
			
			return Obj;
		}
		#endregion
		
		/// <summary>
		/// 根据ID,返回一个OrdersItem对象
		/// </summary>
		/// <param name="orderItemId">orderItemId</param>
		/// <returns>OrdersItem对象</returns>
		public OrdersItemEntity Get_OrdersItemEntity (int orderItemId)
		{
			OrdersItemEntity _obj=null;
			SqlParameter[] _param={
			new SqlParameter("@OrderItemId",SqlDbType.Int)
			};
			_param[0].Value=orderItemId;
			string sqlStr="select * from OrdersItem with(nolock) where OrderItemId=@OrderItemId";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.WfxRW,CommandType.Text,sqlStr,_param))
			{
				while(dr.Read())
				{
            		_obj=Populate_OrdersItemEntity_FromDr(dr);
				}
			}
			return _obj;
		}
		/// <summary>
		/// 得到数据表OrdersItem所有记录
		/// </summary>
		/// <returns>数据集</returns>
		public IList< OrdersItemEntity> Get_OrdersItemAll()
		{
			IList< OrdersItemEntity> Obj=new List< OrdersItemEntity>();
			string sqlStr="select * from OrdersItem";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.WfxRW,CommandType.Text,sqlStr))
			{
				while(dr.Read())
				{
					Obj.Add(Populate_OrdersItemEntity_FromDr(dr));
				}
			}
			return Obj;
		}
		/// <summary>
        /// 检测是否存在根据主键
        /// </summary>
        /// <param name="orderItemId">orderItemId</param>
        /// <returns>是/否</returns>
		public bool IsExistOrdersItem(int orderItemId)
		{
			SqlParameter[] _param={
                                      new SqlParameter("@orderItemId",SqlDbType.Int)
                                  };
            _param[0].Value=orderItemId;
            string sqlStr="select Count(*) from OrdersItem where OrderItemId=@orderItemId";
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
