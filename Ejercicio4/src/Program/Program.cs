using System;
using System.IO;

namespace SRP
{
    
    class Program
    {
        static void Main(string[] args)
        {
            bool[,] board = FileReader.MakeBoard(@"C:\Users\FIT\Ejercicio-Kiosko\Ejercicio4\src\Library\Prueba.txt");
            bool[,] board1 = Board.GameLogic();
            BoardPrinter.PrintBoard(board1);
        }
    }
}
