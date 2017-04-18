// =================================================================== 
// 项目说明
//====================================================================
// yangxg。@Copy Right 2014
// 文件： T_Orders.cs
// 项目名称：买车网
// 创建时间：2016/8/12
// 负责人：yangxg
// ===================================================================
using System;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ComponentModel;
namespace Weifenxiao.Entity
{
	/// <summary>
	///T_Orders数据实体
	/// </summary>
	[Serializable]
	[DataContract]
	public class T_OrdersEntity
	{
		#region 变量定义
		///<summary>
		///
		///</summary>
		private int _orderId;
		///<summary>
		///
		///</summary>
		private string _orderCode = String.Empty;
		///<summary>
		///
		///</summary>
		private int _userId;
		///<summary>
		///
		///</summary>
		private int _paymentId;
		///<summary>
		///
		///</summary>
		private decimal _totalPrice;
		///<summary>
		///
		///</summary>
		private decimal _postage;
		///<summary>
		///
		///</summary>
		private int _status;
		///<summary>
		///
		///</summary>
		private string _consignee = String.Empty;
		///<summary>
		///
		///</summary>
		private int _locationId;
		///<summary>
		///
		///</summary>
		private string _buyer = String.Empty;
		///<summary>
		///
		///</summary>
		private string _phone = String.Empty;
		///<summary>
		///
		///</summary>
		private string _address = String.Empty;
		///<summary>
		///
		///</summary>
		private string _description = String.Empty;
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
		private DateTime _confirmTime;
		///<summary>
		///
		///</summary>
		private DateTime _sendTime;
		///<summary>
		///
		///</summary>
		private int _expresstype;
		///<summary>
		///
		///</summary>
		private string _expresscode = String.Empty;
		///<summary>
		///
		///</summary>
		private int _ordertype;
		///<summary>
		///
		///</summary>
		private DateTime _refundTime;
		///<summary>
		///
		///</summary>
		private DateTime _returnTime;
		///<summary>
		///
		///</summary>
		private string _daili = String.Empty;
		///<summary>
		///
		///</summary>
		private int _shopId;
		///<summary>
		///
		///</summary>
		private string _groupNo = String.Empty;
		///<summary>
		///
		///</summary>
		private int _groupNum;
		///<summary>
		///
		///</summary>
		private int _headStatus;
		///<summary>
		///
		///</summary>
		private int _groupStatus;
		#endregion
		
		#region 构造函数

		///<summary>
		///
		///</summary>
		public T_OrdersEntity()
		{
		}
		///<summary>
		///
		///</summary>
		public T_OrdersEntity
		(
			int orderId,
			string orderCode,
			int userId,
			int paymentId,
			decimal totalPrice,
			decimal postage,
			int status,
			string consignee,
			int locationId,
			string buyer,
			string phone,
			string address,
			string description,
			DateTime addTime,
			DateTime updateTime,
			DateTime confirmTime,
			DateTime sendTime,
			int expresstype,
			string expresscode,
			int ordertype,
			DateTime refundTime,
			DateTime returnTime,
			string daili,
			int shopId,
			string groupNo,
			int groupNum,
			int headStatus,
			int groupStatus
		)
		{
			_orderId     = orderId;
			_orderCode   = orderCode;
			_userId      = userId;
			_paymentId   = paymentId;
			_totalPrice  = totalPrice;
			_postage     = postage;
			_status      = status;
			_consignee   = consignee;
			_locationId  = locationId;
			_buyer       = buyer;
			_phone       = phone;
			_address     = address;
			_description = description;
			_addTime     = addTime;
			_updateTime  = updateTime;
			_confirmTime = confirmTime;
			_sendTime    = sendTime;
			_expresstype = expresstype;
			_expresscode = expresscode;
			_ordertype   = ordertype;
			_refundTime  = refundTime;
			_returnTime  = returnTime;
			_daili       = daili;
			_shopId      = shopId;
			_groupNo     = groupNo;
			_groupNum    = groupNum;
			_headStatus  = headStatus;
			_groupStatus = groupStatus;
			
		}
		#endregion
		
		#region 公共属性

		
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
		public string OrderCode
		{
			get {return _orderCode;}
			set {_orderCode = value;}
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
		public int PaymentId
		{
			get {return _paymentId;}
			set {_paymentId = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public decimal TotalPrice
		{
			get {return _totalPrice;}
			set {_totalPrice = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public decimal Postage
		{
			get {return _postage;}
			set {_postage = value;}
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
		public string Consignee
		{
			get {return _consignee;}
			set {_consignee = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public int LocationId
		{
			get {return _locationId;}
			set {_locationId = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string Buyer
		{
			get {return _buyer;}
			set {_buyer = value;}
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
		public string Address
		{
			get {return _address;}
			set {_address = value;}
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
		public DateTime ConfirmTime
		{
			get {return _confirmTime;}
			set {_confirmTime = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public DateTime SendTime
		{
			get {return _sendTime;}
			set {_sendTime = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public int expresstype
		{
			get {return _expresstype;}
			set {_expresstype = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string expresscode
		{
			get {return _expresscode;}
			set {_expresscode = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public int ordertype
		{
			get {return _ordertype;}
			set {_ordertype = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public DateTime RefundTime
		{
			get {return _refundTime;}
			set {_refundTime = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public DateTime ReturnTime
		{
			get {return _returnTime;}
			set {_returnTime = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string Daili
		{
			get {return _daili;}
			set {_daili = value;}
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
		public string GroupNo
		{
			get {return _groupNo;}
			set {_groupNo = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public int GroupNum
		{
			get {return _groupNum;}
			set {_groupNum = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public int HeadStatus
		{
			get {return _headStatus;}
			set {_headStatus = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public int GroupStatus
		{
			get {return _groupStatus;}
			set {_groupStatus = value;}
		}
	
		#endregion
		
	}
}
