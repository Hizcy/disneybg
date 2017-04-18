// =================================================================== 
// 项目说明
//====================================================================
// yangxg。@Copy Right 2014
// 文件： Bank.cs
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
    /// 数据层实例化接口类 dbo.Bank.
    /// </summary>
    public partial class BankDataAccessLayer 
    {
		#region 构造函数


		/// <summary>
		/// 
		/// </summary>
		public BankDataAccessLayer()
		{
		}
		#endregion

        #region -----------实例化接口函数-----------
		
		#region 添加更新删除
		/// <summary>
		/// 向数据库中插入一条新记录。
		/// </summary>
		/// <param name="_BankModel">Bank实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(BankEntity _BankModel)
		{
			string sqlStr="insert into Bank([uid],[Type],[RealName],[CardNumber],[Addr],[Isdefault],[Status],[Addtime],[Updatetime]) values(@uid,@Type,@RealName,@CardNumber,@Addr,@Isdefault,@Status,@Addtime,@Updatetime) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@uid",SqlDbType.VarChar),
			new SqlParameter("@Type",SqlDbType.Int),
			new SqlParameter("@RealName",SqlDbType.VarChar),
			new SqlParameter("@CardNumber",SqlDbType.VarChar),
			new SqlParameter("@Addr",SqlDbType.VarChar),
			new SqlParameter("@Isdefault",SqlDbType.Int),
			new SqlParameter("@Status",SqlDbType.Int),
			new SqlParameter("@Addtime",SqlDbType.DateTime),
			new SqlParameter("@Updatetime",SqlDbType.DateTime)
			};			
			_param[0].Value=_BankModel.uid;
			_param[1].Value=_BankModel.Type;
			_param[2].Value=_BankModel.RealName;
			_param[3].Value=_BankModel.CardNumber;
			_param[4].Value=_BankModel.Addr;
			_param[5].Value=_BankModel.Isdefault;
			_param[6].Value=_BankModel.Status;
			_param[7].Value=_BankModel.Addtime;
			_param[8].Value=_BankModel.Updatetime;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.WfxRW,CommandType.Text,sqlStr,_param));
			return res;
		}
		/// <summary>
		/// 向数据库中插入一条新记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_BankModel">Bank实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(SqlTransaction sp,BankEntity _BankModel)
		{
			string sqlStr="insert into Bank([uid],[Type],[RealName],[CardNumber],[Addr],[Isdefault],[Status],[Addtime],[Updatetime]) values(@uid,@Type,@RealName,@CardNumber,@Addr,@Isdefault,@Status,@Addtime,@Updatetime) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@uid",SqlDbType.VarChar),
			new SqlParameter("@Type",SqlDbType.Int),
			new SqlParameter("@RealName",SqlDbType.VarChar),
			new SqlParameter("@CardNumber",SqlDbType.VarChar),
			new SqlParameter("@Addr",SqlDbType.VarChar),
			new SqlParameter("@Isdefault",SqlDbType.Int),
			new SqlParameter("@Status",SqlDbType.Int),
			new SqlParameter("@Addtime",SqlDbType.DateTime),
			new SqlParameter("@Updatetime",SqlDbType.DateTime)
			};			
			_param[0].Value=_BankModel.uid;
			_param[1].Value=_BankModel.Type;
			_param[2].Value=_BankModel.RealName;
			_param[3].Value=_BankModel.CardNumber;
			_param[4].Value=_BankModel.Addr;
			_param[5].Value=_BankModel.Isdefault;
			_param[6].Value=_BankModel.Status;
			_param[7].Value=_BankModel.Addtime;
			_param[8].Value=_BankModel.Updatetime;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(sp,CommandType.Text,sqlStr,_param));
			return res;
		}


		/// <summary>
		/// 向数据表Bank更新一条记录。
		/// </summary>
		/// <param name="_BankModel">_BankModel</param>
		/// <returns>影响的行数</returns>
		public int Update(BankEntity _BankModel)
		{
            string sqlStr="update Bank set [uid]=@uid,[Type]=@Type,[RealName]=@RealName,[CardNumber]=@CardNumber,[Addr]=@Addr,[Isdefault]=@Isdefault,[Status]=@Status,[Addtime]=@Addtime,[Updatetime]=@Updatetime where BankId=@BankId";
			SqlParameter[] _param={				
				new SqlParameter("@BankId",SqlDbType.Int),
				new SqlParameter("@uid",SqlDbType.VarChar),
				new SqlParameter("@Type",SqlDbType.Int),
				new SqlParameter("@RealName",SqlDbType.VarChar),
				new SqlParameter("@CardNumber",SqlDbType.VarChar),
				new SqlParameter("@Addr",SqlDbType.VarChar),
				new SqlParameter("@Isdefault",SqlDbType.Int),
				new SqlParameter("@Status",SqlDbType.Int),
				new SqlParameter("@Addtime",SqlDbType.DateTime),
				new SqlParameter("@Updatetime",SqlDbType.DateTime)
				};				
				_param[0].Value=_BankModel.BankId;
				_param[1].Value=_BankModel.uid;
				_param[2].Value=_BankModel.Type;
				_param[3].Value=_BankModel.RealName;
				_param[4].Value=_BankModel.CardNumber;
				_param[5].Value=_BankModel.Addr;
				_param[6].Value=_BankModel.Isdefault;
				_param[7].Value=_BankModel.Status;
				_param[8].Value=_BankModel.Addtime;
				_param[9].Value=_BankModel.Updatetime;
			return SqlHelper.ExecuteNonQuery(WebConfig.WfxRW,CommandType.Text,sqlStr,_param);
		}
		/// <summary>
		/// 向数据表Bank更新一条记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_BankModel">_BankModel</param>
		/// <returns>影响的行数</returns>
		public int Update(SqlTransaction sp,BankEntity _BankModel)
		{
            string sqlStr="update Bank set [uid]=@uid,[Type]=@Type,[RealName]=@RealName,[CardNumber]=@CardNumber,[Addr]=@Addr,[Isdefault]=@Isdefault,[Status]=@Status,[Addtime]=@Addtime,[Updatetime]=@Updatetime where BankId=@BankId";
			SqlParameter[] _param={				
				new SqlParameter("@BankId",SqlDbType.Int),
				new SqlParameter("@uid",SqlDbType.VarChar),
				new SqlParameter("@Type",SqlDbType.Int),
				new SqlParameter("@RealName",SqlDbType.VarChar),
				new SqlParameter("@CardNumber",SqlDbType.VarChar),
				new SqlParameter("@Addr",SqlDbType.VarChar),
				new SqlParameter("@Isdefault",SqlDbType.Int),
				new SqlParameter("@Status",SqlDbType.Int),
				new SqlParameter("@Addtime",SqlDbType.DateTime),
				new SqlParameter("@Updatetime",SqlDbType.DateTime)
				};				
				_param[0].Value=_BankModel.BankId;
				_param[1].Value=_BankModel.uid;
				_param[2].Value=_BankModel.Type;
				_param[3].Value=_BankModel.RealName;
				_param[4].Value=_BankModel.CardNumber;
				_param[5].Value=_BankModel.Addr;
				_param[6].Value=_BankModel.Isdefault;
				_param[7].Value=_BankModel.Status;
				_param[8].Value=_BankModel.Addtime;
				_param[9].Value=_BankModel.Updatetime;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}		
		
		
		/// <summary>
		/// 删除数据表Bank中的一条记录
		/// </summary>
	    /// <param name="BankId">bankId</param>
		/// <returns>影响的行数</returns>
		public int Delete(int BankId)
		{
			string sqlStr="delete from Bank where [BankId]=@BankId";
			SqlParameter[] _param={			
			new SqlParameter("@BankId",SqlDbType.Int),
			
			};			
			_param[0].Value=BankId;
			return SqlHelper.ExecuteNonQuery(WebConfig.WfxRW,CommandType.Text,sqlStr,_param);
		}
		
		/// <summary>
		/// 删除数据表Bank中的一条记录,带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
	    /// <param name="BankId">bankId</param>
		/// <returns>影响的行数</returns>
		public int Delete(SqlTransaction sp,int BankId)
		{
			string sqlStr="delete from Bank where [BankId]=@BankId";
			SqlParameter[] _param={			
			new SqlParameter("@BankId",SqlDbType.Int),
			
			};			
			_param[0].Value=BankId;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}
		#endregion
		
		#region 数据实体
		/// <summary>
		/// 得到  bank 数据实体
		/// </summary>
		/// <param name="row">row</param>
		/// <returns>bank 数据实体</returns>
		public BankEntity Populate_BankEntity_FromDr(DataRow row)
		{
			BankEntity Obj = new BankEntity();
			if(row!=null)
			{
				Obj.BankId = (( row["BankId"])==DBNull.Value)?0:Convert.ToInt32( row["BankId"]);
				Obj.uid =  row["uid"].ToString();
				Obj.Type = (( row["Type"])==DBNull.Value)?0:Convert.ToInt32( row["Type"]);
				Obj.RealName =  row["RealName"].ToString();
				Obj.CardNumber =  row["CardNumber"].ToString();
				Obj.Addr =  row["Addr"].ToString();
				Obj.Isdefault = (( row["Isdefault"])==DBNull.Value)?0:Convert.ToInt32( row["Isdefault"]);
				Obj.Status = (( row["Status"])==DBNull.Value)?0:Convert.ToInt32( row["Status"]);
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
		/// 得到  bank 数据实体
		/// </summary>
		/// <param name="dr">dr</param>
		/// <returns>bank 数据实体</returns>
		public BankEntity Populate_BankEntity_FromDr(IDataReader dr)
		{
			BankEntity Obj = new BankEntity();
			
				Obj.BankId = (( dr["BankId"])==DBNull.Value)?0:Convert.ToInt32( dr["BankId"]);
				Obj.uid =  dr["uid"].ToString();
				Obj.Type = (( dr["Type"])==DBNull.Value)?0:Convert.ToInt32( dr["Type"]);
				Obj.RealName =  dr["RealName"].ToString();
				Obj.CardNumber =  dr["CardNumber"].ToString();
				Obj.Addr =  dr["Addr"].ToString();
				Obj.Isdefault = (( dr["Isdefault"])==DBNull.Value)?0:Convert.ToInt32( dr["Isdefault"]);
				Obj.Status = (( dr["Status"])==DBNull.Value)?0:Convert.ToInt32( dr["Status"]);
				Obj.Addtime = (( dr["Addtime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( dr["Addtime"]);
				Obj.Updatetime = (( dr["Updatetime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( dr["Updatetime"]);
			
			return Obj;
		}
		#endregion
		
		/// <summary>
		/// 根据ID,返回一个Bank对象
		/// </summary>
		/// <param name="bankId">bankId</param>
		/// <returns>Bank对象</returns>
		public BankEntity Get_BankEntity (int bankId)
		{
			BankEntity _obj=null;
			SqlParameter[] _param={
			new SqlParameter("@BankId",SqlDbType.Int)
			};
			_param[0].Value=bankId;
			string sqlStr="select * from Bank with(nolock) where BankId=@BankId";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.WfxRW,CommandType.Text,sqlStr,_param))
			{
				while(dr.Read())
				{
            		_obj=Populate_BankEntity_FromDr(dr);
				}
			}
			return _obj;
		}
		/// <summary>
		/// 得到数据表Bank所有记录
		/// </summary>
		/// <returns>数据集</returns>
		public IList< BankEntity> Get_BankAll()
		{
			IList< BankEntity> Obj=new List< BankEntity>();
			string sqlStr="select * from Bank";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.WfxRW,CommandType.Text,sqlStr))
			{
				while(dr.Read())
				{
					Obj.Add(Populate_BankEntity_FromDr(dr));
				}
			}
			return Obj;
		}
		/// <summary>
        /// 检测是否存在根据主键
        /// </summary>
        /// <param name="bankId">bankId</param>
        /// <returns>是/否</returns>
		public bool IsExistBank(int bankId)
		{
			SqlParameter[] _param={
                                      new SqlParameter("@bankId",SqlDbType.Int)
                                  };
            _param[0].Value=bankId;
            string sqlStr="select Count(*) from Bank where BankId=@bankId";
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
