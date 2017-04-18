using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class user_userList : System.Web.UI.Page
{
    public int roleid
    {
        get
        {
            object obj = Request.QueryString["roleid"];
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
            BindData();

        }
    }
    private void BindData()
    {
        string s = "";

        if (!string.IsNullOrEmpty(this.txtSname.Text)) {
            s += " and RealName like '%"+this.txtSname.Text.Trim()+"%'";
        }
        if (!string.IsNullOrEmpty(this.txtSphone.Text.Trim()))
        {
            s += " and Phone like '%" + this.txtSphone.Text.Trim() + "%'";
        }
        if (!string.IsNullOrEmpty(this.txtSweixin.Text.Trim())) {
            s += " and Weixin like '%" + this.txtSweixin.Text.Trim() + "%'";
        }
        if(!string.IsNullOrEmpty(this.startDate.Value.Trim())&!string.IsNullOrEmpty(this.endDate.Value.Trim())){
            s += " and addTime > '" + this.startDate.Value.Trim() + "' and addtime< '"+this.endDate.Value.Trim()+"'";
        }

        UserIdentity identity = User.Identity as UserIdentity;
        if (identity != null)
        {
            int allCount;
            int CurrentPage = 0;
            CurrentPage = this.pager1.CurrentPageIndex;
            DataSet ds = Weifenxiao.BLL.wx_UsersBLL.GetInstance().GetListByPage(pager1.PageSize, CurrentPage, "shopid=" + identity.ShopID + " and status=1"+s, out allCount);

            if (ds != null && ds.Tables.Count > 0)
            {
                rptResultsList.DataSource = ds;
                rptResultsList.DataBind();

                pager1.RecordCount = allCount;
                pager1.CurrentPageIndex = CurrentPage;
            }

        }
    }
    /// <summary>
    /// 分页控件的翻页事件
    /// </summary>
    protected void AspNetPager1_PageChanged(object sender, EventArgs e)
    {
        int currentPage = 1;   //默认显示第一页
        if (!string.IsNullOrEmpty(Request.QueryString["page"]))
        {
            currentPage = int.Parse(Request.QueryString["page"]);
        }   //通过网页get方式获取当前页码
        BindData();
    } 
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        BindData();
    }
}