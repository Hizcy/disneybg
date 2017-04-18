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
    /// 数据层实例化接口类 dbo.ProductCls.
    /// </summary>
    public partial class ProductClsDataAccessLayer
    {
        public IList<ProductClsEntity> GetListByShopId(int shopid)
        {
            IList<ProductClsEntity> Obj = new List<ProductClsEntity>();
            SqlParameter[] _param ={
			new SqlParameter("@ShopId",SqlDbType.Int)
			};
            _param[0].Value = shopid;
            string sqlStr = "select * from ProductCls with(nolock) where ShopId=@ShopId and Status=1";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.WfxRW, CommandType.Text, sqlStr, _param))
            {
                while (dr.Read())
                {
                    Obj.Add(Populate_ProductClsEntity_FromDr(dr));
                }
            }
            return Obj;
        }

        public IList<ProductClsEntity> Get_ProductClsListAll(int shopid)
        {
            IList<ProductClsEntity> Obj = new List<ProductClsEntity>();
            SqlParameter[] _param ={
            new SqlParameter("@shopid",SqlDbType.Int)
			};
            _param[0].Value = shopid;
            string sqlStr = "SELECT * from [ProductCls] WHERE [ShopId] =@shopid and [ParentId] =0 and [Status] =1";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.WfxRW, CommandType.Text, sqlStr, _param))
            {
                while (dr.Read())
                {
                    Obj.Add(Populate_ProductClsEntity_FromDr(dr));
                }
            }
            return Obj;
        }
        public IList<ProductClsEntity> GetListByParentId(int ParentId,int shopid)
        {
            IList<ProductClsEntity> Obj = new List<ProductClsEntity>();
            SqlParameter[] _param ={
			new SqlParameter("@ParentId",SqlDbType.Int),
            new SqlParameter("@shopid",SqlDbType.Int)
			};
            _param[0].Value = ParentId;
            _param[1].Value = shopid;
            string sqlStr = "SELECT  * from [ProductCls] WHERE [ParentId] =@ParentId and [Status] =1 and [ShopId] =@shopid";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.WfxRW, CommandType.Text, sqlStr, _param))
            {
                while (dr.Read())
                {
                    Obj.Add(Populate_ProductClsEntity_FromDr(dr));
                }
            }
            return Obj;
        }
        /// <summary>
        /// bool 二级分类最多添加4个
        /// </summary>
        /// <param name="ParentId"></param>
        /// <param name="shopid"></param>
        /// <returns></returns>
        public bool GetParentId(int ParentId,int shopid)
        {
            //tb_BuyerEntity _obj = null;
            SqlParameter[] _param ={
			new SqlParameter("@ParentId",SqlDbType.Int),
             new SqlParameter("@shopid",SqlDbType.Int)
			};
            _param[0].Value = ParentId;
            _param[1].Value = shopid;
            string sqlStr = "select count(1) from ProductCls with(nolock) where [ParentId] =@ParentId and [Status] =1 and [ShopId] =@shopid";
            object obj = SqlHelper.ExecuteScalar(WebConfig.WfxRW, CommandType.Text, sqlStr, _param);

            int rows=0;
            int.TryParse(obj.ToString(),out rows);
            if (rows < 4)
                return true;
            else
                return false;
        }
	}
}
