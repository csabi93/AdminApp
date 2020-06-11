/// <reference path="kendo-ui.d.ts" />
/// <reference path="../jquery/jquery.d.ts" />
function change(e) {
    var obj = this.value();
    $.ajax({
        url: '/BusParOfBus/GetValueType',
        type: 'POST',
        data: {
            id: obj
        },
        cache: false,
        success: function (result) {
            $('#change').val(obj);
            $('#date1').show();
            $('#date1l').show();
            $('#date2').show();
            $('#date2l').show();
            $('#divCheck').show();
            $('#divCheckl').show();
            $('#count').show();
            $('#countl').show();
            if (result == 1) {
                $('#date1').hide();
                $('#date1l').hide();
                $('#divCheck').hide();
                $('#divCheckl').hide();
                $('#date2').hide();
                $('#date2l').hide();
            }
            if (result == 2) {
                $('#divCheck').hide();
                $('#divCheckl').hide();
                $('#count').hide();
                $('#countl').hide();
            }
            if (result == 3) {
                $('#count').hide();
                $('#countl').hide();
                $('#date2').hide();
                $('#date2l').hide();
                $('#date1').hide();
                $('#date1l').hide();
            }
        }
    });
}
//# sourceMappingURL=inputvalidation.js.map