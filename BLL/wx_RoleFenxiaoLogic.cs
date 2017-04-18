// =================================================================== 
// 项目说明
//====================================================================
// yangxg。@Copy Right 2014
// 文件： wx_RoleFenxiao.cs
// 项目名称：买车网
// 创建时间：2016/5/22
// 负责人：yangxg
// ===================================================================
using System;
using System.Collections.Generic;
using System.Text;
using Weifenxiao.DAL;
using Weifenxiao.Entity;

namespace Weifenxiao.BLL
{
    public partial class wx_RoleFenxiaoBLL : BaseBLL< wx_RoleFenxiaoBLL>

    {
        wx_RoleFenxiaoDataAccessLayer wx_RoleFenxiaodal;
        public wx_RoleFenxiaoBLL()
        {
            wx_RoleFenxiaodal = new wx_RoleFenxiaoDataAccessLayer();
        }

        public int Insert(wx_RoleFenxiaoEntity wx_RoleFenxiaoEntity)
        {
            return wx_RoleFenxiaodal.Insert(wx_RoleFenxiaoEntity);            
        }
        public int Insert(List<wx_RoleFenxiaoEntity> list)
        {
            try
            {
                foreach (wx_RoleFenxiaoEntity model in list)
                {
                    wx_RoleFenxiaodal.Insert(model);
                }

                return 1;
            }
            catch (Exception ex)
            {

                return -1;    
            }
            
        }
        public void Update(wx_RoleFenxiaoEntity wx_RoleFenxiaoEntity)
        {
            wx_RoleFenxiaodal.Update(wx_RoleFenxiaoEntity);
        }
        public void Update(List<wx_RoleFenxiaoEntity> list)
        {
            try
            {
                foreach (wx_RoleFenxiaoEntity model in list)
                {
                    wx_RoleFenxiaodal.Update(model);
                }
            }
            catch (Exception ex)
            {

            }
        }
        public int Delete(int shopid,int roleid)
        {
            return wx_RoleFenxiaodal.Delete(shopid, roleid);
        }
        public wx_RoleFenxiaoEntity GetAdminSingle(int id)
        {
           return wx_RoleFenxiaodal.Get_wx_RoleFenxiaoEntity(id);
        }

        public IList<wx_RoleFenxiaoEntity> Getwx_RoleFenxiaoList()
        {
            IList<wx_RoleFenxiaoEntity> wx_RoleFenxiaoList = new List<wx_RoleFenxiaoEntity>();
            wx_RoleFenxiaoList=wx_RoleFenxiaodal.Get_wx_RoleFenxiaoAll();
            return wx_RoleFenxiaoList;
        }      
        /// <summary>
        /// 获取分销配置列表通过店铺id
        /// </summary>
        /// <param name="shopid"></param>
        /// <returns></returns>
        public IList<wx_RoleFenxiaoEntity> GetListByShopId(int shopid)
        {
            IList<wx_RoleFenxiaoEntity> wx_RoleFenxiaoList = new List<wx_RoleFenxiaoEntity>();
            wx_RoleFenxiaoList = wx_RoleFenxiaodal.GetListByShopId(shopid);
            return wx_RoleFenxiaoList;
        }
        public IList<wx_RoleFenxiaoEntity> GetListByShopIdAndRole(int shopid,int roleid)
        {
            IList<wx_RoleFenxiaoEntity> wx_RoleFenxiaoList = new List<wx_RoleFenxiaoEntity>();
            wx_RoleFenxiaoList = wx_RoleFenxiaodal.GetListByShopIdAndRole(shopid, roleid);
            return wx_RoleFenxiaoList;
        }
    }
}
