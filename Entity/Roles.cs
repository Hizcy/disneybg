// =================================================================== 
// 项目说明
//====================================================================
// yangxg。@Copy Right 2014
// 文件： Roles.cs
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
	///Roles数据实体
	/// </summary>
	[Serializable]
	[DataContract]
	public class RolesEntity
	{
		#region 变量定义
		///<summary>
		///
		///</summary>
		private int _roleId;
		///<summary>
		///
		///</summary>
		private int _shopId;
		///<summary>
		///
		///</summary>
		private string _name = String.Empty;
		///<summary>
		///
		///</summary>
		private int _permission;
		///<summary>
		///
		///</summary>
		private decimal _price;
		///<summary>
		///
		///</summary>
		private string _description = String.Empty;
		#endregion
		
		#region 构造函数

		///<summary>
		///
		///</summary>
		public RolesEntity()
		{
		}
		///<summary>
		///
		///</summary>
		public RolesEntity
		(
			int roleId,
			int shopId,
			string name,
			int permission,
			decimal price,
			string description
		)
		{
			_roleId      = roleId;
			_shopId      = shopId;
			_name        = name;
			_permission  = permission;
			_price       = price;
			_description = description;
			
		}
		#endregion
		
		#region 公共属性

		
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
		public int ShopId
		{
			get {return _shopId;}
			set {_shopId = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string Name
		{
			get {return _name;}
			set {_name = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public int Permission
		{
			get {return _permission;}
			set {_permission = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public decimal price
		{
			get {return _price;}
			set {_price = value;}
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
	
		#endregion
		
	}
}
