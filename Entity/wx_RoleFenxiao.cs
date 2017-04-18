// =================================================================== 
// 项目说明
//====================================================================
// yangxg。@Copy Right 2014
// 文件： wx_RoleFenxiao.cs
// 项目名称：买车网
// 创建时间：2016/5/22
// 负责人：yangxg
// ===================================================================
using System;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ComponentModel;
namespace Weifenxiao.Entity
{
	/// <summary>
	///wx_RoleFenxiao数据实体
	/// </summary>
	[Serializable]
	[DataContract]
	public class wx_RoleFenxiaoEntity
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
		private int _roleId;
		///<summary>
		///
		///</summary>
		private decimal _commission;
		///<summary>
		///
		///</summary>
		private int _setRoleId;
		///<summary>
		///
		///</summary>
		private decimal _quDao;
		#endregion
		
		#region 构造函数

		///<summary>
		///
		///</summary>
		public wx_RoleFenxiaoEntity()
		{
		}
		///<summary>
		///
		///</summary>
		public wx_RoleFenxiaoEntity
		(
			int id,
			int shopId,
			int roleId,
			decimal commission,
			int setRoleId,
			decimal quDao
		)
		{
			_id         = id;
			_shopId     = shopId;
			_roleId     = roleId;
			_commission = commission;
			_setRoleId  = setRoleId;
			_quDao      = quDao;
			
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
		public int RoleId
		{
			get {return _roleId;}
			set {_roleId = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public decimal Commission
		{
			get {return _commission;}
			set {_commission = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public int SetRoleId
		{
			get {return _setRoleId;}
			set {_setRoleId = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public decimal QuDao
		{
			get {return _quDao;}
			set {_quDao = value;}
		}
	
		#endregion
		
	}
}
