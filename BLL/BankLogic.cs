// =================================================================== 
// 项目说明
//====================================================================
// yangxg。@Copy Right 2014
// 文件： Bank.cs
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
    public partial class BankBLL : BaseBLL< BankBLL>

    {
        BankDataAccessLayer bankdal;
        public BankBLL()
        {
            bankdal = new BankDataAccessLayer();
        }

        public int Insert(BankEntity bankEntity)
        {
            return bankdal.Insert(bankEntity);            
        }

        public void Update(BankEntity bankEntity)
        {
            bankdal.Update(bankEntity);
        }

        public BankEntity GetAdminSingle(int bankId)
        {
           return bankdal.Get_BankEntity(bankId);
        }

        public IList<BankEntity> GetBankList()
        {
            IList<BankEntity> bankList = new List<BankEntity>();
            bankList=bankdal.Get_BankAll();
            return bankList;
        }
    }
}
