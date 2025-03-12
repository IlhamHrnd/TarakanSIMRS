function myFunction() {
    alert("Hello! I am an alert box!");
}

$(document).ready(function () {
    $('#listTable').DataTable();
});

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
    let url = "/Tarakan/HealthRecord/HealthRecordDetail?";
    let params = [];

    if (regType) params.push("regType=" + encodeURIComponent(regType));
    if (regNo) params.push("regNo=" + encodeURIComponent(regNo));
    if (parId) params.push("parId=" + encodeURIComponent(parId));
    if (suId) params.push("suId=" + encodeURIComponent(suId));
    if (roomId) params.push("roomId=" + encodeURIComponent(roomId));
    if (patId) params.push("patId=" + encodeURIComponent(patId));
    if (isDocDuty) params.push("isDocDuty=" + encodeURIComponent(isDocDuty));

    window.location.href = url + params.join("&");
}