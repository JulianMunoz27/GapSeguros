$(document).ready(function () {
    $("#PosttButton").click(function () {
        var insurance = { Name: $("#Name").val(), Description: $("#Description").val(), StartDate: $("#StartDate").val(), CoveringMonths: $("#CoveringMonths").val(), price: $("#price").val(), RiskType: $("#RiskType").val(), CoveringTypes: $("#CoveringTypes").val(), CoveringPercentage: $("#CoveringPercentage").val()};
        $.ajax({
            url: "/api/InsurancePolicy",
            type: 'post',
            data: insurance,
            statusCode: {
                201: function () {
                    alert('Insurance created successfully.');
                },
                400: function () {
                    alert('Covering percentage must be below 50% when risk type is high.');
                },
                500: function () {
                    alert('Error creating Insurance Policy.');
                }
            }
        }).done(function () {
        });
    });
});