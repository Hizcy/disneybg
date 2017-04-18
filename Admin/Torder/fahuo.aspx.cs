using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class order_fahuo : System.Web.UI.Page
{
    public int orderid
    {
        get
        {
            object obj = Request.QueryString["orderid"];
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
            
        }

    }
    protected void btnFahuo_Click(object sender, EventArgs e)
    {
        Weifenxiao.Entity.T_OrdersEntity model = Weifenxiao.BLL.T_OrdersBLL.GetInstance().GetAdminSingle(orderid);

        if (model.Status <= 3)
        {
            model.Status = 3;
            model.SendTime = DateTime.Now;
            model.expresstype = int.Parse(ddlKuaidi.Value);
            model.expresscode = txtKuadidihao.Text.Trim();
            Weifenxiao.BLL.T_OrdersBLL.GetInstance().Update(model);

            //发送发货通知-模板消息
            if (model.ordertype <= 2)
            {
                Jnwf.Utils.Helper.HttpHelper.LoadPageContent("http://m.disneybg.com/data/sendDeliver.ashx?openid=" + model.Daili + "&ordercode=" + model.OrderCode);
            }
            Response.Redirect("TorderList.aspx");
        }
        else
        {
            Response.Write("<script>alert('添加失败！');</script>");
        }
        
    }
}