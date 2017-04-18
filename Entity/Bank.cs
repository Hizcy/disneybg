// =================================================================== 
// 项目说明
//====================================================================
// yangxg。@Copy Right 2014
// 文件： Bank.cs
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
	///Bank数据实体
	/// </summary>
	[Serializable]
	[DataContract]
	public class BankEntity
	{
		#region 变量定义
		///<summary>
		///
		///</summary>
		private int _bankId;
		///<summary>
		///
		///</summary>
		private string _uid = String.Empty;
		///<summary>
		///
		///</summary>
		private int _type;
		///<summary>
		///
		///</summary>
		private string _realName = String.Empty;
		///<summary>
		///
		///</summary>
		private string _cardNumber = String.Empty;
		///<summary>
		///
		///</summary>
		private string _addr = String.Empty;
		///<summary>
		///
		///</summary>
		private int _isdefault;
		///<summary>
		///
		///</summary>
		private int _status;
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
		public BankEntity()
		{
		}
		///<summary>
		///
		///</summary>
		public BankEntity
		(
			int bankId,
			string uid,
			int type,
			string realName,
			string cardNumber,
			string addr,
			int isdefault,
			int status,
			DateTime addtime,
			DateTime updatetime
		)
		{
			_bankId     = bankId;
			_uid        = uid;
			_type       = type;
			_realName   = realName;
			_cardNumber = cardNumber;
			_addr       = addr;
			_isdefault  = isdefault;
			_status     = status;
			_addtime    = addtime;
			_updatetime = updatetime;
			
		}
		#endregion
		
		#region 公共属性

		
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
		public string uid
		{
			get {return _uid;}
			set {_uid = value;}
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
		public string RealName
		{
			get {return _realName;}
			set {_realName = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string CardNumber
		{
			get {return _cardNumber;}
			set {_cardNumber = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string Addr
		{
			get {return _addr;}
			set {_addr = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public int Isdefault
		{
			get {return _isdefault;}
			set {_isdefault = value;}
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
