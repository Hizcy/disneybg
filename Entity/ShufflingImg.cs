using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Weifenxiao.Entity
{
    /// <summary>
    ///wx_Users数据实体
    /// </summary>
    [Serializable]
    [DataContract]
    public class ShufflingImgEntity
    {
        public ShufflingImgEntity()
        {

        }
        public ShufflingImgEntity(string imgUrl, int clsId, DateTime addtime, DateTime updatetime, string linkUrl, string imgUrl2, string imgUrl3, string imgUrl4, string imgUrl5, string linkUrl2, string linkUrl3, string linkUrl4, string linkUrl5)
        {
            _imgUrl = imgUrl;
            _clsId = clsId;
            _addtime = addtime;
            _updatetime = updatetime;
            _linkUrl = linkUrl;
            _linkUrl2 = linkUrl2;
            _linkUrl3 = linkUrl3;
            _linkUrl4 = linkUrl4;
            _linkUrl5 = linkUrl5;
            _imgUrl2 = imgUrl2;
            _imgUrl3 = imgUrl3;
            _imgUrl4 = imgUrl4;
            _imgUrl5 = imgUrl5;
        }
        private string _imgUrl;
        private int _clsId;
        private DateTime _addtime;
        private DateTime _updatetime;
        private string _linkUrl;
        private string _imgUrl2;
        private string _imgUrl3;
        private string _imgUrl4;
        private string _imgUrl5;
        private string _linkUrl2;
        private string _linkUrl3;
        private string _linkUrl4;
        private string _linkUrl5;
        [DataMember]
        public string LinkUrl
        {
            get { return _linkUrl; }
            set { _linkUrl = value; }
        }
        ///<summary>
        ///
        ///</summary>
        [DataMember]
        public string ImgUrl
        {
            get { return _imgUrl; }
            set { _imgUrl = value; }
        }
        ///<summary>
        ///
        ///</summary>
        [DataMember]
        public int ClsId
        {
            get { return _clsId; }
            set { _clsId = value; }
        }
        ///<summary>
        ///
        ///</summary>
        [DataMember]
        public DateTime Addtime
        {
            get { return _addtime; }
            set { _addtime = value; }
        }
        ///<summary>
        ///
        ///</summary>
        [DataMember]
        public DateTime Updatetime
        {
            get { return _updatetime; }
            set { _updatetime = value; }
        }
        ///<summary>
        ///
        ///</summary>
        [DataMember]
        public string ImgUrl2
        {
            get { return _imgUrl2; }
            set { _imgUrl2 = value; }
        }
        ///<summary>
        ///
        ///</summary>
        [DataMember]
        public string ImgUrl3
        {
            get { return _imgUrl3; }
            set { _imgUrl3 = value; }
        }
        ///<summary>
        ///
        ///</summary>
        [DataMember]
        public string ImgUrl4
        {
            get { return _imgUrl4; }
            set { _imgUrl4 = value; }
        }
        ///<summary>
        ///
        ///</summary>
        [DataMember]
        public string ImgUrl5
        {
            get { return _imgUrl5; }
            set { _imgUrl5 = value; }
        }
        ///<summary>
        ///
        ///</summary>
        [DataMember]
        public string LinkUrl2
        {
            get { return _linkUrl2; }
            set { _linkUrl2 = value; }
        }
        ///<summary>
        ///
        ///</summary>
        [DataMember]
        public string LinkUrl3
        {
            get { return _linkUrl3; }
            set { _linkUrl3 = value; }
        }
        ///<summary>
        ///
        ///</summary>
        [DataMember]
        public string LinkUrl4
        {
            get { return _linkUrl4; }
            set { _linkUrl4 = value; }
        }
        ///<summary>
        ///
        ///</summary>
        [DataMember]
        public string LinkUrl5
        {
            get { return _linkUrl5; }
            set { _linkUrl5 = value; }
        }
        
    }
}
