// =================================================================== 
// 项目说明
//====================================================================
// yangxg。@Copy Right 2014
// 文件： AttrValueSKU.cs
// 项目名称：买车网
// 创建时间：2016/8/22
// 负责人：yangxg
// ===================================================================
using System;
using System.Collections.Generic;
using System.Text;
using Weifenxiao.DAL;
using Weifenxiao.Entity;

namespace Weifenxiao.BLL
{
    public partial class T_AttrValueSKUBLL : BaseBLL<T_AttrValueSKUBLL>
    {
    T_AttrValueSKUDataAccessLayer t_attrValueSKUdal;
        public T_AttrValueSKUBLL()
        {
            t_attrValueSKUdal = new T_AttrValueSKUDataAccessLayer();
        }

        public int Insert(T_AttrValueSKUEntity t_attrValueSKUEntity)
        {
            return t_attrValueSKUdal.Insert(t_attrValueSKUEntity);            
        }
        public int Insert(List<T_AttrValueSKUEntity> list)
        {
            foreach (T_AttrValueSKUEntity model in list)
            {
                t_attrValueSKUdal.Insert(model);
            }
            return 1;
        }
        public void Update(T_AttrValueSKUEntity attrValueSKUEntity)
        {
            t_attrValueSKUdal.Update(attrValueSKUEntity);
        }

        public T_AttrValueSKUEntity GetAdminSingle(int id)
        {
            return t_attrValueSKUdal.Get_T_AttrValueSKUEntity(id);
        }

        public IList<T_AttrValueSKUEntity> GetTAttrValueSKUList()
        {
            IList<T_AttrValueSKUEntity> attrValueSKUList = new List<T_AttrValueSKUEntity>();
            attrValueSKUList = t_attrValueSKUdal.Get_T_AttrValueSKUAll();
            return attrValueSKUList;
        }

        public IList<T_AttrValueSKUEntity> GetTAttrValueSKUListByProcuctId(int productid)
        {
            IList<T_AttrValueSKUEntity> t_attrValueSKUList = new List<T_AttrValueSKUEntity>();
            t_attrValueSKUList = t_attrValueSKUdal.Get_T_AttrValueSKUByProductId(productid);
            return t_attrValueSKUList;
        }
    }
}