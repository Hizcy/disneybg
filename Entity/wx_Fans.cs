// =================================================================== 
// 项目说明
//====================================================================
// yangxg。@Copy Right 2014
// 文件： wx_Fans.cs
// 项目名称：买车网
// 创建时间：2016/4/2
// 负责人：yangxg
// ===================================================================
using System;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ComponentModel;
namespace Weifenxiao.Entity
{
	/// <summary>
	///wx_Fans数据实体
	/// </summary>
	[Serializable]
	[DataContract]
	public class wx_FansEntity
	{
		#region 变量定义
		///<summary>
		///
		///</summary>
		private int _id;
		///<summary>
		///
		///</summary>
		private int _shopId;
		///<summary>
		///
		///</summary>
		private int _me;
		///<summary>
		///
		///</summary>
		private int _uid;
		///<summary>
		///
		///</summary>
		private int _status;
		///<summary>
		///
		///</summary>
		private DateTime _addtime;
		#endregion
		
		#region 构造函数

		///<summary>
		///
		///</summary>
		public wx_FansEntity()
		{
		}
		///<summary>
		///
		///</summary>
		public wx_FansEntity
		(
			int id,
			int shopId,
			int me,
			int uid,
			int status,
			DateTime addtime
		)
		{
			_id      = id;
			_shopId  = shopId;
			_me      = me;
			_uid     = uid;
			_status  = status;
			_addtime = addtime;
			
		}
		#endregion
		
		#region 公共属性

		
		///<summary>
		///
		///</summary>
		[DataMember]
		public int Id
		{
			get {return _id;}
			set {_id = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public int ShopId
		{
			get {return _shopId;}
			set {_shopId = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public int Me
		{
			get {return _me;}
			set {_me = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public int uid
		{
			get {return _uid;}
			set {_uid = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public int Status
		{
			get {return _status;}
			set {_status = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public DateTime Addtime
		{
			get {return _addtime;}
			set {_addtime = value;}
		}
	
		#endregion
		
	}
}
