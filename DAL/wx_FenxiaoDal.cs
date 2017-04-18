// =================================================================== 
// 项目说明
//====================================================================
// yangxg。@Copy Right 2014
// 文件： wx_Fenxiao.cs
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
using Jnwf.Utils.Data;
using Weifenxiao.Entity;



namespace Weifenxiao.DAL
{
    /// <summary>
    /// 数据层实例化接口类 dbo.wx_Fenxiao.
    /// </summary>
    public partial class wx_FenxiaoDataAccessLayer 
    {
		#region 构造函数


		/// <summary>
		/// 
		/// </summary>
		public wx_FenxiaoDataAccessLayer()
		{
		}
		#endregion

        #region -----------实例化接口函数-----------
		
		#region 添加更新删除
		/// <summary>
		/// 向数据库中插入一条新记录。
		/// </summary>
		/// <param name="_wx_FenxiaoModel">wx_Fenxiao实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(wx_FenxiaoEntity _wx_FenxiaoModel)
		{
			string sqlStr="insert into wx_Fenxiao([ShopId],[RoleId],[OneFenxiao],[TwoFenxiao],[ThreeFenxiao],[QuDao]) values(@ShopId,@RoleId,@OneFenxiao,@TwoFenxiao,@ThreeFenxiao,@QuDao) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@ShopId",SqlDbType.Int),
			new SqlParameter("@RoleId",SqlDbType.Int),
			new SqlParameter("@OneFenxiao",SqlDbType.Int),
			new SqlParameter("@TwoFenxiao",SqlDbType.Int),
			new SqlParameter("@ThreeFenxiao",SqlDbType.Int),
			new SqlParameter("@QuDao",SqlDbType.Int)
			};			
			_param[0].Value=_wx_FenxiaoModel.ShopId;
			_param[1].Value=_wx_FenxiaoModel.RoleId;
			_param[2].Value=_wx_FenxiaoModel.OneFenxiao;
			_param[3].Value=_wx_FenxiaoModel.TwoFenxiao;
			_param[4].Value=_wx_FenxiaoModel.ThreeFenxiao;
			_param[5].Value=_wx_FenxiaoModel.QuDao;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.WfxRW,CommandType.Text,sqlStr,_param));
			return res;
		}
		/// <summary>
		/// 向数据库中插入一条新记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_wx_FenxiaoModel">wx_Fenxiao实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(SqlTransaction sp,wx_FenxiaoEntity _wx_FenxiaoModel)
		{
			string sqlStr="insert into wx_Fenxiao([ShopId],[RoleId],[OneFenxiao],[TwoFenxiao],[ThreeFenxiao],[QuDao]) values(@ShopId,@RoleId,@OneFenxiao,@TwoFenxiao,@ThreeFenxiao,@QuDao) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@ShopId",SqlDbType.Int),
			new SqlParameter("@RoleId",SqlDbType.Int),
			new SqlParameter("@OneFenxiao",SqlDbType.Int),
			new SqlParameter("@TwoFenxiao",SqlDbType.Int),
			new SqlParameter("@ThreeFenxiao",SqlDbType.Int),
			new SqlParameter("@QuDao",SqlDbType.Int)
			};			
			_param[0].Value=_wx_FenxiaoModel.ShopId;
			_param[1].Value=_wx_FenxiaoModel.RoleId;
			_param[2].Value=_wx_FenxiaoModel.OneFenxiao;
			_param[3].Value=_wx_FenxiaoModel.TwoFenxiao;
			_param[4].Value=_wx_FenxiaoModel.ThreeFenxiao;
			_param[5].Value=_wx_FenxiaoModel.QuDao;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(sp,CommandType.Text,sqlStr,_param));
			return res;
		}


		/// <summary>
		/// 向数据表wx_Fenxiao更新一条记录。
		/// </summary>
		/// <param name="_wx_FenxiaoModel">_wx_FenxiaoModel</param>
		/// <returns>影响的行数</returns>
		public int Update(wx_FenxiaoEntity _wx_FenxiaoModel)
		{
            string sqlStr="update wx_Fenxiao set [ShopId]=@ShopId,[RoleId]=@RoleId,[OneFenxiao]=@OneFenxiao,[TwoFenxiao]=@TwoFenxiao,[ThreeFenxiao]=@ThreeFenxiao,[QuDao]=@QuDao where Id=@Id";
			SqlParameter[] _param={				
				new SqlParameter("@Id",SqlDbType.Int),
				new SqlParameter("@ShopId",SqlDbType.Int),
				new SqlParameter("@RoleId",SqlDbType.Int),
				new SqlParameter("@OneFenxiao",SqlDbType.Int),
				new SqlParameter("@TwoFenxiao",SqlDbType.Int),
				new SqlParameter("@ThreeFenxiao",SqlDbType.Int),
				new SqlParameter("@QuDao",SqlDbType.Int)
				};				
				_param[0].Value=_wx_FenxiaoModel.Id;
				_param[1].Value=_wx_FenxiaoModel.ShopId;
				_param[2].Value=_wx_FenxiaoModel.RoleId;
				_param[3].Value=_wx_FenxiaoModel.OneFenxiao;
				_param[4].Value=_wx_FenxiaoModel.TwoFenxiao;
				_param[5].Value=_wx_FenxiaoModel.ThreeFenxiao;
				_param[6].Value=_wx_FenxiaoModel.QuDao;
                return SqlHelper.ExecuteNonQuery(WebConfig.WfxRW, CommandType.Text, sqlStr, _param);
		}
		/// <summary>
		/// 向数据表wx_Fenxiao更新一条记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_wx_FenxiaoModel">_wx_FenxiaoModel</param>
		/// <returns>影响的行数</returns>
		public int Update(SqlTransaction sp,wx_FenxiaoEntity _wx_FenxiaoModel)
		{
            string sqlStr="update wx_Fenxiao set [ShopId]=@ShopId,[RoleId]=@RoleId,[OneFenxiao]=@OneFenxiao,[TwoFenxiao]=@TwoFenxiao,[ThreeFenxiao]=@ThreeFenxiao,[QuDao]=@QuDao where Id=@Id";
			SqlParameter[] _param={				
				new SqlParameter("@Id",SqlDbType.Int),
				new SqlParameter("@ShopId",SqlDbType.Int),
				new SqlParameter("@RoleId",SqlDbType.Int),
				new SqlParameter("@OneFenxiao",SqlDbType.Int),
				new SqlParameter("@TwoFenxiao",SqlDbType.Int),
				new SqlParameter("@ThreeFenxiao",SqlDbType.Int),
				new SqlParameter("@QuDao",SqlDbType.Int)
				};				
				_param[0].Value=_wx_FenxiaoModel.Id;
				_param[1].Value=_wx_FenxiaoModel.ShopId;
				_param[2].Value=_wx_FenxiaoModel.RoleId;
				_param[3].Value=_wx_FenxiaoModel.OneFenxiao;
				_param[4].Value=_wx_FenxiaoModel.TwoFenxiao;
				_param[5].Value=_wx_FenxiaoModel.ThreeFenxiao;
				_param[6].Value=_wx_FenxiaoModel.QuDao;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}		
		
		
		/// <summary>
		/// 删除数据表wx_Fenxiao中的一条记录
		/// </summary>
	    /// <param name="Id">id</param>
		/// <returns>影响的行数</returns>
		public int Delete(int Id)
		{
			string sqlStr="delete from wx_Fenxiao where [Id]=@Id";
			SqlParameter[] _param={			
			new SqlParameter("@Id",SqlDbType.Int),
			
			};			
			_param[0].Value=Id;
            return SqlHelper.ExecuteNonQuery(WebConfig.WfxRW, CommandType.Text, sqlStr, _param);
		}
		
		/// <summary>
		/// 删除数据表wx_Fenxiao中的一条记录,带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
	    /// <param name="Id">id</param>
		/// <returns>影响的行数</returns>
		public int Delete(SqlTransaction sp,int Id)
		{
			string sqlStr="delete from wx_Fenxiao where [Id]=@Id";
			SqlParameter[] _param={			
			new SqlParameter("@Id",SqlDbType.Int),
			
			};			
			_param[0].Value=Id;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}
		#endregion
		
		#region 数据实体
		/// <summary>
		/// 得到  wx_fenxiao 数据实体
		/// </summary>
		/// <param name="row">row</param>
		/// <returns>wx_fenxiao 数据实体</returns>
		public wx_FenxiaoEntity Populate_wx_FenxiaoEntity_FromDr(DataRow row)
		{
			wx_FenxiaoEntity Obj = new wx_FenxiaoEntity();
			if(row!=null)
			{
				Obj.Id = (( row["Id"])==DBNull.Value)?0:Convert.ToInt32( row["Id"]);
				Obj.ShopId = (( row["ShopId"])==DBNull.Value)?0:Convert.ToInt32( row["ShopId"]);
				Obj.RoleId = (( row["RoleId"])==DBNull.Value)?0:Convert.ToInt32( row["RoleId"]);
				Obj.OneFenxiao = (( row["OneFenxiao"])==DBNull.Value)?0:Convert.ToInt32( row["OneFenxiao"]);
				Obj.TwoFenxiao = (( row["TwoFenxiao"])==DBNull.Value)?0:Convert.ToInt32( row["TwoFenxiao"]);
				Obj.ThreeFenxiao = (( row["ThreeFenxiao"])==DBNull.Value)?0:Convert.ToInt32( row["ThreeFenxiao"]);
				Obj.QuDao = (( row["QuDao"])==DBNull.Value)?0:Convert.ToInt32( row["QuDao"]);
			}
			else
			{
				return null;
			}
			return Obj;
		}
		
        /// <summary>
		/// 得到  wx_fenxiao 数据实体
		/// </summary>
		/// <param name="dr">dr</param>
		/// <returns>wx_fenxiao 数据实体</returns>
		public wx_FenxiaoEntity Populate_wx_FenxiaoEntity_FromDr(IDataReader dr)
		{
			wx_FenxiaoEntity Obj = new wx_FenxiaoEntity();
			
				Obj.Id = (( dr["Id"])==DBNull.Value)?0:Convert.ToInt32( dr["Id"]);
				Obj.ShopId = (( dr["ShopId"])==DBNull.Value)?0:Convert.ToInt32( dr["ShopId"]);
				Obj.RoleId = (( dr["RoleId"])==DBNull.Value)?0:Convert.ToInt32( dr["RoleId"]);
				Obj.OneFenxiao = (( dr["OneFenxiao"])==DBNull.Value)?0:Convert.ToInt32( dr["OneFenxiao"]);
				Obj.TwoFenxiao = (( dr["TwoFenxiao"])==DBNull.Value)?0:Convert.ToInt32( dr["TwoFenxiao"]);
				Obj.ThreeFenxiao = (( dr["ThreeFenxiao"])==DBNull.Value)?0:Convert.ToInt32( dr["ThreeFenxiao"]);
				Obj.QuDao = (( dr["QuDao"])==DBNull.Value)?0:Convert.ToInt32( dr["QuDao"]);
			
			return Obj;
		}
		#endregion
		
		/// <summary>
		/// 根据ID,返回一个wx_Fenxiao对象
		/// </summary>
		/// <param name="id">id</param>
		/// <returns>wx_Fenxiao对象</returns>
		public wx_FenxiaoEntity Get_wx_FenxiaoEntity (int id)
		{
			wx_FenxiaoEntity _obj=null;
			SqlParameter[] _param={
			new SqlParameter("@Id",SqlDbType.Int)
			};
			_param[0].Value=id;
			string sqlStr="select * from wx_Fenxiao with(nolock) where Id=@Id";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.WfxRW, CommandType.Text, sqlStr, _param))
			{
				while(dr.Read())
				{
            		_obj=Populate_wx_FenxiaoEntity_FromDr(dr);
				}
			}
			return _obj;
		}
		/// <summary>
		/// 得到数据表wx_Fenxiao所有记录
		/// </summary>
		/// <returns>数据集</returns>
		public IList< wx_FenxiaoEntity> Get_wx_FenxiaoAll()
		{
			IList< wx_FenxiaoEntity> Obj=new List< wx_FenxiaoEntity>();
			string sqlStr="select * from wx_Fenxiao";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.WfxRW, CommandType.Text, sqlStr))
			{
				while(dr.Read())
				{
					Obj.Add(Populate_wx_FenxiaoEntity_FromDr(dr));
				}
			}
			return Obj;
		}
		/// <summary>
        /// 检测是否存在根据主键
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>是/否</returns>
		public bool IsExistwx_Fenxiao(int id)
		{
			SqlParameter[] _param={
                                      new SqlParameter("@id",SqlDbType.Int)
                                  };
            _param[0].Value=id;
            string sqlStr="select Count(*) from wx_Fenxiao where Id=@id";
            int a = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.WfxRW, CommandType.Text, sqlStr, _param));
            if(a>0)
            {
                return true;
            }
            else
            {
                return false;
            }
		}

        #endregion
		
		#region----------自定义实例化接口函数----------
		#endregion
    }
}
