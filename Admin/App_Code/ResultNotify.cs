using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


    /// <summary>
    /// 支付结果通知回调处理类
    /// 负责接收微信支付后台发送的支付结果并对订单有效性进行验证，将验证结果反馈给微信支付后台
    /// </summary>
    public class ResultNotify:Notify
    {
        public ResultNotify(Page page):base(page)
        {
        }

        public override void ProcessNotify()
        {
            WxPayData notifyData = GetNotifyData();

            //检查支付结果中transaction_id是否存在
            if (!notifyData.IsSet("transaction_id"))
            {
                //若transaction_id不存在，则立即返回结果给微信支付后台
                WxPayData res = new WxPayData();
                res.SetValue("return_code", "FAIL");
                res.SetValue("return_msg", "支付结果中微信订单号不存在");
                Log.Error(this.GetType().ToString(), "The Pay result is error : " + res.ToXml());
                page.Response.Write(res.ToXml());
                page.Response.End();
            }

            string transaction_id = notifyData.GetValue("transaction_id").ToString();

            //查询订单，判断订单真实性
            if (!QueryOrder(transaction_id))
            {
                //若订单查询失败，则立即返回结果给微信支付后台
                WxPayData res = new WxPayData();
                res.SetValue("return_code", "FAIL");
                res.SetValue("return_msg", "订单查询失败");
                Log.Error(this.GetType().ToString(), "Order query failure : " + res.ToXml());
                page.Response.Write(res.ToXml());
                page.Response.End();
            }
            //查询订单成功
            else
            {
                WxPayData res = new WxPayData();
                res.SetValue("return_code", "SUCCESS");
                res.SetValue("return_msg", "OK");
                Log.Info(this.GetType().ToString(), "order query success : " + res.ToXml());
                page.Response.Write(res.ToXml());
                page.Response.End();
            }
        }

        //查询订单
        private bool QueryOrder(string transaction_id)
        {
            WxPayData req = new WxPayData();
            req.SetValue("transaction_id", transaction_id);
            WxPayData res = WxPayApi.OrderQuery(req);
            if (res.GetValue("return_code").ToString() == "SUCCESS" &&
                res.GetValue("result_code").ToString() == "SUCCESS")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string GetToken()
        {
            string token = "";
            string appid = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("appid");
            string secret = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("secret");
            string weixincode = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("weixincode");
            Jnwf.Model.tb_AccessTokenEntity temp = Jnwf.BLL.tb_AccessTokenBLL.GetInstance().GetModel(weixincode);
            if (temp != null)
            {
                if (temp.AddTime.AddHours(1) <= DateTime.Now)
                {
                    token = GetAccessToken(appid, secret);
                    temp.AccessToken = token;
                    temp.AddTime = DateTime.Now;

                    Jnwf.BLL.tb_AccessTokenBLL.GetInstance().Update(temp);
                }
                else
                {
                    token = temp.AccessToken;
                }
            }
            return token;
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
    }
