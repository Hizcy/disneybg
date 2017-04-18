// =================================================================== 
// 项目说明
//====================================================================
// yangxg。@Copy Right 2014
// 文件： wx_RoleFenxiao.cs
// 项目名称：买车网
// 创建时间：2016/5/22
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
    /// 数据层实例化接口类 dbo.wx_RoleFenxiao.
    /// </summary>
    public partial class wx_RoleFenxiaoDataAccessLayer
    {
        public IList<wx_RoleFenxiaoEntity> GetListByShopId(int shopid)
        {
            IList<wx_RoleFenxiaoEntity> Obj = new List<wx_RoleFenxiaoEntity>();
            SqlParameter[] _param ={
			new SqlParameter("@ShopId",SqlDbType.Int)
			};
            _param[0].Value = shopid;
            string sqlStr = "select * from wx_RoleFenxiao with (nolock) where ShopId=@ShopId order by roleid";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.WfxRW, CommandType.Text, sqlStr, _param))
            {
                while (dr.Read())
                {
                    Obj.Add(Populate_wx_RoleFenxiaoEntity_FromDr(dr));
                }
            }
            return Obj;
        }
        public IList<wx_RoleFenxiaoEntity> GetListByShopIdAndRole(int shopid,int roleid)
        {
            IList<wx_RoleFenxiaoEntity> Obj = new List<wx_RoleFenxiaoEntity>();
            SqlParameter[] _param ={
			new SqlParameter("@ShopId",SqlDbType.Int),
			new SqlParameter("@RoleId",SqlDbType.Int)
			};
            _param[0].Value = shopid;
            _param[1].Value = roleid;
            string sqlStr = "select * from wx_RoleFenxiao with (nolock) where ShopId=@ShopId and RoleId=@RoleId";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.WfxRW, CommandType.Text, sqlStr, _param))
            {
                while (dr.Read())
                {
                    Obj.Add(Populate_wx_RoleFenxiaoEntity_FromDr(dr));
                }
            }
            return Obj;
        }
        public int Delete(int shopid,int roleid)
        {
            string sqlStr = "delete from wx_RoleFenxiao where [ShopId]=@ShopId and RoleId=@RoleId";
            SqlParameter[] _param ={			
			new SqlParameter("@ShopId",SqlDbType.Int),
			new SqlParameter("@RoleId",SqlDbType.Int)
			
			};
            _param[0].Value = shopid;
            _param[1].Value = roleid;
            return SqlHelper.ExecuteNonQuery(WebConfig.WfxRW, CommandType.Text, sqlStr, _param);
        }
	}
}
