using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Collections;

public partial class Torder_TorderList : BasePage//System.Web.UI.Page
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

    #region 绑定数据
    
    /// <summary>
    /// 正常显示
    /// </summary>
    /// <param name="where"></param>
    public void BindData()
    {
        string where = String.Empty;
        switch (type)
        {
            case 0:
                where += " and status>0";
                break;
            case 1:
                where += " and GroupStatus=1 and status=2";
                break;
            case 2:
                 where += " and GroupStatus=1 and status=3";
                break;
            case 3:
                where += " and GroupStatus=1 and status=4"; 
                break;
            case 4:
                where += " and GroupStatus=-1 and ((status BETWEEN 2 and 3) or (status BETWEEN -3 and -2))";
                break;

        } 
        //商品名称
        if (!string.IsNullOrEmpty(txtProductName.Text.Trim()))
        {
            where += " and Name like '" + SqlInject(txtProductName.Text.Trim()) + "%'";
        }
        //收货人
        if (!string.IsNullOrEmpty(txtBuyer.Text.Trim()))
        {
            where += " and Buyer='" + SqlInject(txtBuyer.Text.Trim()) + "'";
        }
        // 电话
        if (!string.IsNullOrEmpty(txtPhone.Text.Trim()))
        {
            where += " and Phone='" + SqlInject(txtPhone.Text.Trim()) + "'";
        }
        //下单时间
        if (!string.IsNullOrEmpty(txt_startTime.Value.Trim()))
        {
            where += " and AddTime >= '" + SqlInject(txt_startTime.Value.Trim()) + "'";
        }
        if (!string.IsNullOrEmpty(txt_endTime.Value.Trim()))
        {
            where += " and AddTime <= '" + SqlInject(txt_endTime.Value.Trim()) + "'";
        }
        int allCount;
        int CurrentPage = this.pager1.CurrentPageIndex; 
        DataSet ds = Weifenxiao.BLL.T_OrdersBLL.GetInstance().GetOrderBuyerList(pager1.PageSize, CurrentPage, " 1=1 " + where, out allCount);
        if(ds != null && ds.Tables.Count>0 && ds.Tables[0]!= null && ds.Tables[0].Rows.Count>0)
        { 
            rptOrderList.DataSource = ds.Tables[0];
            rptOrderList.DataBind();
            pager1.RecordCount = allCount;
            pager1.CurrentPageIndex = CurrentPage;
        }
        else
        {
            rptOrderList.DataSource = String.Empty;
            rptOrderList.DataBind();
        }
    }
    #endregion

    /// <summary>
    /// 分页控件的翻页事件
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void pager1_PageChanged(object sender, EventArgs e)
    {
        int currentPage = 1;//默认第一页
        if (!string.IsNullOrEmpty(Request.QueryString["page"]))
        {
            currentPage = int.Parse(Request.QueryString["page"]);
        }
        BindData();
    }
    #region 返回状态
     
    /// <summary>
    /// 发货状态
    /// </summary>
    /// <param name="status"></param>
    /// <param name="orderId"></param>
    /// <returns></returns>
    public string showButton(int status, int orderId)
    {
        switch (status)
        {
            case 1:
                return "<p style=\"color:#3DC054;margin-left: 14px;height:20px;float:right;\">已下单，待付款</p>";
            case 2:
                return "<p style=\"margin-left: 14px;float:right;background: #679b31;padding: 0 5px;\"><a href='fahuo.aspx?orderid=" + orderId + "' class=\"pf\" style=\"color:#fff;\">标记发货</a></p><p style=\"margin-left: 14px;float:right;background: #ffa100;padding: 0 5px;\"><a href='javascript:tuikuan(" + orderId + ")' class=\"ptk\" style=\"color:#fff;\">标记退款</a></p>";
            case 3:
                return "<p style=\"margin-left: 14px;float:right;background: #679b31;padding: 0 5px;\"><a href='javascript:tuihuo(" + orderId + ")' class=\"pth\" style=\"color:#fff;\">标记退货</a></p>";
            case 4:
                return "<p style=\"color:red;margin-left: 14px;height:20px;float:right;\">完成</p>";
            case -2:
                return "<p style=\"color:red;margin-left: 14px;height:20px;float:right;\">已退款</p>";
            default:return "--";
        }  
    }
    /// <summary>
    /// 当前状态
    /// </summary>
    /// <param name="status"></param>
    /// <returns></returns>
    public string orderStatus(int status)
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
            default: return "--";
        }       
    }
    #endregion
    /// <summary>
    /// 查询
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnQuery_Click(object sender, EventArgs e)
    {
        BindData();
    }
    protected void rptOrderList_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        //退款
        if (e.CommandName.Equals("tuikuan"))
        {
            //arr[0]=Postage邮费,arr[1]=groupPrice团购价，arr[2]=orderCode订单编号，arr[3]=订单id,arr[4]=Consignee OpenId,arr[5]=name商品名称,arr[6]=Phone,arr[7]=退款数
            string[] arr = e.CommandArgument.ToString().Trim(',').Split(',');
            float total_fee = float.Parse(arr[0].ToString()) + float.Parse(arr[1].ToString())*100;//总钱数
            Jnwf.Utils.Log.Logger.Log4Net.Error(string.Format("TorderList.aspx;订单编号:{0} 总金额：{1}", arr[2].ToString(), total_fee.ToString()));
            Weifenxiao.BLL.T_OrdersBLL.GetInstance().OrdersTuiKuanPro(Convert.ToInt32(arr[3]));
            Refund.Run("", arr[2], total_fee.ToString(), total_fee.ToString());
           // Jnwf.Utils.Log.Logger.Log4Net.Error("http://m.disneybg.com/data/tuikuan.ashx?openid=" + arr[4] + "&ordercode=" + arr[2] + "&productname=" + arr[5] + "&phone=" + arr[6] + "&tuikuan=" + arr[7]);
            Jnwf.Utils.Helper.HttpHelper.LoadPageContent("http://m.disneybg.com/data/tuikuan.ashx?openid=" + arr[4] + "&ordercode=" + arr[2] + "&productname=" + arr[5] + "&phone="+arr[6]+"&tuikuan="+arr[7]);
            Response.Write("<script>alert('退款成功！')</script>");
            BindData();
        }
    }
}