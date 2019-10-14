$(document).ready(function () {
    $("#DeleteButton").click(function () {
        var id = $("#textId").val();
        $.ajax({
            url: "/api/InsurancePolicy/" + id,
            type: 'delete',
            statusCode: {
                404: function () {
                    alert('Insurance Policy not found.');
                },
                200: function () {
                    alert('Insurance Policy successfully deleted.');
                },
                500: function () {
                    alert('Error occurred trying to delete the Insurance Policy.');
                }
            }
        }).done(function () {
        });
    });
});