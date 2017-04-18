using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using System.Text;

public partial class distribution_Default : System.Web.UI.Page
{
    public int Id
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
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            UserIdentity identity = User.Identity as UserIdentity;
            if (identity != null)
            {
                IList<Weifenxiao.Entity.RolesEntity> list = Weifenxiao.BLL.RolesBLL.GetInstance().GetListByShopId(identity.ShopID);
                if (list.Count > 0 && list != null)
                {
                    if (list[0].Name == "请选择")
                    {
                        list.RemoveAt(0);
                    }
                    if (list[0].Name != "通用权限")
                    {
                        Weifenxiao.Entity.RolesEntity temp = new Weifenxiao.Entity.RolesEntity();
                        temp.RoleId = 0;
                        temp.Name = "通用权限";
                        list.Insert(0, temp);
                    }
                    dpdRole.DataSource = list;
                    dpdRole.DataTextField = "Name";
                    dpdRole.DataValueField = "RoleId";
                    dpdRole.DataBind();
                }
            }
            GetData();
        }
    }
    /// <summary>
    ///   修改时获取数据
    /// </summary>
    public void GetData()
    {
        if (Id != 0)
        {
            Weifenxiao.Entity.wx_FenxiaoEntity model = Weifenxiao.BLL.wx_FenxiaoBLL.GetInstance().GetAdminSingle(Id);
            Weifenxiao.Entity.RolesEntity entity = Weifenxiao.BLL.RolesBLL.GetInstance().GetAdminSingle(model.RoleId);
            if (entity == null)
                dpdRole.SelectedValue = "0";
            else
                dpdRole.SelectedValue = entity.RoleId.ToString(); 

            txtYiji.Text = model.OneFenxiao.ToString();
            txtErji.Text = model.TwoFenxiao.ToString();
            txtSanji.Text = model.ThreeFenxiao.ToString(); 
        }
    }
    /// <summary>
    /// 保存修改事件
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        UserIdentity identity = User.Identity as UserIdentity;
        string fx1 = txtYiji.Text.Trim();
        string  fx2 = txtErji.Text.Trim();
        string fx3 = txtSanji.Text.Trim();
        IList<Weifenxiao.Entity.wx_FenxiaoEntity> list = Weifenxiao.BLL.wx_FenxiaoBLL.GetInstance().GetListByShopId(identity.ShopID);
        if (Id == 0)
        {
            foreach (Weifenxiao.Entity.wx_FenxiaoEntity fx in list)
            {
                if (fx.RoleId == int.Parse(dpdRole.SelectedValue))
                {
                    //MessageBox.ShowMsg(this, "此类型权限已经拥有！请选择其他类型设置权限！");
                    return;
                }
            }
        } 
    
 
        if (Id == 0)
        {
            if (identity != null)
            {
                Weifenxiao.Entity.wx_FenxiaoEntity model = new Weifenxiao.Entity.wx_FenxiaoEntity();
                model.ShopId = identity.ShopID;
                model.RoleId = int.Parse(dpdRole.SelectedValue);
              
                model.OneFenxiao = int.Parse(fx1);
                model.TwoFenxiao = int.Parse(fx2);
                model.ThreeFenxiao = int.Parse(fx3); 

                int num = Weifenxiao.BLL.wx_FenxiaoBLL.GetInstance().Insert(model);
                if (num < 0)
                { 
                    return;
                }
                Response.Redirect("yongList.aspx");
            }
        }
        else
        {
            Weifenxiao.Entity.wx_FenxiaoEntity model = Weifenxiao.BLL.wx_FenxiaoBLL.GetInstance().GetAdminSingle(Id);
            model.RoleId = int.Parse(dpdRole.SelectedValue);
          
            model.OneFenxiao = int.Parse(fx1);
            model.TwoFenxiao = int.Parse(fx2);
            model.ThreeFenxiao = int.Parse(fx3);
      
            Weifenxiao.BLL.wx_FenxiaoBLL.GetInstance().Update(model);
            Response.Redirect("yongList.aspx");
        }
    } 
}