<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="fahuo.aspx.cs" Inherits="order_fahuo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="Server">
    <section>
        <h2><strong style="color: grey;">填写发货信息</strong></h2>

        <ul class="ulColumn2">
            <li>
                <span class="item_name" style="width: 120px;">快递公司：</span>
                <select id="ddlKuaidi" runat="server">
                    <option value="1">顺丰</option>
                    <option value="2">申通</option>
                    <option value="3">圆通</option>
                    <option value="4">韵达</option>
                    <option value="5">邮政小包</option>
                    <option value="6">自提</option>
                    <option value="7">天天</option>
                    <option value="8">中通</option>
                </select>
            </li>
            <li>
                <span class="item_name" style="width: 120px;">快递号：</span>
                <asp:TextBox ID="txtKuadidihao" CssClass="textbox textbox_295" runat="server"></asp:TextBox>
            </li>
            <li>
                <span class="item_name" style="width: 120px;"></span>
                <asp:Button ID="btnFahuo" runat="server" Text="确定发货" OnClick="btnFahuo_Click" />
            </li>
        </ul>
    </section>
</asp:Content>

