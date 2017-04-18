<%@ WebHandler Language="C#" Class="orderTuiKuan" %>

using System;
using System.Web;

public class orderTuiKuan : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
        int orderId = Convert.ToInt32(context.Request.Form["orderId"]);
        int i = Weifenxiao.BLL.OrdersBLL.GetInstance().OrderTuiKuan(orderId);
        if (i > 0)
        {
            context.Response.Write(1);
        }
        else
        {
            context.Response.Write(-1);
        }
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}