// =================================================================== 
// 项目说明
//====================================================================
// yangxg。@Copy Right 2014
// 文件： ProductCls.cs
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
    public partial class ProductClsBLL : BaseBLL< ProductClsBLL>

    {
        ProductClsDataAccessLayer productClsdal;
        public ProductClsBLL()
        {
            productClsdal = new ProductClsDataAccessLayer();
        }

        public int Insert(ProductClsEntity productClsEntity)
        {
            return productClsdal.Insert(productClsEntity);            
        }

        public void Update(ProductClsEntity productClsEntity)
        {
            productClsdal.Update(productClsEntity);
        }

        public ProductClsEntity GetAdminSingle(int clsId)
        {
           return productClsdal.Get_ProductClsEntity(clsId);
        }

        public IList<ProductClsEntity> GetProductClsList()
        {
            IList<ProductClsEntity> productClsList = new List<ProductClsEntity>();
            productClsList=productClsdal.Get_ProductClsAll();
            return productClsList;
        }
        /// <summary>
        /// 获取商品类型列表（本店铺）
        /// </summary>
        /// <param name="shopid"></param>
        /// <returns></returns>
        public IList<ProductClsEntity> GetListByShopId(int shopid)
        {
            IList<ProductClsEntity> productClsList = new List<ProductClsEntity>();
            productClsList = productClsdal.GetListByShopId(shopid);
            return productClsList;
        }
        /// <summary>
        /// 删除商品分类，通过店铺id和分类id（如果分类下还有商品不能删除）
        /// </summary>
        /// <param name="shopid"></param>
        /// <param name="clsid"></param>
        /// <returns></returns>
        public int DeleteProductCls(int shopid, int clsid)
        {
            try
            {
                bool b = Weifenxiao.BLL.ProductsBLL.GetInstance().Exists(shopid, clsid);
                if (!b)
                {
                    ProductClsEntity model = GetAdminSingle(clsid);
                    model.Status = 0;
                    model.Updatetime = DateTime.Now;
                    Update(model);
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                return -1;
            }
            
        }
        /// <summary>
        /// 根据shopid  status 查询所有一级分类
        /// </summary>
        /// <returns></returns>
        public IList<ProductClsEntity> Get_ProductClsListAll(int shopid)
        {
            IList<ProductClsEntity> productClsList = new List<ProductClsEntity>();
            productClsList = productClsdal.Get_ProductClsListAll(shopid);
            return productClsList;
        }
        /// <summary>
        /// 根据一级分类的Clsid  查询二级分类
        /// </summary>
        /// <param name="ParentId"></param>
        /// <returns></returns>
        public IList<ProductClsEntity> GetListByParentId(int ParentId, int shopid)
        {
            IList<ProductClsEntity> productClsList = new List<ProductClsEntity>();
            productClsList = productClsdal.GetListByParentId(ParentId, shopid);
            return productClsList;
        }
        /// <summary>
        /// bool  二级分类 最多添加4个
        /// </summary>
        /// <param name="ParentId"></param>
        /// <param name="shopid"></param>
        /// <returns></returns>
        public bool GetParentId(int ParentId, int shopid)
        {
            return productClsdal.GetParentId(ParentId, shopid);
        }
    }
}
