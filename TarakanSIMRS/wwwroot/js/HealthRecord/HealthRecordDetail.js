$(document).ready(function () {
    $.ajax({
        url: "/Tarakan/Patient/PatientInfo",
        type: "GET",
        contentType: "application/json",
        data: { },
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
        data: { },
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
        data: { },
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
        data: { },
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
        data: { isModeText: isModeText },
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
        data: { },
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
        data: { },
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
        data: { },
        success: function (data) {
            $("#patientVitalSign").html(data);
        },
        error: function (xhr, status, error) {
            console.error("Error loading PatientController:", error);
        }
    });

    $.ajax({
        url: "/Tarakan/ParamedicTeam/ParamedicTeam",
        type: "GET",
        contentType: "application/json",
        data: {},
        success: function (data) {
            $("#paramedicTeam").html(data);
        },
        error: function (xhr, status, error) {
            console.error("Error loading ParamedicTeamController:", error);
        }
    });

    $.ajax({
        url: "/Tarakan/Registration/RegistrationRefer",
        type: "GET",
        contentType: "application/json",
        data: {},
        success: function (data) {
            $("#registrationRefer").html(data);
        },
        error: function (xhr, status, error) {
            console.error("Error loading RegistrationController:", error);
        }
    });

    $.ajax({
        url: "/Tarakan/Integrated/IntegratedNote",
        type: "GET",
        contentType: "application/json",
        data: {},
        success: function (data) {
            $("#integratedNote").html(data);
            $.getScript("/js/Integrated/IntegratedNote.js");
        },
        error: function (xhr, status, error) {
            console.error("Error loading IntegratedController:", error);
        }
    });

    $.ajax({
        url: "/Tarakan/Prescription/PrescriptionHistory",
        type: "GET",
        contentType: "application/json",
        data: {},
        success: function (data) {
            $("#prescriptionHistory").html(data);
            $.getScript("/js/Prescription/PrescriptionHistory.js");
        },
        error: function (xhr, status, error) {
            console.error("Error loading PrescriptionController:", error);
        }
    });
});

function backToList() {
    window.history.back();
}