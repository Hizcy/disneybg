<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="yongList.aspx.cs" Inherits="distribution_pointlist" %>

<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="Server">
 
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="Server">
   <section>
   <div class="page_title">
            <h2><strong>角色佣金分配规则</strong> 
                  <a class="fr top_rt_btn" href="yongEdit.aspx">添加规则</a>
            </h2>
      
        </div> 
                <table class="table">
                    
               
                <asp:Repeater ID="rptPointList" runat="server"  >
                    <HeaderTemplate>
                        <tr>
                        <th>角色名称</th>
                         
                        <th>分销提成点</th>
                    
                        <th>操作</th>
                    </tr> 
                    </HeaderTemplate>

                    <ItemTemplate> 
                            <tr>
                                <td style="line-height: 30px; text-align: center; width: 14%">
                                    <%# GetEntity(int.Parse(Eval("RoleId").ToString())) %>
                                </td>
                               
                                <td style="line-height: 30px; text-align: center; width: 18%">
                                    一层分佣:<%# Eval("OneFenxiao") %>%<br />
                                    二层分佣:<%# Eval("TwoFenxiao") %>%<br />
                                    三层分佣:<%# Eval("ThreeFenxiao")%>%<br />
                                </td> 
                                <td style="line-height: 30px; text-align: center; width: 12%">
                                    <a href="yongEdit.aspx?id=<%#Eval("Id") %>">修改</a>
     
                                </td>
                            </tr> 
                    </ItemTemplate>
                </asp:Repeater>
                     </table>
  </section>

 
</asp:Content>

