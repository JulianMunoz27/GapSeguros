$(document).ready(function () {
    $("#GetButton").click(function () {
        var id = $("#textId").val();
        $.ajax({
            url: "/api/InsurancePolicy/" + id,
            type: 'get',
            statusCode: {
                404: function () {
                    alert('Insurance Policy not found.');
                }
            }
        }).done(function (res) {
            $("#Name").val(res.Name);
            $("#Description").val(res.Description);
            $("#StartDate").val(res.StartDate);
            $("#CoveringMonths").val(res.CoveringMonths);
            $("#price").val(res.price);
            $("#RiskType").val(res.RiskType);
            $("#CoveringTypes").val(res.CoveringTypes);
            $("#CoveringPercentage").val(res.CoveringPercentage);
        });
    });

    $("#PutButton").click(function () {
        var insurance = { Id: $("#textId").val(), Name: $("#Name").val(), Description: $("#Description").val(), StartDate: $("#StartDate").val(), CoveringMonths: $("#CoveringMonths").val(), price: $("#price").val(), RiskType: $("#RiskType").val(), CoveringTypes: $("#CoveringTypes").val(), CoveringPercentage: $("#CoveringPercentage").val() };
        $.ajax({
            url: "/api/InsurancePolicy",
            type: 'put',
            data: insurance,
            statusCode: {
                200: function () {
                    alert('Insurance Policy successfully modified.');
                },
                500: function () {
                    alert('Error modifying Insurance Policy.');
                }
            }
        }).done(function (res) {
            $("#Name").val(res.Name);
            $("#Description").val(res.Description);
            $("#StartDate").val(res.StartDate);
            $("#CoveringMonths").val(res.CoveringMonths);
            $("#price").val(res.price);
            $("#RiskType").val(res.RiskType);
            $("#CoveringTypes").val(res.CoveringTypes);
            $("#CoveringPercentage").val(res.CoveringPercentage);
        });
    });
});