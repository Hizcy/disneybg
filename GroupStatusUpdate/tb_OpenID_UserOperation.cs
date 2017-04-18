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
    public class tb_OpenID_UserOperation
    {
        string getConnectionString = Jnwf.Utils.Config.ConfigurationUtil.GetConnectionString("weipingtai"); 
        public tb_OpenID_UserEntity GetModelByOpenId(string openid)
        {
            tb_OpenID_UserEntity _obj = null;
            SqlParameter[] _param ={
			new SqlParameter("@openid",SqlDbType.VarChar)
			};
            _param[0].Value = openid;
            string sqlStr = "select * from tb_OpenID_User with(nolock) where openid=@openid";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(getConnectionString, CommandType.Text, sqlStr, _param))
            {
                while (dr.Read())
                {
                    _obj = Populate_tb_OpenID_UserEntity_FromDr(dr);
                }
            }
            return _obj;
        } 
        /// <summary>
        /// 得到  tb_openid_user 数据实体
        /// </summary>
        /// <param name="dr">dr</param>
        /// <returns>tb_openid_user 数据实体</returns>
        public tb_OpenID_UserEntity Populate_tb_OpenID_UserEntity_FromDr(IDataReader dr)
        {
            tb_OpenID_UserEntity Obj = new tb_OpenID_UserEntity();

            Obj.ID = ((dr["ID"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["ID"]);
            Obj.OpenID = dr["OpenID"].ToString();
            Obj.NickName = dr["NickName"].ToString();
            Obj.Sex = ((dr["Sex"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["Sex"]);
            Obj.City = dr["City"].ToString();
            Obj.Country = dr["Country"].ToString();
            Obj.Province = dr["Province"].ToString();
            Obj.Language = dr["Language"].ToString();
            Obj.HeadImgurl = dr["HeadImgurl"].ToString();
            Obj.LoginName = dr["LoginName"].ToString();
            Obj.LoginPwd = dr["LoginPwd"].ToString();

            return Obj;
        }
        /// <summary>
        /// 向数据库中插入一条新记录。
        /// </summary>
        /// <param name="_tb_OpenID_UserModel">tb_OpenID_User实体</param>
        /// <returns>新插入记录的编号</returns>
        public int Insert(tb_OpenID_UserEntity _tb_OpenID_UserModel)
        {
            string sqlStr = "insert into tb_OpenID_User([OpenID],[NickName],[Sex],[City],[Country],[Province],[Language],[HeadImgurl],[LoginName],[LoginPwd]) values(@OpenID,@NickName,@Sex,@City,@Country,@Province,@Language,@HeadImgurl,@LoginName,@LoginPwd) select @@identity";
            int res;
            SqlParameter[] _param ={
			new SqlParameter("@OpenID",SqlDbType.VarChar),
			new SqlParameter("@NickName",SqlDbType.VarChar),
			new SqlParameter("@Sex",SqlDbType.Int),
			new SqlParameter("@City",SqlDbType.VarChar),
			new SqlParameter("@Country",SqlDbType.VarChar),
			new SqlParameter("@Province",SqlDbType.VarChar),
			new SqlParameter("@Language",SqlDbType.VarChar),
			new SqlParameter("@HeadImgurl",SqlDbType.VarChar),
			new SqlParameter("@LoginName",SqlDbType.VarChar),
			new SqlParameter("@LoginPwd",SqlDbType.VarChar)
			};
            _param[0].Value = _tb_OpenID_UserModel.OpenID;
            _param[1].Value = _tb_OpenID_UserModel.NickName;
            _param[2].Value = _tb_OpenID_UserModel.Sex;
            _param[3].Value = _tb_OpenID_UserModel.City;
            _param[4].Value = _tb_OpenID_UserModel.Country;
            _param[5].Value = _tb_OpenID_UserModel.Province;
            _param[6].Value = _tb_OpenID_UserModel.Language;
            _param[7].Value = _tb_OpenID_UserModel.HeadImgurl;
            _param[8].Value = _tb_OpenID_UserModel.LoginName;
            _param[9].Value = _tb_OpenID_UserModel.LoginPwd;
            res = Convert.ToInt32(SqlHelper.ExecuteScalar(getConnectionString, CommandType.Text, sqlStr, _param));
            return res;
        }
    }
}
