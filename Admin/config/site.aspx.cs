using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class config_site : System.Web.UI.Page
{
    public int shopid = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DataBinding();
        }
        
    }
    protected void DataBinding()
    {
        UserIdentity identity = User.Identity as UserIdentity;
        if (identity != null)
        {
            shopid = identity.ShopID;
            IList<Weifenxiao.Entity.wx_ConfigEntity> list = Weifenxiao.BLL.wx_ConfigBLL.GetInstance().Gettb_PropertyIdList(shopid);
            if(list!=null)
            {

                rptResultsList.DataSource = list;
                rptResultsList.DataBind();
            }
        }
        
    }
}