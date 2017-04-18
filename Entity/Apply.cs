// =================================================================== 
// 项目说明
//====================================================================
// yangxg。@Copy Right 2014
// 文件： Apply.cs
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
	///Apply数据实体
	/// </summary>
	[Serializable]
	[DataContract]
	public class ApplyEntity
	{
		#region 变量定义
		///<summary>
		///
		///</summary>
		private int _applyId;
		///<summary>
		///
		///</summary>
		private int _shopId;
		///<summary>
		///
		///</summary>
		private string _openId = String.Empty;
		///<summary>
		///
		///</summary>
		private decimal _money;
		///<summary>
		///
		///</summary>
		private string _description = String.Empty;
		///<summary>
		///
		///</summary>
		private int _bankId;
		///<summary>
		///
		///</summary>
		private int _status;
		///<summary>
		///
		///</summary>
		private string _reason = String.Empty;
		///<summary>
		///
		///</summary>
		private DateTime _addtime;
		///<summary>
		///
		///</summary>
		private DateTime _updatetime;
		#endregion
		
		#region 构造函数

		///<summary>
		///
		///</summary>
		public ApplyEntity()
		{
		}
		///<summary>
		///
		///</summary>
		public ApplyEntity
		(
			int applyId,
			int shopId,
			string openId,
			decimal money,
			string description,
			int bankId,
			int status,
			string reason,
			DateTime addtime,
			DateTime updatetime
		)
		{
			_applyId     = applyId;
			_shopId      = shopId;
			_openId      = openId;
			_money       = money;
			_description = description;
			_bankId      = bankId;
			_status      = status;
			_reason      = reason;
			_addtime     = addtime;
			_updatetime  = updatetime;
			
		}
		#endregion
		
		#region 公共属性

		
		///<summary>
		///
		///</summary>
		[DataMember]
		public int ApplyId
		{
			get {return _applyId;}
			set {_applyId = value;}
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
		public string OpenId
		{
			get {return _openId;}
			set {_openId = value;}
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
		public string Description
		{
			get {return _description;}
			set {_description = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public int BankId
		{
			get {return _bankId;}
			set {_bankId = value;}
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
		public string Reason
		{
			get {return _reason;}
			set {_reason = value;}
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

		///<summary>
		///
		///</summary>
		[DataMember]
		public DateTime Updatetime
		{
			get {return _updatetime;}
			set {_updatetime = value;}
		}
	
		#endregion
		
	}
}
