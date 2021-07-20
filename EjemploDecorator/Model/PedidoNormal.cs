using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploDecorator.Model
{
    public class PedidoNormal : Pedido
    {
        public override double TotalPedido() {

            return productos.Sum(x => x.Total);
        }
    }
}
