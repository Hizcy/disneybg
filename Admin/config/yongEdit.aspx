<%@ Page  Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="yongEdit.aspx.cs" Inherits="distribution_Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="Server">

        <section>
        <h2>角色添加</h2>
        <ul class="ulColumn2">
            <li>
                <span class="item_name" style="width: 120px;">角色列表：</span>
                 <asp:DropDownList ID="dpdRole" runat="server"></asp:DropDownList>
            </li>
            <li>
                <span class="item_name" style="width: 120px;">一级佣金：</span>
                <asp:TextBox CssClass="textbox textbox_295" ID="txtYiji" runat="server"></asp:TextBox>%
            </li>
            <li>
                <span class="item_name" style="width: 120px;">二级佣金：</span>
                <asp:TextBox  CssClass="textbox textbox_295" ID="txtErji" runat="server" ></asp:TextBox>%
            </li>
                        <li>
                <span class="item_name" style="width: 120px;">三级佣金：</span>
                <asp:TextBox  CssClass="textbox textbox_295" ID="txtSanji" runat="server"></asp:TextBox>%
            </li>
             <li>
                <span class="item_name" style="width: 120px;"></span>
                 <asp:Button ID="btnAdd" runat="server" Text="确认" CssClass="link_btn" OnClick="btnAdd_Click" />
                 <a class="link_btn" href="yongList.aspx">返回</a>
             </li>
        </ul> 
        
    </section> 
   
</asp:Content>

