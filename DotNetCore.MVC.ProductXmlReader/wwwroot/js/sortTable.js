$(document).ready(function () {
    var table = $('#table').DataTable({
        "order": [[0, "asc"]],
        "fnRowCallback": function (nRow, aData, ) {
            if (aData[1] > 3)
                $(nRow).css('background-color', 'red');
        },
        "bPaginate": false,
        "bLengthChange": false,
        "bFilter": false,
        "bInfo": false,
        "bAutoWidth": false
    });
});
