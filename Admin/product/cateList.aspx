<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="cateList.aspx.cs" Inherits="product_cateList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="Server">
    <title>分类列表</title>
    <link href="/css/product.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="Server">
    <section>
        <div class="page_title">
            <h2><strong>商品分类列表</strong><a class="fr top_rt_btn" href="cateEdit.aspx">添加分类</a></h2>
        </div>
          <div class="m-catelist">

            <ul>
           <%--     <asp:Repeater ID="rptResultsList" runat="server">
                    <ItemTemplate>
                        <li cid="<%#DataBinder.Eval(Container.DataItem,"ClsId") %>"><%#DataBinder.Eval(Container.DataItem,"Clsname") %>
                            <span class="opeart_btn" onclick="addcate(<%#DataBinder.Eval(Container.DataItem,"ClsId") %>)">添加二级分类</span>
                            <a class="opeart_btn" href="/product/cateEdit.aspx?cid=<%#DataBinder.Eval(Container.DataItem,"ClsId") %>">编辑</a>
                            <span class="opeart_btn" onclick="fnDel(<%#DataBinder.Eval(Container.DataItem,"ClsId") %>)">删除</span>
                        </li>
                    </ItemTemplate>
                </asp:Repeater>--%>
            </ul>
        </div>

        <div >
          
            <ul>
                  <%=att.ToString() %>
               <%-- <li style="padding: 10px;border-bottom: 1px #d2d2d2 dashed;">童装
                            <span class="opeart_btn">添加二级分类</span>
                    <a class="opeart_btn" >编辑</a>
                    <span class="opeart_btn">删除</span>
                </li>
                <li style="margin-left:40px;padding: 10px;border-bottom: 1px #d2d2d2 dashed;">女装
                    <a class="opeart_btn">编辑</a>
                    <span class="opeart_btn" >删除</span>
                </li>
                 <li  style="margin-left:40px;padding: 10px;border-bottom: 1px #d2d2d2 dashed;">男装
                    <a class="opeart_btn" >编辑</a>
                    <span class="opeart_btn" >删除</span>
                </li>--%>

            </ul>
        </div>
        <div class="box" id="box1" style="display: none; width: 100%; height: 300%; background: rgba(0,0,0,0.2); position: fixed; z-index: 100000; margin-top: -665px; margin-left: -220px">
            <div class="box1" style="position: fixed; left: 33%; top: 25%; background-color: #19a97b">

                <div style="background-color: #19a97b; padding: 10px; height: 20px; font-size: 16px;">
                    <p style="color: #fff; text-align: center">添加二级分类</p>
                </div>
                <input type="hidden" id="hid" />
                <input type="hidden" id="hid1" />
                <div style="background-color: #fff; width: 300px;">
                    <div style="padding: 15px 10px;">
                        <span style="padding-left: 15px;">名称：</span><input type="text" id="txtName" style="width: 180px" />
                    </div>
                    <div style="padding: 15px 10px;">

                        <span style="padding-left: 15px;">描述：</span><input type="text" id="txtIntro" style="width: 180px" />
                    </div>
                    <div style="padding: 15px 10px;">
                        <span style="padding-left: 15px;">权重：</span><input type="text" id="txtOrderby" style="width: 180px" />
                    </div>
                </div>
                <div style="background: #F0F0F0; border-top: 1px solid #DDDDDD; padding: 12px;">
                    <span style="border: solid 1px #808080; color: #fff; padding: 5px; cursor: pointer; border: 0; background-color: #19a97b" onclick="queding()">确定</span>
                    <span style="border: solid 1px #808080; color: #fff; padding: 5px; cursor: pointer; border: 0; background-color: #808080" onclick="jQuery('.box').hide()">取消</span>
                </div>
                <div style="float: right; position: absolute; right: 0; top: 0; z-index: 999;">
                    <a title="关闭" style="cursor: pointer;">
                        <img src="../images/shut.png" id="img" onclick="jQuery('.box').hide()" style="margin: 10px;" /></a>
                </div>
            </div>
        </div>
    </section>
    <script>


     var cid=0;
        function addcate(ClsId)
        {
            cid=ClsId;
            $("#hid").val("");
            $("#box1").css("display", "block");
           
        }
        function xiugai(ClsId,ParentId) {
            //alert(ParentId);
            $.ajax({
                url: "../data/data.aspx",
                type: 'POST',
                data: {
                    type: 'getCateList',
                    cid: ClsId
                },
                success: function (result) {
                    if (result == 2) {
                        alert("获取配置信息失败！");

                    }
                    else {
                        var json = JSON.parse(result);
                        addcate();
                        $("#txtName").val(json.Clsname);
                        $("#txtIntro").val(json.Description);
                        $("#txtOrderby").val(json.orderby);
                        $("#hid").val(ClsId);
                        $("#hid1").val(ParentId);
                    }
                }
            });
        }
        function queding()
        {
            var txtName = $("#txtName").val();
            //alert(txtName);
            if (txtName == "") {
                alert("分类名称不能为空！");
                return;
            }
            var txtIntro = $("#txtIntro").val();
            //alert(txtIntro);
            if (txtIntro == "") {
                alert("描述不能为空！");
                return;
            }
            var txtOrderby = $("#txtOrderby").val();
            //alert(txtOrderby);
            var pid = $("#hid").val();
            var ParentId = $("#hid1").val();
            if (pid == "") {
            $.ajax({
                url: "../data/data.aspx",
                type: 'POST',
                data: {
                    type: 'AddCateList',
                    parentid:cid,
                    txtName: txtName,
                    txtIntro: txtIntro,
                    txtOrderby:txtOrderby
                },
                success: function (result) {
                    if (result == 1) {
                        alert("添加成功！");
                        window.location.href = "cateList.aspx";
                    }
                    else if (result == 2) {
                        alert("添加失败！");
                        window.location.href = "cateList.aspx";
                    }
                    else if (result == 3) {
                        alert("二级分类最多只能添加4个！");
                        window.location.href = "cateList.aspx";
                    }
                }
            });
           
            } 
            else{
            $.ajax({
                url: "../data/data.aspx",
                type: 'POST',
                data: {
                    type: 'updateCateList',
                    clsid:pid,
                    parentid:ParentId,
                    txtName: txtName,
                    txtIntro: txtIntro,
                    txtOrderby:txtOrderby
                },
                success: function (result) {
                    if (result == 1) {
                        alert("修改成功！");
                        window.location.href = "cateList.aspx";
                    }
                    else if (result == 2) {
                        alert("修改失败！");
                        window.location.href = "cateList.aspx";
                    }
                }
            });  
            }
        }
      
               
       
        var isSubmitDone = true;
        var isConfirm = false;
        function fnDel(cid,shopid) {
            var s=<%= shopid %>;
           
            if (!isConfirm) {
                var callback = function () { fnDel(cid,s); }
                fnShowConfirm("您确定删除该分类吗？", callback)
                return;
            }

            if (!isSubmitDone) return;
            isSubmitDone = false;
           
            $.getJSON(
              "/data/product.ashx?type=delCls&cid=" + cid + "&sid="+s,
              function (msg) {
                  debugger;
                  if (msg.flag == 1) {
                      fnShowMsg("删除成功~", 1);
                      $(".m-catelist").find("li[cid='" + cid + "']").fadeOut();
                      window.location.href = "cateList.aspx";
                  } else if (msg.flag == 0) {
                      fnShowMsg("该分类下有商品信息，无法删除哦~");
                  } else {
                      fnShowMsg("删除失败~");
                  }
                  isSubmitDone = true;
                  isConfirm = false;
              }
            );
        }

    </script>
</asp:Content>

