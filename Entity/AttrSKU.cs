// =================================================================== 
// 项目说明
//====================================================================
// yangxg。@Copy Right 2014
// 文件： AttrSKU.cs
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
	///AttrSKU数据实体
	/// </summary>
	[Serializable]
	[DataContract]
	public class AttrSKUEntity
	{
		#region 变量定义
		///<summary>
		///
		///</summary>
		private int _id;
		///<summary>
		///
		///</summary>
		private int _clsId;
		///<summary>
		///
		///</summary>
		private string _attrName = String.Empty;
		///<summary>
		///
		///</summary>
		private string _attrDesc = String.Empty;
		#endregion
		
		#region 构造函数

		///<summary>
		///
		///</summary>
		public AttrSKUEntity()
		{
		}
		///<summary>
		///
		///</summary>
		public AttrSKUEntity
		(
			int id,
			int clsId,
			string attrName,
			string attrDesc
		)
		{
			_id       = id;
			_clsId    = clsId;
			_attrName = attrName;
			_attrDesc = attrDesc;
			
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
		public int ClsId
		{
			get {return _clsId;}
			set {_clsId = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string AttrName
		{
			get {return _attrName;}
			set {_attrName = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string AttrDesc
		{
			get {return _attrDesc;}
			set {_attrDesc = value;}
		}
	
		#endregion
		
	}
}
