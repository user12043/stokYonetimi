function collapseMenu(index) {
    $("#navbar" + index).toggleClass("collapsed");
}

function collapseWidth(width) {
    if (width < 700) {
        console.log("HAHA");
        $("#navbar1").addClass("collapsed");
    } else {
        $("#navbar1").removeClass("collapsed");
    }
}

collapseWidth($(window).width());

$(window).on("resize", function() { collapseWidth($(window).width()) });