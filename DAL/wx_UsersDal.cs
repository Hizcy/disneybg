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
using Jnwf.Utils.Data;
using Weifenxiao.Entity;



namespace Weifenxiao.DAL
{
    /// <summary>
    /// 数据层实例化接口类 dbo.wx_Users.
    /// </summary>
    public partial class wx_UsersDataAccessLayer 
    {
		#region 构造函数


		/// <summary>
		/// 
		/// </summary>
		public wx_UsersDataAccessLayer()
		{
		}
		#endregion

        #region -----------实例化接口函数-----------
		
		#region 添加更新删除
		/// <summary>
		/// 向数据库中插入一条新记录。
		/// </summary>
		/// <param name="_wx_UsersModel">wx_Users实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(wx_UsersEntity _wx_UsersModel)
		{
			string sqlStr="insert into wx_Users([RealName],[Phone],[Weixin],[Description],[OpenId],[ShopId],[RoleId],[Status],[Address],[Points],[Wallet],[AddTime],[UpdateTime],[ParentId]) values(@RealName,@Phone,@Weixin,@Description,@OpenId,@ShopId,@RoleId,@Status,@Address,@Points,@Wallet,@AddTime,@UpdateTime,@ParentId) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@RealName",SqlDbType.VarChar),
			new SqlParameter("@Phone",SqlDbType.VarChar),
			new SqlParameter("@Weixin",SqlDbType.VarChar),
			new SqlParameter("@Description",SqlDbType.VarChar),
			new SqlParameter("@OpenId",SqlDbType.VarChar),
			new SqlParameter("@ShopId",SqlDbType.Int),
			new SqlParameter("@RoleId",SqlDbType.Int),
			new SqlParameter("@Status",SqlDbType.Int),
			new SqlParameter("@Address",SqlDbType.VarChar),
			new SqlParameter("@Points",SqlDbType.Int),
			new SqlParameter("@Wallet",SqlDbType.Decimal),
			new SqlParameter("@AddTime",SqlDbType.DateTime),
			new SqlParameter("@UpdateTime",SqlDbType.DateTime),
			new SqlParameter("@ParentId",SqlDbType.Int)
			};			
			_param[0].Value=_wx_UsersModel.RealName;
			_param[1].Value=_wx_UsersModel.Phone;
			_param[2].Value=_wx_UsersModel.Weixin;
			_param[3].Value=_wx_UsersModel.Description;
			_param[4].Value=_wx_UsersModel.OpenId;
			_param[5].Value=_wx_UsersModel.ShopId;
			_param[6].Value=_wx_UsersModel.RoleId;
			_param[7].Value=_wx_UsersModel.Status;
			_param[8].Value=_wx_UsersModel.Address;
			_param[9].Value=_wx_UsersModel.Points;
			_param[10].Value=_wx_UsersModel.Wallet;
			_param[11].Value=_wx_UsersModel.AddTime;
			_param[12].Value=_wx_UsersModel.UpdateTime;
			_param[13].Value=_wx_UsersModel.ParentId;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.WfxRW,CommandType.Text,sqlStr,_param));
			return res;
		}
		/// <summary>
		/// 向数据库中插入一条新记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_wx_UsersModel">wx_Users实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(SqlTransaction sp,wx_UsersEntity _wx_UsersModel)
		{
			string sqlStr="insert into wx_Users([RealName],[Phone],[Weixin],[Description],[OpenId],[ShopId],[RoleId],[Status],[Address],[Points],[Wallet],[AddTime],[UpdateTime],[ParentId]) values(@RealName,@Phone,@Weixin,@Description,@OpenId,@ShopId,@RoleId,@Status,@Address,@Points,@Wallet,@AddTime,@UpdateTime,@ParentId) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@RealName",SqlDbType.VarChar),
			new SqlParameter("@Phone",SqlDbType.VarChar),
			new SqlParameter("@Weixin",SqlDbType.VarChar),
			new SqlParameter("@Description",SqlDbType.VarChar),
			new SqlParameter("@OpenId",SqlDbType.VarChar),
			new SqlParameter("@ShopId",SqlDbType.Int),
			new SqlParameter("@RoleId",SqlDbType.Int),
			new SqlParameter("@Status",SqlDbType.Int),
			new SqlParameter("@Address",SqlDbType.VarChar),
			new SqlParameter("@Points",SqlDbType.Int),
			new SqlParameter("@Wallet",SqlDbType.Decimal),
			new SqlParameter("@AddTime",SqlDbType.DateTime),
			new SqlParameter("@UpdateTime",SqlDbType.DateTime),
			new SqlParameter("@ParentId",SqlDbType.Int)
			};			
			_param[0].Value=_wx_UsersModel.RealName;
			_param[1].Value=_wx_UsersModel.Phone;
			_param[2].Value=_wx_UsersModel.Weixin;
			_param[3].Value=_wx_UsersModel.Description;
			_param[4].Value=_wx_UsersModel.OpenId;
			_param[5].Value=_wx_UsersModel.ShopId;
			_param[6].Value=_wx_UsersModel.RoleId;
			_param[7].Value=_wx_UsersModel.Status;
			_param[8].Value=_wx_UsersModel.Address;
			_param[9].Value=_wx_UsersModel.Points;
			_param[10].Value=_wx_UsersModel.Wallet;
			_param[11].Value=_wx_UsersModel.AddTime;
			_param[12].Value=_wx_UsersModel.UpdateTime;
			_param[13].Value=_wx_UsersModel.ParentId;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(sp,CommandType.Text,sqlStr,_param));
			return res;
		}


		/// <summary>
		/// 向数据表wx_Users更新一条记录。
		/// </summary>
		/// <param name="_wx_UsersModel">_wx_UsersModel</param>
		/// <returns>影响的行数</returns>
		public int Update(wx_UsersEntity _wx_UsersModel)
		{
            string sqlStr="update wx_Users set [RealName]=@RealName,[Phone]=@Phone,[Weixin]=@Weixin,[Description]=@Description,[OpenId]=@OpenId,[ShopId]=@ShopId,[RoleId]=@RoleId,[Status]=@Status,[Address]=@Address,[Points]=@Points,[Wallet]=@Wallet,[AddTime]=@AddTime,[UpdateTime]=@UpdateTime,[ParentId]=@ParentId where UserId=@UserId";
			SqlParameter[] _param={				
				new SqlParameter("@UserId",SqlDbType.Int),
				new SqlParameter("@RealName",SqlDbType.VarChar),
				new SqlParameter("@Phone",SqlDbType.VarChar),
				new SqlParameter("@Weixin",SqlDbType.VarChar),
				new SqlParameter("@Description",SqlDbType.VarChar),
				new SqlParameter("@OpenId",SqlDbType.VarChar),
				new SqlParameter("@ShopId",SqlDbType.Int),
				new SqlParameter("@RoleId",SqlDbType.Int),
				new SqlParameter("@Status",SqlDbType.Int),
				new SqlParameter("@Address",SqlDbType.VarChar),
				new SqlParameter("@Points",SqlDbType.Int),
				new SqlParameter("@Wallet",SqlDbType.Decimal),
				new SqlParameter("@AddTime",SqlDbType.DateTime),
				new SqlParameter("@UpdateTime",SqlDbType.DateTime),
				new SqlParameter("@ParentId",SqlDbType.Int)
				};				
				_param[0].Value=_wx_UsersModel.UserId;
				_param[1].Value=_wx_UsersModel.RealName;
				_param[2].Value=_wx_UsersModel.Phone;
				_param[3].Value=_wx_UsersModel.Weixin;
				_param[4].Value=_wx_UsersModel.Description;
				_param[5].Value=_wx_UsersModel.OpenId;
				_param[6].Value=_wx_UsersModel.ShopId;
				_param[7].Value=_wx_UsersModel.RoleId;
				_param[8].Value=_wx_UsersModel.Status;
				_param[9].Value=_wx_UsersModel.Address;
				_param[10].Value=_wx_UsersModel.Points;
				_param[11].Value=_wx_UsersModel.Wallet;
				_param[12].Value=_wx_UsersModel.AddTime;
				_param[13].Value=_wx_UsersModel.UpdateTime;
				_param[14].Value=_wx_UsersModel.ParentId;
			return SqlHelper.ExecuteNonQuery(WebConfig.WfxRW,CommandType.Text,sqlStr,_param);
		}
		/// <summary>
		/// 向数据表wx_Users更新一条记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_wx_UsersModel">_wx_UsersModel</param>
		/// <returns>影响的行数</returns>
		public int Update(SqlTransaction sp,wx_UsersEntity _wx_UsersModel)
		{
            string sqlStr="update wx_Users set [RealName]=@RealName,[Phone]=@Phone,[Weixin]=@Weixin,[Description]=@Description,[OpenId]=@OpenId,[ShopId]=@ShopId,[RoleId]=@RoleId,[Status]=@Status,[Address]=@Address,[Points]=@Points,[Wallet]=@Wallet,[AddTime]=@AddTime,[UpdateTime]=@UpdateTime,[ParentId]=@ParentId where UserId=@UserId";
			SqlParameter[] _param={				
				new SqlParameter("@UserId",SqlDbType.Int),
				new SqlParameter("@RealName",SqlDbType.VarChar),
				new SqlParameter("@Phone",SqlDbType.VarChar),
				new SqlParameter("@Weixin",SqlDbType.VarChar),
				new SqlParameter("@Description",SqlDbType.VarChar),
				new SqlParameter("@OpenId",SqlDbType.VarChar),
				new SqlParameter("@ShopId",SqlDbType.Int),
				new SqlParameter("@RoleId",SqlDbType.Int),
				new SqlParameter("@Status",SqlDbType.Int),
				new SqlParameter("@Address",SqlDbType.VarChar),
				new SqlParameter("@Points",SqlDbType.Int),
				new SqlParameter("@Wallet",SqlDbType.Decimal),
				new SqlParameter("@AddTime",SqlDbType.DateTime),
				new SqlParameter("@UpdateTime",SqlDbType.DateTime),
				new SqlParameter("@ParentId",SqlDbType.Int)
				};				
				_param[0].Value=_wx_UsersModel.UserId;
				_param[1].Value=_wx_UsersModel.RealName;
				_param[2].Value=_wx_UsersModel.Phone;
				_param[3].Value=_wx_UsersModel.Weixin;
				_param[4].Value=_wx_UsersModel.Description;
				_param[5].Value=_wx_UsersModel.OpenId;
				_param[6].Value=_wx_UsersModel.ShopId;
				_param[7].Value=_wx_UsersModel.RoleId;
				_param[8].Value=_wx_UsersModel.Status;
				_param[9].Value=_wx_UsersModel.Address;
				_param[10].Value=_wx_UsersModel.Points;
				_param[11].Value=_wx_UsersModel.Wallet;
				_param[12].Value=_wx_UsersModel.AddTime;
				_param[13].Value=_wx_UsersModel.UpdateTime;
				_param[14].Value=_wx_UsersModel.ParentId;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}		
		
		
		/// <summary>
		/// 删除数据表wx_Users中的一条记录
		/// </summary>
	    /// <param name="UserId">userId</param>
		/// <returns>影响的行数</returns>
		public int Delete(int UserId)
		{
			string sqlStr="delete from wx_Users where [UserId]=@UserId";
			SqlParameter[] _param={			
			new SqlParameter("@UserId",SqlDbType.Int),
			
			};			
			_param[0].Value=UserId;
			return SqlHelper.ExecuteNonQuery(WebConfig.WfxRW,CommandType.Text,sqlStr,_param);
		}
		
		/// <summary>
		/// 删除数据表wx_Users中的一条记录,带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
	    /// <param name="UserId">userId</param>
		/// <returns>影响的行数</returns>
		public int Delete(SqlTransaction sp,int UserId)
		{
			string sqlStr="delete from wx_Users where [UserId]=@UserId";
			SqlParameter[] _param={			
			new SqlParameter("@UserId",SqlDbType.Int),
			
			};			
			_param[0].Value=UserId;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}
		#endregion
		
		#region 数据实体
		/// <summary>
		/// 得到  wx_users 数据实体
		/// </summary>
		/// <param name="row">row</param>
		/// <returns>wx_users 数据实体</returns>
		public wx_UsersEntity Populate_wx_UsersEntity_FromDr(DataRow row)
		{
			wx_UsersEntity Obj = new wx_UsersEntity();
			if(row!=null)
			{
				Obj.UserId = (( row["UserId"])==DBNull.Value)?0:Convert.ToInt32( row["UserId"]);
				Obj.RealName =  row["RealName"].ToString();
				Obj.Phone =  row["Phone"].ToString();
				Obj.Weixin =  row["Weixin"].ToString();
				Obj.Description =  row["Description"].ToString();
				Obj.OpenId =  row["OpenId"].ToString();
				Obj.ShopId = (( row["ShopId"])==DBNull.Value)?0:Convert.ToInt32( row["ShopId"]);
				Obj.RoleId = (( row["RoleId"])==DBNull.Value)?0:Convert.ToInt32( row["RoleId"]);
				Obj.Status = (( row["Status"])==DBNull.Value)?0:Convert.ToInt32( row["Status"]);
				Obj.Address =  row["Address"].ToString();
				Obj.Points = (( row["Points"])==DBNull.Value)?0:Convert.ToInt32( row["Points"]);
				Obj.Wallet = (( row["Wallet"])==DBNull.Value)?0:Convert.ToDecimal( row["Wallet"]);
				Obj.AddTime = (( row["AddTime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( row["AddTime"]);
				Obj.UpdateTime = (( row["UpdateTime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( row["UpdateTime"]);
				Obj.ParentId = (( row["ParentId"])==DBNull.Value)?0:Convert.ToInt32( row["ParentId"]);
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
		public wx_UsersEntity Populate_wx_UsersEntity_FromDr(IDataReader dr)
		{
			wx_UsersEntity Obj = new wx_UsersEntity();
			
				Obj.UserId = (( dr["UserId"])==DBNull.Value)?0:Convert.ToInt32( dr["UserId"]);
				Obj.RealName =  dr["RealName"].ToString();
				Obj.Phone =  dr["Phone"].ToString();
				Obj.Weixin =  dr["Weixin"].ToString();
				Obj.Description =  dr["Description"].ToString();
				Obj.OpenId =  dr["OpenId"].ToString();
				Obj.ShopId = (( dr["ShopId"])==DBNull.Value)?0:Convert.ToInt32( dr["ShopId"]);
				Obj.RoleId = (( dr["RoleId"])==DBNull.Value)?0:Convert.ToInt32( dr["RoleId"]);
				Obj.Status = (( dr["Status"])==DBNull.Value)?0:Convert.ToInt32( dr["Status"]);
				Obj.Address =  dr["Address"].ToString();
				Obj.Points = (( dr["Points"])==DBNull.Value)?0:Convert.ToInt32( dr["Points"]);
				Obj.Wallet = (( dr["Wallet"])==DBNull.Value)?0:Convert.ToDecimal( dr["Wallet"]);
				Obj.AddTime = (( dr["AddTime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( dr["AddTime"]);
				Obj.UpdateTime = (( dr["UpdateTime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( dr["UpdateTime"]);
				Obj.ParentId = (( dr["ParentId"])==DBNull.Value)?0:Convert.ToInt32( dr["ParentId"]);
			
			return Obj;
		}
		#endregion
		
		/// <summary>
		/// 根据ID,返回一个wx_Users对象
		/// </summary>
		/// <param name="userId">userId</param>
		/// <returns>wx_Users对象</returns>
		public wx_UsersEntity Get_wx_UsersEntity (int userId)
		{
			wx_UsersEntity _obj=null;
			SqlParameter[] _param={
			new SqlParameter("@UserId",SqlDbType.Int)
			};
			_param[0].Value=userId;
			string sqlStr="select * from wx_Users with(nolock) where UserId=@UserId";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.WfxRW,CommandType.Text,sqlStr,_param))
			{
				while(dr.Read())
				{
            		_obj=Populate_wx_UsersEntity_FromDr(dr);
				}
			}
			return _obj;
		}
		/// <summary>
		/// 得到数据表wx_Users所有记录
		/// </summary>
		/// <returns>数据集</returns>
		public IList< wx_UsersEntity> Get_wx_UsersAll()
		{
			IList< wx_UsersEntity> Obj=new List< wx_UsersEntity>();
			string sqlStr="select * from wx_Users";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.WfxRW,CommandType.Text,sqlStr))
			{
				while(dr.Read())
				{
					Obj.Add(Populate_wx_UsersEntity_FromDr(dr));
				}
			}
			return Obj;
		}
		/// <summary>
        /// 检测是否存在根据主键
        /// </summary>
        /// <param name="userId">userId</param>
        /// <returns>是/否</returns>
		public bool IsExistwx_Users(int userId)
		{
			SqlParameter[] _param={
                                      new SqlParameter("@userId",SqlDbType.Int)
                                  };
            _param[0].Value=userId;
            string sqlStr="select Count(*) from wx_Users where UserId=@userId";
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
