// =================================================================== 
// 项目说明
//====================================================================
// yangxg。@Copy Right 2014
// 文件： T_ProductSKU.cs
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
    /// 数据层实例化接口类 dbo.T_T_ProductSKU.
    /// </summary>
    public partial class T_ProductSKUDataAccessLayer
    {
        #region 构造函数


		/// <summary>
		/// 
		/// </summary>
        public T_ProductSKUDataAccessLayer()
		{
		}
		#endregion

        #region -----------实例化接口函数-----------
		
		#region 添加更新删除
		/// <summary>
		/// 向数据库中插入一条新记录。
		/// </summary>
		/// <param name="_T_ProductSKUModel">T_ProductSKU实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(T_ProductSKUEntity _T_ProductSKUModel)
		{
			string sqlStr="insert into T_ProductSKU([ProductId],[AttrValue],[Stock],[ProductCode],[Images]) values(@ProductId,@AttrValue,@Stock,@ProductCode,@Images) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@ProductId",SqlDbType.Int),
			new SqlParameter("@AttrValue",SqlDbType.VarChar),
			new SqlParameter("@Stock",SqlDbType.Int),
			new SqlParameter("@ProductCode",SqlDbType.VarChar),
			new SqlParameter("@Images",SqlDbType.VarChar)
			};			
			_param[0].Value=_T_ProductSKUModel.ProductId;
			_param[1].Value=_T_ProductSKUModel.AttrValue;
			_param[2].Value=_T_ProductSKUModel.Stock;
			_param[3].Value=_T_ProductSKUModel.ProductCode;
			_param[4].Value=_T_ProductSKUModel.Images;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.WfxRW,CommandType.Text,sqlStr,_param));
			return res;
		}
		/// <summary>
		/// 向数据库中插入一条新记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_T_ProductSKUModel">T_ProductSKU实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(SqlTransaction sp,T_ProductSKUEntity _T_ProductSKUModel)
		{
			string sqlStr="insert into T_ProductSKU([ProductId],[AttrValue],[Stock],[ProductCode],[Images]) values(@ProductId,@AttrValue,@Stock,@ProductCode,@Images) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@ProductId",SqlDbType.Int),
			new SqlParameter("@AttrValue",SqlDbType.VarChar),
			new SqlParameter("@Stock",SqlDbType.Int),
			new SqlParameter("@ProductCode",SqlDbType.VarChar),
			new SqlParameter("@Images",SqlDbType.VarChar)
			};			
			_param[0].Value=_T_ProductSKUModel.ProductId;
			_param[1].Value=_T_ProductSKUModel.AttrValue;
			_param[2].Value=_T_ProductSKUModel.Stock;
			_param[3].Value=_T_ProductSKUModel.ProductCode;
			_param[4].Value=_T_ProductSKUModel.Images;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(sp,CommandType.Text,sqlStr,_param));
			return res;
		}


		/// <summary>
		/// 向数据表T_ProductSKU更新一条记录。
		/// </summary>
		/// <param name="_T_ProductSKUModel">_T_ProductSKUModel</param>
		/// <returns>影响的行数</returns>
		public int Update(T_ProductSKUEntity _T_ProductSKUModel)
		{
            string sqlStr="update T_ProductSKU set [ProductId]=@ProductId,[AttrValue]=@AttrValue,[Stock]=@Stock,[ProductCode]=@ProductCode,[Images]=@Images where Id=@Id";
			SqlParameter[] _param={				
				new SqlParameter("@Id",SqlDbType.Int),
				new SqlParameter("@ProductId",SqlDbType.Int),
				new SqlParameter("@AttrValue",SqlDbType.VarChar),
				new SqlParameter("@Stock",SqlDbType.Int),
				new SqlParameter("@ProductCode",SqlDbType.VarChar),
				new SqlParameter("@Images",SqlDbType.VarChar)
				};				
				_param[0].Value=_T_ProductSKUModel.Id;
				_param[1].Value=_T_ProductSKUModel.ProductId;
				_param[2].Value=_T_ProductSKUModel.AttrValue;
				_param[3].Value=_T_ProductSKUModel.Stock;
				_param[4].Value=_T_ProductSKUModel.ProductCode;
				_param[5].Value=_T_ProductSKUModel.Images;
			return SqlHelper.ExecuteNonQuery(WebConfig.WfxRW,CommandType.Text,sqlStr,_param);
		}
		/// <summary>
		/// 向数据表T_ProductSKU更新一条记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_T_ProductSKUModel">_T_ProductSKUModel</param>
		/// <returns>影响的行数</returns>
		public int Update(SqlTransaction sp,T_ProductSKUEntity _T_ProductSKUModel)
		{
            string sqlStr="update T_ProductSKU set [ProductId]=@ProductId,[AttrValue]=@AttrValue,[Stock]=@Stock,[ProductCode]=@ProductCode,[Images]=@Images where Id=@Id";
			SqlParameter[] _param={				
				new SqlParameter("@Id",SqlDbType.Int),
				new SqlParameter("@ProductId",SqlDbType.Int),
				new SqlParameter("@AttrValue",SqlDbType.VarChar),
				new SqlParameter("@Stock",SqlDbType.Int),
				new SqlParameter("@ProductCode",SqlDbType.VarChar),
				new SqlParameter("@Images",SqlDbType.VarChar)
				};				
				_param[0].Value=_T_ProductSKUModel.Id;
				_param[1].Value=_T_ProductSKUModel.ProductId;
				_param[2].Value=_T_ProductSKUModel.AttrValue;
				_param[3].Value=_T_ProductSKUModel.Stock;
				_param[4].Value=_T_ProductSKUModel.ProductCode;
				_param[5].Value=_T_ProductSKUModel.Images;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}		
		
		
		/// <summary>
		/// 删除数据表T_ProductSKU中的一条记录
		/// </summary>
	    /// <param name="Id">id</param>
		/// <returns>影响的行数</returns>
		public int Delete(int Id)
		{
			string sqlStr="delete from T_ProductSKU where [Id]=@Id";
			SqlParameter[] _param={			
			new SqlParameter("@Id",SqlDbType.Int),
			
			};			
			_param[0].Value=Id;
			return SqlHelper.ExecuteNonQuery(WebConfig.WfxRW,CommandType.Text,sqlStr,_param);
		}
		
		/// <summary>
		/// 删除数据表T_ProductSKU中的一条记录,带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
	    /// <param name="Id">id</param>
		/// <returns>影响的行数</returns>
		public int Delete(SqlTransaction sp,int Id)
		{
			string sqlStr="delete from T_ProductSKU where [Id]=@Id";
			SqlParameter[] _param={			
			new SqlParameter("@Id",SqlDbType.Int),
			
			};			
			_param[0].Value=Id;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}
		#endregion
		
		#region 数据实体
		/// <summary>
		/// 得到  T_ProductSKU 数据实体
		/// </summary>
		/// <param name="row">row</param>
		/// <returns>T_ProductSKU 数据实体</returns>
		public T_ProductSKUEntity Populate_T_ProductSKUEntity_FromDr(DataRow row)
		{
			T_ProductSKUEntity Obj = new T_ProductSKUEntity();
			if(row!=null)
			{
				Obj.Id = (( row["Id"])==DBNull.Value)?0:Convert.ToInt32( row["Id"]);
				Obj.ProductId = (( row["ProductId"])==DBNull.Value)?0:Convert.ToInt32( row["ProductId"]);
				Obj.AttrValue =  row["AttrValue"].ToString();
				Obj.Stock = (( row["Stock"])==DBNull.Value)?0:Convert.ToInt32( row["Stock"]);
				Obj.ProductCode =  row["ProductCode"].ToString();
				Obj.Images =  row["Images"].ToString();
			}
			else
			{
				return null;
			}
			return Obj;
		}
		
        /// <summary>
		/// 得到  T_ProductSKU 数据实体
		/// </summary>
		/// <param name="dr">dr</param>
		/// <returns>T_ProductSKU 数据实体</returns>
		public T_ProductSKUEntity Populate_T_ProductSKUEntity_FromDr(IDataReader dr)
		{
			T_ProductSKUEntity Obj = new T_ProductSKUEntity();
			
				Obj.Id = (( dr["Id"])==DBNull.Value)?0:Convert.ToInt32( dr["Id"]);
				Obj.ProductId = (( dr["ProductId"])==DBNull.Value)?0:Convert.ToInt32( dr["ProductId"]);
				Obj.AttrValue =  dr["AttrValue"].ToString();
				Obj.Stock = (( dr["Stock"])==DBNull.Value)?0:Convert.ToInt32( dr["Stock"]);
				Obj.ProductCode =  dr["ProductCode"].ToString();
				Obj.Images =  dr["Images"].ToString();
			
			return Obj;
		}
		#endregion
		
		/// <summary>
		/// 根据ID,返回一个T_ProductSKU对象
		/// </summary>
		/// <param name="id">id</param>
		/// <returns>T_ProductSKU对象</returns>
		public T_ProductSKUEntity Get_T_ProductSKUEntity (int id)
		{
			T_ProductSKUEntity _obj=null;
			SqlParameter[] _param={
			new SqlParameter("@Id",SqlDbType.Int)
			};
			_param[0].Value=id;
			string sqlStr="select * from T_ProductSKU with(nolock) where Id=@Id";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.WfxRW,CommandType.Text,sqlStr,_param))
			{
				while(dr.Read())
				{
            		_obj=Populate_T_ProductSKUEntity_FromDr(dr);
				}
			}
			return _obj;
		}
		/// <summary>
		/// 得到数据表T_ProductSKU所有记录
		/// </summary>
		/// <returns>数据集</returns>
        public IList<T_ProductSKUEntity> Get_T_ProductSKUAllByProductId(int ProductId)
		{
			IList< T_ProductSKUEntity> Obj=new List< T_ProductSKUEntity>();
            SqlParameter[] _param ={
			new SqlParameter("@ProductId",SqlDbType.Int)
			};
            _param[0].Value = ProductId;

            string sqlStr = "select * from T_ProductSKU  where ProductId=@ProductId";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.WfxRW, CommandType.Text, sqlStr, _param))
			{
				while(dr.Read())
				{
					Obj.Add(Populate_T_ProductSKUEntity_FromDr(dr));
				}
			}
			return Obj;
		}
		/// <summary>
        /// 检测是否存在根据主键
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>是/否</returns>
		public bool IsExistT_ProductSKU(int id)
		{
			SqlParameter[] _param={
                                      new SqlParameter("@id",SqlDbType.Int)
                                  };
            _param[0].Value=id;
            string sqlStr="select Count(*) from T_ProductSKU where Id=@id";
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
