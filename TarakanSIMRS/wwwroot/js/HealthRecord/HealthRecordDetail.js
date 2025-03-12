function backToList() {
    window.history.back();
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

    $.ajax({
        url: "/Tarakan/Patient/PatientChronic",
        type: "GET",
        contentType: "application/json",
        data: { patId: patId },
        success: function (data) {
            $("#patientChronic").html(data);
        },
        error: function (xhr, status, error) {
            console.error("Error loading PatientController:", error);
        }
    });

    $.ajax({
        url: "/Tarakan/Patient/PatientRiskStatus",
        type: "GET",
        contentType: "application/json",
        data: { srRiskStatus: riskStatus },
        success: function (data) {
            $("#patientRiskStatus").html(data);
        },
        error: function (xhr, status, error) {
            console.error("Error loading PatientController:", error);
        }
    });

    $.ajax({
        url: "/Tarakan/Patient/PatientPathway",
        type: "GET",
        contentType: "application/json",
        data: { regNo: regNo },
        success: function (data) {
            $("#patientPathway").html(data);
        },
        error: function (xhr, status, error) {
            console.error("Error loading PatientController:", error);
        }
    });

    $.ajax({
        url: "/Tarakan/Patient/PatientBilling",
        type: "GET",
        contentType: "application/json",
        data: { regNo: regNo, isModeText: isModeText },
        success: function (data) {
            $("#patientBilling").html(data);
        },
        error: function (xhr, status, error) {
            console.error("Error loading PatientController:", error);
        }
    });

    $.ajax({
        url: "/Tarakan/Patient/PatientAllergy",
        type: "GET",
        contentType: "application/json",
        data: { patId: patId },
        success: function (data) {
            $("#patientAllergy").html(data);
        },
        error: function (xhr, status, error) {
            console.error("Error loading PatientController:", error);
        }
    });

    $.ajax({
        url: "/Tarakan/Patient/PatientDiagnoseSummary",
        type: "GET",
        contentType: "application/json",
        data: { regNo: regNo },
        success: function (data) {
            $("#patientDiagnose").html(data);
        },
        error: function (xhr, status, error) {
            console.error("Error loading PatientController:", error);
        }
    });

    $.ajax({
        url: "/Tarakan/Patient/PatientVitalSign",
        type: "GET",
        contentType: "application/json",
        data: { regNo: regNo, fromRegNo: fromRegNo },
        success: function (data) {
            $("#patientVitalSign").html(data);
        },
        error: function (xhr, status, error) {
            console.error("Error loading PatientController:", error);
        }
    });

    $.ajax({
        url: "/Tarakan/Integrated/IntegratedNote",
        type: "GET",
        contentType: "application/json",
        data: { },
        success: function (data) {
            $("#patientIntegratedNote").html(data);
        },
        error: function (xhr, status, error) {
            console.error("Error loading PatientController:", error);
        }
    });
});