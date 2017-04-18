// =================================================================== 
// 项目说明
//====================================================================
// yangxg。@Copy Right 2014
// 文件： ProductCls.cs
// 项目名称：买车网
// 创建时间：2016/4/3
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
    /// 数据层实例化接口类 dbo.ProductCls.
    /// </summary>
    public partial class ProductClsDataAccessLayer 
    {
		#region 构造函数


		/// <summary>
		/// 
		/// </summary>
		public ProductClsDataAccessLayer()
		{
		}
		#endregion

        #region -----------实例化接口函数----------- 
		
		#region 添加更新删除
		/// <summary>
		/// 向数据库中插入一条新记录。
		/// </summary>
		/// <param name="_ProductClsModel">ProductCls实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(ProductClsEntity _ProductClsModel)
		{
            string sqlStr = "insert into ProductCls([ShopId],[Clsname],[ParentId],[Status],[Addtime],[Updatetime],[orderby],[Image],[Description]) values(@ShopId,@Clsname,@ParentId,@Status,@Addtime,@Updatetime,@orderby,@Image,@Description) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@ShopId",SqlDbType.Int),
			new SqlParameter("@Clsname",SqlDbType.VarChar),
            new SqlParameter("@ParentId",SqlDbType.Int),
			new SqlParameter("@Status",SqlDbType.Int),
			new SqlParameter("@Addtime",SqlDbType.DateTime),
			new SqlParameter("@Updatetime",SqlDbType.DateTime),
			new SqlParameter("@orderby",SqlDbType.Int),
			new SqlParameter("@Image",SqlDbType.VarChar),
			new SqlParameter("@Description",SqlDbType.VarChar)
			};			
			_param[0].Value=_ProductClsModel.ShopId;
			_param[1].Value=_ProductClsModel.Clsname;
            _param[2].Value =_ProductClsModel.ParentId;
			_param[3].Value=_ProductClsModel.Status;
			_param[4].Value=_ProductClsModel.Addtime;
			_param[5].Value=_ProductClsModel.Updatetime;
			_param[6].Value=_ProductClsModel.orderby;
			_param[7].Value=_ProductClsModel.Image;
			_param[8].Value=_ProductClsModel.Description;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.WfxRW,CommandType.Text,sqlStr,_param));
			return res;
		}
		/// <summary>
		/// 向数据库中插入一条新记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_ProductClsModel">ProductCls实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(SqlTransaction sp,ProductClsEntity _ProductClsModel)
		{
            string sqlStr = "insert into ProductCls([ShopId],[Clsname],[ParentId],[Status],[Addtime],[Updatetime],[orderby],[Image],[Description]) values(@ShopId,@Clsname,@ParentId,@Status,@Addtime,@Updatetime,@orderby,@Image,@Description) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@ShopId",SqlDbType.Int),
			new SqlParameter("@Clsname",SqlDbType.VarChar),
            new SqlParameter("@ParentId",SqlDbType.Int),
			new SqlParameter("@Status",SqlDbType.Int),
			new SqlParameter("@Addtime",SqlDbType.DateTime),
			new SqlParameter("@Updatetime",SqlDbType.DateTime),
			new SqlParameter("@orderby",SqlDbType.Int),
			new SqlParameter("@Image",SqlDbType.VarChar),
			new SqlParameter("@Description",SqlDbType.VarChar)
			};			
			_param[0].Value=_ProductClsModel.ShopId;
			_param[1].Value=_ProductClsModel.Clsname;
            _param[2].Value =_ProductClsModel.ParentId;
			_param[3].Value=_ProductClsModel.Status;
			_param[4].Value=_ProductClsModel.Addtime;
			_param[5].Value=_ProductClsModel.Updatetime;
			_param[6].Value=_ProductClsModel.orderby;
			_param[7].Value=_ProductClsModel.Image;
			_param[8].Value=_ProductClsModel.Description;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(sp,CommandType.Text,sqlStr,_param));
			return res;
		}


		/// <summary>
		/// 向数据表ProductCls更新一条记录。
		/// </summary>
		/// <param name="_ProductClsModel">_ProductClsModel</param>
		/// <returns>影响的行数</returns>
		public int Update(ProductClsEntity _ProductClsModel)
		{
            string sqlStr = "update ProductCls set [ShopId]=@ShopId,[Clsname]=@Clsname,[ParentId]=@ParentId,[Status]=@Status,[Addtime]=@Addtime,[Updatetime]=@Updatetime,[orderby]=@orderby,[Image]=@Image,[Description]=@Description where ClsId=@ClsId";
			SqlParameter[] _param={				
				new SqlParameter("@ClsId",SqlDbType.Int),
				new SqlParameter("@ShopId",SqlDbType.Int),
				new SqlParameter("@Clsname",SqlDbType.VarChar),
                new SqlParameter("@ParentId",SqlDbType.Int),
				new SqlParameter("@Status",SqlDbType.Int),
				new SqlParameter("@Addtime",SqlDbType.DateTime),
				new SqlParameter("@Updatetime",SqlDbType.DateTime),
				new SqlParameter("@orderby",SqlDbType.Int),
				new SqlParameter("@Image",SqlDbType.VarChar),
				new SqlParameter("@Description",SqlDbType.VarChar)
				};				
				_param[0].Value=_ProductClsModel.ClsId;
				_param[1].Value=_ProductClsModel.ShopId;
				_param[2].Value=_ProductClsModel.Clsname;
                _param[3].Value =_ProductClsModel.ParentId;
				_param[4].Value=_ProductClsModel.Status;
				_param[5].Value=_ProductClsModel.Addtime;
				_param[6].Value=_ProductClsModel.Updatetime;
				_param[7].Value=_ProductClsModel.orderby;
				_param[8].Value=_ProductClsModel.Image;
				_param[9].Value=_ProductClsModel.Description;
			return SqlHelper.ExecuteNonQuery(WebConfig.WfxRW,CommandType.Text,sqlStr,_param);
		}
		/// <summary>
		/// 向数据表ProductCls更新一条记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_ProductClsModel">_ProductClsModel</param>
		/// <returns>影响的行数</returns>
		public int Update(SqlTransaction sp,ProductClsEntity _ProductClsModel)
		{
            string sqlStr = "update ProductCls set [ShopId]=@ShopId,[Clsname]=@Clsname,[ParentId]=@ParentId,[Status]=@Status,[Addtime]=@Addtime,[Updatetime]=@Updatetime,[orderby]=@orderby,[Image]=@Image,[Description]=@Description where ClsId=@ClsId";
			SqlParameter[] _param={				
				new SqlParameter("@ClsId",SqlDbType.Int),
				new SqlParameter("@ShopId",SqlDbType.Int),
				new SqlParameter("@Clsname",SqlDbType.VarChar),
                new SqlParameter("@ParentId",SqlDbType.Int),
				new SqlParameter("@Status",SqlDbType.Int),
				new SqlParameter("@Addtime",SqlDbType.DateTime),
				new SqlParameter("@Updatetime",SqlDbType.DateTime),
				new SqlParameter("@orderby",SqlDbType.Int),
				new SqlParameter("@Image",SqlDbType.VarChar),
				new SqlParameter("@Description",SqlDbType.VarChar)
				};
            _param[0].Value = _ProductClsModel.ClsId;
            _param[1].Value = _ProductClsModel.ShopId;
            _param[2].Value = _ProductClsModel.Clsname;
            _param[3].Value = _ProductClsModel.ParentId;
            _param[4].Value = _ProductClsModel.Status;
            _param[5].Value = _ProductClsModel.Addtime;
            _param[6].Value = _ProductClsModel.Updatetime;
            _param[7].Value = _ProductClsModel.orderby;
            _param[8].Value = _ProductClsModel.Image;
            _param[9].Value = _ProductClsModel.Description;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}		
		
		
		/// <summary>
		/// 删除数据表ProductCls中的一条记录
		/// </summary>
	    /// <param name="ClsId">clsId</param>
		/// <returns>影响的行数</returns>
		public int Delete(int ClsId)
		{
			string sqlStr="delete from ProductCls where [ClsId]=@ClsId";
			SqlParameter[] _param={			
			new SqlParameter("@ClsId",SqlDbType.Int),
			
			};			
			_param[0].Value=ClsId;
			return SqlHelper.ExecuteNonQuery(WebConfig.WfxRW,CommandType.Text,sqlStr,_param);
		}
		
		/// <summary>
		/// 删除数据表ProductCls中的一条记录,带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
	    /// <param name="ClsId">clsId</param>
		/// <returns>影响的行数</returns>
		public int Delete(SqlTransaction sp,int ClsId)
		{
			string sqlStr="delete from ProductCls where [ClsId]=@ClsId";
			SqlParameter[] _param={			
			new SqlParameter("@ClsId",SqlDbType.Int),
			
			};			
			_param[0].Value=ClsId;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}
		#endregion
		
		#region 数据实体
		/// <summary>
		/// 得到  productcls 数据实体
		/// </summary>
		/// <param name="row">row</param>
		/// <returns>productcls 数据实体</returns>
		public ProductClsEntity Populate_ProductClsEntity_FromDr(DataRow row)
		{
			ProductClsEntity Obj = new ProductClsEntity();
			if(row!=null)
			{
				Obj.ClsId = (( row["ClsId"])==DBNull.Value)?0:Convert.ToInt32( row["ClsId"]);
				Obj.ShopId = (( row["ShopId"])==DBNull.Value)?0:Convert.ToInt32( row["ShopId"]);
				Obj.Clsname =  row["Clsname"].ToString();
                Obj.ParentId = ((row["ParentId"]) == DBNull.Value) ? 0 : Convert.ToInt32(row["ParentId"]);
				Obj.Status = (( row["Status"])==DBNull.Value)?0:Convert.ToInt32( row["Status"]);
				Obj.Addtime = (( row["Addtime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( row["Addtime"]);
				Obj.Updatetime = (( row["Updatetime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( row["Updatetime"]);
				Obj.orderby = (( row["orderby"])==DBNull.Value)?0:Convert.ToInt32( row["orderby"]);
				Obj.Image =  row["Image"].ToString();
				Obj.Description =  row["Description"].ToString();
			}
			else
			{
				return null;
			}
			return Obj;
		}
		
        /// <summary>
		/// 得到  productcls 数据实体
		/// </summary>
		/// <param name="dr">dr</param>
		/// <returns>productcls 数据实体</returns>
		public ProductClsEntity Populate_ProductClsEntity_FromDr(IDataReader dr)
		{
			ProductClsEntity Obj = new ProductClsEntity();
			
				Obj.ClsId = (( dr["ClsId"])==DBNull.Value)?0:Convert.ToInt32( dr["ClsId"]);
				Obj.ShopId = (( dr["ShopId"])==DBNull.Value)?0:Convert.ToInt32( dr["ShopId"]);
				Obj.Clsname =  dr["Clsname"].ToString();
                Obj.ParentId = ((dr["ParentId"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["ParentId"]);
				Obj.Status = (( dr["Status"])==DBNull.Value)?0:Convert.ToInt32( dr["Status"]);
				Obj.Addtime = (( dr["Addtime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( dr["Addtime"]);
				Obj.Updatetime = (( dr["Updatetime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( dr["Updatetime"]);
				Obj.orderby = (( dr["orderby"])==DBNull.Value)?0:Convert.ToInt32( dr["orderby"]);
				Obj.Image =  dr["Image"].ToString();
				Obj.Description =  dr["Description"].ToString();
			
			return Obj;
		}
		#endregion
		
		/// <summary>
		/// 根据ID,返回一个ProductCls对象
		/// </summary>
		/// <param name="clsId">clsId</param>
		/// <returns>ProductCls对象</returns>
		public ProductClsEntity Get_ProductClsEntity (int clsId)
		{
			ProductClsEntity _obj=null;
			SqlParameter[] _param={
			new SqlParameter("@ClsId",SqlDbType.Int)
			};
			_param[0].Value=clsId;
			string sqlStr="select * from ProductCls with(nolock) where ClsId=@ClsId";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.WfxRW,CommandType.Text,sqlStr,_param))
			{
				while(dr.Read())
				{
            		_obj=Populate_ProductClsEntity_FromDr(dr);
				}
			}
			return _obj;
		}
		/// <summary>
		/// 得到数据表ProductCls所有记录
		/// </summary>
		/// <returns>数据集</returns>
		public IList< ProductClsEntity> Get_ProductClsAll()
		{
			IList< ProductClsEntity> Obj=new List< ProductClsEntity>();
			string sqlStr="select * from ProductCls";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.WfxRW,CommandType.Text,sqlStr))
			{
				while(dr.Read())
				{
					Obj.Add(Populate_ProductClsEntity_FromDr(dr));
				}
			}
			return Obj;
		}
		/// <summary>
        /// 检测是否存在根据主键
        /// </summary>
        /// <param name="clsId">clsId</param>
        /// <returns>是/否</returns>
		public bool IsExistProductCls(int clsId)
		{
			SqlParameter[] _param={
                                      new SqlParameter("@clsId",SqlDbType.Int)
                                  };
            _param[0].Value=clsId;
            string sqlStr="select Count(*) from ProductCls where ClsId=@clsId";
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
