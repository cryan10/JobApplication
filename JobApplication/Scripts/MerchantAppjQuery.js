$(document).ready(function () {

    //this code initializes that the page, when loaded, has partner sections displayed. Other display sections based on user choice, however, are still hidden on page load.
    //initial sections hidden when page loads
    $('#crimeExplanation').hide();



    //Checks if user has crime issues. If yes, explanation is necessary
    $('#crimeCheck').click(function () {
        if ($('#crimeCheckDropDown').val() == "Yes") {

            $('#crimeExplanation').show();
        }
        else {
            $('#crimeExplanation').hide();
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

    //autofill code feature for signature

    $("#applicantLastName").on("keyup", function () {
        var $FirstName = $('#applicantFirstName').val();
        var $MiddleName = $('#applicantMiddleName').val();
        var $LastName = $(this).val();

        var $FullName = $FirstName.concat(" ", $LastName);
        $('#signatureFullName').val($FullName);
        document.getElementById("signatureFullName").innerHTML = $FullName;
    });
});