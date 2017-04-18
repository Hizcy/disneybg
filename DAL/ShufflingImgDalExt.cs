using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Jnwf.Utils.Data;
using Jnwf.Utils.Config;
using Weifenxiao.DAL;

namespace Weifenxiao.DAL
{
    public partial class ShufflingImgDataAccessLayer
    {
        public DataSet GetShufflingImgClsList()
        {
            string sqlStr = "SELECT a.[Status] ,a.[Clsname] ,a.[ShopId] ,a.[ClsId] ,isnull(b.[ClsId],'') as bclasid,isnull(b.[ImgUrl],'') as imgurl  FROM [weifenxiao].[dbo].[ProductCls] as a  left join [weifenxiao].[dbo].[ShufflingImg] as b on a.[ClsId] =b.[ClsId]";
            return SqlHelper.ExecuteDataset(WebConfig.WfxRW, CommandType.Text, sqlStr);
        }
    }
}
