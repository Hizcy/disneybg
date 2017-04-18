// =================================================================== 
// 项目说明
//====================================================================
// yangxg。@Copy Right 2014
// 文件： T_OrdersItem.cs
// 项目名称：买车网
// 创建时间：2016/8/11
// 负责人：yangxg
// ===================================================================
using System;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ComponentModel;
namespace Weifenxiao.Entity
{
	/// <summary>
	///T_OrdersItem数据实体
	/// </summary>
	[Serializable]
	[DataContract]
	public class T_OrdersItemEntity
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
		///<summary>
		///
		///</summary>
		private int _productSkuId;
		#endregion
		
		#region 构造函数

		///<summary>
		///
		///</summary>
		public T_OrdersItemEntity()
		{
		}
		///<summary>
		///
		///</summary>
		public T_OrdersItemEntity
		(
			int orderItemId,
			int orderId,
			int productId,
			int number,
			decimal price,
			decimal costPrice,
			int productSkuId
		)
		{
			_orderItemId  = orderItemId;
			_orderId      = orderId;
			_productId    = productId;
			_number       = number;
			_price        = price;
			_costPrice    = costPrice;
			_productSkuId = productSkuId;
			
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

		///<summary>
		///
		///</summary>
		[DataMember]
		public int ProductSkuId
		{
			get {return _productSkuId;}
			set {_productSkuId = value;}
		}
	
		#endregion
		
	}
}
