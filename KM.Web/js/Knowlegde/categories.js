$(function () {
    getCategories();
});
function getCategories() {
    $.ajax({
        type: 'GET',
        url: base_path + 'Home/GetMasterDoctype',
        async: false,
        success: function (data) {
            if (data) {
                console.log(data);
                bindCategories(data);
            } else {
                alert('fail');
            }
        },
        error: function (data) {
            alert('error');
        }
    });
}

function bindCategories(list) {
    if (list) {
        var html = "";
        $.each(list, function (key, val) {
            var color = "";
            if (key == 0)
                color = "blue";
            if (key == 1)
                color = "success";
            if (key == 2)
                color = "purple";
            if (key == 3)
                color = "red";

            if (key % 2 == 0) // even number
            {
                html = html + '<div class="row">';
                html = html + '<div class="col-md-6">';
                html = html + '<div class="info-box">';
                html = html + '<a target="_blank" href="' + base_path + 'Knowledge/Documents?docTypeId=' + this.FIS_MST_DOC_TYPE_ID + '">';
                html = html + '<span class="info-box-icon bg-' + color + '"><i class="fa fa-file"></i></span>';
                html = html + '<div class="info-box-content">';
                html = html + '<span class="info-box-number">' + this.FIS_MST_DOC_TYPE_NAME + '</span>';
                html = html + '<span class="info-box-text">Knowledge</span>';
                html = html + '</div>';
                html = html + '</a>';
                html = html + '</div>';
                html = html + '</div>';
            }
            else
            {
                html = html + '<div class="col-md-6">';
                html = html + '<div class="info-box">';
                html = html + '<a target="_blank" href="' + base_path + 'Knowledge/Documents?docTypeId=' + this.FIS_MST_DOC_TYPE_ID + '">';
                html = html + '<span class="info-box-icon bg-' + color + '"><i class="fa fa-file"></i></span>';
                html = html + '<div class="info-box-content">';
                html = html + '<span class="info-box-number">' + this.FIS_MST_DOC_TYPE_NAME + '</span>';
                html = html + '<span class="info-box-text">Knowledge</span>';
                html = html + '</div>';
                html = html + '</a>';
                html = html + '</div>';
                html = html + '</div>';
                html = html + '</div>';
            }
        });
        $('#categories_body').html(html);
    }
}