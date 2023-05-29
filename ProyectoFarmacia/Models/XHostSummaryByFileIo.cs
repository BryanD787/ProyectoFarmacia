using System;
using System.Collections.Generic;

namespace ProyectoFarmacia.Models;

public partial class XHostSummaryByFileIo
{
    public string? Host { get; set; }

    public decimal? Ios { get; set; }

    public decimal? IoLatency { get; set; }
}
