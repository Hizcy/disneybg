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
using System.Collections.Generic;
using System.Text;
using Weifenxiao.DAL;
using Weifenxiao.Entity;

namespace Weifenxiao.BLL
{
    public partial class OrdersItemBLL : BaseBLL< OrdersItemBLL>

    {
        OrdersItemDataAccessLayer ordersItemdal;
        public OrdersItemBLL()
        {
            ordersItemdal = new OrdersItemDataAccessLayer();
        }

        public int Insert(OrdersItemEntity ordersItemEntity)
        {
            return ordersItemdal.Insert(ordersItemEntity);            
        }

        public void Update(OrdersItemEntity ordersItemEntity)
        {
            ordersItemdal.Update(ordersItemEntity);
        }

        public OrdersItemEntity GetAdminSingle(int orderItemId)
        {
           return ordersItemdal.Get_OrdersItemEntity(orderItemId);
        }

        public IList<OrdersItemEntity> GetOrdersItemList()
        {
            IList<OrdersItemEntity> ordersItemList = new List<OrdersItemEntity>();
            ordersItemList=ordersItemdal.Get_OrdersItemAll();
            return ordersItemList;
        }
    }
}
