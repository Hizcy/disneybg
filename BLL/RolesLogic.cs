// =================================================================== 
// 项目说明
//====================================================================
// yangxg。@Copy Right 2014
// 文件： Roles.cs
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
    public partial class RolesBLL : BaseBLL< RolesBLL>

    {
        RolesDataAccessLayer rolesdal;
        public RolesBLL()
        {
            rolesdal = new RolesDataAccessLayer();
        }

        public int Insert(RolesEntity rolesEntity)
        {
            return rolesdal.Insert(rolesEntity);            
        }

        public void Update(RolesEntity rolesEntity)
        {
            rolesdal.Update(rolesEntity);
        }

        public RolesEntity GetAdminSingle(int roleId)
        {
           return rolesdal.Get_RolesEntity(roleId);
        }

        public IList<RolesEntity> GetRolesList()
        {
            IList<RolesEntity> rolesList = new List<RolesEntity>();
            rolesList=rolesdal.Get_RolesAll();
            return rolesList;
        }
        /// <summary>
        /// 获取角色列表通过店铺id
        /// </summary>
        /// <param name="shopid"></param>
        /// <returns></returns>
        public IList<RolesEntity> GetListByShopId(int shopid)
        {
            IList<RolesEntity> rolesList = new List<RolesEntity>();
            rolesList = rolesdal.GetListByShopId(shopid);
            return rolesList;
        }
    }
}
