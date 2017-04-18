// =================================================================== 
// 项目说明
//====================================================================
// yangxg。@Copy Right 2014
// 文件： Address.cs
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
    /// 数据层实例化接口类 dbo.Address.
    /// </summary>
    public partial class AddressDataAccessLayer 
    {
		#region 构造函数


		/// <summary>
		/// 
		/// </summary>
		public AddressDataAccessLayer()
		{
		}
		#endregion

        #region -----------实例化接口函数-----------
		
		#region 添加更新删除
		/// <summary>
		/// 向数据库中插入一条新记录。
		/// </summary>
		/// <param name="_AddressModel">Address实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(AddressEntity _AddressModel)
		{
			string sqlStr="insert into Address([OpenId],[LocationId],[RealName],[Phone],[Addr],[Isdefault],[Status],[Addtime],[Updatetime]) values(@OpenId,@LocationId,@RealName,@Phone,@Addr,@Isdefault,@Status,@Addtime,@Updatetime) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@OpenId",SqlDbType.VarChar),
			new SqlParameter("@LocationId",SqlDbType.Int),
			new SqlParameter("@RealName",SqlDbType.VarChar),
			new SqlParameter("@Phone",SqlDbType.VarChar),
			new SqlParameter("@Addr",SqlDbType.VarChar),
			new SqlParameter("@Isdefault",SqlDbType.Int),
			new SqlParameter("@Status",SqlDbType.Int),
			new SqlParameter("@Addtime",SqlDbType.DateTime),
			new SqlParameter("@Updatetime",SqlDbType.DateTime)
			};			
			_param[0].Value=_AddressModel.OpenId;
			_param[1].Value=_AddressModel.LocationId;
			_param[2].Value=_AddressModel.RealName;
			_param[3].Value=_AddressModel.Phone;
			_param[4].Value=_AddressModel.Addr;
			_param[5].Value=_AddressModel.Isdefault;
			_param[6].Value=_AddressModel.Status;
			_param[7].Value=_AddressModel.Addtime;
			_param[8].Value=_AddressModel.Updatetime;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.WfxRW,CommandType.Text,sqlStr,_param));
			return res;
		}
		/// <summary>
		/// 向数据库中插入一条新记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_AddressModel">Address实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(SqlTransaction sp,AddressEntity _AddressModel)
		{
			string sqlStr="insert into Address([OpenId],[LocationId],[RealName],[Phone],[Addr],[Isdefault],[Status],[Addtime],[Updatetime]) values(@OpenId,@LocationId,@RealName,@Phone,@Addr,@Isdefault,@Status,@Addtime,@Updatetime) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@OpenId",SqlDbType.VarChar),
			new SqlParameter("@LocationId",SqlDbType.Int),
			new SqlParameter("@RealName",SqlDbType.VarChar),
			new SqlParameter("@Phone",SqlDbType.VarChar),
			new SqlParameter("@Addr",SqlDbType.VarChar),
			new SqlParameter("@Isdefault",SqlDbType.Int),
			new SqlParameter("@Status",SqlDbType.Int),
			new SqlParameter("@Addtime",SqlDbType.DateTime),
			new SqlParameter("@Updatetime",SqlDbType.DateTime)
			};			
			_param[0].Value=_AddressModel.OpenId;
			_param[1].Value=_AddressModel.LocationId;
			_param[2].Value=_AddressModel.RealName;
			_param[3].Value=_AddressModel.Phone;
			_param[4].Value=_AddressModel.Addr;
			_param[5].Value=_AddressModel.Isdefault;
			_param[6].Value=_AddressModel.Status;
			_param[7].Value=_AddressModel.Addtime;
			_param[8].Value=_AddressModel.Updatetime;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(sp,CommandType.Text,sqlStr,_param));
			return res;
		}


		/// <summary>
		/// 向数据表Address更新一条记录。
		/// </summary>
		/// <param name="_AddressModel">_AddressModel</param>
		/// <returns>影响的行数</returns>
		public int Update(AddressEntity _AddressModel)
		{
            string sqlStr="update Address set [OpenId]=@OpenId,[LocationId]=@LocationId,[RealName]=@RealName,[Phone]=@Phone,[Addr]=@Addr,[Isdefault]=@Isdefault,[Status]=@Status,[Addtime]=@Addtime,[Updatetime]=@Updatetime where AddressId=@AddressId";
			SqlParameter[] _param={				
				new SqlParameter("@AddressId",SqlDbType.Int),
				new SqlParameter("@OpenId",SqlDbType.VarChar),
				new SqlParameter("@LocationId",SqlDbType.Int),
				new SqlParameter("@RealName",SqlDbType.VarChar),
				new SqlParameter("@Phone",SqlDbType.VarChar),
				new SqlParameter("@Addr",SqlDbType.VarChar),
				new SqlParameter("@Isdefault",SqlDbType.Int),
				new SqlParameter("@Status",SqlDbType.Int),
				new SqlParameter("@Addtime",SqlDbType.DateTime),
				new SqlParameter("@Updatetime",SqlDbType.DateTime)
				};				
				_param[0].Value=_AddressModel.AddressId;
				_param[1].Value=_AddressModel.OpenId;
				_param[2].Value=_AddressModel.LocationId;
				_param[3].Value=_AddressModel.RealName;
				_param[4].Value=_AddressModel.Phone;
				_param[5].Value=_AddressModel.Addr;
				_param[6].Value=_AddressModel.Isdefault;
				_param[7].Value=_AddressModel.Status;
				_param[8].Value=_AddressModel.Addtime;
				_param[9].Value=_AddressModel.Updatetime;
			return SqlHelper.ExecuteNonQuery(WebConfig.WfxRW,CommandType.Text,sqlStr,_param);
		}
		/// <summary>
		/// 向数据表Address更新一条记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_AddressModel">_AddressModel</param>
		/// <returns>影响的行数</returns>
		public int Update(SqlTransaction sp,AddressEntity _AddressModel)
		{
            string sqlStr="update Address set [OpenId]=@OpenId,[LocationId]=@LocationId,[RealName]=@RealName,[Phone]=@Phone,[Addr]=@Addr,[Isdefault]=@Isdefault,[Status]=@Status,[Addtime]=@Addtime,[Updatetime]=@Updatetime where AddressId=@AddressId";
			SqlParameter[] _param={				
				new SqlParameter("@AddressId",SqlDbType.Int),
				new SqlParameter("@OpenId",SqlDbType.VarChar),
				new SqlParameter("@LocationId",SqlDbType.Int),
				new SqlParameter("@RealName",SqlDbType.VarChar),
				new SqlParameter("@Phone",SqlDbType.VarChar),
				new SqlParameter("@Addr",SqlDbType.VarChar),
				new SqlParameter("@Isdefault",SqlDbType.Int),
				new SqlParameter("@Status",SqlDbType.Int),
				new SqlParameter("@Addtime",SqlDbType.DateTime),
				new SqlParameter("@Updatetime",SqlDbType.DateTime)
				};				
				_param[0].Value=_AddressModel.AddressId;
				_param[1].Value=_AddressModel.OpenId;
				_param[2].Value=_AddressModel.LocationId;
				_param[3].Value=_AddressModel.RealName;
				_param[4].Value=_AddressModel.Phone;
				_param[5].Value=_AddressModel.Addr;
				_param[6].Value=_AddressModel.Isdefault;
				_param[7].Value=_AddressModel.Status;
				_param[8].Value=_AddressModel.Addtime;
				_param[9].Value=_AddressModel.Updatetime;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}		
		
		
		/// <summary>
		/// 删除数据表Address中的一条记录
		/// </summary>
	    /// <param name="AddressId">addressId</param>
		/// <returns>影响的行数</returns>
		public int Delete(int AddressId)
		{
			string sqlStr="delete from Address where [AddressId]=@AddressId";
			SqlParameter[] _param={			
			new SqlParameter("@AddressId",SqlDbType.Int),
			
			};			
			_param[0].Value=AddressId;
			return SqlHelper.ExecuteNonQuery(WebConfig.WfxRW,CommandType.Text,sqlStr,_param);
		}
		
		/// <summary>
		/// 删除数据表Address中的一条记录,带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
	    /// <param name="AddressId">addressId</param>
		/// <returns>影响的行数</returns>
		public int Delete(SqlTransaction sp,int AddressId)
		{
			string sqlStr="delete from Address where [AddressId]=@AddressId";
			SqlParameter[] _param={			
			new SqlParameter("@AddressId",SqlDbType.Int),
			
			};			
			_param[0].Value=AddressId;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}
		#endregion
		
		#region 数据实体
		/// <summary>
		/// 得到  address 数据实体
		/// </summary>
		/// <param name="row">row</param>
		/// <returns>address 数据实体</returns>
		public AddressEntity Populate_AddressEntity_FromDr(DataRow row)
		{
			AddressEntity Obj = new AddressEntity();
			if(row!=null)
			{
				Obj.AddressId = (( row["AddressId"])==DBNull.Value)?0:Convert.ToInt32( row["AddressId"]);
				Obj.OpenId =  row["OpenId"].ToString();
				Obj.LocationId = (( row["LocationId"])==DBNull.Value)?0:Convert.ToInt32( row["LocationId"]);
				Obj.RealName =  row["RealName"].ToString();
				Obj.Phone =  row["Phone"].ToString();
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
		/// 得到  address 数据实体
		/// </summary>
		/// <param name="dr">dr</param>
		/// <returns>address 数据实体</returns>
		public AddressEntity Populate_AddressEntity_FromDr(IDataReader dr)
		{
			AddressEntity Obj = new AddressEntity();
			
				Obj.AddressId = (( dr["AddressId"])==DBNull.Value)?0:Convert.ToInt32( dr["AddressId"]);
				Obj.OpenId =  dr["OpenId"].ToString();
				Obj.LocationId = (( dr["LocationId"])==DBNull.Value)?0:Convert.ToInt32( dr["LocationId"]);
				Obj.RealName =  dr["RealName"].ToString();
				Obj.Phone =  dr["Phone"].ToString();
				Obj.Addr =  dr["Addr"].ToString();
				Obj.Isdefault = (( dr["Isdefault"])==DBNull.Value)?0:Convert.ToInt32( dr["Isdefault"]);
				Obj.Status = (( dr["Status"])==DBNull.Value)?0:Convert.ToInt32( dr["Status"]);
				Obj.Addtime = (( dr["Addtime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( dr["Addtime"]);
				Obj.Updatetime = (( dr["Updatetime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( dr["Updatetime"]);
			
			return Obj;
		}
		#endregion
		
		/// <summary>
		/// 根据ID,返回一个Address对象
		/// </summary>
		/// <param name="addressId">addressId</param>
		/// <returns>Address对象</returns>
		public AddressEntity Get_AddressEntity (int addressId)
		{
			AddressEntity _obj=null;
			SqlParameter[] _param={
			new SqlParameter("@AddressId",SqlDbType.Int)
			};
			_param[0].Value=addressId;
			string sqlStr="select * from Address with(nolock) where AddressId=@AddressId";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.WfxRW,CommandType.Text,sqlStr,_param))
			{
				while(dr.Read())
				{
            		_obj=Populate_AddressEntity_FromDr(dr);
				}
			}
			return _obj;
		}
		/// <summary>
		/// 得到数据表Address所有记录
		/// </summary>
		/// <returns>数据集</returns>
		public IList< AddressEntity> Get_AddressAll()
		{
			IList< AddressEntity> Obj=new List< AddressEntity>();
			string sqlStr="select * from Address";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.WfxRW,CommandType.Text,sqlStr))
			{
				while(dr.Read())
				{
					Obj.Add(Populate_AddressEntity_FromDr(dr));
				}
			}
			return Obj;
		}
		/// <summary>
        /// 检测是否存在根据主键
        /// </summary>
        /// <param name="addressId">addressId</param>
        /// <returns>是/否</returns>
		public bool IsExistAddress(int addressId)
		{
			SqlParameter[] _param={
                                      new SqlParameter("@addressId",SqlDbType.Int)
                                  };
            _param[0].Value=addressId;
            string sqlStr="select Count(*) from Address where AddressId=@addressId";
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
