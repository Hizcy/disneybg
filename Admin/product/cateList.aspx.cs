using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
public partial class product_cateList : System.Web.UI.Page
{
    public int shopid = 0;
   
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindData();
        }
    }
    public System.Text.StringBuilder att = new StringBuilder();
    private void BindData()
    {

        UserIdentity identity = User.Identity as UserIdentity;
        shopid = identity.ShopID;
        //if (identity != null)
        //{
        //    IList<Weifenxiao.Entity.ProductClsEntity> list = Weifenxiao.BLL.ProductClsBLL.GetInstance().GetListByShopId(identity.ShopID);
        //    rptResultsList.DataSource = list;
        //    rptResultsList.DataBind();

        //}
        IList<Weifenxiao.Entity.ProductClsEntity> list = Weifenxiao.BLL.ProductClsBLL.GetInstance().Get_ProductClsListAll(identity.ShopID);
        if (list.Count > 0 && list != null)
        {
            foreach (Weifenxiao.Entity.ProductClsEntity model in list)
            {
                att.Append("<li style=\"padding: 10px;border-bottom: 1px #d2d2d2 dashed;\">" + model.Clsname + "");
                att.Append("<span onclick=\"addcate(" + model.ClsId + ")\" class=\"opeart_btn\">添加二级分类</span>");
                att.Append("<a href=\"/product/cateEdit.aspx?cid=" + model.ClsId + "\" class=\"opeart_btn\" >编辑</a>");
                att.Append("<span onclick=\"fnDel(" + model.ClsId + ")\" class=\"opeart_btn\">删除</span> ");
                att.Append("</li>");
                IList<Weifenxiao.Entity.ProductClsEntity> tlist = Weifenxiao.BLL.ProductClsBLL.GetInstance().GetListByParentId(model.ClsId, identity.ShopID);
                foreach (Weifenxiao.Entity.ProductClsEntity tmodel in tlist)
                {
                    att.Append("<li style=\"margin-left:40px;padding: 10px;border-bottom: 1px #d2d2d2 dashed;\">" + tmodel.Clsname + "");
                    att.Append("<span onclick=\"xiugai(" + tmodel.ClsId + "," + tmodel.ParentId + ")\" class=\"opeart_btn\">编辑</span>");
                    att.Append("<span onclick=\"fnDel(" + tmodel.ClsId + ")\" class=\"opeart_btn\" >删除</span>");
                    att.Append("</li>");
                }
            }
        }
       


    }

}