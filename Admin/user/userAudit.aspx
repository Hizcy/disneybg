<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="userAudit.aspx.cs" Inherits="user_userAudit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="header" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" Runat="Server">
    <section>
        <h2><strong style="color: grey;">编辑用户信息</strong></h2>
        <ul class="ulColumn2">
            
            <li>
                <span class="item_name" style="width: 120px;">代理角色：</span>
                <asp:DropDownList ID="ddlRole" runat="server"></asp:DropDownList>
            </li>
            <li>
                <asp:TextBox ID="hidopen" Style="display:none" runat="server" ></asp:TextBox>
            </li>
            
            <li>
                <span class="item_name" style="width: 120px;"></span>
                <asp:Button ID="btnAudit" runat="server" Text="审核通过" CssClass="link_btn" OnClick="btnAudit_Click"  />
            </li>

        </ul>
    </section>
</asp:Content>

