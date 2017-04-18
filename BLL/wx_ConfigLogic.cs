// =================================================================== 
// 项目说明
//====================================================================
// yangxg。@Copy Right 2014
// 文件： wx_Config.cs
// 项目名称：买车网
// 创建时间：2016/6/23
// 负责人：yangxg
// ===================================================================
using System;
using System.Collections.Generic;
using System.Text;
using Weifenxiao.DAL;
using Weifenxiao.Entity;

namespace Weifenxiao.BLL
{
    public partial class wx_ConfigBLL : BaseBLL< wx_ConfigBLL>

    {
        wx_ConfigDataAccessLayer wx_Configdal;
        public wx_ConfigBLL()
        {
            wx_Configdal = new wx_ConfigDataAccessLayer();
        }

        public int Insert(wx_ConfigEntity wx_ConfigEntity)
        {
            return wx_Configdal.Insert(wx_ConfigEntity);            
        }

        public void Update(wx_ConfigEntity wx_ConfigEntity)
        {
            wx_Configdal.Update(wx_ConfigEntity);
        }

        public wx_ConfigEntity GetAdminSingle(int id)
        {
           return wx_Configdal.Get_wx_ConfigEntity(id);
        }

        public IList<wx_ConfigEntity> Getwx_ConfigList()
        {
            IList<wx_ConfigEntity> wx_ConfigList = new List<wx_ConfigEntity>();
            wx_ConfigList=wx_Configdal.Get_wx_ConfigAll();
            return wx_ConfigList;
        }
        public IList<wx_ConfigEntity> Gettb_PropertyIdList(int PropertyId)
        {
            IList<wx_ConfigEntity> tb_ConfigList = new List<wx_ConfigEntity>();
            tb_ConfigList = wx_Configdal.Get_tb_PropertyIdAll(PropertyId);
            return tb_ConfigList;
        }
    }
}
