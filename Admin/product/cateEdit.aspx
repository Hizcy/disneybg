<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="cateEdit.aspx.cs" Inherits="product_cateEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="Server">
    <title>分类编辑</title>
    <link href="/css/product.css" rel="stylesheet" />
    <script src="/js/ajaxfileupload.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="Server">
    <div class="page_title">
        <h2><strong>商品分类编辑</strong><a class="fr top_rt_btn" href="cateList.aspx">所有分类</a></h2>
    </div>
    <ul class="ulColumn2">
        <li>
            <span class="item_name" style="width: 120px;">分类名称：</span>
            <input id="txtName" type="text" class="textbox textbox_295" placeholder="请输入分类名称" runat="server" />
        </li>
        <li>
            <input type="file" name="txtUpload" id="fFile" onchange="return ajaxFileUpload()" style="display: none" />
            <span class="item_name" style="width: 120px;">分类图片：</span>
            <% =strImgs%>
            <label class="uploadImg" onclick="return goUpload()">
                <span>上传图片</span>
            </label>

        </li>
        <li>
            <span class="item_name" style="width: 120px;">描述：</span>
            <input id="txtIntro" type="text" class="textbox textbox_295" placeholder="请输入用于分享的文字描述" runat="server" />

        </li>
        <li>
            <span class="item_name" style="width: 120px;">权重：</span>
            <input id="txtOrderby" type="text" class="textbox textbox_125" runat="server" />

        </li>

        <li>
            <span class="item_name" style="width: 120px;">父类：</span>
            <asp:DropDownList ID="ddl_Category" runat="server"></asp:DropDownList><span class="errorTips">暂无，备用</span>

        </li>
        <li>
            <span class="item_name" style="width: 120px;"></span>

            <asp:Button ID="btn_Submit" runat="server" Text="提交" class="link_btn larger" OnClick="btn_Submit_Click" OnClientClick="return fnBeforeSubmit();" />
        </li>
    </ul>
    <asp:HiddenField ID="txt_img" runat="server" />
    <script>

        function fnBeforeSubmit() {

            debugger;
            getimghtml();
            try {
                var isCorrct = true;
                $(".ulColumn2").find("input[type='text']").each(function () {
                    $(this).next(".errorTips").remove();
                    if (!$(this).val().length) {
                        $(this).after('<span class="errorTips">请正确输入' + $(this).prev("span").html().replace("：", "") + '</span>');
                        isCorrct = false;

                    } else {
                        if ($(this).attr("id").search("txtOrderby") >= 0) {
                            if (isNaN(parseInt($(this).val()))) {
                                $(this).after('<span class="errorTips">请正确输入' + $(this).prev("span").html().replace("：", "") + '</span>');
                                isCorrct = false;
                            }
                        }
                    }
                });


            } catch (e) {
                alert(e);
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
                    $(".uploadImg").removeClass("load"); debugger;
                    if (msg.succ) {
                        $(".uploadImg").before("<div class=\"uploadImgitem\"><img src=\"" + msg.image + "\" /><span onclick=\"fnDelImg(this)\">删除</span></div>");
                        if ($(".uploadImgitem").length >= 1) {
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
            if ($(".uploadImgitem").length >= 1) {
                $(".uploadImg").css("display", "none")
            } else { $(".uploadImg").css("display", "") }
            return false;
        }
           

        function goUpload() {
            if ($(".uploadImgitem").length > 0) {
                $(".uploadImg").css("display", "none").after('<span class="errorTips">仅限一张图片~</span>');
                return;
            } 

            $("#fFile").click();
            return false;
        }
    </script>
</asp:Content>

