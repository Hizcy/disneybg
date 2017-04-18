// =================================================================== 
// 项目说明
//====================================================================
// yangxg。@Copy Right 2014
// 文件： wx_Shop_User.cs
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
	///wx_Shop_User数据实体
	/// </summary>
	[Serializable]
	[DataContract]
	public class wx_Shop_UserEntity
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
		private int _userId;
		///<summary>
		///
		///</summary>
		private string _weiXinCode = String.Empty;
		#endregion
		
		#region 构造函数

		///<summary>
		///
		///</summary>
		public wx_Shop_UserEntity()
		{
		}
		///<summary>
		///
		///</summary>
		public wx_Shop_UserEntity
		(
			int id,
			int shopId,
			int userId,
			string weiXinCode
		)
		{
			_id         = id;
			_shopId     = shopId;
			_userId     = userId;
			_weiXinCode = weiXinCode;
			
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
		public int UserId
		{
			get {return _userId;}
			set {_userId = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string WeiXinCode
		{
			get {return _weiXinCode;}
			set {_weiXinCode = value;}
		}
	
		#endregion
		
	}
}
