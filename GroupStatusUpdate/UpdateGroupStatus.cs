using Jnwf.Utils.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupStatusUpdate
{
    public class UpdateGroupStatus
    {
        string getConnectionString = Jnwf.Utils.Config.ConfigurationUtil.GetConnectionString("Weifenxiao");
        string overdueTime = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("overdueTime");
        /// <summary>
        /// 定时修改团状态
        /// </summary>
        public void UpdateGroupStatusT()
        {
            string sqlStr = "UPDATE [T_Orders] SET [GroupStatus] =-1  WHERE [GroupNo] in(SELECT [GroupNo] FROM [weifenxiao].[dbo].[T_Orders] WHERE [Status] =2 and [HeadStatus] =1 and [GroupStatus] =0 and DATEADD(hh,{0},[AddTime])<getdate())";
            sqlStr = string.Format(sqlStr, overdueTime);
            SqlHelper.ExecuteNonQuery(getConnectionString,CommandType.Text, sqlStr);
        }
    }
}
