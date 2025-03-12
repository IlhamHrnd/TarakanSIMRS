function backToList() {
    window.history.back();
}

const ctx = document.getElementById('myChart').getContext('2d');
new Chart(ctx, {
    type: 'bar',
    data: {
        labels: ['Red', 'Blue', 'Yellow', 'Green', 'Purple', 'Orange'],
        datasets: [{
            label: 'Votes',
            data: [12, 19, 3, 5, 2, 3],
            backgroundColor: [
                'rgba(255, 99, 132, 0.2)',
                'rgba(54, 162, 235, 0.2)',
                'rgba(255, 206, 86, 0.2)',
                'rgba(75, 192, 192, 0.2)',
                'rgba(153, 102, 255, 0.2)',
                'rgba(255, 159, 64, 0.2)'
            ],
            borderColor: [
                'rgba(255, 99, 132, 1)',
                'rgba(54, 162, 235, 1)',
                'rgba(255, 206, 86, 1)',
                'rgba(75, 192, 192, 1)',
                'rgba(153, 102, 255, 1)',
                'rgba(255, 159, 64, 1)'
            ],
            borderWidth: 1
        }]
    },
    options: {
        scales: {
            y: {
                beginAtZero: true
            }
        }
    }
});

$(document).ready(function () {
    $('#example').DataTable();
});

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
});