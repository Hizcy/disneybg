// =================================================================== 
// 项目说明
//====================================================================
// yangxg。@Copy Right 2014
// 文件： T_AttrValueSKU.cs
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
    /// 数据层实例化接口类 dbo.T_AttrValueSKU.
    /// </summary>
    public partial class T_AttrValueSKUDataAccessLayer 
    {
        #region 构造函数


		/// <summary>
		/// 
		/// </summary>
		public T_AttrValueSKUDataAccessLayer()
		{
		}
		#endregion

        #region -----------实例化接口函数-----------
		
		#region 添加更新删除
		/// <summary>
		/// 向数据库中插入一条新记录。
		/// </summary>
		/// <param name="_T_AttrValueSKUModel">T_AttrValueSKU实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(T_AttrValueSKUEntity _T_AttrValueSKUModel)
		{
			string sqlStr="insert into T_AttrValueSKU([ProductId],[AttrSkuId],[AttrSkuVal]) values(@ProductId,@AttrSkuId,@AttrSkuVal) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@ProductId",SqlDbType.Int),
			new SqlParameter("@AttrSkuId",SqlDbType.Int),
			new SqlParameter("@AttrSkuVal",SqlDbType.VarChar)
			};			
			_param[0].Value=_T_AttrValueSKUModel.ProductId;
			_param[1].Value=_T_AttrValueSKUModel.AttrSkuId;
			_param[2].Value=_T_AttrValueSKUModel.AttrSkuVal;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.WfxRW,CommandType.Text,sqlStr,_param));
			return res;
		}
		/// <summary>
		/// 向数据库中插入一条新记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_T_AttrValueSKUModel">T_AttrValueSKU实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(SqlTransaction sp,T_AttrValueSKUEntity _T_AttrValueSKUModel)
		{
			string sqlStr="insert into T_AttrValueSKU([ProductId],[AttrSkuId],[AttrSkuVal]) values(@ProductId,@AttrSkuId,@AttrSkuVal) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@ProductId",SqlDbType.Int),
			new SqlParameter("@AttrSkuId",SqlDbType.Int),
			new SqlParameter("@AttrSkuVal",SqlDbType.VarChar)
			};			
			_param[0].Value=_T_AttrValueSKUModel.ProductId;
			_param[1].Value=_T_AttrValueSKUModel.AttrSkuId;
			_param[2].Value=_T_AttrValueSKUModel.AttrSkuVal;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(sp,CommandType.Text,sqlStr,_param));
			return res;
		}


		/// <summary>
		/// 向数据表T_AttrValueSKU更新一条记录。
		/// </summary>
		/// <param name="_T_AttrValueSKUModel">_T_AttrValueSKUModel</param>
		/// <returns>影响的行数</returns>
		public int Update(T_AttrValueSKUEntity _T_AttrValueSKUModel)
		{
            string sqlStr="update T_AttrValueSKU set [ProductId]=@ProductId,[AttrSkuId]=@AttrSkuId,[AttrSkuVal]=@AttrSkuVal where Id=@Id";
			SqlParameter[] _param={				
				new SqlParameter("@Id",SqlDbType.Int),
				new SqlParameter("@ProductId",SqlDbType.Int),
				new SqlParameter("@AttrSkuId",SqlDbType.Int),
				new SqlParameter("@AttrSkuVal",SqlDbType.VarChar)
				};				
				_param[0].Value=_T_AttrValueSKUModel.Id;
				_param[1].Value=_T_AttrValueSKUModel.ProductId;
				_param[2].Value=_T_AttrValueSKUModel.AttrSkuId;
				_param[3].Value=_T_AttrValueSKUModel.AttrSkuVal;
			return SqlHelper.ExecuteNonQuery(WebConfig.WfxRW,CommandType.Text,sqlStr,_param);
		}
		/// <summary>
		/// 向数据表T_AttrValueSKU更新一条记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_T_AttrValueSKUModel">_T_AttrValueSKUModel</param>
		/// <returns>影响的行数</returns>
		public int Update(SqlTransaction sp,T_AttrValueSKUEntity _T_AttrValueSKUModel)
		{
            string sqlStr="update T_AttrValueSKU set [ProductId]=@ProductId,[AttrSkuId]=@AttrSkuId,[AttrSkuVal]=@AttrSkuVal where Id=@Id";
			SqlParameter[] _param={				
				new SqlParameter("@Id",SqlDbType.Int),
				new SqlParameter("@ProductId",SqlDbType.Int),
				new SqlParameter("@AttrSkuId",SqlDbType.Int),
				new SqlParameter("@AttrSkuVal",SqlDbType.VarChar)
				};				
				_param[0].Value=_T_AttrValueSKUModel.Id;
				_param[1].Value=_T_AttrValueSKUModel.ProductId;
				_param[2].Value=_T_AttrValueSKUModel.AttrSkuId;
				_param[3].Value=_T_AttrValueSKUModel.AttrSkuVal;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}		
		
		
		/// <summary>
		/// 删除数据表T_AttrValueSKU中的一条记录
		/// </summary>
	    /// <param name="Id">id</param>
		/// <returns>影响的行数</returns>
		public int Delete(int Id)
		{
			string sqlStr="delete from T_AttrValueSKU where [Id]=@Id";
			SqlParameter[] _param={			
			new SqlParameter("@Id",SqlDbType.Int),
			
			};			
			_param[0].Value=Id;
			return SqlHelper.ExecuteNonQuery(WebConfig.WfxRW,CommandType.Text,sqlStr,_param);
		}
		
		/// <summary>
		/// 删除数据表T_AttrValueSKU中的一条记录,带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
	    /// <param name="Id">id</param>
		/// <returns>影响的行数</returns>
		public int Delete(SqlTransaction sp,int Id)
		{
			string sqlStr="delete from T_AttrValueSKU where [Id]=@Id";
			SqlParameter[] _param={			
			new SqlParameter("@Id",SqlDbType.Int),
			
			};			
			_param[0].Value=Id;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}
		#endregion
		
		#region 数据实体
		/// <summary>
		/// 得到  T_AttrValueSKU 数据实体
		/// </summary>
		/// <param name="row">row</param>
		/// <returns>T_AttrValueSKU 数据实体</returns>
		public T_AttrValueSKUEntity Populate_T_AttrValueSKUEntity_FromDr(DataRow row)
		{
			T_AttrValueSKUEntity Obj = new T_AttrValueSKUEntity();
			if(row!=null)
			{
				Obj.Id = (( row["Id"])==DBNull.Value)?0:Convert.ToInt32( row["Id"]);
				Obj.ProductId = (( row["ProductId"])==DBNull.Value)?0:Convert.ToInt32( row["ProductId"]);
				Obj.AttrSkuId = (( row["AttrSkuId"])==DBNull.Value)?0:Convert.ToInt32( row["AttrSkuId"]);
				Obj.AttrSkuVal =  row["AttrSkuVal"].ToString();
			}
			else
			{
				return null;
			}
			return Obj;
		}
		
        /// <summary>
		/// 得到  T_AttrValueSKU 数据实体
		/// </summary>
		/// <param name="dr">dr</param>
		/// <returns>T_AttrValueSKU 数据实体</returns>
		public T_AttrValueSKUEntity Populate_T_AttrValueSKUEntity_FromDr(IDataReader dr)
		{
			T_AttrValueSKUEntity Obj = new T_AttrValueSKUEntity();
			
				Obj.Id = (( dr["Id"])==DBNull.Value)?0:Convert.ToInt32( dr["Id"]);
				Obj.ProductId = (( dr["ProductId"])==DBNull.Value)?0:Convert.ToInt32( dr["ProductId"]);
				Obj.AttrSkuId = (( dr["AttrSkuId"])==DBNull.Value)?0:Convert.ToInt32( dr["AttrSkuId"]);
				Obj.AttrSkuVal =  dr["AttrSkuVal"].ToString();
			
			return Obj;
		}
		#endregion
		
		/// <summary>
		/// 根据ID,返回一个T_AttrValueSKU对象
		/// </summary>
		/// <param name="id">id</param>
		/// <returns>T_AttrValueSKU对象</returns>
		public T_AttrValueSKUEntity Get_T_AttrValueSKUEntity (int id)
		{
			T_AttrValueSKUEntity _obj=null;
			SqlParameter[] _param={
			new SqlParameter("@Id",SqlDbType.Int)
			};
			_param[0].Value=id;
			string sqlStr="select * from T_AttrValueSKU with(nolock) where Id=@Id";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.WfxRW,CommandType.Text,sqlStr,_param))
			{
				while(dr.Read())
				{
            		_obj=Populate_T_AttrValueSKUEntity_FromDr(dr);
				}
			}
			return _obj;
		}
        /// <summary>
        /// 得到数据表T_AttrValueSKU所有记录
        /// </summary>
        /// <returns>数据集</returns>
        public IList<T_AttrValueSKUEntity> Get_T_AttrValueSKUByProductId(int productId)
        {
            IList<T_AttrValueSKUEntity> Obj = new List<T_AttrValueSKUEntity>();
            SqlParameter[] _param ={
			new SqlParameter("@ProductId",SqlDbType.Int)
			};
            _param[0].Value = productId;
            string sqlStr = "select * from T_AttrValueSKU where ProductId=@ProductId";

            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.WfxRW, CommandType.Text, sqlStr, _param))
            {
                while (dr.Read())
                {
                    Obj.Add(Populate_T_AttrValueSKUEntity_FromDr(dr));
                }
            }
            return Obj;
        }

		/// <summary>
		/// 得到数据表T_AttrValueSKU所有记录
		/// </summary>
		/// <returns>数据集</returns>
		public IList< T_AttrValueSKUEntity> Get_T_AttrValueSKUAll()
		{
			IList< T_AttrValueSKUEntity> Obj=new List< T_AttrValueSKUEntity>();
			string sqlStr="select * from T_AttrValueSKU";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.WfxRW,CommandType.Text,sqlStr))
			{
				while(dr.Read())
				{
					Obj.Add(Populate_T_AttrValueSKUEntity_FromDr(dr));
				}
			}
			return Obj;
		}
		/// <summary>
        /// 检测是否存在根据主键
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>是/否</returns>
		public bool IsExistT_AttrValueSKU(int id)
		{
			SqlParameter[] _param={
                                      new SqlParameter("@id",SqlDbType.Int)
                                  };
            _param[0].Value=id;
            string sqlStr="select Count(*) from T_AttrValueSKU where Id=@id";
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
