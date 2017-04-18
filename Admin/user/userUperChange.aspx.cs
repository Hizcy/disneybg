using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class user_Default : System.Web.UI.Page
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
            if (uid != 0)
            {
                Weifenxiao.Entity.wx_UsersEntity model = Weifenxiao.BLL.wx_UsersBLL.GetInstance().GetAdminSingle(uid);

                if (model.ParentId == 0)
                {
                    lbUperID.Text = "无";
                    lbUperName.Text = "无";
                }
                else
                {
                    Weifenxiao.Entity.wx_UsersEntity pmodel = Weifenxiao.BLL.wx_UsersBLL.GetInstance().GetAdminSingle(uid);
                    lbUperID.Text = pmodel.UserId.ToString();
                    lbUperName.Text = pmodel.RealName;
                }
            }
        }
    }
    protected void btnChangeUper_Click(object sender, EventArgs e)
    {
        if(string.IsNullOrEmpty(this.txtNewParentID.Text)){ 

                Weifenxiao.Entity.wx_UsersEntity model = Weifenxiao.BLL.wx_UsersBLL.GetInstance().GetAdminSingle(uid);
                model.ParentId = int.Parse(this.txtNewParentID.Text);
                Weifenxiao.BLL.wx_UsersBLL.GetInstance().Update(model);

        } 

    }

}