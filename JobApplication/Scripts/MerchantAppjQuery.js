$(document).ready(function () {

    //this code initializes that the page, when loaded, has partner sections displayed. Other display sections based on user choice, however, are still hidden on page load.
    //initial sections hidden when page loads
    $('.bankruptcyYesSpecifics').hide();
    $('#taxExplanation').hide();


    //Checks if user has filed for bankruptcy. If yes, more information is necessary
    $('#bankruptcyCheck').click(function () {
        if ($('#bankruptcyCheckDropDown').val() == "Yes" || $('#bankruptcyCheckDropDown').val() == "Discharged") {

            $('.bankruptcyYesSpecifics').show();
        }
        else {
            $('.bankruptcyYesSpecifics').hide();
        }
    });

    //Checks if user has tax issues. If yes, explanation is necessary
    $('#taxCheck').click(function () {
        if ($('#taxCheckDropDown').val() == "Yes") {

            $('#taxExplanation').show();
        }
        else {
            $('#taxExplanation').hide();
        }
    });

    //Check email address is identical (ie, confirm user entered correct email)
    $("#EmailConfirmTextBox").on("keyup", function () {
        if ($(this).val() == $(Email).val()) {
            $("#checkBox").removeClass("glyphicon-remove").addClass("glyphicon-ok");
        }
        else {
            $("#checkBox").removeClass("glyphicon-ok").addClass("glyphicon-remove");
        }
    });

    $(Email).on("keyup", function () {
        if ($(this).val() == $("#EmailConfirmTextBox").val()) {
            $("#checkBox").removeClass("glyphicon-remove").addClass("glyphicon-ok");
        }
        else {
            $("#checkBox").removeClass("glyphicon-ok").addClass("glyphicon-remove");
        }
    });


    $("#partner1EmailConfirmTextBox").on("keyup", function () {
        if ($(this).val() == $(Partner1Email).val()) {
            $("#partner1checkBox").removeClass("glyphicon-remove").addClass("glyphicon-ok");
        }
        else {
            $("#partner1checkBox").removeClass("glyphicon-ok").addClass("glyphicon-remove");
        }
    });

    $(Partner1Email).on("keyup", function () {
        if ($(this).val() == $("#partner1EmailConfirmTextBox").val()) {
            $("#partner1checkBox").removeClass("glyphicon-remove").addClass("glyphicon-ok");
        }
        else {
            $("#partner1checkBox").removeClass("glyphicon-ok").addClass("glyphicon-remove");
        }
    });

    $("#partner2EmailConfirmTextBox").on("keyup", function () {
        if ($(this).val() == $(Partner2Email).val()) {
            $("#partner2checkBox").removeClass("glyphicon-remove").addClass("glyphicon-ok");
        }
        else {
            $("#partner2checkBox").removeClass("glyphicon-ok").addClass("glyphicon-remove");
        }
    });

    $(Partner2Email).on("keyup", function () {
        if ($(this).val() == $("#partner2EmailConfirmTextBox").val()) {
            $("#partner2checkBox").removeClass("glyphicon-remove").addClass("glyphicon-ok");
        }
        else {
            $("#partner2checkBox").removeClass("glyphicon-ok").addClass("glyphicon-remove");
        }
    });

    //autofill code feature for signatures and for titles
    $("#ceoTitle1").on("keyup", function () {
        $('#ceoTitle2').val($(this).val());
    });


    $("#ceoLastName1").on("keyup", function () {
        var $ceoFirstName = $('#ceoFirstName1').val();
        var $ceoMiddleName = $('#ceoMiddleName1').val();
        var $ceoLastName = $(this).val();

        var $ceoFullName = $ceoFirstName.concat(" ", $ceoMiddleName, " ", $ceoLastName);
        $('#ceoSignatureFullName').val($ceoFullName);
        document.getElementById("ceoSignatureFullName").innerHTML = $ceoFullName;
    });
});