// =================================================================== 
// 项目说明
//====================================================================
// yangxg。@Copy Right 2014
// 文件： Address.cs
// 项目名称：买车网
// 创建时间：2016/4/2
// 负责人：yangxg
// ===================================================================
using System;
using System.Collections.Generic;
using System.Text;
using Weifenxiao.DAL;
using Weifenxiao.Entity;

namespace Weifenxiao.BLL
{
    public partial class AddressBLL : BaseBLL< AddressBLL>

    {
        AddressDataAccessLayer addressdal;
        public AddressBLL()
        {
            addressdal = new AddressDataAccessLayer();
        }

        public int Insert(AddressEntity addressEntity)
        {
            return addressdal.Insert(addressEntity);            
        }

        public void Update(AddressEntity addressEntity)
        {
            addressdal.Update(addressEntity);
        }

        public AddressEntity GetAdminSingle(int addressId)
        {
           return addressdal.Get_AddressEntity(addressId);
        }

        public IList<AddressEntity> GetAddressList()
        {
            IList<AddressEntity> addressList = new List<AddressEntity>();
            addressList=addressdal.Get_AddressAll();
            return addressList;
        }
    }
}
