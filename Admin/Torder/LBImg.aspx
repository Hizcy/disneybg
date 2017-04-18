<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="LBImg.aspx.cs" Inherits="Torder_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="Server">
    <script src="../js/plupload.full.min.js"></script>
    <style>
        table tr:nth-child(1) td:nth-child(1) {
            text-align: right;
            width: 79px;
        }

        table tr:nth-child(2) td:nth-child(1) {
            text-align: right;
            width: 79px;
        }

        table tr:nth-child(3) td:nth-child(1) {
            text-align: right;
            width: 79px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="Server">
    <section>
        <div class="page_title">
            <h2><strong>设置轮播图</strong></h2>
        </div>
        <table style="width: 1100px">
            <tr>
                <td>图片：</td>
                <td style="width: 339px">
                    <img src="<%=imgUrl %>" onerror="this.src='../images/add.jpg'" id="showimg1" height="150" /></td>
                <td style="width: 339px">
                    <img src="<%=imgUrl2 %>" onerror="this.src='../images/add.jpg'" id="showimg2" height="150" style="<%=imgUrl2==""?"display: none":"" %>" /></td>
                <td style="width: 339px">
                    <img src="<%=imgUrl3 %>" onerror="this.src='../images/add.jpg'" id="showimg3" height="150" style="<%=imgUrl3==""?"display: none":"" %>" /></td>
            </tr>
            <tr>
                <td style="padding: 20px 0px">图片链接：</td>
                <td>
                    <input type="text" style="width: 300px;" id="txtlinkUrl" value="<%=linkUrl %>" /></td>
                <td>
                    <input type="text" style="<%=linkUrl2==""?"display: none":"" %>;width: 300px;" id="txtlinkUrl2" value="<%=linkUrl2 %>" /></td>
                <td>
                    <input type="text" style="<%=linkUrl3==""?"display: none":"" %>;width: 300px; " id="txtlinkUrl3" value="<%=linkUrl3 %>" /></td>
            </tr>
            <tr>
                <td>类型：</td>
                <td colspan="3" style="float: left; padding: 20px 20px">
                    <asp:DropDownList ID="dropimgclslist" runat="server"></asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td></td>
                <td colspan="3" style="float: left; padding: 20px 20px">
                    <input type="button" value="保存" id="btnsave" /></td>
            </tr>
        </table>
        <!--图片-->
        <input type="text" id="hid1" style="display: none" value="<%=imgUrl %>" />
        <!--图片2-->
        <input type="text" id="hid2" style="display: none" value="<%=imgUrl2 %>" />
        <!--图片3-->
        <input type="text" id="hid3" style="display: none" value="<%=imgUrl3 %>" />
        <!--已上传的图片-->
        <%--<input type="text" id="hid2" />--%>
    </section>
    <script>
        $(document).ready(function () {
            uploadfile(1);
            var i = 0;
            var img2 ='<%=imgUrl2%>';
            if (img2 != "") {
                i++;
                uploadfile(2);
            }
            var img3 = '<%=imgUrl2 %>';
            if (img2 != "") {
                i++;
                uploadfile(3);
            }
            //保存事件
            $("#btnsave").click(function () {
                var imgUrl = $("#hid1").val(),imgUrl2 = $("#hid2").val(),imgUrl3 = $("#hid3").val();
                if (imgUrl == "") {
                    alert("请上传图片！");
                    return;
                } 
                var clsId = $("#<%=dropimgclslist.ClientID %>").val(); 
                var linkUrl = $("#txtlinkUrl").val(), linkUrl2 = $("#txtlinkUrl2").val(), linkUrl3 = $("#txtlinkUrl3").val(); 
                $.post("../data/data.aspx", {
                    type: "updateImg", imgUrl: imgUrl, clsid: clsId, linkurl: linkUrl, imgUrl2: imgUrl2, imgUrl3: imgUrl3, linkUrl2: linkUrl2, linkUrl3: linkUrl3
                }, function (result) {
                    if (result == 1) {
                        alert("保存成功！");
                    }
                    else {
                        alert("保存失败！");
                    }
                }) 
            })
            //下拉框改变
            $("#<%=dropimgclslist.ClientID %>").change(function () {
                var clsid = $(this).val();
                $.ajax({
                    url: "../data/data.aspx",
                    type: "POST",
                    dataType:"JSON",
                    data: { type: "showdata", clsid: clsid },
                    success: function (json) { 
                        json = JSON.parse(json); 
                        if (json.MessageBox === "查询数据成功") {
                            $("#showimg1").attr("src", json.imgurl);
                            $("#hid1").val(json.imgurl);
                            $("#txtlinkUrl").val(json.linkurl);
                            if (json.imgurl2 != "") {
                                $("#showimg2").attr("src", json.imgurl2);
                                $("#showimg2").show();
                                $("#hid2").val(json.imgurl2);
                                if (json.linkurl2 != "") {
                                    $("#txtlinkUrl2").val(json.linkurl2);
                                    $("#txtlinkUrl2").show();
                                }
                                else {

                                    $("#txtlinkUrl2").val("");
                                    $("#txtlinkUrl2").hide();
                                }
                                if(i===0)
                                    uploadfile(2);
                            }
                            else {
                                $("#hid12").val("");
                                $("#showimg2").attr("src", "../images/add.jpg");
                                $("#showimg2").hide();
                                $("#txtlinkUrl2").val("");
                                $("#txtlinkUrl2").hide();
                            }
                            if (json.imgurl3 != "") {
                                $("#showimg3").attr("src", json.imgurl3);
                                $("#showimg3").show();
                                $("#hid13").val(json.imgurl3);
                                if (json.linkurl3 != "") {
                                    $("#txtlinkUrl3").val(json.linkurl3);
                                    $("#txtlinkUrl3").show();
                                }
                                else {
                                    $("#txtlinkUrl3").val("");
                                    $("#txtlinkUrl3").hide();
                                }
                                if(i===0 || i===1)
                                    uploadfile(3);
                            }
                            else {
                                $("#hid13").val("");
                                $("#showimg3").attr("src", "../images/add.jpg");
                                $("#showimg3").hide();
                                $("#txtlinkUrl3").val("");
                                $("#txtlinkUrl3").hide();
                            }
                        }
                        else {
                            $("#hid1").val("");
                            $("#showimg1").attr("src", "../images/add.jpg");
                            $("#txtlinkUrl").val("");

                            $("#hid2").val("");
                            $("#showimg2").attr("src", "../images/add.jpg");
                            $("#txtlinkUrl2").val("");
                            $("#showimg2").hide();
                            $("#txtlinkUrl2").hide();

                            $("#hid3").val("");
                            $("#showimg3").attr("src", "../images/add.jpg");
                            $("#txtlinkUrl3").val("");
                            $("#txtlinkUrl3").hide();
                            $("#showimg3").hide();
                        }
                    }
                })
            })
        })

        //实例化图片并上传图片
        function uploadfile(number) {
            var uploader = new plupload.Uploader({//实例化一个plupload上传对象    
                browse_button: 'showimg' + number,
                url: '/upload.ashx',
                flash_swf_url: '../plupload-2.1.9/Moxie.swf',
                silverlight_xap_url: '../plupload-2.1.9/Moxie.xap',
                filters: {
                    mime_types: [ //只允许上传图片文件
                      { title: "图片文件", extensions: "jpg,gif,png" }
                    ]
                }
            });
            uploader.init(); //初始化 
            //绑定文件添加进队列事件
            uploader.bind('FilesAdded', function (uploader, files) {
                previewImage(files[0], function (imgsrc) {
                    $.ajax({
                        url: "../data/updateloads.ashx",
                        type: "POST",
                        data: { base64: imgsrc },
                        success: function (result) {
                            if (result != "null") {
                                $("#showimg" + number + "").attr("src", result);
                                $("#hid"+number+"").val(result);
                                if ($("#showimg" + (parseInt(number) + 1) + "").is(":hidden")) {
                                    $("#showimg" + (parseInt(number) + 1) + "").show();
                                    uploadfile(parseInt(number) + 1);
                                    $("#txtlinkUrl" + (parseInt(number) + 1) + "").show();
                                }
                            }
                            else {
                                $("#hid").val("");
                            }
                        },
                        error: function (XMLHttpRequest, textStatus, errorThrown) {
                            alert("图片上传失败，请联系管理员！");
                        }
                    })
                })
            });
            //plupload中为我们提供了mOxie对象
            //有关mOxie的介绍和说明请看：https://github.com/moxiecode/moxie/wiki/API
            //如果你不想了解那么多的话，那就照抄本示例的代码来得到预览的图片吧
            function previewImage(file, callback) {//file为plupload事件监听函数参数中的file对象,callback为预览图片准备完成的回调函数
                if (!file || !/image\//.test(file.type)) return; //确保文件是图片
                if (file.type == 'image/gif') {//gif使用FileReader进行预览,因为mOxie.Image只支持jpg和png
                    var fr = new mOxie.FileReader();
                    fr.onload = function () {
                        callback(fr.result);
                        fr.destroy();
                        fr = null;
                    }
                    fr.readAsDataURL(file.getSource());
                } else {
                    var preloader = new mOxie.Image();
                    preloader.onload = function () {
                        preloader.downsize(320, 320);//先压缩一下要预览的图片,宽300，高300
                        var imgsrc = preloader.type == 'image/jpeg' ? preloader.getAsDataURL('image/jpeg', 80) : preloader.getAsDataURL(); //得到图片src,实质为一个base64编码的数据
                        callback && callback(imgsrc); //callback传入的参数为预览图片的url
                        preloader.destroy();
                        preloader = null;
                    };
                    preloader.load(file.getSource());
                }
            }
        }

    </script>
</asp:Content>

