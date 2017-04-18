using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Tproduct_t_proList : System.Web.UI.Page
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

            DataSet ds = Weifenxiao.BLL.T_ProductsBLL.GetInstance().Get_T_ListByPage(pager1.PageSize, CurrentPage, "shopid=" + identity.ShopID + " and status <>-1", out allCount);

            if (ds != null && ds.Tables.Count > 0)
            {
                rptResultsList.DataSource = ds;
                rptResultsList.DataBind();
                pager1.RecordCount = allCount;
                pager1.CurrentPageIndex = CurrentPage;
            }

        }
    }
    //搜索商品
    protected void btnQuery_Click(object sender, EventArgs e)
    {
        string where = String.Empty;

        //商品名称
        if (!string.IsNullOrEmpty(txtProductName.Text.Trim()))
        {
            where += " and Name like '%" + txtProductName.Text.Trim() + "%'";
        }

        int allCount;
        int CurrentPage = this.pager1.CurrentPageIndex;
        DataSet ds = Weifenxiao.BLL.T_ProductsBLL.GetInstance().Get_T_ListByPage(pager1.PageSize, CurrentPage, " 1=1 " + where, out allCount);
        if (ds != null && ds.Tables.Count > 0 && ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
        {
            rptResultsList.DataSource = ds.Tables[0];
            rptResultsList.DataBind();
            pager1.RecordCount = allCount;
            pager1.CurrentPageIndex = CurrentPage;
        }
        else
        {
            rptResultsList.DataSource = String.Empty;
            rptResultsList.DataBind();
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
    public String GetStatus(String status)
    {
        string s = status;
        switch (status)
        {
            case "1": s = "未上架"; break;
            case "-1": s = "删除"; break;
            case "2": s = "已上架"; break;
            case "-2": s = "已下架"; break;
            default: break;
        }
        return s;
    }
}