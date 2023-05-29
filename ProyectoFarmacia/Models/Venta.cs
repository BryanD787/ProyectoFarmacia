using System;
using System.Collections.Generic;

namespace ProyectoFarmacia.Models;

public partial class Venta
{
    public int Id { get; set; }

    public int ProductoId { get; set; }

    public int Cantidad { get; set; }

    public decimal Precio { get; set; }

    public decimal Total { get; set; }

    public virtual Producto Producto { get; set; } = null!;
}
