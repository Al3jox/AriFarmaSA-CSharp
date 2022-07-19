using System;
namespace AriFarmaSA.App.Dominio
{
    public class Producto
    {

        public int ProductoId{get;set;}
        public string Nombre{get;set;}
        public string Descripcion{get;set;}
        public int Cantidad{get;set;}
        public string Categoria{get;set;}
        public bool RequiereFormula{get;set;}
        public DateTime FechaVencimiento{get;set;}
        public TipoSuministro TipoSuministro{get;set;}
        public int PrecioCompra{get;set;}
        public int PrecioVenta{get;set;}

        // Relación de agregación

        public Pedido lote = null;

        public void AdicionaLotePedido(Pedido lPedido){
            if(lPedido != null)
            lote = lPedido;
        }

    }
}