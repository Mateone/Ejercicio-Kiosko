using System;
using System.IO;

namespace SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            FileReader filereader = new FileReader();
            Board board = new Board();
            BoardPrinter boardprinter = new BoardPrinter();
            bool[,] x = filereader.MakeBoard(@"C:\Users\FIT\Ejercicio-Kiosko\Ejercicio4\src\Library\Prueba.txt");
            bool[,] y = board.GameLogic(x);
            boardprinter.PrintBoard(y);
        }
    }
}
