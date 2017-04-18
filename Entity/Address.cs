// =================================================================== 
// 项目说明
//====================================================================
// yangxg。@Copy Right 2014
// 文件： Address.cs
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
	///Address数据实体
	/// </summary>
	[Serializable]
	[DataContract]
	public class AddressEntity
	{
		#region 变量定义
		///<summary>
		///
		///</summary>
		private int _addressId;
		///<summary>
		///
		///</summary>
		private string _openId = String.Empty;
		///<summary>
		///
		///</summary>
		private int _locationId;
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
		public AddressEntity()
		{
		}
		///<summary>
		///
		///</summary>
		public AddressEntity
		(
			int addressId,
			string openId,
			int locationId,
			string realName,
			string phone,
			string addr,
			int isdefault,
			int status,
			DateTime addtime,
			DateTime updatetime
		)
		{
			_addressId  = addressId;
			_openId     = openId;
			_locationId = locationId;
			_realName   = realName;
			_phone      = phone;
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
		public int AddressId
		{
			get {return _addressId;}
			set {_addressId = value;}
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
		public int LocationId
		{
			get {return _locationId;}
			set {_locationId = value;}
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
