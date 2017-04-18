using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class data_data : BasePage//System.Web.UI.Page
{
    public string type
    {
        get
        {
            object obj = Request.Form["type"];
            if (obj == null)
            {
                return "";
            }
            return obj.ToString();
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            switch (type)
            {
                case "AddAttributeone"://添加属性类别
                    AddAttributeone(int.Parse(Request.Form["id"].ToString()), Request.Form["txtattkey"].ToString(), Request.Form["txtattvalue"].ToString());
                    break;
                case "deleteAttribute":
                    deleteAttribute(int.Parse(Request.Form["id"].ToString()));
                    break;
                case "getAttribute":
                    getAttribute(int.Parse(Request.Form["id"].ToString()));
                    break;
                case "updateAttributeone":
                    updateAttributeone(int.Parse(Request.Form["id"].ToString()), Request.Form["txtattkey"].ToString(), Request.Form["txtattvalue"].ToString());
                    break;
                case "zutuanTuikuan":
                    zutuanTuikuan(Request.Form["ordercode"].ToString(), Request.Form["total_fee"].ToString(), Request.Form["refund_fee"].ToString());
                    break;
                case "AddCateList"://添加二级分类
                    AddCateList(int.Parse(Request.Form["parentid"].ToString()), Request.Form["txtName"].ToString(), Request.Form["txtIntro"].ToString(), int.Parse(Request.Form["txtOrderby"].ToString()));
                    break;
                case "getCateList":
                    getCateList(int.Parse(Request.Form["cid"].ToString()));
                    break;
                case "updateCateList"://修改二级分类
                    updateCateList(int.Parse(Request.Form["clsid"].ToString()), int.Parse(Request.Form["parentid"].ToString()), Request.Form["txtName"].ToString(), Request.Form["txtIntro"].ToString(), int.Parse(Request.Form["txtOrderby"].ToString()));
                    break;
                case "select"://分类联动查询
                    select(int.Parse(Request.Form["parentid"].ToString()));
                    break;
                case "updateImg"://轮播图
                    updateImg(Request.Form["imgUrl"].ToString(), Convert.ToInt32(Request.Form["clsid"]), Request.Form["linkurl"], Request.Form["imgUrl2"], Request.Form["imgUrl3"], Request.Form["linkUrl2"], Request.Form["linkUrl3"]);
                    break;
                case "showdata":
                    showdata(Convert.ToInt32(Request.Form["clsid"]));
                    break;
            }
        }
    }
    public void showdata(int clsId)
    {
        Weifenxiao.Entity.ShufflingImgEntity model = Weifenxiao.BLL.ShufflingImgBLL.GetInstance().Get_ShufflingImgEntity(clsId);
        string json = String.Empty;
        if (model != null)
        {
            json = "{\"MessageBox\":\"查询数据成功\",\"imgurl\":\"" + model.ImgUrl + "\",\"imgurl2\":\"" + model.ImgUrl2 + "\",\"imgurl3\":\"" + model.ImgUrl3 + "\",\"linkurl\":\"" + model.LinkUrl + "\",\"linkurl2\":\"" + model.LinkUrl2 + "\",\"linkurl3\":\"" + model.LinkUrl3 + "\"}";
        }
        else
        {
            json = "{\"MessageBox\":\"未查找到数据\"}";
        }
        Response.Write(Jnwf.Utils.Json.JsonHelper.SerializeJson(json));

    }
    public void updateImg(string imgUrl, int clsId, string linkurl, string imgUrl2, string imgUrl3, string linkUrl2, string linkUrl3)
    {
        try
        {
            Weifenxiao.Entity.ShufflingImgEntity model = Weifenxiao.BLL.ShufflingImgBLL.GetInstance().Get_ShufflingImgEntity(clsId);
            if (model != null)
            {
                model.ImgUrl = SqlInject(imgUrl);
                model.Updatetime = DateTime.Now;
                model.LinkUrl = SqlInject(linkurl);
                model.LinkUrl2 = SqlInject(linkUrl2);
                model.LinkUrl3 = SqlInject(linkUrl3);
                model.ImgUrl2 = SqlInject(imgUrl2);
                model.ImgUrl3 = SqlInject(imgUrl3);
                int i = Weifenxiao.BLL.ShufflingImgBLL.GetInstance().Update(model);
                if (i > 0)
                {
                    Response.Write(1);
                }
            }
            else
            {
                Weifenxiao.Entity.ShufflingImgEntity tmodel = new Weifenxiao.Entity.ShufflingImgEntity();
                tmodel.ImgUrl = SqlInject(imgUrl);
                tmodel.ClsId = clsId;
                tmodel.Addtime = DateTime.Now;
                tmodel.Updatetime = DateTime.Now;
                tmodel.LinkUrl = SqlInject(linkurl);
                tmodel.LinkUrl2 = SqlInject(linkUrl2);
                tmodel.LinkUrl3 = SqlInject(linkUrl3);
                tmodel.ImgUrl2 = SqlInject(imgUrl2);
                tmodel.ImgUrl3 = SqlInject(imgUrl3);
                int i = Weifenxiao.BLL.ShufflingImgBLL.GetInstance().Insert(tmodel);
                if (i > 0)
                {
                    Response.Write(1);
                }
            }
        }
        catch (Exception ex)
        {
            Response.Write(-1);
        }

    }
    //分类联动查询
    public void select(int parentid)
    {
        System.Text.StringBuilder sbr = new System.Text.StringBuilder();
        UserIdentity identity = User.Identity as UserIdentity;
        if (parentid != 0)
        {
            //sbr.Append("<option Value=\"0\">全部</option>");
            IList<Weifenxiao.Entity.ProductClsEntity> list = Weifenxiao.BLL.ProductClsBLL.GetInstance().GetListByParentId(parentid, identity.ShopID);
            if (list != null && list.Count > 0)
            { 
                foreach (Weifenxiao.Entity.ProductClsEntity model in list)
                {
                    sbr.Append("<option Value=\"" + model.ClsId + "\">" + model.Clsname + "</option>");
                }
            }
            else
            {
                sbr.Append("<option Value=\"-2\">没有二级分类</option>");
            }
            Response.Write(sbr.ToString());
        }
        else
        {
            Response.Write("<option Value=\"0\">--请选择--</option>");

        }
    }
    public void zutuanTuikuan(string ordercode, string total_fee, string refund_fee)
    {
        try
        {
            string result = Refund.Run(ordercode,"", total_fee, refund_fee);
            Response.Write( result );
        }
        catch (WxPayException ex)
        {
            Response.Write( ex.ToString() );
        }
        catch (Exception ex)
        {
            Response.Write( ex.ToString() );
        }
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="id"></param>
    /// <param name="txtattkey"></param>
    /// <param name="txtattvalue"></param>
    public void AddAttributeone(int id, string txtattkey, string txtattvalue)
    {
        try
        {
            Weifenxiao.Entity.wx_ConfigEntity model = new Weifenxiao.Entity.wx_ConfigEntity();
            model.Name = "";
            model.PropertyId = id;
            model.PropertyKey = txtattkey;
            model.PropertyValue = txtattvalue;
            model.Status = 1;
            model.Addtime = DateTime.Now;
            model.Uptatetime = DateTime.Now;
            Weifenxiao.BLL.wx_ConfigBLL.GetInstance().Insert(model);
            Jnwf.Utils.Helper.HttpHelper.LoadPageContent("http://m.disneybg.com/clear.aspx?type=config&shopid=" + id);
            Response.Write(1);
        }
        catch (Exception ex)
        {
            Response.Write(2);
        }
    }
    public void updateAttributeone(int id, string txtattkey, string txtattvalue)
    {
        try
        {
            Weifenxiao.Entity.wx_ConfigEntity model = Weifenxiao.BLL.wx_ConfigBLL.GetInstance().GetAdminSingle(id);
            model.PropertyKey = txtattkey;
            model.PropertyValue = txtattvalue;
            model.Uptatetime = DateTime.Now;
            Weifenxiao.BLL.wx_ConfigBLL.GetInstance().Update(model);
            Jnwf.Utils.Helper.HttpHelper.LoadPageContent("http://m.disneybg.com/clear.aspx?type=config&shopid=" + id);
            Response.Write(1);
        }
        catch (Exception ex)
        {
            Response.Write(2);
        }
    }
    public void getAttribute(int id)
    {
        try
        {
            Weifenxiao.Entity.wx_ConfigEntity model = Weifenxiao.BLL.wx_ConfigBLL.GetInstance().GetAdminSingle(id);

            Response.Write(Jnwf.Utils.Json.JsonHelper.SerializeJson(model));
        }
        catch (Exception ex)
        {
            Response.Write(2);
        }
    }
    public void deleteAttribute(int id)
    {
        try
        {
            Weifenxiao.Entity.wx_ConfigEntity model = Weifenxiao.BLL.wx_ConfigBLL.GetInstance().GetAdminSingle(id);
            model.Status = 0;
            model.Uptatetime = DateTime.Now;
            Weifenxiao.BLL.wx_ConfigBLL.GetInstance().Update(model);
            Jnwf.Utils.Helper.HttpHelper.LoadPageContent("http://m.disneybg.com/clear.aspx?type=config&shopid=" + model.PropertyId);
            Response.Write(1);
        }
        catch (Exception ex)
        {
            Response.Write(2);
        }
    }
  
    //添加二级分类
    public void AddCateList(int parentid, string txtName, string txtIntro, int txtOrderby)
    {
        UserIdentity identity = User.Identity as UserIdentity;
        try
        {
            bool b = Weifenxiao.BLL.ProductClsBLL.GetInstance().GetParentId(parentid,identity.ShopID);
            if (!b)
            {
                Response.Write(3);
            }
            else
            {
                Weifenxiao.Entity.ProductClsEntity model = new Weifenxiao.Entity.ProductClsEntity();
                model.ShopId = identity.ShopID;
                model.Clsname = txtName;
                model.ParentId = parentid;
                model.Description = txtIntro;
                model.orderby = txtOrderby;
                model.Status = 1;
                model.Addtime = DateTime.Now;
                model.Updatetime = DateTime.Now;
                Weifenxiao.BLL.ProductClsBLL.GetInstance().Insert(model);
                Jnwf.Utils.Helper.HttpHelper.LoadPageContent("http://m.disneybg.com/clear.aspx?type=config&shopid=" + identity.ShopID);
                Response.Write(1);
            }
        
        }
        catch (Exception ex)
        {
            Response.Write(2);
        }
    }

    public void getCateList(int cid)
    {
        try
        {
            Weifenxiao.Entity.ProductClsEntity model = Weifenxiao.BLL.ProductClsBLL.GetInstance().GetAdminSingle(cid);

            Response.Write(Jnwf.Utils.Json.JsonHelper.SerializeJson(model));
        }
        catch (Exception ex)
        {
            Response.Write(2);
        }
    }
    
    /// <summary>
    /// 编辑二级分类
    /// </summary>
    /// <param name="clsid"></param>
    /// <param name="parentid"></param>
    /// <param name="txtName"></param>
    /// <param name="txtIntro"></param>
    /// <param name="txtOrderby"></param>
    public void updateCateList(int clsid,int parentid, string txtName, string txtIntro, int txtOrderby)
    {
        try
        {
            Weifenxiao.Entity.ProductClsEntity model = Weifenxiao.BLL.ProductClsBLL.GetInstance().GetAdminSingle(clsid);
            model.ParentId = parentid;
            model.Clsname = txtName;
            model.Description = txtIntro;
            model.orderby = txtOrderby;
            model.Updatetime = DateTime.Now;
            Weifenxiao.BLL.ProductClsBLL.GetInstance().Update(model);
            //Jnwf.Utils.Helper.HttpHelper.LoadPageContent("http://m.disneybg.com/clear.aspx?type=config&shopid=" + parentid);
            Response.Write(1);
        }
        catch (Exception ex)
        {
            Response.Write(2);
        }
    }
}