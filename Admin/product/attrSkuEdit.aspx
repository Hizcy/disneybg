<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="attrSkuEdit.aspx.cs" Inherits="product_attrSkuEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="header" Runat="Server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" Runat="Server">
    <link href="/css/sku.css?v=09" rel="stylesheet" />
     <div class="page_title">
            <h2><strong>商品规格</strong></h2>
        </div>
     <div class="proitem" id="sku_opeart">
       
        <div class="proitem_content sku_allkind">            
            <div class="sku_opeart">
                <input type="button" value="添加规格+" class="l" /></div>
        </div>
    </div>
      <div onclick="fnSubmit()" class="u-btn">完成</div>

    <asp:HiddenField ID="hfJsonData" runat="server" />
    <script>

        var sku_kind_index = 0, sku_item_index = 0;

        var arr_SKU_Data = [],arr_OptList = [];
       
        var opt_skuitems = "";

        var productid;
       

        $(function () {
           
            productid =<%=productId %>

            fnInitPage();

        });

        function fnInitPage() {

            fnGetAttrSKUList();

            $("#sku_opeart .sku_opeart").on("click", function () {
                sku_kind_index++;
                var html = $("#tpl_add_skuitem").html().replace(/{#list}/g, opt_skuitems);
                $(this).before(html);

                if (!$(".sku_typeitem").last().data("type_id")) {
                    $(".sku_typeitem").last().data("type_id", sku_kind_index)
                }
                $(".sku_typeitem").last().data("ProductId", productid)

                $(".sku_type").on("mouseenter", function (e) {
                    $(e.target).find(".sku_del").removeClass("none");
                });
                $(".sku_typecontent").on("mouseenter", function (e) {
                    $(e.target).find("li span").css({ "display": "block" });
                });
                $(".sku_typeitem").find("select").change(function () {
                    if ($(this).val() == -1) {
                        $(this).siblings(".sku_timelyinput").removeClass("none").find("input[type='text']").val("")
                    } else {
                        var skuid = $(this).val();
                        var skuval = $(this).find("option:selected").text();
                        var temparr = [];
                        $(".sku_typeitem").each(function () {
                            if ($(this).data("AttrSkuVal") || $(this).data("attrskuval")) {
                                temparr.push($(this).data());
                            }
                        });

                        $(this).removeClass("error").siblings(".error-message").remove();
                        if (!isExist(temparr, skuval, "AttrSkuVal", "attrskuval")) {
                            $(this).addClass("done").siblings(".sku_timelyinput").addClass("none");
                            $(this).parents(".sku_typeitem").data("AttrSkuId", $(this).val());
                        } else {
                            $(this).addClass("error").parents(".sku_type").append('<span class="error-message">规格名称不能重复！</span>');
                            $(this).parents(".sku_typeitem").data("AttrSkuId", "");
                        }
                    } return false;
                });


            })
            $("#sku_opeart  .sku_allkind").on("click", function (e) {
                var target = e.target;
                if (target.className == "sku_del") { //删除整个按钮                       
                    $(target).parents(".sku_typeitem").remove();
                } else if ($(target).parents(".sku_typecontent").length && target.nodeName.toUpperCase() == "SPAN") { //删除单个                   
                    var targetid = $(target).parent("li").data("item_id");
                    var list = $(target).parents(".sku_typeitem").data("list") || []; //更新数据
                    for (var i = 0; i < list.length; i++) {
                        if (list[i].item_id == parseInt(targetid)) {
                            list.splice(i, 1); break;
                        }
                    }
                    $(target).parent("li").remove();


                } else if (target.className == 'sku_btn_additem') { //添加规格下数据
                    var itemname = $(target).prev("input").removeClass("error").val();
                    if (!!itemname) {
                        var temparr = $(target).parents(".sku_typeitem").data("list") || [];
                        debugger;
                        if (!isExist(temparr, itemname, "attrskuval", "AttrSkuVal")) {
                            sku_item_index++;
                            var obj = $('<li  data-attrskuval="' + itemname + '" data-item_id="' + sku_item_index + '">' + itemname + '<span>×</span></li>')
                            $(target).parents("li").before(obj); $(target).prev("input").val("");

                            var list = $(target).parents(".sku_typeitem").data("list") || []; //更新数据
                            console.log(list.length);
                            list.push(obj.data());
                            $(target).parents(".sku_typeitem").data("list", list);

                        } else {
                            $(target).prev("input").addClass("error")
                        }


                    }

                }
            });

            $("#sku_opeart  .sku_allkind").on("mouseleave", function (e) {
                $(".sku_allkind").find(".sku_del").addClass("none");
                $(".sku_typecontent").find("li span").css({ "display": "none" });
            });

            $("#sku_opeart  .sku_allkind").bind("keydown", function (e) {// 兼容FF和IE和Opera                
                var theEvent = e || window.event;
                var code = theEvent.keyCode || theEvent.which || theEvent.charCode;
                if (code == 13) {
                    debugger;
                    if ($(e.target).next(".sku_btn_additem").length) {
                        $(e.target).next(".sku_btn_additem").click();
                        return false;
                    }
                }

            });
        }

        function fnGetAttrSKUList() {   //获取系统规格信息
            $.post("attrSkuEdit.aspx",  {
                cmd: "GetAttrSKUList"
            }, function (data) {
                arr_OptList = data;
                debugger;
                for (var i = 0; i < arr_OptList.length; i++) {
                    opt_skuitems += '<option value="' + arr_OptList[i].Id + '">' + arr_OptList[i].AttrName + '</option>';
                }
                fnGetAttrValueSKUListByProcuctId();

            }, "json");

        }
        function fnGetAttrValueSKUListByProcuctId() {//获取当前商品所有规格数据
            $.post("attrSkuEdit.aspx", {
                cmd: "GetAttrValueSKUListByProcuctId", productid: productid
            }, function (data) {
                if (data != null && data.length > 0) {

                    var arr = [], obj = {};
                    obj = { "Id": data[0].AttrSkuId, "list": [] };
                    obj.list.push(data[0]);
                    arr.push(obj);
                    for (var i = 1; i < data.length; i++) {
                        for (var j = 0; j < arr.length; j++) {
                            if (data[i].AttrSkuId == arr[j].Id) {
                                arr[j].list.push(data[i]); break;
                            }
                            if (j == arr.length - 1) {
                                obj = { "Id": data[i].AttrSkuId, "list": [] };

                                obj.list.push(data[i]);
                                arr.push(obj); break;
                            }
                        }
                    }
                    fnInitData(arr);
                }
            }, "json");
        }

        function fnInitData(obj) {
            arr_SKU_Data = obj || [];
            var html = "", list_html = "";
            var arr_list = [];
            for (var i = 0; i < arr_SKU_Data.length; i++) {
                list_html = "";
                for (var j = 0; j < arr_SKU_Data[i].list.length; j++) {
                    list_html += '<li  data-attrskuval="' + arr_SKU_Data[i].list[j].AttrSkuVal + '" data-id="' + (arr_SKU_Data[i].list[j].id || 0) + '">' + arr_SKU_Data[i].list[j].AttrSkuVal + '</li>'
                        
                }
                for (var k = 0; k < arr_OptList.length; k++) {   //手动循环出规格的名称
                    if (arr_SKU_Data[i].Id == arr_OptList[k].Id) {
                        arr_SKU_Data[i].AttrSkuVal = arr_OptList[k].AttrName;
                        break;
                    }
                    arr_SKU_Data[i].AttrSkuVal = "未知";
                }
                html = $("#tpl_init_skuitem").html().replace(/{#name}/g, arr_SKU_Data[i].AttrSkuVal).replace(/{#list}/g, list_html);
                $("#sku_opeart .sku_opeart").before(html);
                if (!$(".sku_typeitem").last().data("AttrSkuId")) {
                    $(".sku_typeitem").last().data("AttrSkuId", arr_SKU_Data[i].Id);
                    $(".sku_typeitem").last().data("AttrSkuVal", arr_SKU_Data[i].AttrSkuVal);
                    $(".sku_typeitem").last().data("list", arr_SKU_Data[i].list);
                }
            }
        }

        function fnSubmit() {
            var result_json = "";
            var temp_list = [];
            var  skuid = 0;
            $(".sku_typeitem").each(function () {
                temp_list = $(this).data("list");
                skuid = $(this).data("AttrSkuId");
                debugger
                for (var i = 0; i < temp_list.length; i++) {
                    if ($(this).data("type_id") || temp_list[i].item_id) {//说明是新添加的一个规格
                        result_json += '{"ProductId":' + productid + ',"AttrSkuId":' + skuid + ',"AttrSkuVal":"' + temp_list[i].attrskuval + '"},';
                    }
                }
            });
            if (!!result_json) {
                result_json = result_json.substr(0, result_json.length - 1);
                result_json = "[" + result_json + "]"

                console.log(result_json);

                $.post("attrSkuEdit.aspx", {
                    cmd: "InsertAttrSKU", data: escape(result_json)
                }, function (data) {
                    if (data == 1) {
                        fnShowMsg("添加成功，正在跳转~");
                        setTimeout(function () {
                            location.href = "skuEdit.aspx?proid=" + productid;
                            return false;
                        }, 500);
                    }
                }, "json");
            } else {
                location.href = "skuEdit.aspx?proid=" + productid;
            }
           
        }


        function isExist(arr, name,attr,attr2) {
            var isexist = false;
            for (var i = 0; i < arr.length; i++) {
                if ((arr[i][attr] || arr[i][attr2]) === name) {
                    isexist = true; break;
                }
            }
            return isexist;
        }
       
    </script>
    <script  type="text/html" id="tpl_add_skuitem">
        <div class="sku_typeitem">
            <div class="sku_type">
                <select>
                    <option value="-1">-请选择-</option>
                    {#list}
                </select>
               <span class="sku_del none">×</span>
            </div>
            <div class="sku_typecontent">
                <ul>                
                    <li ><div class="sku_timelyinput "> <input type="text" placeholder="规格名称" /><input type="button" class="sku_btn_additem" value="添加+" /></li>
                </ul>
            </div>
         </div>
    </script>
    <script  type="text/html" id="tpl_init_skuitem">
        <div class="sku_typeitem">
            <div class="sku_type">                
                <div class="sku_timelyinput done">
                    <input type="text" placeholder="规格名称" value="{#name}"/>
                </div>
            </div>
            <div class="sku_typecontent">
                <ul>                
                   {#list}<li ><div class="sku_timelyinput "> <input type="text" placeholder="规格名称" /><input type="button" class="sku_btn_additem" value="添加+" /></li>
                </ul>
            </div>
         </div>
    </script>
</asp:Content>

