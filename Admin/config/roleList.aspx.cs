using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls; 

public partial class user_ListRole : System.Web.UI.Page
{
    public string roleid
    {
        get
        {
            object obj = Request.QueryString["id"];
            if (obj == null)
            {
                return "";
            }
            return obj.ToString();
        }
    }
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
            IList<Weifenxiao.Entity.RolesEntity> list = Weifenxiao.BLL.RolesBLL.GetInstance().GetListByShopId(identity.ShopID);
            rptResultsList.DataSource = list;
            rptResultsList.DataBind();
        }
    }      
    

}