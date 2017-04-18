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
using Jnwf.Utils.Data;
using Weifenxiao.Entity;



namespace Weifenxiao.DAL
{
    /// <summary>
    /// 数据层实例化接口类 dbo.wx_Shop_User.
    /// </summary>
    public partial class wx_Shop_UserDataAccessLayer 
    {
		#region 构造函数


		/// <summary>
		/// 
		/// </summary>
		public wx_Shop_UserDataAccessLayer()
		{
		}
		#endregion

        #region -----------实例化接口函数-----------
		
		#region 添加更新删除
		/// <summary>
		/// 向数据库中插入一条新记录。
		/// </summary>
		/// <param name="_wx_Shop_UserModel">wx_Shop_User实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(wx_Shop_UserEntity _wx_Shop_UserModel)
		{
			string sqlStr="insert into wx_Shop_User([ShopId],[UserId],[WeiXinCode]) values(@ShopId,@UserId,@WeiXinCode) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@ShopId",SqlDbType.Int),
			new SqlParameter("@UserId",SqlDbType.Int),
			new SqlParameter("@WeiXinCode",SqlDbType.VarChar)
			};			
			_param[0].Value=_wx_Shop_UserModel.ShopId;
			_param[1].Value=_wx_Shop_UserModel.UserId;
			_param[2].Value=_wx_Shop_UserModel.WeiXinCode;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.WfxRW,CommandType.Text,sqlStr,_param));
			return res;
		}
		/// <summary>
		/// 向数据库中插入一条新记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_wx_Shop_UserModel">wx_Shop_User实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(SqlTransaction sp,wx_Shop_UserEntity _wx_Shop_UserModel)
		{
			string sqlStr="insert into wx_Shop_User([ShopId],[UserId],[WeiXinCode]) values(@ShopId,@UserId,@WeiXinCode) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@ShopId",SqlDbType.Int),
			new SqlParameter("@UserId",SqlDbType.Int),
			new SqlParameter("@WeiXinCode",SqlDbType.VarChar)
			};			
			_param[0].Value=_wx_Shop_UserModel.ShopId;
			_param[1].Value=_wx_Shop_UserModel.UserId;
			_param[2].Value=_wx_Shop_UserModel.WeiXinCode;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(sp,CommandType.Text,sqlStr,_param));
			return res;
		}


		/// <summary>
		/// 向数据表wx_Shop_User更新一条记录。
		/// </summary>
		/// <param name="_wx_Shop_UserModel">_wx_Shop_UserModel</param>
		/// <returns>影响的行数</returns>
		public int Update(wx_Shop_UserEntity _wx_Shop_UserModel)
		{
            string sqlStr="update wx_Shop_User set [ShopId]=@ShopId,[UserId]=@UserId,[WeiXinCode]=@WeiXinCode where Id=@Id";
			SqlParameter[] _param={				
				new SqlParameter("@Id",SqlDbType.Int),
				new SqlParameter("@ShopId",SqlDbType.Int),
				new SqlParameter("@UserId",SqlDbType.Int),
				new SqlParameter("@WeiXinCode",SqlDbType.VarChar)
				};				
				_param[0].Value=_wx_Shop_UserModel.Id;
				_param[1].Value=_wx_Shop_UserModel.ShopId;
				_param[2].Value=_wx_Shop_UserModel.UserId;
				_param[3].Value=_wx_Shop_UserModel.WeiXinCode;
			return SqlHelper.ExecuteNonQuery(WebConfig.WfxRW,CommandType.Text,sqlStr,_param);
		}
		/// <summary>
		/// 向数据表wx_Shop_User更新一条记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_wx_Shop_UserModel">_wx_Shop_UserModel</param>
		/// <returns>影响的行数</returns>
		public int Update(SqlTransaction sp,wx_Shop_UserEntity _wx_Shop_UserModel)
		{
            string sqlStr="update wx_Shop_User set [ShopId]=@ShopId,[UserId]=@UserId,[WeiXinCode]=@WeiXinCode where Id=@Id";
			SqlParameter[] _param={				
				new SqlParameter("@Id",SqlDbType.Int),
				new SqlParameter("@ShopId",SqlDbType.Int),
				new SqlParameter("@UserId",SqlDbType.Int),
				new SqlParameter("@WeiXinCode",SqlDbType.VarChar)
				};				
				_param[0].Value=_wx_Shop_UserModel.Id;
				_param[1].Value=_wx_Shop_UserModel.ShopId;
				_param[2].Value=_wx_Shop_UserModel.UserId;
				_param[3].Value=_wx_Shop_UserModel.WeiXinCode;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}		
		
		
		/// <summary>
		/// 删除数据表wx_Shop_User中的一条记录
		/// </summary>
	    /// <param name="Id">id</param>
		/// <returns>影响的行数</returns>
		public int Delete(int Id)
		{
			string sqlStr="delete from wx_Shop_User where [Id]=@Id";
			SqlParameter[] _param={			
			new SqlParameter("@Id",SqlDbType.Int),
			
			};			
			_param[0].Value=Id;
			return SqlHelper.ExecuteNonQuery(WebConfig.WfxRW,CommandType.Text,sqlStr,_param);
		}
		
		/// <summary>
		/// 删除数据表wx_Shop_User中的一条记录,带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
	    /// <param name="Id">id</param>
		/// <returns>影响的行数</returns>
		public int Delete(SqlTransaction sp,int Id)
		{
			string sqlStr="delete from wx_Shop_User where [Id]=@Id";
			SqlParameter[] _param={			
			new SqlParameter("@Id",SqlDbType.Int),
			
			};			
			_param[0].Value=Id;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}
		#endregion
		
		#region 数据实体
		/// <summary>
		/// 得到  wx_shop_user 数据实体
		/// </summary>
		/// <param name="row">row</param>
		/// <returns>wx_shop_user 数据实体</returns>
		public wx_Shop_UserEntity Populate_wx_Shop_UserEntity_FromDr(DataRow row)
		{
			wx_Shop_UserEntity Obj = new wx_Shop_UserEntity();
			if(row!=null)
			{
				Obj.Id = (( row["Id"])==DBNull.Value)?0:Convert.ToInt32( row["Id"]);
				Obj.ShopId = (( row["ShopId"])==DBNull.Value)?0:Convert.ToInt32( row["ShopId"]);
				Obj.UserId = (( row["UserId"])==DBNull.Value)?0:Convert.ToInt32( row["UserId"]);
				Obj.WeiXinCode =  row["WeiXinCode"].ToString();
			}
			else
			{
				return null;
			}
			return Obj;
		}
		
        /// <summary>
		/// 得到  wx_shop_user 数据实体
		/// </summary>
		/// <param name="dr">dr</param>
		/// <returns>wx_shop_user 数据实体</returns>
		public wx_Shop_UserEntity Populate_wx_Shop_UserEntity_FromDr(IDataReader dr)
		{
			wx_Shop_UserEntity Obj = new wx_Shop_UserEntity();
			
				Obj.Id = (( dr["Id"])==DBNull.Value)?0:Convert.ToInt32( dr["Id"]);
				Obj.ShopId = (( dr["ShopId"])==DBNull.Value)?0:Convert.ToInt32( dr["ShopId"]);
				Obj.UserId = (( dr["UserId"])==DBNull.Value)?0:Convert.ToInt32( dr["UserId"]);
				Obj.WeiXinCode =  dr["WeiXinCode"].ToString();
			
			return Obj;
		}
		#endregion
		
		/// <summary>
		/// 根据ID,返回一个wx_Shop_User对象
		/// </summary>
		/// <param name="id">id</param>
		/// <returns>wx_Shop_User对象</returns>
		public wx_Shop_UserEntity Get_wx_Shop_UserEntity (int id)
		{
			wx_Shop_UserEntity _obj=null;
			SqlParameter[] _param={
			new SqlParameter("@Id",SqlDbType.Int)
			};
			_param[0].Value=id;
			string sqlStr="select * from wx_Shop_User with(nolock) where Id=@Id";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.WfxRW,CommandType.Text,sqlStr,_param))
			{
				while(dr.Read())
				{
            		_obj=Populate_wx_Shop_UserEntity_FromDr(dr);
				}
			}
			return _obj;
		}
		/// <summary>
		/// 得到数据表wx_Shop_User所有记录
		/// </summary>
		/// <returns>数据集</returns>
		public IList< wx_Shop_UserEntity> Get_wx_Shop_UserAll()
		{
			IList< wx_Shop_UserEntity> Obj=new List< wx_Shop_UserEntity>();
			string sqlStr="select * from wx_Shop_User";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.WfxRW,CommandType.Text,sqlStr))
			{
				while(dr.Read())
				{
					Obj.Add(Populate_wx_Shop_UserEntity_FromDr(dr));
				}
			}
			return Obj;
		}
		/// <summary>
        /// 检测是否存在根据主键
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>是/否</returns>
		public bool IsExistwx_Shop_User(int id)
		{
			SqlParameter[] _param={
                                      new SqlParameter("@id",SqlDbType.Int)
                                  };
            _param[0].Value=id;
            string sqlStr="select Count(*) from wx_Shop_User where Id=@id";
            int a=Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.WfxRW,CommandType.Text,sqlStr,_param));
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
