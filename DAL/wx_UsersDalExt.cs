// =================================================================== 
// 项目说明
//====================================================================
// yangxg。@Copy Right 2014
// 文件： wx_Users.cs
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
    /// 数据层实例化接口类 dbo.wx_Users.
    /// </summary>
    public partial class wx_UsersDataAccessLayer
    {
        public int Pro_Register(string realname, string phone, string weixin, string advantages, string openid, int shopid, int locationid, string address, int parentid)
        {
            int res;
            SqlParameter[] _param ={
			new SqlParameter("@realname",SqlDbType.NVarChar),
			new SqlParameter("@phone",SqlDbType.VarChar),
			new SqlParameter("@weixin",SqlDbType.VarChar),
			new SqlParameter("@advantages",SqlDbType.NVarChar),
            
			new SqlParameter("@openid",SqlDbType.VarChar),
			new SqlParameter("@shopid",SqlDbType.Int),
			new SqlParameter("@locationid",SqlDbType.Int),
			new SqlParameter("@address",SqlDbType.NVarChar),

            new SqlParameter("@parentid",SqlDbType.Int)
            };
            _param[0].Value = realname;
            _param[1].Value = phone;
            _param[2].Value = weixin;
            _param[3].Value = advantages;

            _param[4].Value = openid;
            _param[5].Value = shopid;
            _param[6].Value = locationid;
            _param[7].Value = address;

            _param[8].Value = parentid;

            res = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.WfxRW, CommandType.StoredProcedure, "pro_Register", _param));
            return res;
        }
        
        public wx_UserExtEntity GetExtModelByUserId(int userid)
        {
            wx_UserExtEntity _obj = null;
            SqlParameter[] _param ={
			new SqlParameter("@UserId",SqlDbType.Int)
			};
            _param[0].Value = userid;
            string sqlStr = "select * from v_UserExt with(nolock) where UserId=@UserId";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.WfxRW, CommandType.Text, sqlStr, _param))
            {
                while (dr.Read())
                {
                    _obj = Populate_wx_UserExtEntity_FromDr(dr);
                }
            }
            return _obj;
        }
        public wx_UsersEntity Get_wx_UsersEntity(string openId)
        {
            wx_UsersEntity _obj = null;
            SqlParameter[] _param ={
			new SqlParameter("@OpenId",SqlDbType.VarChar)
			};
            _param[0].Value = openId;
            string sqlStr = "select * from wx_Users with(nolock) where OpenId=@OpenId";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.WfxRW, CommandType.Text, sqlStr, _param))
            {
                while (dr.Read())
                {
                    _obj = Populate_wx_UsersEntity_FromDr(dr);
                }
            }
            return _obj;
        }
        public DataSet Get_v_UserExt(int userid)
        {
            SqlParameter[] _param ={
			new SqlParameter("@userid",SqlDbType.Int)
			};
            _param[0].Value = userid;
            string sqlStr = "select * from v_UserExt with (nolock) where userid=@userid";
            return SqlHelper.ExecuteDataset(WebConfig.WfxRW, CommandType.Text, sqlStr, _param);

        }
        public wx_UserExtEntity Populate_wx_UserExtEntity_FromDr(IDataReader dr)
        {
            wx_UserExtEntity Obj = new wx_UserExtEntity();

            Obj.UserId = ((dr["UserId"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["UserId"]);
            Obj.RealName = dr["RealName"].ToString();
            Obj.Phone = dr["Phone"].ToString();
            Obj.Weixin = dr["Weixin"].ToString();
            Obj.Description = dr["Description"].ToString();
            Obj.OpenId = dr["OpenId"].ToString();
            Obj.ShopId = ((dr["ShopId"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["ShopId"]);
            Obj.RoleId = ((dr["RoleId"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["RoleId"]);
            Obj.Status = ((dr["Status"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["Status"]);
            Obj.Address = dr["Address"].ToString();
            Obj.Points = ((dr["Points"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["Points"]);
            Obj.Wallet = ((dr["Wallet"]) == DBNull.Value) ? 0 : Convert.ToDecimal(dr["Wallet"]);
            Obj.AddTime = ((dr["AddTime"]) == DBNull.Value) ? Convert.ToDateTime("1900-1-1") : Convert.ToDateTime(dr["AddTime"]);
            Obj.UpdateTime = ((dr["UpdateTime"]) == DBNull.Value) ? Convert.ToDateTime("1900-1-1") : Convert.ToDateTime(dr["UpdateTime"]);
            Obj.ParentId = ((dr["ParentId"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["ParentId"]);


            Obj.ParentName = dr["ParentName"].ToString();
            Obj.NickName = dr["NickName"].ToString();
            Obj.HeadImgurl = dr["HeadImgurl"].ToString();
            Obj.RoleName = dr["rolename"].ToString();

            Obj.yeji = ((dr["yeji"]) == DBNull.Value) ? 0 : Convert.ToDecimal(dr["yeji"]);
            Obj.yongjin = ((dr["yongjin"]) == DBNull.Value) ? 0 : Convert.ToDecimal(dr["yongjin"]);
            Obj.tixian = ((dr["tixian"]) == DBNull.Value) ? 0 : Convert.ToDecimal(dr["tixian"]);
            Obj.yijidaili = ((dr["yijidaili"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["yijidaili"]);
            Obj.erjidaili = ((dr["erjidaili"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["erjidaili"]);
            return Obj;
        }
	}
}
