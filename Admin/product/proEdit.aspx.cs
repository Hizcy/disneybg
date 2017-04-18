using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Weifenxiao.BLL;
using Weifenxiao.Entity;

public partial class product_Default : System.Web.UI.Page
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
    public int shopid = 0;
    public string strImgs = "";
    public string htmlIntro = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            UserIdentity identity = User.Identity as UserIdentity;
            shopid = identity.ShopID;

            IList<Weifenxiao.Entity.ProductClsEntity> ProductClsList = Weifenxiao.BLL.ProductClsBLL.GetInstance().Get_ProductClsListAll(identity.ShopID);

            ddl_Category.DataSource = ProductClsList;

            ddl_Category.DataTextField = "Clsname";
            ddl_Category.DataValueField = "ClsId";
            ddl_Category.DataBind();

            ListItem list = new ListItem("--请选择--", "-1");
            ddl_Category.Items.Insert(0, list);
            ddl_Category.SelectedIndex = 0;

            if (productId != 0)
            {

                Weifenxiao.Entity.ProductsEntity model = Weifenxiao.BLL.ProductsBLL.GetInstance().GetAdminSingle(productId);
                txtName.Value = model.Name;
                txtCostPrize.Value = model.CostPrice.ToString();
                txtPrize.Value = model.SalePrice.ToString();
                txtOriginPrice.Value = model.OriginPrice.ToString();
                hidden_isCommission.Value = model.IsCommission.ToString();
                txtCommission.Value = model.Commission.ToString();
                txtOrderby.Value = model.OrderBy.ToString();
                txtStock.Value = model.Stock.ToString();
                ddl_Category.SelectedValue = model.CategoryId.ToString();
                this.selectcity.Text = model.CategoryId.ToString();
                this.selecteurozone.Text = model.CategoryId2.ToString();

           

                if (model.Image1 != "")
                {
                    strImgs = strImgs + "<div class=\"uploadImgitem\"><img src=\"" + model.Image1 + "\" /><span onclick=\"fnDelImg(this)\">删除</span></div>";
                }
                if (model.Image2 != "")
                {
                    strImgs = strImgs + "<div class=\"uploadImgitem\"><img src=\"" + model.Image2 + "\" /><span onclick=\"fnDelImg(this)\">删除</span></div>";
                }
                if (model.Image3 != "")
                {
                    strImgs = strImgs + "<div class=\"uploadImgitem\"><img src=\"" + model.Image3 + "\" /><span onclick=\"fnDelImg(this)\">删除</span></div>";
                } if (model.Image4 != "")
                {
                    strImgs = strImgs + "<div class=\"uploadImgitem\"><img src=\"" + model.Image4 + "\" /><span onclick=\"fnDelImg(this)\">删除</span></div>";
                } if (model.Image5 != "")
                {
                    strImgs = strImgs + "<div class=\"uploadImgitem\"><img src=\"" + model.Image5 + "\" /><span onclick=\"fnDelImg(this)\">删除</span></div>";
                }


                this.RadioButtonList1.SelectedValue = model.Status.ToString();

                txtIntro.Text = model.Intro;

                htmlIntro = model.Description;

                this.RadioButtonList2.SelectedValue = model.IsNew.ToString();
                this.RadioButtonList3.SelectedValue = model.IsHot.ToString();
            }
            else
            {
                this.RadioButtonList1.SelectedIndex = 0;
                this.RadioButtonList2.SelectedIndex = 0;
                this.RadioButtonList3.SelectedIndex = 0;
            }
        }
    }
    protected void btn_Submit_Click(object sender, EventArgs e)
    {
        try
        {

            Weifenxiao.Entity.ProductsEntity model = new ProductsEntity();

            if (productId != 0)
            {
                model = Weifenxiao.BLL.ProductsBLL.GetInstance().GetAdminSingle(productId);
                model.ProductId = productId;
                model.UpdateTime = DateTime.Now;

            }
            else
            {
                model.AddTime = DateTime.Now;
            }

            UserIdentity identity = User.Identity as UserIdentity;
            model.ShopId = identity.ShopID;

            model.Name = txtName.Value;
            model.CostPrice = Convert.ToDecimal(txtCostPrize.Value);
            model.SalePrice = Convert.ToDecimal(txtPrize.Value);
            model.OriginPrice = Convert.ToDecimal(txtOriginPrice.Value);
            model.IsCommission = Convert.ToInt32(hidden_isCommission.Value.ToString());
            model.Commission = Convert.ToDecimal(txtCommission.Value);
            model.OrderBy = Convert.ToInt32(txtOrderby.Value);
            model.CategoryId = Convert.ToInt32(ddl_Category.SelectedValue);
            model.CategoryId2 = Convert.ToInt32(selecteurozone.Text.Trim());
            model.Intro = txtIntro.Text.ToString();
            model.Status = Convert.ToInt32(RadioButtonList1.SelectedValue);
            model.Description = html_ue.Value;
            model.Stock = Convert.ToInt32(txtStock.Value);
            //-----------------------------------------------------
            model.IsNew = Convert.ToInt32(RadioButtonList2.SelectedValue);
            model.IsHot = Convert.ToInt32(RadioButtonList3.SelectedValue);
            //-----------------------------------------------------
            model.UpdateTime = DateTime.Now;

            string[] imgs = (txt_img.Value.ToString()).Split(',');
            if (imgs.Length > 0)
            {
                model.Image1 = imgs[0];
            }
            else { model.Image1 = null; }
            if (imgs.Length > 1)
            {
                model.Image2 = imgs[1];
            }
            else { model.Image2 = null; }
            if (imgs.Length > 2)
            {
                model.Image3 = imgs[2];
            }
            else { model.Image3 = null; }
            if (imgs.Length > 3)
            {
                model.Image4 = imgs[3];
            }
            else { model.Image4 = null; } if (imgs.Length > 4)
            {
                model.Image5 = imgs[4];
            }
            else { model.Image5 = null; }

            Weifenxiao.BLL.ProductsBLL bll = new ProductsBLL();
            if (productId != 0)
            {
                bll.Update(model);
            }
            else
            {
                bll.Insert(model);
            }
            Jnwf.Utils.Helper.HttpHelper.LoadPageContent("http://m.disneybg.com/clear.aspx?type=product&shopid=" + identity.ShopID);
        }
        catch (Exception ex)
        {
            Jnwf.Utils.Log.Logger.Log4Net.Error("proedit.aspx,ex:" + ex.Message + "|" + ex.StackTrace);
        }
        finally
        {
            Response.Redirect("/product/proList.aspx");
        }
        
    }
    protected void selectcity_Load(object sender, EventArgs e)
    {
        UserIdentity identity = User.Identity as UserIdentity;
        if (!string.IsNullOrEmpty(selectcity.Text))
        {
            IList<Weifenxiao.Entity.ProductClsEntity> list = Weifenxiao.BLL.ProductClsBLL.GetInstance().GetListByParentId(int.Parse(selectcity.Text), identity.ShopID);
            if (list != null && list.Count > 0)
            {
                ProductClsEntity model = new ProductClsEntity();
                ddl_produclsid.DataSource = list;
                ddl_produclsid.DataTextField = "Clsname";
                ddl_produclsid.DataValueField = "ClsId";
                ddl_produclsid.DataBind();
                for (int i = 0; i < ddl_produclsid.Items.Count; i++)
                {
                    if (ddl_produclsid.Items[i].Value == selecteurozone.Text)
                    {
                        ddl_produclsid.Items[i].Selected = true;
                    }
                }
            }
        }
    }

}

        