<%@ WebHandler Language="C#" Class="UploadHandler" %>

using System;
using System.Web;
using System.IO;
using System.Globalization;
using System.Configuration;
using System.Collections;

public class UploadHandler : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/html";
        context.Response.Charset = "utf-8";
        //最大文件大小 10M
        int maxSize = 10485760;
        //定义允许上传的文件扩展名
        
        Hashtable extTable = new Hashtable();
        extTable.Add("image", "gif,jpg,jpeg,png,bmp");
        //extTable.Add("flash", "swf,flv");
        //extTable.Add("media", "swf,flv,mp3,wav,wma,wmv,mid,avi,mpg,asf,rm,rmvb");
        //extTable.Add("file", "doc,docx,xls,xlsx,ppt,htm,html,txt,zip,rar,gz,bz2");
        //文件保存相对路径
        string saveUrl = ConfigurationManager.AppSettings["savePath"] + "ShopImg_" + shopid+"/";
        try
        {
            //获取客户端上传文件
            HttpPostedFile postFile = context.Request.Files[0];
            if (postFile == null)
            {
                context.Response.Write("{\"succ\":false,\"msg\":\"请选择文件\"}");
                return;
            }
            if (postFile.InputStream == null || postFile.InputStream.Length > maxSize)
            {
                context.Response.Write("{\"succ\":false,\"msg\":\"上传文件大小超过限制\"}");
                return;
            }
            //获取扩展名
            string fileExt = Path.GetExtension(postFile.FileName).ToLower();
            if (string.IsNullOrEmpty(fileExt) || Array.IndexOf(((string)extTable["image"]).Split(','), fileExt.Substring(1).ToLower()) == -1)
            {
                context.Response.Write("{\"succ\":false,\"msg\":\"上传图片格式不正确\"}");
                return;
            }

            //文件保存物理路径
            string savePath = context.Server.MapPath(saveUrl);
            //新文件名
            string newFileName =  DateTime.Now.ToString("yyyyMMddHHmmssffff") + fileExt;

            if (!Directory.Exists(savePath))
            {
                Directory.CreateDirectory(savePath);
            }
            //保存上载文件
            postFile.SaveAs(savePath + newFileName);
            context.Response.Write("{\"succ\":true,\"image\":\"" + (saveUrl.Replace("~","")) + newFileName + "\"}");
        }
        catch (Exception ex)
        {
           
            context.Response.Write("{\"succ\":false,\"msg\":\"上传文件异常：" + ex.Message + "\"}");
        }
        finally
        {
            context.Response.End(); 
        }
    }

    public bool IsReusable {
        get {
            return false;
        }
    }
    public int shopid
    {
        get
        {
           // object obj = HttpContext.Current.Request.QueryString["shopid"];
            string obj =  HttpContext.Current.Request.Form["shopid"];            
            int m = 0;
            int.TryParse(obj.ToString(), out m);
            return m;
        }
    }
}