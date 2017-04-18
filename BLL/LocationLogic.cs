// =================================================================== 
// 项目说明
//====================================================================
// yangxg。@Copy Right 2014
// 文件： Location.cs
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
    public partial class LocationBLL : BaseBLL< LocationBLL>

    {
        LocationDataAccessLayer locationdal;
        public LocationBLL()
        {
            locationdal = new LocationDataAccessLayer();
        }

        public int Insert(LocationEntity locationEntity)
        {
            return locationdal.Insert(locationEntity);            
        }

        public void Update(LocationEntity locationEntity)
        {
            locationdal.Update(locationEntity);
        }

        public LocationEntity GetAdminSingle(int locationId)
        {
           return locationdal.Get_LocationEntity(locationId);
        }

        public IList<LocationEntity> GetLocationList()
        {
            IList<LocationEntity> locationList = new List<LocationEntity>();
            locationList=locationdal.Get_LocationAll();
            return locationList;
        }
    }
}
