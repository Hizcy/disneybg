using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Weifenxiao.Entity;

public partial class product_skuEdit : System.Web.UI.Page
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
            if (Request["cmd"] == "GetAttrValueSKUListByProcuctId") {
                object obj = Request["productid"];
                if (obj == null) return;
                int productid = 0;
                int.TryParse(obj.ToString(), out productid);
                IList<Weifenxiao.Entity.AttrValueSKUEntity> list = Weifenxiao.BLL.AttrValueSKUBLL.GetInstance().GetAttrValueSKUListByProcuctId(productid);

               // string resJson = "[{\"Id\":5,\"ProductId\":473,\"AttrSkuId\":1,\"AttrSkuVal\":\"黑色\"},{\"Id\":6,\"ProductId\":473,\"AttrSkuId\":1,\"AttrSkuVal\":\"白色\"},{\"Id\":7,\"ProductId\":473,\"AttrSkuId\":1,\"AttrSkuVal\":\"紫色\"},{\"Id\":8,\"ProductId\":473,\"AttrSkuId\":2,\"AttrSkuVal\":\"M\"},{\"Id\":9,\"ProductId\":473,\"AttrSkuId\":2,\"AttrSkuVal\":\"L\"}]";
                string resJson = Jnwf.Utils.Json.JsonHelper.SerializeJson(list);  
                Response.Write(resJson);
                Response.End();
            }
            else if (Request["cmd"] == "InsetProductSKU")  //批量插入
            {
                string json_productsku = Request["data"];
                json_productsku = System.Web.HttpUtility.UrlDecode(json_productsku);
                ProductSKUEntity a = new ProductSKUEntity();   

                List<ProductSKUEntity> list_productsku = Jnwf.Utils.Json.JsonHelper.DeserializeJsonReturnList<ProductSKUEntity>(json_productsku);
                int res=Weifenxiao.BLL.ProductSKUBLL.GetInstance().Insert(list_productsku);
                Response.Write(res);
                Response.End();
            }
            else if (Request["cmd"] == "UpdateProductSKU")  //批量更新
            {
                string json_productsku = Request["data"];
                json_productsku = System.Web.HttpUtility.UrlDecode(json_productsku);
                ProductSKUEntity a = new ProductSKUEntity();

                List<ProductSKUEntity> list_productsku = Jnwf.Utils.Json.JsonHelper.DeserializeJsonReturnList<ProductSKUEntity>(json_productsku);
                int res = Weifenxiao.BLL.ProductSKUBLL.GetInstance().Update(list_productsku);
                Response.Write(res);
                Response.End();
            }
            else if (Request["cmd"] == "GetProductSKUList")  //
            {
                object obj = Request["productid"];
                if (obj == null) return;
                int productid = 0;
                int.TryParse(obj.ToString(), out productid);
                IList<ProductSKUEntity> skulist = Weifenxiao.BLL.ProductSKUBLL.GetInstance().GetProductSKUList(productid);
                string resJson = Jnwf.Utils.Json.JsonHelper.SerializeJson(skulist);
                Response.Write(resJson);
                Response.End();
            }
            else if (Request["cmd"] == "GetAttrSKUList")
            {
                IList<Weifenxiao.Entity.AttrSKUEntity> list = Weifenxiao.BLL.AttrSKUBLL.GetInstance().GetAttrSKUList();

                string resJson = Jnwf.Utils.Json.JsonHelper.SerializeJson(list);
                Response.Write(resJson);
                Response.End();
            }

           
        }
      
        
    }
    
}