$(function () {
    var docTypeId = getUrlParameter('docTypeId');
    getDocumentsByMasterId(docTypeId);
});

function getDocumentsByMasterId(id) {
    $.ajax({
        type: 'GET',
        url: base_path + 'Home/GetDocumentDetailByMasterId',
        async: false,
        data: {
            'docTypeId': id
        },
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