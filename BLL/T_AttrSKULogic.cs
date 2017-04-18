// =================================================================== 
// 项目说明
//====================================================================
// yangxg。@Copy Right 2014
// 文件： AttrSKU.cs
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
     public partial class T_AttrSKUBLL : BaseBLL< T_AttrSKUBLL>
    {
         T_AttrSKUDataAccessLayer t_attrSKUdal;
        public T_AttrSKUBLL()
        {
            t_attrSKUdal = new T_AttrSKUDataAccessLayer();
        }

        public int Insert(T_AttrSKUEntity t_attrSKUEntity)
        {
            return t_attrSKUdal.Insert(t_attrSKUEntity);            
        }

        public void Update(T_AttrSKUEntity t_attrSKUEntity)
        {
            t_attrSKUdal.Update(t_attrSKUEntity);
        }

        public T_AttrSKUEntity GetAdminSingle(int id)
        {
            return t_attrSKUdal.Get_T_AttrSKUEntity(id);
        }

        public IList<T_AttrSKUEntity> GetAttrSKUList()
        {
            IList<T_AttrSKUEntity> t_attrSKUList = new List<T_AttrSKUEntity>();
            t_attrSKUList = t_attrSKUdal.Get_T_AttrSKUAll();
            return t_attrSKUList;
        }
    }
}
