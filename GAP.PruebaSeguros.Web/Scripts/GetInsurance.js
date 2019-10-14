$(document).ready(function () {    
    $("#GetButton").click(function () {
        var id = $("#textId").val();
        $.ajax({
            url: "/api/InsurancePolicy/" + id,
            type: 'get',
            statusCode: {
                404: function () {
                    alert('Insurance Policy not found');
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