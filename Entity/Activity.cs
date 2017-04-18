// =================================================================== 
// 项目说明
//====================================================================
// yangxg。@Copy Right 2014
// 文件： Activity.cs
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
	///Activity数据实体
	/// </summary>
	[Serializable]
	[DataContract]
	public class ActivityEntity
	{
		#region 变量定义
		///<summary>
		///
		///</summary>
		private int _activityId;
		///<summary>
		///
		///</summary>
		private int _shopId;
		///<summary>
		///
		///</summary>
		private int _menuId;
		///<summary>
		///
		///</summary>
		private string _activityName = String.Empty;
		///<summary>
		///
		///</summary>
		private string _acivityDesc = String.Empty;
		///<summary>
		///
		///</summary>
		private string _activityImage = String.Empty;
		///<summary>
		///
		///</summary>
		private string _ext1 = String.Empty;
		///<summary>
		///
		///</summary>
		private string _ext2 = String.Empty;
		///<summary>
		///
		///</summary>
		private string _ext3 = String.Empty;
		///<summary>
		///
		///</summary>
		private string _ext4 = String.Empty;
		///<summary>
		///
		///</summary>
		private string _ext5 = String.Empty;
		///<summary>
		///
		///</summary>
		private string _ext6 = String.Empty;
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
		private int _belong;
		///<summary>
		///
		///</summary>
		private int _type;
		#endregion
		
		#region 构造函数

		///<summary>
		///
		///</summary>
		public ActivityEntity()
		{
		}
		///<summary>
		///
		///</summary>
		public ActivityEntity
		(
			int activityId,
			int shopId,
			int menuId,
			string name,
			string acivityDesc,
			string activityImage,
			string ext1,
			string ext2,
			string ext3,
			string ext4,
			string ext5,
			string ext6,
			DateTime addTime,
			DateTime updateTime,
			int belong,
			int type
		)
		{
			_activityId    = activityId;
			_shopId        = shopId;
			_menuId        = menuId;
			_activityName          = name;
			_acivityDesc   = acivityDesc;
			_activityImage = activityImage;
			_ext1          = ext1;
			_ext2          = ext2;
			_ext3          = ext3;
			_ext4          = ext4;
			_ext5          = ext5;
			_ext6          = ext6;
			_addTime       = addTime;
			_updateTime    = updateTime;
			_belong        = belong;
			_type          = type;
			
		}
		#endregion
		
		#region 公共属性

		
		///<summary>
		///
		///</summary>
		[DataMember]
		public int ActivityId
		{
			get {return _activityId;}
			set {_activityId = value;}
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
		public int MenuId
		{
			get {return _menuId;}
			set {_menuId = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string ActivityName
		{
			get {return _activityName;}
			set {_activityName = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string AcivityDesc
		{
			get {return _acivityDesc;}
			set {_acivityDesc = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string ActivityImage
		{
			get {return _activityImage;}
			set {_activityImage = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string Ext1
		{
			get {return _ext1;}
			set {_ext1 = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string Ext2
		{
			get {return _ext2;}
			set {_ext2 = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string Ext3
		{
			get {return _ext3;}
			set {_ext3 = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string Ext4
		{
			get {return _ext4;}
			set {_ext4 = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string Ext5
		{
			get {return _ext5;}
			set {_ext5 = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string Ext6
		{
			get {return _ext6;}
			set {_ext6 = value;}
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
		public int Belong
		{
			get {return _belong;}
			set {_belong = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public int Type
		{
			get {return _type;}
			set {_type = value;}
		}
	
		#endregion
		
	}
}
