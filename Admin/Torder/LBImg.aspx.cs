using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Torder_Default : System.Web.UI.Page
{
    public string imgUrl = String.Empty;
    public string linkUrl = String.Empty;
    public string imgUrl2 = String.Empty;
    public string linkUrl2 = String.Empty;
    public string imgUrl3 = String.Empty;
    public string linkUrl3 = String.Empty;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Weifenxiao.Entity.ShufflingImgEntity model = Weifenxiao.BLL.ShufflingImgBLL.GetInstance().Get_ShufflingImgEntity(0);
            if (model != null)
            {
                imgUrl = model.ImgUrl;
                linkUrl = model.LinkUrl;
                imgUrl2 = model.ImgUrl2;
                imgUrl3 = model.ImgUrl3;
                linkUrl2 = model.LinkUrl2;
                linkUrl3 = model.LinkUrl3;
            }
            UserIdentity identity = User.Identity as UserIdentity; 
            if (identity != null)
            {
                List<Weifenxiao.Entity.ProductClsEntity> list = Weifenxiao.BLL.ProductClsBLL.GetInstance().Get_ProductClsListAll(identity.ShopID) as List<Weifenxiao.Entity.ProductClsEntity>;
                if (list != null && list.Count > 0)
                {
                    dropimgclslist.DataSource = list;
                    dropimgclslist.DataTextField = "CLSNAME";
                    dropimgclslist.DataValueField = "CLSID";
                    dropimgclslist.DataBind();
                    ListItem lt = new ListItem("--首页--", "0");
                    dropimgclslist.Items.Insert(0, lt);
                }
            }

        }
    }
}