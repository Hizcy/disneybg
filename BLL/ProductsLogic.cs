// =================================================================== 
// 项目说明
//====================================================================
// yangxg。@Copy Right 2014
// 文件： Products.cs
// 项目名称：买车网
// 创建时间：2016/4/2
// 负责人：yangxg
// ===================================================================
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Weifenxiao.DAL;
using Weifenxiao.Entity;

namespace Weifenxiao.BLL
{
    public partial class ProductsBLL : BaseBLL< ProductsBLL>

    {
        ProductsDataAccessLayer productsdal;
        public ProductsBLL()
        {
            productsdal = new ProductsDataAccessLayer();
        }

        public int Insert(ProductsEntity productsEntity)
        {
            return productsdal.Insert(productsEntity);            
        }

        public void Update(ProductsEntity productsEntity)
        {
            productsdal.Update(productsEntity);
        }

        public ProductsEntity GetAdminSingle(int productId)
        {
           return productsdal.Get_ProductsEntity(productId);
        }

        public IList<ProductsEntity> GetProductsList()
        {
            IList<ProductsEntity> productsList = new List<ProductsEntity>();
            productsList=productsdal.Get_ProductsAll();
            return productsList;
        }
        /// <summary>
        /// 获取商品列表（本店铺）
        /// </summary>
        /// <param name="shopid"></param>
        /// <returns></returns>
        public IList<ProductsEntity> GetListByShopId(int shopid)
        {
            IList<ProductsEntity> productsList = new List<ProductsEntity>();
            productsList = productsdal.GetListByShopId(shopid);
            return productsList;
        }
        /// <summary>
        /// 获取分页数据
        /// </summary>
        /// <param name="pagesize">页数</param>
        /// <param name="currentindex">当前页</param>
        /// <param name="condition">条件</param>
        /// <param name="allcount">返回总条数</param>
        /// <returns></returns>
        public DataSet GetListByPage(int pagesize, int currentindex, string condition, out int allcount)
        {
            return PageData.GetDataByPage("v_Products", "ProductId", "OrderBy desc", currentindex, pagesize, "*", condition, out allcount);
        }
        /// <summary>
        /// 获取商品扩展信息（包括产品分类名称）
        /// </summary>
        /// <param name="shopid"></param>
        /// <returns></returns>
        public IList<ProductExtEntity> GetExtListByShopId(int shopid)
        {
            IList<ProductExtEntity> productsList = new List<ProductExtEntity>();
            productsList = productsdal.GetExtListByShopId(shopid);
            return productsList;
        }

        /// <summary>
        /// 通过店铺id和分类id，判断这分类下是否有商品存在
        /// </summary>
        /// <param name="shopid"></param>
        /// <param name="clsid"></param>
        /// <returns></returns>
        public bool Exists(int shopid, int clsid)
        {
            return productsdal.Exists(shopid,clsid);
        }
    }
}
