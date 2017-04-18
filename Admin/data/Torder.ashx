<%@ WebHandler Language="C#" Class="Torder" %>

using System;
using System.Web;

public class Torder : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
        string type = context.Request.Params["type"];
        int orderId = int.Parse(HttpContext.Current.Request["OrderId"].ToString());  
        switch (type)
        {
            case "tuikuan":
                tuikuan(orderId);
                break;
            case "tuihuo":
                tuihuo(orderId);
                break;
        }
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
    public void UpdateStatus(int oid, int status)
    {
        try
        {
            Weifenxiao.Entity.T_OrdersEntity model = Weifenxiao.BLL.T_OrdersBLL.GetInstance().GetAdminSingle(oid);
            model.Status = status; 
            model.RefundTime = DateTime.Now; 
            //model.UpdateTime = DateTime.Now;
            Weifenxiao.BLL.T_OrdersBLL.GetInstance().Update(model);
            HttpContext.Current.Response.Write(1);
        }
        catch (Exception ex)
        {
            HttpContext.Current.Response.Write(-1);
        }
    } 
    public bool IsReusable {
        get {
            return false;
        }
    }

}