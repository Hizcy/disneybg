using System;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ComponentModel;
namespace Weifenxiao.Entity
{
    /// <summary>
    ///OrdersItem数据实体
    /// </summary>
    [Serializable]
    [DataContract]
    public class OrdersItemExtEntity:OrdersItemEntity
    {
        [DataMember]
        public string ProductName { get; set; }
        [DataMember]
        public string ProductImage { get; set; }
        [DataMember]
        public int dailiId { get; set; }
        [DataMember]
        public string dailiName { get; set; }
        [DataMember]
        public string attr { get; set; }
    }
}
