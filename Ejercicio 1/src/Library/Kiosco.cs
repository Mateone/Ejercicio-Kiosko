using System;

namespace Expert_SRP
{
    public class Kiosco
    {
        // la clase Kiosko tiene dos motivos para cambiar por lo cual no cumple con el SRP
        // Pienso que convertir a pesos debería ser tarea de otra clase, ya que en caso de hacer
        //el cambio a otra moneda tendría que cambiar. Mientras que la responsabilidad de "puede comprar" tiene
        //más sentido que le pertenezca. 
        public Boolean PuedeComprar(Alfajor a, Double dinero, String moneda) 
        {
            Double pesos = ConvertirAPesos(dinero, moneda);
            return pesos >= a.PrecioDulce + a.PrecioMasa;
        }
        private Double ConvertirAPesos(Double dinero, String moneda)
        {
            if (moneda.Equals("U$S")) 
            {
                return dinero / 30;
            } 
            else if (moneda.Equals("$")) 
            {
                return dinero;
            }
            else 
            {
                return -1;
            }
        }
    }
}