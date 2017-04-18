// =================================================================== 
// 项目说明
//====================================================================
// yangxg。@Copy Right 2014
// 文件： ProductSKU.cs
// 项目名称：买车网
// 创建时间：2016/4/17
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
    /// 数据层实例化接口类 dbo.ProductSKU.
    /// </summary>
    public partial class ProductSKUDataAccessLayer 
    {
		#region 构造函数


		/// <summary>
		/// 
		/// </summary>
		public ProductSKUDataAccessLayer()
		{
		}
		#endregion

        #region -----------实例化接口函数-----------
		
		#region 添加更新删除
		/// <summary>
		/// 向数据库中插入一条新记录。
		/// </summary>
		/// <param name="_ProductSKUModel">ProductSKU实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(ProductSKUEntity _ProductSKUModel)
		{
			string sqlStr="insert into ProductSKU([ProductId],[AttrValue],[Stock],[ProductCode],[Images]) values(@ProductId,@AttrValue,@Stock,@ProductCode,@Images) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@ProductId",SqlDbType.Int),
			new SqlParameter("@AttrValue",SqlDbType.VarChar),
			new SqlParameter("@Stock",SqlDbType.Int),
			new SqlParameter("@ProductCode",SqlDbType.VarChar),
			new SqlParameter("@Images",SqlDbType.VarChar)
			};			
			_param[0].Value=_ProductSKUModel.ProductId;
			_param[1].Value=_ProductSKUModel.AttrValue;
			_param[2].Value=_ProductSKUModel.Stock;
			_param[3].Value=_ProductSKUModel.ProductCode;
			_param[4].Value=_ProductSKUModel.Images;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.WfxRW,CommandType.Text,sqlStr,_param));
			return res;
		}
		/// <summary>
		/// 向数据库中插入一条新记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_ProductSKUModel">ProductSKU实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(SqlTransaction sp,ProductSKUEntity _ProductSKUModel)
		{
			string sqlStr="insert into ProductSKU([ProductId],[AttrValue],[Stock],[ProductCode],[Images]) values(@ProductId,@AttrValue,@Stock,@ProductCode,@Images) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@ProductId",SqlDbType.Int),
			new SqlParameter("@AttrValue",SqlDbType.VarChar),
			new SqlParameter("@Stock",SqlDbType.Int),
			new SqlParameter("@ProductCode",SqlDbType.VarChar),
			new SqlParameter("@Images",SqlDbType.VarChar)
			};			
			_param[0].Value=_ProductSKUModel.ProductId;
			_param[1].Value=_ProductSKUModel.AttrValue;
			_param[2].Value=_ProductSKUModel.Stock;
			_param[3].Value=_ProductSKUModel.ProductCode;
			_param[4].Value=_ProductSKUModel.Images;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(sp,CommandType.Text,sqlStr,_param));
			return res;
		}


		/// <summary>
		/// 向数据表ProductSKU更新一条记录。
		/// </summary>
		/// <param name="_ProductSKUModel">_ProductSKUModel</param>
		/// <returns>影响的行数</returns>
		public int Update(ProductSKUEntity _ProductSKUModel)
		{
            string sqlStr="update ProductSKU set [ProductId]=@ProductId,[AttrValue]=@AttrValue,[Stock]=@Stock,[ProductCode]=@ProductCode,[Images]=@Images where Id=@Id";
			SqlParameter[] _param={				
				new SqlParameter("@Id",SqlDbType.Int),
				new SqlParameter("@ProductId",SqlDbType.Int),
				new SqlParameter("@AttrValue",SqlDbType.VarChar),
				new SqlParameter("@Stock",SqlDbType.Int),
				new SqlParameter("@ProductCode",SqlDbType.VarChar),
				new SqlParameter("@Images",SqlDbType.VarChar)
				};				
				_param[0].Value=_ProductSKUModel.Id;
				_param[1].Value=_ProductSKUModel.ProductId;
				_param[2].Value=_ProductSKUModel.AttrValue;
				_param[3].Value=_ProductSKUModel.Stock;
				_param[4].Value=_ProductSKUModel.ProductCode;
				_param[5].Value=_ProductSKUModel.Images;
			return SqlHelper.ExecuteNonQuery(WebConfig.WfxRW,CommandType.Text,sqlStr,_param);
		}
		/// <summary>
		/// 向数据表ProductSKU更新一条记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_ProductSKUModel">_ProductSKUModel</param>
		/// <returns>影响的行数</returns>
		public int Update(SqlTransaction sp,ProductSKUEntity _ProductSKUModel)
		{
            string sqlStr="update ProductSKU set [ProductId]=@ProductId,[AttrValue]=@AttrValue,[Stock]=@Stock,[ProductCode]=@ProductCode,[Images]=@Images where Id=@Id";
			SqlParameter[] _param={				
				new SqlParameter("@Id",SqlDbType.Int),
				new SqlParameter("@ProductId",SqlDbType.Int),
				new SqlParameter("@AttrValue",SqlDbType.VarChar),
				new SqlParameter("@Stock",SqlDbType.Int),
				new SqlParameter("@ProductCode",SqlDbType.VarChar),
				new SqlParameter("@Images",SqlDbType.VarChar)
				};				
				_param[0].Value=_ProductSKUModel.Id;
				_param[1].Value=_ProductSKUModel.ProductId;
				_param[2].Value=_ProductSKUModel.AttrValue;
				_param[3].Value=_ProductSKUModel.Stock;
				_param[4].Value=_ProductSKUModel.ProductCode;
				_param[5].Value=_ProductSKUModel.Images;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}		
		
		
		/// <summary>
		/// 删除数据表ProductSKU中的一条记录
		/// </summary>
	    /// <param name="Id">id</param>
		/// <returns>影响的行数</returns>
		public int Delete(int Id)
		{
			string sqlStr="delete from ProductSKU where [Id]=@Id";
			SqlParameter[] _param={			
			new SqlParameter("@Id",SqlDbType.Int),
			
			};			
			_param[0].Value=Id;
			return SqlHelper.ExecuteNonQuery(WebConfig.WfxRW,CommandType.Text,sqlStr,_param);
		}
		
		/// <summary>
		/// 删除数据表ProductSKU中的一条记录,带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
	    /// <param name="Id">id</param>
		/// <returns>影响的行数</returns>
		public int Delete(SqlTransaction sp,int Id)
		{
			string sqlStr="delete from ProductSKU where [Id]=@Id";
			SqlParameter[] _param={			
			new SqlParameter("@Id",SqlDbType.Int),
			
			};			
			_param[0].Value=Id;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}
		#endregion
		
		#region 数据实体
		/// <summary>
		/// 得到  productsku 数据实体
		/// </summary>
		/// <param name="row">row</param>
		/// <returns>productsku 数据实体</returns>
		public ProductSKUEntity Populate_ProductSKUEntity_FromDr(DataRow row)
		{
			ProductSKUEntity Obj = new ProductSKUEntity();
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
		/// 得到  productsku 数据实体
		/// </summary>
		/// <param name="dr">dr</param>
		/// <returns>productsku 数据实体</returns>
		public ProductSKUEntity Populate_ProductSKUEntity_FromDr(IDataReader dr)
		{
			ProductSKUEntity Obj = new ProductSKUEntity();
			
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
		/// 根据ID,返回一个ProductSKU对象
		/// </summary>
		/// <param name="id">id</param>
		/// <returns>ProductSKU对象</returns>
		public ProductSKUEntity Get_ProductSKUEntity (int id)
		{
			ProductSKUEntity _obj=null;
			SqlParameter[] _param={
			new SqlParameter("@Id",SqlDbType.Int)
			};
			_param[0].Value=id;
			string sqlStr="select * from ProductSKU with(nolock) where Id=@Id";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.WfxRW,CommandType.Text,sqlStr,_param))
			{
				while(dr.Read())
				{
            		_obj=Populate_ProductSKUEntity_FromDr(dr);
				}
			}
			return _obj;
		}
		/// <summary>
		/// 得到数据表ProductSKU所有记录
		/// </summary>
		/// <returns>数据集</returns>
        public IList<ProductSKUEntity> Get_ProductSKUAllByProductId(int ProductId)
		{
			IList< ProductSKUEntity> Obj=new List< ProductSKUEntity>();
            SqlParameter[] _param ={
			new SqlParameter("@ProductId",SqlDbType.Int)
			};
            _param[0].Value = ProductId;

            string sqlStr = "select * from ProductSKU  where ProductId=@ProductId";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.WfxRW, CommandType.Text, sqlStr, _param))
			{
				while(dr.Read())
				{
					Obj.Add(Populate_ProductSKUEntity_FromDr(dr));
				}
			}
			return Obj;
		}
		/// <summary>
        /// 检测是否存在根据主键
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>是/否</returns>
		public bool IsExistProductSKU(int id)
		{
			SqlParameter[] _param={
                                      new SqlParameter("@id",SqlDbType.Int)
                                  };
            _param[0].Value=id;
            string sqlStr="select Count(*) from ProductSKU where Id=@id";
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
