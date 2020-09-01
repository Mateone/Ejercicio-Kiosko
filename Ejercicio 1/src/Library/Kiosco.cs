using System;

namespace Expert_SRP
{
    public class Kiosco
    {
        // la clase Kiosko tiene dos motivos para cambiar por lo cual no cumple con el SRP
        // Pienso que convertir a pesos debería ser tarea de otra clase, ya que en caso de hacer
        //el cambio a otra moneda tendría que cambiar. Mientras que la responsabilidad calcular el precio del alfajor,
        //debería ser de la clase Alfajor, que es la experta en los datos.
        public Boolean PuedeComprar(Alfajor a, Double dinero, String moneda) 
        {
            CambioDeMoneda change = new CambioDeMoneda();
            Double pesos = change.ConvertirDolaresAPesos(dinero, moneda);
            return pesos >= a.PrecioTotal;
        }
    }
}