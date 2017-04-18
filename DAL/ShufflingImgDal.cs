using Jnwf.Utils.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Weifenxiao.Entity;

namespace Weifenxiao.DAL
{
    /// <summary>
    /// 数据层实例化接口类 dbo.ShufflingImg
    /// </summary>
    public partial class ShufflingImgDataAccessLayer 
    {
        #region 构造函数


        /// <summary>
        /// 
        /// </summary>
        public ShufflingImgDataAccessLayer()
        {
        }
        #endregion

        #region -----------实例化接口函数-----------

        #region 添加更新删除
        /// <summary>
        /// 向数据库中插入一条新记录。
        /// </summary>
        /// <param name="_ShufflingImgEntity">wx_Users实体</param>
        /// <returns>新插入记录的编号</returns>
        public int Insert(ShufflingImgEntity _ShufflingImgEntity)
        {
            string sqlStr = "insert into [weifenxiao].[dbo].[ShufflingImg](ImgUrl,clsid,addtime,Updatetime,LinkUrl,ImgUrl2,ImgUrl3,ImgUrl4,ImgUrl5,LinkUrl2,LinkUrl3,LinkUrl4,LinkUrl5) VALUES(@ImgUrl,@clsid,@addtime,@Updatetime,@LinkUrl,@ImgUrl2,@ImgUrl3,@ImgUrl4,@ImgUrl5,@LinkUrl2,@LinkUrl3,@LinkUrl4,@LinkUrl5)";
            int res;
            SqlParameter[] _param ={
			new SqlParameter("@ImgUrl",SqlDbType.VarChar),
			new SqlParameter("@clsid",SqlDbType.VarChar),
			new SqlParameter("@addtime",SqlDbType.VarChar),
			new SqlParameter("@Updatetime",SqlDbType.VarChar) ,
            new SqlParameter("@LinkUrl",SqlDbType.VarChar),
            new SqlParameter("@LinkUrl2",SqlDbType.VarChar),
            new SqlParameter("@LinkUrl3",SqlDbType.VarChar),
            new SqlParameter("@LinkUrl4",SqlDbType.VarChar),
            new SqlParameter("@LinkUrl5",SqlDbType.VarChar),
            new SqlParameter("@ImgUrl2",SqlDbType.VarChar),
            new SqlParameter("@ImgUrl3",SqlDbType.VarChar),
            new SqlParameter("@ImgUrl4",SqlDbType.VarChar),
            new SqlParameter("@ImgUrl5",SqlDbType.VarChar)
			};
            _param[0].Value = _ShufflingImgEntity.ImgUrl;
            _param[1].Value = _ShufflingImgEntity.ClsId;
            _param[2].Value = _ShufflingImgEntity.Addtime;
            _param[3].Value = _ShufflingImgEntity.Updatetime;
            _param[4].Value = _ShufflingImgEntity.LinkUrl;
            _param[5].Value = _ShufflingImgEntity.LinkUrl2;
            _param[6].Value = _ShufflingImgEntity.LinkUrl3;
            _param[7].Value = _ShufflingImgEntity.LinkUrl4;
            _param[8].Value = _ShufflingImgEntity.LinkUrl5;
            _param[9].Value = _ShufflingImgEntity.ImgUrl2;
            _param[10].Value = _ShufflingImgEntity.ImgUrl3;
            _param[11].Value = _ShufflingImgEntity.ImgUrl4;
            _param[12].Value = _ShufflingImgEntity.ImgUrl5;
            res = SqlHelper.ExecuteNonQuery(WebConfig.weixinRW, CommandType.Text, sqlStr, _param);
            return res;
        }
        /// <summary>
        /// 向数据库中插入一条新记录。带事务
        /// </summary>
        /// <param name="sp">事务对象</param>
        /// <param name="_ShufflingImgEntity">wx_Users实体</param>
        /// <returns>新插入记录的编号</returns>
        public int Insert(SqlTransaction sp, ShufflingImgEntity _ShufflingImgEntity)
        {
            string sqlStr = "insert into [weifenxiao].[dbo].[ShufflingImg](ImgUrl,clsid,addtime,Updatetime,LinkUrl,ImgUrl2,ImgUrl3,ImgUrl4,ImgUrl5,LinkUrl2,LinkUrl3,LinkUrl4,LinkUrl5) VALUES(@ImgUrl,@clsid,@addtime,@Updatetime,@LinkUrl,@ImgUrl2,@ImgUrl3,@ImgUrl4,@ImgUrl5,@LinkUrl2,@LinkUrl3,@LinkUrl4,@LinkUrl5)";
            int res;
            SqlParameter[] _param ={
			new SqlParameter("@ImgUrl",SqlDbType.VarChar),
			new SqlParameter("@clsid",SqlDbType.VarChar),
			new SqlParameter("@addtime",SqlDbType.VarChar),
			new SqlParameter("@Updatetime",SqlDbType.VarChar) ,
            new SqlParameter("@LinkUrl",SqlDbType.VarChar),
            new SqlParameter("@LinkUrl2",SqlDbType.VarChar),
            new SqlParameter("@LinkUrl3",SqlDbType.VarChar),
            new SqlParameter("@LinkUrl4",SqlDbType.VarChar),
            new SqlParameter("@LinkUrl5",SqlDbType.VarChar),
            new SqlParameter("@ImgUrl2",SqlDbType.VarChar),
            new SqlParameter("@ImgUrl3",SqlDbType.VarChar),
            new SqlParameter("@ImgUrl4",SqlDbType.VarChar),
            new SqlParameter("@ImgUrl5",SqlDbType.VarChar)
			};
            _param[0].Value = _ShufflingImgEntity.ImgUrl;
            _param[1].Value = _ShufflingImgEntity.ClsId;
            _param[2].Value = _ShufflingImgEntity.Addtime;
            _param[3].Value = _ShufflingImgEntity.Updatetime;
            _param[4].Value = _ShufflingImgEntity.LinkUrl;
            _param[5].Value = _ShufflingImgEntity.LinkUrl2;
            _param[6].Value = _ShufflingImgEntity.LinkUrl3;
            _param[7].Value = _ShufflingImgEntity.LinkUrl4;
            _param[8].Value = _ShufflingImgEntity.LinkUrl5;
            _param[9].Value = _ShufflingImgEntity.ImgUrl2;
            _param[10].Value = _ShufflingImgEntity.ImgUrl3;
            _param[11].Value = _ShufflingImgEntity.ImgUrl4;
            _param[12].Value = _ShufflingImgEntity.ImgUrl5;
            res = SqlHelper.ExecuteNonQuery(sp, CommandType.Text, sqlStr, _param);
            return res;
        }


        /// <summary>
        /// 向数据表wx_Users更新一条记录。
        /// </summary>
        /// <param name="_ShufflingImgEntity">_ShufflingImgEntity</param>
        /// <returns>影响的行数</returns>
        public int Update(ShufflingImgEntity _ShufflingImgEntity)
        {
            string sqlStr = "UPDATE [weifenxiao].[dbo].[ShufflingImg] set [ImgUrl] =@ImgUrl,[ClsId] =@clsid,[Addtime] =@addtime,[Updatetime] =@Updatetime,LinkUrl=@LinkUrl,LinkUrl2=@LinkUrl2,LinkUrl3=@LinkUrl3,LinkUrl4=@LinkUrl4,LinkUrl5=@LinkUrl5,[ImgUrl2] =@ImgUrl2,[ImgUrl3] =@ImgUrl3,[ImgUrl4] =@ImgUrl4,[ImgUrl5] =@ImgUrl5 WHERE [ClsId] =@clsid";
            SqlParameter[] _param ={
			new SqlParameter("@ImgUrl",SqlDbType.VarChar),
			new SqlParameter("@clsid",SqlDbType.VarChar),
			new SqlParameter("@addtime",SqlDbType.VarChar),
			new SqlParameter("@Updatetime",SqlDbType.VarChar) ,
            new SqlParameter("@LinkUrl",SqlDbType.VarChar),
            new SqlParameter("@LinkUrl2",SqlDbType.VarChar),
            new SqlParameter("@LinkUrl3",SqlDbType.VarChar),
            new SqlParameter("@LinkUrl4",SqlDbType.VarChar),
            new SqlParameter("@LinkUrl5",SqlDbType.VarChar),
            new SqlParameter("@ImgUrl2",SqlDbType.VarChar),
            new SqlParameter("@ImgUrl3",SqlDbType.VarChar),
            new SqlParameter("@ImgUrl4",SqlDbType.VarChar),
            new SqlParameter("@ImgUrl5",SqlDbType.VarChar)
			};
            _param[0].Value = _ShufflingImgEntity.ImgUrl;
            _param[1].Value = _ShufflingImgEntity.ClsId;
            _param[2].Value = _ShufflingImgEntity.Addtime;
            _param[3].Value = _ShufflingImgEntity.Updatetime;
            _param[4].Value = _ShufflingImgEntity.LinkUrl;
            _param[5].Value = _ShufflingImgEntity.LinkUrl2;
            _param[6].Value = _ShufflingImgEntity.LinkUrl3;
            _param[7].Value = _ShufflingImgEntity.LinkUrl4;
            _param[8].Value = _ShufflingImgEntity.LinkUrl5;
            _param[9].Value = _ShufflingImgEntity.ImgUrl2;
            _param[10].Value = _ShufflingImgEntity.ImgUrl3;
            _param[11].Value = _ShufflingImgEntity.ImgUrl4;
            _param[12].Value = _ShufflingImgEntity.ImgUrl5;
            return SqlHelper.ExecuteNonQuery(WebConfig.weixinRW, CommandType.Text, sqlStr, _param);
        }
        /// <summary>
        /// 向数据表wx_Users更新一条记录。带事务
        /// </summary>
        /// <param name="sp">事务对象</param>
        /// <param name="_ShufflingImgEntity">_ShufflingImgEntity</param>
        /// <returns>影响的行数</returns>
        public int Update(SqlTransaction sp, ShufflingImgEntity _ShufflingImgEntity)
        {
            string sqlStr = "UPDATE [weifenxiao].[dbo].[ShufflingImg] set [ImgUrl] =@ImgUrl,[ClsId] =@clsid,[Addtime] =@addtime,[Updatetime] =@Updatetime,LinkUrl=@LinkUrl,LinkUrl2=@LinkUrl2,LinkUrl3=@LinkUrl3,LinkUrl4=@LinkUrl4,LinkUrl5=@LinkUrl5,[ImgUrl2] =@ImgUrl2,[ImgUrl3] =@ImgUrl3,[ImgUrl4] =@ImgUrl4,[ImgUrl5] =@ImgUrl5 WHERE [ClsId] =@clsid";
            SqlParameter[] _param ={
			new SqlParameter("@ImgUrl",SqlDbType.VarChar),
			new SqlParameter("@clsid",SqlDbType.VarChar),
			new SqlParameter("@addtime",SqlDbType.VarChar),
			new SqlParameter("@Updatetime",SqlDbType.VarChar) ,
            new SqlParameter("@LinkUrl",SqlDbType.VarChar),
            new SqlParameter("@LinkUrl2",SqlDbType.VarChar),
            new SqlParameter("@LinkUrl3",SqlDbType.VarChar),
            new SqlParameter("@LinkUrl4",SqlDbType.VarChar),
            new SqlParameter("@LinkUrl5",SqlDbType.VarChar),
            new SqlParameter("@ImgUrl2",SqlDbType.VarChar),
            new SqlParameter("@ImgUrl3",SqlDbType.VarChar),
            new SqlParameter("@ImgUrl4",SqlDbType.VarChar),
            new SqlParameter("@ImgUrl5",SqlDbType.VarChar)
			};
            _param[0].Value = _ShufflingImgEntity.ImgUrl;
            _param[1].Value = _ShufflingImgEntity.ClsId;
            _param[2].Value = _ShufflingImgEntity.Addtime;
            _param[3].Value = _ShufflingImgEntity.Updatetime;
            _param[4].Value = _ShufflingImgEntity.LinkUrl;
            _param[5].Value = _ShufflingImgEntity.LinkUrl2;
            _param[6].Value = _ShufflingImgEntity.LinkUrl3;
            _param[7].Value = _ShufflingImgEntity.LinkUrl4;
            _param[8].Value = _ShufflingImgEntity.LinkUrl5;
            _param[9].Value = _ShufflingImgEntity.ImgUrl2;
            _param[10].Value = _ShufflingImgEntity.ImgUrl3;
            _param[11].Value = _ShufflingImgEntity.ImgUrl4;
            _param[12].Value = _ShufflingImgEntity.ImgUrl5;
            return SqlHelper.ExecuteNonQuery(sp, CommandType.Text, sqlStr, _param);
        }


        #endregion

        #region 数据实体
        /// <summary>
        /// 得到  wx_users 数据实体
        /// </summary>
        /// <param name="row">row</param>
        /// <returns>wx_users 数据实体</returns>
        public ShufflingImgEntity Populate_ShufflingImgEntity_FromDr(DataRow row)
        {
            ShufflingImgEntity Obj = new ShufflingImgEntity();
            if (row != null)
            {
                Obj.ImgUrl = row["ImgUrl"].ToString();
                Obj.ClsId = ((row["ClsId"]) == DBNull.Value) ? 0 : Convert.ToInt32(row["ClsId"]);
                Obj.Addtime = ((row["Addtime"]) == DBNull.Value) ? Convert.ToDateTime("1900-1-1") : Convert.ToDateTime(row["Addtime"]);
                Obj.Updatetime = ((row["Updatetime"]) == DBNull.Value) ? Convert.ToDateTime("1900-1-1") : Convert.ToDateTime(row["Updatetime"]);
                Obj.LinkUrl = row["LinkUrl"].ToString();
                Obj.LinkUrl2 = row["LinkUrl2"].ToString();
                Obj.LinkUrl3 = row["LinkUrl3"].ToString();
                Obj.LinkUrl4 = row["LinkUrl4"].ToString();
                Obj.LinkUrl5 = row["LinkUrl5"].ToString();
                Obj.ImgUrl2 = row["ImgUrl2"].ToString();
                Obj.ImgUrl3 = row["ImgUrl3"].ToString();
                Obj.ImgUrl4 = row["ImgUrl4"].ToString();
                Obj.ImgUrl5 = row["ImgUrl5"].ToString();
            }
            else
            {
                return null;
            }
            return Obj;
        }

        /// <summary>
        /// 得到  wx_users 数据实体
        /// </summary>
        /// <param name="dr">dr</param>
        /// <returns>wx_users 数据实体</returns>
        public ShufflingImgEntity Populate_ShufflingImgEntity_FromDr(IDataReader dr)
        {
            ShufflingImgEntity Obj = new ShufflingImgEntity();

            Obj.ImgUrl = dr["ImgUrl"].ToString();
            Obj.ClsId = ((dr["ClsId"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["ClsId"]);
            Obj.Addtime = ((dr["Addtime"]) == DBNull.Value) ? Convert.ToDateTime("1900-1-1") : Convert.ToDateTime(dr["Addtime"]);
            Obj.Updatetime = ((dr["Updatetime"]) == DBNull.Value) ? Convert.ToDateTime("1900-1-1") : Convert.ToDateTime(dr["Updatetime"]);
            Obj.LinkUrl = dr["LinkUrl"].ToString();
            Obj.ImgUrl2 = dr["ImgUrl2"].ToString();
            Obj.ImgUrl3 = dr["ImgUrl3"].ToString();
            Obj.ImgUrl4 = dr["ImgUrl4"].ToString();
            Obj.ImgUrl5 = dr["ImgUrl5"].ToString();
            Obj.LinkUrl2 = dr["LinkUrl2"].ToString();
            Obj.LinkUrl3 = dr["LinkUrl3"].ToString();
            Obj.LinkUrl4 = dr["LinkUrl4"].ToString();
            Obj.LinkUrl5 = dr["LinkUrl5"].ToString();
            return Obj;
        }
        #endregion


        /// <summary>
        /// 得到数据表wx_Users所有记录
        /// </summary>
        /// <returns>数据集</returns>
        public IList<ShufflingImgEntity> Get_ShufflingImgAll()
        {
            IList<ShufflingImgEntity> Obj = new List<ShufflingImgEntity>();
            string sqlStr = "SELECT * FROM [weifenxiao].[dbo].[ShufflingImg]";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.weixinRW, CommandType.Text, sqlStr))
            {
                while (dr.Read())
                {
                    Obj.Add(Populate_ShufflingImgEntity_FromDr(dr));
                }
            }
            return Obj;
        }

        public ShufflingImgEntity Get_ShufflingImgEntity(int clsId)
        {
            ShufflingImgEntity _obj = null;
            SqlParameter[] _param ={
                 new SqlParameter("@ClsId",SqlDbType.Int)
              };
            _param[0].Value = clsId;
            string sqlStr = "SELECT * FROM [weifenxiao].[dbo].[ShufflingImg] where ClsId=@ClsId";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.weixinRW, CommandType.Text, sqlStr, _param))
            {
                while (dr.Read())
                {
                    _obj = Populate_ShufflingImgEntity_FromDr(dr);
                }
            }
            return _obj;
        }
        public bool ShufflingImgEntityByClsIdBool(int clsId)
        {
            SqlParameter[] _param ={
                 new SqlParameter("@ClsId",SqlDbType.Int)
              };
            _param[0].Value = clsId;
            string sqlStr = "SELECT count(*) FROM [weifenxiao].[dbo].[ShufflingImg] where ClsId=@ClsId";
            object obj = SqlHelper.ExecuteScalar(WebConfig.weixinRW, CommandType.Text, sqlStr, _param);
            int i = Convert.ToInt32(obj);
            return i > 0 ? true : false;
        }



        #endregion

        #region----------自定义实例化接口函数----------
        #endregion
    }
}
