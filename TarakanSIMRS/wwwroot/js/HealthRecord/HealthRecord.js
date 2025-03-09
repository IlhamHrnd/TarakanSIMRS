function myFunction() {
    alert("Hello! I am an alert box!");
}

//Partial View
$(document).ready(function () {
    $("#loadPartialFilter").click(function () {
        $.get("/Tarakan/HealthRecord/FilterHealthRecord", function (data) {
            $("#filterContent").html(data);
            $("#filterModal").modal("show");
        });
    });
});

//View
function gotoAddUrl(regType, regNo, parId, suId, roomId, patId, isDocDuty) {
    alert("Hello! I am an alert box!");
}