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

function showMessage(message, type) {
    var $element = $("#pageMessage");
    if (type) {
        $element.addClass("alert-" + type);
    }
    $element.html(message);
    $element.show();
}

function formControl() {
    var username = $("#username").val();
    var password = $("#password").val();
    if (username && password) {
        return true;
    } else {
        showMessage("Boş alan bırakma!", "danger");
    }
    return false;
}

if (window.errorMessage) {
    showMessage(window.errorMessage, "danger");
}

$("#siparisMiktar").keypress(
    function (e) {
        e.preventDefault();
    }
);

$("#siparisMiktar").change(
    function() {
        var value = $(this).val();
        if (value < 0 || isNaN(value)) {
            value = 0;
            $(this).val(0);
        }

        var unit = $("#adetFiyat").val();
        $("#fiyat").val(value * unit);
    }
);