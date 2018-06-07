$(function () {
    initTinyMCE();
    tinymce.init({
        selector: 'textarea',
        height: 500,
        menubar: false,
        plugins: [
          'advlist autolink lists link image charmap print preview anchor textcolor',
          'searchreplace visualblocks code fullscreen',
          'insertdatetime media table contextmenu paste code help wordcount'
        ],
        toolbar: 'insert | undo redo |  formatselect | bold italic backcolor  | alignleft aligncenter alignright alignjustify | bullist numlist outdent indent | removeformat | help',
        content_css: [
          '//fonts.googleapis.com/css?family=Lato:300,300i,400,400i',
          '//www.tinymce.com/css/codepen.min.css']
    });
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

function initTinyMCE() {
    
}