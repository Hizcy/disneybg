// =================================================================== 
// 项目说明
//====================================================================
// yangxg。@Copy Right 2014
// 文件： wx_Users.cs
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
	///wx_Users数据实体
	/// </summary>
	[Serializable]
	[DataContract]
	public class wx_UsersEntity
	{
		#region 变量定义
		///<summary>
		///
		///</summary>
		private int _userId;
		///<summary>
		///
		///</summary>
		private string _realName = String.Empty;
		///<summary>
		///
		///</summary>
		private string _phone = String.Empty;
		///<summary>
		///
		///</summary>
		private string _weixin = String.Empty;
		///<summary>
		///
		///</summary>
		private string _description = String.Empty;
		///<summary>
		///
		///</summary>
		private string _openId = String.Empty;
		///<summary>
		///
		///</summary>
		private int _shopId;
		///<summary>
		///
		///</summary>
		private int _roleId;
		///<summary>
		///
		///</summary>
		private int _status;
		///<summary>
		///
		///</summary>
		private string _address = String.Empty;
		///<summary>
		///
		///</summary>
		private int _points;
		///<summary>
		///
		///</summary>
		private decimal _wallet;
		///<summary>
		///
		///</summary>
		private DateTime _addTime;
		///<summary>
		///
		///</summary>
		private DateTime _updateTime;
		///<summary>
		///
		///</summary>
		private int _parentId;
		#endregion
		
		#region 构造函数

		///<summary>
		///
		///</summary>
		public wx_UsersEntity()
		{
		}
		///<summary>
		///
		///</summary>
		public wx_UsersEntity
		(
			int userId,
			string realName,
			string phone,
			string weixin,
			string description,
			string openId,
			int shopId,
			int roleId,
			int status,
			string address,
			int points,
			decimal wallet,
			DateTime addTime,
			DateTime updateTime,
			int parentId
		)
		{
			_userId      = userId;
			_realName    = realName;
			_phone       = phone;
			_weixin      = weixin;
			_description = description;
			_openId      = openId;
			_shopId      = shopId;
			_roleId      = roleId;
			_status      = status;
			_address     = address;
			_points      = points;
			_wallet      = wallet;
			_addTime     = addTime;
			_updateTime  = updateTime;
			_parentId    = parentId;
			
		}
		#endregion
		
		#region 公共属性

		
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
		public string RealName
		{
			get {return _realName;}
			set {_realName = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string Phone
		{
			get {return _phone;}
			set {_phone = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string Weixin
		{
			get {return _weixin;}
			set {_weixin = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string Description
		{
			get {return _description;}
			set {_description = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string OpenId
		{
			get {return _openId;}
			set {_openId = value;}
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
		public int RoleId
		{
			get {return _roleId;}
			set {_roleId = value;}
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
		public string Address
		{
			get {return _address;}
			set {_address = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public int Points
		{
			get {return _points;}
			set {_points = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public decimal Wallet
		{
			get {return _wallet;}
			set {_wallet = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public DateTime AddTime
		{
			get {return _addTime;}
			set {_addTime = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public DateTime UpdateTime
		{
			get {return _updateTime;}
			set {_updateTime = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public int ParentId
		{
			get {return _parentId;}
			set {_parentId = value;}
		}
	
		#endregion
		
	}
}
