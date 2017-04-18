<%@ Page Title="站点属性" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="site.aspx.cs" Inherits="config_site" %>

<asp:Content ID="Content1" ContentPlaceHolderID="header" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" Runat="Server">
    <section>
        <div class="page_title">
            <h2><strong>站点属性</strong>
                 <a class="fr top_rt_btn" onclick="btnaddsite()">添加属性</a> 
            </h2>
        </div>
        <table class="table">
          
                    <tr>
                        <th>属性Key</th>
                        <th>属性Value</th>
                        <th>添加时间</th>
                        <th>操作</th>
                    </tr>
               <asp:Repeater ID="rptResultsList" runat="server">
                <ItemTemplate>
                    <tr>

                        <td>
                            <%#DataBinder.Eval(Container.DataItem,"PropertyKey") %>
                        </td>

                        <td>
                            <%#DataBinder.Eval(Container.DataItem,"PropertyValue") %>
                        </td>
                        <td>
                            <%#DataBinder.Eval(Container.DataItem,"Addtime") %>
                        </td>
                        <td>
                            <a onclick="xiugai(<%#Eval("Id") %>)">修改</a>
                            &nbsp;|&nbsp;
                            <a onclick="deieteshuxing(<%#Eval("Id") %>)">删除</a>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </table>
    </section>
     <div class="box" id="box1" style="display:none;width: 100%;height:300%;background: rgba(0,0,0,0.2); position: fixed;  z-index:100000;margin-top:-522px;margin-left:-220px">
            <div class="box1" style="position: fixed;left: 33%; top: 25%;background-color:#19a97b"> 
                        
                    <div style="background-color:#19a97b;padding: 10px;height: 20px;font-size: 16px;"> 
                        <p style="color:#fff;text-align:center">添加属性</p>
                    </div><input type="hidden" id="hid" />
                    <div style="background-color:#fff;width:300px;">
                        <div style="padding:15px 10px;">
                            <span style="padding-left: 15px;">属性Key：</span><input type="text" id="txtattkey" style="width:180px"/>
                        </div>
                        <div style="padding:15px 10px;">
                            <span>属性Value：</span><input type="text" id="txtattvalue" style="width:180px"/>
                        </div>
                    </div>
                    <div style="background:#F0F0F0;border-top:1px solid #DDDDDD;padding:12px;">
                       <span style="border:solid 1px #808080;color:#fff;padding:5px;cursor:pointer;border:0;background-color:#19a97b" onclick="queding()">确定</span>
                       <span style="border:solid 1px #808080;color:#fff;padding:5px;cursor:pointer;border:0;background-color:#808080" onclick="jQuery('.box').hide()">取消</span>
                    </div>
                    <div style="float:right;position: absolute;right: 0;top: 0;z-index: 999;"><a title="关闭" style="cursor:pointer;"><img src="../images/shut.png" id="img"  onclick="jQuery('.box').hide()" style="margin:10px;"/></a>
                    </div>
            </div>
        </div>
    <script>
        function btnaddsite()
        {
            $("#hid").val("");
            $("#box1").css("display", "block");
        }
        function xiugai(id) {
            $.ajax({
                url: "../data/data.aspx",
                type: 'POST',
                data: {
                    type: 'getAttribute',
                    id: id
                },
                success: function (result) {
                    if (result == 2) {
                        alert("获取配置信息失败！");

                    }
                    else {
                        var json = JSON.parse(result);
                        btnaddsite();
                        $("#txtattkey").val(json.PropertyKey);
                        $("#txtattvalue").val(json.PropertyValue);
                        $("#hid").val(id);
                    }
                }
            });
        }
        function queding()
        {
            var shopid = "<%=shopid%>";
            var txtattkey = $("#txtattkey").val();
            //alert(txtattkey);
            if (txtattkey == "") {
                alert("属性key值不能为空！");
                return;
            }
            var txtattvalue = $("#txtattvalue").val();
            //alert(txtattvalue);
            if (txtattvalue == "") {
                alert("属性value值不能为空！");
                return;
            }
            var pid = $("#hid").val();
            //alert(pid);
            if (pid == "") {
                $.ajax({
                    url: "../data/data.aspx",
                    type: 'POST',
                    data: {
                        type: 'AddAttributeone',
                        id: shopid,
                        txtattkey: txtattkey,
                        txtattvalue: txtattvalue
                    },
                    success: function (result) {
                        if (result == 1) {
                            alert("添加成功！");
                            window.location.href = "site.aspx";
                        }
                        else if (result == 2) {
                            alert("添加失败！");
                            window.location.href = "site.aspx";
                        }
                    }
                });
            }
            else {
                $.ajax({
                    url: "../data/data.aspx",
                    type: 'POST',
                    data: {
                        type: 'updateAttributeone',
                        id: pid,
                        txtattkey: txtattkey,
                        txtattvalue: txtattvalue
                    },
                    success: function (result) {
                        if (result == 1) {
                            alert("修改成功！");
                            window.location.href = "site.aspx";
                        }
                        else if (result == 2) {
                            alert("修改失败！");
                            window.location.href = "site.aspx";
                        }
                    }
                });
            }
        }
        function deieteshuxing(id) {
            var flag = confirm("确定删除此属性！");
            if (!flag)
                return;
            $.ajax({
                url: "../data/data.aspx",
                type: 'POST',
                data: {
                    type: 'deleteAttribute',
                    id: id
                },
                success: function (result) {
                    if (result == 1) {
                        alert("删除成功！");

                        window.location.href = "site.aspx";
                    }
                    else if (result == 2) {
                        alert("删除失败！");
                        window.location.href = "site.aspx";
                    }
                }
            });
        }
    </script>
</asp:Content>

