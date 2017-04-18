using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jnwf.Utils.Data;
using System.Net;

namespace GroupStatusUpdate
{
    public class GetUserHead
    {
        string getConnectionString = Jnwf.Utils.Config.ConfigurationUtil.GetConnectionString("weipingtai"); 
        string appid = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("appid");
        string secret = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("secret");
        tb_AccessTokenOperation accessTokenOperation  = new tb_AccessTokenOperation();
        tb_OpenID_UserOperation openidUser = new tb_OpenID_UserOperation();
        public DataSet GetOpenIdUser()
        {
            string sqlStr = "SELECT top 5 a.* FROM [weipingtai].[dbo].[tb_App_User] a left join [tb_OpenID_User] b on a.[OpenID] =b.[OpenID]  WHERE status=1 and weixincode='gh_f333134d3738' and [NickName] is null ";
            return  SqlHelper.ExecuteDataset(getConnectionString,CommandType.Text,sqlStr);
        }
        public void SetUserData()
        {
            try
            {                
                DataSet ds = GetOpenIdUser();
                if(ds != null && ds.Tables.Count>0 && ds.Tables[0] != null && ds.Tables[0].Rows.Count >0)
                {
                    foreach(DataRow dr in ds.Tables[0].Rows)
                    {
                        string token = ""; 
                        tb_AccessTokenEntity a = accessTokenOperation.GetModel(dr["weixincode"].ToString());
                        if (a != null)
                        {
                            if (a.AddTime.AddHours(1) <= DateTime.Now)
                            {
                                //tb_UserEntity user = Jnwf.BLL.tb_UserBLL.GetInstance().GetModelByWeiXin(a.WeiXinCode);
                                token = GetAccessToken(appid, secret); 
                                a.AccessToken = token;
                                a.AddTime = DateTime.Now; 
                                accessTokenOperation.Update(a);
                            }
                            else
                            {
                                token = a.AccessToken;
                            }
                            tb_OpenID_UserEntity entity = GetUserInfo(token, dr["openid"].ToString());
                            if (entity != null && entity.OpenID.Length > 0)
                                openidUser.Insert(entity);
                        }
                    } 
                } 
            }
            catch (Exception ex)
            {
                //Jnwf.Utils.Log.Logger.Log4Net.Error("center.aspx,ex:" + ex.Message + "|" + ex.StackTrace);
            }
        }
        public string GetAccessToken(string m_appid, string m_secret)
        {
            string m_AcessTokenUrl = "https://api.weixin.qq.com/cgi-bin/token?grant_type=client_credential";

            WebClient webClient = new WebClient();

            Byte[] bytes = webClient.DownloadData(string.Format("{0}&appid={1}&secret={2}", m_AcessTokenUrl, m_appid, m_secret));
            string result = Encoding.GetEncoding("utf-8").GetString(bytes);
            string[] temp = result.Split(',');
            string[] tp = temp[0].Split(':');
            return tp[1].ToString().Replace('"', ' ').Trim().ToString();
        }
        public tb_OpenID_UserEntity GetUserInfo(string token, string openid)
        {
            tb_OpenID_UserEntity model = null;
            string url = "https://api.weixin.qq.com/cgi-bin/user/info?access_token=" + token + "&openid=" + openid + "&lang=zh_CN";

            WebClient webClient = new WebClient();
            Byte[] bytes = webClient.DownloadData(url);
            string json = Encoding.GetEncoding("utf-8").GetString(bytes);
            if (json.IndexOf("errcode") > 0)
            {

            }
            else
            {
                model = Jnwf.Utils.Json.JsonHelper.DeserializeJson<tb_OpenID_UserEntity>(json);
            }
            return model;
        }
    }
}
