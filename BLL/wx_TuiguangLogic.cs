// =================================================================== 
// 项目说明
//====================================================================
// yangxg。@Copy Right 2014
// 文件： wx_Tuiguang.cs
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
    public partial class wx_TuiguangBLL : BaseBLL< wx_TuiguangBLL>

    {
        wx_TuiguangDataAccessLayer wx_Tuiguangdal;
        public wx_TuiguangBLL()
        {
            wx_Tuiguangdal = new wx_TuiguangDataAccessLayer();
        }

        public int Insert(wx_TuiguangEntity wx_TuiguangEntity)
        {
            return wx_Tuiguangdal.Insert(wx_TuiguangEntity);            
        }

        public void Update(wx_TuiguangEntity wx_TuiguangEntity)
        {
            wx_Tuiguangdal.Update(wx_TuiguangEntity);
        }

        public wx_TuiguangEntity GetAdminSingle(int id)
        {
           return wx_Tuiguangdal.Get_wx_TuiguangEntity(id);
        }

        public IList<wx_TuiguangEntity> Getwx_TuiguangList()
        {
            IList<wx_TuiguangEntity> wx_TuiguangList = new List<wx_TuiguangEntity>();
            wx_TuiguangList=wx_Tuiguangdal.Get_wx_TuiguangAll();
            return wx_TuiguangList;
        }
    }
}
