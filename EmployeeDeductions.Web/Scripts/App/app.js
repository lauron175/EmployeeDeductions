function getCalculatedCosts() {
    var calculatedValues = { totalDeductions: 1, annualSalary: 2, salaryAfterDeductions: 3 };
    return calculatedValues;
}
function displayCalculatedCosts(calculatedBenefitCosts) {
    var button = document.getElementById("btnCalculateBenefitsCost");
    var calculatedResultsArea = document.getElementById("calculatedBenefits");
    button.onclick = function () {
        //ajax call
        calculatedResultsArea.innerHTML = "<div>" + calculatedBenefitCosts.annualSalary.toString() + " < /div><div>" + calculatedBenefitCosts.salaryAfterDeductions.toString() + " </div><div>" + calculatedBenefitCosts.totalDeductions.toString() + " < /div>";
    };
}
var calculatedValues = getCalculatedCosts();
displayCalculatedCosts(calculatedValues);
//# sourceMappingURL=app.js.map