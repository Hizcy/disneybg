<%@ WebHandler Language="C#" Class="product" %>

using System;
using System.Web;

public class product : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
        
        switch (type)
        {
            case "aduit":
                aduit(uid);
                break;
        }
        
    }
  
    /// <summary>
    /// 产品上架，需要修改状态2
    /// </summary>
    /// <param name="pid"></param>
    public void aduit(int uid)
    {
       int result= Weifenxiao.BLL.wx_UsersBLL.GetInstance().AuditPass(uid);

       if (result > 0)
       {
           HttpContext.Current.Response.Write("{\"result\":\"ok\"}");
       }
       else
       {
           HttpContext.Current.Response.Write("{\"result\":\"error\"}");
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
    public int uid
    {
        get
        {
            object obj = HttpContext.Current.Request.QueryString["uid"];
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