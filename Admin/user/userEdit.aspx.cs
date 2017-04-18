using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class user_userEdit : System.Web.UI.Page
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
                
                //用户信息赋值
                Weifenxiao.Entity.wx_UserExtEntity model = Weifenxiao.BLL.wx_UsersBLL.GetInstance().GetExtModelByUserId(uid);
                if (model.ParentId == 0)
                {
                    lbUper.Text = "无";
                }
                else
                {
                    Weifenxiao.Entity.wx_UsersEntity pmodel = Weifenxiao.BLL.wx_UsersBLL.GetInstance().GetAdminSingle(model.ParentId);
                    linkView.Visible = true;
                    linkView.NavigateUrl = "userShow.aspx?uid=" + pmodel.UserId.ToString();
                    lbUper.Text = pmodel.RealName;
                }

                txtRealName.Text = model.RealName;
                txtWeixin.Text = model.Weixin;
                txtPhone.Text = model.Phone;
                lbAddtime.Text = model.AddTime.ToString();
                imgAvatar.ImageUrl = model.HeadImgurl;
                lbNickname.Text = model.NickName;
                //绑定数据
                UserIdentity identity = User.Identity as UserIdentity;


                IList<Weifenxiao.Entity.RolesEntity> list = Weifenxiao.BLL.RolesBLL.GetInstance().GetListByShopId(identity.ShopID);

                ddlRole.DataSource = list;
                ddlRole.DataTextField = "Name";
                ddlRole.DataValueField = "RoleId"; 
                ddlRole.DataBind();

                ddlRole.SelectedValue = model.RoleId.ToString();

            }
        }
    }


    protected void btnEdit_Click(object sender, EventArgs e)
    {
        if (uid != 0)
        {
            Weifenxiao.Entity.wx_UsersEntity model = Weifenxiao.BLL.wx_UsersBLL.GetInstance().GetAdminSingle(uid);
            model.RealName = this.txtRealName.Text;
            model.Phone = this.txtPhone.Text;
            model.Weixin = this.txtWeixin.Text;
            model.RoleId = int.Parse(this.ddlRole.SelectedValue);
            Weifenxiao.BLL.wx_UsersBLL.GetInstance().Update(model);
            Response.Redirect("userShow.aspx?uid="+model.UserId.ToString());
        }
    }
}