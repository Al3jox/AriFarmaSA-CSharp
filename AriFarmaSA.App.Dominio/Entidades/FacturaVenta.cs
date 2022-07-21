using System;
namespace AriFarmaSA.App.Dominio
{
    public class FacturaVenta
    {
        public int FacturaId{get;set;}
        public DateTime FechaVenta{get;set;}
        public int Cantidad{get;set;}
        public int Valor{get;set;}
        
        // Propiedad navigacional hacia la tabla "FacturaVenta"
        public List<Producto> Producto{get;set;}
    }
}
