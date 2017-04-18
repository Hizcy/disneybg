<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="roleList.aspx.cs" Inherits="user_ListRole" %>

<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="server">
    <section>
        <div class="page_title">
            <h2><strong>角色管理</strong>
                 <a class="fr top_rt_btn" href="roleEdit.aspx">添加角色</a> 
            </h2>
           

        </div>
        <table class="table">
            <asp:Repeater ID="rptResultsList" runat="server">
                <HeaderTemplate>
                    <tr>
                        <th>角色类别</th>
                        <th>套餐金额</th>
                        <th>操作</th>
                    </tr>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr>

                        <td>
                            <%#DataBinder.Eval(Container.DataItem,"Name") %>
                        </td>

                        <td>
                            <%#DataBinder.Eval(Container.DataItem,"price") %>
                        </td>
                        <td>
                            <a href="roleEdit.aspx?id=<%#DataBinder.Eval(Container.DataItem,"roleid") %>">编辑</a>

                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </table>
    </section>
</asp:Content>
