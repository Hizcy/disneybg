// =================================================================== 
// 项目说明
//====================================================================
// yangxg。@Copy Right 2014
// 文件： ProductSKU.cs
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
    public partial class T_ProductSKUBLL : BaseBLL<T_ProductSKUBLL>
    {
        T_ProductSKUDataAccessLayer t_productSKUdal;
        public T_ProductSKUBLL()
        {
            t_productSKUdal = new T_ProductSKUDataAccessLayer();
        }

        public int Insert(T_ProductSKUEntity t_productSKUEntity)
        {
            return t_productSKUdal.Insert(t_productSKUEntity);            
        }
        public int Insert(List<T_ProductSKUEntity> list)
        {

            foreach (T_ProductSKUEntity model in list)
            {
                t_productSKUdal.Insert(model);
            }
            return 1;

        }

        public int Update(List<T_ProductSKUEntity> list)
        {

            foreach (T_ProductSKUEntity model in list)
            {
                t_productSKUdal.Update(model);
            }
            return 1;
        }
        public void Update(T_ProductSKUEntity t_productSKUEntity)
        {
            t_productSKUdal.Update(t_productSKUEntity);
        }

        public T_ProductSKUEntity GetAdminSingle(int id)
        {
            return t_productSKUdal.Get_T_ProductSKUEntity(id);
        }

        public IList<T_ProductSKUEntity> GetProductSKUList(int ProductId)
        {
            IList<T_ProductSKUEntity> t_productSKUList = new List<T_ProductSKUEntity>();
            t_productSKUList = t_productSKUdal.Get_T_ProductSKUAllByProductId(ProductId);
            return t_productSKUList;
        }
    }
}
