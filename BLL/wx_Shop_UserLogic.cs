// =================================================================== 
// 项目说明
//====================================================================
// yangxg。@Copy Right 2014
// 文件： wx_Shop_User.cs
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
    public partial class wx_Shop_UserBLL : BaseBLL< wx_Shop_UserBLL>

    {
        wx_Shop_UserDataAccessLayer wx_Shop_Userdal;
        public wx_Shop_UserBLL()
        {
            wx_Shop_Userdal = new wx_Shop_UserDataAccessLayer();
        }

        public int Insert(wx_Shop_UserEntity wx_Shop_UserEntity)
        {
            return wx_Shop_Userdal.Insert(wx_Shop_UserEntity);            
        }

        public void Update(wx_Shop_UserEntity wx_Shop_UserEntity)
        {
            wx_Shop_Userdal.Update(wx_Shop_UserEntity);
        }

        public wx_Shop_UserEntity GetAdminSingle(int id)
        {
           return wx_Shop_Userdal.Get_wx_Shop_UserEntity(id);
        }

        public IList<wx_Shop_UserEntity> Getwx_Shop_UserList()
        {
            IList<wx_Shop_UserEntity> wx_Shop_UserList = new List<wx_Shop_UserEntity>();
            wx_Shop_UserList=wx_Shop_Userdal.Get_wx_Shop_UserAll();
            return wx_Shop_UserList;
        }
        /// <summary>
        /// 通过userid获取店铺用户关系表实体
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        public wx_Shop_UserEntity GetModelByUserId(int userid)
        {
            return wx_Shop_Userdal.GetModelByUserId(userid);
        }
    }
}
