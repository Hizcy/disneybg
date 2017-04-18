// =================================================================== 
// 项目说明
//====================================================================
// yangxg。@Copy Right 2014
// 文件： WalletLog.cs
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
    /// 数据层实例化接口类 dbo.WalletLog.
    /// </summary>
    public partial class WalletLogDataAccessLayer 
    {
		#region 构造函数


		/// <summary>
		/// 
		/// </summary>
		public WalletLogDataAccessLayer()
		{
		}
		#endregion

        #region -----------实例化接口函数-----------
		
		#region 添加更新删除
		/// <summary>
		/// 向数据库中插入一条新记录。
		/// </summary>
		/// <param name="_WalletLogModel">WalletLog实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(WalletLogEntity _WalletLogModel)
		{
			string sqlStr="insert into WalletLog([BuyerOpenId],[Money],[Type],[OpenId],[OrderId],[Status],[Addtime]) values(@BuyerOpenId,@Money,@Type,@OpenId,@OrderId,@Status,@Addtime) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@BuyerOpenId",SqlDbType.VarChar),
			new SqlParameter("@Money",SqlDbType.Decimal),
			new SqlParameter("@Type",SqlDbType.Int),
			new SqlParameter("@OpenId",SqlDbType.VarChar),
			new SqlParameter("@OrderId",SqlDbType.Int),
			new SqlParameter("@Status",SqlDbType.Int),
			new SqlParameter("@Addtime",SqlDbType.DateTime)
			};			
			_param[0].Value=_WalletLogModel.BuyerOpenId;
			_param[1].Value=_WalletLogModel.Money;
			_param[2].Value=_WalletLogModel.Type;
			_param[3].Value=_WalletLogModel.OpenId;
			_param[4].Value=_WalletLogModel.OrderId;
			_param[5].Value=_WalletLogModel.Status;
			_param[6].Value=_WalletLogModel.Addtime;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.WfxRW,CommandType.Text,sqlStr,_param));
			return res;
		}
		/// <summary>
		/// 向数据库中插入一条新记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_WalletLogModel">WalletLog实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(SqlTransaction sp,WalletLogEntity _WalletLogModel)
		{
			string sqlStr="insert into WalletLog([BuyerOpenId],[Money],[Type],[OpenId],[OrderId],[Status],[Addtime]) values(@BuyerOpenId,@Money,@Type,@OpenId,@OrderId,@Status,@Addtime) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@BuyerOpenId",SqlDbType.VarChar),
			new SqlParameter("@Money",SqlDbType.Decimal),
			new SqlParameter("@Type",SqlDbType.Int),
			new SqlParameter("@OpenId",SqlDbType.VarChar),
			new SqlParameter("@OrderId",SqlDbType.Int),
			new SqlParameter("@Status",SqlDbType.Int),
			new SqlParameter("@Addtime",SqlDbType.DateTime)
			};			
			_param[0].Value=_WalletLogModel.BuyerOpenId;
			_param[1].Value=_WalletLogModel.Money;
			_param[2].Value=_WalletLogModel.Type;
			_param[3].Value=_WalletLogModel.OpenId;
			_param[4].Value=_WalletLogModel.OrderId;
			_param[5].Value=_WalletLogModel.Status;
			_param[6].Value=_WalletLogModel.Addtime;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(sp,CommandType.Text,sqlStr,_param));
			return res;
		}


		/// <summary>
		/// 向数据表WalletLog更新一条记录。
		/// </summary>
		/// <param name="_WalletLogModel">_WalletLogModel</param>
		/// <returns>影响的行数</returns>
		public int Update(WalletLogEntity _WalletLogModel)
		{
            string sqlStr="update WalletLog set [BuyerOpenId]=@BuyerOpenId,[Money]=@Money,[Type]=@Type,[OpenId]=@OpenId,[OrderId]=@OrderId,[Status]=@Status,[Addtime]=@Addtime where WalletId=@WalletId";
			SqlParameter[] _param={				
				new SqlParameter("@WalletId",SqlDbType.Int),
				new SqlParameter("@BuyerOpenId",SqlDbType.VarChar),
				new SqlParameter("@Money",SqlDbType.Decimal),
				new SqlParameter("@Type",SqlDbType.Int),
				new SqlParameter("@OpenId",SqlDbType.VarChar),
				new SqlParameter("@OrderId",SqlDbType.Int),
				new SqlParameter("@Status",SqlDbType.Int),
				new SqlParameter("@Addtime",SqlDbType.DateTime)
				};				
				_param[0].Value=_WalletLogModel.WalletId;
				_param[1].Value=_WalletLogModel.BuyerOpenId;
				_param[2].Value=_WalletLogModel.Money;
				_param[3].Value=_WalletLogModel.Type;
				_param[4].Value=_WalletLogModel.OpenId;
				_param[5].Value=_WalletLogModel.OrderId;
				_param[6].Value=_WalletLogModel.Status;
				_param[7].Value=_WalletLogModel.Addtime;
			return SqlHelper.ExecuteNonQuery(WebConfig.WfxRW,CommandType.Text,sqlStr,_param);
		}
		/// <summary>
		/// 向数据表WalletLog更新一条记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_WalletLogModel">_WalletLogModel</param>
		/// <returns>影响的行数</returns>
		public int Update(SqlTransaction sp,WalletLogEntity _WalletLogModel)
		{
            string sqlStr="update WalletLog set [BuyerOpenId]=@BuyerOpenId,[Money]=@Money,[Type]=@Type,[OpenId]=@OpenId,[OrderId]=@OrderId,[Status]=@Status,[Addtime]=@Addtime where WalletId=@WalletId";
			SqlParameter[] _param={				
				new SqlParameter("@WalletId",SqlDbType.Int),
				new SqlParameter("@BuyerOpenId",SqlDbType.VarChar),
				new SqlParameter("@Money",SqlDbType.Decimal),
				new SqlParameter("@Type",SqlDbType.Int),
				new SqlParameter("@OpenId",SqlDbType.VarChar),
				new SqlParameter("@OrderId",SqlDbType.Int),
				new SqlParameter("@Status",SqlDbType.Int),
				new SqlParameter("@Addtime",SqlDbType.DateTime)
				};				
				_param[0].Value=_WalletLogModel.WalletId;
				_param[1].Value=_WalletLogModel.BuyerOpenId;
				_param[2].Value=_WalletLogModel.Money;
				_param[3].Value=_WalletLogModel.Type;
				_param[4].Value=_WalletLogModel.OpenId;
				_param[5].Value=_WalletLogModel.OrderId;
				_param[6].Value=_WalletLogModel.Status;
				_param[7].Value=_WalletLogModel.Addtime;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}		
		
		
		/// <summary>
		/// 删除数据表WalletLog中的一条记录
		/// </summary>
	    /// <param name="WalletId">walletId</param>
		/// <returns>影响的行数</returns>
		public int Delete(int WalletId)
		{
			string sqlStr="delete from WalletLog where [WalletId]=@WalletId";
			SqlParameter[] _param={			
			new SqlParameter("@WalletId",SqlDbType.Int),
			
			};			
			_param[0].Value=WalletId;
			return SqlHelper.ExecuteNonQuery(WebConfig.WfxRW,CommandType.Text,sqlStr,_param);
		}
		
		/// <summary>
		/// 删除数据表WalletLog中的一条记录,带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
	    /// <param name="WalletId">walletId</param>
		/// <returns>影响的行数</returns>
		public int Delete(SqlTransaction sp,int WalletId)
		{
			string sqlStr="delete from WalletLog where [WalletId]=@WalletId";
			SqlParameter[] _param={			
			new SqlParameter("@WalletId",SqlDbType.Int),
			
			};			
			_param[0].Value=WalletId;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}
		#endregion
		
		#region 数据实体
		/// <summary>
		/// 得到  walletlog 数据实体
		/// </summary>
		/// <param name="row">row</param>
		/// <returns>walletlog 数据实体</returns>
		public WalletLogEntity Populate_WalletLogEntity_FromDr(DataRow row)
		{
			WalletLogEntity Obj = new WalletLogEntity();
			if(row!=null)
			{
				Obj.WalletId = (( row["WalletId"])==DBNull.Value)?0:Convert.ToInt32( row["WalletId"]);
				Obj.BuyerOpenId =  row["BuyerOpenId"].ToString();
				Obj.Money = (( row["Money"])==DBNull.Value)?0:Convert.ToDecimal( row["Money"]);
				Obj.Type = (( row["Type"])==DBNull.Value)?0:Convert.ToInt32( row["Type"]);
				Obj.OpenId =  row["OpenId"].ToString();
				Obj.OrderId = (( row["OrderId"])==DBNull.Value)?0:Convert.ToInt32( row["OrderId"]);
				Obj.Status = (( row["Status"])==DBNull.Value)?0:Convert.ToInt32( row["Status"]);
				Obj.Addtime = (( row["Addtime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( row["Addtime"]);
			}
			else
			{
				return null;
			}
			return Obj;
		}
		
        /// <summary>
		/// 得到  walletlog 数据实体
		/// </summary>
		/// <param name="dr">dr</param>
		/// <returns>walletlog 数据实体</returns>
		public WalletLogEntity Populate_WalletLogEntity_FromDr(IDataReader dr)
		{
			WalletLogEntity Obj = new WalletLogEntity();
			
				Obj.WalletId = (( dr["WalletId"])==DBNull.Value)?0:Convert.ToInt32( dr["WalletId"]);
				Obj.BuyerOpenId =  dr["BuyerOpenId"].ToString();
				Obj.Money = (( dr["Money"])==DBNull.Value)?0:Convert.ToDecimal( dr["Money"]);
				Obj.Type = (( dr["Type"])==DBNull.Value)?0:Convert.ToInt32( dr["Type"]);
				Obj.OpenId =  dr["OpenId"].ToString();
				Obj.OrderId = (( dr["OrderId"])==DBNull.Value)?0:Convert.ToInt32( dr["OrderId"]);
				Obj.Status = (( dr["Status"])==DBNull.Value)?0:Convert.ToInt32( dr["Status"]);
				Obj.Addtime = (( dr["Addtime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( dr["Addtime"]);
			
			return Obj;
		}
		#endregion
		
		/// <summary>
		/// 根据ID,返回一个WalletLog对象
		/// </summary>
		/// <param name="walletId">walletId</param>
		/// <returns>WalletLog对象</returns>
		public WalletLogEntity Get_WalletLogEntity (int walletId)
		{
			WalletLogEntity _obj=null;
			SqlParameter[] _param={
			new SqlParameter("@WalletId",SqlDbType.Int)
			};
			_param[0].Value=walletId;
			string sqlStr="select * from WalletLog with(nolock) where WalletId=@WalletId";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.WfxRW,CommandType.Text,sqlStr,_param))
			{
				while(dr.Read())
				{
            		_obj=Populate_WalletLogEntity_FromDr(dr);
				}
			}
			return _obj;
		}
		/// <summary>
		/// 得到数据表WalletLog所有记录
		/// </summary>
		/// <returns>数据集</returns>
		public IList< WalletLogEntity> Get_WalletLogAll()
		{
			IList< WalletLogEntity> Obj=new List< WalletLogEntity>();
			string sqlStr="select * from WalletLog";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.WfxRW,CommandType.Text,sqlStr))
			{
				while(dr.Read())
				{
					Obj.Add(Populate_WalletLogEntity_FromDr(dr));
				}
			}
			return Obj;
		}
		/// <summary>
        /// 检测是否存在根据主键
        /// </summary>
        /// <param name="walletId">walletId</param>
        /// <returns>是/否</returns>
		public bool IsExistWalletLog(int walletId)
		{
			SqlParameter[] _param={
                                      new SqlParameter("@walletId",SqlDbType.Int)
                                  };
            _param[0].Value=walletId;
            string sqlStr="select Count(*) from WalletLog where WalletId=@walletId";
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
