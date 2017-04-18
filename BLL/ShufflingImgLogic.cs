using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Weifenxiao.DAL;
using Weifenxiao.Entity;

namespace Weifenxiao.BLL
{
    public partial class ShufflingImgBLL : BaseBLL<ShufflingImgBLL>
    {
        ShufflingImgDataAccessLayer _ShufflingImgDataAccessLayerdal = null;
        public ShufflingImgBLL()
        {
            _ShufflingImgDataAccessLayerdal = new ShufflingImgDataAccessLayer();
        }
        public IList<ShufflingImgEntity> Get_ShufflingImgAll()
        {
            return _ShufflingImgDataAccessLayerdal.Get_ShufflingImgAll();
        }
        public int Insert(ShufflingImgEntity _ShufflingImgEntity)
        {
            return _ShufflingImgDataAccessLayerdal.Insert(_ShufflingImgEntity);
        }
        public int Update(ShufflingImgEntity _ShufflingImgEntity)
        {
            return _ShufflingImgDataAccessLayerdal.Update(_ShufflingImgEntity);
        }
        public ShufflingImgEntity Get_ShufflingImgEntity(int clsId)
        {
            return _ShufflingImgDataAccessLayerdal.Get_ShufflingImgEntity(clsId);
        }

        public bool ShufflingImgEntityByClsIdBool(int clsId)
        {
            return _ShufflingImgDataAccessLayerdal.ShufflingImgEntityByClsIdBool(clsId);
        }
        public DataSet GetShufflingImgClsList()
        {
            return _ShufflingImgDataAccessLayerdal.GetShufflingImgClsList();
        }
    }
}
