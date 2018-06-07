$(function () {
    var docTypeId = getUrlParameter('docTypeId');
    getDocumentsByMasterId(docTypeId);
});

function getDocumentsByMasterId(id) {
    $.ajax({
        type: 'GET',
        url: base_path + 'Home/GetMasterDoctype?docTypeId=' + id,
        async: false,
        success: function (data) {
            if (data) {
                genarateDocumentDetail(data);
            } else {
                alert('fail');
            }
        },
        error: function (data) {
            alert('error');
        }
    });
}

function genarateDocumentDetail(data) {

}