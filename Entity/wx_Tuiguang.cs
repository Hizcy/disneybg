// =================================================================== 
// 项目说明
//====================================================================
// yangxg。@Copy Right 2014
// 文件： wx_Tuiguang.cs
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
	///wx_Tuiguang数据实体
	/// </summary>
	[Serializable]
	[DataContract]
	public class wx_TuiguangEntity
	{
		#region 变量定义
		///<summary>
		///
		///</summary>
		private int _id;
		///<summary>
		///
		///</summary>
		private string _weiXinCode = String.Empty;
		///<summary>
		///
		///</summary>
		private string _openId = String.Empty;
		///<summary>
		///
		///</summary>
		private int _shareType;
		///<summary>
		///
		///</summary>
		private int _pageId;
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
		private int _pageType;
		#endregion
		
		#region 构造函数

		///<summary>
		///
		///</summary>
		public wx_TuiguangEntity()
		{
		}
		///<summary>
		///
		///</summary>
		public wx_TuiguangEntity
		(
			int id,
			string weiXinCode,
			string openId,
			int shareType,
			int pageId,
			int status,
			DateTime addTime,
			int pageType
		)
		{
			_id         = id;
			_weiXinCode = weiXinCode;
			_openId     = openId;
			_shareType  = shareType;
			_pageId     = pageId;
			_status     = status;
			_addTime    = addTime;
			_pageType   = pageType;
			
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
		public string WeiXinCode
		{
			get {return _weiXinCode;}
			set {_weiXinCode = value;}
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
		public int ShareType
		{
			get {return _shareType;}
			set {_shareType = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public int PageId
		{
			get {return _pageId;}
			set {_pageId = value;}
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
		public int PageType
		{
			get {return _pageType;}
			set {_pageType = value;}
		}
	
		#endregion
		
	}
}
