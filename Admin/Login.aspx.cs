using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        string redirectUrl = Request.QueryString["ReturnUrl"];

        if (UserIdentity.AuthenticateUser(this.txtName.Text.Trim(), this.txtPwd.Text.Trim()))
        {
            if (string.IsNullOrEmpty(redirectUrl) || redirectUrl == "/")
                redirectUrl = "user/userApply.aspx";

            Response.Redirect(redirectUrl);
        }
        else
        {
            this.lbError.Text = "您输入的用户名或密码不正确";
        }
    }
}