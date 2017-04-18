<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Agency.aspx.cs" Inherits="user_Agency" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="header" Runat="Server">
   
    <style>
          .div_1 {
            border:1px solid #e5e5e5
        }
          .div_1 .pp1{
           font-family:"微软雅黑";
           font-weight:600;
           padding:10px;
        }
          .table_1 {
            width:100%;
        }
          .table_1 .tr1 td {
            border: 1px #d2d2d2 solid;
            height: 40px;
            line-height: 40px;
        }
          .table_1 .tr2 td {
            border: 1px #d2d2d2 solid;
            height: 40px;
            line-height: 40px;
            text-align:left;
            padding: 0 20px;
        }
           .table_1 .tr3 td {
            height: 40px;
            line-height: 40px;
        }
          .table_1 .tr2 .tr2_p1 {
            margin:5px;
        }
          .table_1 .tr2 td  img{
            padding: 5px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" Runat="Server">
    <aside class="paging">
        <div class="das_pages">
            <div class="div_1">
                <div style="padding: 10px;background-color:#e5e5e5">
                    <p class="pp1">用户信息</p>
                    <table class="table_1">
                        <tbody>
                            <tr class="tr1" style="background: #f8f8f8;">
                                <td>姓名</td>
                                <td>电话</td>
                                <td>微信昵称</td>
                                <td>微信号</td>
                                <td>添加时间</td>
                                <td>上级代理</td>
                            </tr>
                        </tbody>
                        <tr class="tr2" style="background: #fff;">
                            <td><%=name %></td>
                            <td><%=phone %></td>
                            <td><%=nick %></td>
                            <td><%=weixin %></td>
                            <td><%=addtime %></td>
                            <td style="color:#1faae0"><%=parent %></td>
                        </tr>
                    </table>
                    <p class="pp1">业绩信息</p>
                    <table class="table_1">
                        <tbody>
                            <tr class="tr1" style="background: #f8f8f8;">
                                <td>姓名</td>
                                <td>推广数量</td>
                                <td>销售金额</td>
                                <td>佣金金额</td>
                                <td>已提现金额</td>
                            </tr>
                        </tbody>
                        <tr class="tr2" style="background: #fff;">
                            <td><%=name %></td>
                            <td><%=yijidaili %></td>
                            <td><%=yeji %></td>
                            <td><%=yongjin %></td>
                            <td><%=tixian %></td>
                        </tr>
                    </table>
                    <p class="pp1">推广明细</p>
                    <table class="table_1">
                        <tbody>
                            <tr class="tr3" style="background: #fff;border: solid 1px #d2d2d2;">
                                <td>商品图片</td>
                                <td style="width:200px">商品名称</td>
                                <td>价格</td>
                                <td>数量</td>
                                <td>买家</td>
                                <td>订单状态</td>
                                <td>代理</td>
                            </tr>
                        </tbody>
                        <asp:Repeater ID="rptResultsList" runat="server">
                            <ItemTemplate>
                                <tr class="tr2 tr3_tr1" style="background: #fff;">
                                    <td colspan="7">
                                        <p class="tr2_p1">订单编号：[<span style="color:#1faae0"><%#DataBinder.Eval(Container.DataItem,"OrderCode") %></span>]</p>
                                        <p class="tr2_p1">【实付金额：<%#DataBinder.Eval(Container.DataItem,"TotalPrice") %>】</p>
                                    </td>
                                </tr>
                                <%#DataBinder.Eval(Container.DataItem,"ItemInfo") %>
                            </ItemTemplate>
                        </asp:Repeater>
                        
                    </table>
                </div>
            </div>
            <webdiyer:AspNetPager ID="pager1" CssClass="paginator" CurrentPageButtonClass="cpb" runat="server" AlwaysShow="True"
                FirstPageText="首页" LastPageText="尾页" NextPageText="下一页" PageSize="15" PrevPageText="上一页"
                ShowInputBox="Never" OnPageChanged="AspNetPager1_PageChanged" CustomInfoTextAlign="Left">
            </webdiyer:AspNetPager>
        </div>
    </aside>
</asp:Content>

