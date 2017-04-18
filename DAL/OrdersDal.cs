// =================================================================== 
// 项目说明
//====================================================================
// yangxg。@Copy Right 2014
// 文件： Orders.cs
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
    /// 数据层实例化接口类 dbo.Orders.
    /// </summary>
    public partial class OrdersDataAccessLayer 
    {
		#region 构造函数


		/// <summary>
		/// 
		/// </summary>
		public OrdersDataAccessLayer()
		{
		}
		#endregion

        #region -----------实例化接口函数-----------
		
		#region 添加更新删除
		/// <summary>
		/// 向数据库中插入一条新记录。
		/// </summary>
		/// <param name="_OrdersModel">Orders实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(OrdersEntity _OrdersModel)
		{
			string sqlStr="insert into Orders([OrderCode],[UserId],[PaymentId],[TotalPrice],[Postage],[Status],[Consignee],[LocationId],[Buyer],[Phone],[Address],[Description],[AddTime],[UpdateTime],[ConfirmTime],[SendTime],[expresstype],[expresscode],[ordertype],[RefundTime],[ReturnTime]) values(@OrderCode,@UserId,@PaymentId,@TotalPrice,@Postage,@Status,@Consignee,@LocationId,@Buyer,@Phone,@Address,@Description,@AddTime,@UpdateTime,@ConfirmTime,@SendTime,@expresstype,@expresscode,@ordertype,@RefundTime,@ReturnTime) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@OrderCode",SqlDbType.VarChar),
			new SqlParameter("@UserId",SqlDbType.Int),
			new SqlParameter("@PaymentId",SqlDbType.Int),
			new SqlParameter("@TotalPrice",SqlDbType.Decimal),
			new SqlParameter("@Postage",SqlDbType.Decimal),
			new SqlParameter("@Status",SqlDbType.Int),
			new SqlParameter("@Consignee",SqlDbType.VarChar),
			new SqlParameter("@LocationId",SqlDbType.Int),
			new SqlParameter("@Buyer",SqlDbType.VarChar),
			new SqlParameter("@Phone",SqlDbType.VarChar),
			new SqlParameter("@Address",SqlDbType.VarChar),
			new SqlParameter("@Description",SqlDbType.VarChar),
			new SqlParameter("@AddTime",SqlDbType.DateTime),
			new SqlParameter("@UpdateTime",SqlDbType.DateTime),
			new SqlParameter("@ConfirmTime",SqlDbType.DateTime),
			new SqlParameter("@SendTime",SqlDbType.DateTime),
			new SqlParameter("@expresstype",SqlDbType.Int),
			new SqlParameter("@expresscode",SqlDbType.VarChar),
			new SqlParameter("@ordertype",SqlDbType.Int),
			new SqlParameter("@RefundTime",SqlDbType.DateTime),
			new SqlParameter("@ReturnTime",SqlDbType.DateTime)
			};			
			_param[0].Value=_OrdersModel.OrderCode;
			_param[1].Value=_OrdersModel.UserId;
			_param[2].Value=_OrdersModel.PaymentId;
			_param[3].Value=_OrdersModel.TotalPrice;
			_param[4].Value=_OrdersModel.Postage;
			_param[5].Value=_OrdersModel.Status;
			_param[6].Value=_OrdersModel.Consignee;
			_param[7].Value=_OrdersModel.LocationId;
			_param[8].Value=_OrdersModel.Buyer;
			_param[9].Value=_OrdersModel.Phone;
			_param[10].Value=_OrdersModel.Address;
			_param[11].Value=_OrdersModel.Description;
			_param[12].Value=_OrdersModel.AddTime;
			_param[13].Value=_OrdersModel.UpdateTime;
			_param[14].Value=_OrdersModel.ConfirmTime;
			_param[15].Value=_OrdersModel.SendTime;
			_param[16].Value=_OrdersModel.expresstype;
			_param[17].Value=_OrdersModel.expresscode;
			_param[18].Value=_OrdersModel.ordertype;
			_param[19].Value=_OrdersModel.RefundTime;
			_param[20].Value=_OrdersModel.ReturnTime;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.WfxRW,CommandType.Text,sqlStr,_param));
			return res;
		}
		/// <summary>
		/// 向数据库中插入一条新记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_OrdersModel">Orders实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(SqlTransaction sp,OrdersEntity _OrdersModel)
		{
			string sqlStr="insert into Orders([OrderCode],[UserId],[PaymentId],[TotalPrice],[Postage],[Status],[Consignee],[LocationId],[Buyer],[Phone],[Address],[Description],[AddTime],[UpdateTime],[ConfirmTime],[SendTime],[expresstype],[expresscode],[ordertype],[RefundTime],[ReturnTime]) values(@OrderCode,@UserId,@PaymentId,@TotalPrice,@Postage,@Status,@Consignee,@LocationId,@Buyer,@Phone,@Address,@Description,@AddTime,@UpdateTime,@ConfirmTime,@SendTime,@expresstype,@expresscode,@ordertype,@RefundTime,@ReturnTime) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@OrderCode",SqlDbType.VarChar),
			new SqlParameter("@UserId",SqlDbType.Int),
			new SqlParameter("@PaymentId",SqlDbType.Int),
			new SqlParameter("@TotalPrice",SqlDbType.Decimal),
			new SqlParameter("@Postage",SqlDbType.Decimal),
			new SqlParameter("@Status",SqlDbType.Int),
			new SqlParameter("@Consignee",SqlDbType.VarChar),
			new SqlParameter("@LocationId",SqlDbType.Int),
			new SqlParameter("@Buyer",SqlDbType.VarChar),
			new SqlParameter("@Phone",SqlDbType.VarChar),
			new SqlParameter("@Address",SqlDbType.VarChar),
			new SqlParameter("@Description",SqlDbType.VarChar),
			new SqlParameter("@AddTime",SqlDbType.DateTime),
			new SqlParameter("@UpdateTime",SqlDbType.DateTime),
			new SqlParameter("@ConfirmTime",SqlDbType.DateTime),
			new SqlParameter("@SendTime",SqlDbType.DateTime),
			new SqlParameter("@expresstype",SqlDbType.Int),
			new SqlParameter("@expresscode",SqlDbType.VarChar),
			new SqlParameter("@ordertype",SqlDbType.Int),
			new SqlParameter("@RefundTime",SqlDbType.DateTime),
			new SqlParameter("@ReturnTime",SqlDbType.DateTime)
			};			
			_param[0].Value=_OrdersModel.OrderCode;
			_param[1].Value=_OrdersModel.UserId;
			_param[2].Value=_OrdersModel.PaymentId;
			_param[3].Value=_OrdersModel.TotalPrice;
			_param[4].Value=_OrdersModel.Postage;
			_param[5].Value=_OrdersModel.Status;
			_param[6].Value=_OrdersModel.Consignee;
			_param[7].Value=_OrdersModel.LocationId;
			_param[8].Value=_OrdersModel.Buyer;
			_param[9].Value=_OrdersModel.Phone;
			_param[10].Value=_OrdersModel.Address;
			_param[11].Value=_OrdersModel.Description;
			_param[12].Value=_OrdersModel.AddTime;
			_param[13].Value=_OrdersModel.UpdateTime;
			_param[14].Value=_OrdersModel.ConfirmTime;
			_param[15].Value=_OrdersModel.SendTime;
			_param[16].Value=_OrdersModel.expresstype;
			_param[17].Value=_OrdersModel.expresscode;
			_param[18].Value=_OrdersModel.ordertype;
			_param[19].Value=_OrdersModel.RefundTime;
			_param[20].Value=_OrdersModel.ReturnTime;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(sp,CommandType.Text,sqlStr,_param));
			return res;
		}


		/// <summary>
		/// 向数据表Orders更新一条记录。
		/// </summary>
		/// <param name="_OrdersModel">_OrdersModel</param>
		/// <returns>影响的行数</returns>
		public int Update(OrdersEntity _OrdersModel)
		{
            string sqlStr="update Orders set [OrderCode]=@OrderCode,[UserId]=@UserId,[PaymentId]=@PaymentId,[TotalPrice]=@TotalPrice,[Postage]=@Postage,[Status]=@Status,[Consignee]=@Consignee,[LocationId]=@LocationId,[Buyer]=@Buyer,[Phone]=@Phone,[Address]=@Address,[Description]=@Description,[AddTime]=@AddTime,[UpdateTime]=@UpdateTime,[ConfirmTime]=@ConfirmTime,[SendTime]=@SendTime,[expresstype]=@expresstype,[expresscode]=@expresscode,[ordertype]=@ordertype,[RefundTime]=@RefundTime,[ReturnTime]=@ReturnTime where OrderId=@OrderId";
			SqlParameter[] _param={				
				new SqlParameter("@OrderId",SqlDbType.Int),
				new SqlParameter("@OrderCode",SqlDbType.VarChar),
				new SqlParameter("@UserId",SqlDbType.Int),
				new SqlParameter("@PaymentId",SqlDbType.Int),
				new SqlParameter("@TotalPrice",SqlDbType.Decimal),
				new SqlParameter("@Postage",SqlDbType.Decimal),
				new SqlParameter("@Status",SqlDbType.Int),
				new SqlParameter("@Consignee",SqlDbType.VarChar),
				new SqlParameter("@LocationId",SqlDbType.Int),
				new SqlParameter("@Buyer",SqlDbType.VarChar),
				new SqlParameter("@Phone",SqlDbType.VarChar),
				new SqlParameter("@Address",SqlDbType.VarChar),
				new SqlParameter("@Description",SqlDbType.VarChar),
				new SqlParameter("@AddTime",SqlDbType.DateTime),
				new SqlParameter("@UpdateTime",SqlDbType.DateTime),
				new SqlParameter("@ConfirmTime",SqlDbType.DateTime),
				new SqlParameter("@SendTime",SqlDbType.DateTime),
				new SqlParameter("@expresstype",SqlDbType.Int),
				new SqlParameter("@expresscode",SqlDbType.VarChar),
				new SqlParameter("@ordertype",SqlDbType.Int),
				new SqlParameter("@RefundTime",SqlDbType.DateTime),
				new SqlParameter("@ReturnTime",SqlDbType.DateTime)
				};				
				_param[0].Value=_OrdersModel.OrderId;
				_param[1].Value=_OrdersModel.OrderCode;
				_param[2].Value=_OrdersModel.UserId;
				_param[3].Value=_OrdersModel.PaymentId;
				_param[4].Value=_OrdersModel.TotalPrice;
				_param[5].Value=_OrdersModel.Postage;
				_param[6].Value=_OrdersModel.Status;
				_param[7].Value=_OrdersModel.Consignee;
				_param[8].Value=_OrdersModel.LocationId;
				_param[9].Value=_OrdersModel.Buyer;
				_param[10].Value=_OrdersModel.Phone;
				_param[11].Value=_OrdersModel.Address;
				_param[12].Value=_OrdersModel.Description;
				_param[13].Value=_OrdersModel.AddTime;
				_param[14].Value=_OrdersModel.UpdateTime;
				_param[15].Value=_OrdersModel.ConfirmTime;
				_param[16].Value=_OrdersModel.SendTime;
				_param[17].Value=_OrdersModel.expresstype;
				_param[18].Value=_OrdersModel.expresscode;
				_param[19].Value=_OrdersModel.ordertype;
				_param[20].Value=_OrdersModel.RefundTime;
				_param[21].Value=_OrdersModel.ReturnTime;
			return SqlHelper.ExecuteNonQuery(WebConfig.WfxRW,CommandType.Text,sqlStr,_param);
		}
		/// <summary>
		/// 向数据表Orders更新一条记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_OrdersModel">_OrdersModel</param>
		/// <returns>影响的行数</returns>
		public int Update(SqlTransaction sp,OrdersEntity _OrdersModel)
		{
            string sqlStr="update Orders set [OrderCode]=@OrderCode,[UserId]=@UserId,[PaymentId]=@PaymentId,[TotalPrice]=@TotalPrice,[Postage]=@Postage,[Status]=@Status,[Consignee]=@Consignee,[LocationId]=@LocationId,[Buyer]=@Buyer,[Phone]=@Phone,[Address]=@Address,[Description]=@Description,[AddTime]=@AddTime,[UpdateTime]=@UpdateTime,[ConfirmTime]=@ConfirmTime,[SendTime]=@SendTime,[expresstype]=@expresstype,[expresscode]=@expresscode,[ordertype]=@ordertype,[RefundTime]=@RefundTime,[ReturnTime]=@ReturnTime where OrderId=@OrderId";
			SqlParameter[] _param={				
				new SqlParameter("@OrderId",SqlDbType.Int),
				new SqlParameter("@OrderCode",SqlDbType.VarChar),
				new SqlParameter("@UserId",SqlDbType.Int),
				new SqlParameter("@PaymentId",SqlDbType.Int),
				new SqlParameter("@TotalPrice",SqlDbType.Decimal),
				new SqlParameter("@Postage",SqlDbType.Decimal),
				new SqlParameter("@Status",SqlDbType.Int),
				new SqlParameter("@Consignee",SqlDbType.VarChar),
				new SqlParameter("@LocationId",SqlDbType.Int),
				new SqlParameter("@Buyer",SqlDbType.VarChar),
				new SqlParameter("@Phone",SqlDbType.VarChar),
				new SqlParameter("@Address",SqlDbType.VarChar),
				new SqlParameter("@Description",SqlDbType.VarChar),
				new SqlParameter("@AddTime",SqlDbType.DateTime),
				new SqlParameter("@UpdateTime",SqlDbType.DateTime),
				new SqlParameter("@ConfirmTime",SqlDbType.DateTime),
				new SqlParameter("@SendTime",SqlDbType.DateTime),
				new SqlParameter("@expresstype",SqlDbType.Int),
				new SqlParameter("@expresscode",SqlDbType.VarChar),
				new SqlParameter("@ordertype",SqlDbType.Int),
				new SqlParameter("@RefundTime",SqlDbType.DateTime),
				new SqlParameter("@ReturnTime",SqlDbType.DateTime)
				};				
				_param[0].Value=_OrdersModel.OrderId;
				_param[1].Value=_OrdersModel.OrderCode;
				_param[2].Value=_OrdersModel.UserId;
				_param[3].Value=_OrdersModel.PaymentId;
				_param[4].Value=_OrdersModel.TotalPrice;
				_param[5].Value=_OrdersModel.Postage;
				_param[6].Value=_OrdersModel.Status;
				_param[7].Value=_OrdersModel.Consignee;
				_param[8].Value=_OrdersModel.LocationId;
				_param[9].Value=_OrdersModel.Buyer;
				_param[10].Value=_OrdersModel.Phone;
				_param[11].Value=_OrdersModel.Address;
				_param[12].Value=_OrdersModel.Description;
				_param[13].Value=_OrdersModel.AddTime;
				_param[14].Value=_OrdersModel.UpdateTime;
				_param[15].Value=_OrdersModel.ConfirmTime;
				_param[16].Value=_OrdersModel.SendTime;
				_param[17].Value=_OrdersModel.expresstype;
				_param[18].Value=_OrdersModel.expresscode;
				_param[19].Value=_OrdersModel.ordertype;
				_param[20].Value=_OrdersModel.RefundTime;
				_param[21].Value=_OrdersModel.ReturnTime;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}		
		
		
		/// <summary>
		/// 删除数据表Orders中的一条记录
		/// </summary>
	    /// <param name="OrderId">orderId</param>
		/// <returns>影响的行数</returns>
		public int Delete(int OrderId)
		{
			string sqlStr="delete from Orders where [OrderId]=@OrderId";
			SqlParameter[] _param={			
			new SqlParameter("@OrderId",SqlDbType.Int),
			
			};			
			_param[0].Value=OrderId;
			return SqlHelper.ExecuteNonQuery(WebConfig.WfxRW,CommandType.Text,sqlStr,_param);
		}
		
		/// <summary>
		/// 删除数据表Orders中的一条记录,带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
	    /// <param name="OrderId">orderId</param>
		/// <returns>影响的行数</returns>
		public int Delete(SqlTransaction sp,int OrderId)
		{
			string sqlStr="delete from Orders where [OrderId]=@OrderId";
			SqlParameter[] _param={			
			new SqlParameter("@OrderId",SqlDbType.Int),
			
			};			
			_param[0].Value=OrderId;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}
		#endregion
		
		#region 数据实体
		/// <summary>
		/// 得到  orders 数据实体
		/// </summary>
		/// <param name="row">row</param>
		/// <returns>orders 数据实体</returns>
		public OrdersEntity Populate_OrdersEntity_FromDr(DataRow row)
		{
			OrdersEntity Obj = new OrdersEntity();
			if(row!=null)
			{
				Obj.OrderId = (( row["OrderId"])==DBNull.Value)?0:Convert.ToInt32( row["OrderId"]);
				Obj.OrderCode =  row["OrderCode"].ToString();
				Obj.UserId = (( row["UserId"])==DBNull.Value)?0:Convert.ToInt32( row["UserId"]);
				Obj.PaymentId = (( row["PaymentId"])==DBNull.Value)?0:Convert.ToInt32( row["PaymentId"]);
				Obj.TotalPrice = (( row["TotalPrice"])==DBNull.Value)?0:Convert.ToDecimal( row["TotalPrice"]);
				Obj.Postage = (( row["Postage"])==DBNull.Value)?0:Convert.ToDecimal( row["Postage"]);
				Obj.Status = (( row["Status"])==DBNull.Value)?0:Convert.ToInt32( row["Status"]);
				Obj.Consignee =  row["Consignee"].ToString();
				Obj.LocationId = (( row["LocationId"])==DBNull.Value)?0:Convert.ToInt32( row["LocationId"]);
				Obj.Buyer =  row["Buyer"].ToString();
				Obj.Phone =  row["Phone"].ToString();
				Obj.Address =  row["Address"].ToString();
				Obj.Description =  row["Description"].ToString();
				Obj.AddTime = (( row["AddTime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( row["AddTime"]);
				Obj.UpdateTime = (( row["UpdateTime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( row["UpdateTime"]);
				Obj.ConfirmTime = (( row["ConfirmTime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( row["ConfirmTime"]);
				Obj.SendTime = (( row["SendTime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( row["SendTime"]);
				Obj.expresstype = (( row["expresstype"])==DBNull.Value)?0:Convert.ToInt32( row["expresstype"]);
				Obj.expresscode =  row["expresscode"].ToString();
				Obj.ordertype = (( row["ordertype"])==DBNull.Value)?0:Convert.ToInt32( row["ordertype"]);
				Obj.RefundTime = (( row["RefundTime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( row["RefundTime"]);
				Obj.ReturnTime = (( row["ReturnTime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( row["ReturnTime"]);
                Obj.DaiLi = row["Daili"].ToString();
            }
			else
			{
				return null;
			}
			return Obj;
		}
		
        /// <summary>
		/// 得到  orders 数据实体
		/// </summary>
		/// <param name="dr">dr</param>
		/// <returns>orders 数据实体</returns>
		public OrdersEntity Populate_OrdersEntity_FromDr(IDataReader dr)
		{
			OrdersEntity Obj = new OrdersEntity();
			
				Obj.OrderId = (( dr["OrderId"])==DBNull.Value)?0:Convert.ToInt32( dr["OrderId"]);
				Obj.OrderCode =  dr["OrderCode"].ToString();
				Obj.UserId = (( dr["UserId"])==DBNull.Value)?0:Convert.ToInt32( dr["UserId"]);
				Obj.PaymentId = (( dr["PaymentId"])==DBNull.Value)?0:Convert.ToInt32( dr["PaymentId"]);
				Obj.TotalPrice = (( dr["TotalPrice"])==DBNull.Value)?0:Convert.ToDecimal( dr["TotalPrice"]);
				Obj.Postage = (( dr["Postage"])==DBNull.Value)?0:Convert.ToDecimal( dr["Postage"]);
				Obj.Status = (( dr["Status"])==DBNull.Value)?0:Convert.ToInt32( dr["Status"]);
				Obj.Consignee =  dr["Consignee"].ToString();
				Obj.LocationId = (( dr["LocationId"])==DBNull.Value)?0:Convert.ToInt32( dr["LocationId"]);
				Obj.Buyer =  dr["Buyer"].ToString();
				Obj.Phone =  dr["Phone"].ToString();
				Obj.Address =  dr["Address"].ToString();
				Obj.Description =  dr["Description"].ToString();
				Obj.AddTime = (( dr["AddTime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( dr["AddTime"]);
				Obj.UpdateTime = (( dr["UpdateTime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( dr["UpdateTime"]);
				Obj.ConfirmTime = (( dr["ConfirmTime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( dr["ConfirmTime"]);
				Obj.SendTime = (( dr["SendTime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( dr["SendTime"]);
				Obj.expresstype = (( dr["expresstype"])==DBNull.Value)?0:Convert.ToInt32( dr["expresstype"]);
				Obj.expresscode =  dr["expresscode"].ToString();
				Obj.ordertype = (( dr["ordertype"])==DBNull.Value)?0:Convert.ToInt32( dr["ordertype"]);
				Obj.RefundTime = (( dr["RefundTime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( dr["RefundTime"]);
				Obj.ReturnTime = (( dr["ReturnTime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( dr["ReturnTime"]);
                Obj.DaiLi = dr["Daili"].ToString();

			return Obj;
		}
		#endregion
		
		/// <summary>
		/// 根据ID,返回一个Orders对象
		/// </summary>
		/// <param name="orderId">orderId</param>
		/// <returns>Orders对象</returns>
		public OrdersEntity Get_OrdersEntity (int orderId)
		{
			OrdersEntity _obj=null;
			SqlParameter[] _param={
			new SqlParameter("@OrderId",SqlDbType.Int)
			};
			_param[0].Value=orderId;
			string sqlStr="select * from Orders with(nolock) where OrderId=@OrderId";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.WfxRW,CommandType.Text,sqlStr,_param))
			{
				while(dr.Read())
				{
            		_obj=Populate_OrdersEntity_FromDr(dr);
				}
			}
			return _obj;
		}
		/// <summary>
		/// 得到数据表Orders所有记录
		/// </summary>
		/// <returns>数据集</returns>
		public IList< OrdersEntity> Get_OrdersAll()
		{
			IList< OrdersEntity> Obj=new List< OrdersEntity>();
			string sqlStr="select * from Orders";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.WfxRW,CommandType.Text,sqlStr))
			{
				while(dr.Read())
				{
					Obj.Add(Populate_OrdersEntity_FromDr(dr));
				}
			}
			return Obj;
		}
		/// <summary>
        /// 检测是否存在根据主键
        /// </summary>
        /// <param name="orderId">orderId</param>
        /// <returns>是/否</returns>
		public bool IsExistOrders(int orderId)
		{
			SqlParameter[] _param={
                                      new SqlParameter("@orderId",SqlDbType.Int)
                                  };
            _param[0].Value=orderId;
            string sqlStr="select Count(*) from Orders where OrderId=@orderId";
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
