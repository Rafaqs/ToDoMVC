$(document).ready(function () {

    $.ajax({
        url: '/Todoes/BuildToDoTable',
        success: function (result) {
            $('#tableDiv').html(result);
        
        }
    });
});