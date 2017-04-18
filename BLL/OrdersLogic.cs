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
using System.Collections.Generic;
using System.Data;
using System.Text;
using Weifenxiao.DAL;
using Weifenxiao.Entity;

namespace Weifenxiao.BLL
{
    public partial class OrdersBLL : BaseBLL< OrdersBLL>

    {
        OrdersDataAccessLayer ordersdal;
        public OrdersBLL()
        {
            ordersdal = new OrdersDataAccessLayer();
        }

        public int Insert(OrdersEntity ordersEntity)
        {
            return ordersdal.Insert(ordersEntity);            
        }

        public void Update(OrdersEntity ordersEntity)
        {
            ordersdal.Update(ordersEntity);
        }

        public OrdersEntity GetAdminSingle(int orderId)
        {
           return ordersdal.Get_OrdersEntity(orderId);
        }

        public IList<OrdersEntity> GetOrdersList()
        {
            IList<OrdersEntity> ordersList = new List<OrdersEntity>();
            ordersList=ordersdal.Get_OrdersAll();
            return ordersList;
        }
        /// <summary>
        /// 获取分页数据
        /// </summary>
        /// <param name="pagesize">页数</param>
        /// <param name="currentindex">当前页</param>
        /// <param name="condition">条件</param>
        /// <param name="allcount">返回总条数</param>
        /// <returns></returns>
        public IList<OrderExtEntity> GetListByPage(int pagesize, int currentindex, string condition, out int allcount)
        {
            DataSet ds = PageData.GetDataByPage("v_Product_Order", "OrderId", "addtime desc", currentindex, pagesize, "*", condition, out allcount);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
                return ordersdal.DataSet2List(ds);
            else
                return null;
        }
         /// <summary>
        /// 订单退款
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public int OrderTuiKuan(int orderId)
        {
            return ordersdal.OrderTuiKuan(orderId);
        }
    }
}
