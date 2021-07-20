using EjemploDecorator.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace EjemploDecorator.Decorator
{
    public abstract class BaseDecorator : Pedido
    {
        protected Pedido pedido;

        public BaseDecorator( Pedido pedido) 
        {
            this.pedido = pedido;
        }

        public override double TotalPedido()
        {
            return pedido.TotalPedido();
        }
    }
}
