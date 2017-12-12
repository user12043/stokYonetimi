function collapseMenu(index) {
    $("#navbar" + index).toggleClass("collapsed");
}

function collapseWidth(width) {
    if (width < 700) {
        $("#navbar1").addClass("collapsed");
    } else {
        $("#navbar1").removeClass("collapsed");
    }
}

collapseWidth($(window).width());

$(window).on("resize", function() { collapseWidth($(window).width()) });

function formControl() {
    var username = $("#username").val();
    var password = $("#password").val();
    if (username && password) {
        return true;
    } else {
        $("#pageMessage").html("Boş alan bırakma!").show();
    }
    return false;
}