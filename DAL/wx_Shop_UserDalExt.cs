// =================================================================== 
// 项目说明
//====================================================================
// yangxg。@Copy Right 2014
// 文件： wx_Shop_User.cs
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
    /// 数据层实例化接口类 dbo.wx_Shop_User.
    /// </summary>
    public partial class wx_Shop_UserDataAccessLayer
    {
        /// <summary>
        /// 通过userid获取店铺用户关系表实体
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        public wx_Shop_UserEntity GetModelByUserId(int userid)
        {
            wx_Shop_UserEntity _obj = null;
            SqlParameter[] _param ={
			new SqlParameter("@UserId",SqlDbType.Int)
			};
            _param[0].Value = userid;
            string sqlStr = "select * from wx_Shop_User with(nolock) where UserId=@UserId";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.WfxRW, CommandType.Text, sqlStr, _param))
            {
                while (dr.Read())
                {
                    _obj = Populate_wx_Shop_UserEntity_FromDr(dr);
                }
            }
            return _obj;
        }
	}
}
