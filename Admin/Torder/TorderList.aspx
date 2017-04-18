<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="TorderList.aspx.cs" Inherits="Torder_TorderList" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="Server">
    <title>组团列表</title>
    <link href="../css/torder.css" rel="stylesheet" /> 
    <script src="../js/datepicker/WdatePicker.js"></script>  
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="Server">
    <div class="page_title">
        <h2><strong>组团列表</strong></h2>
    </div>
    <div class="m-orderlist">
        <section>
            <ul class="admin_tab">
                <li><a class="<%=(type == 0 ? "active" : "") %>" href="TorderList.aspx">全部订单</a></li>
                <li><a class="<%=(type == 1 ? "active" : "") %>" href="TorderList.aspx?type=1">待发货订单</a></li>
                <li><a class="<%=(type == 2 ? "active" : "") %>" href="TorderList.aspx?type=2">已发货订单</a></li>
                <li><a class="<%=(type == 3 ? "active" : "") %>" href="TorderList.aspx?type=3">完成订单</a></li>
                 <li><a class="<%=(type == 4? "active" : "") %>" href="TorderList.aspx?type=4">组团失败</a></li>
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
                        <asp:TextBox ID="txtPhone" onkeyup="this.value=this.value.replace(/\D/g,'')" MaxLength="11" runat="server" class="textbox  s textbox_125"></asp:TextBox>
                    </div>

                    <div class="searchitem">
                        <label>下单时间：</label>
                        <input id="txt_startTime" class="Wdate" type="text" runat="server" onfocus="WdatePicker({maxDate:'#F{$dp.$D(\'mainContent_txt_endTime\')||\'2020-10-01\'}'})" />
                        至  
                      <input id="txt_endTime" class="Wdate" runat="server" type="text" onfocus="WdatePicker({minDate:'#F{$dp.$D(\'mainContent_txt_startTime\')}',maxDate:'2020-10-01'})" />

                    </div>
                    <asp:Button ID="btnQuery" CssClass="group_btn" runat="server" Text="查询" OnClick="btnQuery_Click" />
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
                    <asp:Repeater ID="rptOrderList" runat="server" OnItemCommand="rptOrderList_ItemCommand">
                        <ItemTemplate>
                            <tr>
                                <td class="t_lft" colspan="4" >组团编号：
                            <span id="MainContent_rptOrder_lblUnWein_2"></span><%#Eval("GroupNo") %><span id="MainContent_rptOrder_lblQuan_2"></span><br />
                                    付款时间：<%#Eval("ConfirmTime") %><br />
                                    快递单号：<%#Eval("expresscode") %><br />
                                    收货人：<%#Eval("Buyer") %>(<%#Eval("Phone") %>)      【实付金额<%#Eval("GroupPrice") %>】
                            <span id="MainContent_rptOrder_lblPostageFee_2">【邮费:<%#Eval("Postage") %>】</span>
                                    <br />
                                    收货地址：<%#Eval("Address") %><span id="MainContent_rptOrder_lblAddress_2"></span><span id="MainContent_rptOrder_lblShouHuo_2"></span></td>
                                <td class="t_rt" colspan="4">
                                    <span class="icon_flag_2" onclick="BeiZhu(245279,0)" title="点击可添加备注"></span>
                                    下单时间：<%#Eval("AddTime") %><br />
                                    <span id="MainContent_rptOrder_lblUsers_2"></span>
                                    发货时间：<%#Eval("SendTime") %><br />
                                    <%if(type==4){ %>     
                                          <%-- <%#Eval("").ToString().Equals("-2")?"<font color='red'>已退款</font>":"" %>--%>
                                          <%#Eval("status").ToString().Equals("-2")?"<font color='red'>已退款</font>":"" %>
                                          <asp:Button ID="btn_tuikuan" runat="server" class='<%#Eval("status").ToString().Equals("-2")?"btn_hide":"" %>' Text="退款" style='margin-left: 14px;float:right;background: #679b31;padding: 0 5px;cursor:pointer;color:#f9f3ed;border:none;' CommandArgument='<%#Eval("Postage")+","+Eval("GroupPrice")+","+Eval("OrderCode")+","+Eval("OrderId")+","+Eval("Consignee")+","+Eval("Name")+","+Eval("Phone")+","+(float.Parse(Eval("GroupPrice").ToString())+float.Parse(Eval("Postage").ToString())) %>' CommandName="tuikuan" /> 
                                            
                                    <%} else { %>  
                                        <%#showButton(int.Parse(Eval("Status").ToString()),int.Parse(Eval("OrderId").ToString())) %><br />
                                    <%} %>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 50px;">
                                    <img alt="商品图" width="50" height="50" src="<%#Eval("Image1") %>" />
                                </td>
                                <td style=""><%#Eval("Name")%><span id="MainContent_rptOrder_rptList_2_lblRole_0"></span></td>
                                <td style="width: 50px;"><%#Eval("GroupPrice") %></td>
                                <td style="width: 39px;"><%#Eval("Number") %></td>
                                <td style="width: 50px;"><%#Eval("Buyer") %></td>
                                <td style="width: 80px;"><%#orderStatus(int.Parse(Eval("Status").ToString())) %></td>
                                <td>
                                    <a><%#Eval("dailiname") %></a>
                                </td>
                            </tr> 
                            <tr>
                                <td class="td_rlast" colspan="7" style="background-color: #f9f3ed"><span id="MainContent_rptOrder_lblDesp_1"></span></td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                    <tr>
                        <td class="td_rlast" colspan="7" style="background-color: #f9f3ed"><span id="MainContent_rptOrder_lblDesp_1"></span></td>
                    </tr>
                    <tr>
                        <td colspan="7">
                            <hr />
                        </td>
                    </tr>
                </table>

            </div>
            <aside class="paging">
                <div class="das_pages">
                    <webdiyer:AspNetPager ID="pager1" CssClass="paginator" CurrentPageButtonClass="cpb" runat="server" AlwaysShow="True"
                        FirstPageText="首页" LastPageText="尾页" NextPageText="下一页" PageSize="6" PrevPageText="上一页"
                        ShowInputBox="Never" OnPageChanged="pager1_PageChanged" CustomInfoTextAlign="Left">
                    </webdiyer:AspNetPager>
                </div>
            </aside>
        </section>
    </div>
    <script>  
        function tuikuan(OrderId) {
            if (confirm("确定此操作？")) {
                $.ajax({
                    url: "../data/Torder.ashx",
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
        }
        function tuihuo(OrderId) {
            if (confirm("确定此操作？")) {
                $.ajax({
                    url: "../data/Torder.ashx",
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
        }
    </script>
</asp:Content>

