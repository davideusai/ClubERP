$(function () {

    $.ajaxSetup({ cache: false });

    $(document).on("click", "a[data-modal]", function (e) {

        $(e.target).closest('.btn-group').children('.dropdown-toggle').dropdown('toggle');


        $('#myModalContent').load(this.href, function () {


            $('#myModal').modal({
                keyboard: true
            }, 'show');

            //active les datepicker
            $('.datepicker').datepicker({
                format: 'dd/mm/yyyy'
            });

            bindForm(this);
        });


        return false;
    });

    $(document).on("click", "input[data-modal]", function (e) {

        $(e.target).closest('.btn-group').children('.dropdown-toggle').dropdown('toggle');
        
        $('#myModalContent').load($(this).attr("href"), function () {

           
            $('#myModal').modal({
                keyboard: true
            }, 'show');

            //active les datepicker
            $('.datepicker').datepicker({
                format: 'dd/mm/yyyy'
            });

            bindForm(this);
        });
        
        $('#myModalContent').attr("caller", $(this).attr("id"));

        return false;
    });

    $(document).on('click', '.item-select', function (e) {
        e.preventDefault();
        $('#myModal').modal('hide');
        var value = parseInt($(this).children('.item-value').html());
        $('#' + $('#myModalContent').attr("caller")).val(value);
    })


    $(document).on('click', 'a[data-confirm]', function (ev) {
        var href = $(this).attr('href');


        if (!$('#dataConfirmModal').length) {
            $('body').append('<div id="dataConfirmModal" class="modal" role="dialog" aria-labelledby="dataConfirmLabel" aria-hidden="true"><div class="modal-dialog"><div class="modal-content"><div class="modal-header"><button type="button" class="close" data-dismiss="modal" aria-hidden="true">×</button><h3 id="dataConfirmLabel">Merci de confirmer</h3></div><div class="modal-body"></div><div class="modal-footer"><button class="btn" data-dismiss="modal" aria-hidden="true">Non</button><a class="btn btn-danger" id="dataConfirmOK">Oui</a></div></div></div></div>');
        }

        if ($(this).attr("successFunction"))
            $('#dataConfirmOK').attr('success', $(this).attr("successFunction"));

        $('#dataConfirmModal').find('.modal-body').text($(this).attr('data-confirm'));
        $('#dataConfirmOK').attr('href', href);
        $('#dataConfirmModal').modal({ show: true });

        return false;
    });

    $(document).on('click', '#dataConfirmOK', function (e) {
        e.preventDefault();
        $('#dataConfirmModal').modal('hide');
        var success = CallBackTest;
        if ($(this).attr("success"))
            success = PartialRefresh;

        $.ajax($(this).attr("href"), {
            method: 'get',
            dataType: "json",
            success: success,
            error: CallBackError
        });
    })

});

function CallBackTest(result) {
    if (result.success) {

        location.reload();
    }
    else {
        $('#myModalContent').html(result);
    }
}

function CallBackError(result) {
    $('#myModalContent').html(result);
}

function bindForm(dialog) {

    $('form', dialog).submit(function () {
        $.ajax({
            url: this.action,
            type: this.method,
            data: $(this).serialize(),
            success: function (result) {
                if (result.success) {
                    $('#myModal').modal('hide');
                    //Refresh
                    if (typeof isPartialRefresh != 'undefined') {
                        PartialRefresh();
                    }
                    else {
                        location.reload();
                    }


                } else {
                    $('#myModalContent').html(result);
                    bindForm(dialog);
                }
            }
        });
        return false;
    });
}