// =================================================================== 
// 项目说明
//====================================================================
// yangxg。@Copy Right 2014
// 文件： T_Products.cs
// 项目名称：买车网
// 创建时间：2016/8/9
// 负责人：yangxg
// ===================================================================
using System;
using System.Collections.Generic;
using System.Text;
using Weifenxiao.DAL;
using Weifenxiao.Entity;
using System.Data;
namespace Weifenxiao.BLL
{
    public partial class T_ProductsBLL : BaseBLL< T_ProductsBLL>

    {
        T_ProductsDataAccessLayer t_Productsdal;
        public T_ProductsBLL()
        {
            t_Productsdal = new T_ProductsDataAccessLayer();
        }

        public int Insert(T_ProductsEntity t_ProductsEntity)
        {
            return t_Productsdal.Insert(t_ProductsEntity);            
        }

        public void Update(T_ProductsEntity t_ProductsEntity)
        {
            t_Productsdal.Update(t_ProductsEntity);
        }

        public T_ProductsEntity GetAdminSingle(int productId)
        {
           return t_Productsdal.Get_T_ProductsEntity(productId);
        }

        public IList<T_ProductsEntity> GetT_ProductsList()
        {
            IList<T_ProductsEntity> t_ProductsList = new List<T_ProductsEntity>();
            t_ProductsList=t_Productsdal.Get_T_ProductsAll();
            return t_ProductsList;
        }
        /// <summary>
        /// 获取分页  所有组团商品信息
        /// </summary>
        /// <param name="pagesize"></param>
        /// <param name="currentindex"></param>
        /// <param name="condition"></param>
        /// <param name="allcount"></param>
        /// <returns></returns>
        public DataSet Get_T_ListByPage(int pagesize, int currentindex, string condition, out int allcount)
        {
            return PageData.GetDataByPage("v_T_Products", "ProductId", "OrderBy desc", currentindex, pagesize, "*", condition, out allcount);
        }
    }
}
