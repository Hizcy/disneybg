using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Weifenxiao.Entity;
public partial class Tproduct_t_skuEdit : System.Web.UI.Page
{
    public int productId
    {
        get
        {
            object obj = Request.QueryString["proid"];
            if (obj == null)
                return 0;
            int m = 0;
            int.TryParse(obj.ToString(), out m);
            return m;
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Request["cmd"]))
        {
            if (Request["cmd"] == "GetTAttrValueSKUListByProcuctId")
            {
                object obj = Request["productid"];
                if (obj == null) return;
                int productid = 0;
                int.TryParse(obj.ToString(), out productid);
                IList<Weifenxiao.Entity.T_AttrValueSKUEntity> list = Weifenxiao.BLL.T_AttrValueSKUBLL.GetInstance().GetTAttrValueSKUListByProcuctId(productid);
                string resJson = Jnwf.Utils.Json.JsonHelper.SerializeJson(list);
                Response.Write(resJson);
                Response.End();
            }
            else if (Request["cmd"] == "InsetProductSKU")  //批量插入
            {
                string json_productsku = Request["data"];
                json_productsku = System.Web.HttpUtility.UrlDecode(json_productsku);
                T_ProductSKUEntity a = new T_ProductSKUEntity();

                List<T_ProductSKUEntity> list_productsku = Jnwf.Utils.Json.JsonHelper.DeserializeJsonReturnList<T_ProductSKUEntity>(json_productsku);
                int res = Weifenxiao.BLL.T_ProductSKUBLL.GetInstance().Insert(list_productsku);
                Response.Write(res);
                Response.End();
            }
            else if (Request["cmd"] == "UpdateProductSKU")  //批量更新
            {
                string json_productsku = Request["data"];
                json_productsku = System.Web.HttpUtility.UrlDecode(json_productsku);
                T_ProductSKUEntity a = new T_ProductSKUEntity();

                List<T_ProductSKUEntity> list_productsku = Jnwf.Utils.Json.JsonHelper.DeserializeJsonReturnList<T_ProductSKUEntity>(json_productsku);
                int res = Weifenxiao.BLL.T_ProductSKUBLL.GetInstance().Update(list_productsku);
                Response.Write(res);
                Response.End();
            }
            else if (Request["cmd"] == "GetProductSKUList")  //
            {
                object obj = Request["productid"];
                if (obj == null) return;
                int productid = 0;
                int.TryParse(obj.ToString(), out productid);
                IList<T_ProductSKUEntity> skulist = Weifenxiao.BLL.T_ProductSKUBLL.GetInstance().GetProductSKUList(productid);
                string resJson = Jnwf.Utils.Json.JsonHelper.SerializeJson(skulist);
                Response.Write(resJson);
                Response.End();
            }
            else if (Request["cmd"] == "GetAttrSKUList")
            {
                IList<Weifenxiao.Entity.T_AttrSKUEntity> list = Weifenxiao.BLL.T_AttrSKUBLL.GetInstance().GetAttrSKUList();

                string resJson = Jnwf.Utils.Json.JsonHelper.SerializeJson(list);
                Response.Write(resJson);
                Response.End();
            }


        }


    }

}