<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="proList.aspx.cs" Inherits="product_proList" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="Server">
    <title>商品列表</title>
    <link href="/css/product.css" rel="stylesheet" />
    <style type="text/css">
        .table td .inner_btn {
            margin-bottom: 10px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="Server">
    <section>

     <div class="page_title">
            <h2>
                <strong>商品列表</strong>
                <a class="fr top_rt_btn" href="proEdit.aspx">添加商品</a>
            </h2>

        </div>
        <div style="margin-bottom:2%; padding:2%; padding-right:10%;  border-bottom:1px solid #ddd; position:relative;">
            <div class="list_5 clear">
                <div class="list_6">
                    <label>商品名称：</label>
                    <asp:TextBox ID="txtProductName" runat="server"></asp:TextBox>
                    <asp:Button ID="Button1" class="group_btn" runat="server" Text="查询" OnClick="btnQuery_Click" Style="position: absolute; bottom: 10%; right: 1%;" />
                </div>
            </div>

        </div>
           
        <div class="m-prolist">
            <table class="table">
                <tr>
                    <th>商品图片</th>
                    <th>商品名称</th>
                    <th>商品类型</th>
                    <th>销售价格</th>
                    <th>成本价格</th>
                    <th>状态</th>
                    <th>权重</th>
                    <th>操作</th>
                </tr>
                <asp:Repeater ID="rptResultsList" runat="server">
                    <ItemTemplate>
                        <tr class="<%#DataBinder.Eval(Container.DataItem,"Status").ToString()=="-2"?"notserving":""%> ">
                            <td>
                                <div class="proimg">
                                    <img class="" src="<%#DataBinder.Eval(Container.DataItem,"Image1") %>" />
                                </div>
                            </td>
                            <td width="25%"><%#DataBinder.Eval(Container.DataItem,"Name") %>                            </td>
                            <td><%#DataBinder.Eval(Container.DataItem,"Clsname") %></td>
                            <td><%#DataBinder.Eval(Container.DataItem,"SalePrice") %>元</td>
                            <td><%#DataBinder.Eval(Container.DataItem,"CostPrice") %>元</td>
                            <td><span class="f-status"><%#GetStatus(DataBinder.Eval(Container.DataItem,"Status").ToString())%></span></td>
                            <td>
                                <input class="textbox_40" value="<%#DataBinder.Eval(Container.DataItem,"OrderBy") %>" /><br />
                                <span class="opeart_btn" onclick="fnChangeOrderBy(this,<%#DataBinder.Eval(Container.DataItem,"ProductId") %>)" title="修改权重">修改</span></td>
                            <td>
                                <a href="proEdit.aspx?proId=<%#DataBinder.Eval(Container.DataItem,"ProductId") %>" class="inner_btn">编辑</a><br />
                                <a href="skuEdit.aspx?proId=<%#DataBinder.Eval(Container.DataItem,"ProductId") %>" class="inner_btn">SKU修改</a><br />

                                <%#DataBinder.Eval(Container.DataItem,"Status").ToString()=="-2"||DataBinder.Eval(Container.DataItem,"Status").ToString()=="1"?"<a href=\"javascript:;\" onclick=\"fnChangeStatus('shangjia',"+DataBinder.Eval(Container.DataItem,"ProductId").ToString()+")\" class=\"inner_btn f-chagestatus\">上架</a>":""%>
                                <%#DataBinder.Eval(Container.DataItem,"Status").ToString()=="2"?"<a href=\"javascript:;\" onclick=\"fnChangeStatus('xiajia',"+DataBinder.Eval(Container.DataItem,"ProductId").ToString()+")\" class=\"inner_btn f-chagestatus\">下架</a>":""%>
                                <br />
                                <a href="javascript:;" onclick="fnChangeStatus('shanchu' ,<%#DataBinder.Eval(Container.DataItem,"ProductId") %> )" class="inner_btn">删除</a>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </table>

        </div>
        <aside class="paging">
            <div class="das_pages">
                <webdiyer:AspNetPager ID="pager1" CssClass="paginator" CurrentPageButtonClass="cpb" runat="server" AlwaysShow="True"
                    FirstPageText="首页" LastPageText="尾页" NextPageText="下一页" PageSize="15" PrevPageText="上一页"
                    ShowInputBox="Never" OnPageChanged="AspNetPager1_PageChanged" CustomInfoTextAlign="Left">
                </webdiyer:AspNetPager>
            </div>
        </aside>
    </section>
    <script>
        var isSubmitDone = true;
        var isConfirm = false;
        function fnChangeOrderBy(t, pid) {
            if (!isSubmitDone) return;
            isSubmitDone = false;
            debugger
            var orderby = ($(t).siblings("input")).val();
            if (isNaN(parseInt(orderby))) {
                alert("请正确输入权重！"); return;
            }

            $.getJSON(
                "/data/product.ashx?type=quanzhong&pid=" + pid + "&orderby=" + orderby,
                function (msg) {
                    if (msg.result == "ok") {
                        fnShowMsg("成功修改权重，你好棒啊~");
                    }
                }
            );
        }
        function fnChangeStatus(s, pid) {
            if (s == "shanchu" && !isConfirm) {
                var callback = function () { fnChangeStatus(s, pid); }
                fnShowConfirm("您确定删除该商品吗？", callback)
                return;
            }

            if (!isSubmitDone) return;
            isSubmitDone = false;

            $.getJSON(
                "/data/product.ashx?type=" + s + "&pid=" + pid,
                function (msg) {
                    debugger;
                    if (msg.result == "ok") {
                        if (s == "shanchu") {
                            $(".m-prolist").find("tr[pid='" + pid + "']").fadeOut();
                            fnShowMsg("成功删除~", 1);
                            isConfirm = false;

                        } else if (s == "shangjia") {
                            $(".m-prolist").find("tr[pid='" + pid + "']").removeClass("notserving").find('.f-status').html("已上架");
                            $(".m-prolist").find("tr[pid='" + pid + "']").find('.f-chagestatus').html("下架").attr("onclick", "fnChangeStatus('xiajia'," + pid + ")");
                            fnShowMsg("已成功上架~", 1);
                        } else if (s == "xiajia") {
                            $(".m-prolist").find("tr[pid='" + pid + "']").addClass("notserving").find('.f-status').html("已下架");
                            $(".m-prolist").find("tr[pid='" + pid + "']").find('.f-chagestatus').html("上架").attr("onclick", "fnChangeStatus('shangjia'," + pid + ")");
                            fnShowMsg("已成功下架~", 1);
                        }

                    } else {
                        fnShowMsg(msg.message);
                    }
                    setTimeout(function () {
                        isSubmitDone = true;
                    }, 1000);
                }
            );
        }

    </script>
</asp:Content>

