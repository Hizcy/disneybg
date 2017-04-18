// =================================================================== 
// 项目说明
//====================================================================
// yangxg。@Copy Right 2014
// 文件： wx_Fenxiao.cs
// 项目名称：买车网
// 创建时间：2016/5/22
// 负责人：yangxg
// ===================================================================
using System;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ComponentModel;
namespace Weifenxiao.Entity
{
	/// <summary>
	///wx_Fenxiao数据实体
	/// </summary>
	[Serializable]
	[DataContract]
	public class wx_FenxiaoEntity
	{
		#region 变量定义
		///<summary>
		///
		///</summary>
		private int _id;
		///<summary>
		///
		///</summary>
		private int _shopId;
		///<summary>
		///
		///</summary>
		private int _roleId;
		///<summary>
		///
		///</summary>
		private int _oneFenxiao;
		///<summary>
		///
		///</summary>
		private int _twoFenxiao;
		///<summary>
		///
		///</summary>
		private int _threeFenxiao;
		///<summary>
		///
		///</summary>
		private int _quDao;
		#endregion
		
		#region 构造函数

		///<summary>
		///
		///</summary>
		public wx_FenxiaoEntity()
		{
		}
		///<summary>
		///
		///</summary>
		public wx_FenxiaoEntity
		(
			int id,
			int shopId,
			int roleId,
			int oneFenxiao,
			int twoFenxiao,
			int threeFenxiao,
			int quDao
		)
		{
			_id           = id;
			_shopId       = shopId;
			_roleId       = roleId;
			_oneFenxiao   = oneFenxiao;
			_twoFenxiao   = twoFenxiao;
			_threeFenxiao = threeFenxiao;
			_quDao        = quDao;
			
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
		public int ShopId
		{
			get {return _shopId;}
			set {_shopId = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public int RoleId
		{
			get {return _roleId;}
			set {_roleId = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public int OneFenxiao
		{
			get {return _oneFenxiao;}
			set {_oneFenxiao = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public int TwoFenxiao
		{
			get {return _twoFenxiao;}
			set {_twoFenxiao = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public int ThreeFenxiao
		{
			get {return _threeFenxiao;}
			set {_threeFenxiao = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public int QuDao
		{
			get {return _quDao;}
			set {_quDao = value;}
		}
	
		#endregion
		
	}
}
