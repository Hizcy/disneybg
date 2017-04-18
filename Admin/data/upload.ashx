<%@ WebHandler Language="C#" Class="upload" %>

using System;
using System.Web;
using System.Drawing;
using System.IO;
//using Qiniu.IO;
//using Qiniu.RS;
public class upload : IHttpHandler 
{
    public void ProcessRequest (HttpContext context) 
    {
        context.Response.ContentType = "text/plain";
        context.Response.Charset = "utf-8";

        var files = context.Request.Files;
        if (files.Count <= 0) 
        {
            return;
        }

        HttpPostedFile file = files[0];

        if (file == null)
        {
            context.Response.Write("error|file is null");
            return;
        }
        else
        {
            string path = context.Server.MapPath("~/upload/");  //存储图片的文件夹
            string originalFileName = file.FileName;
            string fileExtension = originalFileName.Substring(originalFileName.LastIndexOf('.'), originalFileName.Length - originalFileName.LastIndexOf('.'));
            string currentFileName = DateTime.Now.ToString("yyyyMMddHHmmssfff") + fileExtension;  //文件名中不要带中文，否则会出错
   
            //生成文件路径
            string imagePath = path + currentFileName;
            //保存文件
            file.SaveAs(imagePath);
            //string ak = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("AK");
            //string sk = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("SK");
            //string name = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("NAME");
            //uploadQinui(ak, sk, name, currentFileName, imagePath);
            //获取图片url地址
            string imgUrl = "http://localhost:4067/upload/" + currentFileName;

            //返回图片url地址
            context.Response.Write(imgUrl);
            return;
        }
    }

    /// <summary>
    /// 上传七牛图片
    /// </summary>
    /// <param name="ak">AK</param>
    /// <param name="sk">SK</param>
    /// <param name="kname">上传的空间</param>
    /// <param name="imgkey">图片名称</param>
    /// <param name="imgPath">图片路径</param>
    //public static void uploadQinui(string ak, string sk, string kname, string imgkey, string imgPath)
    //{
    //    try
    //    {
    //        //设置账号的AK和SK
    //        Qiniu.Conf.Config.ACCESS_KEY = ak;
    //        Qiniu.Conf.Config.SECRET_KEY = sk;
    //        IOClient target = new IOClient();
    //        PutExtra extra = new PutExtra();
    //        //设置上传的空间
    //        String bucket = kname;
    //        //设置上传的文件的key值
    //        String key = imgkey;

    //        //普通上传,只需要设置上传的空间名就可以了,第二个参数可以设定token过期时间
    //        PutPolicy put = new PutPolicy(bucket, 3600);

    //        //调用Token()方法生成上传的Token
    //        string upToken = put.Token();
    //        //上传文件的路径
    //        String filePath = imgPath;
    //        Jnwf.Utils.Log.Logger.Log4Net.Error("uploadQinui2:" + filePath + "");
    //        //调用PutFile()方法上传
    //        PutRet ret = target.PutFile(upToken, key, filePath, extra);
    //        Jnwf.Utils.Log.Logger.Log4Net.Error("uploadQinui1:" + ret + "");
    //    }
    //    catch (Exception ex)
    //    {
    //        Jnwf.Utils.Log.Logger.Log4Net.Error("error:uploadQinui:" + ex.Message + "|" + ex.InnerException);
    //    }
    //}

    public bool IsReusable 
    {
        get 
        {
            return false;
        }
    }
}