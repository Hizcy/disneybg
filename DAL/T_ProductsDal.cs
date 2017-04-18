// =================================================================== 
// 项目说明
//====================================================================
// yangxg。@Copy Right 2014
// 文件： T_Products.cs
// 项目名称：买车网
// 创建时间：2016/8/9
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
    /// 数据层实例化接口类 dbo.T_Products.
    /// </summary>
    public partial class T_ProductsDataAccessLayer 
    {
		#region 构造函数


		/// <summary>
		/// 
		/// </summary>
		public T_ProductsDataAccessLayer()
		{
		}
		#endregion

        #region -----------实例化接口函数-----------
		
		#region 添加更新删除
		/// <summary>
		/// 向数据库中插入一条新记录。
		/// </summary>
		/// <param name="_T_ProductsModel">T_Products实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(T_ProductsEntity _T_ProductsModel)
		{
			string sqlStr="insert into T_Products([ShopId],[CategoryId],[Name],[Intro],[Description],[Image1],[Image2],[Image3],[Image4],[Image5],[CostPrice],[SalePrice],[Commission],[Status],[AddTime],[UpdateTime],[OrderBy],[IsCommission],[ProductCode],[Stock],[OriginPrice],[IsNew],[IsHot],[GroupNumber],[GroupPrice]) values(@ShopId,@CategoryId,@Name,@Intro,@Description,@Image1,@Image2,@Image3,@Image4,@Image5,@CostPrice,@SalePrice,@Commission,@Status,@AddTime,@UpdateTime,@OrderBy,@IsCommission,@ProductCode,@Stock,@OriginPrice,@IsNew,@IsHot,@GroupNumber,@GroupPrice) select @@identity";
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
			new SqlParameter("@GroupNumber",SqlDbType.Int),
			new SqlParameter("@GroupPrice",SqlDbType.Decimal)
			};			
			_param[0].Value=_T_ProductsModel.ShopId;
			_param[1].Value=_T_ProductsModel.CategoryId;
			_param[2].Value=_T_ProductsModel.Name;
			_param[3].Value=_T_ProductsModel.Intro;
			_param[4].Value=_T_ProductsModel.Description;
			_param[5].Value=_T_ProductsModel.Image1;
			_param[6].Value=_T_ProductsModel.Image2;
			_param[7].Value=_T_ProductsModel.Image3;
			_param[8].Value=_T_ProductsModel.Image4;
			_param[9].Value=_T_ProductsModel.Image5;
			_param[10].Value=_T_ProductsModel.CostPrice;
			_param[11].Value=_T_ProductsModel.SalePrice;
			_param[12].Value=_T_ProductsModel.Commission;
			_param[13].Value=_T_ProductsModel.Status;
			_param[14].Value=_T_ProductsModel.AddTime;
			_param[15].Value=_T_ProductsModel.UpdateTime;
			_param[16].Value=_T_ProductsModel.OrderBy;
			_param[17].Value=_T_ProductsModel.IsCommission;
			_param[18].Value=_T_ProductsModel.ProductCode;
			_param[19].Value=_T_ProductsModel.Stock;
			_param[20].Value=_T_ProductsModel.OriginPrice;
			_param[21].Value=_T_ProductsModel.IsNew;
			_param[22].Value=_T_ProductsModel.IsHot;
			_param[23].Value=_T_ProductsModel.GroupNumber;
			_param[24].Value=_T_ProductsModel.GroupPrice;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.WfxRW,CommandType.Text,sqlStr,_param));
			return res;
		}
		/// <summary>
		/// 向数据库中插入一条新记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_T_ProductsModel">T_Products实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(SqlTransaction sp,T_ProductsEntity _T_ProductsModel)
		{
			string sqlStr="insert into T_Products([ShopId],[CategoryId],[Name],[Intro],[Description],[Image1],[Image2],[Image3],[Image4],[Image5],[CostPrice],[SalePrice],[Commission],[Status],[AddTime],[UpdateTime],[OrderBy],[IsCommission],[ProductCode],[Stock],[OriginPrice],[IsNew],[IsHot],[GroupNumber],[GroupPrice]) values(@ShopId,@CategoryId,@Name,@Intro,@Description,@Image1,@Image2,@Image3,@Image4,@Image5,@CostPrice,@SalePrice,@Commission,@Status,@AddTime,@UpdateTime,@OrderBy,@IsCommission,@ProductCode,@Stock,@OriginPrice,@IsNew,@IsHot,@GroupNumber,@GroupPrice) select @@identity";
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
			new SqlParameter("@GroupNumber",SqlDbType.Int),
			new SqlParameter("@GroupPrice",SqlDbType.Decimal)
			};			
			_param[0].Value=_T_ProductsModel.ShopId;
			_param[1].Value=_T_ProductsModel.CategoryId;
			_param[2].Value=_T_ProductsModel.Name;
			_param[3].Value=_T_ProductsModel.Intro;
			_param[4].Value=_T_ProductsModel.Description;
			_param[5].Value=_T_ProductsModel.Image1;
			_param[6].Value=_T_ProductsModel.Image2;
			_param[7].Value=_T_ProductsModel.Image3;
			_param[8].Value=_T_ProductsModel.Image4;
			_param[9].Value=_T_ProductsModel.Image5;
			_param[10].Value=_T_ProductsModel.CostPrice;
			_param[11].Value=_T_ProductsModel.SalePrice;
			_param[12].Value=_T_ProductsModel.Commission;
			_param[13].Value=_T_ProductsModel.Status;
			_param[14].Value=_T_ProductsModel.AddTime;
			_param[15].Value=_T_ProductsModel.UpdateTime;
			_param[16].Value=_T_ProductsModel.OrderBy;
			_param[17].Value=_T_ProductsModel.IsCommission;
			_param[18].Value=_T_ProductsModel.ProductCode;
			_param[19].Value=_T_ProductsModel.Stock;
			_param[20].Value=_T_ProductsModel.OriginPrice;
			_param[21].Value=_T_ProductsModel.IsNew;
			_param[22].Value=_T_ProductsModel.IsHot;
			_param[23].Value=_T_ProductsModel.GroupNumber;
			_param[24].Value=_T_ProductsModel.GroupPrice;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(sp,CommandType.Text,sqlStr,_param));
			return res;
		}


		/// <summary>
		/// 向数据表T_Products更新一条记录。
		/// </summary>
		/// <param name="_T_ProductsModel">_T_ProductsModel</param>
		/// <returns>影响的行数</returns>
		public int Update(T_ProductsEntity _T_ProductsModel)
		{
            string sqlStr="update T_Products set [ShopId]=@ShopId,[CategoryId]=@CategoryId,[Name]=@Name,[Intro]=@Intro,[Description]=@Description,[Image1]=@Image1,[Image2]=@Image2,[Image3]=@Image3,[Image4]=@Image4,[Image5]=@Image5,[CostPrice]=@CostPrice,[SalePrice]=@SalePrice,[Commission]=@Commission,[Status]=@Status,[AddTime]=@AddTime,[UpdateTime]=@UpdateTime,[OrderBy]=@OrderBy,[IsCommission]=@IsCommission,[ProductCode]=@ProductCode,[Stock]=@Stock,[OriginPrice]=@OriginPrice,[IsNew]=@IsNew,[IsHot]=@IsHot,[GroupNumber]=@GroupNumber,[GroupPrice]=@GroupPrice where ProductId=@ProductId";
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
				new SqlParameter("@GroupNumber",SqlDbType.Int),
				new SqlParameter("@GroupPrice",SqlDbType.Decimal)
				};				
				_param[0].Value=_T_ProductsModel.ProductId;
				_param[1].Value=_T_ProductsModel.ShopId;
				_param[2].Value=_T_ProductsModel.CategoryId;
				_param[3].Value=_T_ProductsModel.Name;
				_param[4].Value=_T_ProductsModel.Intro;
				_param[5].Value=_T_ProductsModel.Description;
				_param[6].Value=_T_ProductsModel.Image1;
				_param[7].Value=_T_ProductsModel.Image2;
				_param[8].Value=_T_ProductsModel.Image3;
				_param[9].Value=_T_ProductsModel.Image4;
				_param[10].Value=_T_ProductsModel.Image5;
				_param[11].Value=_T_ProductsModel.CostPrice;
				_param[12].Value=_T_ProductsModel.SalePrice;
				_param[13].Value=_T_ProductsModel.Commission;
				_param[14].Value=_T_ProductsModel.Status;
				_param[15].Value=_T_ProductsModel.AddTime;
				_param[16].Value=_T_ProductsModel.UpdateTime;
				_param[17].Value=_T_ProductsModel.OrderBy;
				_param[18].Value=_T_ProductsModel.IsCommission;
				_param[19].Value=_T_ProductsModel.ProductCode;
				_param[20].Value=_T_ProductsModel.Stock;
				_param[21].Value=_T_ProductsModel.OriginPrice;
				_param[22].Value=_T_ProductsModel.IsNew;
				_param[23].Value=_T_ProductsModel.IsHot;
				_param[24].Value=_T_ProductsModel.GroupNumber;
				_param[25].Value=_T_ProductsModel.GroupPrice;
			return SqlHelper.ExecuteNonQuery(WebConfig.WfxRW,CommandType.Text,sqlStr,_param);
		}
		/// <summary>
		/// 向数据表T_Products更新一条记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_T_ProductsModel">_T_ProductsModel</param>
		/// <returns>影响的行数</returns>
		public int Update(SqlTransaction sp,T_ProductsEntity _T_ProductsModel)
		{
            string sqlStr="update T_Products set [ShopId]=@ShopId,[CategoryId]=@CategoryId,[Name]=@Name,[Intro]=@Intro,[Description]=@Description,[Image1]=@Image1,[Image2]=@Image2,[Image3]=@Image3,[Image4]=@Image4,[Image5]=@Image5,[CostPrice]=@CostPrice,[SalePrice]=@SalePrice,[Commission]=@Commission,[Status]=@Status,[AddTime]=@AddTime,[UpdateTime]=@UpdateTime,[OrderBy]=@OrderBy,[IsCommission]=@IsCommission,[ProductCode]=@ProductCode,[Stock]=@Stock,[OriginPrice]=@OriginPrice,[IsNew]=@IsNew,[IsHot]=@IsHot,[GroupNumber]=@GroupNumber,[GroupPrice]=@GroupPrice where ProductId=@ProductId";
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
				new SqlParameter("@GroupNumber",SqlDbType.Int),
				new SqlParameter("@GroupPrice",SqlDbType.Decimal)
				};				
				_param[0].Value=_T_ProductsModel.ProductId;
				_param[1].Value=_T_ProductsModel.ShopId;
				_param[2].Value=_T_ProductsModel.CategoryId;
				_param[3].Value=_T_ProductsModel.Name;
				_param[4].Value=_T_ProductsModel.Intro;
				_param[5].Value=_T_ProductsModel.Description;
				_param[6].Value=_T_ProductsModel.Image1;
				_param[7].Value=_T_ProductsModel.Image2;
				_param[8].Value=_T_ProductsModel.Image3;
				_param[9].Value=_T_ProductsModel.Image4;
				_param[10].Value=_T_ProductsModel.Image5;
				_param[11].Value=_T_ProductsModel.CostPrice;
				_param[12].Value=_T_ProductsModel.SalePrice;
				_param[13].Value=_T_ProductsModel.Commission;
				_param[14].Value=_T_ProductsModel.Status;
				_param[15].Value=_T_ProductsModel.AddTime;
				_param[16].Value=_T_ProductsModel.UpdateTime;
				_param[17].Value=_T_ProductsModel.OrderBy;
				_param[18].Value=_T_ProductsModel.IsCommission;
				_param[19].Value=_T_ProductsModel.ProductCode;
				_param[20].Value=_T_ProductsModel.Stock;
				_param[21].Value=_T_ProductsModel.OriginPrice;
				_param[22].Value=_T_ProductsModel.IsNew;
				_param[23].Value=_T_ProductsModel.IsHot;
				_param[24].Value=_T_ProductsModel.GroupNumber;
				_param[25].Value=_T_ProductsModel.GroupPrice;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}		
		
		
		/// <summary>
		/// 删除数据表T_Products中的一条记录
		/// </summary>
	    /// <param name="ProductId">productId</param>
		/// <returns>影响的行数</returns>
		public int Delete(int ProductId)
		{
			string sqlStr="delete from T_Products where [ProductId]=@ProductId";
			SqlParameter[] _param={			
			new SqlParameter("@ProductId",SqlDbType.Int),
			
			};			
			_param[0].Value=ProductId;
			return SqlHelper.ExecuteNonQuery(WebConfig.WfxRW,CommandType.Text,sqlStr,_param);
		}
		
		/// <summary>
		/// 删除数据表T_Products中的一条记录,带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
	    /// <param name="ProductId">productId</param>
		/// <returns>影响的行数</returns>
		public int Delete(SqlTransaction sp,int ProductId)
		{
			string sqlStr="delete from T_Products where [ProductId]=@ProductId";
			SqlParameter[] _param={			
			new SqlParameter("@ProductId",SqlDbType.Int),
			
			};			
			_param[0].Value=ProductId;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}
		#endregion
		
		#region 数据实体
		/// <summary>
		/// 得到  t_products 数据实体
		/// </summary>
		/// <param name="row">row</param>
		/// <returns>t_products 数据实体</returns>
		public T_ProductsEntity Populate_T_ProductsEntity_FromDr(DataRow row)
		{
			T_ProductsEntity Obj = new T_ProductsEntity();
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
				Obj.OriginPrice = (( row["OriginPrice"])==DBNull.Value)?0:Convert.ToDecimal( row["OriginPrice"]);
				Obj.IsNew = (( row["IsNew"])==DBNull.Value)?0:Convert.ToInt32( row["IsNew"]);
				Obj.IsHot = (( row["IsHot"])==DBNull.Value)?0:Convert.ToInt32( row["IsHot"]);
				Obj.GroupNumber = (( row["GroupNumber"])==DBNull.Value)?0:Convert.ToInt32( row["GroupNumber"]);
				Obj.GroupPrice = (( row["GroupPrice"])==DBNull.Value)?0:Convert.ToDecimal( row["GroupPrice"]);
			}
			else
			{
				return null;
			}
			return Obj;
		}
		
        /// <summary>
		/// 得到  t_products 数据实体
		/// </summary>
		/// <param name="dr">dr</param>
		/// <returns>t_products 数据实体</returns>
		public T_ProductsEntity Populate_T_ProductsEntity_FromDr(IDataReader dr)
		{
			T_ProductsEntity Obj = new T_ProductsEntity();
			
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
				Obj.OriginPrice = (( dr["OriginPrice"])==DBNull.Value)?0:Convert.ToDecimal( dr["OriginPrice"]);
				Obj.IsNew = (( dr["IsNew"])==DBNull.Value)?0:Convert.ToInt32( dr["IsNew"]);
				Obj.IsHot = (( dr["IsHot"])==DBNull.Value)?0:Convert.ToInt32( dr["IsHot"]);
				Obj.GroupNumber = (( dr["GroupNumber"])==DBNull.Value)?0:Convert.ToInt32( dr["GroupNumber"]);
				Obj.GroupPrice = (( dr["GroupPrice"])==DBNull.Value)?0:Convert.ToDecimal( dr["GroupPrice"]);
			
			return Obj;
		}
		#endregion
		
		/// <summary>
		/// 根据ID,返回一个T_Products对象
		/// </summary>
		/// <param name="productId">productId</param>
		/// <returns>T_Products对象</returns>
		public T_ProductsEntity Get_T_ProductsEntity (int productId)
		{
			T_ProductsEntity _obj=null;
			SqlParameter[] _param={
			new SqlParameter("@ProductId",SqlDbType.Int)
			};
			_param[0].Value=productId;
			string sqlStr="select * from T_Products with(nolock) where ProductId=@ProductId";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.WfxRW,CommandType.Text,sqlStr,_param))
			{
				while(dr.Read())
				{
            		_obj=Populate_T_ProductsEntity_FromDr(dr);
				}
			}
			return _obj;
		}
		/// <summary>
		/// 得到数据表T_Products所有记录
		/// </summary>
		/// <returns>数据集</returns>
		public IList< T_ProductsEntity> Get_T_ProductsAll()
		{
			IList< T_ProductsEntity> Obj=new List< T_ProductsEntity>();
			string sqlStr="select * from T_Products";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.WfxRW,CommandType.Text,sqlStr))
			{
				while(dr.Read())
				{
					Obj.Add(Populate_T_ProductsEntity_FromDr(dr));
				}
			}
			return Obj;
		}
		/// <summary>
        /// 检测是否存在根据主键
        /// </summary>
        /// <param name="productId">productId</param>
        /// <returns>是/否</returns>
		public bool IsExistT_Products(int productId)
		{
			SqlParameter[] _param={
                                      new SqlParameter("@productId",SqlDbType.Int)
                                  };
            _param[0].Value=productId;
            string sqlStr="select Count(*) from T_Products where ProductId=@productId";
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
