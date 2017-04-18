// =================================================================== 
// 项目说明
//====================================================================
// yangxg。@Copy Right 2014
// 文件： AttrValueSKU.cs
// 项目名称：买车网
// 创建时间：2016/8/22
// 负责人：yangxg
// ===================================================================
using System;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ComponentModel;

namespace Weifenxiao.Entity
{
    /// <summary>
    ///T_ProductSKUEntity数据实体
    /// </summary>
    [Serializable]
    [DataContract]
    public class T_ProductSKUEntity
    {
        	#region 变量定义
		///<summary>
		///
		///</summary>
		private int _id;
		///<summary>
		///
		///</summary>
		private int _productId;
		///<summary>
		///
		///</summary>
		private string _attrValue = String.Empty;
		///<summary>
		///
		///</summary>
		private int _stock;
		///<summary>
		///
		///</summary>
		private string _productCode = String.Empty;
		///<summary>
		///
		///</summary>
		private string _images = String.Empty;
		#endregion
		
		#region 构造函数

		///<summary>
		///
		///</summary>
		public T_ProductSKUEntity()
		{
		}
		///<summary>
		///
		///</summary>
        public T_ProductSKUEntity
		(
			int id,
			int productId,
			string attrValue,
			int stock,
			string productCode,
			string images
		)
		{
			_id          = id;
			_productId   = productId;
			_attrValue   = attrValue;
			_stock       = stock;
			_productCode = productCode;
			_images      = images;
			
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
		public int ProductId
		{
			get {return _productId;}
			set {_productId = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string AttrValue
		{
			get {return _attrValue;}
			set {_attrValue = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public int Stock
		{
			get {return _stock;}
			set {_stock = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string ProductCode
		{
			get {return _productCode;}
			set {_productCode = value;}
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
	
		#endregion
    }
}
