using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class user_AddRole : System.Web.UI.Page
{
    public int RoleId
    {
        get
        {
            object obj = Request.QueryString["id"];
            if (obj == null)
            {
                return 0;
            }
            return int.Parse(obj.ToString());
        }
    }

    public int Permission = 0;
    //public int ClsId = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindData();
        }
    }
    private void BindData()
    {
        try
        {
            UserIdentity identity = User.Identity as UserIdentity;
            if (identity != null)
            {
                
               // .Model.RolesEntity model = Weifenxiao.BLL.RolesBLL.GetInstance().GetAdminSingle(RoleId);
                Weifenxiao.Entity.RolesEntity model = Weifenxiao.BLL.RolesBLL.GetInstance().GetAdminSingle(RoleId);
                model.ShopId = identity.ShopID;
                if (model != null)
                {                
                    txtName.Text = model.Name;
                    txtmoney.Text = model.price.ToString();
                    Permission = model.Permission ;
                    txtDescrition.Text = model.Description;
                }
            }


        }
        catch (Exception ex)
        {
           // MessageBox.Show(this, ex.Message);
        }
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        UserIdentity identity = User.Identity as UserIdentity;
        if (RoleId == 0)
        {
            //添加角色
            Weifenxiao.Entity.RolesEntity model = new Weifenxiao.Entity.RolesEntity();
            model.ShopId = identity.ShopID;
            model.Name = this.txtName.Text;
            model.Permission = 0;
            model.price =decimal.Parse(this.txtmoney.Text);
            model.Description = txtDescrition.Text;
            Weifenxiao.BLL.RolesBLL.GetInstance().Insert(model);
        }
        else
        {
            Weifenxiao.Entity.RolesEntity model = Weifenxiao.BLL.RolesBLL.GetInstance().GetAdminSingle(RoleId);
            model.ShopId = identity.ShopID;
            model.Name = this.txtName.Text;
            model.Permission = 0;
            model.price = decimal.Parse(this.txtmoney.Text);
            model.Description = txtDescrition.Text;
            Weifenxiao.BLL.RolesBLL.GetInstance().Update(model);
        }
        Jnwf.Utils.Helper.HttpHelper.LoadPageContent("http://m.disneybg.com/clear.aspx?type=role&shopid=" + identity.ShopID);
        Response.Redirect("roleList.aspx");
    }
}