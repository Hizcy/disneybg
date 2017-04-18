<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="t_skuEdit.aspx.cs" Inherits="Tproduct_t_skuEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="header" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" Runat="Server">
    <link href="/css/sku.css?v=09" rel="stylesheet" />
    <div class="page_title">
        <h2><strong>商品库存</strong><a class="fr top_rt_btn" href="t_attrSkuEdit.aspx?proId=<%=productId %>">设置产品属性</a></h2>
    </div>
    <div class="proitem">
       
        <div class="proitem_content" id="sku_table">
            <div class="sku_opeart">
                <input type="button" value="设置库存" class="l" />
            </div>
        </div>
    </div>
    <div onclick="fnSubmit()" class="u-btn">提交</div>
    <script>
        var arr_SKU_Data = [], arr_Stock_Data = [], arr_OptList = [];
        var productId = 0;

        $(function () {
            productId =<%=productId %>
            fnInitAttrValueSKUList();
        })


        function fnInitAttrValueSKUList() {

            $.post("t_attrSkuEdit.aspx", {
                cmd: "GetAttrSKUList"
            }, function (data) {
                arr_OptList = data;
            }, "json");

            $.post("t_skuEdit.aspx", {
                cmd: "GetTAttrValueSKUListByProcuctId", productid: productId
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
                }
                fnOrganizeHTML(arr);
                fnGetProductSKUList();

            }, "json");
        }

        function fnGetProductSKUList() {//获取商品的库存信息
            $.post("t_skuEdit.aspx", {
                cmd: "GetProductSKUList", productid: productId
            }, function (data) {
                if (data != null && data.length > 0) {
                    arr_Stock_Data = data;

                    $("#sku_table").find("tbody").find("tr").each(function () {
                        var val = $(this).data("attrvalue");
                        for (var i = 0; i < arr_Stock_Data.length; i++) {
                            if (arr_Stock_Data[i].AttrValue == val || (arr_Stock_Data[i].attrvalue == val)) {

                                $(this).find(".js-price").val(isNaN(parseFloat(arr_Stock_Data[i].price)) ? "0.00" : parseFloat(arr_Stock_Data[i].price).toFixed(2));
                                $(this).find(".js-stock").val(isNaN(parseInt(arr_Stock_Data[i].Stock)) ? "0" : parseInt(arr_Stock_Data[i].Stock));
                                $(this).find(".js-code").val(arr_Stock_Data[i].ProductCode);
                                $(this).data("Id", arr_Stock_Data[i].Id);
                                break;
                            }
                        }


                    });
                }
            }, "json");
        }

        function fnOrganizeHTML(obj) {//组织页面html
            debugger;
            arr_SKU_Data = obj || [];

            var arr = [];
            for (var i = 0; i < arr_SKU_Data.length; i++) {
                arr.push(arr_SKU_Data[i].list);
                for (var k = 0; k < arr_OptList.length; k++) {
                    if (arr_SKU_Data[i].Id == arr_OptList[k].Id) {
                        arr_SKU_Data[i].AttrSkuVal = arr_OptList[k].AttrName;
                        break;
                    }
                    arr_SKU_Data[i].AttrSkuVal = "未知";
                }

            }
            arr.reverse();
            var res = combine(arr);

            //合并单元格
            var row = [];
            var rowspan = res.length;
            for (var n = arr.length - 1; n > -1; n--) {
                row[n] = parseInt(rowspan / arr[n].length);
                rowspan = row[n];
            }
            row.reverse();

            //table tr td
            var str = "";
            var arr_attrvalue = [];
            var len = res[0].length;
            for (var i = 0; i < res.length; i++) {
                var tmp = "";
                for (var j = 0; j < len; j++) {
                    if (i % row[j] == 0 && row[j] > 1) {
                        tmp += "<td rowspan='" + row[j] + "'>" + res[i][j].AttrSkuVal + "</td>";
                    } else if (row[j] == 1) {
                        tmp += "<td>" + res[i][j].AttrSkuVal + "</td>";
                    }
                }
                arr_attrvalue = [];
                for (var k = 0; k < res[i].length; k++) {
                    arr_attrvalue.push(res[i][k].Id);
                }
                str += "<tr data-attrvalue='," + (arr_attrvalue.join(",")) + ",' >" + tmp +
                      /*    '<td>' +
                            '<input  type="text" name="sku_price" class="js-price input-mini"  value="" maxlength="10">' +
                        '</td>' +*/
                        '<td>' +
                            '<input type="text" name="stock_num" class="js-stock input-mini" value="" maxlength="9">' +
                        '</td>' +
                        '<td>' +
                            '<input type="text" name="code" class="js-code input-small" value="">' +
                        '</td>' +
                    "</tr>";
            }

            var th = "", tfoot = "";
            for (var k = 0; k < arr_SKU_Data.length; k++) {
                th += "<th>" + arr_SKU_Data[k].AttrSkuVal + "</th>";
            }
            th = "<thead>" + th + '<th class="th-stock">库存</th><th class="th-code">商家编码</th>' + "</thead>"; //<th class="th-price">价格（元）</th>
            console.log(len)
            if (res.length > 3) {
                tfoot = '<tfoot>' +
                    '<tr>' +
                        '<td colspan="5">' +
                            '<div class="batch-opts">' +
                                '批量设置：<span class="desc"> <span class="js_btn_stock">库存</span></span>' + //<span class="js_btn_price">价格</span>
                                '<div class="sku_timelyinput " style="display:none;"><input type="text" placeholder="" /><input type="button" class="sku_btn_batch_done" value="确定" /><input type="button" class="sku_btn_batch_cancel" value="取消" /></div>' +
                            '</div>' +
                        '</td>' +

                    '</tr>' +
                '</tfoot>';


            }
            str = "<table class='table-sku-stock'>" + th + str + tfoot + "</table>";

            $("#sku_table").html(str);



            $("#sku_table").find(".js_btn_price").on("click", function () {
                $(this).parent().css("display", "none");
                $(this).parent().siblings(".sku_timelyinput").css("display", "inline-block").find("input").attr("placeholder", "请输入价格").attr("batch_type", 1);
            })
            $("#sku_table").find(".js_btn_stock").on("click", function () {
                $(this).parent().css("display", "none");
                $(this).parent().siblings(".sku_timelyinput").css("display", "inline-block").find("input").attr("placeholder", "请输入库存").attr("batch_type", 2);
            })
            $("#sku_table").find(".sku_btn_batch_done").on("click", function () {
                var num = parseInt($(this).siblings("input").val());
                if (isNaN(num) || num < 0) { $(this).siblings("input").val("NAN").addClass("error"); return; }
                if ($(this).siblings("input").attr("batch_type") == "1") { //修改价格
                    $("#sku_table").find(".js-price").val(parseFloat(num).toFixed(2))
                } else if ($(this).siblings("input").attr("batch_type") == "2") { //修改库存
                    $("#sku_table").find(".js-stock").val(num);
                }
                $(this).parent().css("display", "none");
                $(this).parent().siblings(".desc").css("display", "inline-block");

            })
            $("#sku_table").find(".sku_btn_batch_cancel").on("click", function () {
                $(this).parent().css("display", "none");
                $(this).parent().siblings(".desc").css("display", "inline-block");

            })


            $("#sku_table").find(".js-price").change(function () {
                var num = parseInt($(this).val());
                if (isNaN(num) || num < 0) { $(this).val("NAN").addClass("error"); return; }
                $(this).removeClass("error").val(parseFloat($(this).val()).toFixed(2));



            });
            $("#sku_table").find(".js-stock").change(function () {
                var num = parseInt($(this).val());
                if (isNaN(num) || num < 0) { $(this).val("NAN").addClass("error"); return; }
                $(this).removeClass("error");
            });


            return;

        }

        function fnSubmit() {

            var int_prize = 0, int_stock = 0;
            $("#sku_table").find("input").removeClass("error");

            var arrStockInfo = [];
            var isCanSubmit = true;

            $("#sku_table").find("tbody").find("tr").each(function () {
                int_stock = parseInt($(this).find(".js-stock").val());
                if (isNaN(int_stock) || int_stock < 0) { $(this).find(".js-stock").addClass("error"); isCanSubmit = false; return false; }

                $(this).data("stock", int_stock);
                $(this).data("productcode", $(this).find(".js-code").val());

                arrStockInfo.push($(this).data());

            });
            debugger;
            if (!isCanSubmit) return;
            var stock_info = "", update_stock_info = "";
            for (var i = 0; i < arrStockInfo.length; i++) {
                if (arrStockInfo[i].Id) {
                    update_stock_info += '{"Id":' + arrStockInfo[i].Id + ',"ProductId":"' + productId + '","AttrValue":"' + arrStockInfo[i].attrvalue + '","Stock":"' + arrStockInfo[i].stock + '","ProductCode":"' + arrStockInfo[i].productcode + '","Images":""},';
                } else {
                    stock_info += '{"ProductId":"' + productId + '","AttrValue":"' + arrStockInfo[i].attrvalue + '","Stock":"' + arrStockInfo[i].stock + '","ProductCode":"' + arrStockInfo[i].productcode + '","Images":""},';
                }

            }
            stock_info = stock_info.substr(0, stock_info.length - 1);
            stock_info = "[" + stock_info + "]";
            update_stock_info = update_stock_info.substr(0, update_stock_info.length - 1);
            update_stock_info = "[" + update_stock_info + "]";

            var isInsertDone = true, isUpdateDone = true;
            console.log(stock_info);
            console.log(update_stock_info);

            if (!!stock_info) {
                alert(11);
                isInsertDone = false;
                $.post("t_skuEdit.aspx", {
                    cmd: "InsetProductSKU", data: escape(stock_info)
                }, function (data) {
                    if (data == 1) {
                        isInsertDone = true;
                        if (isUpdateDone) {
                            fnShowMsg("保存成功，正在跳转~");
                            setTimeout(function () {
                                location.href = "t_proList.aspx";
                                return false;
                            }, 500);
                        }

                    }
                }, "json");
            }
            if (!!update_stock_info) {
                alert(22);
                isUpdateDone = false;
                $.post("t_skuEdit.aspx", {
                    cmd: "UpdateProductSKU", data: escape(update_stock_info)
                }, function (data) {
                    if (data == 1) {
                        isUpdateDone = true;
                        if (isInsertDone) {
                            fnShowMsg("修改成功，正在跳转~");
                            setTimeout(function () {
                                location.href = "t_proList.aspx";
                                return false;
                            }, 500);
                        }
                    }
                }, "json");
            }




        }


        function combine(arr) {
            var r = [];
            (function f(t, a, n) {
                if (n == 0) return r.push(t);
                for (var i = 0; i < a[n - 1].length; i++) {
                    f(t.concat(a[n - 1][i]), a, n - 1);
                }
            })([], arr, arr.length);
            return r;
        }

    </script>
</asp:Content>


