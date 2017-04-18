// =================================================================== 
// 项目说明
//====================================================================
// yangxg。@Copy Right 2014
// 文件： wx_OpenInfo.cs
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
    public partial class wx_OpenInfoBLL : BaseBLL< wx_OpenInfoBLL>

    {
        wx_OpenInfoDataAccessLayer wx_OpenInfodal;
        public wx_OpenInfoBLL()
        {
            wx_OpenInfodal = new wx_OpenInfoDataAccessLayer();
        }

        public int Insert(wx_OpenInfoEntity wx_OpenInfoEntity)
        {
            return wx_OpenInfodal.Insert(wx_OpenInfoEntity);            
        }

        public void Update(wx_OpenInfoEntity wx_OpenInfoEntity)
        {
            wx_OpenInfodal.Update(wx_OpenInfoEntity);
        }

        public wx_OpenInfoEntity GetAdminSingle(int id)
        {
           return wx_OpenInfodal.Get_wx_OpenInfoEntity(id);
        }

        public IList<wx_OpenInfoEntity> Getwx_OpenInfoList()
        {
            IList<wx_OpenInfoEntity> wx_OpenInfoList = new List<wx_OpenInfoEntity>();
            wx_OpenInfoList=wx_OpenInfodal.Get_wx_OpenInfoAll();
            return wx_OpenInfoList;
        }
    }
}
