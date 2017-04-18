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
using System.Collections.Generic;
using System.Text;
using Weifenxiao.DAL;
using Weifenxiao.Entity;

namespace Weifenxiao.BLL
{
    public partial class T_OrdersItemBLL : BaseBLL< T_OrdersItemBLL>

    {
        T_OrdersItemDataAccessLayer t_OrdersItemdal;
        public T_OrdersItemBLL()
        {
            t_OrdersItemdal = new T_OrdersItemDataAccessLayer();
        }

        public int Insert(T_OrdersItemEntity t_OrdersItemEntity)
        {
            return t_OrdersItemdal.Insert(t_OrdersItemEntity);            
        }

        public void Update(T_OrdersItemEntity t_OrdersItemEntity)
        {
            t_OrdersItemdal.Update(t_OrdersItemEntity);
        }

        public T_OrdersItemEntity GetAdminSingle(int orderItemId)
        {
           return t_OrdersItemdal.Get_T_OrdersItemEntity(orderItemId);
        }

        public IList<T_OrdersItemEntity> GetT_OrdersItemList()
        {
            IList<T_OrdersItemEntity> t_OrdersItemList = new List<T_OrdersItemEntity>();
            t_OrdersItemList=t_OrdersItemdal.Get_T_OrdersItemAll();
            return t_OrdersItemList;
        }
    }
}
