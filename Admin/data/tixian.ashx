<%@ WebHandler Language="C#" Class="tixian" %>

using System;
using System.Web;

public class tixian : IHttpHandler {
    
    
    
    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain"; 
        switch (type)
        {
            case "pass":
                pass(applyid);
                break; 
        }
    } 
    public void pass(int applyid)
    {
        try
        {
            //status -1 不通过  0 待审核 1 通过
            Weifenxiao.Entity.ApplyEntity model = Weifenxiao.BLL.ApplyBLL.GetInstance().GetAdminSingle(applyid);
            if (model != null)
            {
                Weifenxiao.Entity.wx_UsersEntity user = Weifenxiao.BLL.wx_UsersBLL.GetInstance().GetAdminSingle(model.OpenId);
                if (user != null)
                {
                    if (user.Wallet >= model.Money)
                    {

                        model.Status = 1;
                        Weifenxiao.BLL.ApplyBLL.GetInstance().Update(model);

                        user.Wallet = user.Wallet - model.Money;
                        user.UpdateTime = DateTime.Now;
                        Weifenxiao.BLL.wx_UsersBLL.GetInstance().Update(user);

                        HttpContext.Current.Response.Write("{\"result\":\"ok\"}");
                    }
                    else
                    {
                        HttpContext.Current.Response.Write("{\"result\":\"error\"}");
                    }
                }
                else
                {
                    HttpContext.Current.Response.Write("{\"result\":\"error\"}");
                }
            }
            else
            {
                HttpContext.Current.Response.Write("{\"result\":\"error\"}");
            }
            
        }
        catch (Exception ex)
        {
            HttpContext.Current.Response.Write("{\"result\":\"error\",\"message\":\"" + ex.Message + "\"}");
        }
    }
    public int applyid
    {
        get
        {
            object obj = HttpContext.Current.Request.QueryString["applyid"];
            if (obj == null)
                return 0;
            int m = 0;
            int.TryParse(obj.ToString(), out m);
            return m;
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
    public bool IsReusable {
        get {
            return false;
        }
    }

}