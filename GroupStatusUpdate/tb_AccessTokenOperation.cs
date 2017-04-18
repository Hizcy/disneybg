using Jnwf.Utils.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupStatusUpdate
{
    public class tb_AccessTokenOperation
    {
        string getConnectionString = Jnwf.Utils.Config.ConfigurationUtil.GetConnectionString("weipingtai"); 
        public tb_AccessTokenEntity GetModel(string weixincode)
        {
            tb_AccessTokenEntity _obj = null;
            SqlParameter[] _param ={
			
            new SqlParameter("@weixincode",SqlDbType.VarChar,50)
			};

            _param[0].Value = weixincode;

            string sqlStr = "select * from tb_AccessToken with(nolock) where WeiXinCode=@weixincode";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(getConnectionString, CommandType.Text, sqlStr, _param))
            {
                while (dr.Read())
                {
                    _obj = Populate_tb_AccessTokenEntity_FromDr(dr);
                }
            }
            return _obj;
        }
        /// <summary>
        /// 向数据表tb_AccessToken更新一条记录。
        /// </summary>
        /// <param name="_tb_AccessTokenModel">_tb_AccessTokenModel</param>
        /// <returns>影响的行数</returns>
        public int Update(tb_AccessTokenEntity _tb_AccessTokenModel)
        {
            string sqlStr = "update tb_AccessToken set [UserID]=@UserID,[WeiXinCode]=@WeiXinCode,[AccessToken]=@AccessToken,[AddTime]=@AddTime where ID=@ID";
            SqlParameter[] _param ={				
				new SqlParameter("@ID",SqlDbType.Int),
				new SqlParameter("@UserID",SqlDbType.VarChar),
				new SqlParameter("@WeiXinCode",SqlDbType.VarChar),
				new SqlParameter("@AccessToken",SqlDbType.VarChar),
				new SqlParameter("@AddTime",SqlDbType.DateTime)
				};
            _param[0].Value = _tb_AccessTokenModel.ID;
            _param[1].Value = _tb_AccessTokenModel.UserID;
            _param[2].Value = _tb_AccessTokenModel.WeiXinCode;
            _param[3].Value = _tb_AccessTokenModel.AccessToken;
            _param[4].Value = _tb_AccessTokenModel.AddTime;
            return SqlHelper.ExecuteNonQuery(getConnectionString, CommandType.Text, sqlStr, _param);
        }
        /// <summary>
        /// 得到  tb_accesstoken 数据实体
        /// </summary>
        /// <param name="dr">dr</param>
        /// <returns>tb_accesstoken 数据实体</returns>
        public tb_AccessTokenEntity Populate_tb_AccessTokenEntity_FromDr(IDataReader dr)
        {
            tb_AccessTokenEntity Obj = new tb_AccessTokenEntity();

            Obj.ID = ((dr["ID"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["ID"]);
            Obj.UserID = dr["UserID"].ToString();
            Obj.WeiXinCode = dr["WeiXinCode"].ToString();
            Obj.AccessToken = dr["AccessToken"].ToString();
            Obj.AddTime = ((dr["AddTime"]) == DBNull.Value) ? Convert.ToDateTime("1900-1-1") : Convert.ToDateTime(dr["AddTime"]);

            return Obj;
        }
    }
}
