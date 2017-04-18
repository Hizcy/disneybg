// =================================================================== 
// 项目说明
//====================================================================
// yangxg。@Copy Right 2014
// 文件： wx_Config.cs
// 项目名称：买车网
// 创建时间：2016/6/23
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
    /// 数据层实例化接口类 dbo.wx_Config.
    /// </summary>
    public partial class wx_ConfigDataAccessLayer 
    {
        /// <summary>
        /// 根据PropertyId  查找
        /// </summary>
        /// <param name="PropertyId"></param>
        /// <returns></returns>
        public IList<wx_ConfigEntity> Get_tb_PropertyIdAll(int PropertyId)
        {
            IList<wx_ConfigEntity> Obj = new List<wx_ConfigEntity>();
            string sqlStr = "select * from [weifenxiao].[dbo].[wx_Config] where PropertyId=@PropertyId and Status=1";
            SqlParameter[] _param = {
               new SqlParameter("@PropertyId", SqlDbType.Int) 
            };
            _param[0].Value = PropertyId;
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.WfxRW, CommandType.Text, sqlStr, _param))
            {
                while (dr.Read())
                {
                    Obj.Add(Populate_wx_ConfigEntity_FromDr(dr));
                }
            }
            return Obj;
        }
	}
}
