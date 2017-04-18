// =================================================================== 
// 项目说明
//====================================================================
// yangxg。@Copy Right 2014
// 文件： T_AttrSKU.cs
// 项目名称：买车网
// 创建时间：2016/8/22
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
    /// 数据层实例化接口类 dbo.T_AttrSKU.
    /// </summary>
    public partial class T_AttrSKUDataAccessLayer 
    {
        	#region 构造函数


		/// <summary>
		/// 
		/// </summary>
		public T_AttrSKUDataAccessLayer()
		{
		}
		#endregion

        #region -----------实例化接口函数-----------
		
		#region 添加更新删除
		/// <summary>
		/// 向数据库中插入一条新记录。
		/// </summary>
		/// <param name="_T_AttrSKUModel">T_AttrSKU实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(T_AttrSKUEntity _T_AttrSKUModel)
		{
			string sqlStr="insert into T_AttrSKU([ClsId],[AttrName],[AttrDesc]) values(@ClsId,@AttrName,@AttrDesc) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@ClsId",SqlDbType.Int),
			new SqlParameter("@AttrName",SqlDbType.VarChar),
			new SqlParameter("@AttrDesc",SqlDbType.VarChar)
			};			
			_param[0].Value=_T_AttrSKUModel.ClsId;
			_param[1].Value=_T_AttrSKUModel.AttrName;
			_param[2].Value=_T_AttrSKUModel.AttrDesc;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.WfxRW,CommandType.Text,sqlStr,_param));
			return res;
		}
		/// <summary>
		/// 向数据库中插入一条新记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_T_AttrSKUModel">T_AttrSKU实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(SqlTransaction sp,T_AttrSKUEntity _T_AttrSKUModel)
		{
			string sqlStr="insert into T_AttrSKU([ClsId],[AttrName],[AttrDesc]) values(@ClsId,@AttrName,@AttrDesc) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@ClsId",SqlDbType.Int),
			new SqlParameter("@AttrName",SqlDbType.VarChar),
			new SqlParameter("@AttrDesc",SqlDbType.VarChar)
			};			
			_param[0].Value=_T_AttrSKUModel.ClsId;
			_param[1].Value=_T_AttrSKUModel.AttrName;
			_param[2].Value=_T_AttrSKUModel.AttrDesc;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(sp,CommandType.Text,sqlStr,_param));
			return res;
		}


		/// <summary>
		/// 向数据表T_AttrSKU更新一条记录。
		/// </summary>
		/// <param name="_T_AttrSKUModel">_T_AttrSKUModel</param>
		/// <returns>影响的行数</returns>
		public int Update(T_AttrSKUEntity _T_AttrSKUModel)
		{
            string sqlStr="update T_AttrSKU set [ClsId]=@ClsId,[AttrName]=@AttrName,[AttrDesc]=@AttrDesc where Id=@Id";
			SqlParameter[] _param={				
				new SqlParameter("@Id",SqlDbType.Int),
				new SqlParameter("@ClsId",SqlDbType.Int),
				new SqlParameter("@AttrName",SqlDbType.VarChar),
				new SqlParameter("@AttrDesc",SqlDbType.VarChar)
				};				
				_param[0].Value=_T_AttrSKUModel.Id;
				_param[1].Value=_T_AttrSKUModel.ClsId;
				_param[2].Value=_T_AttrSKUModel.AttrName;
				_param[3].Value=_T_AttrSKUModel.AttrDesc;
			return SqlHelper.ExecuteNonQuery(WebConfig.WfxRW,CommandType.Text,sqlStr,_param);
		}
		/// <summary>
		/// 向数据表T_AttrSKU更新一条记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_T_AttrSKUModel">_T_AttrSKUModel</param>
		/// <returns>影响的行数</returns>
		public int Update(SqlTransaction sp,T_AttrSKUEntity _T_AttrSKUModel)
		{
            string sqlStr="update T_AttrSKU set [ClsId]=@ClsId,[AttrName]=@AttrName,[AttrDesc]=@AttrDesc where Id=@Id";
			SqlParameter[] _param={				
				new SqlParameter("@Id",SqlDbType.Int),
				new SqlParameter("@ClsId",SqlDbType.Int),
				new SqlParameter("@AttrName",SqlDbType.VarChar),
				new SqlParameter("@AttrDesc",SqlDbType.VarChar)
				};				
				_param[0].Value=_T_AttrSKUModel.Id;
				_param[1].Value=_T_AttrSKUModel.ClsId;
				_param[2].Value=_T_AttrSKUModel.AttrName;
				_param[3].Value=_T_AttrSKUModel.AttrDesc;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}		
		
		
		/// <summary>
		/// 删除数据表T_AttrSKU中的一条记录
		/// </summary>
	    /// <param name="Id">id</param>
		/// <returns>影响的行数</returns>
		public int Delete(int Id)
		{
			string sqlStr="delete from T_AttrSKU where [Id]=@Id";
			SqlParameter[] _param={			
			new SqlParameter("@Id",SqlDbType.Int),
			
			};			
			_param[0].Value=Id;
			return SqlHelper.ExecuteNonQuery(WebConfig.WfxRW,CommandType.Text,sqlStr,_param);
		}
		
		/// <summary>
		/// 删除数据表T_AttrSKU中的一条记录,带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
	    /// <param name="Id">id</param>
		/// <returns>影响的行数</returns>
		public int Delete(SqlTransaction sp,int Id)
		{
			string sqlStr="delete from T_AttrSKU where [Id]=@Id";
			SqlParameter[] _param={			
			new SqlParameter("@Id",SqlDbType.Int),
			
			};			
			_param[0].Value=Id;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}
		#endregion
		
		#region 数据实体
		/// <summary>
		/// 得到  T_AttrSKU 数据实体
		/// </summary>
		/// <param name="row">row</param>
		/// <returns>T_AttrSKU 数据实体</returns>
		public T_AttrSKUEntity Populate_T_AttrSKUEntity_FromDr(DataRow row)
		{
			T_AttrSKUEntity Obj = new T_AttrSKUEntity();
			if(row!=null)
			{
				Obj.Id = (( row["Id"])==DBNull.Value)?0:Convert.ToInt32( row["Id"]);
				Obj.ClsId = (( row["ClsId"])==DBNull.Value)?0:Convert.ToInt32( row["ClsId"]);
				Obj.AttrName =  row["AttrName"].ToString();
				Obj.AttrDesc =  row["AttrDesc"].ToString();
			}
			else
			{
				return null;
			}
			return Obj;
		}
		
        /// <summary>
		/// 得到  T_AttrSKU 数据实体
		/// </summary>
		/// <param name="dr">dr</param>
		/// <returns>T_AttrSKU 数据实体</returns>
		public T_AttrSKUEntity Populate_T_AttrSKUEntity_FromDr(IDataReader dr)
		{
			T_AttrSKUEntity Obj = new T_AttrSKUEntity();
			
				Obj.Id = (( dr["Id"])==DBNull.Value)?0:Convert.ToInt32( dr["Id"]);
				Obj.ClsId = (( dr["ClsId"])==DBNull.Value)?0:Convert.ToInt32( dr["ClsId"]);
				Obj.AttrName =  dr["AttrName"].ToString();
				Obj.AttrDesc =  dr["AttrDesc"].ToString();
			
			return Obj;
		}
		#endregion
		
		/// <summary>
		/// 根据ID,返回一个T_AttrSKU对象
		/// </summary>
		/// <param name="id">id</param>
		/// <returns>T_AttrSKU对象</returns>
		public T_AttrSKUEntity Get_T_AttrSKUEntity (int id)
		{
			T_AttrSKUEntity _obj=null;
			SqlParameter[] _param={
			new SqlParameter("@Id",SqlDbType.Int)
			};
			_param[0].Value=id;
			string sqlStr="select * from T_AttrSKU with(nolock) where Id=@Id";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.WfxRW,CommandType.Text,sqlStr,_param))
			{
				while(dr.Read())
				{
            		_obj=Populate_T_AttrSKUEntity_FromDr(dr);
				}
			}
			return _obj;
		}
		/// <summary>
		/// 得到数据表T_AttrSKU所有记录
		/// </summary>
		/// <returns>数据集</returns>
		public IList< T_AttrSKUEntity> Get_T_AttrSKUAll()
		{
			IList< T_AttrSKUEntity> Obj=new List< T_AttrSKUEntity>();
			string sqlStr="select * from T_AttrSKU";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.WfxRW,CommandType.Text,sqlStr))
			{
				while(dr.Read())
				{
					Obj.Add(Populate_T_AttrSKUEntity_FromDr(dr));
				}
			}
			return Obj;
		}
		/// <summary>
        /// 检测是否存在根据主键
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>是/否</returns>
		public bool IsExistT_AttrSKU(int id)
		{
			SqlParameter[] _param={
                                      new SqlParameter("@id",SqlDbType.Int)
                                  };
            _param[0].Value=id;
            string sqlStr="select Count(*) from T_AttrSKU where Id=@id";
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
