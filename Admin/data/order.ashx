<%@ WebHandler Language="C#" Class="order" %>

using System;
using System.Web;

public class order : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
        //context.Response.Write("Hello World");
        switch (type)
        {
            case "tuikuan":
                tuikuan(oid);
                break;
            case "tuihuo":
                tuihuo(oid);
                break;
        }
    }
    /// <summary>
    /// 订单申请发货
    /// </summary>
    /// <param name="oid"></param>
    public void fahuo(int oid)
    {
        UpdateStatus(oid, 3);
    }
    /// <summary>
    /// 订单申请退款
    /// </summary>
    /// <param name="oid"></param>
    public void tuikuan(int oid)
    {
        UpdateStatus(oid, -2);
    }
    /// <summary>
    /// 订单申请退货
    /// </summary>
    /// <param name="oid"></param>
    public void tuihuo(int oid)
    {
        UpdateStatus(oid, -3);
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="oid"></param>
    /// <param name="status"></param>
    public void UpdateStatus(int oid, int status)
    {
        try
        {
            Weifenxiao.Entity.OrdersEntity model = Weifenxiao.BLL.OrdersBLL.GetInstance().GetAdminSingle(oid);
            model.Status = status;
            if (status == -2)
                model.RefundTime = DateTime.Now;
            else if (status == -3)
                model.ReturnTime = DateTime.Now;
            else if (status == 3)
                model.SendTime = DateTime.Now;
            //model.UpdateTime = DateTime.Now;
            Weifenxiao.BLL.OrdersBLL.GetInstance().Update(model);
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
    public int oid
    {
        get
        {
            object obj = HttpContext.Current.Request.QueryString["oid"];
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