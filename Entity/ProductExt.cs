using System;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ComponentModel;

namespace Weifenxiao.Entity
{
    [Serializable]
    [DataContract]
    public class ProductExtEntity:ProductsEntity
    {
        private string _clsname;

        [DataMember]
        public string Clsname
        {
            get { return _clsname; }
            set { _clsname = value; }
        }
    }
}
