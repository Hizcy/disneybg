<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="orderList.aspx.cs" Inherits="order_orderList" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="Server">
    <title>订单列表</title>
    <link href="/css/order.css" rel="stylesheet" />
    <script type="text/javascript" src="/js/datepicker/WdatePicker.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="Server">
    <div class="page_title">
        <h2><strong>订单列表</strong></h2>
    </div>
    <div class="m-orderlist">
        <section> 
            <ul class="admin_tab">
                <li><a class="<%=(type == 0 ? "active" : "") %>" href="orderList.aspx">全部订单</a></li>
                <li><a class="<%=(type == 1 ? "active" : "")%>" href="orderList.aspx?type=1">待发货订单</a></li>
                <li><a class="<%=(type == 2 ? "active" : "")%>" href="orderList.aspx?type=2">已发货订单</a></li>
                <li><a class="<%=(type == 3 ? "active" : "")%>" href="orderList.aspx?type=3">完成订单</a></li>
            </ul>
            <!--tabCont-->
            <div class="admin_tab_cont" style="display: block;">
                <div class="m-search_order clear">
                    <div class="searchitem">
                        <label>商品名称：</label>
                        <asp:TextBox ID="txtProductName" runat="server" class="textbox s textbox_125"></asp:TextBox>
                    </div>
                    <div class="searchitem">
                        <label>收货人：</label>
                        <asp:TextBox ID="txtBuyer" runat="server" class="textbox  s textbox_80"></asp:TextBox>
                    </div>

                    <div class="searchitem">
                        <label>电话：</label>
                        <asp:TextBox ID="txtPhone" runat="server" class="textbox  s textbox_125"></asp:TextBox>
                    </div>

                    <div class="searchitem">
                        <label>下单时间：</label>
                        <input id="startDate" runat="server" class="Wdate" type="text" onfocus="var endDate=$dp.$('endDate');WdatePicker({onpicked:function(){endDate.focus();},maxDate:'#F{$dp.$D(\'endDate\')}',dateFmt:'yyyy-MM-dd HH:mm:ss'})" />
                        至 
                      <input id="endDate" runat="server" class="Wdate" type="text" onfocus="WdatePicker({minDate:'#F{$dp.$D(\'startDate\')}',dateFmt:'yyyy-MM-dd HH:mm:ss'})" />

                    </div>
                    <asp:Button ID="btnQuery" class="group_btn" runat="server" Text="查询" OnClick="btnQuery_Click" />
                </div>
                <table class="table">
                    <tr class="trbg">
                        <td class="td_rlast" style="width: 60px">商品图片</td>
                        <td class="td_rlast">商品名称</td>
                        <td class="td_rlast" style="width: 50px">价格</td>
                        <td class="td_rlast" style="width: 39px">数量</td>

                        <td class="td_rlast" style="width: 50px">买家</td>
                        <td class="td_rlast" style="width: 90px">订单状态</td>
                        <td class="td_rlast" style="width: 60px">代理</td>
                    </tr>
                    <asp:Repeater ID="rptResultsList" runat="server">
                        <ItemTemplate>

                            <tr>
                                <td class="t_lft" colspan="4">订单编号：
                            <span id="MainContent_rptOrder_lblUnWein_2"></span>[<%#DataBinder.Eval(Container.DataItem,"OrderCode") %>]<span id="MainContent_rptOrder_lblQuan_2"></span><br>
                                    付款时间：<%#DataBinder.Eval(Container.DataItem,"ConfirmTime") %><br>
                                    快递单号：<%#DataBinder.Eval(Container.DataItem,"expresscode") %><br>
                                    收货人：<%#DataBinder.Eval(Container.DataItem,"buyer") %>(<%#DataBinder.Eval(Container.DataItem,"phone") %>)      【实付金额：<%#DataBinder.Eval(Container.DataItem,"TotalPrice") %>】
                            <span id="MainContent_rptOrder_lblPostageFee_2">【邮费:<%#DataBinder.Eval(Container.DataItem,"Postage") %>】</span>
                                    <br>
                                    收货地址：<span id="MainContent_rptOrder_lblAddress_2"><%#DataBinder.Eval(Container.DataItem,"Address") %></span><span id="MainContent_rptOrder_lblShouHuo_2"></span></td>
                                <td class="t_rt" align="right" colspan="4">
                                    <span class="icon_flag_2" onclick="BeiZhu(245279,0)" title="点击可添加备注"></span>
                                    下单时间：<%#DataBinder.Eval(Container.DataItem,"AddTime") %><br>
                                    <span id="MainContent_rptOrder_lblUsers_2"></span>
                                    发货时间：<%#DataBinder.Eval(Container.DataItem,"SendTime") %><br>
                                    <%#showButton(int.Parse(Eval("Status").ToString()),int.Parse(Eval("OrderId").ToString())) %>                                   
                                </td>
                            </tr>
                            <%#DataBinder.Eval(Container.DataItem,"ItemInfo") %>
                            <tr>
                                <td class="td_rlast" colspan="7" style="background-color: #f9f3ed"><span id="MainContent_rptOrder_lblDesp_1"></span></td>
                            </tr>
                            <tr>
                                <td colspan="7">
                                    <hr>
                                </td>
                            </tr>
                        </ItemTemplate>
                        <FooterTemplate>
                        </FooterTemplate>
                    </asp:Repeater>
                </table>

            </div>

            <aside class="paging">
                <div class="das_pages">
                    <webdiyer:AspNetPager ID="pager1" CssClass="paginator" CurrentPageButtonClass="cpb" runat="server" AlwaysShow="True"
                        FirstPageText="首页" LastPageText="尾页" NextPageText="下一页" PageSize="15" PrevPageText="上一页"
                        ShowInputBox="Never" OnPageChanged="AspNetPager1_PageChanged" CustomInfoTextAlign="Left">
                    </webdiyer:AspNetPager>
                </div>
            </aside>
        </section>
    </div>
    <script>
        function tuikuan(OrderId) {
            $.ajax({
                url: "../data/order.ashx",
                type: "POST",
                data: {
                    type: "tuikuan",
                    OrderId: OrderId
                },
                success: function (result) {
                    if (result == 1) {
                        alert("退款成功！");
                        location.reload();
                    }
                    else
                        alert("退款失败！");
                }
            })
        }
        function tuihuo(OrderId) {
            $.ajax({
                url: "../data/order.ashx",
                type: "POST",
                data: {
                    type: "tuihuo",
                    OrderId: OrderId
                },
                success: function (result) {
                    if (result == 1) {
                        alert("退货成功！");
                        location.reload();
                    }
                    else
                        alert("退货失败！");
                }
            })
        }
        //退款
        function orderTuikuan(orderId) {
            $.ajax({
                url: "../data/orderTuiKuan.ashx",
                type: "POST",
                data: { 
                    orderId: orderId
                },
                success: function (result) {
                    if (result == 1) {
                        alert("退款成功！");
                        location.reload();
                    }
                    else
                        alert("退款失败！");
                }
            })
        }
    </script>
</asp:Content>

