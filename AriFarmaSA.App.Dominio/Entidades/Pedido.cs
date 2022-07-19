using System;
namespace AriFarmaSA.App.Dominio
{
    public class Pedido
    {
        public int PedidoId{get;set;}
        public List<Producto> Productos{get;set;}
        public int Cantidad{get;set;}
        public int Valor{get;set;}
        public DateTime FechaPedido{get;set;}
        
        // Llave Foranea
        public Distribuidor Distribuidor{get;set;}
    }
}
