// =================================================================== 
// 项目说明
//====================================================================
// yangxg。@Copy Right 2014
// 文件： wx_Shop.cs
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
	///wx_Shop数据实体
	/// </summary>
	[Serializable]
	[DataContract]
	public class wx_ShopEntity
	{
		#region 变量定义
		///<summary>
		///
		///</summary>
		private int _shopId;
		///<summary>
		///
		///</summary>
		private string _shopName = String.Empty;
		///<summary>
		///
		///</summary>
		private string _description = String.Empty;
		///<summary>
		///
		///</summary>
		private string _images = String.Empty;
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
		public wx_ShopEntity()
		{
		}
		///<summary>
		///
		///</summary>
		public wx_ShopEntity
		(
			int shopId,
			string shopName,
			string description,
			string images,
			int status,
			DateTime addTime,
			DateTime updateTime
		)
		{
			_shopId      = shopId;
			_shopName    = shopName;
			_description = description;
			_images      = images;
			_status      = status;
			_addTime     = addTime;
			_updateTime  = updateTime;
			
		}
		#endregion
		
		#region 公共属性

		
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
		public string ShopName
		{
			get {return _shopName;}
			set {_shopName = value;}
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
		public string Images
		{
			get {return _images;}
			set {_images = value;}
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
