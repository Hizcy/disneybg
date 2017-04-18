<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="tixianReject.aspx.cs" Inherits="config_tixianReject" %>

<asp:Content ID="Content1" ContentPlaceHolderID="header" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" Runat="Server">
    <section>
      <h2><strong style="color:grey;">拒绝原因</strong></h2>
      <ul class="ulColumn2">
      
       <li>
        <span class="item_name" style="width:120px;">摘要：</span>
        <textarea runat="server" id="txtReason" placeholder="详细拒绝原因" class="textarea" style="width:500px;height:100px;"></textarea>
       </li>
        
       <li>
        <span class="item_name" style="width:120px;"></span>
           <asp:Button ID="btnSubmit" runat="server" Text="驳回" CssClass="link_btn" OnClick="btnSubmit_Click" />
       </li>
      </ul>
     </section>

</asp:Content>

