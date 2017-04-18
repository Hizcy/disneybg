// =================================================================== 
// 项目说明
//====================================================================
// yangxg。@Copy Right 2014
// 文件： T_Orders.cs
// 项目名称：买车网
// 创建时间：2016/8/11
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
    public partial class T_OrdersBLL : BaseBLL< T_OrdersBLL>

    {
        T_OrdersDataAccessLayer t_Ordersdal;
        public T_OrdersBLL()
        {
            t_Ordersdal = new T_OrdersDataAccessLayer();
        }

        public int Insert(T_OrdersEntity t_OrdersEntity)
        {
            return t_Ordersdal.Insert(t_OrdersEntity);            
        }

        public void Update(T_OrdersEntity t_OrdersEntity)
        {
            t_Ordersdal.Update(t_OrdersEntity);
        }

        public T_OrdersEntity GetAdminSingle(int orderId)
        {
           return t_Ordersdal.Get_T_OrdersEntity(orderId);
        }

        public IList<T_OrdersEntity> GetT_OrdersList()
        {
            IList<T_OrdersEntity> t_OrdersList = new List<T_OrdersEntity>();
            t_OrdersList=t_Ordersdal.Get_T_OrdersAll();
            return t_OrdersList;
        }
        /// <summary>
        /// 分页 
        /// </summary>
        /// <param name="pagesize"></param>
        /// <param name="currentindex"></param>
        /// <param name="condition"></param>
        /// <param name="allcount"></param>
        /// <returns></returns>
        public DataSet GetOrderBuyerList(int pagesize, int currentindex, string condition, out int allcount)
        {
            return PageData.GetDataByPage("v_Order", "OrderId", "Addtime desc,groupno desc", currentindex, pagesize, "*", condition, out allcount);
        } 
        /// <summary>
        /// 订单退款
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public int OrdersTuiKuanPro(int orderId)
        {
            return t_Ordersdal.OrdersTuiKuanPro(orderId);
        }
    }
}
