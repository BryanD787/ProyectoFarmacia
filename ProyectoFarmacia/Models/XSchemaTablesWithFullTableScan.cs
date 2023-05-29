using System;
using System.Collections.Generic;

namespace ProyectoFarmacia.Models;

public partial class XSchemaTablesWithFullTableScan
{
    public string? ObjectSchema { get; set; }

    public string? ObjectName { get; set; }

    public ulong RowsFullScanned { get; set; }

    public ulong Latency { get; set; }
}
