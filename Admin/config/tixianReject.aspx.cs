using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Weifenxiao.BLL;
using Weifenxiao.Entity;

public partial class config_tixianReject : System.Web.UI.Page
{

    public int applyid
    {
        get
        {
            object obj = Request.QueryString["applyid"];
            if (obj == null)
                return 0;
            int m = 0;
            int.TryParse(obj.ToString(), out m);
            return m;
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        
        Weifenxiao.Entity.ApplyEntity model = Weifenxiao.BLL.ApplyBLL.GetInstance().GetAdminSingle(applyid);
        model.Status = -1;
        model.Reason = this.txtReason.Value;
        model.Updatetime = DateTime.Now;
        ApplyBLL.GetInstance().Update(model);
        Response.Redirect("tixianList.aspx");
    }
}