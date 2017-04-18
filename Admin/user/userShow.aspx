<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="userShow.aspx.cs" Inherits="user_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="header" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" Runat="Server">
             <section>
      <h2><strong style="color:grey;">常用操作</strong></h2> 
         <span class="item_name" style="width:120px;display:inline-block;">&nbsp;</span>

           <a class="link_btn" href="userShow.aspx?uid=<%=uid %>">查看代理详情</a>
            <a class="link_btn" href="userEdit.aspx?uid=<%=uid %>">修改基本信息</a>
           <a class="link_btn" href="userUperChange.aspx?uid=<%=uid %>" >更换上级代理</a> 
           <a class="link_btn" href="userAchieve.aspx?uid=<%=uid %>">查看代理业绩</a>
    
     </section>
     <section>
      <h2><strong>代理基本信息</strong></h2>
      <ul class="ulColumn2">
       <li>
        <span class="item_name" style="width:120px;">OpenID：</span>
           <asp:Label ID="lbOpenid" runat="server" Text=""></asp:Label>
       </li>
           <li>
        <span class="item_name" style="width:120px;">上级代理：</span>
         <asp:Label ID="lbUperdaili" runat="server" Text=""></asp:Label>
       </li>

       <li>
        <span class="item_name" style="width:120px;">头像：</span>
           <asp:Image ID="imgAvatar" runat="server" CssClass="avatar" />
       </li>
        <li>
        <span class="item_name" style="width:120px;">微信昵称：</span>
         <asp:Label ID="lbNickname" runat="server" Text=""></asp:Label>
       </li>
       <li>
        <span class="item_name" style="width:120px;">姓名：</span>
       <asp:Label ID="lbRealname" runat="server" Text=""></asp:Label>
       </li>
       <li>
        <span class="item_name" style="width:120px;">电话：</span>
         <asp:Label ID="lbPhone" runat="server" Text=""></asp:Label>
       </li>
         <li>
        <span class="item_name" style="width:120px;">微信号：</span>
         <asp:Label ID="lbWeixinhao" runat="server" Text=""></asp:Label>
       </li>
        <li>
        <span class="item_name" style="width:120px;">加入时间：</span>
         <asp:Label ID="lbAddtime" runat="server" Text=""></asp:Label>
       </li>
      </ul>
     </section>
     <section>
      <h2><strong>基本业绩信息</strong></h2>
      <ul class="ulColumn2">
       <li>
        <span class="item_name" style="width:120px;">总业绩：</span>
          <asp:Label ID="lbYeji" runat="server" Text=""></asp:Label>
       </li>
                 <li>
        <span class="item_name" style="width:120px;">总佣金：</span>
          <asp:Label ID="lbYongjin" runat="server" Text=""></asp:Label>
       </li>
                 <li>
        <span class="item_name" style="width:120px;">已提现：</span>
          <asp:Label ID="lbTixian" runat="server" Text=""></asp:Label>
       </li> 
      </ul>
     </section>
     <section>
      <h2><strong>基本团队信息</strong></h2>
      <ul class="ulColumn2">
       <li>
        <span class="item_name" style="width:120px;">一级总人数：</span>
         <asp:Label ID="lbYijidaili" runat="server" Text=""></asp:Label>

       </li>
          <li>
        <span class="item_name" style="width:120px;">二级总人数：</span>
         <asp:Label ID="lbErjidaili" runat="server" Text=""></asp:Label>

       </li>
      </ul>
     </section>
</asp:Content>

