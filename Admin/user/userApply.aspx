<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="userApply.aspx.cs" Inherits="user_Default" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="header" Runat="Server">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" Runat="Server">
      <section>
      
      <div class="page_title">
       <h2>待审核页面</h2> 
      </div>
      <table class="table">
      <asp:Repeater ID="rptResultsList" runat="server">
          <HeaderTemplate>                 
                
               <tr>
                <th>头像</th>
                <th>昵称</th>
                <th>真实姓名</th>
                <th>申请资料</th>
                <th>上级代理</th>
                <th>申请时间</th>
                <th>操作</th>
               </tr>
          </HeaderTemplate>
          <ItemTemplate>                   
                    
               <tr>
                <td style="width:90px;"><img src="<%#DataBinder.Eval(Container.DataItem,"HeadImgUrl") %>" class="avatar" /></td>
                <td><%#DataBinder.Eval(Container.DataItem,"NickName") %></td>
                <td><%#DataBinder.Eval(Container.DataItem,"RealName") %></td>
                <td style="width:200px;">
                    <%#DataBinder.Eval(Container.DataItem,"description") %>
                </td>
                <td>
                    <a href="<%#Eval("uid").ToString()==""?"":"userShow.aspx?uid="+Eval("uid") %>">
                    <%#DataBinder.Eval(Container.DataItem,"NickName2")==""?"<span style='color:red'>暂无推荐</span>":Eval("NickName2") %>
                    </a>

                </td>
                <td><%#DataBinder.Eval(Container.DataItem,"AddTime") %></td>
                <td><a href="useraudit.aspx?uid=<%#Eval("userid") %>"  class="inner_btn">审核</a></td>
               </tr> 
          </ItemTemplate>
          <FooterTemplate>                     
          </FooterTemplate>   
      </asp:Repeater>  
      </table>
      <aside class="paging">
       <div class="das_pages" >       
                <webdiyer:AspNetPager ID="pager1" CssClass="paginator"   CurrentPageButtonClass="cpb" runat="server" AlwaysShow="True" 
                FirstPageText="首页"  LastPageText="尾页" NextPageText="下一页"  PageSize="15" PrevPageText="上一页"   
            ShowInputBox="Never" onpagechanged="AspNetPager1_PageChanged"  CustomInfoTextAlign="Left"   >
            </webdiyer:AspNetPager>
        </div>
      </aside>
     </section> 
    <script>
        function audit(uid,obj) {
            $.getJSON(
                "../data/user.ashx?type=aduit&uid=" + uid,
                function (data) {
                    if (data.result == 'ok') { $(obj).parent().parent().remove(); alert("修改成功！"); } else { alert("修改失败！"); }
                }
            );
        }
    </script>
</asp:Content>

