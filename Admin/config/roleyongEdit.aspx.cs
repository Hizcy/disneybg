using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Weifenxiao.Entity;
public partial class config_roleyongEdit : System.Web.UI.Page
{
    public int RoleId
    {
        get
        {
            object obj = Request.QueryString["roleid"];
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
                IList<Weifenxiao.Entity.wx_RoleFenxiaoEntity> fenxiaolist2 = Weifenxiao.BLL.wx_RoleFenxiaoBLL.GetInstance().GetListByShopId(identity.ShopID);
                IList<Weifenxiao.Entity.RolesEntity> list2 = new List<Weifenxiao.Entity.RolesEntity>();

                foreach (Weifenxiao.Entity.RolesEntity m in list)
                {
                    foreach (Weifenxiao.Entity.wx_RoleFenxiaoEntity i in fenxiaolist2)
                    {
                        if (m.RoleId == i.RoleId)
                        {
                            if (!list2.Contains(m))
                                list2.Add(m);
                        }
                        
                    }
                    
                }
                if (list.Count > 0 && list != null)
                {
                    if (RoleId > 0)
                        dpdRole.DataSource = list.Where(c => c.RoleId == RoleId).ToList();
                    else
                        dpdRole.DataSource = list.Except(list2);
                    dpdRole.DataTextField = "Name";
                    dpdRole.DataValueField = "RoleId";
                    dpdRole.DataBind();
                }

                if (RoleId != 0)
                {
                    IList<Weifenxiao.Entity.wx_RoleFenxiaoEntity> fenxiaolist = Weifenxiao.BLL.wx_RoleFenxiaoBLL.GetInstance().GetListByShopIdAndRole(identity.ShopID,RoleId);

                    dpdRole.SelectedValue = fenxiaolist[0].RoleId.ToString();

                    Weifenxiao.Entity.wx_RoleFenxiaoEntity rolefenxiao = null;
                    if (this.hidHehuoren.Text.Trim() != "")
                    {
                        rolefenxiao = fenxiaolist.FirstOrDefault(c => c.SetRoleId == int.Parse(this.hidHehuoren.Text.Trim()));
                        if (rolefenxiao != null)
                        {
                            this.txtHehuoren.Text = rolefenxiao.Commission.ToString();
                            this.txtHehuorenQudao.Text = rolefenxiao.QuDao.ToString();
                        }
                    }
                    if (this.hidJinpai.Text.Trim() != "")
                    {
                        rolefenxiao = fenxiaolist.FirstOrDefault(c => c.SetRoleId == int.Parse(this.hidJinpai.Text.Trim()));
                        if (rolefenxiao != null)
                        {
                            this.txtJinpai.Text = rolefenxiao.Commission.ToString();
                            this.txtJinpaiQudao.Text = rolefenxiao.QuDao.ToString();
                        }
                    }
                    if (this.hidYinpai.Text.Trim() != "")
                    {
                        rolefenxiao = fenxiaolist.FirstOrDefault(c => c.SetRoleId == int.Parse(this.hidYinpai.Text.Trim()));
                        if (rolefenxiao != null)
                        {
                            this.txtYinpai.Text = rolefenxiao.Commission.ToString();
                            this.txtYinpaiQudao.Text = rolefenxiao.QuDao.ToString();
                        }
                    }
                    if (this.hidPutong.Text.Trim() != "")
                    {
                        rolefenxiao = fenxiaolist.FirstOrDefault(c => c.SetRoleId == int.Parse(this.hidPutong.Text.Trim()));
                        if (rolefenxiao != null)
                        {
                            this.txtPutong.Text = rolefenxiao.Commission.ToString();
                            this.txtPutongQudao.Text = rolefenxiao.QuDao.ToString();
                        }
                    }
                    
                }
            }
            
        }
    }
 
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        
        UserIdentity identity = User.Identity as UserIdentity;
        if (identity != null)
        {
            List<Weifenxiao.Entity.wx_RoleFenxiaoEntity> list = new List<Weifenxiao.Entity.wx_RoleFenxiaoEntity>();

            wx_RoleFenxiaoEntity rolefenxiao1 = new wx_RoleFenxiaoEntity();
            wx_RoleFenxiaoEntity rolefenxiao2 = new wx_RoleFenxiaoEntity();
            wx_RoleFenxiaoEntity rolefenxiao3 = new wx_RoleFenxiaoEntity();
            wx_RoleFenxiaoEntity rolefenxiao4 = new wx_RoleFenxiaoEntity();
            if (RoleId > 0)
            {
                Weifenxiao.BLL.wx_RoleFenxiaoBLL.GetInstance().Delete(identity.ShopID,RoleId);
                
            }
            
            rolefenxiao1.Commission = this.txtHehuoren.Text == "" ? 0 : decimal.Parse(this.txtHehuoren.Text.Trim());
            rolefenxiao1.SetRoleId = int.Parse(hidHehuoren.Text.Trim());
            rolefenxiao1.RoleId = RoleId>0?RoleId:int.Parse(dpdRole.SelectedValue.ToString());
            rolefenxiao1.ShopId = identity.ShopID;
            rolefenxiao1.QuDao = this.txtHehuorenQudao.Text == "" ? 0 : decimal.Parse(this.txtHehuorenQudao.Text.Trim());
            list.Add(rolefenxiao1);

            rolefenxiao2.Commission = this.txtJinpai.Text == "" ? 0 : decimal.Parse(this.txtJinpai.Text.Trim());
            rolefenxiao2.SetRoleId = int.Parse(hidJinpai.Text.Trim());
            rolefenxiao2.RoleId = RoleId > 0 ? RoleId : int.Parse(dpdRole.SelectedValue.ToString());
            rolefenxiao2.ShopId = identity.ShopID;
            rolefenxiao2.QuDao = this.txtJinpaiQudao.Text == "" ? 0 : decimal.Parse(this.txtJinpaiQudao.Text.Trim());
            list.Add(rolefenxiao2);

            rolefenxiao3.Commission = this.txtYinpai.Text == "" ? 0 : decimal.Parse(this.txtYinpai.Text.Trim());
            rolefenxiao3.SetRoleId = int.Parse(hidYinpai.Text.Trim());
            rolefenxiao3.RoleId = RoleId > 0 ? RoleId : int.Parse(dpdRole.SelectedValue.ToString());
            rolefenxiao3.ShopId = identity.ShopID;
            rolefenxiao3.QuDao = this.txtYinpaiQudao.Text == "" ? 0 : decimal.Parse(this.txtYinpaiQudao.Text.Trim());
            list.Add(rolefenxiao3);

            rolefenxiao4.Commission = this.txtPutong.Text == "" ? 0 : decimal.Parse(this.txtPutong.Text.Trim());
            rolefenxiao4.SetRoleId = int.Parse(hidPutong.Text.Trim());
            rolefenxiao4.RoleId = RoleId > 0 ? RoleId : int.Parse(dpdRole.SelectedValue.ToString());
            rolefenxiao4.ShopId = identity.ShopID;
            rolefenxiao4.QuDao = this.txtPutongQudao.Text == "" ? 0 : decimal.Parse(this.txtPutongQudao.Text.Trim());
            list.Add(rolefenxiao4);

            Weifenxiao.BLL.wx_RoleFenxiaoBLL.GetInstance().Insert(list);

        }
        Response.Redirect("roleyongList.aspx");
    }
}