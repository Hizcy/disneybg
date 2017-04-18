// =================================================================== 
// 项目说明
//====================================================================
// yangxg。@Copy Right 2014
// 文件： ProductSKU.cs
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
    public partial class ProductSKUBLL : BaseBLL< ProductSKUBLL>

    {
        ProductSKUDataAccessLayer productSKUdal;
        public ProductSKUBLL()
        {
            productSKUdal = new ProductSKUDataAccessLayer();
        }

        public int Insert(ProductSKUEntity productSKUEntity)
        {
            return productSKUdal.Insert(productSKUEntity);            
        }
        public int Insert(List<ProductSKUEntity> list)
        {

            foreach (ProductSKUEntity model in list)
            {
                productSKUdal.Insert(model);
            }
            return 1;

        }

        public int Update(List<ProductSKUEntity> list)
        {

            foreach (ProductSKUEntity model in list)
            {
                productSKUdal.Update(model);
            }
            return 1;
        }
        public void Update(ProductSKUEntity productSKUEntity)
        {
            productSKUdal.Update(productSKUEntity);
        }

        public ProductSKUEntity GetAdminSingle(int id)
        {
           return productSKUdal.Get_ProductSKUEntity(id);
        }

        public IList<ProductSKUEntity> GetProductSKUList(int ProductId)
        {
            IList<ProductSKUEntity> productSKUList = new List<ProductSKUEntity>();
            productSKUList = productSKUdal.Get_ProductSKUAllByProductId(ProductId);
            return productSKUList;
        }
    }
}
