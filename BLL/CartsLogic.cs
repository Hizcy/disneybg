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
using System.Collections.Generic;
using System.Text;
using Weifenxiao.DAL;
using Weifenxiao.Entity;

namespace Weifenxiao.BLL
{
    public partial class CartsBLL : BaseBLL< CartsBLL>

    {
        CartsDataAccessLayer cartsdal;
        public CartsBLL()
        {
            cartsdal = new CartsDataAccessLayer();
        }

        public int Insert(CartsEntity cartsEntity)
        {
            return cartsdal.Insert(cartsEntity);            
        }

        public void Update(CartsEntity cartsEntity)
        {
            cartsdal.Update(cartsEntity);
        }

        public CartsEntity GetAdminSingle(int cartId)
        {
           return cartsdal.Get_CartsEntity(cartId);
        }

        public IList<CartsEntity> GetCartsList()
        {
            IList<CartsEntity> cartsList = new List<CartsEntity>();
            cartsList=cartsdal.Get_CartsAll();
            return cartsList;
        }
    }
}
