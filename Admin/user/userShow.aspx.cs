using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Weifenxiao.BLL;

public partial class user_Default : System.Web.UI.Page
{
    public int uid
    {
        get
        {
            object obj = Request.QueryString["uid"];
            if (obj == null)
                return 0;
            int m = 0;
            int.TryParse(obj.ToString(),out m);
            return m;
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (uid != 0)
            {
              //用户信息赋值
               Weifenxiao.Entity.wx_UserExtEntity model = Weifenxiao.BLL.wx_UsersBLL.GetInstance().GetExtModelByUserId(uid);
              //Weifenxiao.Entity.wx_UsersEntity test = Weifenxiao.BLL.wx_UsersBLL.GetInstance().GetAdminSingle(uid);
              if (model == null) { return; }
               if (model.ParentId == 0)
               {
                   lbUperdaili.Text = "无";
               }
               else
               { 
                    Weifenxiao.Entity.wx_UsersEntity pmodel = Weifenxiao.BLL.wx_UsersBLL.GetInstance().GetAdminSingle(model.ParentId);
                    lbUperdaili.Text = pmodel.RealName;
               }
               lbNickname.Text = model.NickName;
               imgAvatar.ImageUrl = model.HeadImgurl; 
               lbRealname.Text = model.RealName;
               lbOpenid.Text = model.OpenId;
               lbAddtime.Text = model.AddTime.ToString();
               lbPhone.Text = model.Phone;
               lbWeixinhao.Text = model.Weixin;
              //基础业绩赋值
               lbYeji.Text = model.yeji.ToString();
               lbYongjin.Text = model.yongjin.ToString();
               lbTixian.Text = model.tixian.ToString(); 
               
                //下级代理赋值
               lbYijidaili.Text=  model.yijidaili.ToString();
               lbErjidaili.Text = model.erjidaili.ToString();
            }
        }
    }
}