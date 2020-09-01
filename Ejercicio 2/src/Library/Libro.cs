using System;

namespace SRP
{
    public class Libro
    {
        //El metodo "Libro" está bien asignado ya que la clase es la experta en la información,
        //pero en mi opinión el metodo "AlmacenarLibro" debería ser responsabilidad de otra clase, para cumplir con el SRP, y a su vez cumplir con el expert.
        //O sea, en este momento la clase tiene dos motivos por los cuales cambiar.
        //La responsabilidad de almacenar libros no debería ser del libro, sino de otra clase llamada "Biblioteca", por ejemplo.
        public string Titulo { get ; }
        public string Autor { get ; }
        public string Codigo { get ;  }
        public string SectorBiblioteca { get ; set; }
        public string EstanteBiblioteca { get ; set; }

        public Libro(String titulo, String autor, String codigo)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Codigo = codigo;
        }

        public void AlmacenarLibro(String sector, String estante)
        {
            this.SectorBiblioteca = sector;
            this.EstanteBiblioteca = estante;
        }

    }
}
