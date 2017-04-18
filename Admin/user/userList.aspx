<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="userList.aspx.cs" Inherits="user_userList" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="Server">
    <link href="/css/order.css" rel="stylesheet" />
    <script type="text/javascript" src="/js/datepicker/WdatePicker.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="Server">
    <div class="page_title">
        <h2>代理汇总</h2>
    </div>
    <div class="m-orderlist">
        <section>
            <ul class="admin_tab">
                <li><a class="active" href="userList.aspx">全部代理</a></li>
                </ul>
            <!--tabCont-->
            <div class="admin_tab_cont" style="display: block;">
                <div class="m-search_order clear">
                    <div class="searchitem">
                        <label>姓名：</label> 
                        <asp:TextBox ID="txtSname" runat="server" CssClass="textbox s textbox_125"></asp:TextBox>
                    </div>
                    <div class="searchitem">
                        <label>手机号：</label> 
                        <asp:TextBox ID="txtSphone" runat="server" CssClass="textbox s textbox_125"></asp:TextBox>

                    </div>
                    <div class="searchitem">
                        <label>微信号：</label> 
                        <asp:TextBox ID="txtSweixin" runat="server" CssClass="textbox s textbox_125"></asp:TextBox>
                    </div>  
 
                    <div class="searchitem">
                        <label>下单时间：</label>  
                        
                        <input runat="server" ClientIDMode="Static"  id="startDate" class="Wdate" type="text" onfocus="var endDate=$dp.$('endDate');WdatePicker({onpicked:function(){endDate.focus();},maxDate:'#F{$dp.$D(\'endDate\')}',dateFmt:'yyyy-MM-dd HH:mm:ss'})" />
                        至 
                      <input  runat="server" ClientIDMode="Static"  id="endDate" class="Wdate" type="text" onfocus="WdatePicker({minDate:'#F{$dp.$D(\'startDate\')}',dateFmt:'yyyy-MM-dd HH:mm:ss'})" />

                    </div> 
                     <asp:Button ID="btnSearch" runat="server" Text="查询" CssClass="group_btn" OnClick="btnSearch_Click" />
                </div>
               
                <section>
                    <table class="table">
                        <asp:Repeater ID="rptResultsList" runat="server">
                            <HeaderTemplate>

                                <tr>
                                    <th>头像</th>
                                    <th>昵称</th>
                                    <th>真实姓名</th>
                                    <th>手机号</th>
                                     <th>微信号</th>
                                    <th>代理级别</th>
                                    <th>上级代理</th>
                                    <th>申请时间</th>
                                    <th>操作</th>
                                </tr>
                            </HeaderTemplate>
                            <ItemTemplate>

                                <tr>
                                    <td style="width: 90px;">
                                        <img src="<%#DataBinder.Eval(Container.DataItem,"HeadImgUrl") %>" class="avatar" /></td>
                                    <td><%#DataBinder.Eval(Container.DataItem,"NickName") %></td>
                                    <td><%#DataBinder.Eval(Container.DataItem,"RealName") %></td>
                                    <td><%#DataBinder.Eval(Container.DataItem,"Phone") %></td>
                                    <td><%#DataBinder.Eval(Container.DataItem,"Weixin") %></td>
                                    <td>
                                        <%#DataBinder.Eval(Container.DataItem,"RoleName") %>
                                    </td>
                                    <td>
                                        <a href="<%#Eval("uid").ToString()==""?"":"userShow.aspx?uid="+Eval("uid") %>">
                                            <%#DataBinder.Eval(Container.DataItem,"NickName2")==""?"<span style='color:red'>暂无推荐</span>":Eval("NickName2") %>
                                        </a>

                                    </td>
                                    <td><%#DataBinder.Eval(Container.DataItem,"AddTime") %></td>
                                    <td><a href="userEdit.aspx?uid=<%#DataBinder.Eval(Container.DataItem,"UserId") %>" class="inner_btn">编辑</a>

                                    </td>
                                </tr>
                            </ItemTemplate>
                            <FooterTemplate>
                            </FooterTemplate>
                        </asp:Repeater>
                    </table>
                    <aside class="paging">
                        <div class="das_pages">
                            <webdiyer:AspNetPager ID="pager1" CssClass="paginator" CurrentPageButtonClass="cpb" runat="server" AlwaysShow="True"
                                FirstPageText="首页" LastPageText="尾页" NextPageText="下一页" PageSize="15" PrevPageText="上一页"
                                ShowInputBox="Never" OnPageChanged="AspNetPager1_PageChanged" CustomInfoTextAlign="Left">
                            </webdiyer:AspNetPager>
                        </div>
                    </aside>
                </section>

            </div>
            <div class="admin_tab_cont">2</div>
            <div class="admin_tab_cont">3</div>
        </section>
    </div>
    
</asp:Content>

