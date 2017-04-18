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
using System.Collections.Generic;
using System.Text;
using Weifenxiao.DAL;
using Weifenxiao.Entity;

namespace Weifenxiao.BLL
{
    public partial class ActivityBLL : BaseBLL< ActivityBLL>

    {
        ActivityDataAccessLayer activitydal;
        public ActivityBLL()
        {
            activitydal = new ActivityDataAccessLayer();
        }

        public int Insert(ActivityEntity activityEntity)
        {
            return activitydal.Insert(activityEntity);            
        }

        public void Update(ActivityEntity activityEntity)
        {
            activitydal.Update(activityEntity);
        }

        public ActivityEntity GetAdminSingle(int activityId)
        {
           return activitydal.Get_ActivityEntity(activityId);
        }

        public IList<ActivityEntity> GetActivityList()
        {
            IList<ActivityEntity> activityList = new List<ActivityEntity>();
            activityList=activitydal.Get_ActivityAll();
            return activityList;
        }
    }
}
