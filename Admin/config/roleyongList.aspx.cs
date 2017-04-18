using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Linq;

public partial class config_roleyongList : System.Web.UI.Page
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
            IList<Weifenxiao.Entity.wx_RoleFenxiaoEntity> list = Weifenxiao.BLL.wx_RoleFenxiaoBLL.GetInstance().GetListByShopId(identity.ShopID);
            IList<Weifenxiao.Entity.RolesEntity> rolelist = Weifenxiao.BLL.RolesBLL.GetInstance().GetListByShopId(identity.ShopID);

            List<A> alist = new List<A>();
            int roleid = 0;
            Weifenxiao.Entity.RolesEntity role = null;

            foreach (Weifenxiao.Entity.wx_RoleFenxiaoEntity model in list)
            {
                if (roleid != model.RoleId)
                {
                    A a = new A();
                    a.roleid = model.RoleId;
                    
                    role = rolelist.FirstOrDefault(c => c.RoleId == model.RoleId);
                    if (role != null)
                    {
                        a.rolename = role.Name;
                    }
                    

                    foreach (Weifenxiao.Entity.wx_RoleFenxiaoEntity m in list)
                    {
                        if (m.RoleId == model.RoleId)
                        {
                            role = rolelist.FirstOrDefault(c => c.RoleId == m.SetRoleId);
                            if (role != null)
                            {
                                a.desc += role.Name + " 分佣 " + m.Commission + ",渠道 分佣 " + m.QuDao + "<br/>";
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }
                    alist.Add(a);

                    roleid = model.RoleId;
                }
                
            }

            rptPointList.DataSource = alist;
            rptPointList.DataBind();
        }
    }

}
public class A
{
    public int roleid { get; set; }

    public string rolename { get; set; }

    public string desc {get;set;}
}