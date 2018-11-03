$(document).ready(function () {
    $.fn.dataTable.defaults.column.asSorting = ['asc'];
    var table = $('#table').DataTable({
        "order": [[0, "asc"]],
        "fnRowCallback": function (nRow, aData, ) {
            if (aData[1] > 3)
                $(nRow).css('background-color', 'red');
        },
        "bPaginate": true,
        "bLengthChange": false,
        "bFilter": false,
        "bInfo": false,
        "bAutoWidth": false
    });
    table.page.len(5).draw();
});
