// =================================================================== 
// 项目说明
//====================================================================
// yangxg。@Copy Right 2014
// 文件： wx_Fenxiao.cs
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
    public partial class wx_FenxiaoBLL : BaseBLL< wx_FenxiaoBLL>

    {
        wx_FenxiaoDataAccessLayer wx_Fenxiaodal;
        public wx_FenxiaoBLL()
        {
            wx_Fenxiaodal = new wx_FenxiaoDataAccessLayer();
        }

        public int Insert(wx_FenxiaoEntity wx_FenxiaoEntity)
        {
            return wx_Fenxiaodal.Insert(wx_FenxiaoEntity);            
        }

        public void Update(wx_FenxiaoEntity wx_FenxiaoEntity)
        {
            wx_Fenxiaodal.Update(wx_FenxiaoEntity);
        }

        public wx_FenxiaoEntity GetAdminSingle(int id)
        {
           return wx_Fenxiaodal.Get_wx_FenxiaoEntity(id);
        }

        public IList<wx_FenxiaoEntity> Getwx_FenxiaoList()
        {
            IList<wx_FenxiaoEntity> wx_FenxiaoList = new List<wx_FenxiaoEntity>();
            wx_FenxiaoList=wx_Fenxiaodal.Get_wx_FenxiaoAll();
            return wx_FenxiaoList;
        }
        /// <summary>
        /// 获取分销配置列表通过店铺id
        /// </summary>
        /// <param name="shopid"></param>
        /// <returns></returns>
        public IList<wx_FenxiaoEntity> GetListByShopId(int shopid)
        {
            IList<wx_FenxiaoEntity> rolesList = new List<wx_FenxiaoEntity>();
            rolesList = wx_Fenxiaodal.GetListByShopId(shopid);
            return rolesList;
        }
    }
}
