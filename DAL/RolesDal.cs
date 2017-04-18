// =================================================================== 
// 项目说明
//====================================================================
// yangxg。@Copy Right 2014
// 文件： Roles.cs
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
    /// 数据层实例化接口类 dbo.Roles.
    /// </summary>
    public partial class RolesDataAccessLayer 
    {
		#region 构造函数


		/// <summary>
		/// 
		/// </summary>
		public RolesDataAccessLayer()
		{
		}
		#endregion

        #region -----------实例化接口函数-----------
		
		#region 添加更新删除
		/// <summary>
		/// 向数据库中插入一条新记录。
		/// </summary>
		/// <param name="_RolesModel">Roles实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(RolesEntity _RolesModel)
		{
			string sqlStr="insert into Roles([RoleId],[ShopId],[Name],[Permission],[price],[Description]) values(@RoleId,@ShopId,@Name,@Permission,@price,@Description) select @RoleId";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@RoleId",SqlDbType.Int),
			new SqlParameter("@ShopId",SqlDbType.Int),
			new SqlParameter("@Name",SqlDbType.VarChar),
			new SqlParameter("@Permission",SqlDbType.Int),
			new SqlParameter("@price",SqlDbType.Decimal),
			new SqlParameter("@Description",SqlDbType.VarChar)
			};			
			_param[0].Value=_RolesModel.RoleId;
			_param[1].Value=_RolesModel.ShopId;
			_param[2].Value=_RolesModel.Name;
			_param[3].Value=_RolesModel.Permission;
			_param[4].Value=_RolesModel.price;
			_param[5].Value=_RolesModel.Description;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.WfxRW,CommandType.Text,sqlStr,_param));
			return res;
		}
		/// <summary>
		/// 向数据库中插入一条新记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_RolesModel">Roles实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(SqlTransaction sp,RolesEntity _RolesModel)
		{
			string sqlStr="insert into Roles([RoleId],[ShopId],[Name],[Permission],[price],[Description]) values(@RoleId,@ShopId,@Name,@Permission,@price,@Description) select @RoleId";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@RoleId",SqlDbType.Int),
			new SqlParameter("@ShopId",SqlDbType.Int),
			new SqlParameter("@Name",SqlDbType.VarChar),
			new SqlParameter("@Permission",SqlDbType.Int),
			new SqlParameter("@price",SqlDbType.Decimal),
			new SqlParameter("@Description",SqlDbType.VarChar)
			};			
			_param[0].Value=_RolesModel.RoleId;
			_param[1].Value=_RolesModel.ShopId;
			_param[2].Value=_RolesModel.Name;
			_param[3].Value=_RolesModel.Permission;
			_param[4].Value=_RolesModel.price;
			_param[5].Value=_RolesModel.Description;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(sp,CommandType.Text,sqlStr,_param));
			return res;
		}


		/// <summary>
		/// 向数据表Roles更新一条记录。
		/// </summary>
		/// <param name="_RolesModel">_RolesModel</param>
		/// <returns>影响的行数</returns>
		public int Update(RolesEntity _RolesModel)
		{
            string sqlStr="update Roles set [ShopId]=@ShopId,[Name]=@Name,[Permission]=@Permission,[price]=@price,[Description]=@Description where RoleId=@RoleId";
			SqlParameter[] _param={				
				new SqlParameter("@RoleId",SqlDbType.Int),
				new SqlParameter("@ShopId",SqlDbType.Int),
				new SqlParameter("@Name",SqlDbType.VarChar),
				new SqlParameter("@Permission",SqlDbType.Int),
				new SqlParameter("@price",SqlDbType.Decimal),
				new SqlParameter("@Description",SqlDbType.VarChar)
				};				
				_param[0].Value=_RolesModel.RoleId;
				_param[1].Value=_RolesModel.ShopId;
				_param[2].Value=_RolesModel.Name;
				_param[3].Value=_RolesModel.Permission;
				_param[4].Value=_RolesModel.price;
				_param[5].Value=_RolesModel.Description;
			return SqlHelper.ExecuteNonQuery(WebConfig.WfxRW,CommandType.Text,sqlStr,_param);
		}
		/// <summary>
		/// 向数据表Roles更新一条记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_RolesModel">_RolesModel</param>
		/// <returns>影响的行数</returns>
		public int Update(SqlTransaction sp,RolesEntity _RolesModel)
		{
            string sqlStr="update Roles set [ShopId]=@ShopId,[Name]=@Name,[Permission]=@Permission,[price]=@price,[Description]=@Description where RoleId=@RoleId";
			SqlParameter[] _param={				
				new SqlParameter("@RoleId",SqlDbType.Int),
				new SqlParameter("@ShopId",SqlDbType.Int),
				new SqlParameter("@Name",SqlDbType.VarChar),
				new SqlParameter("@Permission",SqlDbType.Int),
				new SqlParameter("@price",SqlDbType.Decimal),
				new SqlParameter("@Description",SqlDbType.VarChar)
				};				
				_param[0].Value=_RolesModel.RoleId;
				_param[1].Value=_RolesModel.ShopId;
				_param[2].Value=_RolesModel.Name;
				_param[3].Value=_RolesModel.Permission;
				_param[4].Value=_RolesModel.price;
				_param[5].Value=_RolesModel.Description;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}		
		
		
		/// <summary>
		/// 删除数据表Roles中的一条记录
		/// </summary>
	    /// <param name="RoleId">roleId</param>
		/// <returns>影响的行数</returns>
		public int Delete(int RoleId)
		{
			string sqlStr="delete from Roles where [RoleId]=@RoleId";
			SqlParameter[] _param={			
			new SqlParameter("@RoleId",SqlDbType.Int),
			
			};			
			_param[0].Value=RoleId;
			return SqlHelper.ExecuteNonQuery(WebConfig.WfxRW,CommandType.Text,sqlStr,_param);
		}
		
		/// <summary>
		/// 删除数据表Roles中的一条记录,带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
	    /// <param name="RoleId">roleId</param>
		/// <returns>影响的行数</returns>
		public int Delete(SqlTransaction sp,int RoleId)
		{
			string sqlStr="delete from Roles where [RoleId]=@RoleId";
			SqlParameter[] _param={			
			new SqlParameter("@RoleId",SqlDbType.Int),
			
			};			
			_param[0].Value=RoleId;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}
		#endregion
		
		#region 数据实体
		/// <summary>
		/// 得到  roles 数据实体
		/// </summary>
		/// <param name="row">row</param>
		/// <returns>roles 数据实体</returns>
		public RolesEntity Populate_RolesEntity_FromDr(DataRow row)
		{
			RolesEntity Obj = new RolesEntity();
			if(row!=null)
			{
				Obj.RoleId = (( row["RoleId"])==DBNull.Value)?0:Convert.ToInt32( row["RoleId"]);
				Obj.ShopId = (( row["ShopId"])==DBNull.Value)?0:Convert.ToInt32( row["ShopId"]);
				Obj.Name =  row["Name"].ToString();
				Obj.Permission = (( row["Permission"])==DBNull.Value)?0:Convert.ToInt32( row["Permission"]);
				Obj.price = (( row["price"])==DBNull.Value)?0:Convert.ToDecimal( row["price"]);
				Obj.Description =  row["Description"].ToString();
			}
			else
			{
				return null;
			}
			return Obj;
		}
		
        /// <summary>
		/// 得到  roles 数据实体
		/// </summary>
		/// <param name="dr">dr</param>
		/// <returns>roles 数据实体</returns>
		public RolesEntity Populate_RolesEntity_FromDr(IDataReader dr)
		{
			RolesEntity Obj = new RolesEntity();
			
				Obj.RoleId = (( dr["RoleId"])==DBNull.Value)?0:Convert.ToInt32( dr["RoleId"]);
				Obj.ShopId = (( dr["ShopId"])==DBNull.Value)?0:Convert.ToInt32( dr["ShopId"]);
				Obj.Name =  dr["Name"].ToString();
				Obj.Permission = (( dr["Permission"])==DBNull.Value)?0:Convert.ToInt32( dr["Permission"]);
				Obj.price = (( dr["price"])==DBNull.Value)?0:Convert.ToDecimal( dr["price"]);
				Obj.Description =  dr["Description"].ToString();
			
			return Obj;
		}
		#endregion
		
		/// <summary>
		/// 根据ID,返回一个Roles对象
		/// </summary>
		/// <param name="roleId">roleId</param>
		/// <returns>Roles对象</returns>
		public RolesEntity Get_RolesEntity (int roleId)
		{
			RolesEntity _obj=null;
			SqlParameter[] _param={
			new SqlParameter("@RoleId",SqlDbType.Int)
			};
			_param[0].Value=roleId;
			string sqlStr="select * from Roles with(nolock) where RoleId=@RoleId";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.WfxRW,CommandType.Text,sqlStr,_param))
			{
				while(dr.Read())
				{
            		_obj=Populate_RolesEntity_FromDr(dr);
				}
			}
			return _obj;
		}
		/// <summary>
		/// 得到数据表Roles所有记录
		/// </summary>
		/// <returns>数据集</returns>
		public IList< RolesEntity> Get_RolesAll()
		{
			IList< RolesEntity> Obj=new List< RolesEntity>();
			string sqlStr="select * from Roles";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.WfxRW,CommandType.Text,sqlStr))
			{
				while(dr.Read())
				{
					Obj.Add(Populate_RolesEntity_FromDr(dr));
				}
			}
			return Obj;
		}
		/// <summary>
        /// 检测是否存在根据主键
        /// </summary>
        /// <param name="roleId">roleId</param>
        /// <returns>是/否</returns>
		public bool IsExistRoles(int roleId)
		{
			SqlParameter[] _param={
                                      new SqlParameter("@roleId",SqlDbType.Int)
                                  };
            _param[0].Value=roleId;
            string sqlStr="select Count(*) from Roles where RoleId=@roleId";
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
