using System;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ComponentModel;
namespace Weifenxiao.Entity
{
    [Serializable]
    [DataContract]
    public class wx_UserExtEntity : wx_UsersEntity
    {
        [DataMember]
        public string ParentName { get; set; }
        [DataMember]
        public string NickName { get; set; }
        [DataMember]
        public string HeadImgurl { get; set; }
        [DataMember]
        public string RoleName { get; set; }
        [DataMember]
        public decimal yeji { get; set; }
        [DataMember]
        public decimal yongjin { get; set; }
        [DataMember]
        public decimal tixian { get; set; }
        [DataMember]
        public int yijidaili { get; set; }
        [DataMember]
        public int erjidaili { get; set; }
    }
}
