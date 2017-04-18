// =================================================================== 
// 项目说明
//====================================================================
// yangxg。@Copy Right 2014
// 文件： AttrValueSKU.cs
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
    /// 数据层实例化接口类 dbo.AttrValueSKU.
    /// </summary>
    public partial class AttrValueSKUDataAccessLayer 
    {
		#region 构造函数


		/// <summary>
		/// 
		/// </summary>
		public AttrValueSKUDataAccessLayer()
		{
		}
		#endregion

        #region -----------实例化接口函数-----------
		
		#region 添加更新删除
		/// <summary>
		/// 向数据库中插入一条新记录。
		/// </summary>
		/// <param name="_AttrValueSKUModel">AttrValueSKU实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(AttrValueSKUEntity _AttrValueSKUModel)
		{
			string sqlStr="insert into AttrValueSKU([ProductId],[AttrSkuId],[AttrSkuVal]) values(@ProductId,@AttrSkuId,@AttrSkuVal) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@ProductId",SqlDbType.Int),
			new SqlParameter("@AttrSkuId",SqlDbType.Int),
			new SqlParameter("@AttrSkuVal",SqlDbType.VarChar)
			};			
			_param[0].Value=_AttrValueSKUModel.ProductId;
			_param[1].Value=_AttrValueSKUModel.AttrSkuId;
			_param[2].Value=_AttrValueSKUModel.AttrSkuVal;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.WfxRW,CommandType.Text,sqlStr,_param));
			return res;
		}
		/// <summary>
		/// 向数据库中插入一条新记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_AttrValueSKUModel">AttrValueSKU实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(SqlTransaction sp,AttrValueSKUEntity _AttrValueSKUModel)
		{
			string sqlStr="insert into AttrValueSKU([ProductId],[AttrSkuId],[AttrSkuVal]) values(@ProductId,@AttrSkuId,@AttrSkuVal) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@ProductId",SqlDbType.Int),
			new SqlParameter("@AttrSkuId",SqlDbType.Int),
			new SqlParameter("@AttrSkuVal",SqlDbType.VarChar)
			};			
			_param[0].Value=_AttrValueSKUModel.ProductId;
			_param[1].Value=_AttrValueSKUModel.AttrSkuId;
			_param[2].Value=_AttrValueSKUModel.AttrSkuVal;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(sp,CommandType.Text,sqlStr,_param));
			return res;
		}


		/// <summary>
		/// 向数据表AttrValueSKU更新一条记录。
		/// </summary>
		/// <param name="_AttrValueSKUModel">_AttrValueSKUModel</param>
		/// <returns>影响的行数</returns>
		public int Update(AttrValueSKUEntity _AttrValueSKUModel)
		{
            string sqlStr="update AttrValueSKU set [ProductId]=@ProductId,[AttrSkuId]=@AttrSkuId,[AttrSkuVal]=@AttrSkuVal where Id=@Id";
			SqlParameter[] _param={				
				new SqlParameter("@Id",SqlDbType.Int),
				new SqlParameter("@ProductId",SqlDbType.Int),
				new SqlParameter("@AttrSkuId",SqlDbType.Int),
				new SqlParameter("@AttrSkuVal",SqlDbType.VarChar)
				};				
				_param[0].Value=_AttrValueSKUModel.Id;
				_param[1].Value=_AttrValueSKUModel.ProductId;
				_param[2].Value=_AttrValueSKUModel.AttrSkuId;
				_param[3].Value=_AttrValueSKUModel.AttrSkuVal;
			return SqlHelper.ExecuteNonQuery(WebConfig.WfxRW,CommandType.Text,sqlStr,_param);
		}
		/// <summary>
		/// 向数据表AttrValueSKU更新一条记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_AttrValueSKUModel">_AttrValueSKUModel</param>
		/// <returns>影响的行数</returns>
		public int Update(SqlTransaction sp,AttrValueSKUEntity _AttrValueSKUModel)
		{
            string sqlStr="update AttrValueSKU set [ProductId]=@ProductId,[AttrSkuId]=@AttrSkuId,[AttrSkuVal]=@AttrSkuVal where Id=@Id";
			SqlParameter[] _param={				
				new SqlParameter("@Id",SqlDbType.Int),
				new SqlParameter("@ProductId",SqlDbType.Int),
				new SqlParameter("@AttrSkuId",SqlDbType.Int),
				new SqlParameter("@AttrSkuVal",SqlDbType.VarChar)
				};				
				_param[0].Value=_AttrValueSKUModel.Id;
				_param[1].Value=_AttrValueSKUModel.ProductId;
				_param[2].Value=_AttrValueSKUModel.AttrSkuId;
				_param[3].Value=_AttrValueSKUModel.AttrSkuVal;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}		
		
		
		/// <summary>
		/// 删除数据表AttrValueSKU中的一条记录
		/// </summary>
	    /// <param name="Id">id</param>
		/// <returns>影响的行数</returns>
		public int Delete(int Id)
		{
			string sqlStr="delete from AttrValueSKU where [Id]=@Id";
			SqlParameter[] _param={			
			new SqlParameter("@Id",SqlDbType.Int),
			
			};			
			_param[0].Value=Id;
			return SqlHelper.ExecuteNonQuery(WebConfig.WfxRW,CommandType.Text,sqlStr,_param);
		}
		
		/// <summary>
		/// 删除数据表AttrValueSKU中的一条记录,带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
	    /// <param name="Id">id</param>
		/// <returns>影响的行数</returns>
		public int Delete(SqlTransaction sp,int Id)
		{
			string sqlStr="delete from AttrValueSKU where [Id]=@Id";
			SqlParameter[] _param={			
			new SqlParameter("@Id",SqlDbType.Int),
			
			};			
			_param[0].Value=Id;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}
		#endregion
		
		#region 数据实体
		/// <summary>
		/// 得到  attrvaluesku 数据实体
		/// </summary>
		/// <param name="row">row</param>
		/// <returns>attrvaluesku 数据实体</returns>
		public AttrValueSKUEntity Populate_AttrValueSKUEntity_FromDr(DataRow row)
		{
			AttrValueSKUEntity Obj = new AttrValueSKUEntity();
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
		/// 得到  attrvaluesku 数据实体
		/// </summary>
		/// <param name="dr">dr</param>
		/// <returns>attrvaluesku 数据实体</returns>
		public AttrValueSKUEntity Populate_AttrValueSKUEntity_FromDr(IDataReader dr)
		{
			AttrValueSKUEntity Obj = new AttrValueSKUEntity();
			
				Obj.Id = (( dr["Id"])==DBNull.Value)?0:Convert.ToInt32( dr["Id"]);
				Obj.ProductId = (( dr["ProductId"])==DBNull.Value)?0:Convert.ToInt32( dr["ProductId"]);
				Obj.AttrSkuId = (( dr["AttrSkuId"])==DBNull.Value)?0:Convert.ToInt32( dr["AttrSkuId"]);
				Obj.AttrSkuVal =  dr["AttrSkuVal"].ToString();
			
			return Obj;
		}
		#endregion
		
		/// <summary>
		/// 根据ID,返回一个AttrValueSKU对象
		/// </summary>
		/// <param name="id">id</param>
		/// <returns>AttrValueSKU对象</returns>
		public AttrValueSKUEntity Get_AttrValueSKUEntity (int id)
		{
			AttrValueSKUEntity _obj=null;
			SqlParameter[] _param={
			new SqlParameter("@Id",SqlDbType.Int)
			};
			_param[0].Value=id;
			string sqlStr="select * from AttrValueSKU with(nolock) where Id=@Id";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.WfxRW,CommandType.Text,sqlStr,_param))
			{
				while(dr.Read())
				{
            		_obj=Populate_AttrValueSKUEntity_FromDr(dr);
				}
			}
			return _obj;
		}
        /// <summary>
        /// 得到数据表AttrValueSKU所有记录
        /// </summary>
        /// <returns>数据集</returns>
        public IList<AttrValueSKUEntity> Get_AttrValueSKUByProductId(int productId)
        {
            IList<AttrValueSKUEntity> Obj = new List<AttrValueSKUEntity>();
            SqlParameter[] _param ={
			new SqlParameter("@ProductId",SqlDbType.Int)
			};
            _param[0].Value = productId;
            string sqlStr = "select * from AttrValueSKU where ProductId=@ProductId";

            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.WfxRW, CommandType.Text, sqlStr, _param))
            {
                while (dr.Read())
                {
                    Obj.Add(Populate_AttrValueSKUEntity_FromDr(dr));
                }
            }
            return Obj;
        }

		/// <summary>
		/// 得到数据表AttrValueSKU所有记录
		/// </summary>
		/// <returns>数据集</returns>
		public IList< AttrValueSKUEntity> Get_AttrValueSKUAll()
		{
			IList< AttrValueSKUEntity> Obj=new List< AttrValueSKUEntity>();
			string sqlStr="select * from AttrValueSKU";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.WfxRW,CommandType.Text,sqlStr))
			{
				while(dr.Read())
				{
					Obj.Add(Populate_AttrValueSKUEntity_FromDr(dr));
				}
			}
			return Obj;
		}
		/// <summary>
        /// 检测是否存在根据主键
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>是/否</returns>
		public bool IsExistAttrValueSKU(int id)
		{
			SqlParameter[] _param={
                                      new SqlParameter("@id",SqlDbType.Int)
                                  };
            _param[0].Value=id;
            string sqlStr="select Count(*) from AttrValueSKU where Id=@id";
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
