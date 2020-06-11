
/// <reference path="../../typings/kendo-ui/kendo-ui.d.ts" />
/// <reference path="../../typings/jquery/jquery.d.ts" />


function change(e) {
    $.ajax({
        url: '/BusParOfBus/GetValueType',
        type: 'POST',
        data: {
            id: e.sender.value()
        },
        cache: false,
        success: function (result) {
            $('#change').val(e.sender.value());
            ShowAllInput();
            HideInputs(result);
        }
    });
}

function HideInputs(res) {

    if (res == 1) {
        $('#divCheck').hide();
        $('#divCheckl').hide();
        $('.dates').hide();
    }
    if (res == 2) {
        $('#divCheck').hide();
        $('#divCheckl').hide();
        $('#count').hide();
        $('#countl').hide();
    }
    if (res== 3) {
        $('#count').hide();
        $('#countl').hide();
        $('.dates').hide();
    }

}
function ShowAllInput() {
    $('.dates').show();
    $('#divCheck').show();
    $('#divCheckl').show();
    $('#count').show();
    $('#countl').show();
}
function error_handler(e) {
    if (e.errors) {
        var message = "Errors:\n";
        $.each(e.errors, function (key, value) {
            if ('errors' in value) {

                $.each(value.errors, function () {
                    message += this + "\n";
                });
            }
        });
        alert(message);
    }
}



  