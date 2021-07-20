using System;
using System.Collections.Generic;
using System.Text;

namespace EjemploDecorator.Model
{
    public abstract class Pedido
    {
        public List<Producto> productos { get; set; }

        public abstract double TotalPedido();

    }
}
