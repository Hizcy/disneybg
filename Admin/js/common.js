

function fnShowMsg(msg, succ) {
    $(".loading_txt").html(!succ?'<mark>'+msg+'</mark>':"<succ>"+msg+"</succ>");
    $(".loading_area").fadeIn();
    $(".loading_area").fadeOut(1500);
}
function fnShowConfirm(msg,callback) {
    isConfirm = false;
    $("#dlg_Confirm").find(".pop_cont_text").html(msg);
    $("#dlg_Confirm").fadeIn();
    $("#dlg_Confirm").find(".trueBtn").off("click").click(function () {
        debugger;
        $("#dlg_Confirm").fadeOut(); isConfirm = true; isSubmitDone = true;
        if(!!callback) callback();
    });
    $("#dlg_Confirm").find(".falseBtn").off("click").click(function () {
        $("#dlg_Confirm").fadeOut(); isSubmitDone = true;
    });
}
