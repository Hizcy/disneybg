using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class product_demo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string resJson = "[{\"ProductId\":473,\"AttrSkuId\":1,\"AttrSkuVal\":\"白色\"},{\"ProductId\":473,\"AttrSkuId\":1,\"AttrSkuVal\":\"黑色\"},{\"ProductId\":473,\"AttrSkuId\":2,\"AttrSkuVal\":\"M\"}]";
         List<Weifenxiao.Entity.AttrValueSKUEntity> list_attrsku = Jnwf.Utils.Json.JsonHelper.DeserializeJsonReturnList<Weifenxiao.Entity.AttrValueSKUEntity>(resJson);

         string s = "{\"ProductId\":\"473\",\"AttrValue\":\",1,4,\",\"Stock\":\"12\",\"ProductCode\":\"\",\"Images\":\"\"}";

         Weifenxiao.Entity.ProductSKUEntity o = Newtonsoft.Json.JsonConvert.DeserializeObject<Weifenxiao.Entity.ProductSKUEntity>(s);
         
    }
}