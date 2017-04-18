// =================================================================== 
// 项目说明
//====================================================================
// yangxg。@Copy Right 2014
// 文件： wx_Users.cs
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
    public partial class wx_UsersBLL : BaseBLL< wx_UsersBLL>

    {
        wx_UsersDataAccessLayer wx_Usersdal;
        public wx_UsersBLL()
        {
            wx_Usersdal = new wx_UsersDataAccessLayer();
        }

        public int Insert(wx_UsersEntity wx_UsersEntity)
        {
            return wx_Usersdal.Insert(wx_UsersEntity);            
        }

        public void Update(wx_UsersEntity wx_UsersEntity)
        {
            wx_Usersdal.Update(wx_UsersEntity);
        }

        public wx_UsersEntity GetAdminSingle(int userId)
        {
           return wx_Usersdal.Get_wx_UsersEntity(userId);
        }
        public wx_UsersEntity GetAdminSingle(string openId)
        {
            return wx_Usersdal.Get_wx_UsersEntity(openId);
        }
        public IList<wx_UsersEntity> Getwx_UsersList()
        {
            IList<wx_UsersEntity> wx_UsersList = new List<wx_UsersEntity>();
            wx_UsersList=wx_Usersdal.Get_wx_UsersAll();
            return wx_UsersList;
        }
        /// <summary>
        /// 添加代理信息
        /// </summary>
        /// <param name="realname">姓名</param>
        /// <param name="phone">手机</param>
        /// <param name="weixin">微信</param>
        /// <param name="advantages">优势</param>
        /// <param name="openid">唯一标识</param>
        /// <param name="shopid">店铺</param>
        /// <param name="locationid">地区id</param>
        /// <param name="address">地址</param>
        /// <param name="parentid">推荐人</param>
        /// <returns></returns>
        public int Pro_Register(string realname, string phone, string weixin, string advantages, string openid, int shopid, int locationid, string address, int parentid)
        {
            return wx_Usersdal.Pro_Register(realname, phone, weixin, advantages, openid, shopid, locationid, address, parentid);
        }
        /// <summary>
        /// 获取分页数据
        /// </summary>
        /// <param name="pagesize">页数</param>
        /// <param name="currentindex">当前页</param>
        /// <param name="condition">条件</param>
        /// <param name="allcount">返回总条数</param>
        /// <returns></returns>
        public DataSet GetListByPage(int pagesize, int currentindex, string condition, out int allcount)
        {
            return PageData.GetDataByPage("v_Users_Open", "UserId", "UserId desc", currentindex, pagesize, "*", condition, out allcount);
        }
        /// <summary>
        /// 代理申请后，未付款，可以通过手动点击通过完成代理审核（代理审核通过但未付款）
        /// </summary>
        /// <param name="openid"></param>
        /// <returns></returns>
        public int AuditPass(int userid)
        {
            try
            {
                wx_UsersEntity model = GetAdminSingle(userid);
                model.Status = 1;
                model.UpdateTime = DateTime.Now;
                Update(model);
                return userid;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
        /// <summary>
        /// 冻结用户
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        public int Freeze(int userid)
        {
            try
            {
                wx_UsersEntity model = GetAdminSingle(userid);
                model.Status = -1;
                model.UpdateTime = DateTime.Now;
                Update(model);
                return userid;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
        /// <summary>
        /// 获取用户扩展信息通过userid
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        public wx_UserExtEntity GetExtModelByUserId(int userid)
        {
            return wx_Usersdal.GetExtModelByUserId(userid);
        }
        public DataSet Get_v_UserExt(int userid)
        {
            return wx_Usersdal.Get_v_UserExt(userid);
        }
    }
}
