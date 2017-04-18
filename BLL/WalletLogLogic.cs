// =================================================================== 
// 项目说明
//====================================================================
// yangxg。@Copy Right 2014
// 文件： WalletLog.cs
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
    public partial class WalletLogBLL : BaseBLL< WalletLogBLL>

    {
        WalletLogDataAccessLayer walletLogdal;
        public WalletLogBLL()
        {
            walletLogdal = new WalletLogDataAccessLayer();
        }

        public int Insert(WalletLogEntity walletLogEntity)
        {
            return walletLogdal.Insert(walletLogEntity);            
        }

        public void Update(WalletLogEntity walletLogEntity)
        {
            walletLogdal.Update(walletLogEntity);
        }

        public WalletLogEntity GetAdminSingle(int walletId)
        {
           return walletLogdal.Get_WalletLogEntity(walletId);
        }

        public IList<WalletLogEntity> GetWalletLogList()
        {
            IList<WalletLogEntity> walletLogList = new List<WalletLogEntity>();
            walletLogList=walletLogdal.Get_WalletLogAll();
            return walletLogList;
        }
    }
}
