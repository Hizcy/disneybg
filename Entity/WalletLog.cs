// =================================================================== 
// 项目说明
//====================================================================
// yangxg。@Copy Right 2014
// 文件： WalletLog.cs
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
	///WalletLog数据实体
	/// </summary>
	[Serializable]
	[DataContract]
	public class WalletLogEntity
	{
		#region 变量定义
		///<summary>
		///
		///</summary>
		private int _walletId;
		///<summary>
		///
		///</summary>
		private string _buyerOpenId = String.Empty;
		///<summary>
		///
		///</summary>
		private decimal _money;
		///<summary>
		///
		///</summary>
		private int _type;
		///<summary>
		///
		///</summary>
		private string _openId = String.Empty;
		///<summary>
		///
		///</summary>
		private int _orderId;
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
		public WalletLogEntity()
		{
		}
		///<summary>
		///
		///</summary>
		public WalletLogEntity
		(
			int walletId,
			string buyerOpenId,
			decimal money,
			int type,
			string openId,
			int orderId,
			int status,
			DateTime addtime
		)
		{
			_walletId    = walletId;
			_buyerOpenId = buyerOpenId;
			_money       = money;
			_type        = type;
			_openId      = openId;
			_orderId     = orderId;
			_status      = status;
			_addtime     = addtime;
			
		}
		#endregion
		
		#region 公共属性

		
		///<summary>
		///
		///</summary>
		[DataMember]
		public int WalletId
		{
			get {return _walletId;}
			set {_walletId = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string BuyerOpenId
		{
			get {return _buyerOpenId;}
			set {_buyerOpenId = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public decimal Money
		{
			get {return _money;}
			set {_money = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public int Type
		{
			get {return _type;}
			set {_type = value;}
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
		public int OrderId
		{
			get {return _orderId;}
			set {_orderId = value;}
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
