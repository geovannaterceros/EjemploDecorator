using EjemploDecorator.Decorator;
using EjemploDecorator.Model;
using System;
using System.Collections.Generic;

namespace EjemploDecorator
{
    public class Principal
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inicio");

            //Productos a comprar
            List<Producto> productos = new List<Producto>()
            {
                new Producto { Nombre = "Arroz", Precio = 10, Cantidad = 2, Total = 20},
                new Producto { Nombre = "Chorizo Sofia", Precio = 20, Cantidad = 3, Total = 60}
            };


            var pedidoNormal = new PedidoNormal() 
            {   productos = productos

            };
            var totalPedidoNormal = pedidoNormal.TotalPedido();
            Console.WriteLine("Pedido Normal:" + totalPedidoNormal);
            Console.WriteLine();

            var pedidoPromocion = new PedidoPromocion()
            {
                productos = productos

            };
            var totalPedidoPromocion = pedidoPromocion.TotalPedido();
            Console.WriteLine("Pedido Promocion:" + totalPedidoPromocion);
            Console.WriteLine();

            var pedidoPromocionNavidad = new PedidoPromocionNavidad(pedidoNormal)
            {
                productos = productos

            };
            var totalPedidoPromocionNavidad = pedidoPromocionNavidad.TotalPedido();
            Console.WriteLine("Pedido Promocion Navidad:" + totalPedidoPromocionNavidad);
            Console.WriteLine("Fin del Programa");

        }
    }
}
