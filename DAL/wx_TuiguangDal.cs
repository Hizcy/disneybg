// =================================================================== 
// 项目说明
//====================================================================
// yangxg。@Copy Right 2014
// 文件： wx_Tuiguang.cs
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
    /// 数据层实例化接口类 dbo.wx_Tuiguang.
    /// </summary>
    public partial class wx_TuiguangDataAccessLayer 
    {
		#region 构造函数


		/// <summary>
		/// 
		/// </summary>
		public wx_TuiguangDataAccessLayer()
		{
		}
		#endregion

        #region -----------实例化接口函数-----------
		
		#region 添加更新删除
		/// <summary>
		/// 向数据库中插入一条新记录。
		/// </summary>
		/// <param name="_wx_TuiguangModel">wx_Tuiguang实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(wx_TuiguangEntity _wx_TuiguangModel)
		{
			string sqlStr="insert into wx_Tuiguang([WeiXinCode],[OpenId],[ShareType],[PageId],[Status],[AddTime],[PageType]) values(@WeiXinCode,@OpenId,@ShareType,@PageId,@Status,@AddTime,@PageType) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@WeiXinCode",SqlDbType.VarChar),
			new SqlParameter("@OpenId",SqlDbType.VarChar),
			new SqlParameter("@ShareType",SqlDbType.Int),
			new SqlParameter("@PageId",SqlDbType.Int),
			new SqlParameter("@Status",SqlDbType.Int),
			new SqlParameter("@AddTime",SqlDbType.DateTime),
			new SqlParameter("@PageType",SqlDbType.Int)
			};			
			_param[0].Value=_wx_TuiguangModel.WeiXinCode;
			_param[1].Value=_wx_TuiguangModel.OpenId;
			_param[2].Value=_wx_TuiguangModel.ShareType;
			_param[3].Value=_wx_TuiguangModel.PageId;
			_param[4].Value=_wx_TuiguangModel.Status;
			_param[5].Value=_wx_TuiguangModel.AddTime;
			_param[6].Value=_wx_TuiguangModel.PageType;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.WfxRW,CommandType.Text,sqlStr,_param));
			return res;
		}
		/// <summary>
		/// 向数据库中插入一条新记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_wx_TuiguangModel">wx_Tuiguang实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(SqlTransaction sp,wx_TuiguangEntity _wx_TuiguangModel)
		{
			string sqlStr="insert into wx_Tuiguang([WeiXinCode],[OpenId],[ShareType],[PageId],[Status],[AddTime],[PageType]) values(@WeiXinCode,@OpenId,@ShareType,@PageId,@Status,@AddTime,@PageType) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@WeiXinCode",SqlDbType.VarChar),
			new SqlParameter("@OpenId",SqlDbType.VarChar),
			new SqlParameter("@ShareType",SqlDbType.Int),
			new SqlParameter("@PageId",SqlDbType.Int),
			new SqlParameter("@Status",SqlDbType.Int),
			new SqlParameter("@AddTime",SqlDbType.DateTime),
			new SqlParameter("@PageType",SqlDbType.Int)
			};			
			_param[0].Value=_wx_TuiguangModel.WeiXinCode;
			_param[1].Value=_wx_TuiguangModel.OpenId;
			_param[2].Value=_wx_TuiguangModel.ShareType;
			_param[3].Value=_wx_TuiguangModel.PageId;
			_param[4].Value=_wx_TuiguangModel.Status;
			_param[5].Value=_wx_TuiguangModel.AddTime;
			_param[6].Value=_wx_TuiguangModel.PageType;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(sp,CommandType.Text,sqlStr,_param));
			return res;
		}


		/// <summary>
		/// 向数据表wx_Tuiguang更新一条记录。
		/// </summary>
		/// <param name="_wx_TuiguangModel">_wx_TuiguangModel</param>
		/// <returns>影响的行数</returns>
		public int Update(wx_TuiguangEntity _wx_TuiguangModel)
		{
            string sqlStr="update wx_Tuiguang set [WeiXinCode]=@WeiXinCode,[OpenId]=@OpenId,[ShareType]=@ShareType,[PageId]=@PageId,[Status]=@Status,[AddTime]=@AddTime,[PageType]=@PageType where Id=@Id";
			SqlParameter[] _param={				
				new SqlParameter("@Id",SqlDbType.Int),
				new SqlParameter("@WeiXinCode",SqlDbType.VarChar),
				new SqlParameter("@OpenId",SqlDbType.VarChar),
				new SqlParameter("@ShareType",SqlDbType.Int),
				new SqlParameter("@PageId",SqlDbType.Int),
				new SqlParameter("@Status",SqlDbType.Int),
				new SqlParameter("@AddTime",SqlDbType.DateTime),
				new SqlParameter("@PageType",SqlDbType.Int)
				};				
				_param[0].Value=_wx_TuiguangModel.Id;
				_param[1].Value=_wx_TuiguangModel.WeiXinCode;
				_param[2].Value=_wx_TuiguangModel.OpenId;
				_param[3].Value=_wx_TuiguangModel.ShareType;
				_param[4].Value=_wx_TuiguangModel.PageId;
				_param[5].Value=_wx_TuiguangModel.Status;
				_param[6].Value=_wx_TuiguangModel.AddTime;
				_param[7].Value=_wx_TuiguangModel.PageType;
			return SqlHelper.ExecuteNonQuery(WebConfig.WfxRW,CommandType.Text,sqlStr,_param);
		}
		/// <summary>
		/// 向数据表wx_Tuiguang更新一条记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_wx_TuiguangModel">_wx_TuiguangModel</param>
		/// <returns>影响的行数</returns>
		public int Update(SqlTransaction sp,wx_TuiguangEntity _wx_TuiguangModel)
		{
            string sqlStr="update wx_Tuiguang set [WeiXinCode]=@WeiXinCode,[OpenId]=@OpenId,[ShareType]=@ShareType,[PageId]=@PageId,[Status]=@Status,[AddTime]=@AddTime,[PageType]=@PageType where Id=@Id";
			SqlParameter[] _param={				
				new SqlParameter("@Id",SqlDbType.Int),
				new SqlParameter("@WeiXinCode",SqlDbType.VarChar),
				new SqlParameter("@OpenId",SqlDbType.VarChar),
				new SqlParameter("@ShareType",SqlDbType.Int),
				new SqlParameter("@PageId",SqlDbType.Int),
				new SqlParameter("@Status",SqlDbType.Int),
				new SqlParameter("@AddTime",SqlDbType.DateTime),
				new SqlParameter("@PageType",SqlDbType.Int)
				};				
				_param[0].Value=_wx_TuiguangModel.Id;
				_param[1].Value=_wx_TuiguangModel.WeiXinCode;
				_param[2].Value=_wx_TuiguangModel.OpenId;
				_param[3].Value=_wx_TuiguangModel.ShareType;
				_param[4].Value=_wx_TuiguangModel.PageId;
				_param[5].Value=_wx_TuiguangModel.Status;
				_param[6].Value=_wx_TuiguangModel.AddTime;
				_param[7].Value=_wx_TuiguangModel.PageType;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}		
		
		
		/// <summary>
		/// 删除数据表wx_Tuiguang中的一条记录
		/// </summary>
	    /// <param name="Id">id</param>
		/// <returns>影响的行数</returns>
		public int Delete(int Id)
		{
			string sqlStr="delete from wx_Tuiguang where [Id]=@Id";
			SqlParameter[] _param={			
			new SqlParameter("@Id",SqlDbType.Int),
			
			};			
			_param[0].Value=Id;
			return SqlHelper.ExecuteNonQuery(WebConfig.WfxRW,CommandType.Text,sqlStr,_param);
		}
		
		/// <summary>
		/// 删除数据表wx_Tuiguang中的一条记录,带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
	    /// <param name="Id">id</param>
		/// <returns>影响的行数</returns>
		public int Delete(SqlTransaction sp,int Id)
		{
			string sqlStr="delete from wx_Tuiguang where [Id]=@Id";
			SqlParameter[] _param={			
			new SqlParameter("@Id",SqlDbType.Int),
			
			};			
			_param[0].Value=Id;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}
		#endregion
		
		#region 数据实体
		/// <summary>
		/// 得到  wx_tuiguang 数据实体
		/// </summary>
		/// <param name="row">row</param>
		/// <returns>wx_tuiguang 数据实体</returns>
		public wx_TuiguangEntity Populate_wx_TuiguangEntity_FromDr(DataRow row)
		{
			wx_TuiguangEntity Obj = new wx_TuiguangEntity();
			if(row!=null)
			{
				Obj.Id = (( row["Id"])==DBNull.Value)?0:Convert.ToInt32( row["Id"]);
				Obj.WeiXinCode =  row["WeiXinCode"].ToString();
				Obj.OpenId =  row["OpenId"].ToString();
				Obj.ShareType = (( row["ShareType"])==DBNull.Value)?0:Convert.ToInt32( row["ShareType"]);
				Obj.PageId = (( row["PageId"])==DBNull.Value)?0:Convert.ToInt32( row["PageId"]);
				Obj.Status = (( row["Status"])==DBNull.Value)?0:Convert.ToInt32( row["Status"]);
				Obj.AddTime = (( row["AddTime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( row["AddTime"]);
				Obj.PageType = (( row["PageType"])==DBNull.Value)?0:Convert.ToInt32( row["PageType"]);
			}
			else
			{
				return null;
			}
			return Obj;
		}
		
        /// <summary>
		/// 得到  wx_tuiguang 数据实体
		/// </summary>
		/// <param name="dr">dr</param>
		/// <returns>wx_tuiguang 数据实体</returns>
		public wx_TuiguangEntity Populate_wx_TuiguangEntity_FromDr(IDataReader dr)
		{
			wx_TuiguangEntity Obj = new wx_TuiguangEntity();
			
				Obj.Id = (( dr["Id"])==DBNull.Value)?0:Convert.ToInt32( dr["Id"]);
				Obj.WeiXinCode =  dr["WeiXinCode"].ToString();
				Obj.OpenId =  dr["OpenId"].ToString();
				Obj.ShareType = (( dr["ShareType"])==DBNull.Value)?0:Convert.ToInt32( dr["ShareType"]);
				Obj.PageId = (( dr["PageId"])==DBNull.Value)?0:Convert.ToInt32( dr["PageId"]);
				Obj.Status = (( dr["Status"])==DBNull.Value)?0:Convert.ToInt32( dr["Status"]);
				Obj.AddTime = (( dr["AddTime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( dr["AddTime"]);
				Obj.PageType = (( dr["PageType"])==DBNull.Value)?0:Convert.ToInt32( dr["PageType"]);
			
			return Obj;
		}
		#endregion
		
		/// <summary>
		/// 根据ID,返回一个wx_Tuiguang对象
		/// </summary>
		/// <param name="id">id</param>
		/// <returns>wx_Tuiguang对象</returns>
		public wx_TuiguangEntity Get_wx_TuiguangEntity (int id)
		{
			wx_TuiguangEntity _obj=null;
			SqlParameter[] _param={
			new SqlParameter("@Id",SqlDbType.Int)
			};
			_param[0].Value=id;
			string sqlStr="select * from wx_Tuiguang with(nolock) where Id=@Id";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.WfxRW,CommandType.Text,sqlStr,_param))
			{
				while(dr.Read())
				{
            		_obj=Populate_wx_TuiguangEntity_FromDr(dr);
				}
			}
			return _obj;
		}
		/// <summary>
		/// 得到数据表wx_Tuiguang所有记录
		/// </summary>
		/// <returns>数据集</returns>
		public IList< wx_TuiguangEntity> Get_wx_TuiguangAll()
		{
			IList< wx_TuiguangEntity> Obj=new List< wx_TuiguangEntity>();
			string sqlStr="select * from wx_Tuiguang";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.WfxRW,CommandType.Text,sqlStr))
			{
				while(dr.Read())
				{
					Obj.Add(Populate_wx_TuiguangEntity_FromDr(dr));
				}
			}
			return Obj;
		}
		/// <summary>
        /// 检测是否存在根据主键
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>是/否</returns>
		public bool IsExistwx_Tuiguang(int id)
		{
			SqlParameter[] _param={
                                      new SqlParameter("@id",SqlDbType.Int)
                                  };
            _param[0].Value=id;
            string sqlStr="select Count(*) from wx_Tuiguang where Id=@id";
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
