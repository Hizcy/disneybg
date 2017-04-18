// =================================================================== 
// 项目说明
//====================================================================
// yangxg。@Copy Right 2014
// 文件： wx_Fenxiao.cs
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
    /// 数据层实例化接口类 dbo.wx_Fenxiao.
    /// </summary>
    public partial class wx_FenxiaoDataAccessLayer 
    {
        public IList<wx_FenxiaoEntity> GetListByShopId(int shopid)
        {
            IList<wx_FenxiaoEntity> Obj = new List<wx_FenxiaoEntity>();
            SqlParameter[] _param ={
			new SqlParameter("@ShopId",SqlDbType.Int)
			};
            _param[0].Value = shopid;
            string sqlStr = "select * from wx_Fenxiao with (nolock) where ShopId=@ShopId";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.WfxRW, CommandType.Text, sqlStr, _param))
            {
                while (dr.Read())
                {
                    Obj.Add(Populate_wx_FenxiaoEntity_FromDr(dr));
                }
            }
            return Obj;
        }
	}
}
