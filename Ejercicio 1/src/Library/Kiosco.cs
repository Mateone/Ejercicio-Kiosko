using System;

namespace Expert_SRP
{
    public class Kiosco
    {
        public Boolean PuedeComprar(Alfajor a, Double dinero, String moneda) 
        {
            CambioDeMoneda change = new CambioDeMoneda();
            Double pesos = change.ConvertirDolaresAPesos(dinero, moneda);
            return pesos >= a.PrecioTotal;
        }
    }
}