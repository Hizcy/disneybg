// =================================================================== 
// 项目说明
//====================================================================
// yangxg。@Copy Right 2014
// 文件： T_Products.cs
// 项目名称：买车网
// 创建时间：2016/8/9
// 负责人：yangxg
// ===================================================================
using System;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ComponentModel;
namespace Weifenxiao.Entity
{
	/// <summary>
	///T_Products数据实体
	/// </summary>
	[Serializable]
	[DataContract]
	public class T_ProductsEntity
	{
		#region 变量定义
		///<summary>
		///
		///</summary>
		private int _productId;
		///<summary>
		///
		///</summary>
		private int _shopId;
		///<summary>
		///
		///</summary>
		private int _categoryId;
		///<summary>
		///
		///</summary>
		private string _name = String.Empty;
		///<summary>
		///
		///</summary>
		private string _intro = String.Empty;
		///<summary>
		///
		///</summary>
		private string _description = String.Empty;
		///<summary>
		///
		///</summary>
		private string _image1 = String.Empty;
		///<summary>
		///
		///</summary>
		private string _image2 = String.Empty;
		///<summary>
		///
		///</summary>
		private string _image3 = String.Empty;
		///<summary>
		///
		///</summary>
		private string _image4 = String.Empty;
		///<summary>
		///
		///</summary>
		private string _image5 = String.Empty;
		///<summary>
		///
		///</summary>
		private decimal _costPrice;
		///<summary>
		///
		///</summary>
		private decimal _salePrice;
		///<summary>
		///
		///</summary>
		private decimal _commission;
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
		///<summary>
		///
		///</summary>
		private int _orderBy;
		///<summary>
		///
		///</summary>
		private int _isCommission;
		///<summary>
		///
		///</summary>
		private string _productCode = String.Empty;
		///<summary>
		///
		///</summary>
		private int _stock;
		///<summary>
		///
		///</summary>
		private decimal _originPrice;
		///<summary>
		///
		///</summary>
		private int _isNew;
		///<summary>
		///
		///</summary>
		private int _isHot;
		///<summary>
		///
		///</summary>
		private int _groupNumber;
		///<summary>
		///
		///</summary>
		private decimal _groupPrice;
		#endregion
		
		#region 构造函数

		///<summary>
		///
		///</summary>
		public T_ProductsEntity()
		{
		}
		///<summary>
		///
		///</summary>
		public T_ProductsEntity
		(
			int productId,
			int shopId,
			int categoryId,
			string name,
			string intro,
			string description,
			string image1,
			string image2,
			string image3,
			string image4,
			string image5,
			decimal costPrice,
			decimal salePrice,
			decimal commission,
			int status,
			DateTime addTime,
			DateTime updateTime,
			int orderBy,
			int isCommission,
			string productCode,
			int stock,
			decimal originPrice,
			int isNew,
			int isHot,
			int groupNumber,
			decimal groupPrice
		)
		{
			_productId    = productId;
			_shopId       = shopId;
			_categoryId   = categoryId;
			_name         = name;
			_intro        = intro;
			_description  = description;
			_image1       = image1;
			_image2       = image2;
			_image3       = image3;
			_image4       = image4;
			_image5       = image5;
			_costPrice    = costPrice;
			_salePrice    = salePrice;
			_commission   = commission;
			_status       = status;
			_addTime      = addTime;
			_updateTime   = updateTime;
			_orderBy      = orderBy;
			_isCommission = isCommission;
			_productCode  = productCode;
			_stock        = stock;
			_originPrice  = originPrice;
			_isNew        = isNew;
			_isHot        = isHot;
			_groupNumber  = groupNumber;
			_groupPrice   = groupPrice;
			
		}
		#endregion
		
		#region 公共属性

		
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
		public int ShopId
		{
			get {return _shopId;}
			set {_shopId = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public int CategoryId
		{
			get {return _categoryId;}
			set {_categoryId = value;}
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
		public string Intro
		{
			get {return _intro;}
			set {_intro = value;}
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
		public string Image1
		{
			get {return _image1;}
			set {_image1 = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string Image2
		{
			get {return _image2;}
			set {_image2 = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string Image3
		{
			get {return _image3;}
			set {_image3 = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string Image4
		{
			get {return _image4;}
			set {_image4 = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string Image5
		{
			get {return _image5;}
			set {_image5 = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public decimal CostPrice
		{
			get {return _costPrice;}
			set {_costPrice = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public decimal SalePrice
		{
			get {return _salePrice;}
			set {_salePrice = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public decimal Commission
		{
			get {return _commission;}
			set {_commission = value;}
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

		///<summary>
		///
		///</summary>
		[DataMember]
		public int OrderBy
		{
			get {return _orderBy;}
			set {_orderBy = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public int IsCommission
		{
			get {return _isCommission;}
			set {_isCommission = value;}
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
		public int Stock
		{
			get {return _stock;}
			set {_stock = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public decimal OriginPrice
		{
			get {return _originPrice;}
			set {_originPrice = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public int IsNew
		{
			get {return _isNew;}
			set {_isNew = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public int IsHot
		{
			get {return _isHot;}
			set {_isHot = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public int GroupNumber
		{
			get {return _groupNumber;}
			set {_groupNumber = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public decimal GroupPrice
		{
			get {return _groupPrice;}
			set {_groupPrice = value;}
		}
	
		#endregion
		
	}
}
