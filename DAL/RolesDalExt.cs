// =================================================================== 
// 项目说明
//====================================================================
// yangxg。@Copy Right 2014
// 文件： Roles.cs
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
    /// 数据层实例化接口类 dbo.Roles.
    /// </summary>
    public partial class RolesDataAccessLayer
    {
        public IList<RolesEntity> GetListByShopId(int shopid)
        {
            IList<RolesEntity> Obj = new List<RolesEntity>();
            SqlParameter[] _param ={
			new SqlParameter("@ShopId",SqlDbType.Int)
			};
            _param[0].Value = shopid;
            string sqlStr = "select * from Roles with (nolock) where ShopId=@ShopId";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.WfxRW, CommandType.Text, sqlStr, _param))
            {
                while (dr.Read())
                {
                    Obj.Add(Populate_RolesEntity_FromDr(dr));
                }
            }
            return Obj;
        }
	}
}
