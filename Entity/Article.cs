// =================================================================== 
// 项目说明
//====================================================================
// yangxg。@Copy Right 2014
// 文件： Article.cs
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
	///Article数据实体
	/// </summary>
	[Serializable]
	[DataContract]
	public class ArticleEntity
	{
		#region 变量定义
		///<summary>
		///
		///</summary>
		private int _articleId;
		///<summary>
		///
		///</summary>
		private int _shopId;
		///<summary>
		///
		///</summary>
		private int _articleCls;
		///<summary>
		///
		///</summary>
		private string _articleTitle = String.Empty;
		///<summary>
		///
		///</summary>
		private string _author = String.Empty;
		///<summary>
		///
		///</summary>
		private string _articleContent = String.Empty;
		///<summary>
		///
		///</summary>
		private string _articleUrl = String.Empty;
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
		public ArticleEntity()
		{
		}
		///<summary>
		///
		///</summary>
		public ArticleEntity
		(
			int articleId,
			int shopId,
			int articleCls,
			string articleTitle,
			string author,
			string articleContent,
			string articleUrl,
			int status,
			DateTime addtime,
			DateTime updatetime
		)
		{
			_articleId      = articleId;
			_shopId         = shopId;
			_articleCls     = articleCls;
			_articleTitle   = articleTitle;
			_author         = author;
			_articleContent = articleContent;
			_articleUrl     = articleUrl;
			_status         = status;
			_addtime        = addtime;
			_updatetime     = updatetime;
			
		}
		#endregion
		
		#region 公共属性

		
		///<summary>
		///
		///</summary>
		[DataMember]
		public int ArticleId
		{
			get {return _articleId;}
			set {_articleId = value;}
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
		public int ArticleCls
		{
			get {return _articleCls;}
			set {_articleCls = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string ArticleTitle
		{
			get {return _articleTitle;}
			set {_articleTitle = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string Author
		{
			get {return _author;}
			set {_author = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string ArticleContent
		{
			get {return _articleContent;}
			set {_articleContent = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string ArticleUrl
		{
			get {return _articleUrl;}
			set {_articleUrl = value;}
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
