using System;
using System.Collections.Generic;

namespace ProyectoFarmacia.Models;

public partial class Producto
{
    public int IdProducto { get; set; }

    public string Nombre { get; set; } = null!;

    public string Tipo { get; set; } = null!;

    public int Cantidad { get; set; }

    public int Minimo { get; set; }

    public decimal Precio { get; set; }

    public virtual ICollection<Venta> Venta { get; set; } = new List<Venta>();
}
