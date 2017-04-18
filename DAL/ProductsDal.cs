// =================================================================== 
// 项目说明
//====================================================================
// yangxg。@Copy Right 2014
// 文件： Products.cs
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
    /// 数据层实例化接口类 dbo.Products.
    /// </summary>
    public partial class ProductsDataAccessLayer 
    {
		#region 构造函数


		/// <summary>
		/// 
		/// </summary>
		public ProductsDataAccessLayer()
		{
		}
		#endregion

        #region -----------实例化接口函数-----------
		
		#region 添加更新删除
		/// <summary>
		/// 向数据库中插入一条新记录。
		/// </summary>
		/// <param name="_ProductsModel">Products实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(ProductsEntity _ProductsModel) 
		{
            string sqlStr = "insert into Products([ShopId],[CategoryId],[Name],[Intro],[Description],[Image1],[Image2],[Image3],[Image4],[Image5],[CostPrice],[SalePrice],[Commission],[Status],[AddTime],[UpdateTime],[OrderBy],[IsCommission],[ProductCode],[Stock],[OriginPrice],[IsNew],[IsHot],[CategoryId2]) values(@ShopId,@CategoryId,@Name,@Intro,@Description,@Image1,@Image2,@Image3,@Image4,@Image5,@CostPrice,@SalePrice,@Commission,@Status,@AddTime,@UpdateTime,@OrderBy,@IsCommission,@ProductCode,@Stock,@OriginPrice,@IsNew,@IsHot,@CategoryId2) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@ShopId",SqlDbType.Int),
			new SqlParameter("@CategoryId",SqlDbType.Int),
			new SqlParameter("@Name",SqlDbType.VarChar),
			new SqlParameter("@Intro",SqlDbType.VarChar),
			new SqlParameter("@Description",SqlDbType.VarChar),
			new SqlParameter("@Image1",SqlDbType.VarChar),
			new SqlParameter("@Image2",SqlDbType.VarChar),
			new SqlParameter("@Image3",SqlDbType.VarChar),
			new SqlParameter("@Image4",SqlDbType.VarChar),
			new SqlParameter("@Image5",SqlDbType.VarChar),
			new SqlParameter("@CostPrice",SqlDbType.Decimal),
			new SqlParameter("@SalePrice",SqlDbType.Decimal),
			new SqlParameter("@Commission",SqlDbType.Decimal),
			new SqlParameter("@Status",SqlDbType.Int),
			new SqlParameter("@AddTime",SqlDbType.DateTime),
			new SqlParameter("@UpdateTime",SqlDbType.DateTime),
			new SqlParameter("@OrderBy",SqlDbType.Int),
			new SqlParameter("@IsCommission",SqlDbType.Int),
			new SqlParameter("@ProductCode",SqlDbType.VarChar),
			new SqlParameter("@Stock",SqlDbType.Int),
            new SqlParameter("@OriginPrice",SqlDbType.Decimal),
            new SqlParameter("@IsNew",SqlDbType.Int),
            new SqlParameter("@IsHot",SqlDbType.Int),
            new SqlParameter("@CategoryId2",SqlDbType.Int)
			};			
			_param[0].Value=_ProductsModel.ShopId;
			_param[1].Value=_ProductsModel.CategoryId;
			_param[2].Value=_ProductsModel.Name;
			_param[3].Value=_ProductsModel.Intro;
			_param[4].Value=_ProductsModel.Description;
			_param[5].Value=_ProductsModel.Image1;
			_param[6].Value=_ProductsModel.Image2;
			_param[7].Value=_ProductsModel.Image3;
			_param[8].Value=_ProductsModel.Image4;
			_param[9].Value=_ProductsModel.Image5;
			_param[10].Value=_ProductsModel.CostPrice;
			_param[11].Value=_ProductsModel.SalePrice;
			_param[12].Value=_ProductsModel.Commission;
			_param[13].Value=_ProductsModel.Status;
			_param[14].Value=_ProductsModel.AddTime;
			_param[15].Value=_ProductsModel.UpdateTime;
			_param[16].Value=_ProductsModel.OrderBy;
			_param[17].Value=_ProductsModel.IsCommission;
			_param[18].Value=_ProductsModel.ProductCode;
			_param[19].Value=_ProductsModel.Stock;
            _param[20].Value = _ProductsModel.OriginPrice;
            _param[21].Value = _ProductsModel.IsNew;
            _param[22].Value = _ProductsModel.IsHot;
            _param[23].Value = _ProductsModel.CategoryId2;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.WfxRW,CommandType.Text,sqlStr,_param));
			return res;
		}
		/// <summary>
		/// 向数据库中插入一条新记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_ProductsModel">Products实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(SqlTransaction sp,ProductsEntity _ProductsModel)
		{
            string sqlStr = "insert into Products([ShopId],[CategoryId],[Name],[Intro],[Description],[Image1],[Image2],[Image3],[Image4],[Image5],[CostPrice],[SalePrice],[Commission],[Status],[AddTime],[UpdateTime],[OrderBy],[IsCommission],[ProductCode],[Stock],[OriginPrice],[IsNew],[IsHot],[CategoryId2]) values(@ShopId,@CategoryId,@Name,@Intro,@Description,@Image1,@Image2,@Image3,@Image4,@Image5,@CostPrice,@SalePrice,@Commission,@Status,@AddTime,@UpdateTime,@OrderBy,@IsCommission,@ProductCode,@Stock,@OriginPrice,@IsNew,@IsHot,@CategoryId2) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@ShopId",SqlDbType.Int),
			new SqlParameter("@CategoryId",SqlDbType.Int),
			new SqlParameter("@Name",SqlDbType.VarChar),
			new SqlParameter("@Intro",SqlDbType.VarChar),
			new SqlParameter("@Description",SqlDbType.VarChar),
			new SqlParameter("@Image1",SqlDbType.VarChar),
			new SqlParameter("@Image2",SqlDbType.VarChar),
			new SqlParameter("@Image3",SqlDbType.VarChar),
			new SqlParameter("@Image4",SqlDbType.VarChar),
			new SqlParameter("@Image5",SqlDbType.VarChar),
			new SqlParameter("@CostPrice",SqlDbType.Decimal),
			new SqlParameter("@SalePrice",SqlDbType.Decimal),
			new SqlParameter("@Commission",SqlDbType.Decimal),
			new SqlParameter("@Status",SqlDbType.Int),
			new SqlParameter("@AddTime",SqlDbType.DateTime),
			new SqlParameter("@UpdateTime",SqlDbType.DateTime),
			new SqlParameter("@OrderBy",SqlDbType.Int),
			new SqlParameter("@IsCommission",SqlDbType.Int),
			new SqlParameter("@ProductCode",SqlDbType.VarChar),
			new SqlParameter("@Stock",SqlDbType.Int),
			new SqlParameter("@OriginPrice",SqlDbType.Decimal),
            new SqlParameter("@IsNew",SqlDbType.Int),
            new SqlParameter("@IsHot",SqlDbType.Int),
            new SqlParameter("@CategoryId2",SqlDbType.Int)
			};			
			_param[0].Value=_ProductsModel.ShopId;
			_param[1].Value=_ProductsModel.CategoryId;
			_param[2].Value=_ProductsModel.Name;
			_param[3].Value=_ProductsModel.Intro;
			_param[4].Value=_ProductsModel.Description;
			_param[5].Value=_ProductsModel.Image1;
			_param[6].Value=_ProductsModel.Image2;
			_param[7].Value=_ProductsModel.Image3;
			_param[8].Value=_ProductsModel.Image4;
			_param[9].Value=_ProductsModel.Image5;
			_param[10].Value=_ProductsModel.CostPrice;
			_param[11].Value=_ProductsModel.SalePrice;
			_param[12].Value=_ProductsModel.Commission;
			_param[13].Value=_ProductsModel.Status;
			_param[14].Value=_ProductsModel.AddTime;
			_param[15].Value=_ProductsModel.UpdateTime;
			_param[16].Value=_ProductsModel.OrderBy;
			_param[17].Value=_ProductsModel.IsCommission;
			_param[18].Value=_ProductsModel.ProductCode;
			_param[19].Value=_ProductsModel.Stock;
            _param[20].Value = _ProductsModel.OriginPrice;
            _param[21].Value = _ProductsModel.IsNew;
            _param[22].Value = _ProductsModel.IsHot;
            _param[23].Value = _ProductsModel.CategoryId2;
            res = Convert.ToInt32(SqlHelper.ExecuteScalar(sp,CommandType.Text,sqlStr,_param));
			return res;
		}


		/// <summary>
		/// 向数据表Products更新一条记录。
		/// </summary>
		/// <param name="_ProductsModel">_ProductsModel</param>
		/// <returns>影响的行数</returns>
		public int Update(ProductsEntity _ProductsModel)
		{
            string sqlStr = "update Products set [ShopId]=@ShopId,[CategoryId]=@CategoryId,[Name]=@Name,[Intro]=@Intro,[Description]=@Description,[Image1]=@Image1,[Image2]=@Image2,[Image3]=@Image3,[Image4]=@Image4,[Image5]=@Image5,[CostPrice]=@CostPrice,[SalePrice]=@SalePrice,[Commission]=@Commission,[Status]=@Status,[AddTime]=@AddTime,[UpdateTime]=@UpdateTime,[OrderBy]=@OrderBy,[IsCommission]=@IsCommission,[ProductCode]=@ProductCode,[Stock]=@Stock,[OriginPrice]=@OriginPrice,[IsNew]=@IsNew,[IsHot]=@IsHot,[CategoryId2]=@CategoryId2 where ProductId=@ProductId";
			SqlParameter[] _param={				
				new SqlParameter("@ProductId",SqlDbType.Int),
				new SqlParameter("@ShopId",SqlDbType.Int),
				new SqlParameter("@CategoryId",SqlDbType.Int),
				new SqlParameter("@Name",SqlDbType.VarChar),
				new SqlParameter("@Intro",SqlDbType.VarChar),
				new SqlParameter("@Description",SqlDbType.VarChar),
				new SqlParameter("@Image1",SqlDbType.VarChar),
				new SqlParameter("@Image2",SqlDbType.VarChar),
				new SqlParameter("@Image3",SqlDbType.VarChar),
				new SqlParameter("@Image4",SqlDbType.VarChar),
				new SqlParameter("@Image5",SqlDbType.VarChar),
				new SqlParameter("@CostPrice",SqlDbType.Decimal),
				new SqlParameter("@SalePrice",SqlDbType.Decimal),
				new SqlParameter("@Commission",SqlDbType.Decimal),
				new SqlParameter("@Status",SqlDbType.Int),
				new SqlParameter("@AddTime",SqlDbType.DateTime),
				new SqlParameter("@UpdateTime",SqlDbType.DateTime),
				new SqlParameter("@OrderBy",SqlDbType.Int),
				new SqlParameter("@IsCommission",SqlDbType.Int),
				new SqlParameter("@ProductCode",SqlDbType.VarChar),
				new SqlParameter("@Stock",SqlDbType.Int),
			    new SqlParameter("@OriginPrice",SqlDbType.Decimal),
                new SqlParameter("@IsNew",SqlDbType.Int),
                new SqlParameter("@IsHot",SqlDbType.Int),
                new SqlParameter("@CategoryId2",SqlDbType.Int)
				};				
				_param[0].Value=_ProductsModel.ProductId;
				_param[1].Value=_ProductsModel.ShopId;
				_param[2].Value=_ProductsModel.CategoryId;
				_param[3].Value=_ProductsModel.Name;
				_param[4].Value=_ProductsModel.Intro;
				_param[5].Value=_ProductsModel.Description;
				_param[6].Value=_ProductsModel.Image1;
				_param[7].Value=_ProductsModel.Image2;
				_param[8].Value=_ProductsModel.Image3;
				_param[9].Value=_ProductsModel.Image4;
				_param[10].Value=_ProductsModel.Image5;
				_param[11].Value=_ProductsModel.CostPrice;
				_param[12].Value=_ProductsModel.SalePrice;
				_param[13].Value=_ProductsModel.Commission;
				_param[14].Value=_ProductsModel.Status;
				_param[15].Value=_ProductsModel.AddTime;
				_param[16].Value=_ProductsModel.UpdateTime;
				_param[17].Value=_ProductsModel.OrderBy;
				_param[18].Value=_ProductsModel.IsCommission;
				_param[19].Value=_ProductsModel.ProductCode;
				_param[20].Value=_ProductsModel.Stock;
                _param[21].Value = _ProductsModel.OriginPrice;
                _param[22].Value = _ProductsModel.IsNew;
                _param[23].Value = _ProductsModel.IsHot;
                _param[24].Value = _ProductsModel.CategoryId2;
			return SqlHelper.ExecuteNonQuery(WebConfig.WfxRW,CommandType.Text,sqlStr,_param);
		}
		/// <summary>
		/// 向数据表Products更新一条记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_ProductsModel">_ProductsModel</param>
		/// <returns>影响的行数</returns>
		public int Update(SqlTransaction sp,ProductsEntity _ProductsModel)
		{
            string sqlStr = "update Products set [ShopId]=@ShopId,[CategoryId]=@CategoryId,[Name]=@Name,[Intro]=@Intro,[Description]=@Description,[Image1]=@Image1,[Image2]=@Image2,[Image3]=@Image3,[Image4]=@Image4,[Image5]=@Image5,[CostPrice]=@CostPrice,[SalePrice]=@SalePrice,[Commission]=@Commission,[Status]=@Status,[AddTime]=@AddTime,[UpdateTime]=@UpdateTime,[OrderBy]=@OrderBy,[IsCommission]=@IsCommission,[ProductCode]=@ProductCode,[Stock]=@Stock,[OriginPrice]=@OriginPrice,[IsNew]=@IsNew,[IsHot]=@IsHot,[CategoryId2]=@CategoryId2 where ProductId=@ProductId";
			SqlParameter[] _param={				
				new SqlParameter("@ProductId",SqlDbType.Int),
				new SqlParameter("@ShopId",SqlDbType.Int),
				new SqlParameter("@CategoryId",SqlDbType.Int),
				new SqlParameter("@Name",SqlDbType.VarChar),
				new SqlParameter("@Intro",SqlDbType.VarChar),
				new SqlParameter("@Description",SqlDbType.VarChar),
				new SqlParameter("@Image1",SqlDbType.VarChar),
				new SqlParameter("@Image2",SqlDbType.VarChar),
				new SqlParameter("@Image3",SqlDbType.VarChar),
				new SqlParameter("@Image4",SqlDbType.VarChar),
				new SqlParameter("@Image5",SqlDbType.VarChar),
				new SqlParameter("@CostPrice",SqlDbType.Decimal),
				new SqlParameter("@SalePrice",SqlDbType.Decimal),
				new SqlParameter("@Commission",SqlDbType.Decimal),
				new SqlParameter("@Status",SqlDbType.Int),
				new SqlParameter("@AddTime",SqlDbType.DateTime),
				new SqlParameter("@UpdateTime",SqlDbType.DateTime),
				new SqlParameter("@OrderBy",SqlDbType.Int),
				new SqlParameter("@IsCommission",SqlDbType.Int),
				new SqlParameter("@ProductCode",SqlDbType.VarChar),
				new SqlParameter("@Stock",SqlDbType.Int),
			    new SqlParameter("@OriginPrice",SqlDbType.Decimal),
                new SqlParameter("@IsNew",SqlDbType.Int),
                new SqlParameter("@IsHot",SqlDbType.Int),
                new SqlParameter("@CategoryId2",SqlDbType.Int)
				};				
				_param[0].Value=_ProductsModel.ProductId;
				_param[1].Value=_ProductsModel.ShopId;
				_param[2].Value=_ProductsModel.CategoryId;
				_param[3].Value=_ProductsModel.Name;
				_param[4].Value=_ProductsModel.Intro;
				_param[5].Value=_ProductsModel.Description;
				_param[6].Value=_ProductsModel.Image1;
				_param[7].Value=_ProductsModel.Image2;
				_param[8].Value=_ProductsModel.Image3;
				_param[9].Value=_ProductsModel.Image4;
				_param[10].Value=_ProductsModel.Image5;
				_param[11].Value=_ProductsModel.CostPrice;
				_param[12].Value=_ProductsModel.SalePrice;
				_param[13].Value=_ProductsModel.Commission;
				_param[14].Value=_ProductsModel.Status;
				_param[15].Value=_ProductsModel.AddTime;
				_param[16].Value=_ProductsModel.UpdateTime;
				_param[17].Value=_ProductsModel.OrderBy;
				_param[18].Value=_ProductsModel.IsCommission;
				_param[19].Value=_ProductsModel.ProductCode;
                _param[20].Value = _ProductsModel.Stock;
                _param[21].Value = _ProductsModel.OriginPrice;
                _param[22].Value = _ProductsModel.IsNew;
                _param[23].Value = _ProductsModel.IsHot;
                _param[24].Value = _ProductsModel.CategoryId2;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}		
		
		
		/// <summary>
		/// 删除数据表Products中的一条记录
		/// </summary>
	    /// <param name="ProductId">productId</param>
		/// <returns>影响的行数</returns>
		public int Delete(int ProductId)
		{
			string sqlStr="delete from Products where [ProductId]=@ProductId";
			SqlParameter[] _param={			
			new SqlParameter("@ProductId",SqlDbType.Int),
			
			};			
			_param[0].Value=ProductId;
			return SqlHelper.ExecuteNonQuery(WebConfig.WfxRW,CommandType.Text,sqlStr,_param);
		}
		
		/// <summary>
		/// 删除数据表Products中的一条记录,带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
	    /// <param name="ProductId">productId</param>
		/// <returns>影响的行数</returns>
		public int Delete(SqlTransaction sp,int ProductId)
		{
			string sqlStr="delete from Products where [ProductId]=@ProductId";
			SqlParameter[] _param={			
			new SqlParameter("@ProductId",SqlDbType.Int),
			
			};			
			_param[0].Value=ProductId;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}
		#endregion
		
		#region 数据实体
		/// <summary>
		/// 得到  products 数据实体
		/// </summary>
		/// <param name="row">row</param>
		/// <returns>products 数据实体</returns>
		public ProductsEntity Populate_ProductsEntity_FromDr(DataRow row)
		{
			ProductsEntity Obj = new ProductsEntity();
			if(row!=null)
			{
				Obj.ProductId = (( row["ProductId"])==DBNull.Value)?0:Convert.ToInt32( row["ProductId"]);
				Obj.ShopId = (( row["ShopId"])==DBNull.Value)?0:Convert.ToInt32( row["ShopId"]);
				Obj.CategoryId = (( row["CategoryId"])==DBNull.Value)?0:Convert.ToInt32( row["CategoryId"]);
				Obj.Name =  row["Name"].ToString();
				Obj.Intro =  row["Intro"].ToString();
				Obj.Description =  row["Description"].ToString();
				Obj.Image1 =  row["Image1"].ToString();
				Obj.Image2 =  row["Image2"].ToString();
				Obj.Image3 =  row["Image3"].ToString();
				Obj.Image4 =  row["Image4"].ToString();
				Obj.Image5 =  row["Image5"].ToString();
                Obj.OriginPrice = ((row["OriginPrice"]) == DBNull.Value) ? 0 : Convert.ToDecimal(row["OriginPrice"]);
				Obj.CostPrice = (( row["CostPrice"])==DBNull.Value)?0:Convert.ToDecimal( row["CostPrice"]);
				Obj.SalePrice = (( row["SalePrice"])==DBNull.Value)?0:Convert.ToDecimal( row["SalePrice"]);
				Obj.Commission = (( row["Commission"])==DBNull.Value)?0:Convert.ToDecimal( row["Commission"]);
				Obj.Status = (( row["Status"])==DBNull.Value)?0:Convert.ToInt32( row["Status"]);
				Obj.AddTime = (( row["AddTime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( row["AddTime"]);
				Obj.UpdateTime = (( row["UpdateTime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( row["UpdateTime"]);
				Obj.OrderBy = (( row["OrderBy"])==DBNull.Value)?0:Convert.ToInt32( row["OrderBy"]);
				Obj.IsCommission = (( row["IsCommission"])==DBNull.Value)?0:Convert.ToInt32( row["IsCommission"]);
				Obj.ProductCode =  row["ProductCode"].ToString();
				Obj.Stock = (( row["Stock"])==DBNull.Value)?0:Convert.ToInt32( row["Stock"]);

                Obj.IsNew = ((row["IsNew"]) == DBNull.Value) ? 0 : Convert.ToInt32(row["IsNew"]);
                Obj.IsHot = ((row["IsHot"]) == DBNull.Value) ? 0 : Convert.ToInt32(row["IsHot"]);
                Obj.CategoryId2 = ((row["CategoryId2"]) == DBNull.Value) ? 0 : Convert.ToInt32(row["CategoryId2"]);
			}
			else
			{
				return null;
			}
			return Obj;
		}
		
        /// <summary>
		/// 得到  products 数据实体
		/// </summary>
		/// <param name="dr">dr</param>
		/// <returns>products 数据实体</returns>
		public ProductsEntity Populate_ProductsEntity_FromDr(IDataReader dr)
		{
			ProductsEntity Obj = new ProductsEntity();
			
				Obj.ProductId = (( dr["ProductId"])==DBNull.Value)?0:Convert.ToInt32( dr["ProductId"]);
				Obj.ShopId = (( dr["ShopId"])==DBNull.Value)?0:Convert.ToInt32( dr["ShopId"]);
				Obj.CategoryId = (( dr["CategoryId"])==DBNull.Value)?0:Convert.ToInt32( dr["CategoryId"]);
				Obj.Name =  dr["Name"].ToString();
				Obj.Intro =  dr["Intro"].ToString();
				Obj.Description =  dr["Description"].ToString();
				Obj.Image1 =  dr["Image1"].ToString();
				Obj.Image2 =  dr["Image2"].ToString();
				Obj.Image3 =  dr["Image3"].ToString();
				Obj.Image4 =  dr["Image4"].ToString();
				Obj.Image5 =  dr["Image5"].ToString();
                Obj.OriginPrice = ((dr["OriginPrice"]) == DBNull.Value) ? 0 : Convert.ToDecimal(dr["OriginPrice"]);
			    Obj.CostPrice = (( dr["CostPrice"])==DBNull.Value)?0:Convert.ToDecimal( dr["CostPrice"]);
				Obj.SalePrice = (( dr["SalePrice"])==DBNull.Value)?0:Convert.ToDecimal( dr["SalePrice"]);
				Obj.Commission = (( dr["Commission"])==DBNull.Value)?0:Convert.ToDecimal( dr["Commission"]);
				Obj.Status = (( dr["Status"])==DBNull.Value)?0:Convert.ToInt32( dr["Status"]);
				Obj.AddTime = (( dr["AddTime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( dr["AddTime"]);
				Obj.UpdateTime = (( dr["UpdateTime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( dr["UpdateTime"]);
				Obj.OrderBy = (( dr["OrderBy"])==DBNull.Value)?0:Convert.ToInt32( dr["OrderBy"]);
				Obj.IsCommission = (( dr["IsCommission"])==DBNull.Value)?0:Convert.ToInt32( dr["IsCommission"]);
				Obj.ProductCode =  dr["ProductCode"].ToString();
				Obj.Stock = (( dr["Stock"])==DBNull.Value)?0:Convert.ToInt32( dr["Stock"]);

                Obj.IsNew = ((dr["IsNew"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["IsNew"]);
                Obj.IsHot = ((dr["IsHot"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["IsHot"]);
                Obj.CategoryId2 = ((dr["CategoryId2"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["CategoryId2"]);
			return Obj;
		}
		#endregion
		
		/// <summary>
		/// 根据ID,返回一个Products对象
		/// </summary>
		/// <param name="productId">productId</param>
		/// <returns>Products对象</returns>
		public ProductsEntity Get_ProductsEntity (int productId)
		{
			ProductsEntity _obj=null;
			SqlParameter[] _param={
			new SqlParameter("@ProductId",SqlDbType.Int)
			};
			_param[0].Value=productId;
			string sqlStr="select * from Products with(nolock) where ProductId=@ProductId";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.WfxRW,CommandType.Text,sqlStr,_param))
			{
				while(dr.Read())
				{
            		_obj=Populate_ProductsEntity_FromDr(dr);
				}
			}
			return _obj;
		}
		/// <summary>
		/// 得到数据表Products所有记录
		/// </summary>
		/// <returns>数据集</returns>
		public IList< ProductsEntity> Get_ProductsAll()
		{
			IList< ProductsEntity> Obj=new List< ProductsEntity>();
			string sqlStr="select * from Products";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.WfxRW,CommandType.Text,sqlStr))
			{
				while(dr.Read())
				{
					Obj.Add(Populate_ProductsEntity_FromDr(dr));
				}
			}
			return Obj;
		}
		/// <summary>
        /// 检测是否存在根据主键
        /// </summary>
        /// <param name="productId">productId</param>
        /// <returns>是/否</returns>
		public bool IsExistProducts(int productId)
		{
			SqlParameter[] _param={
                                      new SqlParameter("@productId",SqlDbType.Int)
                                  };
            _param[0].Value=productId;
            string sqlStr="select Count(*) from Products where ProductId=@productId";
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
