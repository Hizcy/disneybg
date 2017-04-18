<%@ Page Language="C#" AutoEventWireup="true" CodeFile="demo.aspx.cs" Inherits="product_demo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <script src="../js/jquery.js"></script>
    <style>
        .sku-atom {
            border: 1px solid #AAA;
            padding: 4px;
            display: inline-block;
            margin-right: 10px;
            margin-bottom: 5px;
            margin-top: 5px;
            width: 80px;
            vertical-align: middle;
            text-align: center;
            position: relative;
            border-radius: 4px;
            cursor: pointer;
        }

            .sku-atom span {
                padding-right: 25px;
            }

        .atom-close {
            position: absolute;
            z-index: 2;
            top: 4px;
            right: 2px;
            width: 18px;
            height: 18px;
            font-size: 18px;
            line-height: 18px;
            color: #fff;
            text-align: center;
            cursor: pointer;
            background: rgba(153,153,153,0.6);
            border-radius: 10px;
        }

        .sku-group-remove {
            position: absolute;
            top: 2px;
            right: 10px;
            color: #fff;
            text-align: center;
            cursor: pointer;
            width: 18px;
            height: 18px;
            font-size: 14px;
            line-height: 18px;
            background: rgba(153,153,153,0.6);
            border-radius: 10px;
            text-indent: 0;
        }

        .sku-group-title {
            position: relative;
        }

        .sku-title {
            padding: 5px;
        }
    </style>
</head>
<body>
    <div class="sku-panel">
        <div class="sku-group">
            <div class="sku-group-title">
                属性：<select class="sku-select" name="sku[]">
                    <option value="19">颜色</option>
                    <option value="20">尺寸</option>
                    <option value="30">规格</option>
                    <option value="40">种类</option>
                </select>
                <input class="sku-new-value" type="text" value="" />
                <input id="addsku" type="button" value="添加属性值" />

                <a class="sku-group-remove">×</a>

            </div>

            <div class="sku-atom-panel">
            </div>
        </div>

    </div>

    <div class="addsku">
        <a id="addnewsku" href="javascript:void(0);">+添加属性</a>
    </div>
    <div>
        <table id="sku-panels">
          
             

        </table>

    </div>
    <script>
        $("#addsku").on("click", function () {
            $err = 0;
            $content = $(this).siblings(".sku-new-value").val();
            $panel = $(this).parent(".sku-group-title").siblings(".sku-atom-panel");
            //不可添加空
            if ($.trim($content) == "") {
                $err = 1;
            }
            //不可重复添加
            $("span").each(function () {
                if ($(this).text() == $content) {
                    $err = 2;
                    return;
                }
            });
            //添加sku-atom元素
            if ($err == 0) {
                $(this).parent(".sku-group-title").siblings(".sku-atom-panel").append(getSkuAtomTemp($content, 19));
                refreshSkuTable();
            } else {
                switch ($err) {
                    case 1: alert("空"); break;
                    case 2: alert("重复"); break;
                }
            }
        });

        $("#addnewsku").on("click", function () {
            $(".sku-panel").append(getSkuGroupTemp);
        });

        function getSkuAtomTemp($content, $skuid) {
            $str = '<div class="sku-atom"><span data-atom-id="' + $skuid + '">' + $content + '</span><div class="atom-close">×</div></div>';
            return $str;
        }

        function getSkuGroupTemp() {
            $str = '<div class="sku-group"><div class="sku-group-title">';
            $str += '属性：<select class="sku-select">';
            $str += '<option value="19">颜色</option>';
            $str += '<option value="20">尺寸</option>';
            $str += '<option value="21">规格</option>';
            $str += '<option value="22">种类</option>';
            $str += '</select>';
            $str += '<input class="sku-new-value" type="text" value="" />';
            $str += '<input id="addsku" type="button" value="添加属性值" />';
            $str += '<a class="sku-group-remove">×</a>';
            $str += '</div><div class="sku-atom-panel"></div></div>';

            return $str;
        }
        function refreshSkuTable() {
            $str=generateTableHead();
            $str += generateTableBody();
            $("#sku-panels").html($str);
        }
        function generateTableHead() {
            $str = '<thead><tr>';
            $str += '<td></td>';
            $str += commonHead();
            $str += '</tr></thead>';

            return $str;
        }
        function generateTableBody() {
            $str = '<tbody><tr>';
            $str += '<td></td>';

            $('')
            $str += commonBody();
            $str += '</tr></thead>';

            return $str;
        }
        function commonHead() {
            $str = '<td>库存</td>';
            $str += '<td>商品编码</td>';
            return $str;
        }
        function commonBody() {
            $str = '<td><input type="text" name="stock_num" /></td>';
            $str += '<td><input type="text" name="productcode"/></td>';
            return $str;
        }
    </script>
</body>
</html>
