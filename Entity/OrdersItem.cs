// =================================================================== 
// 项目说明
//====================================================================
// yangxg。@Copy Right 2014
// 文件： OrdersItem.cs
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
	///OrdersItem数据实体
	/// </summary>
	[Serializable]
	[DataContract]
	public class OrdersItemEntity
	{
		#region 变量定义
		///<summary>
		///
		///</summary>
		private int _orderItemId;
		///<summary>
		///
		///</summary>
		private int _orderId;
		///<summary>
		///
		///</summary>
		private int _productId;
		///<summary>
		///
		///</summary>
		private int _number;
		///<summary>
		///
		///</summary>
		private decimal _price;
		///<summary>
		///
		///</summary>
		private decimal _costPrice;
		#endregion
		
		#region 构造函数

		///<summary>
		///
		///</summary>
		public OrdersItemEntity()
		{
		}
		///<summary>
		///
		///</summary>
		public OrdersItemEntity
		(
			int orderItemId,
			int orderId,
			int productId,
			int number,
			decimal price,
			decimal costPrice
		)
		{
			_orderItemId = orderItemId;
			_orderId     = orderId;
			_productId   = productId;
			_number      = number;
			_price       = price;
			_costPrice   = costPrice;
			
		}
		#endregion
		
		#region 公共属性

		
		///<summary>
		///
		///</summary>
		[DataMember]
		public int OrderItemId
		{
			get {return _orderItemId;}
			set {_orderItemId = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public int OrderId
		{
			get {return _orderId;}
			set {_orderId = value;}
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
		public int Number
		{
			get {return _number;}
			set {_number = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public decimal Price
		{
			get {return _price;}
			set {_price = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public decimal CostPrice
		{
			get {return _costPrice;}
			set {_costPrice = value;}
		}
	
		#endregion
		
	}
}
