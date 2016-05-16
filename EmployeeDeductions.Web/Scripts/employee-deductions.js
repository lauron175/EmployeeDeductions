$(document).ready(function () {
    
    //handle calculate benefits click
    $("#btnCalculateBenefitsCost").click(function () {                

        $.ajax({
            type: "GET",
            url: "/employee/CalculateBenefitsCost",            
            contentType: "application/json",
            dataType: "json",
            success: function (data) {
                $("#calculatedBenefits").append(data.TotalDeductions);
            },
            error: function (err) {
                alert(err);
            }
        });
        }
    );
})
    