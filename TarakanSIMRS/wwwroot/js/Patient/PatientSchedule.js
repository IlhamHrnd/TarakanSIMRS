$(document).ready(function () {
    $("#scheduleYear").hide();
    $("#scheduleMonth").hide();
    $("#scheduleDay").show();
    $("#selectScheduleType").change(function () {
        var selectedValue = $(this).val();
        switch (selectedValue) {
            case "year":
                $("#scheduleYear").show();
                $("#scheduleMonth").hide();
                $("#scheduleDay").hide();
                break;

            case "month":
                $("#scheduleYear").hide();
                $("#scheduleMonth").show();
                $("#scheduleDay").hide();
                break;

            case "day":
                $("#scheduleYear").hide();
                $("#scheduleMonth").hide();
                $("#scheduleDay").show();
                break;

            default:
                $("#scheduleYear").hide();
                $("#scheduleMonth").hide();
                $("#scheduleDay").hide();
                break;
        }
    });
});

function AddSchedule() {
    var scheduleName = $('#selectScheduleName :selected').val();
    var scheduleType = $('#selectScheduleType :selected').val();
    var scheduleYear = $('#scheduleYear :selected').val();
    var scheduleMonth = $('#selectScheduleMonth :selected').val();
    var scheduleFrom = $('#selectScheduleFrom').val();
    var scheduleTo = $('#selectScheduleTo').val();

    if (scheduleName == "") {
        alert('Schedule Name is required');
        return;
    }

    switch (scheduleType) {
        case "year":
            if (scheduleYear == "") {
                alert('Schedule Year is required');
                return;
            }
            break;

        case "month":
            if (scheduleYear == "") {
                alert('Schedule Year is required');
                return;
            }

            if (scheduleMonth == "") {
                alert('Schedule Month is required');
                return;
            }
            break;

        case "day":
            if (scheduleFrom == "") {
                alert('Schedule From is required');
                return;
            }

            if (scheduleTo == "") {
                alert('Schedule To is required');
                return;
            }
            break;

        default:
            alert('Schedule Type is required');
            return;
            break;
    }

    $.ajax({
        url: "/Tarakan/Patient/AddSchedule",
        type: "GET",
        data: { itemId: scheduleName, type: scheduleType, year: scheduleYear, month: scheduleMonth, from: scheduleFrom, to: scheduleTo },
        success: function (response) {
            alert("Response: " + response);
        },
        error: function (xhr, status, error) {
            alert("Error: " + error);
        }
    });
}