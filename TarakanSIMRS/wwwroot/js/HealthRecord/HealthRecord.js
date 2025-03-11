function myFunction() {
    alert("Hello! I am an alert box!");
}

$(document).ready(function () {
    $('#myTable').DataTable();
});

const ctx = document.getElementById('myChart');
new Chart(ctx, {
    type: 'line',
    data: {
        labels: ['Red', 'Blue', 'Yellow', 'Green', 'Purple', 'Orange'],
        datasets: [{
            label: '# of Votes',
            data: [12, 19, 3, 5, 2, 3],
            borderWidth: 1
        }]
    },
    options: {
        scales: {
            y: {
                beginAtZero: true
            }
        },
        animations: {
            tension: {
                duration: 1000,
                easing: 'linear',
                from: 1,
                to: 0,
                loop: true
            }
        },
        interaction: {
            mode: 'index'
        }
    }
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

    if (regType) {
        params.push("regType=" + encodeURIComponent(regType));
    }

    if (regNo) {
        params.push("regNo=" + encodeURIComponent(regNo));
    }

    if (parId) {
        params.push("parId=" + encodeURIComponent(parId));
    }

    if (suId) {
        params.push("suId=" + encodeURIComponent(suId));
    }

    if (roomId) {
        params.push("roomId=" + encodeURIComponent(roomId));
    }

    if (patId) {
        params.push("patId=" + encodeURIComponent(patId));
    }

    if (isDocDuty) {
        params.push("isDocDuty=" + encodeURIComponent(isDocDuty));
    }

    if (params.length > 0) {
        window.location.href = url + params.join("&");
    } else {
        alert("Please enter at least one filter criteria.");
    }
}