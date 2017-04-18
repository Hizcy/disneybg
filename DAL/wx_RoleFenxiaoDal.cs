// =================================================================== 
// 项目说明
//====================================================================
// yangxg。@Copy Right 2014
// 文件： wx_RoleFenxiao.cs
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
    /// 数据层实例化接口类 dbo.wx_RoleFenxiao.
    /// </summary>
    public partial class wx_RoleFenxiaoDataAccessLayer 
    {
		#region 构造函数


		/// <summary>
		/// 
		/// </summary>
		public wx_RoleFenxiaoDataAccessLayer()
		{
		}
		#endregion

        #region -----------实例化接口函数-----------
		
		#region 添加更新删除
		/// <summary>
		/// 向数据库中插入一条新记录。
		/// </summary>
		/// <param name="_wx_RoleFenxiaoModel">wx_RoleFenxiao实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(wx_RoleFenxiaoEntity _wx_RoleFenxiaoModel)
		{
			string sqlStr="insert into wx_RoleFenxiao([ShopId],[RoleId],[Commission],[SetRoleId],[QuDao]) values(@ShopId,@RoleId,@Commission,@SetRoleId,@QuDao) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@ShopId",SqlDbType.Int),
			new SqlParameter("@RoleId",SqlDbType.Int),
			new SqlParameter("@Commission",SqlDbType.Decimal),
			new SqlParameter("@SetRoleId",SqlDbType.Int),
			new SqlParameter("@QuDao",SqlDbType.Decimal)
			};			
			_param[0].Value=_wx_RoleFenxiaoModel.ShopId;
			_param[1].Value=_wx_RoleFenxiaoModel.RoleId;
			_param[2].Value=_wx_RoleFenxiaoModel.Commission;
			_param[3].Value=_wx_RoleFenxiaoModel.SetRoleId;
			_param[4].Value=_wx_RoleFenxiaoModel.QuDao;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.WfxRW,CommandType.Text,sqlStr,_param));
			return res;
		}
		/// <summary>
		/// 向数据库中插入一条新记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_wx_RoleFenxiaoModel">wx_RoleFenxiao实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(SqlTransaction sp,wx_RoleFenxiaoEntity _wx_RoleFenxiaoModel)
		{
			string sqlStr="insert into wx_RoleFenxiao([ShopId],[RoleId],[Commission],[SetRoleId],[QuDao]) values(@ShopId,@RoleId,@Commission,@SetRoleId,@QuDao) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@ShopId",SqlDbType.Int),
			new SqlParameter("@RoleId",SqlDbType.Int),
			new SqlParameter("@Commission",SqlDbType.Decimal),
			new SqlParameter("@SetRoleId",SqlDbType.Int),
			new SqlParameter("@QuDao",SqlDbType.Decimal)
			};			
			_param[0].Value=_wx_RoleFenxiaoModel.ShopId;
			_param[1].Value=_wx_RoleFenxiaoModel.RoleId;
			_param[2].Value=_wx_RoleFenxiaoModel.Commission;
			_param[3].Value=_wx_RoleFenxiaoModel.SetRoleId;
			_param[4].Value=_wx_RoleFenxiaoModel.QuDao;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(sp,CommandType.Text,sqlStr,_param));
			return res;
		}


		/// <summary>
		/// 向数据表wx_RoleFenxiao更新一条记录。
		/// </summary>
		/// <param name="_wx_RoleFenxiaoModel">_wx_RoleFenxiaoModel</param>
		/// <returns>影响的行数</returns>
		public int Update(wx_RoleFenxiaoEntity _wx_RoleFenxiaoModel)
		{
            string sqlStr="update wx_RoleFenxiao set [ShopId]=@ShopId,[RoleId]=@RoleId,[Commission]=@Commission,[SetRoleId]=@SetRoleId,[QuDao]=@QuDao where Id=@Id";
			SqlParameter[] _param={				
				new SqlParameter("@Id",SqlDbType.Int),
				new SqlParameter("@ShopId",SqlDbType.Int),
				new SqlParameter("@RoleId",SqlDbType.Int),
				new SqlParameter("@Commission",SqlDbType.Decimal),
				new SqlParameter("@SetRoleId",SqlDbType.Int),
				new SqlParameter("@QuDao",SqlDbType.Decimal)
				};				
				_param[0].Value=_wx_RoleFenxiaoModel.Id;
				_param[1].Value=_wx_RoleFenxiaoModel.ShopId;
				_param[2].Value=_wx_RoleFenxiaoModel.RoleId;
				_param[3].Value=_wx_RoleFenxiaoModel.Commission;
				_param[4].Value=_wx_RoleFenxiaoModel.SetRoleId;
				_param[5].Value=_wx_RoleFenxiaoModel.QuDao;
                return SqlHelper.ExecuteNonQuery(WebConfig.WfxRW, CommandType.Text, sqlStr, _param);
		}
		/// <summary>
		/// 向数据表wx_RoleFenxiao更新一条记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_wx_RoleFenxiaoModel">_wx_RoleFenxiaoModel</param>
		/// <returns>影响的行数</returns>
		public int Update(SqlTransaction sp,wx_RoleFenxiaoEntity _wx_RoleFenxiaoModel)
		{
            string sqlStr="update wx_RoleFenxiao set [ShopId]=@ShopId,[RoleId]=@RoleId,[Commission]=@Commission,[SetRoleId]=@SetRoleId,[QuDao]=@QuDao where Id=@Id";
			SqlParameter[] _param={				
				new SqlParameter("@Id",SqlDbType.Int),
				new SqlParameter("@ShopId",SqlDbType.Int),
				new SqlParameter("@RoleId",SqlDbType.Int),
				new SqlParameter("@Commission",SqlDbType.Decimal),
				new SqlParameter("@SetRoleId",SqlDbType.Int),
				new SqlParameter("@QuDao",SqlDbType.Decimal)
				};				
				_param[0].Value=_wx_RoleFenxiaoModel.Id;
				_param[1].Value=_wx_RoleFenxiaoModel.ShopId;
				_param[2].Value=_wx_RoleFenxiaoModel.RoleId;
				_param[3].Value=_wx_RoleFenxiaoModel.Commission;
				_param[4].Value=_wx_RoleFenxiaoModel.SetRoleId;
				_param[5].Value=_wx_RoleFenxiaoModel.QuDao;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}		
		
		
		/// <summary>
		/// 删除数据表wx_RoleFenxiao中的一条记录
		/// </summary>
	    /// <param name="Id">id</param>
		/// <returns>影响的行数</returns>
		public int Delete(int Id)
		{
			string sqlStr="delete from wx_RoleFenxiao where [Id]=@Id";
			SqlParameter[] _param={			
			new SqlParameter("@Id",SqlDbType.Int),
			
			};			
			_param[0].Value=Id;
            return SqlHelper.ExecuteNonQuery(WebConfig.WfxRW, CommandType.Text, sqlStr, _param);
		}
		
		/// <summary>
		/// 删除数据表wx_RoleFenxiao中的一条记录,带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
	    /// <param name="Id">id</param>
		/// <returns>影响的行数</returns>
		public int Delete(SqlTransaction sp,int Id)
		{
			string sqlStr="delete from wx_RoleFenxiao where [Id]=@Id";
			SqlParameter[] _param={			
			new SqlParameter("@Id",SqlDbType.Int),
			
			};			
			_param[0].Value=Id;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}
		#endregion
		
		#region 数据实体
		/// <summary>
		/// 得到  wx_rolefenxiao 数据实体
		/// </summary>
		/// <param name="row">row</param>
		/// <returns>wx_rolefenxiao 数据实体</returns>
		public wx_RoleFenxiaoEntity Populate_wx_RoleFenxiaoEntity_FromDr(DataRow row)
		{
			wx_RoleFenxiaoEntity Obj = new wx_RoleFenxiaoEntity();
			if(row!=null)
			{
				Obj.Id = (( row["Id"])==DBNull.Value)?0:Convert.ToInt32( row["Id"]);
				Obj.ShopId = (( row["ShopId"])==DBNull.Value)?0:Convert.ToInt32( row["ShopId"]);
				Obj.RoleId = (( row["RoleId"])==DBNull.Value)?0:Convert.ToInt32( row["RoleId"]);
				Obj.Commission = (( row["Commission"])==DBNull.Value)?0:Convert.ToDecimal( row["Commission"]);
				Obj.SetRoleId = (( row["SetRoleId"])==DBNull.Value)?0:Convert.ToInt32( row["SetRoleId"]);
				Obj.QuDao = (( row["QuDao"])==DBNull.Value)?0:Convert.ToDecimal( row["QuDao"]);
			}
			else
			{
				return null;
			}
			return Obj;
		}
		
        /// <summary>
		/// 得到  wx_rolefenxiao 数据实体
		/// </summary>
		/// <param name="dr">dr</param>
		/// <returns>wx_rolefenxiao 数据实体</returns>
		public wx_RoleFenxiaoEntity Populate_wx_RoleFenxiaoEntity_FromDr(IDataReader dr)
		{
			wx_RoleFenxiaoEntity Obj = new wx_RoleFenxiaoEntity();
			
				Obj.Id = (( dr["Id"])==DBNull.Value)?0:Convert.ToInt32( dr["Id"]);
				Obj.ShopId = (( dr["ShopId"])==DBNull.Value)?0:Convert.ToInt32( dr["ShopId"]);
				Obj.RoleId = (( dr["RoleId"])==DBNull.Value)?0:Convert.ToInt32( dr["RoleId"]);
				Obj.Commission = (( dr["Commission"])==DBNull.Value)?0:Convert.ToDecimal( dr["Commission"]);
				Obj.SetRoleId = (( dr["SetRoleId"])==DBNull.Value)?0:Convert.ToInt32( dr["SetRoleId"]);
				Obj.QuDao = (( dr["QuDao"])==DBNull.Value)?0:Convert.ToDecimal( dr["QuDao"]);
			
			return Obj;
		}
		#endregion
		
		/// <summary>
		/// 根据ID,返回一个wx_RoleFenxiao对象
		/// </summary>
		/// <param name="id">id</param>
		/// <returns>wx_RoleFenxiao对象</returns>
		public wx_RoleFenxiaoEntity Get_wx_RoleFenxiaoEntity (int id)
		{
			wx_RoleFenxiaoEntity _obj=null;
			SqlParameter[] _param={
			new SqlParameter("@Id",SqlDbType.Int)
			};
			_param[0].Value=id;
			string sqlStr="select * from wx_RoleFenxiao with(nolock) where Id=@Id";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.WfxRW, CommandType.Text, sqlStr, _param))
			{
				while(dr.Read())
				{
            		_obj=Populate_wx_RoleFenxiaoEntity_FromDr(dr);
				}
			}
			return _obj;
		}
		/// <summary>
		/// 得到数据表wx_RoleFenxiao所有记录
		/// </summary>
		/// <returns>数据集</returns>
		public IList< wx_RoleFenxiaoEntity> Get_wx_RoleFenxiaoAll()
		{
			IList< wx_RoleFenxiaoEntity> Obj=new List< wx_RoleFenxiaoEntity>();
			string sqlStr="select * from wx_RoleFenxiao";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.WfxRW, CommandType.Text, sqlStr))
			{
				while(dr.Read())
				{
					Obj.Add(Populate_wx_RoleFenxiaoEntity_FromDr(dr));
				}
			}
			return Obj;
		}
		/// <summary>
        /// 检测是否存在根据主键
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>是/否</returns>
		public bool IsExistwx_RoleFenxiao(int id)
		{
			SqlParameter[] _param={
                                      new SqlParameter("@id",SqlDbType.Int)
                                  };
            _param[0].Value=id;
            string sqlStr="select Count(*) from wx_RoleFenxiao where Id=@id";
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
