// =================================================================== 
// 项目说明
//====================================================================
// yangxg。@Copy Right 2014
// 文件： AttrSKU.cs
// 项目名称：买车网
// 创建时间：2016/4/17
// 负责人：yangxg
// ===================================================================
using System;
using System.Collections.Generic;
using System.Text;
using Weifenxiao.DAL;
using Weifenxiao.Entity;

namespace Weifenxiao.BLL
{
    public partial class AttrSKUBLL : BaseBLL< AttrSKUBLL>

    {
        AttrSKUDataAccessLayer attrSKUdal;
        public AttrSKUBLL()
        {
            attrSKUdal = new AttrSKUDataAccessLayer();
        }

        public int Insert(AttrSKUEntity attrSKUEntity)
        {
            return attrSKUdal.Insert(attrSKUEntity);            
        }

        public void Update(AttrSKUEntity attrSKUEntity)
        {
            attrSKUdal.Update(attrSKUEntity);
        }

        public AttrSKUEntity GetAdminSingle(int id)
        {
           return attrSKUdal.Get_AttrSKUEntity(id);
        }

        public IList<AttrSKUEntity> GetAttrSKUList()
        {
            IList<AttrSKUEntity> attrSKUList = new List<AttrSKUEntity>();
            attrSKUList=attrSKUdal.Get_AttrSKUAll();
            return attrSKUList;
        }
    }
}
