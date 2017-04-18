using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class user_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindData();
        }
    }
    private void BindData()
    {

        UserIdentity identity = User.Identity as UserIdentity;
        if (identity != null)
        {
            int allCount;
            int CurrentPage = 0;
            CurrentPage = this.pager1.CurrentPageIndex;
            DataSet ds = Weifenxiao.BLL.wx_UsersBLL.GetInstance().GetListByPage(pager1.PageSize, CurrentPage, "shopid=" + identity.ShopID + " and status=0" , out allCount);

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

}