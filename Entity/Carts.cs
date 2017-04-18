// =================================================================== 
// 项目说明
//====================================================================
// yangxg。@Copy Right 2014
// 文件： Carts.cs
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
	///Carts数据实体
	/// </summary>
	[Serializable]
	[DataContract]
	public class CartsEntity
	{
		#region 变量定义
		///<summary>
		///
		///</summary>
		private int _cartId;
		///<summary>
		///
		///</summary>
		private int _productId;
		///<summary>
		///
		///</summary>
		private string _uid = String.Empty;
		///<summary>
		///
		///</summary>
		private int _number;
		///<summary>
		///
		///</summary>
		private int _status;
		///<summary>
		///
		///</summary>
		private DateTime _addTime;
		///<summary>
		///
		///</summary>
		private DateTime _updateTime;
		#endregion
		
		#region 构造函数

		///<summary>
		///
		///</summary>
		public CartsEntity()
		{
		}
		///<summary>
		///
		///</summary>
		public CartsEntity
		(
			int cartId,
			int productId,
			string uid,
			int number,
			int status,
			DateTime addTime,
			DateTime updateTime
		)
		{
			_cartId     = cartId;
			_productId  = productId;
			_uid        = uid;
			_number     = number;
			_status     = status;
			_addTime    = addTime;
			_updateTime = updateTime;
			
		}
		#endregion
		
		#region 公共属性

		
		///<summary>
		///
		///</summary>
		[DataMember]
		public int CartId
		{
			get {return _cartId;}
			set {_cartId = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public int ProductId
		{
			get {return _productId;}
			set {_productId = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string uid
		{
			get {return _uid;}
			set {_uid = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public int Number
		{
			get {return _number;}
			set {_number = value;}
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
	
		#endregion
		
	}
}
