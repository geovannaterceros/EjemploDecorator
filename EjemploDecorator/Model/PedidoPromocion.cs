using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploDecorator.Model
{
    public class PedidoPromocion : Pedido
    {
        //Tiene un descuento del 10%
        public override double TotalPedido()
        {

            return productos.Sum(x => x.Total) - ((productos.Sum(x => x.Total)) * 0.1);
        }
    }
}
