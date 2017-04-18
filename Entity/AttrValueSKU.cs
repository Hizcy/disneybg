// =================================================================== 
// 项目说明
//====================================================================
// yangxg。@Copy Right 2014
// 文件： AttrValueSKU.cs
// 项目名称：买车网
// 创建时间：2016/4/17
// 负责人：yangxg
// ===================================================================
using System;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ComponentModel;
namespace Weifenxiao.Entity
{
	/// <summary>
	///AttrValueSKU数据实体
	/// </summary>
	[Serializable]
	[DataContract]
	public class AttrValueSKUEntity
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
		private int _attrSkuId;
		///<summary>
		///
		///</summary>
		private string _attrSkuVal = String.Empty;
		#endregion
		
		#region 构造函数

		///<summary>
		///
		///</summary>
		public AttrValueSKUEntity()
		{
		}
		///<summary>
		///
		///</summary>
		public AttrValueSKUEntity
		(
			int id,
			int productId,
			int attrSkuId,
			string attrSkuVal
		)
		{
			_id         = id;
			_productId  = productId;
			_attrSkuId  = attrSkuId;
			_attrSkuVal = attrSkuVal;
			
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
		public int AttrSkuId
		{
			get {return _attrSkuId;}
			set {_attrSkuId = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string AttrSkuVal
		{
			get {return _attrSkuVal;}
			set {_attrSkuVal = value;}
		}
	
		#endregion
		
	}
}
