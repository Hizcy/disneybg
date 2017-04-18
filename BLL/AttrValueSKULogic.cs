// =================================================================== 
// 项目说明
//====================================================================
// yangxg。@Copy Right 2014
// 文件： AttrValueSKU.cs
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
    public partial class AttrValueSKUBLL : BaseBLL< AttrValueSKUBLL>

    {
        AttrValueSKUDataAccessLayer attrValueSKUdal;
        public AttrValueSKUBLL()
        {
            attrValueSKUdal = new AttrValueSKUDataAccessLayer();
        }

        public int Insert(AttrValueSKUEntity attrValueSKUEntity)
        {
            return attrValueSKUdal.Insert(attrValueSKUEntity);            
        }
        public int Insert (List<AttrValueSKUEntity> list)
        {
            foreach (AttrValueSKUEntity model in list)
            {
                attrValueSKUdal.Insert(model);
            }
            return 1;
        }
        public void Update(AttrValueSKUEntity attrValueSKUEntity)
        {
            attrValueSKUdal.Update(attrValueSKUEntity);
        }

        public AttrValueSKUEntity GetAdminSingle(int id)
        {
           return attrValueSKUdal.Get_AttrValueSKUEntity(id);
        }

        public IList<AttrValueSKUEntity> GetAttrValueSKUList()
        {
            IList<AttrValueSKUEntity> attrValueSKUList = new List<AttrValueSKUEntity>();
            attrValueSKUList=attrValueSKUdal.Get_AttrValueSKUAll();
            return attrValueSKUList;
        }

        public IList<AttrValueSKUEntity> GetAttrValueSKUListByProcuctId(int productid)
        {
            IList<AttrValueSKUEntity> attrValueSKUList = new List<AttrValueSKUEntity>();
            attrValueSKUList = attrValueSKUdal.Get_AttrValueSKUByProductId(productid);
            return attrValueSKUList;
        }
    }
}
