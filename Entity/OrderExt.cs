using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Weifenxiao.Entity
{
    [Serializable]
    [DataContract]
    public class OrderExtEntity : OrdersEntity
    {
        private List<OrdersItemExtEntity> _list;

        public OrderExtEntity()
        {

            _list = new List<OrdersItemExtEntity>();
        }

        [DataMember]
        public List<OrdersItemExtEntity> List
        {
            get { return _list; }
            set { _list = value; }
        }

        [DataMember]
        public string ItemInfo
        {
            get;
            set;
        }
    }
}
