// =================================================================== 
// 项目说明
//====================================================================
// yangxg。@Copy Right 2014
// 文件： Apply.cs
// 项目名称：买车网
// 创建时间：2016/4/2
// 负责人：yangxg
// ===================================================================
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Weifenxiao.DAL;
using Weifenxiao.Entity;

namespace Weifenxiao.BLL
{
    public partial class ApplyBLL : BaseBLL< ApplyBLL>

    {
        ApplyDataAccessLayer applydal;
        public ApplyBLL()
        {
            applydal = new ApplyDataAccessLayer();
        }

        public int Insert(ApplyEntity applyEntity)
        {
            return applydal.Insert(applyEntity);            
        }

        public void Update(ApplyEntity applyEntity)
        {
            applydal.Update(applyEntity);
        }

        public ApplyEntity GetAdminSingle(int applyId)
        {
           return applydal.Get_ApplyEntity(applyId);
        }

        public IList<ApplyEntity> GetApplyList()
        {
            IList<ApplyEntity> applyList = new List<ApplyEntity>();
            applyList=applydal.Get_ApplyAll();
            return applyList;
        }

        public IList<ApplyEntity> GetListByShopId(int shopid, int status)
        {
            IList<ApplyEntity> applylist = new List<ApplyEntity>();
            applylist = applydal.GetListByShopId(shopid, status);
            return applylist;
        }
        /// <summary>
        /// 申请提现，成功
        /// </summary>
        /// <param name="applyid"></param>
        private void verifypass(int applyid)
        {

            Weifenxiao.Entity.ApplyEntity model = GetAdminSingle(applyid);
            if (model != null)
            {
                model.Status = 1;
                model.Updatetime = DateTime.Now;
                Update(model);
            }
        }
        /// <summary>
        /// 申请提现，失败
        /// </summary>
        /// <param name="applyid"></param>
        private void refusereason(int applyid, string reason)
        {

            Weifenxiao.Entity.ApplyEntity model = GetAdminSingle(applyid);
            if (model != null)
            {
                model.Status = -1;
                model.Reason = reason;
                model.Updatetime = DateTime.Now;
                Update(model);
            }
        }
        /// <summary>
        /// 获取分页数据
        /// </summary>
        /// <param name="pagesize">页数</param>
        /// <param name="currentindex">当前页</param>
        /// <param name="condition">条件</param>
        /// <param name="allcount">返回总条数</param>
        /// <returns></returns>
        public DataSet GetListByPage(int pagesize, int currentindex, string condition, out int allcount)
        {
            return PageData.GetDataByPage("v_Apply_Bank", "applyid", "addtime desc", currentindex, pagesize, "*", condition, out allcount);
        }
    }
}
