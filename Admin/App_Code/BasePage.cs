﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

/// <summary>
///BasePage 的摘要说明
/// </summary>
public class BasePage : System.Web.UI.Page
{
    public BasePage()
    {
        //
        //TODO: 在此处添加构造函数逻辑
        //
    }

    Literal ltlMessage;

    protected override void OnInit(EventArgs e)
    {
        base.OnInit(e);
    }

    protected override void OnLoad(EventArgs e)
    {
        Control c = this.FinnalControl(this, "ltlMessage");
        if (c != null && c is Literal)
        {
            ltlMessage = c as Literal;
            ltlMessage.Visible = false;
        }


        base.OnLoad(e);

    }


    /// <summary>
    /// 提示信息
    /// </summary>
    /// <param name="type">aSuccess|aError|aWarning|aInfo</param>
    /// <param name="title"></param>
    /// <param name="content"></param>
    protected void ShowTips(string type, string title, string content)
    {
        //Control c = this.FinnalControl(this, "ltlMessage");
        if (ltlMessage != null)
        {
            string html = "<h4 class='alertP " + type + "'><b>" + title + "</b><span>" + content + "</span></h4>";
            ltlMessage.Visible = true;
            ltlMessage.Text = html;
            //ClientScript.RegisterClientScriptBlock(this.GetType(), "showTips", html);
        }
    }
    protected Control FinnalControl(Control p, string id)
    {
        Control ctrl = null;
        foreach (Control c in p.Controls)
        {
            //Response.Write(c.ID + "\r\n");
            if (c.ID == id)
                return c;
            if (!c.HasControls())
                continue;

            ctrl = FinnalControl(c, id);
        }

        return ctrl;
    }
    /// <summary>
    /// 导出Excel
    /// </summary>
    /// <param name="gridView">GridView</param>
    /// <param name="nameTitle">导出名称</param>
    public static void GridViewToExcel(GridView gridView, string strFileName)
    {
        #region <<====数据格式导出====>>

        HttpContext HC = HttpContext.Current;
        HC.Response.Clear();
        HC.Response.Buffer = true;
        HC.Response.ContentEncoding = System.Text.Encoding.UTF8;
        HC.Response.HeaderEncoding = System.Text.Encoding.GetEncoding("GB2312");

        HC.Response.AddHeader("Content-Disposition", "attachment;filename=" + strFileName + ".xls");
        HC.Response.ContentType = "application/ms-excel";
        //HC.Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet;";

        string strStyle = "<style>td{mso-number-format:\"\\@\";}</style>";

        System.IO.StringWriter sw = new System.IO.StringWriter();
        System.Web.UI.HtmlTextWriter htw = new System.Web.UI.HtmlTextWriter(sw);
        gridView.Visible = true;
        sw.WriteLine(strStyle);


        gridView.RenderControl(htw);
        if (gridView.Rows.Count > 0)
        {
            HC.Response.Write("\ufeff" + sw.ToString());
        }

        HC.Response.Flush();
        HC.Response.End();

        #endregion
    }
    /// <summary>
    /// SQL防注入方法，对每个查询字符串做检查
    /// </summary>
    /// <param name="strTextIn"></param>
    /// <returns></returns>
    public static string SqlInject(string strTextIn)
    {
        if ((strTextIn != null) && (strTextIn != ""))
        {
            string str = strTextIn.ToLower().Replace(" ", "%20");
            
            if (str.IndexOf("alert") != -1)
            {
                str = str.Replace("alert", " ");
            }
            if (str.IndexOf("%20and%20") != -1)
            {
                str = str.Replace("%20and%20", " ");
            }
            if (str.IndexOf("having") != -1)
            {
                str = str.Replace("having", " ");
            }
            if (str.IndexOf("%20db_name") != -1)
            {
                str = str.Replace("%20db_name", " ");
            }
            if (str.IndexOf("%20or%20") != -1)
            {
                str = str.Replace("%20or%20", " ");
            }
            if (str.IndexOf("net%20user") != -1)
            {
                str = str.Replace("net%20user", " ");
            }
            if (str.IndexOf("'") != -1)
            {
                str = str.Replace("'"," ");
            }
            if (str.IndexOf("/add") != -1)
            {
                str = str.Replace("/add", " ");
            }
            if (str.IndexOf("select%20") != -1)
            {
                str = str.Replace("select%20", " ");
            }
            if (str.IndexOf("insert%20") != -1)
            {
                str = str.Replace("insert%20", " ");
            }
            if (str.IndexOf("delete%20from") != -1)
            {
                str = str.Replace("delete%20from", " ");
            }
            if (str.IndexOf("drop%20") != -1)
            {
                str = str.Replace("drop%20", " ");
            }
            if (str.IndexOf("update%20") != -1)
            {
                str = str.Replace("update%20", " ");
            }
            if (str.IndexOf("truncate%20") != -1)
            {
                str = str.Replace("truncate%20", " ");
            }
            if (str.IndexOf("asc(") != -1)
            {
                str = str.Replace("asc(", " ");
            }
            if (str.IndexOf("mid(") != -1)
            {
                str = str.Replace("mid(", " ");
            }
            if (str.IndexOf("char(") != -1)
            {
                str = str.Replace("char(", " ");
            }
            if (str.IndexOf("count(") != -1)
            {
                str = str.Replace("count(", " ");
            }
            if (str.IndexOf("xp_cmdshell") != -1)
            {
                str = str.Replace("xp_cmdshell", " ");
            }
            if (str.IndexOf("exec%20master") != -1)
            {
                str = str.Replace("exec%20master", " ");
            }
            if (str.IndexOf("net%20localgroup%20administrators") != -1)
            {
                str = str.Replace("net%20localgroup%20administrators", " ");
            }
            return str;
        }
        else
        {
            return string.Empty;
        }
    
    }
}