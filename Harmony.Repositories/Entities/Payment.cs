using System;
using System.Collections.Generic;

namespace Harmony.Repositories.Entities;

public partial class Payment
{
    public int PaymentId { get; set; }

    public int? AppointmentId { get; set; }

    public DateTime PaymentDate { get; set; }

    public string? PaymentMethod { get; set; }

    public string? PaymentStatus { get; set; }

    public virtual Appointment? Appointment { get; set; }
}
