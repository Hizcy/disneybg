using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Tproduct_t_attrSkuEdit : System.Web.UI.Page
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
            if (Request["cmd"] == "GetAttrSKUList")
            {
                IList<Weifenxiao.Entity.T_AttrSKUEntity> list = Weifenxiao.BLL.T_AttrSKUBLL.GetInstance().GetAttrSKUList();

                string resJson = Jnwf.Utils.Json.JsonHelper.SerializeJson(list);
                Response.Write(resJson);
                Response.End();
            }
            else if (Request["cmd"] == "InsertAttrSKU")
            {
                string json_attrsku = Request["data"];
                json_attrsku = System.Web.HttpUtility.UrlDecode(json_attrsku);
                List<Weifenxiao.Entity.T_AttrValueSKUEntity> list_attrsku = Jnwf.Utils.Json.JsonHelper.DeserializeJsonReturnList<Weifenxiao.Entity.T_AttrValueSKUEntity>(json_attrsku);

                int res = Weifenxiao.BLL.T_AttrValueSKUBLL.GetInstance().Insert(list_attrsku);
                Response.Write(res);
                Response.End();
            }
            else if (Request["cmd"] == "GetTAttrValueSKUListByProcuctId")
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


        }


    }

}