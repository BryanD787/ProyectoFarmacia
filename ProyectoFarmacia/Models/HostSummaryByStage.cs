using System;
using System.Collections.Generic;

namespace ProyectoFarmacia.Models;

public partial class HostSummaryByStage
{
    public string? Host { get; set; }

    public string EventName { get; set; } = null!;

    public ulong Total { get; set; }

    public string? TotalLatency { get; set; }

    public string? AvgLatency { get; set; }
}
