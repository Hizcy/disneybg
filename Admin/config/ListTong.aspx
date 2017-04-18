<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ListTong.aspx.cs" Inherits="config_ListTong" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="header" Runat="Server">
       <title>审核通过列表</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" Runat="Server">
     <div class="page_title">

         <ul class="admin_tab">
                <li><a class="<%=(type == 0 ? "active" : "") %>" href="tixianList.aspx"style="color: #090909; font-weight: bolder;">提现审核</a></li>
                <li><a class="<%=(type == 1 ? "active" : "") %>" href="ListTong.aspx?type=1"style="color: #090909; font-weight: bolder;">审核通过列表</a></li>
        
            </ul>
    </div>
        <section> 
                <table class="table">
                    <tr>
                        <th style="width: 49%; text-align: center">申信息</th>
                        <th style="width: 17%; text-align: center">提现金额</th>
                        <th style="width: 17%; text-align: center">申请时间</th>
                        <th style="width: 17%; text-align: center">审核状态</th>
                    </tr>
                    <asp:Repeater ID="rptResultsList" runat="server">
                        <ItemTemplate>
                            <tr>
                                <td style="line-height: 30px; text-align: center; width: 49%">
                                    <span style="float: left; margin-left: 10px;color:red;">体现人：<a href="../user/agency.aspx?id=<%#Eval("userid") %>" style="color:red"><%#Eval("RealName") %>（<%#Eval("nickname") %>）</a></span><br />
                                    <span style="float: left; margin-left: 10px">开户人：<%#Eval("realname") %></span><br />
                                    <span style="float: left; margin-left: 10px">开户行：<%#Eval("address")%></span><br />
                                    <span style="float: left; margin-left: 10px">卡&nbsp;&nbsp;&nbsp;号：<%#Eval("cardnumber") %></span></td>
                                <td style="line-height: 30px; text-align: center; width: 17%">
                                    <%#Eval("money") %>
                                </td>
                                <td style="line-height: 30px; text-align: center; width: 17%">
                                    <%# Eval("AddTime").ToString() %> 
                                </td>
                                <td style="line-height: 30px; text-align: center; width: 17%">
                                 已通过
                                </td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </table> 
        <aside class="paging">
            <div class="das_pages">
                <webdiyer:AspNetPager ID="pager1" CssClass="paginator" CurrentPageButtonClass="cpb" runat="server" AlwaysShow="True"
                    FirstPageText="首页" LastPageText="尾页" NextPageText="下一页" PageSize="15" PrevPageText="上一页"
                    ShowInputBox="Never" OnPageChanged="AspNetPager1_PageChanged" CustomInfoTextAlign="Left">
                </webdiyer:AspNetPager>
            </div>
        </aside>
    </section>
        <script type="text/javascript">

            function pass(applyid, obj) {

                $.getJSON("/data/tixian.ashx?type=pass&applyid=" + applyid,
                 function (msg) {
                     if (msg.result == "ok") {
                         fnShowMsg("通过申请！");
                         $(obj).parent().parent().remove();
                     }
                 });
            }

    </script>
</asp:Content>

