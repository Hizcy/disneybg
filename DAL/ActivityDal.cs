// =================================================================== 
// 项目说明
//====================================================================
// yangxg。@Copy Right 2014
// 文件： Activity.cs
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
    /// 数据层实例化接口类 dbo.Activity.
    /// </summary>
    public partial class ActivityDataAccessLayer 
    {
		#region 构造函数


		/// <summary>
		/// 
		/// </summary>
		public ActivityDataAccessLayer()
		{
		}
		#endregion

        #region -----------实例化接口函数-----------
		
		#region 添加更新删除
		/// <summary>
		/// 向数据库中插入一条新记录。
		/// </summary>
		/// <param name="_ActivityModel">Activity实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(ActivityEntity _ActivityModel)
		{
			string sqlStr="insert into Activity([ShopId],[MenuId],[ActivityName],[AcivityDesc],[ActivityImage],[Ext1],[Ext2],[Ext3],[Ext4],[Ext5],[Ext6],[AddTime],[UpdateTime],[Belong],[Type]) values(@ShopId,@MenuId,@ActivityName,@AcivityDesc,@ActivityImage,@Ext1,@Ext2,@Ext3,@Ext4,@Ext5,@Ext6,@AddTime,@UpdateTime,@Belong,@Type) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@ShopId",SqlDbType.Int),
			new SqlParameter("@MenuId",SqlDbType.Int),
			new SqlParameter("@ActivityName",SqlDbType.VarChar),
			new SqlParameter("@AcivityDesc",SqlDbType.VarChar),
			new SqlParameter("@ActivityImage",SqlDbType.VarChar),
			new SqlParameter("@Ext1",SqlDbType.VarChar),
			new SqlParameter("@Ext2",SqlDbType.VarChar),
			new SqlParameter("@Ext3",SqlDbType.VarChar),
			new SqlParameter("@Ext4",SqlDbType.VarChar),
			new SqlParameter("@Ext5",SqlDbType.VarChar),
			new SqlParameter("@Ext6",SqlDbType.VarChar),
			new SqlParameter("@AddTime",SqlDbType.DateTime),
			new SqlParameter("@UpdateTime",SqlDbType.DateTime),
			new SqlParameter("@Belong",SqlDbType.Int),
			new SqlParameter("@Type",SqlDbType.Int)
			};			
			_param[0].Value=_ActivityModel.ShopId;
			_param[1].Value=_ActivityModel.MenuId;
			_param[2].Value=_ActivityModel.ActivityName;
			_param[3].Value=_ActivityModel.AcivityDesc;
			_param[4].Value=_ActivityModel.ActivityImage;
			_param[5].Value=_ActivityModel.Ext1;
			_param[6].Value=_ActivityModel.Ext2;
			_param[7].Value=_ActivityModel.Ext3;
			_param[8].Value=_ActivityModel.Ext4;
			_param[9].Value=_ActivityModel.Ext5;
			_param[10].Value=_ActivityModel.Ext6;
			_param[11].Value=_ActivityModel.AddTime;
			_param[12].Value=_ActivityModel.UpdateTime;
			_param[13].Value=_ActivityModel.Belong;
			_param[14].Value=_ActivityModel.Type;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.WfxRW,CommandType.Text,sqlStr,_param));
			return res;
		}
		/// <summary>
		/// 向数据库中插入一条新记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_ActivityModel">Activity实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(SqlTransaction sp,ActivityEntity _ActivityModel)
		{
			string sqlStr="insert into Activity([ShopId],[MenuId],[ActivityName],[AcivityDesc],[ActivityImage],[Ext1],[Ext2],[Ext3],[Ext4],[Ext5],[Ext6],[AddTime],[UpdateTime],[Belong],[Type]) values(@ShopId,@MenuId,@ActivityName,@AcivityDesc,@ActivityImage,@Ext1,@Ext2,@Ext3,@Ext4,@Ext5,@Ext6,@AddTime,@UpdateTime,@Belong,@Type) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@ShopId",SqlDbType.Int),
			new SqlParameter("@MenuId",SqlDbType.Int),
			new SqlParameter("@ActivityName",SqlDbType.VarChar),
			new SqlParameter("@AcivityDesc",SqlDbType.VarChar),
			new SqlParameter("@ActivityImage",SqlDbType.VarChar),
			new SqlParameter("@Ext1",SqlDbType.VarChar),
			new SqlParameter("@Ext2",SqlDbType.VarChar),
			new SqlParameter("@Ext3",SqlDbType.VarChar),
			new SqlParameter("@Ext4",SqlDbType.VarChar),
			new SqlParameter("@Ext5",SqlDbType.VarChar),
			new SqlParameter("@Ext6",SqlDbType.VarChar),
			new SqlParameter("@AddTime",SqlDbType.DateTime),
			new SqlParameter("@UpdateTime",SqlDbType.DateTime),
			new SqlParameter("@Belong",SqlDbType.Int),
			new SqlParameter("@Type",SqlDbType.Int)
			};			
			_param[0].Value=_ActivityModel.ShopId;
			_param[1].Value=_ActivityModel.MenuId;
			_param[2].Value=_ActivityModel.ActivityName;
			_param[3].Value=_ActivityModel.AcivityDesc;
			_param[4].Value=_ActivityModel.ActivityImage;
			_param[5].Value=_ActivityModel.Ext1;
			_param[6].Value=_ActivityModel.Ext2;
			_param[7].Value=_ActivityModel.Ext3;
			_param[8].Value=_ActivityModel.Ext4;
			_param[9].Value=_ActivityModel.Ext5;
			_param[10].Value=_ActivityModel.Ext6;
			_param[11].Value=_ActivityModel.AddTime;
			_param[12].Value=_ActivityModel.UpdateTime;
			_param[13].Value=_ActivityModel.Belong;
			_param[14].Value=_ActivityModel.Type;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(sp,CommandType.Text,sqlStr,_param));
			return res;
		}


		/// <summary>
		/// 向数据表Activity更新一条记录。
		/// </summary>
		/// <param name="_ActivityModel">_ActivityModel</param>
		/// <returns>影响的行数</returns>
		public int Update(ActivityEntity _ActivityModel)
		{
            string sqlStr="update Activity set [ShopId]=@ShopId,[MenuId]=@MenuId,[ActivityName]=@ActivityName,[AcivityDesc]=@AcivityDesc,[ActivityImage]=@ActivityImage,[Ext1]=@Ext1,[Ext2]=@Ext2,[Ext3]=@Ext3,[Ext4]=@Ext4,[Ext5]=@Ext5,[Ext6]=@Ext6,[AddTime]=@AddTime,[UpdateTime]=@UpdateTime,[Belong]=@Belong,[Type]=@Type where ActivityId=@ActivityId";
			SqlParameter[] _param={				
				new SqlParameter("@ActivityId",SqlDbType.Int),
				new SqlParameter("@ShopId",SqlDbType.Int),
				new SqlParameter("@MenuId",SqlDbType.Int),
				new SqlParameter("@ActivityName",SqlDbType.VarChar),
				new SqlParameter("@AcivityDesc",SqlDbType.VarChar),
				new SqlParameter("@ActivityImage",SqlDbType.VarChar),
				new SqlParameter("@Ext1",SqlDbType.VarChar),
				new SqlParameter("@Ext2",SqlDbType.VarChar),
				new SqlParameter("@Ext3",SqlDbType.VarChar),
				new SqlParameter("@Ext4",SqlDbType.VarChar),
				new SqlParameter("@Ext5",SqlDbType.VarChar),
				new SqlParameter("@Ext6",SqlDbType.VarChar),
				new SqlParameter("@AddTime",SqlDbType.DateTime),
				new SqlParameter("@UpdateTime",SqlDbType.DateTime),
				new SqlParameter("@Belong",SqlDbType.Int),
				new SqlParameter("@Type",SqlDbType.Int)
				};				
				_param[0].Value=_ActivityModel.ActivityId;
				_param[1].Value=_ActivityModel.ShopId;
				_param[2].Value=_ActivityModel.MenuId;
				_param[3].Value=_ActivityModel.ActivityName;
				_param[4].Value=_ActivityModel.AcivityDesc;
				_param[5].Value=_ActivityModel.ActivityImage;
				_param[6].Value=_ActivityModel.Ext1;
				_param[7].Value=_ActivityModel.Ext2;
				_param[8].Value=_ActivityModel.Ext3;
				_param[9].Value=_ActivityModel.Ext4;
				_param[10].Value=_ActivityModel.Ext5;
				_param[11].Value=_ActivityModel.Ext6;
				_param[12].Value=_ActivityModel.AddTime;
				_param[13].Value=_ActivityModel.UpdateTime;
				_param[14].Value=_ActivityModel.Belong;
				_param[15].Value=_ActivityModel.Type;
			return SqlHelper.ExecuteNonQuery(WebConfig.WfxRW,CommandType.Text,sqlStr,_param);
		}
		/// <summary>
		/// 向数据表Activity更新一条记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_ActivityModel">_ActivityModel</param>
		/// <returns>影响的行数</returns>
		public int Update(SqlTransaction sp,ActivityEntity _ActivityModel)
		{
            string sqlStr="update Activity set [ShopId]=@ShopId,[MenuId]=@MenuId,[ActivityName]=@ActivityName,[AcivityDesc]=@AcivityDesc,[ActivityImage]=@ActivityImage,[Ext1]=@Ext1,[Ext2]=@Ext2,[Ext3]=@Ext3,[Ext4]=@Ext4,[Ext5]=@Ext5,[Ext6]=@Ext6,[AddTime]=@AddTime,[UpdateTime]=@UpdateTime,[Belong]=@Belong,[Type]=@Type where ActivityId=@ActivityId";
			SqlParameter[] _param={				
				new SqlParameter("@ActivityId",SqlDbType.Int),
				new SqlParameter("@ShopId",SqlDbType.Int),
				new SqlParameter("@MenuId",SqlDbType.Int),
				new SqlParameter("@ActivityName",SqlDbType.VarChar),
				new SqlParameter("@AcivityDesc",SqlDbType.VarChar),
				new SqlParameter("@ActivityImage",SqlDbType.VarChar),
				new SqlParameter("@Ext1",SqlDbType.VarChar),
				new SqlParameter("@Ext2",SqlDbType.VarChar),
				new SqlParameter("@Ext3",SqlDbType.VarChar),
				new SqlParameter("@Ext4",SqlDbType.VarChar),
				new SqlParameter("@Ext5",SqlDbType.VarChar),
				new SqlParameter("@Ext6",SqlDbType.VarChar),
				new SqlParameter("@AddTime",SqlDbType.DateTime),
				new SqlParameter("@UpdateTime",SqlDbType.DateTime),
				new SqlParameter("@Belong",SqlDbType.Int),
				new SqlParameter("@Type",SqlDbType.Int)
				};				
				_param[0].Value=_ActivityModel.ActivityId;
				_param[1].Value=_ActivityModel.ShopId;
				_param[2].Value=_ActivityModel.MenuId;
				_param[3].Value=_ActivityModel.ActivityName;
				_param[4].Value=_ActivityModel.AcivityDesc;
				_param[5].Value=_ActivityModel.ActivityImage;
				_param[6].Value=_ActivityModel.Ext1;
				_param[7].Value=_ActivityModel.Ext2;
				_param[8].Value=_ActivityModel.Ext3;
				_param[9].Value=_ActivityModel.Ext4;
				_param[10].Value=_ActivityModel.Ext5;
				_param[11].Value=_ActivityModel.Ext6;
				_param[12].Value=_ActivityModel.AddTime;
				_param[13].Value=_ActivityModel.UpdateTime;
				_param[14].Value=_ActivityModel.Belong;
				_param[15].Value=_ActivityModel.Type;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}		
		
		
		/// <summary>
		/// 删除数据表Activity中的一条记录
		/// </summary>
	    /// <param name="ActivityId">activityId</param>
		/// <returns>影响的行数</returns>
		public int Delete(int ActivityId)
		{
			string sqlStr="delete from Activity where [ActivityId]=@ActivityId";
			SqlParameter[] _param={			
			new SqlParameter("@ActivityId",SqlDbType.Int),
			
			};			
			_param[0].Value=ActivityId;
			return SqlHelper.ExecuteNonQuery(WebConfig.WfxRW,CommandType.Text,sqlStr,_param);
		}
		
		/// <summary>
		/// 删除数据表Activity中的一条记录,带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
	    /// <param name="ActivityId">activityId</param>
		/// <returns>影响的行数</returns>
		public int Delete(SqlTransaction sp,int ActivityId)
		{
			string sqlStr="delete from Activity where [ActivityId]=@ActivityId";
			SqlParameter[] _param={			
			new SqlParameter("@ActivityId",SqlDbType.Int),
			
			};			
			_param[0].Value=ActivityId;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}
		#endregion
		
		#region 数据实体
		/// <summary>
		/// 得到  activity 数据实体
		/// </summary>
		/// <param name="row">row</param>
		/// <returns>activity 数据实体</returns>
		public ActivityEntity Populate_ActivityEntity_FromDr(DataRow row)
		{
			ActivityEntity Obj = new ActivityEntity();
			if(row!=null)
			{
				Obj.ActivityId = (( row["ActivityId"])==DBNull.Value)?0:Convert.ToInt32( row["ActivityId"]);
				Obj.ShopId = (( row["ShopId"])==DBNull.Value)?0:Convert.ToInt32( row["ShopId"]);
				Obj.MenuId = (( row["MenuId"])==DBNull.Value)?0:Convert.ToInt32( row["MenuId"]);
				Obj.ActivityName =  row["ActivityName"].ToString();
				Obj.AcivityDesc =  row["AcivityDesc"].ToString();
				Obj.ActivityImage =  row["ActivityImage"].ToString();
				Obj.Ext1 =  row["Ext1"].ToString();
				Obj.Ext2 =  row["Ext2"].ToString();
				Obj.Ext3 =  row["Ext3"].ToString();
				Obj.Ext4 =  row["Ext4"].ToString();
				Obj.Ext5 =  row["Ext5"].ToString();
				Obj.Ext6 =  row["Ext6"].ToString();
				Obj.AddTime = (( row["AddTime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( row["AddTime"]);
				Obj.UpdateTime = (( row["UpdateTime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( row["UpdateTime"]);
				Obj.Belong = (( row["Belong"])==DBNull.Value)?0:Convert.ToInt32( row["Belong"]);
				Obj.Type = (( row["Type"])==DBNull.Value)?0:Convert.ToInt32( row["Type"]);
			}
			else
			{
				return null;
			}
			return Obj;
		}
		
        /// <summary>
		/// 得到  activity 数据实体
		/// </summary>
		/// <param name="dr">dr</param>
		/// <returns>activity 数据实体</returns>
		public ActivityEntity Populate_ActivityEntity_FromDr(IDataReader dr)
		{
			ActivityEntity Obj = new ActivityEntity();
			
				Obj.ActivityId = (( dr["ActivityId"])==DBNull.Value)?0:Convert.ToInt32( dr["ActivityId"]);
				Obj.ShopId = (( dr["ShopId"])==DBNull.Value)?0:Convert.ToInt32( dr["ShopId"]);
				Obj.MenuId = (( dr["MenuId"])==DBNull.Value)?0:Convert.ToInt32( dr["MenuId"]);
				Obj.ActivityName =  dr["ActivityName"].ToString();
				Obj.AcivityDesc =  dr["AcivityDesc"].ToString();
				Obj.ActivityImage =  dr["ActivityImage"].ToString();
				Obj.Ext1 =  dr["Ext1"].ToString();
				Obj.Ext2 =  dr["Ext2"].ToString();
				Obj.Ext3 =  dr["Ext3"].ToString();
				Obj.Ext4 =  dr["Ext4"].ToString();
				Obj.Ext5 =  dr["Ext5"].ToString();
				Obj.Ext6 =  dr["Ext6"].ToString();
				Obj.AddTime = (( dr["AddTime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( dr["AddTime"]);
				Obj.UpdateTime = (( dr["UpdateTime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( dr["UpdateTime"]);
				Obj.Belong = (( dr["Belong"])==DBNull.Value)?0:Convert.ToInt32( dr["Belong"]);
				Obj.Type = (( dr["Type"])==DBNull.Value)?0:Convert.ToInt32( dr["Type"]);
			
			return Obj;
		}
		#endregion
		
		/// <summary>
		/// 根据ID,返回一个Activity对象
		/// </summary>
		/// <param name="activityId">activityId</param>
		/// <returns>Activity对象</returns>
		public ActivityEntity Get_ActivityEntity (int activityId)
		{
			ActivityEntity _obj=null;
			SqlParameter[] _param={
			new SqlParameter("@ActivityId",SqlDbType.Int)
			};
			_param[0].Value=activityId;
			string sqlStr="select * from Activity with(nolock) where ActivityId=@ActivityId";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.WfxRW,CommandType.Text,sqlStr,_param))
			{
				while(dr.Read())
				{
            		_obj=Populate_ActivityEntity_FromDr(dr);
				}
			}
			return _obj;
		}
		/// <summary>
		/// 得到数据表Activity所有记录
		/// </summary>
		/// <returns>数据集</returns>
		public IList< ActivityEntity> Get_ActivityAll()
		{
			IList< ActivityEntity> Obj=new List< ActivityEntity>();
			string sqlStr="select * from Activity";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.WfxRW,CommandType.Text,sqlStr))
			{
				while(dr.Read())
				{
					Obj.Add(Populate_ActivityEntity_FromDr(dr));
				}
			}
			return Obj;
		}
		/// <summary>
        /// 检测是否存在根据主键
        /// </summary>
        /// <param name="activityId">activityId</param>
        /// <returns>是/否</returns>
		public bool IsExistActivity(int activityId)
		{
			SqlParameter[] _param={
                                      new SqlParameter("@activityId",SqlDbType.Int)
                                  };
            _param[0].Value=activityId;
            string sqlStr="select Count(*) from Activity where ActivityId=@activityId";
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
