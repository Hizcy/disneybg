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
using Weifenxiao.Entity;
using Jnwf.Utils.Data;
using System.Linq;

namespace Weifenxiao.DAL
{
    /// <summary>
    /// 数据层实例化接口类 dbo.Orders.
    /// </summary>
    public partial class OrdersDataAccessLayer 
    {
        public IList<OrderExtEntity> DataSet2List(DataSet ds)
        {
            IList<OrderExtEntity> Obj = new List<OrderExtEntity>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                OrderExtEntity model = new OrderExtEntity();
                model = Populate_OrdersExtEntity_FromDr(dr);
                OrderExtEntity temp = Obj.FirstOrDefault(c => c.OrderCode == model.OrderCode);
                if (temp != null)
                {
                    temp.List.Add(Populate_OrdersItemEntity_FromDr(dr));
                }
                else
                {
                    model.List.Add(Populate_OrdersItemEntity_FromDr(dr));
                    Obj.Add(model);
                }
            }
            
            return Obj;
        }
        public OrderExtEntity Populate_OrdersExtEntity_FromDr(DataRow dr)
        {
            OrderExtEntity Obj = new OrderExtEntity();

            Obj.OrderId = ((dr["OrderId"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["OrderId"]);
            Obj.OrderCode = dr["OrderCode"].ToString();
            Obj.UserId = ((dr["UserId"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["UserId"]);
            Obj.PaymentId = ((dr["PaymentId"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["PaymentId"]);
            Obj.TotalPrice = ((dr["TotalPrice"]) == DBNull.Value) ? 0 : Convert.ToDecimal(dr["TotalPrice"]);
            Obj.Postage = ((dr["Postage"]) == DBNull.Value) ? 0 : Convert.ToDecimal(dr["Postage"]);
            Obj.Status = ((dr["Status"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["Status"]);
            Obj.Consignee = dr["Consignee"].ToString();
            Obj.LocationId = ((dr["LocationId"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["LocationId"]);
            Obj.Address = dr["Address"].ToString();
            Obj.Phone = dr["Phone"].ToString();
            Obj.Buyer = dr["Buyer"].ToString();
            Obj.Description = dr["Description"].ToString();
            Obj.AddTime = ((dr["AddTime"]) == DBNull.Value) ? Convert.ToDateTime("1900-1-1") : Convert.ToDateTime(dr["AddTime"]);
            Obj.UpdateTime = ((dr["UpdateTime"]) == DBNull.Value) ? Convert.ToDateTime("1900-1-1") : Convert.ToDateTime(dr["UpdateTime"]);
            Obj.ConfirmTime = ((dr["ConfirmTime"]) == DBNull.Value) ? Convert.ToDateTime("1900-1-1") : Convert.ToDateTime(dr["ConfirmTime"]);
            Obj.SendTime = ((dr["SendTime"]) == DBNull.Value) ? Convert.ToDateTime("1900-1-1") : Convert.ToDateTime(dr["SendTime"]);
            Obj.expresstype = ((dr["expresstype"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["expresstype"]);
            Obj.expresscode = dr["expresscode"].ToString();
            Obj.RefundTime = ((dr["RefundTime"]) == DBNull.Value) ? Convert.ToDateTime("1900-1-1") : Convert.ToDateTime(dr["RefundTime"]);
            Obj.ReturnTime = ((dr["ReturnTime"]) == DBNull.Value) ? Convert.ToDateTime("1900-1-1") : Convert.ToDateTime(dr["ReturnTime"]);
            return Obj;
        }
        public OrdersItemExtEntity Populate_OrdersItemEntity_FromDr(DataRow dr)
        {
            OrdersItemExtEntity Obj = new OrdersItemExtEntity();

            Obj.OrderItemId = ((dr["OrderItemId"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["OrderItemId"]);
            Obj.OrderId = ((dr["OrderId"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["OrderId"]);
            Obj.ProductId = ((dr["ProductId"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["ProductId"]);
            Obj.Number = ((dr["Number"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["Number"]);
            Obj.Price = ((dr["Price"]) == DBNull.Value) ? 0 : Convert.ToDecimal(dr["Price"]);
            Obj.CostPrice = ((dr["CostPrice"]) == DBNull.Value) ? 0 : Convert.ToDecimal(dr["CostPrice"]);

            Obj.ProductName = dr["ProductName"].ToString();
            Obj.ProductImage = dr["ProductImage"].ToString();

            Obj.dailiId = ((dr["dailiId"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["dailiId"]); ;
            Obj.dailiName = dr["dailiName"].ToString();
            Obj.attr = dr["attr"].ToString().TrimEnd(',') ;
            return Obj;
        }
        /// <summary>
        /// 订单退款
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public int OrderTuiKuan(int orderId)
        {
            SqlParameter[] _param = {
                new SqlParameter("@orderid",SqlDbType.Int)
            };
            _param[0].Value = orderId;
            object obj = SqlHelper.ExecuteScalar(WebConfig.WfxRW, CommandType.StoredProcedure, "pro_Tuikuan", _param);
            return Convert.ToInt32(obj);
        }
	}
}
