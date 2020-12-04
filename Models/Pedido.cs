using System;

namespace Restaurant
{
    public class Pedido
    {
        public int idPedido { get; set; }
        public string Producto { get; set; }
        public string Observaciones { get; set; }
        public Decimal Total { get; set; }

    }
}