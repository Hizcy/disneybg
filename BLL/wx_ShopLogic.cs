// =================================================================== 
// 项目说明
//====================================================================
// yangxg。@Copy Right 2014
// 文件： wx_Shop.cs
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
    public partial class wx_ShopBLL : BaseBLL< wx_ShopBLL>

    {
        wx_ShopDataAccessLayer wx_Shopdal;
        public wx_ShopBLL()
        {
            wx_Shopdal = new wx_ShopDataAccessLayer();
        }

        public int Insert(wx_ShopEntity wx_ShopEntity)
        {
            return wx_Shopdal.Insert(wx_ShopEntity);            
        }

        public void Update(wx_ShopEntity wx_ShopEntity)
        {
            wx_Shopdal.Update(wx_ShopEntity);
        }

        public wx_ShopEntity GetAdminSingle(int shopId)
        {
           return wx_Shopdal.Get_wx_ShopEntity(shopId);
        }

        public IList<wx_ShopEntity> Getwx_ShopList()
        {
            IList<wx_ShopEntity> wx_ShopList = new List<wx_ShopEntity>();
            wx_ShopList=wx_Shopdal.Get_wx_ShopAll();
            return wx_ShopList;
        }
    }
}
