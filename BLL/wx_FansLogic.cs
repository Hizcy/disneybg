// =================================================================== 
// 项目说明
//====================================================================
// yangxg。@Copy Right 2014
// 文件： wx_Fans.cs
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
    public partial class wx_FansBLL : BaseBLL< wx_FansBLL>

    {
        wx_FansDataAccessLayer wx_Fansdal;
        public wx_FansBLL()
        {
            wx_Fansdal = new wx_FansDataAccessLayer();
        }

        public int Insert(wx_FansEntity wx_FansEntity)
        {
            return wx_Fansdal.Insert(wx_FansEntity);            
        }

        public void Update(wx_FansEntity wx_FansEntity)
        {
            wx_Fansdal.Update(wx_FansEntity);
        }

        public wx_FansEntity GetAdminSingle(int id)
        {
           return wx_Fansdal.Get_wx_FansEntity(id);
        }

        public IList<wx_FansEntity> Getwx_FansList()
        {
            IList<wx_FansEntity> wx_FansList = new List<wx_FansEntity>();
            wx_FansList=wx_Fansdal.Get_wx_FansAll();
            return wx_FansList;
        }
    }
}
