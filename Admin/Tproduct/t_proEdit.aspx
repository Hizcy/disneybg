<%@ Page Title="" Language="C#" ValidateRequest="false" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="t_proEdit.aspx.cs" Inherits="Tproduct_t_proEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="Server">
    <title>编辑商品</title>
    <link href="/css/product.css" rel="stylesheet" type="text/css" />
    <link href="/js/umeditor1_2_2-utf8-net/themes/default/css/umeditor.css" type="text/css" rel="stylesheet" />
    <link href="../wangEditor/dist/css/wangEditor.min.css" rel="stylesheet" />
    <script src="../wangEditor/dist/js/lib/jquery-1.10.2.min.js"></script>
    <script src="/js/ajaxfileupload.js"></script>
    <link href="../css/wangeditor.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="Server">
    <section>
        <div class="page_title">
            <h2><strong>添加商品信息</strong></h2>
        </div>
        <ul class="ulColumn2">
            <li>
                <span class="item_name" style="width: 120px;">商品名称：</span>
                <input id="txtName" type="text" class="textbox textbox_295" placeholder="请输入商品名称" runat="server" />
            </li>
            <li>
                <span class="item_name" style="width: 120px;">商品简介：</span>
                <asp:TextBox ID="txtIntro" runat="server" class="textbox textbox_295" Rows="3" TextMode="MultiLine"></asp:TextBox>

            </li>
            <li>
                <span class="item_name" style="width: 120px;">库存：</span>
                <input id="txtStock" type="text" class="textbox textbox_125" runat="server" />(如果添加SKU，本设置将失效)
                元
            </li>
            <li>
                <span class="item_name" style="width: 120px;">原价：</span>
                <input id="txtOriginPrice" type="text" class="textbox textbox_125" runat="server" />
                元
            </li>
            <li>
                <span class="item_name" style="width: 120px;">销售价格：</span>
                <input id="txtPrize" type="text" class="textbox textbox_125" runat="server" />
                元
            </li>
            <li>
                <span class="item_name" style="width: 120px;">成本价格：</span>
                <input id="txtCostPrize" type="text" class="textbox textbox_125" runat="server" />
                元
            </li>
            <li>
                <span class="item_name" style="width: 120px;">组团价格：</span>
                <input id="txtGroupPrize" type="text" class="textbox textbox_125" runat="server" />
                元
            </li>
            <li>
                <span class="item_name" style="width: 120px;">组团人数：</span>
                <input id="txtGroupPeople" type="text" class="textbox textbox_125" runat="server" />
                人
            </li>
            <li>
                <span class="item_name" style="width: 120px;">佣金：</span>

                <input id="rb_isCommission_0" type="radio" name="rb_isCommission" value="1" checked="checked"><label for="rb_isCommission_0">默认佣金（（售价-成本价）*0.8）</label>

            </li>
            <li>
                <span class="item_name" style="width: 120px;"></span>
                <input id="rb_isCommission_1" type="radio" name="rb_isCommission" value="1"><label for="rb_isCommission_1">启用独立佣金</label>
                <input id="txtCommission" type="text" class="textbox xs textbox_40" value="0" runat="server" />元
            </li>
            <li>
                <span class="item_name" style="width: 120px;">权重：</span>
                <input id="txtOrderby" type="text" class="textbox textbox_125" runat="server" />

            </li>
            <li>
                <span class="item_name" style="width: 120px;">是否最新：</span>
                <span class="inlinebolck">
                    <asp:RadioButtonList ID="RadioButtonList2" runat="server" BorderStyle="None" RepeatDirection="Horizontal" ValidationGroup="radio_isnew">

                        <asp:ListItem Value="0">否</asp:ListItem>
                        <asp:ListItem Value="1">是</asp:ListItem>
                    </asp:RadioButtonList>

                </span>
            </li>
            <li>
                <span class="item_name" style="width: 120px;">是否最热：</span>
                <span class="inlinebolck">
                    <asp:RadioButtonList ID="RadioButtonList3" runat="server" BorderStyle="None" RepeatDirection="Horizontal" ValidationGroup="radio_ishot">

                        <asp:ListItem Value="0">否</asp:ListItem>
                        <asp:ListItem Value="1">是</asp:ListItem>
                    </asp:RadioButtonList>

                </span>
            </li>
            <li>
                <input type="file" name="txtUpload" id="fFile" onchange="return ajaxFileUpload()" style="display: none" />
                <span class="item_name" style="width: 120px;">上传图片：</span>
                <% =strImgs%>
                <label class="uploadImg" onclick="return goUpload()">
                    <span>上传图片</span>
                </label>
            </li>

            <li>
                <span class="item_name" style="width: 120px;">商品类型：</span>
                  <asp:DropDownList ID="ddl_Category" runat="server"  ></asp:DropDownList>
                <%--  <span class="item_name" style="width: 120px;">二级类型：</span>--%>
    <%--            <asp:DropDownList ID="ddl_produclsid" runat="server">
                          <asp:ListItem Value="0">--请选择--</asp:ListItem>
                </asp:DropDownList>--%>
            </li>
            <li>
                <span class="item_name" style="width: 120px;">商品状态：</span>
                <span class="inlinebolck">
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server" BorderStyle="None" RepeatDirection="Horizontal" ValidationGroup="radio_status">

                        <asp:ListItem Value="2">上架</asp:ListItem>
                        <asp:ListItem Value="-2">下架</asp:ListItem>
                    </asp:RadioButtonList></span>


            </li>

            <li>
                <span class="item_name" style="width: 120px; margin-right: -121px;">商品描述：</span>
                <div id="editor-container" class="container">
                    <div id="editor-trigger">

                        <%--   <%if (productId>0){ %>
                          <%=htmlIntro%>
                        <%}else{ %>
                         <p>请输入内容</p>
                        <%} %>--%>
                    </div>
                    <%--   <button id="btn1">获取内容</button>--%>
                </div>
                <%--  <div class="m-ueditor">
                    <script type="text/plain" id="myEditor" style="width: 70%; height: 140px;">
                       <%=htmlIntro%>
                    </script>
                </div>--%>
            </li>

            <li>
                <span class="item_name" style="width: 120px;"></span>
                <asp:Button ID="btn_Submit" runat="server" Text="提交" class="link_btn larger" OnClientClick="return fnBeforeSubmit();" OnClick="btn_Submit_Click" />
            </li>

        </ul>
        <asp:TextBox ID="selectcity" runat="server" style="display:none" ></asp:TextBox>
        <asp:TextBox ID="selecteurozone" runat="server" style="display:none" ></asp:TextBox>
        <asp:HiddenField ID="txt_img" runat="server" />
        <asp:HiddenField ID="html_ue" runat="server" />
        <asp:HiddenField ID="hidden_isCommission" runat="server" />
        <script src="../wangEditor/dist/js/wangEditor.js"></script>
        <script src="../wangEditor/test/plupload/lib/plupload/plupload.full.min.js"></script>
        <script src="../js/wangeditor2.js"></script>
        <%--        <script type="text/javascript" charset="utf-8" src="/js/umeditor1_2_2-utf8-net/umeditor.config.js"></script>
        <script type="text/javascript" charset="utf-8" src="/js/umeditor1_2_2-utf8-net/umeditor.min.js"></script>--%>
        <script>

        function fnBeforeSubmit() {

            //var html = UM.getEditor('myEditor').getContent();
            // 获取编辑器区域完整html代码
            var html = editor.$txt.html();
            //alert(html);
            $("#<%=html_ue.ClientID%>").val((html));
                $("#mainContent_html_ue").val((html));
                console.log(html);
                html = "";
                for (var i = 0; i < $(".uploadImgitem").length; i++) {
                    if (i > 0) html += ',';
                    html += $(".uploadImgitem").eq(i).find("img").attr("src");
                }
                console.log(html);
                $("#<%=txt_img.ClientID%>").val(html);
                $("#mainContent_txt_img").val(html);

                html = $("#rb_isCommission_1").is(":checked") ? 1 : 0;
                $("#hidden_isCommission").val(html);
                $("#<%=hidden_isCommission.ClientID%>").val(html);
                var s = "";
                debugger;
                try {
                    var isCorrct = true;
                    $(".ulColumn2").find("input[type='text']").each(function () {
                        $(this).next(".errorTips").remove();
                        if (!$(this).val().length && $(this).attr("id") != undefined) {
                            
                            $(this).after('<span class="errorTips">请正确输入' +($(this).prev("span").html()||"").replace("：", "") + '</span>');
                            s = $(this).attr("class");
                            isCorrct = false;

                        } else {
                            if ($(this).attr("id").search("txtCostPrize") >= 0 || $(this).attr("id").search("txtOrderby") >= 0 || $(this).attr("id").search("txtPrize") >= 0 || $(this).attr("id").search("txtCommission") >= 0|| $(this).attr("id").search("txtGroupPrize") >= 0|| $(this).attr("id").search("txtGroupPeople") >= 0) {
                                if (isNaN(parseInt($(this).val()))) {
                                    $(this).after('<span class="errorTips">请正确输入' + ($(this).prev("span").html()||"").replace("：", "") + '</span>');
                                    isCorrct = false;
                                }
                            }
                        }
                    });
                    $(".ulColumn2").find("select").each(function () {
                        if ($(this).val() == -1) {
                            $(this).after('<span class="errorTips">请正确输入' + ($(this).prev("span").html()||"").replace("：", "") + '</span>');
                            isCorrct = false;
                        }
                    });
                    if (!$(".ulColumn2").find("input[type='radio']:checked").val()) {
                        $(".ulColumn2").find("input[type='radio']").eq(0).click();
                    }
                    
                    if ($("#rb_isCommission_1").is(":checked")) {
                        var m = $("#rb_isCommission_1").siblings("input").val();
                        if (!m || isNaN(parseInt(m))) {
                            $("#rb_isCommission_1").parent("li").append('<span class="errorTips">请输入独立佣金</span>');
                            isCorrct = false;
                        }
                    } else {
                        $("#rb_isCommission_1").siblings("errorTips").remove();
                    }
                    
                } catch (e) {
                    console.log(e)
                    return;
                }
               

                if (!isCorrct) { return false; } else { return; }

                return false;

            }

            function ajaxFileUpload() {
                var shopid=<%= shopid%>||0;
                var fileName = $("#fFile").val();
                if (fileName == "") {
                    alert("先选择图片文件！");
                    return false;
                }

                var extName = fileName.substr(fileName.lastIndexOf(".")).toLowerCase();
                if (extName == ".jpg" || extName == ".png" || extName == ".gif") {

                }
                else {
                    alert("上传图片格式不正确！");
                    return;
                }

                $(".uploadImg").addClass("load");

                $.ajaxFileUpload(
                {
                    url: '/data/UploadHandler.ashx',
                    type: 'post',
                    secureuri: false,
                    fileElementId: 'fFile',
                    dataType: 'json',
                    data: {"shopid":shopid},
                    beforeSend: function () {
                        //alert(1);
                    },
                    complete: function () {

                        //alert(11);
                    },
                    success: function (msg) {
                        $(".lilast").removeClass("load"); debugger;
                        if (msg.succ) {
                            $(".uploadImg").before("<div class=\"uploadImgitem\"><img src=\"" + msg.image + "\" /><span onclick=\"fnDelImg(this)\">删除</span></div>");
                            if ($(".uploadImgitem").length >= 5) {
                                $(".uploadImg").css("display", "none")
                            } else { $(".uploadImg").css("display", "") }

                        } else {
                            alert(msg.msg);
                        }

                    },
                    error: function (data, status, e) {
                        alert("上传出错！");
                    }
                });

                return false;

            }

            function getimghtml() {
                var html = "";
                for (var i = 0; i < $(".uploadImgitem").length; i++) {
                    if (i > 0) html += ',';
                    html += $(".uploadImgitem").find("img").attr("src");
                }
                debugger;
                $("#<%=txt_img.ClientID%>").val(html);
                $("#mainContent_txt_img").val(html);
            }


            function fnDelImg(t) {
                $(t).parents(".uploadImgitem").remove();
                return false;
            }
            var k=0;
            function goUpload() {
                
                $("#fFile").click();
                return false;
            }
            $(function () {
                var proid="<%=productId%>";
                if(proid>0)
                {
                }else{
                    editor.$txt.html('<p><br></p>');
                }
                //实例化编辑器
                var um = UM.getEditor('myEditor');
                um.addListener('blur', function () {
                    $('#focush2').html('编辑器失去焦点了')
                });
                um.addListener('focus', function () {
                    $('#focush2').html('')
                });
                var ism= $("#<%=hidden_isCommission.ClientID%>").val()||$("#hidden_isCommission").val();
                if (ism == "0") { $("#rb_isCommission_0").click(); } else if (ism == "1") { $("#rb_isCommission_1").click(); }
                

            })

        </script>
    </section>
</asp:Content>

