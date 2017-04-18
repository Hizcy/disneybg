// =================================================================== 
// 项目说明
//====================================================================
// yangxg。@Copy Right 2014
// 文件： wx_Config.cs
// 项目名称：买车网
// 创建时间：2016/6/23
// 负责人：yangxg
// ===================================================================
using System;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ComponentModel;
namespace Weifenxiao.Entity
{
	/// <summary>
	///wx_Config数据实体
	/// </summary>
	[Serializable]
	[DataContract]
	public class wx_ConfigEntity
	{
		#region 变量定义
		///<summary>
		///
		///</summary>
		private int _id;
		///<summary>
		///
		///</summary>
		private string _name = String.Empty;
		///<summary>
		///
		///</summary>
		private int _propertyId;
		///<summary>
		///
		///</summary>
		private string _propertyKey = String.Empty;
		///<summary>
		///
		///</summary>
		private string _propertyValue = String.Empty;
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
		private DateTime _uptatetime;
		#endregion
		
		#region 构造函数

		///<summary>
		///
		///</summary>
		public wx_ConfigEntity()
		{
		}
		///<summary>
		///
		///</summary>
		public wx_ConfigEntity
		(
			int id,
			string name,
			int propertyId,
			string propertyKey,
			string propertyValue,
			int status,
			DateTime addtime,
			DateTime uptatetime
		)
		{
			_id            = id;
			_name          = name;
			_propertyId    = propertyId;
			_propertyKey   = propertyKey;
			_propertyValue = propertyValue;
			_status        = status;
			_addtime       = addtime;
			_uptatetime    = uptatetime;
			
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
		public string Name
		{
			get {return _name;}
			set {_name = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public int PropertyId
		{
			get {return _propertyId;}
			set {_propertyId = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string PropertyKey
		{
			get {return _propertyKey;}
			set {_propertyKey = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string PropertyValue
		{
			get {return _propertyValue;}
			set {_propertyValue = value;}
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
		public DateTime Uptatetime
		{
			get {return _uptatetime;}
			set {_uptatetime = value;}
		}
	
		#endregion
		
	}
}
