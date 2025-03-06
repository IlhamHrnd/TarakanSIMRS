using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PatientFace
{
    public string PatientId { get; set; }

    public int FacePositionXc { get; set; }

    public int FacePositionYc { get; set; }

    public int FacePositionW { get; set; }

    public float FacePositionAngle { get; set; }

    public int Eye1X { get; set; }

    public int Eye1Y { get; set; }

    public int Eye2X { get; set; }

    public int Eye2Y { get; set; }

    public byte[] Template { get; set; }

    public byte[] Image { get; set; }

    public byte[] FaceImage { get; set; }

    public DateTime? LastCreatedDateTime { get; set; }

    public string LastCreatedUserId { get; set; }

    public DateTime? LastUpdatedDateTime { get; set; }

    public string LastUpdatedUserId { get; set; }
}
