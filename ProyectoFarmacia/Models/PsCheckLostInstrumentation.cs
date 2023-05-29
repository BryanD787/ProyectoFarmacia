using System;
using System.Collections.Generic;

namespace ProyectoFarmacia.Models;

public partial class PsCheckLostInstrumentation
{
    public string VariableName { get; set; } = null!;

    public string? VariableValue { get; set; }
}
