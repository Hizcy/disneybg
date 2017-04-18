using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class user_Agency : System.Web.UI.Page
{
    public decimal yeji = 0;
    public decimal yongjin = 0;
    public decimal tixian = 0;
    public int yijidaili = 0;

    public string name = "";
    public string nick = "";
    public string phone = "";
    public string weixin = "";
    public string addtime = "";
    public string parent = "";

    public string openid = "";

    public int userid
    {
        get { 
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
            BindData();
        }
    }
    private void BindData()
    {
        UserIdentity identity = User.Identity as UserIdentity;
        if (identity != null)
        {
            DataSet user = Weifenxiao.BLL.wx_UsersBLL.GetInstance().Get_v_UserExt(userid);
            if (user != null && user.Tables.Count > 0 && user.Tables[0] != null && user.Tables[0].Rows.Count > 0)
            {
                name = user.Tables[0].Rows[0]["realname"].ToString();
                nick = user.Tables[0].Rows[0]["nickname"].ToString();
                phone = user.Tables[0].Rows[0]["phone"].ToString();
                weixin = user.Tables[0].Rows[0]["weixin"].ToString();
                addtime = user.Tables[0].Rows[0]["addtime"].ToString();
                parent = user.Tables[0].Rows[0]["parentname"].ToString();
                openid = user.Tables[0].Rows[0]["openid"].ToString();
                yeji = (decimal)user.Tables[0].Rows[0]["yeji"];
                yongjin = (decimal)user.Tables[0].Rows[0]["yongjin"];
                tixian = (decimal)user.Tables[0].Rows[0]["tixian"];
                yijidaili = (int)user.Tables[0].Rows[0]["yijidaili"];
            }

            string where = " and daili='" + openid + "' or consignee='" + openid + "'";
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
    protected string GetItemInfo(Weifenxiao.Entity.OrderExtEntity model)
    {
        StringBuilder sb = new StringBuilder();

        string ret = @"<tr class=""tr2"" style=""background: #fff;"">
                         <td>
                            <img alt="""" width=""50px"" height=""50px"" src=""{0}"">
                        </td>
                        <td style=""width:200px;"">{1}<span id=""MainContent_rptOrder_rptList_2_lblRole_0""></span></td>
                        <td>{2}</td>
                        <td>{3}</td>
                        <td>{4}</td>
                        <td>{5}</td>
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
            return "<p style=\"margin-left: 14px;float:right;background: #679b31;padding: 0 5px;\"><a href='fahuo.aspx?orderid=" + OrderId + "' class=\"pf\" style=\"color:#fff;\">标记发货</a></p><p style=\"margin-left: 14px;float:right;background: #ffa100;padding: 0 5px;\"><a href='javascript:tuikuan(" + OrderId + ")' class=\"ptk\" style=\"color:#fff;\">标记退款</a></p>";
        }
        else if (status == 3)
        {
            //all = 3;
            return "<p style=\"margin-left: 14px;float:right;background: #679b31;padding: 0 5px;\"><a href='javascript:tuihuo(" + OrderId + ")' class=\"pth\" style=\"color:#fff;\">标记退货</a></p>";
        }
        else if (status == 4)
        {
            //all = 4;
            return "<p style=\"color:red;margin-left: 14px;height:20px;float:right;\">完成</p>";
        }
        return "--";
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