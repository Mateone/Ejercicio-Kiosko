using System;

namespace Expert_SRP
{
    public class Alfajor

    // La clase Alfajor cumple con el SRP ya que su unico motivo de cambiar es que
    // cambien sus ingredientes o su valor. También debería implementar el metodo "PuedeComprar" porque es el experto en la información (patrón expert)
    {
        public Alfajor(double precioMasa, double precioDulce)
        {
            this.PrecioDulce = precioDulce;
            this.PrecioMasa = precioMasa;
            this.PrecioTotal = precioMasa + precioDulce;
        }
        public Double PrecioDulce {get;set;}
        public Double PrecioMasa {get; set;}
        public Double PrecioTotal {get; set;}
    }
}