// =================================================================== 
// 项目说明
//====================================================================
// yangxg。@Copy Right 2014
// 文件： ProductCls.cs
// 项目名称：买车网
// 创建时间：2016/4/3
// 负责人：yangxg
// ===================================================================
using System;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ComponentModel;
namespace Weifenxiao.Entity
{
	/// <summary>
	///ProductCls数据实体
	/// </summary>
	[Serializable]
	[DataContract]
	public class ProductClsEntity
	{
		#region 变量定义
		///<summary>
		///
		///</summary>
		private int _clsId;
		///<summary>
		///
		///</summary>
		private int _shopId;
		///<summary>
		///
		///</summary>
		private string _clsname = String.Empty;
        /// <summary>
        /// 
        /// </summary>
        private int _parentId;
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
		///<summary>
		///
		///</summary>
		private int _orderby;
		///<summary>
		///
		///</summary>
		private string _image = String.Empty;
		///<summary>
		///
		///</summary>
		private string _description = String.Empty;
		#endregion
		
		#region 构造函数

		///<summary>
		///
		///</summary>
		public ProductClsEntity()
		{
		}
		///<summary>
		///
		///</summary>
		public ProductClsEntity
		(
			int clsId,
			int shopId,
			string clsname,
            int parentId,
			int status,
			DateTime addtime,
			DateTime updatetime,
			int orderby,
			string image,
			string description
		)
		{
			_clsId       = clsId;
			_shopId      = shopId;
			_clsname     = clsname;
            _parentId = parentId;
            _status = status;
			_addtime     = addtime;
			_updatetime  = updatetime;
			_orderby     = orderby;
			_image       = image;
			_description = description;
			
		}
		#endregion
		
		#region 公共属性

		
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
		public int ShopId
		{
			get {return _shopId;}
			set {_shopId = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string Clsname
		{
			get {return _clsname;}
			set {_clsname = value;}
		}
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int ParentId
        {
            get { return _parentId; }
            set { _parentId = value; }
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

		///<summary>
		///
		///</summary>
		[DataMember]
		public int orderby
		{
			get {return _orderby;}
			set {_orderby = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string Image
		{
			get {return _image;}
			set {_image = value;}
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
	
		#endregion
		
	}
}
