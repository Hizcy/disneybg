<%@ WebHandler Language="C#" Class="tproduct" %>

using System;
using System.Web;

public class tproduct : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
        //context.Response.Write("Hello World");
        switch (type)
        {
            case "shangjia":
                shangjia(pid);
                break;
            case "xiajia":
                xiajia(pid);
                break;
            case "shanchu":
                shanchu(pid);
                break;
            case "quanzhong":
                UpdateOrderBy(pid, orderby);
                break;
        }
    }
    /// <summary>
    /// 产品上架，需要修改状态2
    /// </summary>
    /// <param name="pid"></param>
    public void shangjia(int pid)
    {
        UpdateStatus(pid, 2);
    }
    /// <summary>
    /// 产品下架，需要修改状态-2
    /// </summary>
    /// <param name="pid"></param>
    public void xiajia(int pid)
    {
        UpdateStatus(pid, -2);
    }
    /// <summary>
    /// 产品删除，需要修改状态-1
    /// </summary>
    /// <param name="pid"></param>
    public void shanchu(int pid)
    {
        UpdateStatus(pid, -1);
    }
    public void UpdateStatus(int pid, int status)
    {
        try
        {
            Weifenxiao.Entity.T_ProductsEntity model = Weifenxiao.BLL.T_ProductsBLL.GetInstance().GetAdminSingle(pid);
            model.Status = status;
            model.UpdateTime = DateTime.Now;
            Weifenxiao.BLL.T_ProductsBLL.GetInstance().Update(model);
            HttpContext.Current.Response.Write("{\"result\":\"ok\"}");
        }
        catch (Exception ex)
        {
            HttpContext.Current.Response.Write("{\"result\":\"error\",\"message\":\"" + ex.Message + "\"}");
        }
    }
    /// <summary>
    /// 修改产品权重
    /// </summary>
    /// <param name="pid"></param>
    /// <param name="orderby"></param>
    public void UpdateOrderBy(int pid, int orderby)
    {
        try
        {
            Weifenxiao.Entity.T_ProductsEntity model = Weifenxiao.BLL.T_ProductsBLL.GetInstance().GetAdminSingle(pid);
            model.OrderBy = orderby;
            model.UpdateTime = DateTime.Now;
            Weifenxiao.BLL.T_ProductsBLL.GetInstance().Update(model);
            HttpContext.Current.Response.Write("{\"result\":\"ok\"}");
        }
        catch (Exception ex)
        {
            HttpContext.Current.Response.Write("{\"result\":\"error\",\"message\":\"" + ex.Message + "\"}");
        }
    }
    public string type
    {
        get
        {
            object obj = HttpContext.Current.Request.QueryString["type"];
            if (obj == null)
                return "";
            return obj.ToString();
        }
    }
    public int pid
    {
        get
        {
            object obj = HttpContext.Current.Request.QueryString["pid"];
            if (obj == null)
                return 0;
            int m = 0;
            int.TryParse(obj.ToString(), out m);
            return m;
        }
    }
    public int orderby
    {
        get
        {
            object obj = HttpContext.Current.Request.QueryString["orderby"];
            if (obj == null)
                return 0;
            int m = 0;
            int.TryParse(obj.ToString(), out m);
            return m;
        }
    }
    public bool IsReusable {
        get {
            return false;
        }
    }

}