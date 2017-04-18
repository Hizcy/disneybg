<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="userUperChange.aspx.cs" Inherits="user_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="header" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" Runat="Server">
         <section>
      <h2><strong style="color:grey;">常用操作</strong></h2> 
         <span class="item_name" style="width:120px;display:inline-block;">&nbsp;</span>

           <a class="link_btn" href="userShow.aspx?uid=<%=uid %>">查看用户详情</a>
            <a class="link_btn" href="userEdit.aspx?uid=<%=uid %>">修改基本信息</a>
           <a class="link_btn" href="userUperChange.aspx?uid=<%=uid %>" >更换上级代理</a> 
           <a class="link_btn" href="userAchieve.aspx?uid=<%=uid %>">查看代理业绩</a>
    
     </section>

     <section>
      <h2><strong style="color:grey;">修改{杨晓光}的上级代理</strong></h2>
      <ul class="ulColumn2">
          <li>
        <span class="item_name" style="width:120px;">原上级代理：</span> 
              <asp:Label ID="lbUperName" runat="server" Text="Label"></asp:Label>
       </li>
          <li>
        <span class="item_name" style="width:120px;">原上级代理ID：</span> 
            <asp:Label ID="lbUperID" runat="server" Text="Label"></asp:Label>
       </li>
           
       <li>
        <span class="item_name" style="width:120px;">新的上级代理ID：</span> 
           <asp:TextBox ID="txtNewParentID" runat="server" CssClass="textbox textbox_295"></asp:TextBox>
       </li>
          
        
       <li>
           
        <span class="item_name" style="width:120px;"></span> 
           <asp:Button ID="btnChangeUper" runat="server" Text="确定更改" CssClass="link_btn" OnClick="btnChangeUper_Click" />
       </li>
      </ul>
     </section>
</asp:Content>

