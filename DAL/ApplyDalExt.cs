// =================================================================== 
// 项目说明
//====================================================================
// yangxg。@Copy Right 2014
// 文件： Apply.cs
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
    /// 数据层实例化接口类 dbo.Apply.
    /// </summary>
    public partial class ApplyDataAccessLayer 
    {
        public IList<ApplyEntity> GetListByShopId(int shopid,int status)
        {
            IList<ApplyEntity> Obj = new List<ApplyEntity>();
            SqlParameter[] _param ={
			new SqlParameter("@ShopId",SqlDbType.Int),
            new SqlParameter("@Status",SqlDbType.Int)
			};
            _param[0].Value = shopid;
            _param[1].Value = status;
            string sqlStr = "select * from Apply with (nolock) where ShopId=@ShopId and Status=@Status";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.WfxRW, CommandType.Text, sqlStr, _param))
            {
                while (dr.Read())
                {
                    Obj.Add(Populate_ApplyEntity_FromDr(dr));
                }
            }
            return Obj;
        }
	}
}
