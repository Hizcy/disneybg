using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class order_orderList : System.Web.UI.Page
{
    public int type
    {
        get
        {
            object obj = Request.QueryString["type"];
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
        string where = "";
        if (type == 0)
            where = " and status>0";
        else if (type == 1)
            where = " and status=2";
        else if (type == 2)
            where = " and status=3";
        else if (type == 3)
            where = " and status=4";

        if (!string.IsNullOrEmpty(this.txtProductName.Text.Trim()))
        {
            where += " and productname like '" + this.txtProductName.Text.Trim() + "%'";
        }
        if (!string.IsNullOrEmpty(this.txtBuyer.Text.Trim()))
        {
            where += " and buyer='" + this.txtBuyer.Text.Trim() + "'";
        }
        if (!string.IsNullOrEmpty(this.txtPhone.Text.Trim()))
        {
            where += " and phone='" + this.txtPhone.Text.Trim() + "'";
        }
        if (!string.IsNullOrEmpty(startDate.Value.Trim()))
        {
            where += " and '" + startDate.Value.Trim() + "'>= addtime ";
        }
        if (!string.IsNullOrEmpty(endDate.Value.Trim()))
        {
            where += " and addtime<='" + endDate.Value.Trim() + "'";
        }
        UserIdentity identity = User.Identity as UserIdentity;
        if (identity != null)
        {
            int allCount;
            int CurrentPage = 0;
            CurrentPage = this.pager1.CurrentPageIndex;
            List<Weifenxiao.Entity.OrderExtEntity> list = Weifenxiao.BLL.OrdersBLL.GetInstance().GetListByPage(pager1.PageSize, CurrentPage, "shopid=" + identity.ShopID + where, out allCount) as List<Weifenxiao.Entity.OrderExtEntity>;

            if (list != null)
            {
                list.ForEach(c =>
                {
                    c.ItemInfo = GetItemInfo(c);
                });

                
            }
            rptResultsList.DataSource = list;
            rptResultsList.DataBind();

            pager1.RecordCount = allCount;
            pager1.CurrentPageIndex = CurrentPage;
        
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
    protected string GetItemInfo(Weifenxiao.Entity.OrderExtEntity model)
    {
        StringBuilder sb = new StringBuilder();
        
        string ret = @"<tr>
                        <td align=""center"" style=""width: 50px;"" >
                            <img alt="""" width=""50px"" height=""50px"" src=""{0}"">
                        </td>
                        <td style="""">{1}<span id=""MainContent_rptOrder_rptList_2_lblRole_0""></span></td>
                        <td style=""width: 50px;"">{2}</td>
                        <td style=""width: 39px;"">{3}</td>
                        <td style=""width: 50px;"">{4}</td>
                        <td style=""width: 80px;"">{5}</td>
                        <td>
                            <a href=""/user/agency.aspx?id={7}"">{6}</a> 
                        </td>
                    </tr>";
        foreach (Weifenxiao.Entity.OrdersItemExtEntity m in model.List)
        {
            string str = string.Format(ret, m.ProductImage, m.ProductName + " " + m.attr, m.Price, m.Number, model.Buyer, Status(model.Status), m.dailiName, m.dailiId == 0 ? "#" : m.dailiId.ToString());
            sb.Append(str);
        }
        return sb.ToString();
    }
    protected string Status(int status)
    {
        switch (status)
        {
            case 1:
                return "已下单";
            case 2:
                return "已付款";
            case 3:
                return "已发货";
            case 4:
                return "已收货";
            default: return "";
        }
    }
    protected void btnQuery_Click(object sender, EventArgs e)
    {
        BindData();
    }
    public string showButton(int status, int OrderId)
    {
        if (status == 1)
        {
            //all = 1;
            return "<p style=\"color:#3DC054;margin-left: 14px;height:20px;float:right;\">已下单，待付款</p>";
        }
        else if (status == 2)
        {
             
            //all = 2;
            return "<p style=\"margin-left: 14px;float:right;background: #679b31;padding: 0 5px;\"><a href='fahuo.aspx?orderid=" + OrderId + "' class=\"pf\" style=\"color:#fff;\">标记发货</a></p><p style=\"margin-left: 14px;float:right;background: #ffa100;padding: 0 5px;\"><a href='javascript:tuikuan(" + OrderId + ")' class=\"ptk\" style=\"color:#fff;\">标记退款</a></p><p><a href='javascript:orderTuikuan(" + OrderId + ")'>退款</a></p>";
        }
        else if (status == 3)
        {
            //all = 3;
            return "<p style=\"margin-left: 14px;float:right;background: #679b31;padding: 0 5px;\"><a href='javascript:tuihuo(" + OrderId + ")' class=\"pth\" style=\"color:#fff;\">标记退货</a></p><p><a href='javascript:orderTuikuan(" + OrderId + ")'>退款</a></p>";
        }
        else if (status == 4)
        {
            //all = 4;
            return "<p style=\"color:red;margin-left: 14px;height:20px;float:right;\">完成</p><p><a href='javascript:orderTuikuan(" + OrderId + ")'>退款</a></p>";
        }
        return "--";
    }
}
