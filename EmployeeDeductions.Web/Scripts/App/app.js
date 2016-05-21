/// <reference path="jquery.d.ts"/>
/// <reference path="toastr.d.ts"/>
$(document).ready(function () {
    var CalculatedBenefitCosts = (function () {
        function CalculatedBenefitCosts() {
        }
        return CalculatedBenefitCosts;
    }());
    var Dependent = (function () {
        function Dependent() {
        }
        return Dependent;
    }());
    toastr.options = {
        "positionClass": 'toast-top-left'
    };
    function getParameterByName(name) {
        var match = RegExp('[?&]' + name + '=([^&]*)').exec(window.location.search);
        return match && decodeURIComponent(match[1].replace(/\+/g, ' '));
    }
    function displayCalculatedCosts(annualSalary, totalBenefitCost) {
        $("#calculatedBenefits").empty();
        var r = "/(\d)(?=(\d{3})+\.)/g";
        var calculatedBenefitCosts = new CalculatedBenefitCosts();
        calculatedBenefitCosts.annualSalary = "$" + annualSalary.toFixed(2).replace(r, "$1,").toString();
        calculatedBenefitCosts.totalDeductions = "$" + totalBenefitCost.toFixed(2).replace(r, "$1,").toString();
        calculatedBenefitCosts.salaryAfterDeductions = "$" + (annualSalary - totalBenefitCost).toFixed(2).replace(r, "$1,").toString();
        //append data
        $("#calculatedBenefits").append("<div><h3>Annual Salary: " + calculatedBenefitCosts.annualSalary + " </h3></div><div><h3>Total Benefits Cost: " + calculatedBenefitCosts.totalDeductions +
            " </h3></div><div><h3>Salary After Benefits: " + calculatedBenefitCosts.salaryAfterDeductions + "</h3></div>");
    }
    //handle calculate benefits click
    $(".btn-calculate").click(function () {
        var employeeId = this.id;
        $.ajax({
            type: "GET",
            url: "/employee/CalculateBenefitsCost?employeeId=" + employeeId,
            contentType: "application/json",
            dataType: "json",
            success: function (data) {
                var annualSalary = data.Pay;
                var totalBenefitCost = data.TotalBenefitCost;
                displayCalculatedCosts(data.Pay, data.TotalBenefitCost);
            },
            error: function (err) {
                console.log(err);
            }
        });
    });
    //handle add dependent button click
    $("#btnAddDependent").click(function () {
        var dependent = new Dependent();
        dependent.employeeId = getParameterByName("employeeId");
        dependent.firstName = $("#txtFirstname").val();
        dependent.lastName = $("#txtLastname").val();
        dependent.benefitCost = 0;
        if (dependent.firstName == "" || dependent.lastName == "") {
            toastr.error("First Name and Last Name is required");
            return;
        }
        $.ajax({
            type: "POST",
            url: "/dependent/Create/",
            data: dependent,
            success: function (data) {
                toastr.success("Dependent added successfully");
                $("#txtFirstname").val("");
                $("#txtLastname").val("");
                $("#btnAddDependent").html("+ Add Another");
            },
            error: function (err) {
                console.log(err);
                toastr.error("Houston we have a problem...");
            }
        });
    });
});
//# sourceMappingURL=app.js.map