using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class distribution_pointlist : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            GetData();
        }
    }
    public void GetData()
    {
        UserIdentity identity = User.Identity as UserIdentity;
        if (identity != null)
        {
            IList<Weifenxiao.Entity.wx_FenxiaoEntity> list = Weifenxiao.BLL.wx_FenxiaoBLL.GetInstance().GetListByShopId(identity.ShopID);
            rptPointList.DataSource = list;
            rptPointList.DataBind();
        }
    }
    
    public string GetEntity(int roled)
    {
        if(roled != 0)
             return Weifenxiao.BLL.RolesBLL.GetInstance().GetAdminSingle(roled).Name.ToString();
        return "通用权限";
    }
}