<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="userEdit.aspx.cs" Inherits="user_userEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="Server">
    <section>
        <h2><strong style="color: grey;">常用操作</strong></h2>
        <span class="item_name" style="width: 120px; display: inline-block;">&nbsp;</span>

        <a class="link_btn" href="userShow.aspx?uid=<%=uid %>">查看用户详情</a>
        <a class="link_btn" href="userEdit.aspx?uid=<%=uid %>">修改基本信息</a>
        <a class="link_btn" href="userUperChange.aspx?uid=<%=uid %>">更换上级代理</a>
        <a class="link_btn" href="userAchieve.aspx?uid=<%=uid %>">查看代理业绩</a>

    </section>
    <section>
        <h2><strong style="color: grey;">编辑用户信息</strong></h2>
        <ul class="ulColumn2">
            <li>
                <span class="item_name" style="width: 120px;">头像：</span>
                 <asp:Image ID="imgAvatar" runat="server" CssClass="avatar" />
            </li>
            <li>
                <span class="item_name" style="width: 120px;">昵称：</span>
                     <asp:Label ID="lbNickname" runat="server" Text=""></asp:Label>
            </li>
            <li>
                <span class="item_name" style="width: 120px;">真实姓名：</span>
                <asp:TextBox ID="txtRealName" runat="server" CssClass="textbox textbox_295"></asp:TextBox>
            </li>
            <li>
                <span class="item_name" style="width: 120px;">微信号：</span>
                <asp:TextBox ID="txtWeixin" runat="server" CssClass="textbox textbox_295"></asp:TextBox>
            </li>
            <li>
                <span class="item_name" style="width: 120px;">手机号：</span>
                <asp:TextBox ID="txtPhone" runat="server" CssClass="textbox textbox_295"></asp:TextBox>
            </li>
            <li>
                <span class="item_name" style="width: 120px;">代理角色：</span>
                <asp:DropDownList ID="ddlRole" runat="server"></asp:DropDownList>
            </li>
            <li>
                <span class="item_name" style="width: 120px;">上级代理：</span>
                <asp:Label ID="lbUper" runat="server" Text="Label"></asp:Label>
                <asp:HyperLink ID="linkView" runat="server" Visible="false">>>去查看</asp:HyperLink>
            </li>
            <li>
                <span class="item_name" style="width: 120px;">加入时间：</span>
                <asp:Label ID="lbAddtime" runat="server" Text="Label"></asp:Label>
            </li>
            <li>
                <span class="item_name" style="width: 120px;"></span>
                <asp:Button ID="btnEdit" runat="server" Text="确定修改" CssClass="link_btn" OnClick="btnEdit_Click" />
            </li>

        </ul>
    </section>

</asp:Content>

