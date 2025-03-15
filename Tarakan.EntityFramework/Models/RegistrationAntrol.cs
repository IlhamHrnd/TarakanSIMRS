using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class RegistrationAntrol
{
    public string AppointmentNo { get; set; } = null!;

    public string RegistrationNo { get; set; } = null!;

    public bool? IsTaskOneSent { get; set; }

    public DateTime? TaskOneSentDateTime { get; set; }

    public byte? TaskOneSentAttempt { get; set; }

    public string? TaskOneResponse { get; set; }

    public bool? IsTaskTwoSent { get; set; }

    public DateTime? TaskTwoSentDateTime { get; set; }

    public byte? TaskTwoSentAttempt { get; set; }

    public string? TaskTwoResponse { get; set; }

    public bool? IsTaskThreeSent { get; set; }

    public DateTime? TaskThreeSentDateTime { get; set; }

    public byte? TaskThreeSentAttempt { get; set; }

    public string? TaskThreeResponse { get; set; }

    public bool? IsTaskFourSent { get; set; }

    public DateTime? TaskFourSentDateTime { get; set; }

    public byte? TaskFourSentAttempt { get; set; }

    public string? TaskFourResponse { get; set; }

    public bool? IsTaskFiveSent { get; set; }

    public DateTime? TaskFiveSentDateTime { get; set; }

    public byte? TaskFiveSentAttempt { get; set; }

    public string? TaskFiveResponse { get; set; }

    public bool? IsTaskSixSent { get; set; }

    public DateTime? TaskSixSentDateTime { get; set; }

    public byte? TaskSixSentAttempt { get; set; }

    public string? TaskSixResponse { get; set; }

    public bool? IsTaskSevenSent { get; set; }

    public DateTime? TaskSevenSentDateTime { get; set; }

    public byte? TaskSevenSentAttempt { get; set; }

    public string? TaskSevenResponse { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public DateTime? LastCreateDateTime { get; set; }

    public string? LastCreateByUserId { get; set; }
}
