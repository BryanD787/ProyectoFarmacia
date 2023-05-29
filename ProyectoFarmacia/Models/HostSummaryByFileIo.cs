using System;
using System.Collections.Generic;

namespace ProyectoFarmacia.Models;

public partial class HostSummaryByFileIo
{
    public string? Host { get; set; }

    public decimal? Ios { get; set; }

    public string? IoLatency { get; set; }
}
