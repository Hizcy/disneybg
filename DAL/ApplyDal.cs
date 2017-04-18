// =================================================================== 
// 项目说明
//====================================================================
// yangxg。@Copy Right 2014
// 文件： Apply.cs
// 项目名称：买车网
// 创建时间：2016/4/2
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
    /// 数据层实例化接口类 dbo.Apply.
    /// </summary>
    public partial class ApplyDataAccessLayer 
    {
		#region 构造函数


		/// <summary>
		/// 
		/// </summary>
		public ApplyDataAccessLayer()
		{
		}
		#endregion

        #region -----------实例化接口函数-----------
		
		#region 添加更新删除
		/// <summary>
		/// 向数据库中插入一条新记录。
		/// </summary>
		/// <param name="_ApplyModel">Apply实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(ApplyEntity _ApplyModel)
		{
			string sqlStr="insert into Apply([ShopId],[OpenId],[Money],[Description],[BankId],[Status],[Reason],[Addtime],[Updatetime]) values(@ShopId,@OpenId,@Money,@Description,@BankId,@Status,@Reason,@Addtime,@Updatetime) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@ShopId",SqlDbType.Int),
			new SqlParameter("@OpenId",SqlDbType.VarChar),
			new SqlParameter("@Money",SqlDbType.Decimal),
			new SqlParameter("@Description",SqlDbType.VarChar),
			new SqlParameter("@BankId",SqlDbType.Int),
			new SqlParameter("@Status",SqlDbType.Int),
			new SqlParameter("@Reason",SqlDbType.VarChar),
			new SqlParameter("@Addtime",SqlDbType.DateTime),
			new SqlParameter("@Updatetime",SqlDbType.DateTime)
			};			
			_param[0].Value=_ApplyModel.ShopId;
			_param[1].Value=_ApplyModel.OpenId;
			_param[2].Value=_ApplyModel.Money;
			_param[3].Value=_ApplyModel.Description;
			_param[4].Value=_ApplyModel.BankId;
			_param[5].Value=_ApplyModel.Status;
			_param[6].Value=_ApplyModel.Reason;
			_param[7].Value=_ApplyModel.Addtime;
			_param[8].Value=_ApplyModel.Updatetime;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.WfxRW,CommandType.Text,sqlStr,_param));
			return res;
		}
		/// <summary>
		/// 向数据库中插入一条新记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_ApplyModel">Apply实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(SqlTransaction sp,ApplyEntity _ApplyModel)
		{
			string sqlStr="insert into Apply([ShopId],[OpenId],[Money],[Description],[BankId],[Status],[Reason],[Addtime],[Updatetime]) values(@ShopId,@OpenId,@Money,@Description,@BankId,@Status,@Reason,@Addtime,@Updatetime) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@ShopId",SqlDbType.Int),
			new SqlParameter("@OpenId",SqlDbType.VarChar),
			new SqlParameter("@Money",SqlDbType.Decimal),
			new SqlParameter("@Description",SqlDbType.VarChar),
			new SqlParameter("@BankId",SqlDbType.Int),
			new SqlParameter("@Status",SqlDbType.Int),
			new SqlParameter("@Reason",SqlDbType.VarChar),
			new SqlParameter("@Addtime",SqlDbType.DateTime),
			new SqlParameter("@Updatetime",SqlDbType.DateTime)
			};			
			_param[0].Value=_ApplyModel.ShopId;
			_param[1].Value=_ApplyModel.OpenId;
			_param[2].Value=_ApplyModel.Money;
			_param[3].Value=_ApplyModel.Description;
			_param[4].Value=_ApplyModel.BankId;
			_param[5].Value=_ApplyModel.Status;
			_param[6].Value=_ApplyModel.Reason;
			_param[7].Value=_ApplyModel.Addtime;
			_param[8].Value=_ApplyModel.Updatetime;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(sp,CommandType.Text,sqlStr,_param));
			return res;
		}


		/// <summary>
		/// 向数据表Apply更新一条记录。
		/// </summary>
		/// <param name="_ApplyModel">_ApplyModel</param>
		/// <returns>影响的行数</returns>
		public int Update(ApplyEntity _ApplyModel)
		{
            string sqlStr="update Apply set [ShopId]=@ShopId,[OpenId]=@OpenId,[Money]=@Money,[Description]=@Description,[BankId]=@BankId,[Status]=@Status,[Reason]=@Reason,[Addtime]=@Addtime,[Updatetime]=@Updatetime where ApplyId=@ApplyId";
			SqlParameter[] _param={				
				new SqlParameter("@ApplyId",SqlDbType.Int),
				new SqlParameter("@ShopId",SqlDbType.Int),
				new SqlParameter("@OpenId",SqlDbType.VarChar),
				new SqlParameter("@Money",SqlDbType.Decimal),
				new SqlParameter("@Description",SqlDbType.VarChar),
				new SqlParameter("@BankId",SqlDbType.Int),
				new SqlParameter("@Status",SqlDbType.Int),
				new SqlParameter("@Reason",SqlDbType.VarChar),
				new SqlParameter("@Addtime",SqlDbType.DateTime),
				new SqlParameter("@Updatetime",SqlDbType.DateTime)
				};				
				_param[0].Value=_ApplyModel.ApplyId;
				_param[1].Value=_ApplyModel.ShopId;
				_param[2].Value=_ApplyModel.OpenId;
				_param[3].Value=_ApplyModel.Money;
				_param[4].Value=_ApplyModel.Description;
				_param[5].Value=_ApplyModel.BankId;
				_param[6].Value=_ApplyModel.Status;
				_param[7].Value=_ApplyModel.Reason;
				_param[8].Value=_ApplyModel.Addtime;
				_param[9].Value=_ApplyModel.Updatetime;
			return SqlHelper.ExecuteNonQuery(WebConfig.WfxRW,CommandType.Text,sqlStr,_param);
		}
		/// <summary>
		/// 向数据表Apply更新一条记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_ApplyModel">_ApplyModel</param>
		/// <returns>影响的行数</returns>
		public int Update(SqlTransaction sp,ApplyEntity _ApplyModel)
		{
            string sqlStr="update Apply set [ShopId]=@ShopId,[OpenId]=@OpenId,[Money]=@Money,[Description]=@Description,[BankId]=@BankId,[Status]=@Status,[Reason]=@Reason,[Addtime]=@Addtime,[Updatetime]=@Updatetime where ApplyId=@ApplyId";
			SqlParameter[] _param={				
				new SqlParameter("@ApplyId",SqlDbType.Int),
				new SqlParameter("@ShopId",SqlDbType.Int),
				new SqlParameter("@OpenId",SqlDbType.VarChar),
				new SqlParameter("@Money",SqlDbType.Decimal),
				new SqlParameter("@Description",SqlDbType.VarChar),
				new SqlParameter("@BankId",SqlDbType.Int),
				new SqlParameter("@Status",SqlDbType.Int),
				new SqlParameter("@Reason",SqlDbType.VarChar),
				new SqlParameter("@Addtime",SqlDbType.DateTime),
				new SqlParameter("@Updatetime",SqlDbType.DateTime)
				};				
				_param[0].Value=_ApplyModel.ApplyId;
				_param[1].Value=_ApplyModel.ShopId;
				_param[2].Value=_ApplyModel.OpenId;
				_param[3].Value=_ApplyModel.Money;
				_param[4].Value=_ApplyModel.Description;
				_param[5].Value=_ApplyModel.BankId;
				_param[6].Value=_ApplyModel.Status;
				_param[7].Value=_ApplyModel.Reason;
				_param[8].Value=_ApplyModel.Addtime;
				_param[9].Value=_ApplyModel.Updatetime;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}		
		
		
		/// <summary>
		/// 删除数据表Apply中的一条记录
		/// </summary>
	    /// <param name="ApplyId">applyId</param>
		/// <returns>影响的行数</returns>
		public int Delete(int ApplyId)
		{
			string sqlStr="delete from Apply where [ApplyId]=@ApplyId";
			SqlParameter[] _param={			
			new SqlParameter("@ApplyId",SqlDbType.Int),
			
			};			
			_param[0].Value=ApplyId;
			return SqlHelper.ExecuteNonQuery(WebConfig.WfxRW,CommandType.Text,sqlStr,_param);
		}
		
		/// <summary>
		/// 删除数据表Apply中的一条记录,带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
	    /// <param name="ApplyId">applyId</param>
		/// <returns>影响的行数</returns>
		public int Delete(SqlTransaction sp,int ApplyId)
		{
			string sqlStr="delete from Apply where [ApplyId]=@ApplyId";
			SqlParameter[] _param={			
			new SqlParameter("@ApplyId",SqlDbType.Int),
			
			};			
			_param[0].Value=ApplyId;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}
		#endregion
		
		#region 数据实体
		/// <summary>
		/// 得到  apply 数据实体
		/// </summary>
		/// <param name="row">row</param>
		/// <returns>apply 数据实体</returns>
		public ApplyEntity Populate_ApplyEntity_FromDr(DataRow row)
		{
			ApplyEntity Obj = new ApplyEntity();
			if(row!=null)
			{
				Obj.ApplyId = (( row["ApplyId"])==DBNull.Value)?0:Convert.ToInt32( row["ApplyId"]);
				Obj.ShopId = (( row["ShopId"])==DBNull.Value)?0:Convert.ToInt32( row["ShopId"]);
				Obj.OpenId =  row["OpenId"].ToString();
				Obj.Money = (( row["Money"])==DBNull.Value)?0:Convert.ToDecimal( row["Money"]);
				Obj.Description =  row["Description"].ToString();
				Obj.BankId = (( row["BankId"])==DBNull.Value)?0:Convert.ToInt32( row["BankId"]);
				Obj.Status = (( row["Status"])==DBNull.Value)?0:Convert.ToInt32( row["Status"]);
				Obj.Reason =  row["Reason"].ToString();
				Obj.Addtime = (( row["Addtime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( row["Addtime"]);
				Obj.Updatetime = (( row["Updatetime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( row["Updatetime"]);
			}
			else
			{
				return null;
			}
			return Obj;
		}
		
        /// <summary>
		/// 得到  apply 数据实体
		/// </summary>
		/// <param name="dr">dr</param>
		/// <returns>apply 数据实体</returns>
		public ApplyEntity Populate_ApplyEntity_FromDr(IDataReader dr)
		{
			ApplyEntity Obj = new ApplyEntity();
			
				Obj.ApplyId = (( dr["ApplyId"])==DBNull.Value)?0:Convert.ToInt32( dr["ApplyId"]);
				Obj.ShopId = (( dr["ShopId"])==DBNull.Value)?0:Convert.ToInt32( dr["ShopId"]);
				Obj.OpenId =  dr["OpenId"].ToString();
				Obj.Money = (( dr["Money"])==DBNull.Value)?0:Convert.ToDecimal( dr["Money"]);
				Obj.Description =  dr["Description"].ToString();
				Obj.BankId = (( dr["BankId"])==DBNull.Value)?0:Convert.ToInt32( dr["BankId"]);
				Obj.Status = (( dr["Status"])==DBNull.Value)?0:Convert.ToInt32( dr["Status"]);
				Obj.Reason =  dr["Reason"].ToString();
				Obj.Addtime = (( dr["Addtime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( dr["Addtime"]);
				Obj.Updatetime = (( dr["Updatetime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( dr["Updatetime"]);
			
			return Obj;
		}
		#endregion
		
		/// <summary>
		/// 根据ID,返回一个Apply对象
		/// </summary>
		/// <param name="applyId">applyId</param>
		/// <returns>Apply对象</returns>
		public ApplyEntity Get_ApplyEntity (int applyId)
		{
			ApplyEntity _obj=null;
			SqlParameter[] _param={
			new SqlParameter("@ApplyId",SqlDbType.Int)
			};
			_param[0].Value=applyId;
			string sqlStr="select * from Apply with(nolock) where ApplyId=@ApplyId";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.WfxRW,CommandType.Text,sqlStr,_param))
			{
				while(dr.Read())
				{
            		_obj=Populate_ApplyEntity_FromDr(dr);
				}
			}
			return _obj;
		}
		/// <summary>
		/// 得到数据表Apply所有记录
		/// </summary>
		/// <returns>数据集</returns>
		public IList< ApplyEntity> Get_ApplyAll()
		{
			IList< ApplyEntity> Obj=new List< ApplyEntity>();
			string sqlStr="select * from Apply";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.WfxRW,CommandType.Text,sqlStr))
			{
				while(dr.Read())
				{
					Obj.Add(Populate_ApplyEntity_FromDr(dr));
				}
			}
			return Obj;
		}
		/// <summary>
        /// 检测是否存在根据主键
        /// </summary>
        /// <param name="applyId">applyId</param>
        /// <returns>是/否</returns>
		public bool IsExistApply(int applyId)
		{
			SqlParameter[] _param={
                                      new SqlParameter("@applyId",SqlDbType.Int)
                                  };
            _param[0].Value=applyId;
            string sqlStr="select Count(*) from Apply where ApplyId=@applyId";
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
