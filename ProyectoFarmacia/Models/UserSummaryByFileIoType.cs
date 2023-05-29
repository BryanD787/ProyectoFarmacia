using System;
using System.Collections.Generic;

namespace ProyectoFarmacia.Models;

public partial class UserSummaryByFileIoType
{
    public string? User { get; set; }

    public string EventName { get; set; } = null!;

    public ulong Total { get; set; }

    public string? Latency { get; set; }

    public string? MaxLatency { get; set; }
}
