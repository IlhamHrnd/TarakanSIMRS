function backToList() {
    window.location.href = "/Tarakan/HealthRecord/HealthRecord";
}

$(document).ready(function () {
    $.ajax({
        url: "/Tarakan/Patient/PatientInfo",
        type: "GET",
        contentType: "application/json",
        data: { regNo: regNo },
        success: function (data) {
            $("#patientInfo").html(data);
        },
        error: function (xhr, status, error) {
            console.error("Error loading PatientController:", error);
        }
    });
});