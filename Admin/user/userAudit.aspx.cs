using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class user_userAudit : System.Web.UI.Page
{
    public int uid
    {
        get
        {
            object obj = Request.QueryString["uid"];
            if (obj == null)
                return 0;
            int m = 0;
            int.TryParse(obj.ToString(), out m);
            return m;
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            UserIdentity identity = User.Identity as UserIdentity;
            if (identity != null && uid != 0)
            {
                Weifenxiao.Entity.wx_UsersEntity model = Weifenxiao.BLL.wx_UsersBLL.GetInstance().GetAdminSingle(uid);
                if (model != null)
                    hidopen.Text = model.OpenId;
                //Weifenxiao.Entity.wx_UserExtEntity model = Weifenxiao.BLL.wx_UsersBLL.GetInstance().GetExtModelByUserId(uid);
                //if (model != null && model.ParentId == 0)
                //{
                //    lbUper.Text = "无";
                //}
                //else
                //{
                //    Weifenxiao.Entity.wx_UsersEntity pmodel = Weifenxiao.BLL.wx_UsersBLL.GetInstance().GetAdminSingle(model.ParentId);
                //    lbUper.Text = pmodel.RealName;
                //}
                IList<Weifenxiao.Entity.RolesEntity> list = Weifenxiao.BLL.RolesBLL.GetInstance().GetListByShopId(identity.ShopID);

                ddlRole.DataSource = list;
                ddlRole.DataTextField = "Name";
                ddlRole.DataValueField = "RoleId";
                ddlRole.DataBind();

                //ddlRole.SelectedValue = model.RoleId.ToString();
            }
        }
    }
    protected void btnAudit_Click(object sender, EventArgs e)
    {
        try
        {

            string roleid = ddlRole.SelectedValue;
            string openid = hidopen.Text.Trim();

            Jnwf.Utils.Helper.HttpHelper.LoadPageContent("http://m.disneybg.com/data/test.ashx?openid=" + openid + "&roleid=" + roleid);
            Response.Redirect("userapply.aspx");
        }
        catch (Exception ex)
        {
            Jnwf.Utils.Log.Logger.Log4Net.Error("useraudit.aspx,ex:" + ex.Message + "|" + ex.StackTrace );
        }
    }
}