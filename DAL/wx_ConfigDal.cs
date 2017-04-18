// =================================================================== 
// 项目说明
//====================================================================
// yangxg。@Copy Right 2014
// 文件： wx_Config.cs
// 项目名称：买车网
// 创建时间：2016/6/23
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
    /// 数据层实例化接口类 dbo.wx_Config.
    /// </summary>
    public partial class wx_ConfigDataAccessLayer 
    {
		#region 构造函数


		/// <summary>
		/// 
		/// </summary>
		public wx_ConfigDataAccessLayer()
		{
		}
		#endregion

        #region -----------实例化接口函数-----------
		
		#region 添加更新删除
		/// <summary>
		/// 向数据库中插入一条新记录。
		/// </summary>
		/// <param name="_wx_ConfigModel">wx_Config实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(wx_ConfigEntity _wx_ConfigModel)
		{
			string sqlStr="insert into wx_Config([Name],[PropertyId],[PropertyKey],[PropertyValue],[Status],[Addtime],[Uptatetime]) values(@Name,@PropertyId,@PropertyKey,@PropertyValue,@Status,@Addtime,@Uptatetime) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@Name",SqlDbType.VarChar),
			new SqlParameter("@PropertyId",SqlDbType.Int),
			new SqlParameter("@PropertyKey",SqlDbType.VarChar),
			new SqlParameter("@PropertyValue",SqlDbType.VarChar),
			new SqlParameter("@Status",SqlDbType.Int),
			new SqlParameter("@Addtime",SqlDbType.DateTime),
			new SqlParameter("@Uptatetime",SqlDbType.DateTime)
			};			
			_param[0].Value=_wx_ConfigModel.Name;
			_param[1].Value=_wx_ConfigModel.PropertyId;
			_param[2].Value=_wx_ConfigModel.PropertyKey;
			_param[3].Value=_wx_ConfigModel.PropertyValue;
			_param[4].Value=_wx_ConfigModel.Status;
			_param[5].Value=_wx_ConfigModel.Addtime;
			_param[6].Value=_wx_ConfigModel.Uptatetime;
            res = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.WfxRW, CommandType.Text, sqlStr, _param));
			return res;
		}
		/// <summary>
		/// 向数据库中插入一条新记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_wx_ConfigModel">wx_Config实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(SqlTransaction sp,wx_ConfigEntity _wx_ConfigModel)
		{
			string sqlStr="insert into wx_Config([Name],[PropertyId],[PropertyKey],[PropertyValue],[Status],[Addtime],[Uptatetime]) values(@Name,@PropertyId,@PropertyKey,@PropertyValue,@Status,@Addtime,@Uptatetime) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@Name",SqlDbType.VarChar),
			new SqlParameter("@PropertyId",SqlDbType.Int),
			new SqlParameter("@PropertyKey",SqlDbType.VarChar),
			new SqlParameter("@PropertyValue",SqlDbType.VarChar),
			new SqlParameter("@Status",SqlDbType.Int),
			new SqlParameter("@Addtime",SqlDbType.DateTime),
			new SqlParameter("@Uptatetime",SqlDbType.DateTime)
			};			
			_param[0].Value=_wx_ConfigModel.Name;
			_param[1].Value=_wx_ConfigModel.PropertyId;
			_param[2].Value=_wx_ConfigModel.PropertyKey;
			_param[3].Value=_wx_ConfigModel.PropertyValue;
			_param[4].Value=_wx_ConfigModel.Status;
			_param[5].Value=_wx_ConfigModel.Addtime;
			_param[6].Value=_wx_ConfigModel.Uptatetime;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(sp,CommandType.Text,sqlStr,_param));
			return res;
		}


		/// <summary>
		/// 向数据表wx_Config更新一条记录。
		/// </summary>
		/// <param name="_wx_ConfigModel">_wx_ConfigModel</param>
		/// <returns>影响的行数</returns>
		public int Update(wx_ConfigEntity _wx_ConfigModel)
		{
            string sqlStr="update wx_Config set [Name]=@Name,[PropertyId]=@PropertyId,[PropertyKey]=@PropertyKey,[PropertyValue]=@PropertyValue,[Status]=@Status,[Addtime]=@Addtime,[Uptatetime]=@Uptatetime where Id=@Id";
			SqlParameter[] _param={				
				new SqlParameter("@Id",SqlDbType.Int),
				new SqlParameter("@Name",SqlDbType.VarChar),
				new SqlParameter("@PropertyId",SqlDbType.Int),
				new SqlParameter("@PropertyKey",SqlDbType.VarChar),
				new SqlParameter("@PropertyValue",SqlDbType.VarChar),
				new SqlParameter("@Status",SqlDbType.Int),
				new SqlParameter("@Addtime",SqlDbType.DateTime),
				new SqlParameter("@Uptatetime",SqlDbType.DateTime)
				};				
				_param[0].Value=_wx_ConfigModel.Id;
				_param[1].Value=_wx_ConfigModel.Name;
				_param[2].Value=_wx_ConfigModel.PropertyId;
				_param[3].Value=_wx_ConfigModel.PropertyKey;
				_param[4].Value=_wx_ConfigModel.PropertyValue;
				_param[5].Value=_wx_ConfigModel.Status;
				_param[6].Value=_wx_ConfigModel.Addtime;
				_param[7].Value=_wx_ConfigModel.Uptatetime;
                return SqlHelper.ExecuteNonQuery(WebConfig.WfxRW, CommandType.Text, sqlStr, _param);
		}
		/// <summary>
		/// 向数据表wx_Config更新一条记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_wx_ConfigModel">_wx_ConfigModel</param>
		/// <returns>影响的行数</returns>
		public int Update(SqlTransaction sp,wx_ConfigEntity _wx_ConfigModel)
		{
            string sqlStr="update wx_Config set [Name]=@Name,[PropertyId]=@PropertyId,[PropertyKey]=@PropertyKey,[PropertyValue]=@PropertyValue,[Status]=@Status,[Addtime]=@Addtime,[Uptatetime]=@Uptatetime where Id=@Id";
			SqlParameter[] _param={				
				new SqlParameter("@Id",SqlDbType.Int),
				new SqlParameter("@Name",SqlDbType.VarChar),
				new SqlParameter("@PropertyId",SqlDbType.Int),
				new SqlParameter("@PropertyKey",SqlDbType.VarChar),
				new SqlParameter("@PropertyValue",SqlDbType.VarChar),
				new SqlParameter("@Status",SqlDbType.Int),
				new SqlParameter("@Addtime",SqlDbType.DateTime),
				new SqlParameter("@Uptatetime",SqlDbType.DateTime)
				};				
				_param[0].Value=_wx_ConfigModel.Id;
				_param[1].Value=_wx_ConfigModel.Name;
				_param[2].Value=_wx_ConfigModel.PropertyId;
				_param[3].Value=_wx_ConfigModel.PropertyKey;
				_param[4].Value=_wx_ConfigModel.PropertyValue;
				_param[5].Value=_wx_ConfigModel.Status;
				_param[6].Value=_wx_ConfigModel.Addtime;
				_param[7].Value=_wx_ConfigModel.Uptatetime;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}		
		
		
		/// <summary>
		/// 删除数据表wx_Config中的一条记录
		/// </summary>
	    /// <param name="Id">id</param>
		/// <returns>影响的行数</returns>
		public int Delete(int Id)
		{
			string sqlStr="delete from wx_Config where [Id]=@Id";
			SqlParameter[] _param={			
			new SqlParameter("@Id",SqlDbType.Int),
			
			};			
			_param[0].Value=Id;
            return SqlHelper.ExecuteNonQuery(WebConfig.WfxRW, CommandType.Text, sqlStr, _param);
		}
		
		/// <summary>
		/// 删除数据表wx_Config中的一条记录,带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
	    /// <param name="Id">id</param>
		/// <returns>影响的行数</returns>
		public int Delete(SqlTransaction sp,int Id)
		{
			string sqlStr="delete from wx_Config where [Id]=@Id";
			SqlParameter[] _param={			
			new SqlParameter("@Id",SqlDbType.Int),
			
			};			
			_param[0].Value=Id;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}
		#endregion
		
		#region 数据实体
		/// <summary>
		/// 得到  wx_config 数据实体
		/// </summary>
		/// <param name="row">row</param>
		/// <returns>wx_config 数据实体</returns>
		public wx_ConfigEntity Populate_wx_ConfigEntity_FromDr(DataRow row)
		{
			wx_ConfigEntity Obj = new wx_ConfigEntity();
			if(row!=null)
			{
				Obj.Id = (( row["Id"])==DBNull.Value)?0:Convert.ToInt32( row["Id"]);
				Obj.Name =  row["Name"].ToString();
				Obj.PropertyId = (( row["PropertyId"])==DBNull.Value)?0:Convert.ToInt32( row["PropertyId"]);
				Obj.PropertyKey =  row["PropertyKey"].ToString();
				Obj.PropertyValue =  row["PropertyValue"].ToString();
				Obj.Status = (( row["Status"])==DBNull.Value)?0:Convert.ToInt32( row["Status"]);
				Obj.Addtime = (( row["Addtime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( row["Addtime"]);
				Obj.Uptatetime = (( row["Uptatetime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( row["Uptatetime"]);
			}
			else
			{
				return null;
			}
			return Obj;
		}
		
        /// <summary>
		/// 得到  wx_config 数据实体
		/// </summary>
		/// <param name="dr">dr</param>
		/// <returns>wx_config 数据实体</returns>
		public wx_ConfigEntity Populate_wx_ConfigEntity_FromDr(IDataReader dr)
		{
			wx_ConfigEntity Obj = new wx_ConfigEntity();
			
				Obj.Id = (( dr["Id"])==DBNull.Value)?0:Convert.ToInt32( dr["Id"]);
				Obj.Name =  dr["Name"].ToString();
				Obj.PropertyId = (( dr["PropertyId"])==DBNull.Value)?0:Convert.ToInt32( dr["PropertyId"]);
				Obj.PropertyKey =  dr["PropertyKey"].ToString();
				Obj.PropertyValue =  dr["PropertyValue"].ToString();
				Obj.Status = (( dr["Status"])==DBNull.Value)?0:Convert.ToInt32( dr["Status"]);
				Obj.Addtime = (( dr["Addtime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( dr["Addtime"]);
				Obj.Uptatetime = (( dr["Uptatetime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( dr["Uptatetime"]);
			
			return Obj;
		}
		#endregion
		
		/// <summary>
		/// 根据ID,返回一个wx_Config对象
		/// </summary>
		/// <param name="id">id</param>
		/// <returns>wx_Config对象</returns>
		public wx_ConfigEntity Get_wx_ConfigEntity (int id)
		{
			wx_ConfigEntity _obj=null;
			SqlParameter[] _param={
			new SqlParameter("@Id",SqlDbType.Int)
			};
			_param[0].Value=id;
			string sqlStr="select * from wx_Config with(nolock) where Id=@Id";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.WfxRW, CommandType.Text, sqlStr, _param))
			{
				while(dr.Read())
				{
            		_obj=Populate_wx_ConfigEntity_FromDr(dr);
				}
			}
			return _obj;
		}
		/// <summary>
		/// 得到数据表wx_Config所有记录
		/// </summary>
		/// <returns>数据集</returns>
		public IList< wx_ConfigEntity> Get_wx_ConfigAll()
		{
			IList< wx_ConfigEntity> Obj=new List< wx_ConfigEntity>();
			string sqlStr="select * from wx_Config";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.WfxRW, CommandType.Text, sqlStr))
			{
				while(dr.Read())
				{
					Obj.Add(Populate_wx_ConfigEntity_FromDr(dr));
				}
			}
			return Obj;
		}
		/// <summary>
        /// 检测是否存在根据主键
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>是/否</returns>
		public bool IsExistwx_Config(int id)
		{
			SqlParameter[] _param={
                                      new SqlParameter("@id",SqlDbType.Int)
                                  };
            _param[0].Value=id;
            string sqlStr="select Count(*) from wx_Config where Id=@id";
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
