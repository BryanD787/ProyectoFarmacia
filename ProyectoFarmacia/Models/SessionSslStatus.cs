using System;
using System.Collections.Generic;

namespace ProyectoFarmacia.Models;

public partial class SessionSslStatus
{
    public ulong ThreadId { get; set; }

    public string? SslVersion { get; set; }

    public string? SslCipher { get; set; }

    public string? SslSessionsReused { get; set; }
}
