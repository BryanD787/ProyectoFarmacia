using System;
using System.Collections.Generic;

namespace ProyectoFarmacia.Models;

public partial class MemoryByUserByCurrentByte
{
    public string? User { get; set; }

    public decimal? CurrentCountUsed { get; set; }

    public string? CurrentAllocated { get; set; }

    public string? CurrentAvgAlloc { get; set; }

    public string? CurrentMaxAlloc { get; set; }

    public string? TotalAllocated { get; set; }
}
