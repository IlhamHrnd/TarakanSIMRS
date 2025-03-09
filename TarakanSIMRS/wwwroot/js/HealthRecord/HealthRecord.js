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