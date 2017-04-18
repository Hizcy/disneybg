using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class product_cateEdit : System.Web.UI.Page
{
    public int categoryId
    {
        get
        {
            object obj = Request.QueryString["cid"];
            if (obj == null)
                return 0;
            int m = 0;
            int.TryParse(obj.ToString(), out m);
            return m;
        }
    }
    public int shopid = 0;
    public string strImgs = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            UserIdentity identity = User.Identity as UserIdentity;
            shopid = identity.ShopID;

            IList<Weifenxiao.Entity.ProductClsEntity> ProductClsList = Weifenxiao.BLL.ProductClsBLL.GetInstance().GetListByShopId(identity.ShopID);

            ddl_Category.DataSource = ProductClsList;

            ddl_Category.DataTextField = "Clsname";
            ddl_Category.DataValueField = "ClsId";
            ddl_Category.DataBind();

            ListItem list = new ListItem("--暂无父类--", "-1");
            ddl_Category.Items.Insert(0, list);
            ddl_Category.SelectedIndex = 0;

            if (categoryId != 0)
            {
                Weifenxiao.Entity.ProductClsEntity model = Weifenxiao.BLL.ProductClsBLL.GetInstance().GetAdminSingle(categoryId);
                txtIntro.Value = model.Description;
                txtOrderby.Value = model.orderby.ToString();
                txtName.Value = model.Clsname.ToString();
                if (model.Image != "")
                {
                    strImgs = strImgs + "<div class=\"uploadImgitem\"><img src=\"" + model.Image + "\" /><span onclick=\"fnDelImg(this)\">删除</span></div>";
                }


            }
        }
    }

    protected void btn_Submit_Click(object sender, EventArgs e)
    {
        Weifenxiao.Entity.ProductClsEntity model =  new Weifenxiao.Entity.ProductClsEntity();
        if (categoryId != 0)
        {
            model = Weifenxiao.BLL.ProductClsBLL.GetInstance().GetAdminSingle(categoryId);
            model.Updatetime = DateTime.Now;
        }
        else {
            UserIdentity identity = User.Identity as UserIdentity;
            model.ShopId = identity.ShopID;

            model.Addtime = DateTime.Now;
            model.Updatetime = DateTime.Now;
            model.Status = 1;
        }
        model.Clsname = txtName.Value;
        model.Description = txtIntro.Value;
        model.orderby = Convert.ToInt16(txtOrderby.Value);
        string[] imgs = (txt_img.Value.ToString()).Split(',');
        if (imgs.Length > 0)
        {
            model.Image = imgs[0];

        }
        else {
            model.Image = "";
        }
        if (categoryId != 0)
        {
            Weifenxiao.BLL.ProductClsBLL.GetInstance().Update(model);
        }
        else {
            Weifenxiao.BLL.ProductClsBLL.GetInstance().Insert(model);
        }
        Response.Redirect("/product/cateList.aspx");

    }
}