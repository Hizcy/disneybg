<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="roleyongEdit.aspx.cs" Inherits="config_roleyongEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="header" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" Runat="Server">
    <section>
        <h2>角色添加</h2>
        <ul class="ulColumn2">
            <li>
                <span class="item_name" style="width: 120px;">角色列表：</span>
                 <asp:DropDownList ID="dpdRole" runat="server"></asp:DropDownList>
            </li>
            <li>
                <span class="item_name" style="width: 120px;">合伙人：</span>
                <asp:TextBox CssClass="textbox textbox_125" ID="txtHehuoren" runat="server"></asp:TextBox>
                <asp:TextBox style="display:none" ID="hidHehuoren" Text="11" runat="server"></asp:TextBox>
                <span class="item_name" style="width: 120px;">渠道：</span>
                <asp:TextBox CssClass="textbox textbox_125" ID="txtHehuorenQudao" runat="server"></asp:TextBox>
            </li>
            <li>
                <span class="item_name" style="width: 120px;">金牌代理：</span>
                <asp:TextBox  CssClass="textbox textbox_125" ID="txtJinpai" runat="server" ></asp:TextBox>
                <asp:TextBox style="display:none" ID="hidJinpai" Text="13" runat="server"></asp:TextBox>
                <span class="item_name" style="width: 120px;">渠道：</span>
                <asp:TextBox CssClass="textbox textbox_125" ID="txtJinpaiQudao" runat="server"></asp:TextBox>
            </li>
            <li>
                <span class="item_name" style="width: 120px;">银牌代理：</span>
                <asp:TextBox  CssClass="textbox textbox_125" ID="txtYinpai" runat="server"></asp:TextBox>
                <asp:TextBox style="display:none" ID="hidYinpai" Text="14" runat="server"></asp:TextBox>
                <span class="item_name" style="width: 120px;">渠道：</span>
                <asp:TextBox CssClass="textbox textbox_125" ID="txtYinpaiQudao" runat="server"></asp:TextBox>
            </li>
            <li>
                <span class="item_name" style="width: 120px;">普通代理：</span>
                <asp:TextBox  CssClass="textbox textbox_125" ID="txtPutong" runat="server"></asp:TextBox>
                <asp:TextBox style="display:none" ID="hidPutong" Text="15" runat="server"></asp:TextBox>
                <span class="item_name" style="width: 120px;">渠道：</span>
                <asp:TextBox CssClass="textbox textbox_125" ID="txtPutongQudao" runat="server"></asp:TextBox>
            </li>
             <li>
                <span class="item_name" style="width: 120px;"></span>
                 <asp:Button ID="btnAdd" runat="server" Text="确认" CssClass="link_btn" OnClick="btnAdd_Click" />
                 <a class="link_btn" href="yongList.aspx">返回</a>
             </li>
        </ul> 
        
    </section> 
</asp:Content>

