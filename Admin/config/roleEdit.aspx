<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="roleEdit.aspx.cs" Inherits="user_AddRole" %>

<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="Server">
    <section>
        <h2>角色添加</h2>
        <ul class="ulColumn2">
            <li>
                <span class="item_name" style="width: 120px;">角色名称：</span>
                <asp:TextBox CssClass="textbox textbox_295" ID="txtName" runat="server"></asp:TextBox>
            </li>
            <li>
                <span class="item_name" style="width: 120px;">升级套餐：</span>
                <asp:TextBox CssClass="textbox textbox_295" ID="txtmoney" runat="server"></asp:TextBox>
            </li>
            <li>
                <span class="item_name" style="width: 120px;">套餐描述：</span>
                <asp:TextBox  CssClass="textarea" ID="txtDescrition" runat="server" TextMode="MultiLine"></asp:TextBox>
            </li>
             <li>
                <span class="item_name" style="width: 120px;"></span>
                 <asp:Button ID="btnAdd" runat="server" Text="确认" CssClass="link_btn" OnClick="btnAdd_Click" />
                 <a class="link_btn" href="roleList.aspx">返回</a>
             </li>
        </ul> 
        
    </section>

</asp:Content>
