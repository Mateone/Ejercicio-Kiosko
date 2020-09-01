using System;

namespace Expert_SRP
{
    public class Alfajor

    // La clase Alfajor cumple con el SRP ya que su unico motivo de cambiar es que
    // cambien sus ingredientes o su valor.
    {
        public Alfajor(double precioMasa, double precioDulce)
        {
            this.PrecioDulce = precioDulce;
            this.PrecioMasa = precioMasa;
        }
        public Double PrecioDulce {get;set;}
        public Double PrecioMasa {get; set;}
    }
}