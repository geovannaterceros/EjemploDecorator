using EjemploDecorator.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace EjemploDecorator.Decorator
{
    public class PedidoPromocionNavidad : BaseDecorator
    {
        public PedidoPromocionNavidad(Pedido pedido) : base(pedido) 
        { }

        //20% de descuento
        public override double TotalPedido() 
        {
            return base.TotalPedido() - (base.TotalPedido() * 0.2);
        }
    }
}
