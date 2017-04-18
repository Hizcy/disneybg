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
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Weifenxiao.Entity;
using Jnwf.Utils.Data;


namespace Weifenxiao.DAL
{
    /// <summary>
    /// 数据层实例化接口类 dbo.Products.
    /// </summary>
    public partial class ProductsDataAccessLayer
    {
        /// <summary>
        /// 通过店铺id和分类id，判断这分类下是否有商品存在
        /// </summary>
        /// <param name="shopid"></param>
        /// <param name="clsid"></param>
        /// <returns></returns>
        public bool Exists(int shopid, int clsid)
        {
            SqlParameter[] _param ={
			new SqlParameter("@ShopId",SqlDbType.Int),
            new SqlParameter("@ClsId",SqlDbType.Int)
			};
            _param[0].Value = shopid;
            _param[1].Value = clsid;

            string sqlStr = "select count(1) from Products with (nolock) where ShopId=@ShopId and CategoryId=@ClsId";
            object obj = SqlHelper.ExecuteScalar(WebConfig.WfxRW, CommandType.Text, sqlStr, _param);

            if (obj.ToString() == "0")
                return false;
            else
                return true;
        }
        public IList<ProductsEntity> GetListByShopId(int shopid)
        {
            IList<ProductsEntity> Obj = new List<ProductsEntity>();
            SqlParameter[] _param ={
			new SqlParameter("@ShopId",SqlDbType.Int)
			};
            _param[0].Value = shopid;
            string sqlStr = "select * from Products with (nolock) where ShopId=@ShopId and Status=1";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.WfxRW, CommandType.Text, sqlStr, _param))
            {
                while (dr.Read())
                {
                    Obj.Add(Populate_ProductsEntity_FromDr(dr));
                }
            }
            return Obj;
        }

        public IList<ProductExtEntity> GetExtListByShopId(int shopid)
        {
            IList<ProductExtEntity> Obj = new List<ProductExtEntity>();
            SqlParameter[] _param ={
			new SqlParameter("@ShopId",SqlDbType.Int)
			};
            _param[0].Value = shopid;
            string sqlStr = "select a.*,b.clsname from Products a inner join ProductCls b on a.categoryid=b.clsid where ShopId=@ShopId and Status=1";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.WfxRW, CommandType.Text, sqlStr, _param))
            {
                while (dr.Read())
                {
                    Obj.Add(Populate_ProductExtEntity_FromDr(dr));
                }
            }
            return Obj;
        }
        public ProductExtEntity Populate_ProductExtEntity_FromDr(IDataReader dr)
        {
            ProductExtEntity Obj = new ProductExtEntity();

            Obj.ProductId = ((dr["ProductId"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["ProductId"]);
            Obj.ShopId = ((dr["ShopId"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["ShopId"]);
            Obj.CategoryId = ((dr["CategoryId"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["CategoryId"]);
            Obj.Name = dr["Name"].ToString();
            Obj.Intro = dr["Intro"].ToString();
            Obj.Description = dr["Description"].ToString();
            Obj.Image1 = dr["Image1"].ToString();
            Obj.Image2 = dr["Image2"].ToString();
            Obj.Image3 = dr["Image3"].ToString();
            Obj.Image4 = dr["Image4"].ToString();
            Obj.Image5 = dr["Image5"].ToString();
            Obj.CostPrice = ((dr["CostPrice"]) == DBNull.Value) ? 0 : Convert.ToDecimal(dr["CostPrice"]);
            Obj.SalePrice = ((dr["SalePrice"]) == DBNull.Value) ? 0 : Convert.ToDecimal(dr["SalePrice"]);
            Obj.Commission = ((dr["Commission"]) == DBNull.Value) ? 0 : Convert.ToDecimal(dr["Commission"]);
            Obj.Status = ((dr["Status"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["Status"]);
            Obj.AddTime = ((dr["AddTime"]) == DBNull.Value) ? Convert.ToDateTime("1900-1-1") : Convert.ToDateTime(dr["AddTime"]);
            Obj.UpdateTime = ((dr["UpdateTime"]) == DBNull.Value) ? Convert.ToDateTime("1900-1-1") : Convert.ToDateTime(dr["UpdateTime"]);
            Obj.OrderBy = ((dr["OrderBy"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["OrderBy"]);
            Obj.IsCommission = ((dr["IsCommission"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["IsCommission"]);

            Obj.Clsname = dr["clsname"].ToString();

            return Obj;
        }
	}
}
