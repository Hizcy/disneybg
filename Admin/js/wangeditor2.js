﻿function printLog(title, info) {
    window.console && console.log(title, info);
}

// ------- 配置上传的初始化事件 -------
function uploadInit() {

    // this 即 editor 对象
    var editor = this;
    // 编辑器中，触发选择图片的按钮的id
    var btnId = editor.customUploadBtnId;

    // 编辑器中，触发选择图片的按钮的父元素的id
    var containerId = editor.customUploadContainerId;

    //实例化一个上传对象
    var uploader = new plupload.Uploader({
        browse_button: btnId,  // 选择文件的按钮的id
        url: '../data/upload.ashx',  // 服务器端的上传地址
        flash_swf_url: 'wangEditor/test/plupload/lib/plupload/Moxie.swf',
            sliverlight_xap_url: 'wangEditor/test/plupload/lib/plupload/Moxie.xap',
        filters: {
            mime_types: [
                //只允许上传图片文件 （注意，extensions中，逗号后面不要加空格）
                { title: "图片文件", extensions: "jpg,gif,png,bmp" }
            ]
        }
    });
    //存储所有图片的url地址
    var urls = [];

    //初始化
    uploader.init();

    //绑定文件添加到队列的事件
    uploader.bind('FilesAdded', function (uploader, files) {
        //显示添加进来的文件名
        $.each(files, function (key, value) {

            printLog('添加文件' + value.name);
        });

        // 文件添加之后，开始执行上传
        uploader.start();
    });

    //单个文件上传之后
    uploader.bind('FileUploaded', function (uploader, file, responseObject) {
        //注意，要从服务器返回图片的url地址，否则上传的图片无法显示在编辑器中
        var url = responseObject.response;
        //先将url地址存储来，待所有图片都上传完了，再统一处理
        urls.push(url);

        printLog('一个图片上传完成，返回的url是' + url);
    });

    //全部文件上传时候
    uploader.bind('UploadComplete', function (uploader, files) {
        printLog('所有图片上传完成');

        // 用 try catch 兼容IE低版本的异常情况
        try {
            //打印出所有图片的url地址
            $.each(urls, function (key, value) {
                printLog('即将插入图片' + value);
                //alert(125);
                // 插入到编辑器中
                editor.command(null, 'insertHtml', '<img src="' + value + '" style="max-width:100%;"/>');
            });
        } catch (ex) {
            // 此处可不写代码
        } finally {
            //清空url数组
            urls = [];

            // 隐藏进度条
            editor.hideUploadProgress();
        }
    });

    // 上传进度条
    uploader.bind('UploadProgress', function (uploader, file) {
        // 显示进度条
        editor.showUploadProgress(file.percent);
    });
}


// ------- 创建编辑器 -------
var editor = new wangEditor('editor-trigger');
editor.config.customUpload = true;  // 配置自定义上传的开关
editor.config.customUploadInit = uploadInit;  // 配置上传事件，uploadInit方法已经在上面定义了
editor.create();