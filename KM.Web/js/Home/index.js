$(function () {
    getMasterDoctype();
});

function getMasterDoctype() {
    $.ajax({
        type: 'GET',
        url: base_path + 'Home/GetMasterDoctype',
        async: false,
        success: function (data) {
            if (data) {
                createTable(data);
            } else {
                alert('fail');
            }
        },
        error: function (data) {
            alert('error');
        }
    });
}

function createTable(data) {
    if (data) {
        $('#doc_type_table > tbody').empty();
        $.each(data, function () {
            var html = "<tr>";
            html = html + "<td>" + this.FIS_MST_DOC_TYPE_ID + "</td>";
            html = html + "<td>" + this.FIS_MST_DOC_TYPE_NAME + "</td>";
            html = html + "<td>" + this.FIS_MST_DOC_TYPE_DETAIL + "</td>";
            html = html + "</tr>";
            $('#doc_type_table > tbody:last').append(html);
        });
    }
}