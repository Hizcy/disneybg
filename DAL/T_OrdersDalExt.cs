// =================================================================== 
// 项目说明
//====================================================================
// yangxg。@Copy Right 2014
// 文件： T_Orders.cs
// 项目名称：买车网
// 创建时间：2016/8/11
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
    /// 数据层实例化接口类 dbo.T_Orders.
    /// </summary>
    public partial class T_OrdersDataAccessLayer 
    {
        /// <summary>
        /// 订单退款
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public int OrdersTuiKuanPro(int orderId)
        {
            SqlParameter[] _param = {
                new SqlParameter("@OrderId",SqlDbType.Int)
            };
            _param[0].Value = orderId;
            object obj = SqlHelper.ExecuteScalar(WebConfig.WfxRW, CommandType.StoredProcedure, "pro_TuanTuikuan", _param);
            return Convert.ToInt32(obj);
        }
	}
}
